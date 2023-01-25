BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkSystemInsightDnsResolver.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Get-JcSdkSystemInsightDnsResolver' -Tag:(""){
    It 'List' {
        { Get-JcSdkSystemInsightDnsResolver } | Should -Not -Throw
    }
    It 'List Filter Tests' {
        $siDNS = Get-JcSdkSystemInsightDnsResolver | Get-Random -Count 1
        if ($siDNS) {
            Get-JcSdkSystemInsightDnsResolver -Filter @("system_id:eq:$($siDNS.systemId)") | Should -Not -BeNullOrEmpty
            Get-JcSdkSystemInsightDnsResolver -Filter @("system_id:eq:$($siDNS.systemId)", "type:eq:$($siDNS.type)") | Should -Not -BeNullOrEmpty
            # type accepts strings, fakeString is a fake value
            Get-JcSdkSystemInsightDnsResolver -Filter @("system_id:eq:$($siDNS.systemId)", "type:eq:fakeString") | Should -BeNullOrEmpty
        }
    }
}

