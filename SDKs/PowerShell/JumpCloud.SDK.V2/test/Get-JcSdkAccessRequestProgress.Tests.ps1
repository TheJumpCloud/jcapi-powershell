if(($null -eq $TestName) -or ($TestName -contains 'Get-JcSdkAccessRequestProgress'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkAccessRequestProgress.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Get-JcSdkAccessRequestProgress' {
    It 'Get' {
        $workflows = Get-JcSdkApprovalFlow
        if ($null -eq $workflows){
            # can't create workflows without logging in as a user, skip test
            continue
        } else {
            $workflow = $workflows | Get-Random -Count 1
            $progress = Get-JcSdkAccessRequestProgress -Id $workflow.Id
            $progress | Should -Not -BeNullOrEmpty
            $progress.Count | Should -Be 1
        }
    }
}
