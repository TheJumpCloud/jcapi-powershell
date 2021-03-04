$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkUserTraverseLdapServer.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-JcSdkUserTraverseLdapServer' {
   BeforeAll{
        # Associate User > LDAP
        Set-JCSdkUserAssociation -UserId:($global:PesterTestUser.Id) -Id:($global:PesterTestLdap.Id) -Op:('add') -Type:("ldap_server")
    }

    AfterAll{
        # Remove Associations
        Set-JCSdkUserAssociation -UserId:($global:PesterTestUser.Id) -Id:($global:PesterTestLdap.Id) -Op:('remove') -Type:("ldap_server")
   }

    It 'Get' {
        $AssociationTest = JumpCloud.SDK.V2\Get-JcSdkUserTraverseLdapServer -UserId:($global:PesterTestUser.Id)
        If ([System.String]::IsNullOrEmpty($AssociationTest))
        {
            $AssociationTest | Should -Not -BeNullOrEmpty
        }
        else
        {
            # Test that an association exists
            $AssociationTest.Count | Should -BeGreaterOrEqual 1
        }
    }
    It 'GetViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
