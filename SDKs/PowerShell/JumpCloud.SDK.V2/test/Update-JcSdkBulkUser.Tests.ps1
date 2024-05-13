BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Update-JcSdkBulkUser.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Update-JcSdkBulkUser' -Tag:(""){
    It 'Update' {
        $updateBulkUserJobID = Update-JcSdkBulkUser -Body:($global:PesterDefUpdateBulkUser)
        $updateBulkUserJobID | Should -Not -BeNullOrEmpty
        $bulkUserUpdate = Get-JcSdkUser -Filter "username:`$eq:$($global:PesterDefUpdateBulkUser.username)"
        $bulkUserUpdate.AccountLocked | Should -Be $global:PesterDefUpdateBulkUser.AccountLocked
        $bulkUserUpdate.Activated | Should -Be $global:PesterDefUpdateBulkUser.Activated
        $global:PesterDefUpdateBulkUser.Addresses | Get-Member -MemberType Property | ForEach-Object {
            if ($null -eq $($global:PesterDefUpdateBulkUser.Addresses.$($_.Name))){
                $global:bulkUserUpdate.Addresses.$($_.Name) | Should -BeNullOrEmpty
            } else {
                $global:PesterDefUpdateBulkUser.Addresses.$($_.Name) | Should -be $bulkUserUpdate.Addresses.$($_.Name)
            }
        }
        $bulkUserUpdate.AllowPublicKey | Should -Be $global:PesterDefUpdateBulkUser.AllowPublicKey
        #$bulkUserUpdate.AlternateEmail | Should -Be $global:PesterDefUpdateBulkUser.AlternateEmail
        $bulkUserUpdate.Company | Should -Be $global:PesterDefUpdateBulkUser.Company
        $bulkUserUpdate.CostCenter | Should -Be $global:PesterDefUpdateBulkUser.CostCenter
        $bulkUserUpdate.Department | Should -Be $global:PesterDefUpdateBulkUser.Department
        $bulkUserUpdate.Description | Should -Be $global:PesterDefUpdateBulkUser.Description
        $bulkUserUpdate.DisableDeviceMaxLoginAttempts | Should -Be $global:PesterDefUpdateBulkUser.DisableDeviceMaxLoginAttempts
        $bulkUserUpdate.Displayname | Should -Be $global:PesterDefUpdateBulkUser.DisplayName
        $bulkUserUpdate.Email | Should -Be $global:PesterDefUpdateBulkUser.Email
        $bulkUserUpdate.EmployeeIdentifier | Should -Be $global:PesterDefUpdateBulkUser.EmployeeIdentifier
        $bulkUserUpdate.EmployeeType | Should -Be $global:PesterDefUpdateBulkUser.EmployeeType
        $bulkUserUpdate.EnableManagedUid | Should -Be $global:PesterDefUpdateBulkUser.EnableManagedUid
        $bulkUserUpdate.EnableUserPortalMultifactor | Should -Be $global:PesterDefUpdateBulkUser.EnableUserPortalMultifactor
        $bulkUserUpdate.ExternallyManaged | Should -Be $global:PesterDefUpdateBulkUser.ExternallyManaged
        $bulkUserUpdate.Firstname | Should -Be $global:PesterDefUpdateBulkUser.FirstName
        $bulkUserUpdate.JobTitle | Should -Be $global:PesterDefUpdateBulkUser.JobTitle
        $bulkUserUpdate.Lastname | Should -Be $global:PesterDefUpdateBulkUser.LastName
        $bulkUserUpdate.LdapBindingUser | Should -Be $global:PesterDefUpdateBulkUser.LdapBindingUser
        $bulkUserUpdate.Location | Should -Be $global:PesterDefUpdateBulkUser.Location
        $bulkUserUpdate.ManagedAppleId | Should -Be $global:PesterDefUpdateBulkUser.ManagedAppleId
        $bulkUserUpdate.Manager | Should -Be $global:PesterDefUpdateBulkUser.Manager
        $bulkUserUpdate.MfaConfigured | Should -Be $global:PesterDefUpdateBulkUser.MfaConfigured
        $bulkUserUpdate.PasswordNeverExpires | Should -Be $global:PesterDefUpdateBulkUser.PasswordNeverExpires
        $bulkUserUpdate.PasswordlessSudo | Should -Be $global:PesterDefUpdateBulkUser.PasswordlessSudo
        $global:PesterDefUpdateBulkUser.PhoneNumbers | Get-Member -MemberType Property | ForEach-Object {
            if ($null -eq $($global:PesterDefUpdateBulkUser.PhoneNumbers.$($_.Number))){
                $bulkUserUpdate.PhoneNumbers.$($_.Number) | Should -BeNullOrEmpty
            } else {
                $bulkUserUpdate.PhoneNumbers.$($_.Numbers) | Should -be $global:PesterDefUpdateBulkUser.PhoneNumbers.$($_.Numbers)
            }
        }
        $bulkUserUpdate.Username | Should -Be $global:PesterDefUpdateBulkUser.Username
    }
}
