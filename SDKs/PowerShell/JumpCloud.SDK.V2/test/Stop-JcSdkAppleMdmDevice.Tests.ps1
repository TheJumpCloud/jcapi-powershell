BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Stop-JcSdkAppleMdmDevice.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Stop-JcSdkAppleMdmDevice' {
    It 'Stop' -skip {
        { Stop-JcSdkAppleMdmDevice -AppleMdmId:($global:PesterTestAppleMdm.Id) -DeviceId '<String>' } | Should -Not -Throw
    }

    It 'StopViaIdentity' -skip {
        { Stop-JcSdkAppleMdmDevice -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }
}

