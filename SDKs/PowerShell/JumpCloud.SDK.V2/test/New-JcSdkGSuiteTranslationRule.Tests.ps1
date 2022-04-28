BeforeAll {
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


}
Describe 'New-JcSdkGSuiteTranslationRule' -Tag:(""){
    It 'CreateExpanded' {
        $global:PesterTestGSuiteTranslationRule = New-JcSdkGSuiteTranslationRule @global:PesterDefGSuiteTranslationRule
        $global:PesterTestGSuiteTranslationRule | Should -Not -BeNullOrEmpty
    }

    It 'Create' -skip {
        { New-JcSdkGSuiteTranslationRule -Body:($global:PesterTestGSuiteTranslationRule) -GsuiteId:($global:PesterTestGsuite.Id) } | Should -Not -Throw
    }

    It 'CreateViaIdentity' -skip {
        { New-JcSdkGSuiteTranslationRule -Body:($global:PesterTestGSuiteTranslationRule) -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'CreateViaIdentityExpanded' -skip {
        { New-JcSdkGSuiteTranslationRule -InputObject '<IJumpCloudApIsIdentity>' [-BuiltIn '<String>'] } | Should -Not -Throw
    }
}

