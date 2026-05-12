#!/usr/bin/env node
/**
 * OpenAPI Generator via Docker with correct bind-mount paths (/local/...).
 * The npm openapi-generator-cli package does not rewrite --input-spec for Docker mode.
 */
import { readFileSync } from "node:fs";
import { dirname, join, resolve } from "node:path";
import { spawnSync } from "node:child_process";
import { fileURLToPath } from "node:url";

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
