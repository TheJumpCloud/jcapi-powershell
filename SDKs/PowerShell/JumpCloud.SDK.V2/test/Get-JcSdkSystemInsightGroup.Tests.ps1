BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkSystemInsightGroup.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Get-JcSdkSystemInsightGroup' -Tag:(""){
    It 'List' {
        { Get-JcSdkSystemInsightGroup } | Should -Not -Throw
    }

    It 'List Filter Tests' {
        $siGroup = Get-JcSdkSystemInsightGroup | Get-Random -Count 1
        if ($siGroup) {
            Get-JcSdkSystemInsightGroup -Filter @("system_id:eq:$($siGroup.systemId)") | Should -Not -BeNullOrEmpty
            Get-JcSdkSystemInsightGroup -Filter @("system_id:eq:$($siGroup.systemId)", "groupname:eq:$($siGroup.groupname)") | Should -Not -BeNullOrEmpty
            # groupname accepts strings, fakeString is a fake value
            Get-JcSdkSystemInsightGroup -Filter @("system_id:eq:$($siGroup.systemId)", "groupname:eq:fakeString") | Should -BeNullOrEmpty
        }
    }
}

