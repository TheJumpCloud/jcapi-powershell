BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkSystemInsightConnectivity.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Get-JcSdkSystemInsightConnectivity' -Tag:(""){
    It 'List' {
        { Get-JcSdkSystemInsightConnectivity } | Should -Not -Throw
    }
    It 'List Filter Tests' {
        $siConnect = Get-JcSdkSystemInsightConnectivity | Get-Random -Count 1
        if ($siConnect) {
            Get-JcSdkSystemInsightConnectivity -Filter @("system_id:eq:$($siConnect.systemId)") | Should -Not -BeNullOrEmpty
        }
    }
}

