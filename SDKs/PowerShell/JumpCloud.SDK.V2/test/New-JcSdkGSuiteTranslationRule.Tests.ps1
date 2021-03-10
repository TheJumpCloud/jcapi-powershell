$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'New-JcSdkGSuiteTranslationRule.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'New-JcSdkGSuiteTranslationRule' {
    It 'CreateExpanded' {
        $global:PesterTestGSuiteTranslationRule = New-JcSdkGSuiteTranslationRule @global:PesterDefGSuiteTranslationRule
        $global:PesterTestGSuiteTranslationRule | Should -Not -BeNullOrEmpty
    }

    It 'Create' -skip {
        New-JcSdkGSuiteTranslationRule -Body '<IGSuiteTranslationRuleRequest>' -GsuiteId:($global:PesterTestGsuite.Id) | Should -Not -BeNullOrEmpty
    }

    It 'CreateViaIdentityExpanded' -skip {
        New-JcSdkGSuiteTranslationRule -InputObject '<IJumpCloudApIsIdentity>' | Should -Not -BeNullOrEmpty
    }

    It 'CreateViaIdentity' -skip {
        New-JcSdkGSuiteTranslationRule -Body '<IGSuiteTranslationRuleRequest>' -InputObject '<IJumpCloudApIsIdentity>' | Should -Not -BeNullOrEmpty
    }
}
