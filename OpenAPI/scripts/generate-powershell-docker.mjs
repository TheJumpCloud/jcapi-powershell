#!/usr/bin/env node
/**
 * OpenAPI Generator — PowerShell SDKs via Docker
 *
 * Invokes `docker run` with the official openapitools image (version from
 * `openapitools.json`). The OpenAPI/ folder is bind-mounted at `/local` so
 * `-i` / `-o` paths work inside the container. The npm `openapi-generator-cli`
 * package is not used here (it does not rewrite paths correctly for Docker mode).
 *
 * Host prerequisites: Node.js (to run this script) and Docker (daemon running).
 * Java and openapi-generator-cli on the host are not required — the JVM and
 * generator run inside the container.
 *
 * Templates: generation uses `-t /local/templates/powershell` so comment-based
 * help and the verbose OAS description header are omitted from .ps1 files.
 *
 * Pagination: generation uses `--enable-post-process-file` with a queue script
 * inside the container; after each target, `Apply-OasPagination.ps1` runs on the
 * host (PowerShell 7+) because the generator image does not include pwsh.
 */
import { existsSync, readFileSync, unlinkSync, readdirSync, writeFileSync } from "node:fs";
import { chmodSync } from "node:fs";
import { dirname, join, resolve } from "node:path";
import { spawnSync } from "node:child_process";
import { fileURLToPath } from "node:url";

/** @returns {boolean} */
function commandOk(cmd, args, options = {}) {
  const r = spawnSync(cmd, args, {
    encoding: "utf8",
    stdio: "pipe",
    ...options,
  });
  return r.status === 0;
}

function ensureDocker() {
  if (commandOk("docker", ["version", "--format", "{{.Server.Version}}"])) {
    console.error("Prerequisite OK: Docker daemon reachable");
    return;
  }
  if (commandOk("docker", ["version"])) {
    console.error("Prerequisite OK: Docker client/daemon responding");
    return;
  }
  console.error(`
Prerequisite failed: Docker is not usable from this shell.

Checklist:
  • Install Docker Desktop (macOS/Windows) or Docker Engine (Linux).
  • Start the Docker daemon and wait until it is fully running.
  • Linux: your user may need to be in the "docker" group, then log out and back in:
      sudo usermod -aG docker "$USER"
  • Run  docker version  yourself; it must succeed before re-running this script.
`);
  process.exit(1);
}

/**
 * Resolve PowerShell 7+ for host-side pagination post-processing.
 * Do not fall back to Windows PowerShell 5.1 (`powershell`): Apply-OasPagination.ps1
 * requires #Requires -Version 7.0 and uses PS7-only APIs.
 * @returns {string | null}
 */
function resolvePwsh() {
  // Check major version explicitly — presence of the binary is not enough.
  if (
    commandOk("pwsh", [
      "-NoProfile",
      "-Command",
      "if ($PSVersionTable.PSVersion.Major -lt 7) { exit 1 }",
    ])
  ) {
    return "pwsh";
  }
  return null;
}

/** @param {string} hostPath path under OpenAPI/ (e.g. OAS/foo.json) */
function ensureSpecExists(hostPath) {
  const full = join(root, hostPath);
  if (!existsSync(full)) {
    console.error(`Missing OpenAPI spec: ${full}`);
    process.exit(1);
  }
}

const root = resolve(dirname(fileURLToPath(import.meta.url)), "..");
const configPath = join(root, "openapitools.json");
const config = JSON.parse(readFileSync(configPath, "utf8"));
const version = config["generator-cli"]?.version ?? "7.22.0";
const image = `openapitools/openapi-generator-cli:v${version}`;

const postProcessQueuePath = join(root, ".pagination-postprocess-queue");
const postProcessQueueScript = "/local/scripts/Apply-OasPagination-queue.sh";
const postProcessScriptHost = join(root, "scripts/Apply-OasPagination.ps1");
const postProcessQueueScriptHost = join(root, "scripts/Apply-OasPagination-queue.sh");
/** Custom mustache templates (lean headers, no comment-based help on functions). */
const templateDirHost = join(root, "templates/powershell");
const templateDirContainer = "/local/templates/powershell";

const targets = {
  console: {
    spec: "OAS/JumpCloud.SDK.Console.json",
    input: "/local/OAS/JumpCloud.SDK.Console.json",
    output: "/local/PowerShell/JumpCloud.SDK.Console",
    outputHost: join(root, "PowerShell/JumpCloud.SDK.Console"),
    sdkShortName: "Console",
    props:
      "packageName=JumpCloud.SDK.Console,apiNamePrefix=JcSdk,powershellVersion=7.0,commonDebuggingType=Stop",
    skipValidate: true,
  },
  directoryInsights: {
    spec: "OAS/JumpCloud.SDK.DirectoryInsights.json",
    input: "/local/OAS/JumpCloud.SDK.DirectoryInsights.json",
    output: "/local/PowerShell/JumpCloud.SDK.DirectoryInsights",
    outputHost: join(root, "PowerShell/JumpCloud.SDK.DirectoryInsights"),
    sdkShortName: "DirectoryInsights",
    props:
      "packageName=JumpCloud.SDK.DirectoryInsights,apiNamePrefix=JcSdk,powershellVersion=7.0,commonDebuggingType=Stop",
    skipValidate: true,
  },
};

const sdkTargetKeys = Object.keys(targets);
const modes = [...sdkTargetKeys, "all"];

function clearPostProcessQueue() {
  try {
    unlinkSync(postProcessQueuePath);
  } catch {
    /* queue file may not exist */
  }
}

/**
 * OpenAPI Generator's PowerShell example snippets omit apiNamePrefix on model
 * Initialize-* cmdlets (and sometimes Configuration helpers). Rewrite docs so
 * examples match the generated cmdlets (e.g. Initialize-JcSdkEventQuery).
 * @param {typeof targets[string]} target
 */
function fixDocCmdletPrefixes(target) {
  const prefixMatch = /(?:^|,)apiNamePrefix=([^,]+)/.exec(target.props);
  const prefix = prefixMatch?.[1];
  if (!prefix) {
    return;
  }

  const docsDir = join(target.outputHost, "docs");
  if (!existsSync(docsDir)) {
    return;
  }

  let updatedFiles = 0;

  /** @param {string} content */
  function rewriteDocContent(content) {
    // Fresh regexes each call — /g lastIndex must not leak across files
    return content
      .replace(
        new RegExp(`\\bInitialize-(?!${prefix})([A-Za-z][A-Za-z0-9_]*)`, "g"),
        `Initialize-${prefix}$1`,
      )
      .replace(/\bGet-Configuration\b/g, `Get-${prefix}Configuration`)
      .replace(/\bSet-Configuration(?=[A-Za-z]|\b)/g, `Set-${prefix}Configuration`);
  }

  for (const name of readdirSync(docsDir)) {
    if (!name.endsWith(".md")) {
      continue;
    }
    const filePath = join(docsDir, name);
    const original = readFileSync(filePath, "utf8");
    const next = rewriteDocContent(original);
    if (next !== original) {
      writeFileSync(filePath, next, "utf8");
      updatedFiles++;
    }
  }

  // README examples can have the same unprefixed Initialize-/Configuration names
  const readmePath = join(target.outputHost, "README.md");
  if (existsSync(readmePath)) {
    const original = readFileSync(readmePath, "utf8");
    const next = rewriteDocContent(original);
    if (next !== original) {
      writeFileSync(readmePath, next, "utf8");
      updatedFiles++;
    }
  }

  if (updatedFiles > 0) {
    console.error(
      `[docs] Prefixed example cmdlets with ${prefix} in ${updatedFiles} file(s)`,
    );
  }
}

/**
 * Drain files queued during Docker generation and apply pagination on the host.
 * @param {typeof targets[string]} target
 * @returns {number} exit code (0 ok)
 */
function flushPaginationPostProcess(target) {
  const pwsh = resolvePwsh();
  if (!pwsh) {
    console.error(
      "Warning: PowerShell 7+ (pwsh) not found on host; skipping pagination post-processing.",
    );
    return 0;
  }

  if (!existsSync(postProcessScriptHost)) {
    console.error(`Missing post-process script: ${postProcessScriptHost}`);
    return 1;
  }

  if (!existsSync(postProcessQueuePath)) {
    console.error("Pagination queue empty; running batch post-process on generated API files.");
    const batch = spawnSync(
      pwsh,
      [
        "-NoProfile",
        "-File",
        postProcessScriptHost,
        "-GeneratedRoot",
        target.outputHost,
        "-SdkName",
        target.sdkShortName,
      ],
      { stdio: "inherit", encoding: "utf8", cwd: root },
    );
    return batch.status ?? 1;
  }

  const queued = readFileSync(postProcessQueuePath, "utf8")
    .split("\n")
    .map((line) => line.trim())
    .filter(Boolean);

  let failed = false;
  for (const containerPath of queued) {
    const hostPath = containerPath.replace(/^\/local/, root);
    if (!hostPath.endsWith(".ps1")) {
      continue;
    }
    console.error(`[pagination] Post-processing ${hostPath}`);
    const r = spawnSync(
      pwsh,
      ["-NoProfile", "-File", postProcessScriptHost, hostPath],
      { stdio: "inherit", encoding: "utf8", cwd: root },
    );
    if ((r.status ?? 1) !== 0) {
      failed = true;
    }
  }

  clearPostProcessQueue();
  return failed ? 1 : 0;
}

function generate(target) {
  clearPostProcessQueue();

  if (existsSync(postProcessQueueScriptHost)) {
    chmodSync(postProcessQueueScriptHost, 0o755);
  }

  if (!existsSync(templateDirHost)) {
    console.error(`Missing custom templates directory: ${templateDirHost}`);
    return 1;
  }

  const args = [
    "run",
    "--rm",
    "-v",
    `${root}:/local`,
    "-e",
    `POWERSHELL_POST_PROCESS_FILE=/bin/sh ${postProcessQueueScript}`,
    image,
    "generate",
    "-g",
    "powershell",
    "-i",
    target.input,
    "-o",
    target.output,
    "-t",
    templateDirContainer,
    `--additional-properties=${target.props}`,
    // Keep API markdown docs; skip model docs/*.md
    "--global-property",
    "modelDocs=false",
    "--enable-post-process-file",
  ];
  if (target.skipValidate) {
    args.push("--skip-validate-spec");
  }

  const r = spawnSync("docker", args, { stdio: "inherit", encoding: "utf8" });
  if ((r.status ?? 1) !== 0) {
    clearPostProcessQueue();
    return r.status ?? 1;
  }

  console.error(`\n=== Applying pagination post-processing (${target.sdkShortName}) ===\n`);
  const paginationStatus = flushPaginationPostProcess(target);
  fixDocCmdletPrefixes(target);
  return paginationStatus;
}

const mode = process.argv[2] ?? "all";
if (!modes.includes(mode)) {
  console.error(`Usage: node generate-powershell-docker.mjs [${modes.join("|")}]`);
  process.exit(1);
}

console.error(`Generator image: ${image}\n`);
console.error("Checking prerequisites (Docker) …\n");
ensureDocker();

const pwsh = resolvePwsh();
if (pwsh) {
  console.error(`Prerequisite OK: ${pwsh} available for pagination post-processing\n`);
} else {
  console.error(
    "Warning: pwsh not found; generated SDKs will not receive automatic pagination.\n",
  );
}

const keysToRun = mode === "all" ? sdkTargetKeys : [mode];
for (const key of keysToRun) {
  ensureSpecExists(targets[key].spec);
}
console.error("");

if (mode === "all") {
  let failed = false;
  for (const key of sdkTargetKeys) {
    console.error(`\n=== Generating ${key} ===\n`);
    if (generate(targets[key]) !== 0) {
      failed = true;
    }
  }
  process.exit(failed ? 1 : 0);
}

process.exit(generate(targets[mode]));
