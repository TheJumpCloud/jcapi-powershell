BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkSystemInsightUserGroup.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Get-JcSdkSystemInsightUserGroup' -Tag:(""){
    It 'List' {
        { Get-JcSdkSystemInsightUserGroup } | Should -Not -Throw
    }

    It 'List Filter Tests' {
        $siUserGroup = Get-JcSdkSystemInsightUserGroup | Get-Random -Count 1
        if ($siUserGroup) {
            Get-JcSdkSystemInsightUserGroup -Filter @("system_id:eq:$($siUserGroup.systemId)") | Should -Not -BeNullOrEmpty
            Get-JcSdkSystemInsightUserGroup -Filter @("system_id:eq:$($siUserGroup.systemId)", "uid:eq:$($siUserGroup.uid)") | Should -Not -BeNullOrEmpty
            # uid accepts int, 9988 is a fake value
            Get-JcSdkSystemInsightUserGroup -Filter @("system_id:eq:$($siUserGroup.systemId)", "uid:eq:9988") | Should -BeNullOrEmpty
        }
    }
}

