#Requires -modules JumpCloudApiSdkV2
Function Import-JCWorkday
{
    [CmdletBinding(DefaultParameterSetName = 'Import')]
	Param(
		[Parameter(
			ParameterSetName = 'Import',
			Mandatory = $true
		)]
		[System.String]$WorkdayId,
		[Parameter(
			ParameterSetName = 'ImportViaIdentity',
			Mandatory = $true,
			ValueFromPipeline = $true
		)]
		[JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentity]$InputObject,
		[Parameter(
			ParameterSetName = 'Import',
			Mandatory = $true,
			ValueFromPipeline = $true
		)]
		[Parameter(
			ParameterSetName = 'ImportViaIdentity',
			Mandatory = $true,
			ValueFromPipeline = $true
		)]
		[JumpCloudApiSdkV2.Models.IBulkUserCreate[]]$Body,
		[Parameter(ParameterSetName = 'Import')]
		[Parameter(ParameterSetName = 'ImportViaIdentity')]
		[Alias(cf)][System.Management.Automation.SwitchParameter]$Confirm,
		[Parameter(ParameterSetName = 'Import')]
		[Parameter(ParameterSetName = 'ImportViaIdentity')]
		[Alias(wi)][System.Management.Automation.SwitchParameter]$WhatIf,
		[System.Boolean]$Paginate = $true
	)
    Begin
    {
        $Results = @()
    }
    Process
    {
        $Results = Import-JcSdkWorkday @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}
