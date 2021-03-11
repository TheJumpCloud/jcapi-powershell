$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Sync-JcSdkAppleMdmDevice.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Sync-JcSdkAppleMdmDevice' {
    It 'Sync' -skip {
        { Sync-JcSdkAppleMdmDevice -AppleMdmId:($global:PesterTestAppleMdm.Id) } | Should -Not -Throw
    }

    It 'SyncViaIdentity' -skip {
        { Sync-JcSdkAppleMdmDevice -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }
}
