BeforeAll {
if(($null -eq $TestName) -or ($TestName -contains 'Get-JcSdkAdministratorOrganizationLink'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkAdministratorOrganizationLink.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}


}
Describe 'Get-JcSdkAdministratorOrganizationLink' -Tag:("MTP") {
    It 'List' {
        { Get-JcSdkAdministratorOrganizationLink -Id:((Get-JcSdkOrganization | Select-Object -First 1).Id) } | Should -Not -Throw
    }
}

