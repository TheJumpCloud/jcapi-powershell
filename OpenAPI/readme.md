# OpenAPI PowerShell SDK generation

This folder holds the OpenAPI specs (`OAS/`) and the tooling that regenerates the PowerShell SDKs under `PowerShell/`. Generation uses **[OpenAPI Generator](https://openapi-generator.tech/)** with the **`powershell`** generator.

The entry point is **`scripts/generate-powershell-docker.mjs`**. It runs the official **`openapitools/openapi-generator-cli`** Docker image so the generator (and its JVM) run inside the container, while bind-mounting this `OpenAPI/` directory at **`/local`**. Paths such as `-i /local/OAS/....json` and `-o /local/PowerShell/...` are stable on any host. This script does **not** call the npm **`openapi-generator-cli`** package (that wrapper has path issues in Docker mode anyway).

---

## End-to-end build process (preferred)

Use the wrapper for a full regenerate. It runs every host post-process step in the **required order** (Fill → Fix collisions → Pagination). Fill may temporarily leave duplicate Expanded parameters; Fix removes them. Skipping Fix (or stopping after Fill) leaves API scripts that fail to parse and then **`Build.ps1` cannot write the module manifest**.

### 1. Generate (Docker + host post-processors)

From the repository root:

```bash
node OpenAPI/scripts/generate-powershell-docker.mjs console
# or: directoryInsights | all
```

From inside `OpenAPI/`:

```bash
cd OpenAPI
node scripts/generate-powershell-docker.mjs console
```

### 2. Build the PowerShell module manifest

After generation succeeds, build each SDK so `*.psd1` exports match the generated functions:

```bash
pwsh -File OpenAPI/PowerShell/JumpCloud.SDK.Console/Build.ps1
pwsh -File OpenAPI/PowerShell/JumpCloud.SDK.DirectoryInsights/Build.ps1
```

`Build.ps1` parses every `Api` / `Model` / `Client` `.ps1` file. If any file still has duplicate parameters or other parse errors, manifest creation fails with `Path` null / parse exceptions — fix collisions first (step below), do not hand-edit around a broken tree.

### 3. Optional smoke checks

```bash
pwsh -File OpenAPI/scripts/Test-JcSdkEnvAuth.ps1
pwsh -File OpenAPI/scripts/Test-ExpandBodyParams.ps1
pwsh -File OpenAPI/scripts/Test-DirectoryInsightsExpand.ps1
```

---

## What the wrapper script does (in order)

For **each** selected target (`console`, `directoryInsights`, or `all`):

1. **Parses your target** from the command line (default: `all`).
2. **Checks Docker** — `docker version` must reach the daemon.
3. **Checks that each selected spec file exists** under `OAS/`.
4. **Annotates Expanded-body name collisions** — `scripts/annotate-expand-body-collisions.py` writes `.expand-body-collisions.json` (advisory manifest for reporting).
5. **Runs `docker run`** with image **`openapitools/openapi-generator-cli:v<version>`** (`openapitools.json` → `generator-cli.version`, currently **7.22.0**). First run may **pull** the image. Generation uses **`-t templates/powershell`**, **`--enable-post-process-file`**, and queues API files for host-side pagination (the generator image does not include `pwsh`).
6. **Host post-processors** (PowerShell 7+), **in this order — do not skip or reorder**:

   | Order | Script | Purpose |
   | --- | --- | --- |
   | 1 | `Fill-ExpandedBodyParams.ps1` | Fills empty Expanded maps/params from `Initialize-*` models (allOf / composed request bodies). May leave duplicate Expanded params; warns but does not fail. |
   | 2 | `Fix-ExpandBodyCollisions.ps1` | **Required (hard parse gate).** Drops Expanded body parameters that collide with path/query/header/form names (e.g. body `id` vs path `Id`), renames colliding `-Body` containers, and **fails** if API files still do not parse. |
   | 3 | `Apply-OasPagination.ps1` | Adds pagination for operations marked `paginate: true` in `OAS/mapping/OASMapping.*.json` (runs after Fix so cmdlets parse). |
   | 4 | Doc prefix rewrite (in the Node wrapper) | Rewrites `docs/` / README examples so `Initialize-*` / Configuration cmdlets include `apiNamePrefix` (`JcSdk`). |

**Always prefer the wrapper** over running Fill alone. If you must run post-processors by hand after a partial regen, run them in the table order above — **Fix must run immediately after Fill** before `Build.ps1`:

```bash
pwsh -File OpenAPI/scripts/Fill-ExpandedBodyParams.ps1 -GeneratedRoot OpenAPI/PowerShell/JumpCloud.SDK.Console -SpecPath OpenAPI/OAS/JumpCloud.SDK.Console.json
pwsh -File OpenAPI/scripts/Fix-ExpandBodyCollisions.ps1 -GeneratedRoot OpenAPI/PowerShell/JumpCloud.SDK.Console
pwsh -File OpenAPI/scripts/Apply-OasPagination.ps1 -GeneratedRoot OpenAPI/PowerShell/JumpCloud.SDK.Console -SdkName Console
pwsh -File OpenAPI/PowerShell/JumpCloud.SDK.Console/Build.ps1
```

---

## Prerequisites (install these before running)

| Requirement | Why it is needed |
| --- | --- |
| **[Node.js](https://nodejs.org/)** (LTS recommended) | Runs `generate-powershell-docker.mjs`. |
| **[PowerShell 7+](https://github.com/PowerShell/PowerShell)** (`pwsh`) | Host post-processors (Fill, Fix collisions, Pagination) and `Build.ps1`. |
| **[Docker](https://www.docker.com/)** | Docker Desktop (macOS/Windows) or Docker Engine (Linux), daemon **running**, and permission for your user to run **`docker`**. |
| **[Python 3](https://www.python.org/)** | `annotate-expand-body-collisions.py` before each Docker generate. |
| **Network (first run)** | Pulling the generator image from Docker Hub (or your registry mirror). |

**Not required for this script:** Java on the host, npm, or **`openapi-generator-cli`**. Those only matter if you run OpenAPI Generator outside Docker (for example via the npm CLI or a local JAR). This wrapper uses **`docker run`** only; Java runs inside the image.

**`openapitools.json`** is still used to pin the **Docker image tag**. It is not used to invoke the npm CLI in this workflow.

---

## Verify your environment (copy/paste)

Run these in the **same terminal** you will use for generation:

```bash
node -v
docker version
pwsh -NoProfile -Command '$PSVersionTable.PSVersion'
python3 --version
```

Expected pattern:

- **`node -v`** — v18+ or current LTS is typical.
- **`docker version`** — shows **Client** and **Server** sections (Server missing ⇒ daemon not running or no permission).
- **`pwsh`** — 7.0 or newer (host post-processors and `Build.ps1`).
- **`python3`** — 3.x for collision annotation.

---

## How to generate the SDKs

See **[End-to-end build process](#end-to-end-build-process-preferred)** for generate + `Build.ps1`. Shortcut:

```bash
# From repo root — both SDKs (default)
node OpenAPI/scripts/generate-powershell-docker.mjs

# One SDK
node OpenAPI/scripts/generate-powershell-docker.mjs console
node OpenAPI/scripts/generate-powershell-docker.mjs directoryInsights

# Explicit all
node OpenAPI/scripts/generate-powershell-docker.mjs all
```

Then build manifests:

```bash
pwsh -File OpenAPI/PowerShell/JumpCloud.SDK.Console/Build.ps1
pwsh -File OpenAPI/PowerShell/JumpCloud.SDK.DirectoryInsights/Build.ps1
```

---

## Targets

| Target | OpenAPI spec | Output directory (under `OpenAPI/`) |
| --- | --- | --- |
| `console` | `OAS/JumpCloud.SDK.Console.json` | `PowerShell/JumpCloud.SDK.Console/` |
| `directoryInsights` | `OAS/JumpCloud.SDK.DirectoryInsights.json` | `PowerShell/JumpCloud.SDK.DirectoryInsights/` |
| `all` | Both specs, in order | Both output directories |

With **`all`**, each target runs in sequence. If one fails, the script still runs the rest, then exits with a **non-zero** status if any target failed.

---

## Configuration

- **Generator image version:** `openapitools.json` → `generator-cli.version`
- **Wrapper script:** `scripts/generate-powershell-docker.mjs`

Each target uses generator **`powershell`** with **`apiNamePrefix=JcSdk`**, **`powershellVersion=7.0`**, and **`commonDebuggingType=Stop`**. Spec validation during generation is turned off with **`--skip-validate-spec`**. Custom templates under **`templates/powershell/`** are passed with **`-t`** (lean headers; no `<# .SYNOPSIS #>` help blocks on `.ps1` files; API docs use prefixed Configuration cmdlets). API markdown under **`docs/`** is generated; model docs are skipped via **`--global-property modelDocs=false`**. After generation, example snippets in docs are rewritten so `Initialize-*` / Configuration cmdlets include **`apiNamePrefix`**.

### JumpCloud env auth (parity with AutoRest SDKs)

Generated Console and DirectoryInsights modules authenticate like AutoRest `Custom/Module.cs`, without requiring `Set-JcSdkConfiguration*` for normal use:

| Variable | Role |
| --- | --- |
| `$env:JCApiKey` | Sent as `x-api-key` |
| `$env:JCOrgId` | Sent as `x-org-id` |
| `$env:JCEnvironment` | Selects base URL: `STANDARD` / `US` (default), `EU`, or `IN` |

Behavior is implemented in **`templates/powershell/configuration.mustache`** (`Get-JcSdkConfiguration`) and **`templates/powershell/api_client.mustache`** (DefaultHeaders merge; MTP routes that reject `x-org-id`). Regen preserves it.

- Missing ApiKey/OrgId: interactive hosts prompt (and set the env vars); non-interactive / CI fails with a clear error.
- Explicit `Set-JcSdkConfiguration -BaseUrl` wins over `JCEnvironment`.
- Unit tests: `pwsh -File OpenAPI/scripts/Test-JcSdkEnvAuth.ps1`

---

## Troubleshooting

### Docker: “Cannot connect to the Docker daemon” / no Server section in `docker version`

- Start **Docker Desktop** (or **`sudo systemctl start docker`** on Linux).
- Linux: add your user to the **`docker`** group, then **log out and back in** (or reboot):
  ```bash
  sudo usermod -aG docker "$USER"
  ```

### “No Java runtime present” when running something else

That message applies to **host-side** tools (npm **`openapi-generator-cli`**, IDE plugins, local JAR). **This script does not need host Java.** If you still see it while running this wrapper, check that you are not accidentally calling **`openapi-generator-cli`** or another tool instead of:

```bash
node OpenAPI/scripts/generate-powershell-docker.mjs
```

If you need host Java for other workflows, see [Stack Overflow — “No Java runtime present” on Mac](https://stackoverflow.com/questions/44009058/even-though-jre-8-is-installed-on-my-mac-no-java-runtime-present-requesting-t).

### Image pull is slow or blocked

The first run pulls **`openapitools/openapi-generator-cli:v<version>`**. Allow network access to your registry (Docker Hub by default) or mirror the image per your org’s policy.

### Missing OpenAPI spec

The script exits early if `OAS/JumpCloud.SDK.*.json` for the selected target is missing. Ensure specs are present (or generated upstream) before running.

### Permission errors writing `PowerShell/…`

The container writes through the bind mount. If files are owned by root from a previous run, fix ownership on the host or regenerate in a clean tree.

### `Duplicate parameter $Id` / `$Body` / `$Fields` during generate or `Build.ps1`

Expanded request-body properties often share PowerShell names with path/query/header parameters (e.g. `Id`) or with the ByBody `-Body` container. **`Fill-ExpandedBodyParams.ps1` may leave those duplicates**; it warns and continues. **`Fix-ExpandBodyCollisions.ps1`** (next step in the wrapper) removes/renames them and is the hard parse gate.

If generate was interrupted after Fill, or you ran Fill by hand:

```bash
pwsh -File OpenAPI/scripts/Fix-ExpandBodyCollisions.ps1 -GeneratedRoot OpenAPI/PowerShell/JumpCloud.SDK.Console
pwsh -File OpenAPI/PowerShell/JumpCloud.SDK.Console/Build.ps1
```

Prefer re-running `node scripts/generate-powershell-docker.mjs console` so Fill → Fix → Pagination all complete.

---

## Files to know

| Path | Role |
| --- | --- |
| `OAS/*.json` | OpenAPI documents used as input. |
| `PowerShell/JumpCloud.SDK.*` | Generated SDK output (release artifact). Prefer changing templates + regenerating over hand-edits. |
| `PowerShell/JumpCloud.SDK.*/Build.ps1` | Writes/updates the module `.psd1` from parsed generated functions. Run after a successful generate + post-process. |
| `openapitools.json` | Pins the Docker image version (`generator-cli.version`). |
| `scripts/generate-powershell-docker.mjs` | Full pipeline: Docker generate + Fill → Fix collisions → Pagination + doc prefix rewrite. |
| `templates/powershell/` | Custom mustache overrides (lean headers; JCApiKey/JCOrgId/JCEnvironment auth in `configuration.mustache` / `api_client.mustache`). |
| `scripts/annotate-expand-body-collisions.py` | Pre-generate OAS scan; writes `.expand-body-collisions.json` (advisory). |
| `scripts/Fill-ExpandedBodyParams.ps1` | Post-processor (1/3): fills empty Expanded maps/params from Initialize-* models (allOf request bodies). Warns on duplicate-param parse issues; does not fail. |
| `scripts/Fix-ExpandBodyCollisions.ps1` | Post-processor (2/3, required): drops colliding Expanded params; hard-fails if API files still do not parse. |
| `scripts/Apply-OasPagination.ps1` | Post-processor (3/3): adds pagination for `paginate: true` in `OAS/mapping/OASMapping.*.json`. |
| `scripts/Test-JcSdkEnvAuth.ps1` | Unit tests for env-based auth / regional BaseUrl mapping. |
| `scripts/Test-ExpandBodyParams.ps1` | Console Expanded-body / collision smoke tests. |
| `scripts/Test-DirectoryInsightsExpand.ps1` | Directory Insights Expanded-body smoke tests. |
| `scripts/Render-ConfigurationFromTemplate.ps1` | Renders `configuration.mustache` without a full Docker regen (tests / local refresh). |
| `OAS/mapping/OASMapping.*.json` | Per-operation flags (`paginate`, `x-powershell-method-name`, etc.). |
