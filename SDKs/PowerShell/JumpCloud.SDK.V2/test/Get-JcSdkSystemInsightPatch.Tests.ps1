BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkSystemInsightPatch.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Get-JcSdkSystemInsightPatch' -Tag:(""){
    It 'List' {
        { Get-JcSdkSystemInsightPatch } | Should -Not -Throw
    }

    It 'List Filter Tests' {
        $siHotfix = Get-JcSdkSystemInsightPatch | Get-Random -Count 1
        if ($siHotfix) {
            Get-JcSdkSystemInsightPatch -Filter @("system_id:eq:$($siHotfix.systemId)") | Should -Not -BeNullOrEmpty
            Get-JcSdkSystemInsightPatch -Filter @("system_id:eq:$($siHotfix.systemId)", "hotfix_id:eq:$($siHotfix.hotfixid)") | Should -Not -BeNullOrEmpty
            # hotfix_id accepts strings, fakeString is a fake value
            Get-JcSdkSystemInsightPatch -Filter @("system_id:eq:$($siHotfix.systemId)", "hotfix_id:eq:fakeString") | Should -BeNullOrEmpty
        }
    }
}

