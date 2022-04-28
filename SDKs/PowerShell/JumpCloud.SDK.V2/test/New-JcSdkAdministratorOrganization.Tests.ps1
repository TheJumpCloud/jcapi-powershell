BeforeAll {
if(($null -eq $TestName) -or ($TestName -contains 'New-JcSdkAdministratorOrganization'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'New-JcSdkAdministratorOrganization.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}


}
Describe 'New-JcSdkAdministratorOrganization' -Tag:("MTP") {
    It 'Create' {
        ## Admin variables:
        $name = "ProviderAdmin-$(-join ((65..90) + (97..122) | Get-Random -Count 5 | ForEach-Object { [char]$_ }))"
        $email = "$($name)@example$(-join ((65..90) + (97..122) | Get-Random -Count 5 | ForEach-Object { [char]$_ })).com";
        $Firstname = 'AdminFirst'
        $Lastname  = 'AdminLast'
        # Create new providerAdmin for test
        $testAdmin = New-JcsdkProviderAdministrator -Email:($email) -Firstname:($Firstname) -Lastname:($Lastname) -ProviderId:($env:JCProviderId) -BindNoOrgs
        { New-JcSdkAdministratorOrganization -Organization:($env:JCOrgId) -Id:(($testAdmin).Id) } | Should -Not -Throw
        # Remove providerAdmin to clean up
        Remove-JcSdkProviderAdministrator -Id:(($testAdmin).Id) -ProviderId:($env:JCProviderId)
    }

    It 'CreateViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CreateViaIdentityExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
