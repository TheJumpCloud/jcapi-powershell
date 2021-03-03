$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkCustomEmailConfiguration.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-JcSdkCustomEmailConfiguration' {
    It 'Get' {
        Get-JcSdkCustomEmailConfiguration -CustomEmailType password_reset_confirmation | Should -Not -BeNullOrEmpty
        Get-JcSdkCustomEmailConfiguration -CustomEmailType password_expiration_warning| Should -Not -BeNullOrEmpty
        Get-JcSdkCustomEmailConfiguration -CustomEmailType lockout_notice_user | Should -Not -BeNullOrEmpty
        Get-JcSdkCustomEmailConfiguration -CustomEmailType password_expiration | Should -Not -BeNullOrEmpty
        Get-JcSdkCustomEmailConfiguration -CustomEmailType user_change_password | Should -Not -BeNullOrEmpty
    }

    It 'GetViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
