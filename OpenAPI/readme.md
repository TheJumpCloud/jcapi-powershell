# OpenAPI PowerShell SDK generation

PowerShell SDKs in this folder are generated from the OpenAPI specs under `OAS/` using [OpenAPI Generator](https://openapi-generator.tech/) in Docker. The wrapper script `scripts/generate-powershell-docker.mjs` runs the generator with bind mounts mapped to `/local/...` inside the container, which avoids path issues with the npm `openapi-generator-cli` package in Docker mode.

## Prerequisites

Install and have available on your machine:

- **[Node.js](https://nodejs.org/)** (current LTS is fine) — used to run `scripts/generate-powershell-docker.mjs`.
- **npm** — ships with Node. The script checks for `openapi-generator-cli` on your `PATH` or under `OpenAPI/node_modules`; if it is missing, it runs `npm install @openapitools/openapi-generator-cli` in the `OpenAPI/` folder (needs network the first time that install runs).
- **[Docker](https://www.docker.com/)** — Docker Engine (or Docker Desktop) installed, the daemon running, and permission to run `docker` from your shell (e.g. your user in the `docker` group on Linux).

First-time notes:

- Docker pulls the generator image from `openapitools/openapi-generator-cli`; the tag matches `generator-cli.version` in `openapitools.json` (currently `7.22.0`). That pull also needs network access.
- After a local npm install of the CLI, you may see new or updated files under `OpenAPI/` (for example `package.json`, `package-lock.json`, and `node_modules/`). Commit those if you want a reproducible setup for others without relying on the auto-install step.

## Run from the repository root

Generate all three SDKs (default):

```bash
node OpenAPI/scripts/generate-powershell-docker.mjs
```

Generate a single SDK:

```bash
node OpenAPI/scripts/generate-powershell-docker.mjs v1
node OpenAPI/scripts/generate-powershell-docker.mjs v2
node OpenAPI/scripts/generate-powershell-docker.mjs directoryInsights
```

Generate all three explicitly:

```bash
node OpenAPI/scripts/generate-powershell-docker.mjs all
```

## Run from the OpenAPI directory

```bash
cd OpenAPI
node scripts/generate-powershell-docker.mjs
```

Use the same optional target argument (`v1`, `v2`, `directoryInsights`, or `all`) as above.

## Targets

| Target | OpenAPI spec | Output directory |
| --- | --- | --- |
| `v1` | `OAS/JumpCloud.SDK.V1.json` | `JumpCloud.SDK.V1/` |
| `v2` | `OAS/JumpCloud.SDK.V2.json` | `JumpCloud.SDK.V2/` |
| `directoryInsights` | `OAS/JumpCloud.SDK.DirectoryInsights.json` | `JumpCloud.SDK.DirectoryInsights/` |
| `all` | All three specs, in order | All three output directories |

With `all`, each target runs in sequence. If any generation fails, the script exits with a non-zero status after the remaining targets finish.

## Configuration

- Generator version and CLI settings: `openapitools.json`
- Wrapper script: `scripts/generate-powershell-docker.mjs`

Each target uses the `powershell` generator with `apiNamePrefix=JcSdk`, `powershellVersion=7.0`, and `commonDebuggingType=Stop`. Spec validation is skipped during generation (`--skip-validate-spec`).
