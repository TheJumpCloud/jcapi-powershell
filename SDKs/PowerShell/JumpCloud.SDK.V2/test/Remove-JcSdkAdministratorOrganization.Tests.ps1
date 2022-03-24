BeforeAll {
if(($null -eq $TestName) -or ($TestName -contains 'Remove-JcSdkAdministratorOrganization'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Remove-JcSdkAdministratorOrganization.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}


}
Describe 'Remove-JcSdkAdministratorOrganization' -Tag:("MTP") {
    It 'Delete' {
        { Remove-JcSdkAdministratorOrganization -AdministratorId:(($global:PesterTestProviderAdmin).Id) -Id:($env:JCOrgId) } | Should -Not -Throw
    }

   It 'DeleteViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}

