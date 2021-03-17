$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Lock-JcSdkSystem.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Lock-JcSdkSystem' {
    It 'Lock' -skip {
        { Lock-JcSdkSystem -SystemId:($global:PesterTestSystem.Id) } | Should -Not -Throw
    }

    It 'LockViaIdentity' -skip {
        { Lock-JcSdkSystem -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }
}
