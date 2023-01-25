BeforeAll {
if(($null -eq $TestName) -or ($TestName -contains 'Get-JcSdkSystemInsightAzureInstanceMetadata'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkSystemInsightAzureInstanceMetadata.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}


}
Describe 'Get-JcSdkSystemInsightAzureInstanceMetadata' -Tag:(""){
    It 'List' -skip {
        { Get-JcSdkSystemInsightAzureInstanceMetadata } | Should -Not -Throw
    }

    It 'List Filter Tests' {
        $siAppShim = Get-JcSdkSystemInsightAzureInstanceMetadata | Get-Random -Count 1
        if ($siAppShim) {
            Get-JcSdkSystemInsightAzureInstanceMetadata -Filter @("system_id:eq:$($siAppShim.systemId)") | Should -Not -BeNullOrEmpty
        }
    }
}
