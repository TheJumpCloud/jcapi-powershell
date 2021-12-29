$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkProviderAdministrator.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

BeforeAll {
    # Set Environment Variables
    # These tests must be run with an APIKEY and null ORGID
    $ENV:JCApiKeyBackup = $ENV:JCApiKey
    $ENV:JCApiKey = $ENV:JCApiKeyMTP
    $ENV:JcOrgIdBackup = $ENV:JcOrgId
    $ENV:JcOrgId = ''
}
Describe 'Get-JcSdkProviderAdministrator' {
    It 'List' {
        { Get-JcSdkProviderAdministrator -ProviderId $Env:JCProviderId } | Should -Not -Throw
    }
}
AfterAll {
    # Set Environment Variables
    # Switch env vairables back to regular pester org
    # $ENV:JCApiKeyBackup = ''
    $ENV:JCApiKey = $ENV:JCApiKeyBackup
    # $ENV:JcOrgIdBackup = ''
    $ENV:JcOrgId = $ENV:JcOrgIdBackup
}