#Requires -modules JumpCloudApiSdkV1
Function Remove-JCApplication
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
		[JumpCloudApiSdkV1.Models.IJumpCloudApIsIdentity]$InputObject,
		[Parameter(ParameterSetName = 'Delete')]
		[Parameter(ParameterSetName = 'DeleteViaIdentity')]
		[System.String]$Accept,
		[Parameter(ParameterSetName = 'Delete')]
		[Parameter(ParameterSetName = 'DeleteViaIdentity')]
		[System.String]$ContentType,
		[Parameter(ParameterSetName = 'Delete')]
		[Parameter(ParameterSetName = 'DeleteViaIdentity')]
		[System.String]$XOrgId,
		[Parameter(ParameterSetName = 'Delete')]
		[Parameter(ParameterSetName = 'DeleteViaIdentity')]
		[Alias(wi)][System.Management.Automation.SwitchParameter]$WhatIf,
		[Parameter(ParameterSetName = 'Delete')]
		[Parameter(ParameterSetName = 'DeleteViaIdentity')]
		[Alias(cf)][System.Management.Automation.SwitchParameter]$Confirm,
		[System.Boolean]$Paginate = $true
	)
    Begin
    {
        $Results = @()
    }
    Process
    {
        $Results = Remove-JcSdkApplication @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}
