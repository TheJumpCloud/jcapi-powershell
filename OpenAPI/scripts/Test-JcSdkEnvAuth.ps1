#Requires -Version 7.0
<#
.SYNOPSIS
    Unit tests for JCApiKey / JCOrgId / JCEnvironment auth in OpenAPI configuration templates.
#>
[CmdletBinding()]
param()

$ErrorActionPreference = 'Stop'
$root = Split-Path $PSScriptRoot -Parent
$failed = 0
$passed = 0

function Test-Case {
    param([string]$Name, [scriptblock]$Body)
    try {
        & $Body
        Write-Host "PASS  $Name" -ForegroundColor Green
        $script:passed++
    } catch {
        Write-Host "FAIL  $Name : $_" -ForegroundColor Red
        $script:failed++
    }
}

function Invoke-WithCleanEnv {
    param([scriptblock]$Body, [hashtable]$Env = @{})
    $names = @('JCApiKey', 'JCOrgId', 'JCEnvironment')
    $saved = @{}
    foreach ($n in $names) {
        $saved[$n] = [Environment]::GetEnvironmentVariable($n)
        [Environment]::SetEnvironmentVariable($n, $null)
    }
    foreach ($k in $Env.Keys) {
        [Environment]::SetEnvironmentVariable($k, $Env[$k])
    }
    try {
        & $Body
    } finally {
        foreach ($n in $names) {
            [Environment]::SetEnvironmentVariable($n, $saved[$n])
        }
    }
}

# Render configuration from template into a temp file and dot-source it
$tmpDir = Join-Path ([System.IO.Path]::GetTempPath()) ("jc-oas-auth-" + [guid]::NewGuid().ToString('n'))
New-Item -ItemType Directory -Path $tmpDir -Force | Out-Null
try {
    $cfgPath = Join-Path $tmpDir 'JcSdkConfiguration.ps1'
    & (Join-Path $PSScriptRoot 'Render-ConfigurationFromTemplate.ps1') -SdkName Console -OutputPath $cfgPath | Out-Null

    $Script:Configuration = [hashtable]@{}
    . $cfgPath

    Test-Case 'Env credentials populate ApiKey and DefaultHeaders' {
        Invoke-WithCleanEnv -Env @{ JCApiKey = 'key-1'; JCOrgId = 'org-1'; JCEnvironment = 'STANDARD' } -Body {
            $Script:Configuration = [hashtable]@{}
            $c = Get-JcSdkConfiguration
            if ($c.ApiKey['x-api-key'] -ne 'key-1') { throw "ApiKey x-api-key='$($c.ApiKey['x-api-key'])'" }
            if ($c.ApiKey['x-org-id'] -ne 'org-1') { throw "ApiKey x-org-id='$($c.ApiKey['x-org-id'])'" }
            if ($c.DefaultHeaders['x-api-key'] -ne 'key-1') { throw 'DefaultHeaders missing x-api-key' }
            if ($c.DefaultHeaders['x-org-id'] -ne 'org-1') { throw 'DefaultHeaders missing x-org-id' }
            if ($c.BaseUrl -ne 'https://console.jumpcloud.com') { throw "BaseUrl=$($c.BaseUrl)" }
        }
    }

    Test-Case 'JCEnvironment EU selects EU base URL' {
        Invoke-WithCleanEnv -Env @{ JCApiKey = 'k'; JCOrgId = 'o'; JCEnvironment = 'EU' } -Body {
            $Script:Configuration = [hashtable]@{}
            $c = Get-JcSdkConfiguration
            if ($c.BaseUrl -ne 'https://console.eu.jumpcloud.com') { throw "BaseUrl=$($c.BaseUrl)" }
        }
    }

    Test-Case 'JCEnvironment IN selects IN base URL' {
        Invoke-WithCleanEnv -Env @{ JCApiKey = 'k'; JCOrgId = 'o'; JCEnvironment = 'IN' } -Body {
            $Script:Configuration = [hashtable]@{}
            $c = Get-JcSdkConfiguration
            if ($c.BaseUrl -ne 'https://console.in.jumpcloud.com') { throw "BaseUrl=$($c.BaseUrl)" }
        }
    }

    Test-Case 'JCEnvironment US aliases STANDARD' {
        Invoke-WithCleanEnv -Env @{ JCApiKey = 'k'; JCOrgId = 'o'; JCEnvironment = 'US' } -Body {
            $Script:Configuration = [hashtable]@{}
            $c = Get-JcSdkConfiguration
            if ($c.BaseUrl -ne 'https://console.jumpcloud.com') { throw "BaseUrl=$($c.BaseUrl)" }
        }
    }

    Test-Case 'Missing JCEnvironment defaults to STANDARD and sets env var' {
        Invoke-WithCleanEnv -Env @{ JCApiKey = 'k'; JCOrgId = 'o' } -Body {
            $Script:Configuration = [hashtable]@{}
            $c = Get-JcSdkConfiguration
            if ($c.BaseUrl -ne 'https://console.jumpcloud.com') { throw "BaseUrl=$($c.BaseUrl)" }
            if ($env:JCEnvironment -ne 'STANDARD') { throw "JCEnvironment=$env:JCEnvironment" }
        }
    }

    Test-Case 'Explicit Set-JcSdkConfiguration -BaseUrl is preserved' {
        Invoke-WithCleanEnv -Env @{ JCApiKey = 'k'; JCOrgId = 'o'; JCEnvironment = 'EU' } -Body {
            $Script:Configuration = [hashtable]@{}
            Set-JcSdkConfiguration -BaseUrl 'https://custom.example.com'
            $c = Get-JcSdkConfiguration
            if ($c.BaseUrl -ne 'https://custom.example.com') { throw "BaseUrl=$($c.BaseUrl)" }
        }
    }

    Test-Case 'Set-JcSdkConfiguration -ApiKey works without env vars' {
        Invoke-WithCleanEnv -Body {
            $Script:Configuration = [hashtable]@{}
            Set-JcSdkConfiguration -ApiKey @{ 'x-api-key' = 'cfg-key'; 'x-org-id' = 'cfg-org' }
            function Test-JcSdkIsInteractiveHost { return $false }
            $c = Get-JcSdkConfiguration
            if ($c.ApiKey['x-api-key'] -ne 'cfg-key') { throw "ApiKey=$($c.ApiKey['x-api-key'])" }
            if ($c.ApiKey['x-org-id'] -ne 'cfg-org') { throw "OrgId=$($c.ApiKey['x-org-id'])" }
        }
    }

    Test-Case 'Non-interactive missing JCApiKey throws clearly' {
        Invoke-WithCleanEnv -Env @{ JCOrgId = 'o' } -Body {
            $Script:Configuration = [hashtable]@{}
            # Force non-interactive path by stubbing the interactive check
            function Test-JcSdkIsInteractiveHost { return $false }
            $threw = $false
            try {
                $null = Get-JcSdkConfiguration
            } catch {
                $threw = $true
                if ("$_" -notmatch 'JCApiKey') { throw "Unexpected message: $_" }
            }
            if (-not $threw) { throw 'Expected throw for missing JCApiKey' }
        }
    }

    Test-Case 'Non-interactive missing JCOrgId throws clearly' {
        Invoke-WithCleanEnv -Env @{ JCApiKey = 'k' } -Body {
            $Script:Configuration = [hashtable]@{}
            function Test-JcSdkIsInteractiveHost { return $false }
            $threw = $false
            try {
                $null = Get-JcSdkConfiguration
            } catch {
                $threw = $true
                if ("$_" -notmatch 'JCOrgId') { throw "Unexpected message: $_" }
            }
            if (-not $threw) { throw 'Expected throw for missing JCOrgId' }
        }
    }

    Test-Case 'DirectoryInsights base URL maps for EU' {
        $diPath = Join-Path $tmpDir 'JcSdkConfiguration.DI.ps1'
        & (Join-Path $PSScriptRoot 'Render-ConfigurationFromTemplate.ps1') -SdkName DirectoryInsights -OutputPath $diPath | Out-Null
        Invoke-WithCleanEnv -Env @{ JCApiKey = 'k'; JCOrgId = 'o'; JCEnvironment = 'EU' } -Body {
            $Script:Configuration = [hashtable]@{}
            . $diPath
            $c = Get-JcSdkConfiguration
            if ($c.BaseUrl -ne 'https://api.eu.jumpcloud.com/insights/directory') {
                throw "BaseUrl=$($c.BaseUrl)"
            }
        }
    }

    # DefaultHeaders merge / MTP strip — exercise the mustache snippet as PowerShell
    Test-Case 'DefaultHeaders do not overwrite existing operation headers' {
        $HeaderParameters = @{ 'x-org-id' = 'from-param' }
        $DefaultHeaders = @{ 'x-org-id' = 'from-env'; 'x-api-key' = 'key' }
        foreach ($header in $DefaultHeaders.GetEnumerator()) {
            if (-not $HeaderParameters.ContainsKey($header.Name)) {
                $HeaderParameters[$header.Name] = $header.Value
            }
        }
        if ($HeaderParameters['x-org-id'] -ne 'from-param') { throw 'overwrote XOrgId' }
        if ($HeaderParameters['x-api-key'] -ne 'key') { throw 'missing api key default' }
    }

    Test-Case 'MTP paths strip x-org-id' {
        $Uri = '/api/organizations'
        $HeaderParameters = @{ 'x-org-id' = 'org'; 'x-api-key' = 'key' }
        $mtpUrls = @(
            '/api/search/organizations',
            '/api/organizations',
            '/api/users',
            '/api/v2/organizations',
            '/api/v2/administrators',
            '/api/v2/providers',
            '/api/v2/integrations/'
        )
        foreach ($mtpUrl in $mtpUrls) {
            if ($HeaderParameters.ContainsKey('x-org-id') -and $Uri.StartsWith($mtpUrl)) {
                $HeaderParameters.Remove('x-org-id') | Out-Null
            }
        }
        if ($HeaderParameters.ContainsKey('x-org-id')) { throw 'x-org-id not stripped' }
        if ($HeaderParameters['x-api-key'] -ne 'key') { throw 'api key removed' }
    }

} finally {
    Remove-Item -Recurse -Force $tmpDir -ErrorAction SilentlyContinue
}

Write-Host ""
Write-Host "Passed: $passed  Failed: $failed"
if ($failed -gt 0) { exit 1 }
exit 0
