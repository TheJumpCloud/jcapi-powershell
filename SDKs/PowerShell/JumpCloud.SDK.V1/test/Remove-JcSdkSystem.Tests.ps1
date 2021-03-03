$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath))
{
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Remove-JcSdkSystem.Recording.json'
$currentPath = $PSScriptRoot
while (-not $mockingPath)
{
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Remove-JcSdkSystem' {
    It 'Delete' {
        { Remove-JcSdkRadJcSdkSystem -Id:($global:PesterTestSystem.Id) } | Should -Not -Throw
    }

    It 'DeleteViaIdentity' -Skip {
        Remove-JcSdkSystem -InputObject '<IJumpCloudApIsIdentity>'
    }
}