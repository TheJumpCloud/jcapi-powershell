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
 */
import { existsSync, readFileSync } from "node:fs";
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

const targets = {
  v1: {
    spec: "OAS/JumpCloud.SDK.V1.json",
    input: "/local/OAS/JumpCloud.SDK.V1.json",
    output: "/local/PowerShell/JumpCloud.SDK.V1",
    props:
      "packageName=JumpCloud.SDK.V1,apiNamePrefix=JcSdk,powershellVersion=7.0,commonDebuggingType=Stop",
    skipValidate: true,
  },
  v2: {
    spec: "OAS/JumpCloud.SDK.V2.json",
    input: "/local/OAS/JumpCloud.SDK.V2.json",
    output: "/local/PowerShell/JumpCloud.SDK.V2",
    props:
      "packageName=JumpCloud.SDK.V2,apiNamePrefix=JcSdk,powershellVersion=7.0,commonDebuggingType=Stop",
    skipValidate: true,
  },
  directoryInsights: {
    spec: "OAS/JumpCloud.SDK.DirectoryInsights.json",
    input: "/local/OAS/JumpCloud.SDK.DirectoryInsights.json",
    output: "/local/PowerShell/JumpCloud.SDK.DirectoryInsights",
    props:
      "packageName=JumpCloud.SDK.DirectoryInsights,apiNamePrefix=JcSdk,powershellVersion=7.0,commonDebuggingType=Stop",
    skipValidate: true,
  },
};

const sdkTargetKeys = Object.keys(targets);
const modes = [...sdkTargetKeys, "all"];

function generate(target) {
  const args = [
    "run",
    "--rm",
    "-v",
    `${root}:/local`,
    image,
    "generate",
    "-g",
    "powershell",
    "-i",
    target.input,
    "-o",
    target.output,
    `--additional-properties=${target.props}`,
  ];
  if (target.skipValidate) {
    args.push("--skip-validate-spec");
  }

  const r = spawnSync("docker", args, { stdio: "inherit", encoding: "utf8" });
  return r.status ?? 1;
}

const mode = process.argv[2] ?? "all";
if (!modes.includes(mode)) {
  console.error(`Usage: node generate-powershell-docker.mjs [${modes.join("|")}]`);
  process.exit(1);
}

console.error(`Generator image: ${image}\n`);
console.error("Checking prerequisites (Docker) …\n");
ensureDocker();

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
