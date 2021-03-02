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

Describe 'Get-JcSdkGSuiteTranslationRule' {
    BeforeAll {
        New-JcSdkGSuiteTranslationRule -GsuiteId $($global:PesterTestGSuite.Id) -BuiltIn user_work_addresses
    }
    AfterAll {
        $rule = Get-JcSdkGSuiteTranslationRule -GsuiteId $($global:PesterTestGSuite.Id) | Select-Object -First 1
        Remove-JcSdkGSuiteTranslationRule -GsuiteId $($global:PesterTestGSuite.Id) -Id $rule.id
    }
    It 'List' {
        Get-JcSdkGSuiteTranslationRule -GsuiteId $($global:PesterTestGSuite.Id)
    }

    It 'Get' {
        $rule = Get-JcSdkGSuiteTranslationRule -GsuiteId $($global:PesterTestGSuite.Id) | Select-Object -First 1
        Get-JcSdkGSuiteTranslationRule -GsuiteId $($global:PesterTestGSuite.Id) -id $rule.id
    }

    It 'GetViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
