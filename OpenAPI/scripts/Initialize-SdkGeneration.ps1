#Requires -Version 7.0
<#
.SYNOPSIS
    Initializes PowerShell SDK generation: fetches the latest OAS3 specs, syncs the mapping files and
    method names, then runs the OpenAPI Generator Docker build.

.DESCRIPTION
    Runs the steps needed to start an SDK build, in order:
      1. Checks prerequisites (powershell-yaml; Node.js and Docker unless -SkipGenerate).
      2. Fetches the latest OAS3 spec per SDK from docs.jumpcloud.com (Get-OasFile), or saves the
         file passed with -SpecPath, to OAS/JumpCloud.SDK.{SDKName}.json.
      3. Syncs OAS/mapping/OASMapping.{SDKName}.json with the spec (Update-OasMapping).
      4. Stops if any operation has no x-powershell-method-name, listing the operations to name.
      5. Writes x-powershell-method-name from the mapping into the spec (Add-OasMethodName).
      6. Generates the SDKs with generate-powershell-docker.mjs.

.PARAMETER SDKName
    SDKs to initialize. Defaults to all SDKs.

.PARAMETER SpecPath
    Path to a manually downloaded OAS3 spec (.yaml, .yml or .json) to use instead of the public URL.
    Requires exactly one SDKName.

.PARAMETER SkipFetch
    Use the specs already in OAS/ instead of fetching them.

.PARAMETER SkipGenerate
    Stop after syncing the specs and mappings, without running the Docker build.

.EXAMPLE
    pwsh OpenAPI/scripts/Initialize-SdkGeneration.ps1

.EXAMPLE
    pwsh OpenAPI/scripts/Initialize-SdkGeneration.ps1 -SDKName DirectoryInsights -SpecPath ~/Downloads/index.yaml
#>
[CmdletBinding()]
param(
    [ValidateSet('Console', 'DirectoryInsights')]
    [string[]]$SDKName = @('Console', 'DirectoryInsights'),

    [string]$SpecPath,

    [switch]$SkipFetch,

    [switch]$SkipGenerate
)

$ErrorActionPreference = 'Stop'

$OpenApiRoot = Split-Path -Parent $PSScriptRoot
$OasDir = Join-Path $OpenApiRoot 'OAS'
$MappingDir = Join-Path $OasDir 'mapping'
$GenerateScript = Join-Path $PSScriptRoot 'generate-powershell-docker.mjs'
# SDKName -> generate-powershell-docker.mjs target
$GenerateTargets = @{
    'Console'           = 'console'
    'DirectoryInsights' = 'directoryInsights'
}

Function Assert-Oas3 {
    Param(
        [Parameter(Mandatory)][string]$Json,
        [Parameter(Mandatory)][string]$Source
    )

    $oas = $Json | ConvertFrom-Json -AsHashtable
    $version = [string]$oas['openapi']
    if ($version -notmatch '^3\.') {
        $found = if ($version) { "openapi: $version" } elseif ($oas['swagger']) { "swagger: $($oas['swagger'])" } else { 'no openapi version field' }
        throw "$Source is not an OpenAPI 3 document ($found). The SDK build requires an OAS3 spec."
    }
}

Function Test-DockerDaemon {
    # docker writes to stderr when the daemon is down; only the exit code matters here
    $ErrorActionPreference = 'Continue'
    & docker version --format '{{.Server.Version}}' *> $null
    return ($LASTEXITCODE -eq 0)
}

$SDKName = @($SDKName | Select-Object -Unique)

if ($SpecPath) {
    if ($SkipFetch) {
        throw '-SpecPath and -SkipFetch cannot be used together.'
    }
    if ($SDKName.Count -ne 1) {
        throw '-SpecPath requires exactly one -SDKName.'
    }
    if (-not (Test-Path -LiteralPath $SpecPath -PathType Leaf)) {
        throw "Spec file not found: $SpecPath"
    }
}

# 1. Prerequisites - checked before any files are changed
Write-Host '[status] Checking prerequisites'
if (-not (Get-Module -ListAvailable -Name 'powershell-yaml')) {
    throw 'The powershell-yaml module is required. Install it with: Install-Module powershell-yaml -RequiredVersion 0.4.2 -Scope CurrentUser'
}
if (-not $SkipGenerate) {
    if (-not (Get-Command -Name 'node' -ErrorAction SilentlyContinue)) {
        throw 'Node.js is required to run generate-powershell-docker.mjs. Install it from https://nodejs.org/ or rerun with -SkipGenerate.'
    }
    if (-not (Get-Command -Name 'docker' -ErrorAction SilentlyContinue)) {
        throw 'Docker is required to generate the SDKs. Install Docker Desktop (macOS/Windows) or Docker Engine (Linux), or rerun with -SkipGenerate.'
    }
    if (-not (Test-DockerDaemon)) {
        throw 'The Docker daemon is not reachable. Start Docker Desktop (or "sudo systemctl start docker" on Linux) and check that "docker version" shows a Server section.'
    }
}

. (Join-Path $PSScriptRoot 'OASFunctions.ps1')

# 2. Fetch the specs
if ($SkipFetch) {
    Write-Host '[status] Skipping fetch; using the existing specs in OAS/'
}
foreach ($name in $SDKName) {
    $specFile = Join-Path $OasDir "JumpCloud.SDK.$name.json"
    if ($SkipFetch) {
        if (-not (Test-Path -LiteralPath $specFile)) {
            throw "Missing spec $specFile. Rerun without -SkipFetch."
        }
        continue
    }

    if ($SpecPath) {
        $specJson = Get-Content -LiteralPath $SpecPath -Raw
        if ([System.IO.Path]::GetExtension($SpecPath) -in @('.yaml', '.yml')) {
            $specJson = $specJson | ConvertFrom-Yaml -Ordered | ConvertTo-Json -Depth 99
        }
        Assert-Oas3 -Json $specJson -Source $SpecPath
        Write-Host "[status] Saving $SpecPath to $specFile"
        $specJson | Set-Content -Path $specFile
    } else {
        Get-OasFile -SDKName $name
        Assert-Oas3 -Json (Get-Content -LiteralPath $specFile -Raw) -Source $specFile
    }
}

# 3. Sync the mapping files with the specs
Update-OasMapping

# 4. Every operation needs a method name before generation
$missingNames = foreach ($name in $SDKName) {
    $mappingFile = Join-Path $MappingDir "OASMapping.$name.json"
    $mapping = Get-Content -LiteralPath $mappingFile -Raw | ConvertFrom-Json -AsHashtable
    foreach ($entry in $mapping.GetEnumerator()) {
        if ([string]::IsNullOrWhiteSpace([string]$entry.Value['x-powershell-method-name'])) {
            [PSCustomObject]@{
                SDKName     = $name
                OperationId = $entry.Key
                Method      = $entry.Value['method']
                Path        = $entry.Value['path']
            }
        }
    }
}
if ($missingNames) {
    $missingNames | Sort-Object SDKName, OperationId | Format-Table -AutoSize | Out-String -Width 4096 | Write-Host
    throw ("$(@($missingNames).Count) operation(s) have no x-powershell-method-name. " +
        'Fill them in OAS/mapping/OASMapping.<SDKName>.json, then rerun with -SkipFetch. ' +
        'For Console, python3 OpenAPI/scripts/Fill-OasMappingMethodNames.py fills them but regenerates every name, so review its diff.')
}

# 5. Write the method names into the specs (one SDK per call)
foreach ($name in $SDKName) {
    Add-OasMethodName -SDKName $name
}

# 6. Generate the SDKs
if ($SkipGenerate) {
    Write-Host '[status] Skipping generation (-SkipGenerate)'
} else {
    $target = if ($SDKName.Count -gt 1) { 'all' } else { $GenerateTargets[$SDKName[0]] }
    Write-Host "[status] Running generate-powershell-docker.mjs $target"
    & node $GenerateScript $target
    if ($LASTEXITCODE -ne 0) {
        throw "generate-powershell-docker.mjs $target failed with exit code $LASTEXITCODE"
    }
    foreach ($name in $SDKName) {
        Write-Host "[status] Generated $(Join-Path $OpenApiRoot "PowerShell/JumpCloud.SDK.$name")"
    }
}

# 7. Show which spec and mapping files changed
if (Get-Command -Name 'git' -ErrorAction SilentlyContinue) {
    $changes = & git -C $OpenApiRoot status --short -- OAS
    if ($changes) {
        Write-Host '[status] Spec/mapping changes to review and commit:'
        $changes | ForEach-Object { Write-Host "  $_" }
    } else {
        Write-Host '[status] No spec/mapping changes'
    }
}
