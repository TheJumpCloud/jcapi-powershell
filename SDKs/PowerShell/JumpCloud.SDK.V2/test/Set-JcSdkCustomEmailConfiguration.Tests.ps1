$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Set-JcSdkCustomEmailConfiguration.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Set-JcSdkCustomEmailConfiguration' {
    It 'SetExpanded' {
        { Set-JcSdkCustomEmailConfiguration -CustomEmailType password_reset_confirmation -Type password_reset_confirmation -subject "CUSTOMMODIFY" } | Should -Not -Throw
        { Set-JcSdkCustomEmailConfiguration -CustomEmailType password_expiration_warning -Type password_expiration_warning -subject "CUSTOMMODIFY" } | Should -Not -Throw
        { Set-JcSdkCustomEmailConfiguration -CustomEmailType lockout_notice_user -Type lockout_notice_user -subject "CUSTOMMODIFY" } | Should -Not -Throw
        { Set-JcSdkCustomEmailConfiguration -CustomEmailType password_expiration -Type password_expiration -subject "CUSTOMMODIFY" } | Should -Not -Throw
        { Set-JcSdkCustomEmailConfiguration -CustomEmailType user_change_password -Type user_change_password -subject "CUSTOMMODIFY" } | Should -Not -Throw
    }

    It 'Set' {
        $types = ('password_reset_confirmation', 'password_expiration_warning', 'lockout_notice_user', 'password_expiration', 'user_change_password')
        foreach ($type in $types) {
            $body = @{
                Subject = 'CustomModify'
                Header = 'CustomModify'
                Title = 'CustomModify'
                Button = 'CustomModify'
                NextStepContactInfo = 'pester_person@alderaan.org'
                Type                = $type
            }
            { Set-JcSdkCustomEmailConfiguration -CustomEmailType $type -BodyObject $body } | Should -Not -Throw
        }
    }

    It 'SetViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
