BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkSystemInsightApp.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Get-JcSdkSystemInsightApp' -Tag:(""){
    It 'List' {
        { Get-JcSdkSystemInsightApp } | Should -Not -Throw
    }

    It 'List Filter Tests' {
        $app = Get-JcSdkSystemInsightApp | Get-Random -Count 1
        if ($app){
            Get-JcSdkSystemInsightApp -Filter @("system_id:eq:$($app.systemId)") | Should -Not -BeNullOrEmpty
            Get-JcSdkSystemInsightApp -Filter @("system_id:eq:$($app.systemId)", "bundle_name:eq:$($app.bundlename)") | Should -Not -BeNullOrEmpty
            # bundle_name accepts strings, fakeString is a fake value
            Get-JcSdkSystemInsightApp -Filter @("system_id:eq:$($app.systemId)", "bundle_name:eq:fakeString") | Should -BeNullOrEmpty
        }
    }
}

