BeforeAll {
if(($null -eq $TestName) -or ($TestName -contains 'Remove-JcSdkProviderAdministrator'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Remove-JcSdkProviderAdministrator.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}


}
Describe 'Remove-JcSdkProviderAdministrator' -Tag:("MTP") -Skip {
    It 'Delete' {
        { Remove-JcSdkProviderAdministrator -Id:(($global:PesterTestProviderAdmin).Id) -ProviderId $env:JCProviderId } | Should -Not -Throw
    }

    It 'DeleteViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}

