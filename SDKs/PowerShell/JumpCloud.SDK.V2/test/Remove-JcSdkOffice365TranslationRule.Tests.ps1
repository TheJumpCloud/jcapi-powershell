BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Remove-JcSdkOffice365TranslationRule.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Remove-JcSdkOffice365TranslationRule' -Tag:(""){
    It 'Delete' {
        { Remove-JcSdkOffice365TranslationRule -Id:($global:PesterTestOffice365TranslationRule.Id) -Office365Id:($global:PesterTestOffice365.Id) } | Should -Not -Throw
    }

    It 'DeleteViaIdentity' -skip {
        { Remove-JcSdkOffice365TranslationRule -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }
}

