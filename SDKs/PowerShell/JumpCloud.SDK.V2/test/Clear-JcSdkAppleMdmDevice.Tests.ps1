$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Clear-JcSdkAppleMdmDevice.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Clear-JcSdkAppleMdmDevice' {
    It 'ClearExpanded' -skip {
        { Clear-JcSdkAppleMdmDevice -AppleMdmId '<String>' -DeviceId '<String>' -Pin '<String>' } | Should -Not -Throw
    }

    It 'Clear' -skip {
        { Clear-JcSdkAppleMdmDevice -AppleMdmId '<String>' -Body '<IPaths1FfbqfwApplemdmsAppleMdmIdDevicesDeviceIdErasePostRequestbodyContentApplicationJsonSchema>' -DeviceId '<String>' } | Should -Not -Throw
    }

    It 'ClearViaIdentity' -skip {
        { Clear-JcSdkAppleMdmDevice -Body '<IPaths1FfbqfwApplemdmsAppleMdmIdDevicesDeviceIdErasePostRequestbodyContentApplicationJsonSchema>' -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'ClearViaIdentityExpanded' -skip {
        { Clear-JcSdkAppleMdmDevice -InputObject '<IJumpCloudApIsIdentity>' -Pin '<String>' } | Should -Not -Throw
    }
}
