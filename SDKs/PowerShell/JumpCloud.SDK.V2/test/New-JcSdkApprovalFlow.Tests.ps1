if(($null -eq $TestName) -or ($TestName -contains 'New-JcSdkApprovalFlow'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'New-JcSdkApprovalFlow.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

function Get-TestApprovalFlowGroupContext {
    $userGroups = @(Get-JcSdkUserGroup | Where-Object { $_ })

    while ($userGroups.Count -lt 2) {
        $suffix = [guid]::NewGuid().ToString('N').Substring(0,8)
        $userGroups += New-JcSdkUserGroup -Name "PesterApprovalFlowGroup-$suffix"
    }

    $resourceGroup = $userGroups | Get-Random
    $visibleGroup = Get-JcSdkUserGroup -Filter @('name:eq:All Activated Users') | Select-Object -First 1

    if (-not $visibleGroup -or $visibleGroup.Id -eq $resourceGroup.Id) {
        $visibleCandidates = $userGroups | Where-Object { $_.Id -ne $resourceGroup.Id }
        if ($visibleCandidates) {
            $visibleGroup = $visibleCandidates | Get-Random
        }
        else {
            $visibleGroup = $resourceGroup
        }
    }

    [pscustomobject]@{
        ResourceGroup = $resourceGroup
        VisibleGroup  = $visibleGroup
    }
}
Describe 'New-JcSdkApprovalFlow' -Tag:(""){
    It 'Create new approval flow with required parameters' {
        $context = Get-TestApprovalFlowGroupContext
        $flowName = "PesterApprovalFlow-$([guid]::NewGuid().ToString('N').Substring(0,8))"
        $description = "Created new approval flow with required parameters on $(Get-Date -Format 'u')"

        $parameters = @{
            ApprovalType        = 'manual'
            Category            = 'Application'
            Description         = $description
            MultiSelectDuration = @('P5D')
            Name                = $flowName
            NonAdminApproval    = $false
            ResourceId          = $context.ResourceGroup.Id
            ResourceType        = 'user_group'
            SlackEnabled        = $false
            Status              = 'active'
            TimeBasedAccess     = $true
            TtlConfig           = 'TTL_CONFIG_MULTI_SELECT_DURATIONS'
            VisibleTo           = @($context.VisibleGroup.Id)
        }

        $approvalFlow = New-JcSdkApprovalFlow @parameters

        $approvalFlow | Should -Not -BeNullOrEmpty
        $approvalFlow.ID | Should -Not -BeNullOrEmpty
    }


}
