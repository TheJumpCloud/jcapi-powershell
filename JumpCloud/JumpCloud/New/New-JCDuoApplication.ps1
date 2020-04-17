#Requires -modules JumpCloud.SDK.V2
Function New-JCDuoApplication
{
    [CmdletBinding(DefaultParameterSetName = 'CreateExpanded')]
	Param(
		[Parameter(
			ParameterSetName = 'CreateExpanded',
			Mandatory = $true
		)]
		[Parameter(
			ParameterSetName = 'Create',
			Mandatory = $true
		)]
		[System.String]$AccountId,
		[Parameter(
			ParameterSetName = 'CreateViaIdentityExpanded',
			Mandatory = $true,
			ValueFromPipeline = $true
		)]
		[Parameter(
			ParameterSetName = 'CreateViaIdentity',
			Mandatory = $true,
			ValueFromPipeline = $true
		)]
		[JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity]$InputObject,
		[Parameter(
			ParameterSetName = 'CreateViaIdentity',
			Mandatory = $true,
			ValueFromPipeline = $true
		)]
		[Parameter(
			ParameterSetName = 'Create',
			Mandatory = $true,
			ValueFromPipeline = $true
		)]
		[JumpCloud.SDK.V2.Models.IDuoApplicationReq]$Body,
		[Parameter(
			ParameterSetName = 'CreateViaIdentityExpanded',
			Mandatory = $true
		)]
		[Parameter(
			ParameterSetName = 'CreateExpanded',
			Mandatory = $true
		)]
		[System.String]$ApiHost,
		[Parameter(
			ParameterSetName = 'CreateViaIdentityExpanded',
			Mandatory = $true
		)]
		[Parameter(
			ParameterSetName = 'CreateExpanded',
			Mandatory = $true
		)]
		[System.String]$IntegrationKey,
		[Parameter(
			ParameterSetName = 'CreateViaIdentityExpanded',
			Mandatory = $true
		)]
		[Parameter(
			ParameterSetName = 'CreateExpanded',
			Mandatory = $true
		)]
		[System.String]$Name,
		[Parameter(
			ParameterSetName = 'CreateViaIdentityExpanded',
			Mandatory = $true
		)]
		[Parameter(
			ParameterSetName = 'CreateExpanded',
			Mandatory = $true
		)]
		[System.String]$SecretKey,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[Parameter(ParameterSetName = 'Create')]
		[Parameter(ParameterSetName = 'CreateViaIdentityExpanded')]
		[Parameter(ParameterSetName = 'CreateViaIdentity')]
		[Alias(cf)][System.Management.Automation.SwitchParameter]$Confirm,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[Parameter(ParameterSetName = 'Create')]
		[Parameter(ParameterSetName = 'CreateViaIdentityExpanded')]
		[Parameter(ParameterSetName = 'CreateViaIdentity')]
		[Alias(wi)][System.Management.Automation.SwitchParameter]$WhatIf,
		[System.Boolean]$Paginate = $true
	)
    Begin
    {
        $Results = @()
    }
    Process
    {
        $Results = New-JcSdkDuoApplication @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}
