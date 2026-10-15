#Requires -Version 7.0
<#
.SYNOPSIS
    Smoke tests for the Expanded / ByBody parameter sets on the generated Console SDK.

.DESCRIPTION
    Verifies that expanded body parameters are declared, that only bound parameters reach the
    request body (so unset properties are never sent as null), that the whole-object -Body
    parameter set still works, and that duplicate-parameter collisions were repaired.

    Cmdlets are invoked with a stubbed Invoke-JcSdkApiClient so the request body can be
    inspected without any network calls.
#>
[CmdletBinding()]
param(
    [string]$GeneratedRoot = (Join-Path (Split-Path $PSScriptRoot -Parent) 'PowerShell/JumpCloud.SDK.Console')
)

Set-StrictMode -Version Latest
$ErrorActionPreference = 'Stop'

$pkg = Join-Path $GeneratedRoot 'src/JumpCloud.SDK.Console'
$apiDir = Join-Path $pkg 'Api'
$privateDir = Join-Path $pkg 'Private'

. (Join-Path $privateDir 'Get-CommonParameters.ps1')
. (Join-Path $privateDir 'Out-DebugParameter.ps1')
. (Join-Path $apiDir 'JcSdkSystemusersApi.ps1')
. (Join-Path $apiDir 'JcSdkCustomEmailsApi.ps1')
. (Join-Path $apiDir 'JcSdkSoftwareappsApi.ps1')
. (Join-Path $pkg 'Model/Systemuserput.ps1')

$script:CapturedBody = $null

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
    return @{ Response = $null }
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

Test-Case 'All generated API files parse' {
    $bad = @()
    foreach ($file in Get-ChildItem -LiteralPath $apiDir -Filter '*.ps1') {
        $errors = $null
        $null = [System.Management.Automation.Language.Parser]::ParseFile($file.FullName, [ref]$null, [ref]$errors)
        if ($errors.Count -gt 0) { $bad += "$($file.Name): $($errors[0].Message)" }
    }
    if ($bad.Count -gt 0) { throw ($bad -join '; ') }
}

Test-Case 'Set-JcSdkSystemUser exposes Expanded properties and a -Body parameter set' {
    $cmd = Get-Command Set-JcSdkSystemUser
    if (-not $cmd.Parameters.ContainsKey('Firstname')) { throw 'Firstname parameter missing' }
    if ($cmd.Parameters['Firstname'].ParameterSets.Keys -notcontains 'Expanded') {
        throw 'Firstname is not in the Expanded parameter set'
    }
    if (-not $cmd.Parameters.ContainsKey('Body')) { throw 'Body parameter missing' }
    if ($cmd.Parameters['Body'].ParameterSets.Keys -notcontains 'ByBody') {
        throw 'Body is not in the ByBody parameter set'
    }
    if ($cmd.DefaultParameterSet -ne 'Expanded') { throw "Default set is $($cmd.DefaultParameterSet)" }
}

Test-Case 'Expanded call sends only the parameters that were supplied' {
    $script:CapturedBody = $null
    Set-JcSdkSystemUser -Id 'abc123' -Firstname 'Ada' -Lastname 'Lovelace' | Out-Null
    if (-not $script:CapturedBody) { throw 'No body captured' }
    $sent = $script:CapturedBody | ConvertFrom-Json -AsHashtable
    $keys = ($sent.Keys | Sort-Object) -join ','
    if ($keys -ne 'firstname,lastname') { throw "Body keys were '$keys'" }
    if ($script:CapturedBody -match 'null') { throw "Body contains nulls: $script:CapturedBody" }
}

Test-Case 'Expanded call keeps path parameters out of the request body' {
    $script:CapturedBody = $null
    Set-JcSdkSystemUser -Id 'abc123' -Email 'ada@example.com' | Out-Null
    $sent = $script:CapturedBody | ConvertFrom-Json -AsHashtable
    if ($sent.ContainsKey('id')) { throw 'Path parameter id leaked into the body' }
    if ($sent['email'] -ne 'ada@example.com') { throw "Unexpected body: $script:CapturedBody" }
}

Test-Case 'ByBody call serializes the supplied object' {
    $script:CapturedBody = $null
    $body = Initialize-JcSdkSystemuserput -Firstname 'Grace'
    Set-JcSdkSystemUser -Id 'abc123' -Body $body | Out-Null
    $sent = $script:CapturedBody | ConvertFrom-Json -AsHashtable
    if ($sent.Keys.Count -ne 1 -or $sent['firstname'] -ne 'Grace') {
        throw "Unexpected body: $script:CapturedBody"
    }
}

Test-Case 'Initialize-JcSdkSystemuserput omits unbound properties' {
    $json = Initialize-JcSdkSystemuserput -Firstname 'Bob' -Lastname 'Smith' | ConvertTo-Json -Compress
    if ($json -match 'null') { throw "Emitted nulls: $json" }
    $sent = $json | ConvertFrom-Json -AsHashtable
    if ($sent.Keys.Count -ne 2) { throw "Expected 2 properties, got $($sent.Keys.Count): $json" }
}

Test-Case 'Body property colliding with a path parameter is dropped from Expanded' {
    $cmd = Get-Command Set-JcSdkSoftwareApp
    $idSets = @($cmd.Parameters['Id'].Attributes |
        Where-Object { $_ -is [System.Management.Automation.ParameterAttribute] } |
        ForEach-Object { $_.ParameterSetName })
    if (@($idSets | Where-Object { $_ -eq 'Expanded' }).Count -ne 1) {
        throw "Expected exactly one Expanded declaration of Id, found $(@($idSets | Where-Object { $_ -eq 'Expanded' }).Count)"
    }
}

Test-Case 'Model with a body property keeps -Body expanded and renames the container' {
    $cmd = Get-Command Set-JcSdkCustomEmail
    if ($cmd.Parameters['Body'].ParameterType -ne [string]) {
        throw "Expected the email body to stay a String, got $($cmd.Parameters['Body'].ParameterType)"
    }
    if (-not $cmd.Parameters.ContainsKey('BodyObject')) { throw 'BodyObject container missing' }

    $script:CapturedBody = $null
    Set-JcSdkCustomEmail -CustomEmailType 'activate_user_custom' -Body '<html>hi</html>' | Out-Null
    $sent = $script:CapturedBody | ConvertFrom-Json -AsHashtable
    if ($sent['body'] -ne '<html>hi</html>') { throw "Body property not sent: $script:CapturedBody" }

    $script:CapturedBody = $null
    Set-JcSdkCustomEmail -CustomEmailType 'activate_user_custom' -BodyObject ([PSCustomObject]@{ body = 'x' }) | Out-Null
    $sent = $script:CapturedBody | ConvertFrom-Json -AsHashtable
    if ($sent['body'] -ne 'x') { throw "Container not serialized: $script:CapturedBody" }
}

if ($failures.Count -gt 0) {
    Write-Error "Failed test(s): $($failures -join ', ')"
    exit 1
}

Write-Host 'All expand-body smoke tests passed.'
