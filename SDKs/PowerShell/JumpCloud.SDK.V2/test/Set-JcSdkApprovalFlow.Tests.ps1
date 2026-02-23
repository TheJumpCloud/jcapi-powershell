if(($null -eq $TestName) -or ($TestName -contains 'Set-JcSdkApprovalFlow'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Set-JcSdkApprovalFlow.Recording.json'
  $currentPath = $PSScriptRoot
  $mockingPath = $null
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}


Describe 'Set-JcSdkApprovalFlow' -Tag:(""){
    It 'Set' {
        $workflows = Get-JcSdkApprovalFlow
        if (-not $workflows) {
            $userGroups = Get-JcSdkUserGroup
            $resourceGroup = $null
            $visibleGroup = $null
            if (-not $userGroups) {
                $createdGroups = @()
                1..2 | ForEach-Object {
                    $groupName = "PesterFlowGroup$_-$([guid]::NewGuid().ToString('N').Substring(0,8))"
                    $createdGroups += New-JcSdkUserGroup -Name $groupName
                }

                $userGroups = $createdGroups
                $resourceGroup = $createdGroups[0]
                $visibleGroup = $createdGroups[1]
            }

            $workflowNameSuffix = [guid]::NewGuid().ToString('N').Substring(0,8)
            $workflows = @(
                New-JcSdkApprovalFlow -ApprovalType 'manual' -Category 'Application' -Description 'A new workflow2' -MultiSelectDuration @('P5D') -Name "New Workflow-$workflowNameSuffix" -ResourceId $resourceGroup.Id -ResourceType 'user_group' -Status 'active' -TimeBasedAccess -TtlConfig 'TTL_CONFIG_MULTI_SELECT_DURATIONS' -VisibleTo @($visibleGroup.Id)
            )
        }

        $workflow = $workflows | Get-Random
        $newName = "{0}-Updated" -f $workflow.Name
        $newDescription = "Updated via Pester on $(Get-Date -Format 'u')"

        $body = @{
            ApprovalType        = $workflow.ApprovalType
            ApproverRequirement = $workflow.ApproverRequirement
            ApproverResources   = $workflow.ApproverResources
            Description         = $newDescription
            FixedDuration       = $workflow.FixedDuration
            IconColor           = $workflow.IconColor
            IconUrl             = $workflow.IconUrl
            MultiSelectDuration = $workflow.MultiSelectDuration
            Name                = $newName
            NonAdminApproval    = $workflow.NonAdminApproval
            ResourceId          = $workflow.ResourceId
            SlackConfig         = $workflow.SlackConfig
            SlackEnabled        = $workflow.SlackEnabled
            Status              = $workflow.Status
            TimeBasedAccess     = $workflow.TimeBasedAccess
            TtlConfig           = $workflow.TtlConfig
            VisibleTo           = $workflow.VisibleTo
        }

        foreach ($key in @($body.Keys)) {
            if ($null -eq $body[$key]) {
                $body.Remove($key) | Out-Null
            }
        }

        $updatedWorkflow = Set-JcSdkApprovalFlow -ApprovalFlowId $workflow.Id -Body $body

        $updatedWorkflow | Should -Not -BeNullOrEmpty

        $refreshedWorkflow = Get-JcSdkApprovalFlow -ApprovalFlowId $workflow.Id
        $refreshedWorkflow | Should -Not -BeNullOrEmpty
        $refreshedWorkflow.Name | Should -Be $newName
        $refreshedWorkflow.Description | Should -Be $newDescription
    }
}
