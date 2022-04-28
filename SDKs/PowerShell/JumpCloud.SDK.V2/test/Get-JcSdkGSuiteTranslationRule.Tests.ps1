BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkGSuiteTranslationRule.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Get-JcSdkGSuiteTranslationRule' -Tag:(""){
    It 'List' {
        { Get-JcSdkGSuiteTranslationRule -GsuiteId:($global:PesterTestGsuite.Id) } | Should -Not -Throw
    }

    It 'Get' {
        { Get-JcSdkGSuiteTranslationRule -GsuiteId:($global:PesterTestGsuite.Id) -Id:($global:PesterTestGSuiteTranslationRule.Id) } | Should -Not -Throw
    }

    It 'GetViaIdentity' -skip {
        { Get-JcSdkGSuiteTranslationRule -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }
}

