#Requires -Version 7.0
<#
.SYNOPSIS
    Renders templates/powershell/configuration.mustache for a JumpCloud OpenAPI SDK.
.DESCRIPTION
    Used by tests and to refresh generated Client/JcSdkConfiguration.ps1 without a
    full Docker regen. Expands the limited mustache tokens we rely on.
    (PowerShell/ is the release artifact; templates remain the regen source of truth.)
#>
[CmdletBinding()]
param(
    [Parameter(Mandatory = $true)]
    [ValidateSet('Console', 'DirectoryInsights')]
    [string]$SdkName,

    [Parameter(Mandatory = $false)]
    [string]$OutputPath
)

$ErrorActionPreference = 'Stop'
$root = Split-Path $PSScriptRoot -Parent
$templatePath = Join-Path $root 'templates/powershell/configuration.mustache'
$headerPath = Join-Path $root 'templates/powershell/partial_header.mustache'

$defaults = @{
    Console = @{
        BasePath = 'https://console.jumpcloud.com'
        Servers  = @(
            @{ Url = 'https://console.jumpcloud.com'; Description = 'United States (US)' }
            @{ Url = 'https://console.eu.jumpcloud.com'; Description = 'European Union (EU)' }
            @{ Url = 'https://console.in.jumpcloud.com'; Description = 'India (IN)' }
        )
        DefaultOutput = (Join-Path $root 'PowerShell/JumpCloud.SDK.Console/src/JumpCloud.SDK.Console/Client/JcSdkConfiguration.ps1')
    }
    DirectoryInsights = @{
        BasePath = 'https://api.jumpcloud.com/insights/directory'
        Servers  = @(
            @{ Url = 'https://api.jumpcloud.com/insights/directory'; Description = 'United States (US)' }
            @{ Url = 'https://api.eu.jumpcloud.com/insights/directory'; Description = 'European Union (EU)' }
            @{ Url = 'https://api.in.jumpcloud.com/insights/directory'; Description = 'India (IN)' }
        )
        DefaultOutput = (Join-Path $root 'PowerShell/JumpCloud.SDK.DirectoryInsights/src/JumpCloud.SDK.DirectoryInsights/Client/JcSdkConfiguration.ps1')
    }
}

$cfg = $defaults[$SdkName]
$prefix = 'JcSdk'
$header = (Get-Content -Path $headerPath -Raw).TrimEnd() + "`n"
$text = Get-Content -Path $templatePath -Raw

$text = $text.Replace('{{> partial_header}}', $header)
$text = $text.Replace('{{{apiNamePrefix}}}', $prefix)
$text = $text.Replace('{{apiNamePrefix}}', $prefix)
$text = $text.Replace('{{{basePath}}}', $cfg.BasePath)

# Expand {{#servers}} ... {{/servers}} block inside Get-JcSdkHostSetting
$serverLines = foreach ($i in 0..($cfg.Servers.Count - 1)) {
    $s = $cfg.Servers[$i]
    $comma = if ($i -lt $cfg.Servers.Count - 1) { ',' } else { '' }
    @(
        '          @{'
        "            `"Url`" = `"$($s.Url)`";"
        "            `"Description`" = `"$($s.Description)`";"
        "          }$comma"
    ) -join "`n"
}
$serversBlock = ($serverLines -join "`n") + "`n"

$text = [regex]::Replace(
    $text,
    '(?s)\{\{#servers\}\}.*?\{\{/servers\}\}',
    [System.Text.RegularExpressions.MatchEvaluator]{ param($m) $serversBlock }
)

# Drop any leftover mustache tags from unused variable sections (none for these specs)
if ($text -match '\{\{') {
    throw "Unresolved mustache tokens remain after render for $SdkName"
}

if (-not $OutputPath) {
    $OutputPath = $cfg.DefaultOutput
}

$dir = Split-Path $OutputPath -Parent
if (-not (Test-Path $dir)) {
    New-Item -ItemType Directory -Path $dir -Force | Out-Null
}
Set-Content -Path $OutputPath -Value ($text.TrimEnd() + "`n")
Write-Host "[render] Wrote $OutputPath"
