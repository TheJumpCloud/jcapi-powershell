# OpenAPI PowerShell SDK generation

This folder holds the OpenAPI specs (`OAS/`) and the tooling that regenerates the PowerShell SDKs under `PowerShell/`. Generation uses **[OpenAPI Generator](https://openapi-generator.tech/)** with the **`powershell`** generator.

The entry point is **`scripts/generate-powershell-docker.mjs`**. It runs the official **`openapitools/openapi-generator-cli`** Docker image so the generator (and its JVM) run inside the container, while bind-mounting this `OpenAPI/` directory at **`/local`**. Paths such as `-i /local/OAS/....json` and `-o /local/PowerShell/...` are stable on any host. This script does **not** call the npm **`openapi-generator-cli`** package (that wrapper has path issues in Docker mode anyway).

---

## What the wrapper script does (in order)

1. **Parses your target** (`console`, `directoryInsights`, or `all`) from the command line (default: `all`).
2. **Checks Docker** — `docker version` must reach the daemon.
3. **Checks that each selected spec file exists** under `OAS/` before starting containers.
4. **Runs `docker run`** once per target with image tag **`openapitools/openapi-generator-cli:v<version>`**, where `<version>` comes from **`openapitools.json`** → **`generator-cli.version`** (currently **7.22.0**). Docker will **pull** that image the first time it is needed.

---

## Prerequisites (install these before running)

| Requirement | Why it is needed |
| --- | --- |
| **[Node.js](https://nodejs.org/)** (LTS recommended) | Runs `generate-powershell-docker.mjs`. |
| **[Docker](https://www.docker.com/)** | Docker Desktop (macOS/Windows) or Docker Engine (Linux), daemon **running**, and permission for your user to run **`docker`**. |
| **Network (first run)** | Pulling the generator image from Docker Hub (or your registry mirror). |

**Not required for this script:** Java on the host, npm, or **`openapi-generator-cli`**. Those only matter if you run OpenAPI Generator outside Docker (for example via the npm CLI or a local JAR). This wrapper uses **`docker run`** only; Java runs inside the image.

**`openapitools.json`** is still used to pin the **Docker image tag**. It is not used to invoke the npm CLI in this workflow.

---

## Verify your environment (copy/paste)

Run these in the **same terminal** you will use for generation:

```bash
node -v
docker version
```

Expected pattern:

- **`node -v`** — v18+ or current LTS is typical.
- **`docker version`** — shows **Client** and **Server** sections (Server missing ⇒ daemon not running or no permission).

---

## How to generate the SDKs

### From the repository root

Generate **all** three SDKs (default):

```bash
node OpenAPI/scripts/generate-powershell-docker.mjs
```

Generate **one** SDK:

```bash
node OpenAPI/scripts/generate-powershell-docker.mjs console
node OpenAPI/scripts/generate-powershell-docker.mjs directoryInsights
```

Same as “all”, but explicit:

```bash
node OpenAPI/scripts/generate-powershell-docker.mjs all
```

### From inside `OpenAPI/`

```bash
cd OpenAPI
node scripts/generate-powershell-docker.mjs
```

Use the same optional argument: `console`, `directoryInsights`, or `all`.

---

## Targets

| Target | OpenAPI spec | Output directory (under `OpenAPI/`) |
| --- | --- | --- |
| `console` | `OAS/JumpCloud.SDK.Console.json` | `PowerShell/JumpCloud.SDK.Console/` |
| `directoryInsights` | `OAS/JumpCloud.SDK.DirectoryInsights.json` | `PowerShell/JumpCloud.SDK.DirectoryInsights/` |
| `all` | All three specs, in order | All three output directories |

With **`all`**, each target runs in sequence. If one fails, the script still runs the rest, then exits with a **non-zero** status if any target failed.

---

## Configuration

- **Generator image version:** `openapitools.json` → `generator-cli.version`
- **Wrapper script:** `scripts/generate-powershell-docker.mjs`

Each target uses generator **`powershell`** with **`apiNamePrefix=JcSdk`**, **`powershellVersion=7.0`**, and **`commonDebuggingType=Stop`**. Spec validation during generation is turned off with **`--skip-validate-spec`**.

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

---

## Files to know

| Path | Role |
| --- | --- |
| `OAS/*.json` | OpenAPI documents used as input. |
| `PowerShell/JumpCloud.SDK.*` | Generated SDK output (do not hand-edit if you expect regen to overwrite). |
| `openapitools.json` | Pins the Docker image version (`generator-cli.version`). |
| `scripts/generate-powershell-docker.mjs` | Docker prerequisite check + `docker run` orchestration. |
