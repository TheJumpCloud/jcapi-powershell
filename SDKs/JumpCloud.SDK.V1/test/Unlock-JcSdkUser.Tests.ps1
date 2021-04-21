$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Unlock-JcSdkUser.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Unlock-JcSdkUser' {
    It 'Unlock' -skip {
        { Unlock-JcSdkUser -Id:($global:PesterTestUser.Id) } | Should -Not -Throw
    }

    It 'UnlockViaIdentity' -skip {
        { Unlock-JcSdkUser -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }
}
