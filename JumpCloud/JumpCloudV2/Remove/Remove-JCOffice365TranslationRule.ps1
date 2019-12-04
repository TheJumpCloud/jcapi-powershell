#Requires -modules JumpCloudApiSdkV2
Function Remove-JCOffice365TranslationRule
{
    [CmdletBinding(DefaultParameterSetName = 'Delete')]
	Param(
		[Parameter(
			ParameterSetName = 'Delete',
			Mandatory = $true
		)]
		[System.String]$Id,
		[Parameter(
			ParameterSetName = 'Delete',
			Mandatory = $true
		)]
		[System.String]$Office365Id,
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
        $Results = Remove-JcSdkOffice365TranslationRule @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}
