#Requires -modules JumpCloudApiSdkV2
Function Remove-JCSystemGroup
{
    [CmdletBinding(DefaultParameterSetName = 'Delete')]
	Param(
		[Parameter(
			ParameterSetName = 'Delete',
			Mandatory = $true
		)]
		[System.String]$Id,
		[Parameter(
			ParameterSetName = 'DeleteViaIdentity',
			Mandatory = $true,
			ValueFromPipeline = $true
		)]
		[JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentity]$InputObject,
		[Parameter(ParameterSetName = 'Delete')]
		[Parameter(ParameterSetName = 'DeleteViaIdentity')]
		[Alias(cf)][System.Management.Automation.SwitchParameter]$Confirm,
		[Parameter(ParameterSetName = 'Delete')]
		[Parameter(ParameterSetName = 'DeleteViaIdentity')]
		[Alias(wi)][System.Management.Automation.SwitchParameter]$WhatIf,
		[System.Boolean]$Paginate = $true
	)
    Begin
    {
        $Results = @()
    }
    Process
    {
        $Results = Remove-JcSdkSystemGroup @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}
