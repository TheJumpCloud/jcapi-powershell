#Requires -modules JumpCloud.SDK.V2
Function Grant-JCWorkdayImportWorkday
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
		[JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity]$InputObject,
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
		[JumpCloud.SDK.V2.Models.IAuthInputObject]$Body,
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
		[Alias(cf)][System.Management.Automation.SwitchParameter]$Confirm,
		[Parameter(ParameterSetName = 'AuthorizeExpanded')]
		[Parameter(ParameterSetName = 'Authorize')]
		[Parameter(ParameterSetName = 'AuthorizeViaIdentityExpanded')]
		[Parameter(ParameterSetName = 'AuthorizeViaIdentity')]
		[Alias(wi)][System.Management.Automation.SwitchParameter]$WhatIf,
		[System.Boolean]$Paginate = $true
	)
    Begin
    {
        $Results = @()
    }
    Process
    {
        $Results = Grant-JcSdkWorkdayImportWorkday @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}
