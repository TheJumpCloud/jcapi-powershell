BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkSystemInsightSipConfig.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Get-JcSdkSystemInsightSipConfig' -Tag:(""){
    It 'List' {
        { Get-JcSdkSystemInsightSipConfig } | Should -Not -Throw
    }

    It 'List Filter Tests' {
        $siSIP = Get-JcSdkSystemInsightSipConfig | Get-Random -Count 1
        if ($siSIP) {
            Get-JcSdkSystemInsightSipConfig -Filter @("system_id:eq:$($siSIP.systemId)") | Should -Not -BeNullOrEmpty
            Get-JcSdkSystemInsightSipConfig -Filter @("system_id:eq:$($siSIP.systemId)", "enabled:eq:$($siSIP.enabled)") | Should -Not -BeNullOrEmpty
            # enabled accepts int, 9988 is a fake value
            Get-JcSdkSystemInsightSipConfig -Filter @("system_id:eq:$($siSIP.systemId)", "enabled:eq:9988") | Should -BeNullOrEmpty
        }
    }
}

