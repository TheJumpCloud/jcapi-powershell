BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'New-JcSdkOffice365TranslationRule.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'New-JcSdkOffice365TranslationRule' -Tag:(""){
    It 'CreateExpanded' {
        $global:PesterTestOffice365TranslationRule = New-JcSdkOffice365TranslationRule @global:PesterDefOffice365TranslationRule
        $global:PesterTestOffice365TranslationRule | Should -Not -BeNullOrEmpty
    }

    It 'Create' -skip {
        { New-JcSdkOffice365TranslationRule -Body:($global:PesterTestOffice365TranslationRule) -Office365Id:($global:PesterTestOffice365.Id) } | Should -Not -Throw
    }

    It 'CreateViaIdentity' -skip {
        { New-JcSdkOffice365TranslationRule -Body:($global:PesterTestOffice365TranslationRule) -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'CreateViaIdentityExpanded' -skip {
        { New-JcSdkOffice365TranslationRule -InputObject '<IJumpCloudApIsIdentity>' [-BuiltIn '<String>'] } | Should -Not -Throw
    }
}

