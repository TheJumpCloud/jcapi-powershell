if(($null -eq $TestName) -or ($TestName -contains 'Get-JcSdkAccessRequest'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkAccessRequest.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Get-JcSdkAccessRequest' {
    It 'List' {
        { Get-JcSdkAccessRequest } | Should -Not -Throw
    }

    It 'List should return actual access requests if they exist' {
        $accessRequests = Get-JcSdkAccessRequest
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
