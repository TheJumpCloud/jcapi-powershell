BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkSystemInsightInterfaceAddress.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Get-JcSdkSystemInsightInterfaceAddress' -Tag:(""){
    It 'List' {
        { Get-JcSdkSystemInsightInterfaceAddress } | Should -Not -Throw
    }

    It 'List Filter Tests' {
        $siIAddress = Get-JcSdkSystemInsightInterfaceAddress | Get-Random -Count 1
        if ($siIAddress) {
            Get-JcSdkSystemInsightInterfaceAddress -Filter @("system_id:eq:$($siIAddress.systemId)") | Should -Not -BeNullOrEmpty
            Get-JcSdkSystemInsightInterfaceAddress -Filter @("system_id:eq:$($siIAddress.systemId)", "address:eq:$($siIAddress.address)") | Should -Not -BeNullOrEmpty
            # address accepts strings, fakeString is a fake value
            Get-JcSdkSystemInsightInterfaceAddress -Filter @("system_id:eq:$($siIAddress.systemId)", "address:eq:fakeString") | Should -BeNullOrEmpty
        }
    }
}

