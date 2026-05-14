#!/usr/bin/env node
/**
 * OpenAPI Generator — PowerShell SDKs via Docker
 *
 * What this script does
 * ---------------------
 * 1. Validates prerequisites on your machine (Java, Docker, openapi-generator-cli).
 * 2. Optionally installs `@openapitools/openapi-generator-cli` under `OpenAPI/` if the
 *    CLI is missing (npm needs network).
 * 3. Runs `docker run` with the OpenAPI Generator image from `openapitools.json`,
 *    bind-mounting this repo’s `OpenAPI/` tree at `/local` so `-i` / `-o` paths match
 *    what the container expects (the stock npm CLI does not rewrite paths for Docker).
 *
 * Prerequisites (validated, not installed automatically except the npm CLI)
 * --------------------------------------------------------------------------
 * - Node.js — you are already running this file with Node.
 * - npm — used only when the CLI must be installed locally.
 * - Java (JDK or JRE that provides `java` on PATH) — required by the official
 *   `openapi-generator-cli` wrapper (downloads/runs the generator JAR on the host).
 *   Generation still uses Docker for the heavy work, but the CLI itself needs a JVM.
 * - Docker — Engine/Desktop running; your user must be able to run `docker`.
 *
 * @see https://openapi-generator.tech/docs/installation
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

function javaVersionLines() {
  const r = spawnSync("java", ["-version"], { encoding: "utf8", stdio: "pipe" });
  // `java -version` prints to stderr; status 0 means JVM started.
  const err = r.stderr?.trim() || "";
  const out = r.stdout?.trim() || "";
  return { ok: r.status === 0, text: err || out || "(no output)" };
}

function printJavaTroubleshooting() {
  console.error(`
Java is required on the host because @openapitools/openapi-generator-cli uses a JVM
(even when generation runs inside Docker).

Fix (pick one approach that matches your OS):

  • Verify: run  java -version  in this terminal. You should see an OpenJDK/Oracle/etc.
    line and no "Unable to locate a Java Runtime" message.

  • macOS — Apple / Homebrew "keg-only" OpenJDK often needs PATH or a symlink so GUI and
    terminal tools find the JDK:
      - Install a JDK: https://adoptium.net/  (Eclipse Temurin), or: brew install temurin
      - Homebrew OpenJDK: follow the "Caveats" from  brew info openjdk  (often symlink
        into /Library/Java/JavaVirtualMachines/ … or add .../opt/openjdk/bin to PATH).
      - Point JAVA_HOME at a real JDK home, e.g.:
          export JAVA_HOME=$(/usr/libexec/java_home -v 17)   # adjust version
        Add that to ~/.zshrc or ~/.bash_profile, then open a new terminal.

  • More context (JRE vs JDK, Mac symlinks, JAVA_HOME):
      https://stackoverflow.com/questions/44009058/even-though-jre-8-is-installed-on-my-mac-no-java-runtime-present-requesting-t

  • Windows — install a JDK from Adoptium or Oracle and ensure "java" is on PATH
    (restart the terminal after installing).

  • Linux — install default-jdk or temurin-* package from your distro or Adoptium;
    ensure  which java  points at the JDK/JRE you expect.
`);
}

function ensureJava() {
  const { ok, text } = javaVersionLines();
  if (ok) {
    console.error(`Prerequisite OK: Java (${text.split("\n")[0] ?? "detected"})`);
    return;
  }
  console.error("Prerequisite failed: Java is not available or `java -version` did not succeed.");
  console.error(`Output was:\n${text}`);
  printJavaTroubleshooting();
  process.exit(1);
}

function ensureDocker() {
  if (commandOk("docker", ["version", "--format", "{{.Server.Version}}"])) {
    console.error("Prerequisite OK: Docker daemon reachable");
    return;
  }
  // Fallback: `docker version` without format (older clients)
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

function openapiGeneratorCliVersionOk(cmd, args = ["version"]) {
  return commandOk(cmd, args);
}

function ensureOpenApiGeneratorCli(openapiRoot) {
  if (openapiGeneratorCliVersionOk("openapi-generator-cli")) {
    return;
  }

  const localBin = join(openapiRoot, "node_modules", ".bin", "openapi-generator-cli");
  const localBinWin = `${localBin}.cmd`;
  const localCmd =
    process.platform === "win32" && existsSync(localBinWin) ? localBinWin : localBin;

  if (existsSync(localCmd) && openapiGeneratorCliVersionOk(localCmd)) {
    return;
  }

  console.error(
    "openapi-generator-cli not found; installing @openapitools/openapi-generator-cli in OpenAPI …",
  );
  const install = spawnSync(
    "npm",
    ["install", "@openapitools/openapi-generator-cli"],
    { stdio: "inherit", cwd: openapiRoot },
  );
  if (install.status !== 0) {
    console.error("Failed to install @openapitools/openapi-generator-cli.");
    process.exit(1);
  }

  const verifyPath =
    process.platform === "win32" && existsSync(localBinWin) ? localBinWin : localBin;
  if (!openapiGeneratorCliVersionOk(verifyPath)) {
    console.error("openapi-generator-cli is still not runnable after install.");
    console.error("If the error mentions Java, fix Java first (see messages above).");
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
    input: "/local/OAS/JumpCloud.SDK.V1.json",
    output: "/local/PowerShell/JumpCloud.SDK.V1",
    props:
      "packageName=JumpCloud.SDK.V1,apiNamePrefix=JcSdk,powershellVersion=7.0,commonDebuggingType=Stop",
    skipValidate: true,
  },
  v2: {
    input: "/local/OAS/JumpCloud.SDK.V2.json",
    output: "/local/PowerShell/JumpCloud.SDK.V2",
    props:
      "packageName=JumpCloud.SDK.V2,apiNamePrefix=JcSdk,powershellVersion=7.0,commonDebuggingType=Stop",
    skipValidate: true,
  },
  directoryInsights: {
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

console.error("Checking prerequisites (Java, Docker, openapi-generator-cli) …\n");
ensureJava();
ensureDocker();
ensureOpenApiGeneratorCli(root);
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
