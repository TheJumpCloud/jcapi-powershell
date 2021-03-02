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
    BeforeAll{
        New-JcSdkCustomEmailConfiguration -type password_reset_confirmation -subject "CUSTOM"
        New-JcSdkCustomEmailConfiguration -type password_expiration_warning -subject "CUSTOM"
        New-JcSdkCustomEmailConfiguration -type lockout_notice_user -subject "CUSTOM"
        New-JcSdkCustomEmailConfiguration -type password_expiration -subject "CUSTOM"
        New-JcSdkCustomEmailConfiguration -type user_change_password -subject "CUSTOM"
    }
    AfterAll{
        Remove-JcSdkCustomEmailConfiguration -CustomEmailType password_reset_confirmation
        Remove-JcSdkCustomEmailConfiguration -CustomEmailType password_expiration_warning
        Remove-JcSdkCustomEmailConfiguration -CustomEmailType lockout_notice_user
        Remove-JcSdkCustomEmailConfiguration -CustomEmailType password_expiration
        Remove-JcSdkCustomEmailConfiguration -CustomEmailType user_change_password
    }
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
