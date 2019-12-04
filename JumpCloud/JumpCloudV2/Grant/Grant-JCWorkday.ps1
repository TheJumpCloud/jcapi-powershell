#Requires -modules JumpCloudApiSdkV2
Function Grant-JCWorkday
{
    [CmdletBinding(DefaultParameterSetName = 'AuthorizeExpanded')]
	Param(
		[Parameter(
			ParameterSetName = 'AuthorizeExpanded',
			Mandatory = $true
		)]
		[Parameter(
			ParameterSetName = 'Authorize',
			Mandatory = $true
		)]
		[System.String]$WorkdayId,
		[Parameter(
			ParameterSetName = 'AuthorizeViaIdentityExpanded',
			Mandatory = $true,
			ValueFromPipeline = $true
		)]
		[Parameter(
			ParameterSetName = 'AuthorizeViaIdentity',
			Mandatory = $true,
			ValueFromPipeline = $true
		)]
		[JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentity]$InputObject,
		[Parameter(
			ParameterSetName = 'AuthorizeViaIdentity',
			Mandatory = $true,
			ValueFromPipeline = $true
		)]
		[Parameter(
			ParameterSetName = 'Authorize',
			Mandatory = $true,
			ValueFromPipeline = $true
		)]
		[JumpCloudApiSdkV2.Models.IAuthInputObject]$Body,
		[Parameter(ParameterSetName = 'AuthorizeViaIdentityExpanded')]
		[Parameter(ParameterSetName = 'AuthorizeExpanded')]
		[System.String]$BasicPassword,
		[Parameter(ParameterSetName = 'AuthorizeViaIdentityExpanded')]
		[Parameter(ParameterSetName = 'AuthorizeExpanded')]
		[System.String]$BasicUsername,
		[Parameter(ParameterSetName = 'AuthorizeViaIdentityExpanded')]
		[Parameter(ParameterSetName = 'AuthorizeExpanded')]
		[System.String]$OauthCode,
		[Parameter(ParameterSetName = 'AuthorizeExpanded')]
		[Parameter(ParameterSetName = 'Authorize')]
		[Parameter(ParameterSetName = 'AuthorizeViaIdentityExpanded')]
		[Parameter(ParameterSetName = 'AuthorizeViaIdentity')]
		[Alias(wi)][System.Management.Automation.SwitchParameter]$WhatIf,
		[Parameter(ParameterSetName = 'AuthorizeExpanded')]
		[Parameter(ParameterSetName = 'Authorize')]
		[Parameter(ParameterSetName = 'AuthorizeViaIdentityExpanded')]
		[Parameter(ParameterSetName = 'AuthorizeViaIdentity')]
		[Alias(cf)][System.Management.Automation.SwitchParameter]$Confirm,
		[System.Boolean]$Paginate = $true
	)
    Begin
    {
        $Results = @()
    }
    Process
    {
        $Results = Grant-JcSdkWorkday @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}
