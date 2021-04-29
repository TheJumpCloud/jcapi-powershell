$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Lock-JcSdkAppleMdmDevice.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Lock-JcSdkAppleMdmDevice' {
    It 'LockExpanded' -skip {
        { Lock-JcSdkAppleMdmDevice -AppleMdmId:($global:PesterTestAppleMdm.Id) -DeviceId '<String>' -Pin '<String>' } | Should -Not -Throw
    }

    It 'Lock' -skip {
        { Lock-JcSdkAppleMdmDevice -AppleMdmId:($global:PesterTestAppleMdm.Id) -Body:($global:PesterTestAppleMdmDevice) -DeviceId '<String>' } | Should -Not -Throw
    }

    It 'LockViaIdentity' -skip {
        { Lock-JcSdkAppleMdmDevice -Body:($global:PesterTestAppleMdmDevice) -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'LockViaIdentityExpanded' -skip {
        { Lock-JcSdkAppleMdmDevice -InputObject '<IJumpCloudApIsIdentity>' -Pin '<String>' } | Should -Not -Throw
    }
}
