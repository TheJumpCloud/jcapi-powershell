if(($null -eq $TestName) -or ($TestName -contains 'Get-JcSdkWorkflowAccessRequest'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkWorkflowAccessRequest.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Get-JcSdkWorkflowAccessRequest' {
    It 'List' {
        { Get-JcSdkWorkflowAccessRequest } | Should -Not -Throw
    }

    It 'List should return actual access requests if they exist' {
        $accessRequests = Get-JcSdkWorkflowAccessRequest
        if ($null -eq $accessRequests){
            # can't create workflows without logging in as a user, skip test
            continue
        } else {
            $accessRequest = $accessRequests | Get-Random -Count 1
            $accessRequest | Should -Not -BeNullOrEmpty
            $accessRequest.Count | Should -Be 1
        }
    }
}
