#Requires -modules JumpCloud.SDK.V2
Function Set-JCSystemGroup
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
		[JumpCloud.SDK.V2.Models.ISystemGroupData]$Body,
		[Parameter(
			ParameterSetName = 'PutViaIdentityExpanded',
			Mandatory = $true
		)]
		[Parameter(
			ParameterSetName = 'PutExpanded',
			Mandatory = $true
		)]
		[System.String]$Name,
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
        $Results = Set-JcSdkSystemGroup @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}
