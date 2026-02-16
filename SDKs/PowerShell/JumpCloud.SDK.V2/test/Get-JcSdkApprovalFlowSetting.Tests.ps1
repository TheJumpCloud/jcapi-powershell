if(($null -eq $TestName) -or ($TestName -contains 'Get-JcSdkApprovalFlowSetting'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkApprovalFlowSetting.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Get-JcSdkApprovalFlowSetting' {
    It 'Get' {
        { Get-JcSdkApprovalFlowSetting } | Should -Not -Throw
    }
    It 'Get should return actual settings if they exist' {
        $settings = Get-JcSdkApprovalFlowSetting
        $settings | Should -Not -BeNullOrEmpty
        $settings.Count | Should -Be 1
    }
}
