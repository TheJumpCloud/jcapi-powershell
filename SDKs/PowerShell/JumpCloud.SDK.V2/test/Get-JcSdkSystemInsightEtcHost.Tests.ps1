BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkSystemInsightEtcHost.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Get-JcSdkSystemInsightEtcHost' -Tag:(""){
    It 'List' {
        { Get-JcSdkSystemInsightEtcHost } | Should -Not -Throw
    }

    It 'List Filter Tests' {
        $siETC = Get-JcSdkSystemInsightEtcHost | Get-Random -Count 1
        if ($siETC) {
            Get-JcSdkSystemInsightEtcHost -Filter @("system_id:eq:$($siETC.systemId)") | Should -Not -BeNullOrEmpty
            Get-JcSdkSystemInsightEtcHost -Filter @("system_id:eq:$($siETC.systemId)", "address:eq:$($siETC.address)") | Should -Not -BeNullOrEmpty
            # address accepts strings, fakeString is a fake value
            Get-JcSdkSystemInsightEtcHost -Filter @("system_id:eq:$($siETC.systemId)", "address:eq:fakeString") | Should -BeNullOrEmpty
        }
    }
}

