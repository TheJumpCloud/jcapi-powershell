# OpenAPI PowerShell SDK generation

This folder holds the OpenAPI specs (`OAS/`) and the tooling that regenerates the PowerShell SDKs under `PowerShell/`. Generation uses **[OpenAPI Generator](https://openapi-generator.tech/)** with the **`powershell`** generator.

The entry point is **`scripts/generate-powershell-docker.mjs`**. It runs the official **`openapitools/openapi-generator-cli`** Docker image so the generator runs in a consistent Linux environment, while bind-mounting this `OpenAPI/` directory at **`/local`** inside the container. Paths such as `-i /local/OAS/....json` and `-o /local/PowerShell/...` are therefore stable and do not depend on your host path layout. That avoids a known pitfall: the npm **`openapi-generator-cli`** package does not rewrite `--input-spec` paths when using Docker mode, so a naïve wrapper can break; this script invokes **`docker run`** directly with the correct mounts.

---

## What the wrapper script does (in order)

1. **Parses your target** (`v1`, `v2`, `directoryInsights`, or `all`) from the command line (default: `all`).
2. **Checks prerequisites** and exits with a clear message if something is missing:
   - **Java** on the host (`java -version` must succeed). The **`@openapitools/openapi-generator-cli`** npm package uses a JVM on your machine even though code generation runs in Docker.
   - **Docker** (`docker version` must reach the daemon).
   - **`openapi-generator-cli`** on your `PATH` or under `OpenAPI/node_modules/.bin`. If absent, the script runs **`npm install @openapitools/openapi-generator-cli`** in the **`OpenAPI/`** directory (requires **npm** and usually **network** the first time).
3. **Runs `docker run`** once per target with image tag **`openapitools/openapi-generator-cli:v<version>`**, where `<version>` comes from **`openapitools.json`** → **`generator-cli.version`** (currently **7.22.0**). Docker will **pull** that image the first time it is needed.

If any step fails, read the script’s stderr output: it includes targeted hints (especially for Java on macOS).

---

## Prerequisites (install these before running)

| Requirement | Why it is needed |
| --- | --- |
| **[Node.js](https://nodejs.org/)** (LTS recommended) | Runs `generate-powershell-docker.mjs`. |
| **npm** | Ships with Node; used when the script auto-installs `@openapitools/openapi-generator-cli`. |
| **Java (JDK or full JRE)** | The OpenAPI Generator **CLI** on the host is a Java application. **Docker does not replace this:** the container runs the generator for `docker run ... generate`, but installing/validating the npm CLI and related tooling still expects **`java`** on your **`PATH`**. |
| **[Docker](https://www.docker.com/)** | Docker Desktop (macOS/Windows) or Docker Engine (Linux), daemon **running**, and permission for your user to run **`docker`** (e.g. Linux: user in **`docker`** group). |
| **Network (first run)** | Pulling the generator image from Docker Hub; possibly **`npm install`** under `OpenAPI/`. |

Optional but useful: commit **`OpenAPI/package.json`** and **`OpenAPI/package-lock.json`** (and optionally document **`node_modules/`** in `.gitignore` or commit it—your team’s choice) so others get the same CLI without re-resolving dependencies.

---

## Verify your environment (copy/paste)

Run these in the **same terminal** you will use for generation:

```bash
node -v
npm -v
java -version
docker version
```

Expected pattern:

- **`node -v`** — v18+ or current LTS is typical.
- **`npm -v`** — any recent npm is fine.
- **`java -version`** — prints vendor/version lines and **exits without** “Unable to locate a Java Runtime” / “No Java runtime present”.
- **`docker version`** — shows **Client** and **Server** sections (Server missing ⇒ daemon not running or no permission).

If **`openapi-generator-cli`** is already installed globally, you can also run:

```bash
openapi-generator-cli version
```

---

## How to generate the SDKs

### From the repository root

Generate **all** three SDKs (default):

```bash
node OpenAPI/scripts/generate-powershell-docker.mjs
```

Generate **one** SDK:

```bash
node OpenAPI/scripts/generate-powershell-docker.mjs v1
node OpenAPI/scripts/generate-powershell-docker.mjs v2
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

Use the same optional argument: `v1`, `v2`, `directoryInsights`, or `all`.

---

## Targets

| Target | OpenAPI spec | Output directory (under `OpenAPI/`) |
| --- | --- | --- |
| `v1` | `OAS/JumpCloud.SDK.V1.json` | `PowerShell/JumpCloud.SDK.V1/` |
| `v2` | `OAS/JumpCloud.SDK.V2.json` | `PowerShell/JumpCloud.SDK.V2/` |
| `directoryInsights` | `OAS/JumpCloud.SDK.DirectoryInsights.json` | `PowerShell/JumpCloud.SDK.DirectoryInsights/` |
| `all` | All three specs, in order | All three output directories |

With **`all`**, each target runs in sequence. If one fails, the script still runs the rest, then exits with a **non-zero** status if any target failed.

---

## Configuration

- **Generator version / CLI metadata:** `openapitools.json` (`generator-cli.version`, etc.).
- **Wrapper script:** `scripts/generate-powershell-docker.mjs`.

Each target uses generator **`powershell`** with **`apiNamePrefix=JcSdk`**, **`powershellVersion=7.0`**, and **`commonDebuggingType=Stop`**. Spec validation during generation is turned off with **`--skip-validate-spec`**.

---

## Troubleshooting

### “No Java runtime present” / “Unable to locate a Java Runtime” (especially macOS)

The JVM must be visible to the **terminal** process (PATH and sometimes **`JAVA_HOME`**). Common causes:

1. **JDK not installed**, or only a browser plug-in / partial JRE — install a proper JDK, e.g. **[Eclipse Temurin](https://adoptium.net/)**, or on macOS with Homebrew: **`brew install temurin`**.
2. **Homebrew OpenJDK is “keg-only”** — Homebrew may print a **Caveats** block after install. Follow it: often **`brew info openjdk`** suggests symlinking into **`/Library/Java/JavaVirtualMachines/`** or prepending **`.../opt/openjdk/bin`** to **`PATH`** in **`~/.zshrc`** / **`~/.bash_profile`**.
3. **`JAVA_HOME` unset or wrong** — On macOS, after installing a JDK, try:
   ```bash
   /usr/libexec/java_home -V
   export JAVA_HOME="$(/usr/libexec/java_home)"   # or add -v 17 for a specific version
   java -version
   ```
   Persist **`export JAVA_HOME=...`** in your shell rc file and **open a new terminal**.

Further discussion and community fixes (JRE vs JDK, symlinks, **`JAVA_HOME`**):  
[Stack Overflow — “No Java runtime present” on Mac](https://stackoverflow.com/questions/44009058/even-though-jre-8-is-installed-on-my-mac-no-java-runtime-present-requesting-t)

### Docker: “Cannot connect to the Docker daemon” / no Server section in `docker version`

- Start **Docker Desktop** (or **`sudo systemctl start docker`** on Linux).
- Linux: add your user to the **`docker`** group, then **log out and back in** (or reboot):
  ```bash
  sudo usermod -aG docker "$USER"
  ```

### `npm install` fails (proxy, TLS, offline)

- Ensure corporate proxy / `npm config set proxy` settings if required.
- Run **`npm install @openapitools/openapi-generator-cli`** manually inside **`OpenAPI/`** and fix the reported error; then re-run the script.

### Image pull is slow or blocked

The first run pulls **`openapitools/openapi-generator-cli:v<version>`**. Allow network access to your registry (Docker Hub by default) or mirror the image per your org’s policy.

### Permission errors writing `PowerShell/…`

The container writes through the bind mount as the user Docker maps for your files (often your host uid on Linux). If files are owned by root from a previous run, fix ownership on the host or regenerate in a clean tree.

---

## Files to know

| Path | Role |
| --- | --- |
| `OAS/*.json` | OpenAPI documents used as input. |
| `PowerShell/JumpCloud.SDK.*` | Generated SDK output (do not hand-edit if you expect regen to overwrite). |
| `openapitools.json` | Generator CLI version and related settings. |
| `scripts/generate-powershell-docker.mjs` | Prerequisite checks + `docker run` orchestration. |
