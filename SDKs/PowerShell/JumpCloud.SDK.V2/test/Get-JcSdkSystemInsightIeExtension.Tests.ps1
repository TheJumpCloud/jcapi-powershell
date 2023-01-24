BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkSystemInsightIeExtension.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Get-JcSdkSystemInsightIeExtension' -Tag:(""){
    It 'List' {
        { Get-JcSdkSystemInsightIeExtension } | Should -Not -Throw
    }

    It 'List Filter Tests' {
        $siIeExt = Get-JcSdkSystemInsightIeExtension | Get-Random -Count 1
        if ($siIeExt) {
            Get-JcSdkSystemInsightIeExtension -Filter @("system_id:eq:$($siIeExt.systemId)") | Should -Not -BeNullOrEmpty
            Get-JcSdkSystemInsightIeExtension -Filter @("system_id:eq:$($siIeExt.systemId)", "name:eq:$($siIeExt.name)") | Should -Not -BeNullOrEmpty
            # name accepts strings, fakeString is a fake value
            Get-JcSdkSystemInsightIeExtension -Filter @("system_id:eq:$($siIeExt.systemId)", "name:eq:fakeString") | Should -BeNullOrEmpty
        }
    }
}

