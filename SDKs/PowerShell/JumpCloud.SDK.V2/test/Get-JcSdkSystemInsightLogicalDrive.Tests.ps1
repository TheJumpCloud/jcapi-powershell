BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkSystemInsightLogicalDrive.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Get-JcSdkSystemInsightLogicalDrive' -Tag:(""){
    It 'List' {
        { Get-JcSdkSystemInsightLogicalDrive } | Should -Not -Throw
    }

    It 'List Filter Tests' {
        $siDrive = Get-JcSdkSystemInsightLogicalDrive | Get-Random -Count 1
        if ($siDrive) {
            Get-JcSdkSystemInsightLogicalDrive -Filter @("system_id:eq:$($siDrive.systemId)") | Should -Not -BeNullOrEmpty
            Get-JcSdkSystemInsightLogicalDrive -Filter @("system_id:eq:$($siDrive.systemId)", "device_id:eq:$($siDrive.deviceId)") | Should -Not -BeNullOrEmpty
            # device_id accepts strings, fakeString is a fake value
            Get-JcSdkSystemInsightLogicalDrive -Filter @("system_id:eq:$($siDrive.systemId)", "device_id:eq:fakeString") | Should -BeNullOrEmpty
        }
    }
}

