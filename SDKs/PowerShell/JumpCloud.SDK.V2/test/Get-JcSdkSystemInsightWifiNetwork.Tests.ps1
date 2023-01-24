BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkSystemInsightWifiNetwork.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Get-JcSdkSystemInsightWifiNetwork' -Tag:(""){
    It 'List' {
        { Get-JcSdkSystemInsightWifiNetwork } | Should -Not -Throw
    }

    It 'List Filter Tests' {
        $siWiFi = Get-JcSdkSystemInsightWifiNetwork | Get-Random -Count 1
        if ($siWiFi) {
            Get-JcSdkSystemInsightWifiNetwork -Filter @("system_id:eq:$($siWiFi.systemId)") | Should -Not -BeNullOrEmpty
            Get-JcSdkSystemInsightWifiNetwork -Filter @("system_id:eq:$($siWiFi.systemId)", "security_type:eq:$($siWiFi.securityType)") | Should -Not -BeNullOrEmpty
            # security_type accepts strings, fakeString is a fake value
            Get-JcSdkSystemInsightWifiNetwork -Filter @("system_id:eq:$($siWiFi.systemId)", "security_type:eq:fakeString") | Should -BeNullOrEmpty
        }
    }
}

