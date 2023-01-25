BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkSystemInsightWifiStatus.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Get-JcSdkSystemInsightWifiStatus' -Tag:(""){
    It 'List' {
        { Get-JcSdkSystemInsightWifiStatus } | Should -Not -Throw
    }

    It 'List Filter Tests' {
        $siWiFiStatus = Get-JcSdkSystemInsightWifiStatus | Get-Random -Count 1
        if ($siWiFiStatus) {
            Get-JcSdkSystemInsightWifiStatus -Filter @("system_id:eq:$($siWiFiStatus.systemId)") | Should -Not -BeNullOrEmpty
            Get-JcSdkSystemInsightWifiStatus -Filter @("system_id:eq:$($siWiFiStatus.systemId)", "security_type:eq:$($siWiFiStatus.securityType)") | Should -Not -BeNullOrEmpty
            # security_type accepts strings, fakeString is a fake value
            Get-JcSdkSystemInsightWifiStatus -Filter @("system_id:eq:$($siWiFiStatus.systemId)", "security_type:eq:fakeString") | Should -BeNullOrEmpty
        }
    }
}

