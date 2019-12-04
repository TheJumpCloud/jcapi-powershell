#Requires -modules JumpCloudApiSdkV2
Function New-JCUserGroup
{
    [CmdletBinding(DefaultParameterSetName = 'CreateExpanded')]
	Param(
		[Parameter(
			ParameterSetName = 'Create',
			Mandatory = $true,
			ValueFromPipeline = $true
		)]
		[JumpCloudApiSdkV2.Models.IUserGroupPost]$Body,
		[Parameter(
			ParameterSetName = 'CreateExpanded',
			Mandatory = $true
		)]
		[System.String]$Name,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[JumpCloudApiSdkV2.Models.IUserGroupAttributesPosixGroupsItem[]]$AttributePosixGroups,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.Management.Automation.SwitchParameter]$AttributeSambaEnabled,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[Parameter(ParameterSetName = 'Create')]
		[Alias(wi)][System.Management.Automation.SwitchParameter]$WhatIf,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[Parameter(ParameterSetName = 'Create')]
		[Alias(cf)][System.Management.Automation.SwitchParameter]$Confirm,
		[System.Boolean]$Paginate = $true
	)
    Begin
    {
        $Results = @()
    }
    Process
    {
        $Results = New-JcSdkUserGroup @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}
