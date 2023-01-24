BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkSystemInsightSharedFolder.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Get-JcSdkSystemInsightSharedFolder' -Tag:(""){
    It 'List' {
        { Get-JcSdkSystemInsightSharedFolder } | Should -Not -Throw
    }

    It 'List Filter Tests' {
        $siSharedDir = Get-JcSdkSystemInsightSharedFolder | Get-Random -Count 1
        if ($siSharedDir) {
            Get-JcSdkSystemInsightSharedFolder -Filter @("system_id:eq:$($siSharedDir.systemId)") | Should -Not -BeNullOrEmpty
            Get-JcSdkSystemInsightSharedFolder -Filter @("system_id:eq:$($siSharedDir.systemId)", "name:eq:$($siSharedDir.name)") | Should -Not -BeNullOrEmpty
            # name accepts strings, fakeString is a fake value
            Get-JcSdkSystemInsightSharedFolder -Filter @("system_id:eq:$($siSharedDir.systemId)", "name:eq:fakeString") | Should -BeNullOrEmpty
        }
    }
}

