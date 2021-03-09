$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Remove-JcSdkApplication.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Remove-JcSdkApplication' {
    It 'Delete' {
        { Remove-JcSdkApplication -Id:($global:PesterTestApplication.Id) } | Should -Not -Throw
    }

    It 'DeleteViaIdentity' -Skip {
        { Remove-JcSdkApplication -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }
}
