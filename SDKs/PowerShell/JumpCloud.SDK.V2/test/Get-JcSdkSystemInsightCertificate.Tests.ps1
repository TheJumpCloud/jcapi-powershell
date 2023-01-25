BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkSystemInsightCertificate.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Get-JcSdkSystemInsightCertificate' -Tag:(""){
    It 'List' {
        { Get-JcSdkSystemInsightCertificate } | Should -Not -Throw
    }

    It 'List Filter Tests' {
        $siAppShim = Get-JcSdkSystemInsightCertificate | Get-Random -Count 1
        if ($siAppShim) {
            Get-JcSdkSystemInsightCertificate -Filter @("system_id:eq:$($siAppShim.systemId)") | Should -Not -BeNullOrEmpty
            Get-JcSdkSystemInsightCertificate -Filter @("system_id:eq:$($siAppShim.systemId)", "common_name:eq:$($siAppShim.commonName)") | Should -Not -BeNullOrEmpty
            # common_name accepts strings, fakeString is a fake value
            Get-JcSdkSystemInsightCertificate -Filter @("system_id:eq:$($siAppShim.systemId)", "common_name:eq:fakeString") | Should -BeNullOrEmpty
        }
    }
}

