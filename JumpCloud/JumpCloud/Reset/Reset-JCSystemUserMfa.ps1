#Requires -modules JumpCloud.SDK.V1
Function Reset-JCSystemUserMfa
{
    [CmdletBinding(DefaultParameterSetName = 'ResetExpanded')]
	Param(
		[Parameter(
			ParameterSetName = 'ResetExpanded',
			Mandatory = $true
		)]
		[Parameter(
			ParameterSetName = 'Reset',
			Mandatory = $true
		)]
		[System.String]$Id,
		[Parameter(
			ParameterSetName = 'ResetViaIdentityExpanded',
			Mandatory = $true,
			ValueFromPipeline = $true
		)]
		[Parameter(
			ParameterSetName = 'ResetViaIdentity',
			Mandatory = $true,
			ValueFromPipeline = $true
		)]
		[JumpCloud.SDK.V1.Models.IJumpCloudApIsIdentity]$InputObject,
		[Parameter(
			ParameterSetName = 'ResetViaIdentity',
			Mandatory = $true,
			ValueFromPipeline = $true
		)]
		[Parameter(
			ParameterSetName = 'Reset',
			Mandatory = $true,
			ValueFromPipeline = $true
		)]
		[JumpCloud.SDK.V1.Models.IPathsYhix24SystemusersIdResetmfaPostRequestbodyContentApplicationJsonSchema]$Body,
		[Parameter(ParameterSetName = 'ResetViaIdentityExpanded')]
		[Parameter(ParameterSetName = 'ResetExpanded')]
		[System.Management.Automation.SwitchParameter]$Exclusion,
		[Parameter(ParameterSetName = 'ResetViaIdentityExpanded')]
		[Parameter(ParameterSetName = 'ResetExpanded')]
		[System.DateTime]$ExclusionUntil,
		[Parameter(ParameterSetName = 'ResetExpanded')]
		[Parameter(ParameterSetName = 'Reset')]
		[Parameter(ParameterSetName = 'ResetViaIdentityExpanded')]
		[Parameter(ParameterSetName = 'ResetViaIdentity')]
		[Alias(cf)][System.Management.Automation.SwitchParameter]$Confirm,
		[Parameter(ParameterSetName = 'ResetExpanded')]
		[Parameter(ParameterSetName = 'Reset')]
		[Parameter(ParameterSetName = 'ResetViaIdentityExpanded')]
		[Parameter(ParameterSetName = 'ResetViaIdentity')]
		[Alias(wi)][System.Management.Automation.SwitchParameter]$WhatIf,
		[System.Boolean]$Paginate = $true
	)
    Begin
    {
        $Results = @()
    }
    Process
    {
        $Results = Reset-JcSdkSystemUserMfa @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}
