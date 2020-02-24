#Requires -modules JumpCloud.SDK.V2
Function Update-JCGSuite
{
    [CmdletBinding(DefaultParameterSetName = 'PatchExpanded')]
	Param(
		[Parameter(
			ParameterSetName = 'PatchExpanded',
			Mandatory = $true
		)]
		[Parameter(
			ParameterSetName = 'Patch',
			Mandatory = $true
		)]
		[System.String]$Id,
		[Parameter(
			ParameterSetName = 'PatchViaIdentityExpanded',
			Mandatory = $true,
			ValueFromPipeline = $true
		)]
		[Parameter(
			ParameterSetName = 'PatchViaIdentity',
			Mandatory = $true,
			ValueFromPipeline = $true
		)]
		[JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity]$InputObject,
		[Parameter(
			ParameterSetName = 'PatchViaIdentity',
			Mandatory = $true,
			ValueFromPipeline = $true
		)]
		[Parameter(
			ParameterSetName = 'Patch',
			Mandatory = $true,
			ValueFromPipeline = $true
		)]
		[JumpCloud.SDK.V2.Models.IGsuitePatchInput]$Body,
		[Parameter(ParameterSetName = 'PatchViaIdentityExpanded')]
		[Parameter(ParameterSetName = 'PatchExpanded')]
		[System.String]$UserLockoutAction,
		[Parameter(ParameterSetName = 'PatchViaIdentityExpanded')]
		[Parameter(ParameterSetName = 'PatchExpanded')]
		[System.String]$UserPasswordExpirationAction,
		[Parameter(ParameterSetName = 'PatchExpanded')]
		[Parameter(ParameterSetName = 'Patch')]
		[Parameter(ParameterSetName = 'PatchViaIdentityExpanded')]
		[Parameter(ParameterSetName = 'PatchViaIdentity')]
		[Alias(cf)][System.Management.Automation.SwitchParameter]$Confirm,
		[Parameter(ParameterSetName = 'PatchExpanded')]
		[Parameter(ParameterSetName = 'Patch')]
		[Parameter(ParameterSetName = 'PatchViaIdentityExpanded')]
		[Parameter(ParameterSetName = 'PatchViaIdentity')]
		[Alias(wi)][System.Management.Automation.SwitchParameter]$WhatIf,
		[System.Boolean]$Paginate = $true
	)
    Begin
    {
        $Results = @()
    }
    Process
    {
        $Results = Update-JcSdkGSuite @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}
