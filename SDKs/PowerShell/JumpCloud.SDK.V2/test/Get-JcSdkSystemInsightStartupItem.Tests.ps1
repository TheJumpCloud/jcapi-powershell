BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkSystemInsightStartupItem.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Get-JcSdkSystemInsightStartupItem' -Tag:(""){
    It 'List' {
        { Get-JcSdkSystemInsightStartupItem } | Should -Not -Throw
    }

    It 'List Filter Tests' {
        $siStartItem = Get-JcSdkSystemInsightStartupItem | Get-Random -Count 1
        if ($siStartItem) {
            Get-JcSdkSystemInsightStartupItem -Filter @("system_id:eq:$($siStartItem.systemId)") | Should -Not -BeNullOrEmpty
            Get-JcSdkSystemInsightStartupItem -Filter @("system_id:eq:$($siStartItem.systemId)", "name:eq:$($siStartItem.name)") | Should -Not -BeNullOrEmpty
            # name accepts strings, fakeString is a fake value
            Get-JcSdkSystemInsightStartupItem -Filter @("system_id:eq:$($siStartItem.systemId)", "name:eq:fakeString") | Should -BeNullOrEmpty
        }
    }
}

