BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkSystemInsightFirefoxAddon.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Get-JcSdkSystemInsightFirefoxAddon' -Tag:(""){
    It 'List' {
        { Get-JcSdkSystemInsightFirefoxAddon } | Should -Not -Throw
    }

    It 'List Filter Tests' {
        $siFirefox = Get-JcSdkSystemInsightFirefoxAddon | Get-Random -Count 1
        if ($siFirefox) {
            Get-JcSdkSystemInsightFirefoxAddon -Filter @("system_id:eq:$($siFirefox.systemId)") | Should -Not -BeNullOrEmpty
            Get-JcSdkSystemInsightFirefoxAddon -Filter @("system_id:eq:$($siFirefox.systemId)", "name:eq:$($siFirefox.name)") | Should -Not -BeNullOrEmpty
            # name accepts strings, fakeString is a fake value
            Get-JcSdkSystemInsightFirefoxAddon -Filter @("system_id:eq:$($siFirefox.systemId)", "name:eq:fakeString") | Should -BeNullOrEmpty
        }
    }
}

