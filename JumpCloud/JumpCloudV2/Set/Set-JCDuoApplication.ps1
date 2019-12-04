#Requires -modules JumpCloudApiSdkV2
Function Set-JCDuoApplication
{
    [CmdletBinding(DefaultParameterSetName = 'UpdateExpanded')]
	Param(
		[Parameter(
			ParameterSetName = 'UpdateExpanded',
			Mandatory = $true
		)]
		[Parameter(
			ParameterSetName = 'Update',
			Mandatory = $true
		)]
		[System.String]$AccountId,
		[Parameter(
			ParameterSetName = 'UpdateExpanded',
			Mandatory = $true
		)]
		[Parameter(
			ParameterSetName = 'Update',
			Mandatory = $true
		)]
		[System.String]$ApplicationId,
		[Parameter(
			ParameterSetName = 'UpdateViaIdentityExpanded',
			Mandatory = $true,
			ValueFromPipeline = $true
		)]
		[Parameter(
			ParameterSetName = 'UpdateViaIdentity',
			Mandatory = $true,
			ValueFromPipeline = $true
		)]
		[JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentity]$InputObject,
		[Parameter(
			ParameterSetName = 'UpdateViaIdentity',
			Mandatory = $true,
			ValueFromPipeline = $true
		)]
		[Parameter(
			ParameterSetName = 'Update',
			Mandatory = $true,
			ValueFromPipeline = $true
		)]
		[JumpCloudApiSdkV2.Models.IDuoApplicationUpdateReq]$Body,
		[Parameter(ParameterSetName = 'UpdateViaIdentityExpanded')]
		[Parameter(ParameterSetName = 'UpdateExpanded')]
		[System.String]$ApiHost,
		[Parameter(ParameterSetName = 'UpdateViaIdentityExpanded')]
		[Parameter(ParameterSetName = 'UpdateExpanded')]
		[System.String]$IntegrationKey,
		[Parameter(ParameterSetName = 'UpdateViaIdentityExpanded')]
		[Parameter(ParameterSetName = 'UpdateExpanded')]
		[System.String]$Name,
		[Parameter(ParameterSetName = 'UpdateViaIdentityExpanded')]
		[Parameter(ParameterSetName = 'UpdateExpanded')]
		[System.String]$SecretKey,
		[Parameter(ParameterSetName = 'UpdateExpanded')]
		[Parameter(ParameterSetName = 'Update')]
		[Parameter(ParameterSetName = 'UpdateViaIdentityExpanded')]
		[Parameter(ParameterSetName = 'UpdateViaIdentity')]
		[Alias(wi)][System.Management.Automation.SwitchParameter]$WhatIf,
		[Parameter(ParameterSetName = 'UpdateExpanded')]
		[Parameter(ParameterSetName = 'Update')]
		[Parameter(ParameterSetName = 'UpdateViaIdentityExpanded')]
		[Parameter(ParameterSetName = 'UpdateViaIdentity')]
		[Alias(cf)][System.Management.Automation.SwitchParameter]$Confirm,
		[System.Boolean]$Paginate = $true
	)
    Begin
    {
        $Results = @()
    }
    Process
    {
        $Results = Set-JcSdkDuoApplication @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}
