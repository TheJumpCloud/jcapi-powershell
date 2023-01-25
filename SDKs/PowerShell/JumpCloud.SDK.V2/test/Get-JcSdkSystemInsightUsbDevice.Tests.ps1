BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkSystemInsightUsbDevice.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Get-JcSdkSystemInsightUsbDevice' -Tag:(""){
    It 'List' {
        { Get-JcSdkSystemInsightUsbDevice } | Should -Not -Throw
    }

    It 'List Filter Tests' {
        $siUSB = Get-JcSdkSystemInsightUsbDevice | Get-Random -Count 1
        if ($siUSB) {
            Get-JcSdkSystemInsightUsbDevice -Filter @("system_id:eq:$($siUSB.systemId)") | Should -Not -BeNullOrEmpty
            Get-JcSdkSystemInsightUsbDevice -Filter @("system_id:eq:$($siUSB.systemId)", "model:eq:$($siUSB.model)") | Should -Not -BeNullOrEmpty
            # model accepts strings, fakeString is a fake value
            Get-JcSdkSystemInsightUsbDevice -Filter @("system_id:eq:$($siUSB.systemId)", "model:eq:fakeString") | Should -BeNullOrEmpty
        }
    }
}

