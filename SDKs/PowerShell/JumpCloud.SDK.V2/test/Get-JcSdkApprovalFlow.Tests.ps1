if(($null -eq $TestName) -or ($TestName -contains 'Get-JcSdkApprovalFlow'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkApprovalFlow.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Get-JcSdkApprovalFlow' {
    It 'List' {
        { Get-JcSdkApprovalFlow } | Should -Not -Throw
    }

    It 'List should return actual workflows if they exist' {
        $workflows = Get-JcSdkApprovalFlow
        if ($null -eq $workflows){
            # create a workflow with new-jcsdkworkflow
            $userGroups = Get-JcSdkUserGroup
            $userGroup = $userGroups | Get-Random -Count 1
            $targetGroup = Get-JcSdkUserGroup | Get-Random -Count 1
            while ($targetGroup.Id -eq $userGroup.Id) {
                $targetGroup = Get-JcSdkUserGroup | Get-Random -Count 1
            }
            $workflow = New-JcSdkWorkflow -ApprovalType 'manual' -Category "Application" -Description "A new workflow" -MultiSelectDuration @("P5D") -Name "New Workflow" -NonAdminApproval $false -ResourceId $userGroup.Id -ResourceType "user_group" -SlackEnabled $false -Status "active" -TimeBasedAccess $true -TtlConfig "TTL_CONFIG_MULTI_SELECT_DURATIONS" -VisibleTo @($targetGroup.Id)
        } else {
            $workflow = $workflows | Get-Random -Count 1
        }
        $workflow | Should -Not -BeNullOrEmpty
        $workflow.Count | Should -Be 1
    }

    It 'Get' {
        $workflows = Get-JcSdkApprovalFlow
        if ($null -eq $workflows){
            $workflow = New-JcSdkWorkflow -ApprovalType 'manual' -Category "Application" -Description "A new workflow" -MultiSelectDuration @("P5D") -Name "New Workflow" -NonAdminApproval $false -ResourceId $userGroup.Id -ResourceType "user_group" -SlackEnabled $false -Status "active" -TimeBasedAccess $true -TtlConfig "TTL_CONFIG_MULTI_SELECT_DURATIONS" -VisibleTo @($targetGroup.Id)
        } else {
            $workflow = $workflows | Get-Random -Count 1
        }
        Get-JcSdkApprovalFlow -ApprovalFlowId $workflow.Id | Should -Not -BeNullOrEmpty
        $workflow.Id | Should -Be $workflow.Id
    }
}
