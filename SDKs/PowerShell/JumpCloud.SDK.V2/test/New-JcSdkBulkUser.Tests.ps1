BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'New-JcSdkBulkUser.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'New-JcSdkBulkUser' -Tag:(""){
    It 'Create' {
        $global:PesterTestBulkUserJobId =  New-JcSdkBulkUser -Body:($global:PesterDefBulkUser) -CreationSource:('jumpcloud:bulk')
        { $global:PesterTestBulkUserJobId } | Should -Not -BeNullOrEmpty
        $bulkUserCreate = Get-JcSdkUser -Filter "username:`$eq:$($global:PesterDefBulkUser.username)"
        $bulkUserCreate.AccountLocked | Should -Be $global:PesterDefBulkUser.AccountLocked
        $bulkUserCreate.Activated | Should -Be $global:PesterDefBulkUser.Activated
        $global:PesterDefBulkUser.Addresses | Get-Member -MemberType Property | ForEach-Object {
            if ($null -eq $($global:PesterDefBulkUser.Addresses.$($_.Name))){
                $global:bulkUserCreate.Addresses.$($_.Name) | Should -BeNullOrEmpty
            } else {
                $global:PesterDefBulkUser.Addresses.$($_.Name) | Should -be $bulkUserCreate.Addresses.$($_.Name)
            }
        }
        $bulkUserCreate.AllowPublicKey | Should -Be $global:PesterDefBulkUser.AllowPublicKey
        #$bulkUserCreate.AlternateEmail | Should -Be $global:PesterDefBulkUser.AlternateEmail
        $bulkUserCreate.Company | Should -Be $global:PesterDefBulkUser.Company
        $bulkUserCreate.CostCenter | Should -Be $global:PesterDefBulkUser.CostCenter
        $bulkUserCreate.Department | Should -Be $global:PesterDefBulkUser.Department
        $bulkUserCreate.Description | Should -Be $global:PesterDefBulkUser.Description
        $bulkUserCreate.DisableDeviceMaxLoginAttempts | Should -Be $global:PesterDefBulkUser.DisableDeviceMaxLoginAttempts
        $bulkUserCreate.Displayname | Should -Be $global:PesterDefBulkUser.DisplayName
        $bulkUserCreate.Email | Should -Be $global:PesterDefBulkUser.Email
        $bulkUserCreate.EmployeeIdentifier | Should -Be $global:PesterDefBulkUser.EmployeeIdentifier
        $bulkUserCreate.EmployeeType | Should -Be $global:PesterDefBulkUser.EmployeeType
        $bulkUserCreate.EnableManagedUid | Should -Be $global:PesterDefBulkUser.EnableManagedUid
        $bulkUserCreate.EnableUserPortalMultifactor | Should -Be $global:PesterDefBulkUser.EnableUserPortalMultifactor
        $bulkUserCreate.ExternallyManaged | Should -Be $global:PesterDefBulkUser.ExternallyManaged
        $bulkUserCreate.Firstname | Should -Be $global:PesterDefBulkUser.FirstName
        $bulkUserCreate.JobTitle | Should -Be $global:PesterDefBulkUser.JobTitle
        $bulkUserCreate.Lastname | Should -Be $global:PesterDefBulkUser.LastName
        $bulkUserCreate.LdapBindingUser | Should -Be $global:PesterDefBulkUser.LdapBindingUser
        $bulkUserCreate.Location | Should -Be $global:PesterDefBulkUser.Location
        $bulkUserCreate.ManagedAppleId | Should -Be $global:PesterDefBulkUser.ManagedAppleId
        $bulkUserCreate.Manager | Should -Be $global:PesterDefBulkUser.Manager
        $bulkUserCreate.MfaConfigured | Should -Be $global:PesterDefBulkUser.MfaConfigured
        $bulkUserCreate.PasswordNeverExpires | Should -Be $global:PesterDefBulkUser.PasswordNeverExpires
        $bulkUserCreate.PasswordlessSudo | Should -Be $global:PesterDefBulkUser.PasswordlessSudo
        $global:PesterDefBulkUser.PhoneNumbers | Get-Member -MemberType Property | ForEach-Object {
            if ($null -eq $($global:PesterDefBulkUser.PhoneNumbers.$($_.Number))){
                $global:bulkUserCreate.PhoneNumbers.$($_.Number) | Should -BeNullOrEmpty
            } else {
                $global:PesterDefBulkUser.PhoneNumbers.$($_.Numbers) | Should -be $bulkUserCreate.PhoneNumbers.$($_.Numbers)
            }
        }
        $bulkUserCreate.Username | Should -Be $global:PesterDefBulkUser.Username
    }
}

