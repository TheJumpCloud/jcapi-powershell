[CmdletBinding()]
param (
    [Parameter(Mandatory = $true, HelpMessage = 'The type of version bump.')]
    [ValidateSet('major', 'minor', 'patch', 'manual')]
    [System.String]
    $VersionType,

    [Parameter(Mandatory = $true, ValueFromPipelineByPropertyName = $true, HelpMessage = 'Name of the API to build an SDK for.', ParameterSetName = 'IndividualSDK')]
    [ValidateSet('JumpCloud.SDK.DirectoryInsights', 'JumpCloud.SDK.V1', 'JumpCloud.SDK.V2')]
    [ValidateNotNullOrEmpty()]
    [System.String[]]
    $SDKName
)

#TODO: Enable this if you want to build all SDKs by default.
# If no individual SDK is specified, build all of them.
# if (!$SDKName) {
#     $sdks = @('JumpCloud.SDK.DirectoryInsights', 'JumpCloud.SDK.V1', 'JumpCloud.SDK.V2')
# }
# else {
#     $sdks = $SDKName
# }

# Store the current path to return to it after the script finishes.
$pathBeforeRun = $pwd
$rootPath = "$PSScriptRoot/../"

# Build each of the specified SDKs.
foreach ($sdk in $sdks) {
    Write-Host "Building $sdk with version type: $VersionType"

    # Invoke Build Autorest and pass the version type.
    . "$rootPath/BuildAutoRest.ps1" -SDKName $sdk -VersionType $VersionType | Out-Null

    # Update SDK Examples and pass the version type.
    . "$PSscriptRoot/Build-SdkExamples" -SDKName $sdk | Out-Null

    # Update module changelog and pass the version type.
    . "$PSscriptRoot/Build-SdkChangelog" -SDKName $sdk | Out-Null
}

# Return to the original directory.
Set-Location $pathBeforeRun