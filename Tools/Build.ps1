[CmdletBinding()]
param (
    [Parameter(Mandatory = $true, HelpMessage = 'The type of version bump.')]
    [ValidateSet('major', 'minor', 'patch', 'manual')]
    [System.String]
    $VersionType,

    [Parameter(Mandatory = $false, HelpMessage = 'The manual module version to set when VersionType is manual.')]
    [ValidateNotNullOrEmpty()]
    [System.String]
    $ManualModuleVersion = '',

    [Parameter(Mandatory = $true, ValueFromPipelineByPropertyName = $true, HelpMessage = 'Name of the API to build an SDK for.', ParameterSetName = 'IndividualSDK')]
    [ValidateSet('JumpCloud.SDK.DirectoryInsights', 'JumpCloud.SDK.V1', 'JumpCloud.SDK.V2')]
    [ValidateNotNullOrEmpty()]
    [System.String[]]
    $SDKName
)

# If no individual SDK is specified, build all of them.
if (!$SDKName) {
    $sdks = @('JumpCloud.SDK.DirectoryInsights', 'JumpCloud.SDK.V1', 'JumpCloud.SDK.V2')
}
else {
    $sdks = $SDKName
}

# Store the current path to return to it after the script finishes.
$pathBeforeRun = $pwd
$rootPath = "$PSScriptRoot/../"

# start stopwatch to measure build time
$stopwatch = [System.Diagnostics.Stopwatch]::StartNew()
# Build each of the specified SDKs.
foreach ($sdk in $sdks) {
    Write-Host "Building $sdk with version type: $VersionType"

    if ($VersionType -eq 'manual') {
        . "$rootPath/BuildAutoRest.ps1" -SDKName $sdk -ManualModuleVersion $ManualModuleVersion -ModuleVersionIncrementType $VersionType| Out-Null
    } else {
        # Invoke Build Autorest and pass the version type.
        . "$rootPath/BuildAutoRest.ps1" -SDKName $sdk -ModuleVersionIncrementType $VersionType | Out-Null
    }

    # Update SDK Examples and pass the version type.
    . "$PSscriptRoot/Build-SdkExamples" -SDKName $sdk | Out-Null

    # Update module changelog and pass the version type.
    . "$PSscriptRoot/Build-SdkChangelog" -SDKName $sdk | Out-Null
}
# Stop the stopwatch
$stopwatch.Stop()
$elapsedTime = $stopwatch.Elapsed
if ($IsMacOS -and (Get-InstalledModule -Name "MacNotify")){
    Invoke-MacNotification 'SDK Build completed' -Title "$($SDKName) Built" -Subtitle "Build took $($elapsedTime.TotalSeconds) seconds" -Sound 'Ping'
}

# Return to the original directory.
Set-Location $pathBeforeRun