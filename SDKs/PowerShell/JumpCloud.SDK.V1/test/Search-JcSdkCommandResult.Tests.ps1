BeforeAll {
if(($null -eq $TestName) -or ($TestName -contains 'Search-JcSdkCommandResult'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Search-JcSdkCommandResult.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}


}
Describe 'Search-JcSdkCommandResult' -Tag:(""){
    It 'SearchExpanded' {
        { Search-JcSdkCommandResult -Filter @{'and' = @("workflowId:eq:$($global:PesterTestCommand.Id)") } } | Should -Not -Throw

    }

    It 'Search' {
        { Search-JcSdkCommandResult } | Should -Not -Throw
    }
}
