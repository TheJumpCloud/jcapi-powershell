$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'New-JcSdkCustomEmailConfiguration.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'New-JcSdkCustomEmailConfiguration' {
    It 'CreateExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Create' {
        { New-JcSdkCustomEmailConfiguration -type password_reset_confirmation -subject "CUSTOM" | Should -Not -BeNullOrEmpty } | Should -Not -Throw
        { New-JcSdkCustomEmailConfiguration -type password_expiration_warning -subject "CUSTOM" | Should -Not -BeNullOrEmpty } | Should -Not -Throw
        { New-JcSdkCustomEmailConfiguration -type lockout_notice_user -subject "CUSTOM" | Should -Not -BeNullOrEmpty } | Should -Not -Throw
        { New-JcSdkCustomEmailConfiguration -type password_expiration -subject "CUSTOM" | Should -Not -BeNullOrEmpty } | Should -Not -Throw
        { New-JcSdkCustomEmailConfiguration -type user_change_password -subject "CUSTOM" | Should -Not -BeNullOrEmpty } | Should -Not -Throw
    }
}
