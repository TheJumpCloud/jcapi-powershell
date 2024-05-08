[CmdletBinding()]
param (
    [Parameter(Mandatory = $false, ValueFromPipelineByPropertyName = $true, HelpMessage = 'Name of the API to build an SDK for.', ParameterSetName = 'IndividualSDK')][ValidateSet('JumpCloud.SDK.DirectoryInsights', 'JumpCloud.SDK.V1', 'JumpCloud.SDK.V2')][ValidateNotNullOrEmpty()][System.String[]]$SDKName
)

# build all SDKs if no individual SDK is specified
if (!$SDKName){
    $sdks = @('JumpCloud.SDK.DirectoryInsights', 'JumpCloud.SDK.V1', 'JumpCloud.SDK.V2')
} else {
    $sdks = $SDKName
}
$pathBeforeRun = $pwd
# Build each of the specified SDKs:
$rootPath = "$PSScriptRoot/../"
foreach ($sdk in $sdks){
    # invoke Build Autorest
    . "$rootPath/BuildAutoRest.ps1" -SDKName $sdk | Out-Null
    # update SDK Examples:
    . "$PSscriptRoot/Build-SdkExamples" -SDKName $sdk | Out-Null
    # update module changelog
    . "$PSscriptRoot/Build-SdkChangelog" -SDKName $sdk | Out-Null
}
# CD back to the directory before building the SDKs
Set-Location $pathBeforeRun