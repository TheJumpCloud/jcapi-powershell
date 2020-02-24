#Requires -modules JumpCloud.SDK.V2
Function Set-JCLdapServerSambaDomain
{
    [CmdletBinding(DefaultParameterSetName = 'PutExpanded')]
	Param(
		[Parameter(
			ParameterSetName = 'PutExpanded',
			Mandatory = $true
		)]
		[Parameter(
			ParameterSetName = 'Put',
			Mandatory = $true
		)]
		[System.String]$Id,
		[Parameter(
			ParameterSetName = 'PutExpanded',
			Mandatory = $true
		)]
		[Parameter(
			ParameterSetName = 'Put',
			Mandatory = $true
		)]
		[System.String]$LdapserverId,
		[Parameter(
			ParameterSetName = 'PutViaIdentityExpanded',
			Mandatory = $true,
			ValueFromPipeline = $true
		)]
		[Parameter(
			ParameterSetName = 'PutViaIdentity',
			Mandatory = $true,
			ValueFromPipeline = $true
		)]
		[JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity]$InputObject,
		[Parameter(ParameterSetName = 'PutExpanded')]
		[Parameter(ParameterSetName = 'Put')]
		[Parameter(ParameterSetName = 'PutViaIdentityExpanded')]
		[Parameter(ParameterSetName = 'PutViaIdentity')]
		[System.String]$Accept,
		[Parameter(ParameterSetName = 'PutExpanded')]
		[Parameter(ParameterSetName = 'Put')]
		[Parameter(ParameterSetName = 'PutViaIdentityExpanded')]
		[Parameter(ParameterSetName = 'PutViaIdentity')]
		[System.String]$ContentType,
		[Parameter(
			ParameterSetName = 'PutViaIdentity',
			Mandatory = $true,
			ValueFromPipeline = $true
		)]
		[Parameter(
			ParameterSetName = 'Put',
			Mandatory = $true,
			ValueFromPipeline = $true
		)]
		[JumpCloud.SDK.V2.Models.ISambaDomainInput]$Body,
		[Parameter(
			ParameterSetName = 'PutViaIdentityExpanded',
			Mandatory = $true
		)]
		[Parameter(
			ParameterSetName = 'PutExpanded',
			Mandatory = $true
		)]
		[System.String]$Name,
		[Parameter(
			ParameterSetName = 'PutViaIdentityExpanded',
			Mandatory = $true
		)]
		[Parameter(
			ParameterSetName = 'PutExpanded',
			Mandatory = $true
		)]
		[System.String]$Sid,
		[Parameter(ParameterSetName = 'PutExpanded')]
		[Parameter(ParameterSetName = 'Put')]
		[Parameter(ParameterSetName = 'PutViaIdentityExpanded')]
		[Parameter(ParameterSetName = 'PutViaIdentity')]
		[Alias(cf)][System.Management.Automation.SwitchParameter]$Confirm,
		[Parameter(ParameterSetName = 'PutExpanded')]
		[Parameter(ParameterSetName = 'Put')]
		[Parameter(ParameterSetName = 'PutViaIdentityExpanded')]
		[Parameter(ParameterSetName = 'PutViaIdentity')]
		[Alias(wi)][System.Management.Automation.SwitchParameter]$WhatIf,
		[System.Boolean]$Paginate = $true
	)
    Begin
    {
        $Results = @()
    }
    Process
    {
        $Results = Set-JcSdkLdapServerSambaDomain @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}
