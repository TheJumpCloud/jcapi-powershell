BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkSystemInsightBrowserPlugin.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Get-JcSdkSystemInsightBrowserPlugin' -Tag:(""){
    It 'List' {
        { Get-JcSdkSystemInsightBrowserPlugin } | Should -Not -Throw
    }
    It 'List Filter Tests' {
        $siBrowserPlugin = Get-JcSdkSystemInsightBrowserPlugin | Get-Random -Count 1
        if ($siBrowserPlugin) {
            Get-JcSdkSystemInsightBrowserPlugin -Filter @("system_id:eq:$($siBrowserPlugin.systemId)") | Should -Not -BeNullOrEmpty
            Get-JcSdkSystemInsightBrowserPlugin -Filter @("system_id:eq:$($siBrowserPlugin.systemId)", "name:eq:$($siBrowserPlugin.name)") | Should -Not -BeNullOrEmpty
            # name accepts strings, fakeString is a fake value
            Get-JcSdkSystemInsightBrowserPlugin -Filter @("system_id:eq:$($siBrowserPlugin.systemId)", "name:eq:fakeString") | Should -BeNullOrEmpty
        }
    }
}

