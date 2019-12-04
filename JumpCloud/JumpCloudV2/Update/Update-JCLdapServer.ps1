#Requires -modules JumpCloudApiSdkV2
Function Update-JCLdapServer
{
    [CmdletBinding(DefaultParameterSetName = 'PatchExpanded')]
	Param(
		[Parameter(ParameterSetName = 'PatchViaIdentityExpanded')]
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
		[JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentity]$InputObject,
		[Parameter(ParameterSetName = 'PatchExpanded')]
		[Parameter(ParameterSetName = 'PatchViaIdentityExpanded')]
		[Parameter(ParameterSetName = 'Patch')]
		[Parameter(ParameterSetName = 'PatchViaIdentity')]
		[System.String]$XApiKey,
		[Parameter(ParameterSetName = 'PatchExpanded')]
		[Parameter(ParameterSetName = 'PatchViaIdentityExpanded')]
		[Parameter(ParameterSetName = 'Patch')]
		[Parameter(ParameterSetName = 'PatchViaIdentity')]
		[System.String]$XOrgId,
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
		[JumpCloudApiSdkV2.Models.IBodyParameterLdapServerPatchRequestBody]$Body,
		[Parameter(ParameterSetName = 'PatchExpanded')]
		[System.String]$Id1,
		[Parameter(ParameterSetName = 'PatchViaIdentityExpanded')]
		[Parameter(ParameterSetName = 'PatchExpanded')]
		[System.String]$UserLockoutAction,
		[Parameter(ParameterSetName = 'PatchViaIdentityExpanded')]
		[Parameter(ParameterSetName = 'PatchExpanded')]
		[System.String]$UserPasswordExpirationAction,
		[Parameter(ParameterSetName = 'PatchExpanded')]
		[Parameter(ParameterSetName = 'PatchViaIdentityExpanded')]
		[Parameter(ParameterSetName = 'Patch')]
		[Parameter(ParameterSetName = 'PatchViaIdentity')]
		[Alias(wi)][System.Management.Automation.SwitchParameter]$WhatIf,
		[Parameter(ParameterSetName = 'PatchExpanded')]
		[Parameter(ParameterSetName = 'PatchViaIdentityExpanded')]
		[Parameter(ParameterSetName = 'Patch')]
		[Parameter(ParameterSetName = 'PatchViaIdentity')]
		[Alias(cf)][System.Management.Automation.SwitchParameter]$Confirm,
		[System.Boolean]$Paginate = $true
	)
    Begin
    {
        $Results = @()
    }
    Process
    {
        $Results = Update-JcSdkLdapServer @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}
