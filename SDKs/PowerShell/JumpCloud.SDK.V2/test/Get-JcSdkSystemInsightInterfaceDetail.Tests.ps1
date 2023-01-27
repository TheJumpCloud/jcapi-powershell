BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkSystemInsightInterfaceDetail.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Get-JcSdkSystemInsightInterfaceDetail' -Tag:(""){
    It 'List' {
        { Get-JcSdkSystemInsightInterfaceDetail } | Should -Not -Throw
    }

    It 'List Filter Tests' {
        $siIDetail = Get-JcSdkSystemInsightInterfaceDetail | Get-Random -Count 1
        if ($siIDetail) {
            Get-JcSdkSystemInsightInterfaceDetail -Filter @("system_id:eq:$($siIDetail.systemId)") | Should -Not -BeNullOrEmpty
            Get-JcSdkSystemInsightInterfaceDetail -Filter @("system_id:eq:$($siIDetail.systemId)", "interface:eq:$($siIDetail.interface)") | Should -Not -BeNullOrEmpty
            # interface accepts strings, fakeString is a fake value
            Get-JcSdkSystemInsightInterfaceDetail -Filter @("system_id:eq:$($siIDetail.systemId)", "interface:eq:fakeString") | Should -BeNullOrEmpty
        }
    }
}

