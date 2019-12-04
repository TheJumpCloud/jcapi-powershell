#Requires -modules JumpCloudApiSdkV2
Function Update-JCBulkUser
{
    [CmdletBinding(DefaultParameterSetName = 'Update')]
	Param(
		[Parameter(
			ParameterSetName = 'Update',
			Mandatory = $true,
			ValueFromPipeline = $true
		)]
		[JumpCloudApiSdkV2.Models.IBulkUserUpdate[]]$Body,
		[Parameter(ParameterSetName = 'Update')]
		[Alias(wi)][System.Management.Automation.SwitchParameter]$WhatIf,
		[Parameter(ParameterSetName = 'Update')]
		[Alias(cf)][System.Management.Automation.SwitchParameter]$Confirm,
		[System.Boolean]$Paginate = $true
	)
    Begin
    {
        $Results = @()
    }
    Process
    {
        $Results = Update-JcSdkBulkUser @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}
