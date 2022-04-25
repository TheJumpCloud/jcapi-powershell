BeforeAll {
    $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
    if (-Not (Test-Path -Path $loadEnvPath)) {
        $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
    }
    . ($loadEnvPath)
    $TestRecordingFile = Join-Path $PSScriptRoot 'Set-JcSdkUser.Recording.json'
    $currentPath = $PSScriptRoot
    while(-not $mockingPath) {
        $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
        $currentPath = Split-Path -Path $currentPath -Parent
    }
    . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Set-JcSdkUser' -Tag:(""){
    It 'SetExpanded' -skip {
        { Set-JcSdkUser -Id:($global:PesterTestUser.Id) } | Should -Not -Throw
    }

    It 'Set' {
        { Set-JcSdkUser -Body:($global:PesterTestUser) -Id:($global:PesterTestUser.Id) } | Should -Not -Throw
    }

    It 'SetViaIdentity' -skip {
        { Set-JcSdkUser -Body:($global:PesterTestUser) -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { Set-JcSdkUser -InputObject '<IJumpCloudApIsIdentity>' [-AccountLocked] [-Addresses '<ISystemuserputAddressesItem[]>'] [-AllowPublicKey] [-Attributes '<ISystemuserputAttributesItem[]>'] [-Company '<String>'] [-CostCenter '<String>'] [-Department '<String>'] [-Description '<String>'] [-DisableDeviceMaxLoginAttempts] [-Displayname '<String>'] [-Email '<String>'] [-EmployeeIdentifier '<String>'] [-EmployeeType '<String>'] [-EnableManagedUid] [-EnableUserPortalMultifactor] [-ExternalDn '<String>'] [-ExternallyManaged] [-ExternalPasswordExpirationDate '<String>'] [-ExternalSourceType '<String>'] [-Firstname '<String>'] [-JobTitle '<String>'] [-Lastname '<String>'] [-LdapBindingUser] [-Location '<String>'] [-MfaConfigured] [-MfaExclusion] [-MfaExclusionUntil '<DateTime>'] [-Middlename '<String>'] [-Password '<String>'] [-PasswordNeverExpires] [-PhoneNumbers '<ISystemuserputPhoneNumbersItem[]>'] [-PublicKey '<String>'] [-Relationships '<ISystemuserputRelationshipsItem[]>'] [-SambaServiceUser] [-SshKeys '<ISshkeypost[]>'] [-Sudo] [-Suspended] [-UnixGuid '<Int32>'] [-UnixUid '<Int32>'] [-Username '<String>'] } | Should -Not -Throw
    }
}
