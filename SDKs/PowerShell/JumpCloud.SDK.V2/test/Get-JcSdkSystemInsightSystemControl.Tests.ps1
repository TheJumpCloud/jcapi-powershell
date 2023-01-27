BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkSystemInsightSystemControl.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Get-JcSdkSystemInsightSystemControl' -Tag:(""){
    It 'List' {
        { Get-JcSdkSystemInsightSystemControl } | Should -Not -Throw
    }

    It 'List Filter Tests' {
        $siSysCtl = Get-JcSdkSystemInsightSystemControl | Get-Random -Count 1
        if ($siSysCtl) {
            Get-JcSdkSystemInsightSystemControl -Filter @("system_id:eq:$($siSysCtl.systemId)") | Should -Not -BeNullOrEmpty
            Get-JcSdkSystemInsightSystemControl -Filter @("system_id:eq:$($siSysCtl.systemId)", "name:eq:$($siSysCtl.name)") | Should -Not -BeNullOrEmpty
            # name accepts strings, fakeString is a fake value
            Get-JcSdkSystemInsightSystemControl -Filter @("system_id:eq:$($siSysCtl.systemId)", "name:eq:fakeString") | Should -BeNullOrEmpty
        }
    }
}

