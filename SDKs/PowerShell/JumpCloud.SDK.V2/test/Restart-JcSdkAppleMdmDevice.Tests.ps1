$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Restart-JcSdkAppleMdmDevice.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Restart-JcSdkAppleMdmDevice' {
    It 'Restart' -skip {
        { Restart-JcSdkAppleMdmDevice -AppleMdmId '<String>' -DeviceId '<String>' } | Should -Not -Throw
    }

    It 'RestartViaIdentity' -skip {
        { Restart-JcSdkAppleMdmDevice -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }
}
