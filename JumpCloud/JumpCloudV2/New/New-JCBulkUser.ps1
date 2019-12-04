#Requires -modules JumpCloudApiSdkV2
Function New-JCBulkUser
{
    [CmdletBinding(DefaultParameterSetName = 'Create')]
	Param(
		[Parameter(
			ParameterSetName = 'Create',
			Mandatory = $true,
			ValueFromPipeline = $true
		)]
		[JumpCloudApiSdkV2.Models.IBulkUserCreate[]]$Body,
		[Parameter(ParameterSetName = 'Create')]
		[Alias(cf)][System.Management.Automation.SwitchParameter]$Confirm,
		[Parameter(ParameterSetName = 'Create')]
		[Alias(wi)][System.Management.Automation.SwitchParameter]$WhatIf,
		[System.Boolean]$Paginate = $true
	)
    Begin
    {
        $Results = @()
    }
    Process
    {
        $Results = New-JcSdkBulkUser @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}
