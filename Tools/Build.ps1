# Build each of the SDKs:
$sdks = @('JumpCloud.SDK.DirectoryInsights', 'JumpCloud.SDK.V1', 'JumpCloud.SDK.V2')

$rootPath = "$PSScriptRoot/../"
foreach ($sdk in $sdks){
    # invoke Build Autorest
    . "$rootPath/BuildAutoRest.ps1" -SDKName $sdk | Out-Null
    # update module changelog
    . "$PSscriptRoot/Build-SdkChangelog" -SDKName $sdk | Out-Null
}