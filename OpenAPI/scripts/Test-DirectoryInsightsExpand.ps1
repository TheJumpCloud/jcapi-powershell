#Requires -Version 7.0
<#
.SYNOPSIS
    Smoke tests for Directory Insights Expanded / ByBody parameter sets and pagination.
#>
[CmdletBinding()]
param(
    [string]$GeneratedRoot = (Join-Path (Split-Path $PSScriptRoot -Parent) 'PowerShell/JumpCloud.SDK.DirectoryInsights')
)

Set-StrictMode -Version Latest
$ErrorActionPreference = 'Stop'

$pkg = Join-Path $GeneratedRoot 'src/JumpCloud.SDK.DirectoryInsights'
$apiDir = Join-Path $pkg 'Api'
$privateDir = Join-Path $pkg 'Private'
$modelDir = Join-Path $pkg 'Model'

. (Join-Path $privateDir 'Get-CommonParameters.ps1')
. (Join-Path $privateDir 'Out-DebugParameter.ps1')
. (Join-Path $apiDir 'JcSdkEventQueryApi.ps1')
. (Join-Path $modelDir 'EventQuery.ps1')

$script:CapturedBody = $null
$script:CapturedUri = $null

function Get-JcSdkConfiguration {
    @{ ApiKey = @{ 'x-api-key' = 'test-key' }; ApiKeyPrefix = @{} }
}

function Invoke-JcSdkApiClient {
    [CmdletBinding()]
    param(
        $Method, $Uri, $Accepts, $ContentTypes, $Body, $HeaderParameters,
        $QueryParameters, $FormParameters, $CookieParameters, $ReturnType, $IsBodyNullable
    )
    $script:CapturedBody = $Body
    $script:CapturedUri = $Uri
    return @{
        Response = @(@{ id = 'evt-1' })
        Headers  = @{
            'X-Search_after' = '["cursor"]'
            'X-Result-Count' = '1'
            'X-Limit'        = '100'
        }
        StatusCode = 200
    }
}

$failures = [System.Collections.Generic.List[string]]::new()

function Test-Case {
    param(
        [Parameter(Mandatory)][string]$Name,
        [Parameter(Mandatory)][scriptblock]$Test
    )
    try {
        & $Test
        Write-Host "PASS: $Name"
    } catch {
        Write-Host "FAIL: $Name - $($_.Exception.Message)"
        $failures.Add($Name)
    }
}

Test-Case 'Get-JcSdkEvents API file parses' {
    $errors = $null
    $null = [System.Management.Automation.Language.Parser]::ParseFile(
        (Join-Path $apiDir 'JcSdkEventQueryApi.ps1'),
        [ref]$null,
        [ref]$errors
    )
    if ($errors.Count -gt 0) { throw $errors[0].Message }
}

Test-Case 'Get-JcSdkEvents exposes Expanded -Service/-StartTime and ByBody -Body' {
    $cmd = Get-Command Get-JcSdkEvents
    foreach ($name in @('Service', 'StartTime', 'SearchAfter', 'Limit')) {
        if (-not $cmd.Parameters.ContainsKey($name)) { throw "$name parameter missing" }
        if ($cmd.Parameters[$name].ParameterSets.Keys -notcontains 'Expanded') {
            throw "$name is not in the Expanded parameter set"
        }
    }
    if (-not $cmd.Parameters.ContainsKey('Body')) { throw 'Body parameter missing' }
    if ($cmd.Parameters['Body'].ParameterSets.Keys -notcontains 'ByBody') {
        throw 'Body is not in the ByBody parameter set'
    }
    if ($cmd.DefaultParameterSet -ne 'Expanded') { throw "Default set is $($cmd.DefaultParameterSet)" }
    if (-not $cmd.Parameters.ContainsKey('Paginate')) { throw 'Paginate parameter missing on list events' }
    $serviceMandatory = @($cmd.Parameters['Service'].Attributes | Where-Object {
            $_ -is [System.Management.Automation.ParameterAttribute] -and $_.ParameterSetName -eq 'Expanded' -and $_.Mandatory
        })
    if ($serviceMandatory.Count -eq 0) { throw 'Service should be Mandatory on Expanded' }
    $startMandatory = @($cmd.Parameters['StartTime'].Attributes | Where-Object {
            $_ -is [System.Management.Automation.ParameterAttribute] -and $_.ParameterSetName -eq 'Expanded' -and $_.Mandatory
        })
    if ($startMandatory.Count -eq 0) { throw 'StartTime should be Mandatory on Expanded' }
}

Test-Case 'Get-JcSdkEvents source rejects empty Expanded body' {
    $apiText = Get-Content -LiteralPath (Join-Path $apiDir 'JcSdkEventQueryApi.ps1') -Raw
    if ($apiText -notmatch 'No Expanded body parameters were provided') {
        throw 'Missing empty-Expanded-body guard in Get-JcSdkEvents'
    }
    if ($apiText -notmatch 'Mandatory = \$true[^\n]*\r?\n[^\n]*\r?\n[^\n]*\r?\n\s*\$\{Service\}') {
        throw 'Service is not marked Mandatory = $true in generated API'
    }
}

Test-Case 'Docs use Expanded examples without Initialize-*' {
    $doc = Join-Path $GeneratedRoot 'docs/JcSdkEventQueryApi.md'
    $text = Get-Content -LiteralPath $doc -Raw
    if ($text -match 'Initialize-JcSdk') {
        throw 'Docs still reference Initialize-JcSdk* helpers'
    }
    if ($text -notmatch 'Get-JcSdkEvents -Service') {
        throw 'Docs missing Expanded Get-JcSdkEvents -Service example'
    }
    if ($text -match '\[-Service\] <String\[>') {
        throw 'Docs still have truncated String[ type for -Service'
    }
    if ($text -match '\[-StartTime\] <System\.Nullable\[System\.DateTime>') {
        throw 'Docs still have truncated DateTime type for -StartTime'
    }
}

Test-Case 'Get-JcSdkEventsCount is not auto-paginated' {
    $cmd = Get-Command Get-JcSdkEventsCount
    if ($cmd.Parameters.ContainsKey('Paginate')) {
        throw 'Count cmdlet should not have $Paginate'
    }
    if (-not $cmd.Parameters.ContainsKey('Service')) {
        throw 'Count cmdlet should still expose Expanded -Service'
    }
}

Test-Case 'Expanded Get-JcSdkEvents sends only supplied body keys' {
    $script:CapturedBody = $null
    Get-JcSdkEvents -Service @('all') -StartTime ([datetime]'2021-07-14T23:00:00Z') -Paginate:$false | Out-Null
    if (-not $script:CapturedBody) { throw 'No body captured' }
    $sent = $script:CapturedBody | ConvertFrom-Json -AsHashtable
    $keys = @($sent.Keys | Sort-Object)
    if (($keys -join ',') -ne 'service,start_time') {
        throw "Body keys were '$($keys -join ',')'"
    }
}

Test-Case 'ByBody Get-JcSdkEvents serializes Initialize-JcSdkEventQuery' {
    $script:CapturedBody = $null
    $body = Initialize-JcSdkEventQuery -Service @('directory') -StartTime ([datetime]'2021-07-14T23:00:00Z')
    Get-JcSdkEvents -Body $body -Paginate:$false | Out-Null
    $sent = $script:CapturedBody | ConvertFrom-Json -AsHashtable
    if ($sent['service'][0] -ne 'directory') { throw "Unexpected body: $script:CapturedBody" }
    if (-not $sent.ContainsKey('start_time')) { throw 'start_time missing from ByBody payload' }
}

if ($failures.Count -gt 0) {
    Write-Error "Failed test(s): $($failures -join ', ')"
    exit 1
}

Write-Host 'All Directory Insights expand/pagination smoke tests passed.'
