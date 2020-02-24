#Requires -modules JumpCloud.SDK.V2
Function Update-JCBulkUser
{
    [CmdletBinding(DefaultParameterSetName = 'Patch')]
	Param(
		[Parameter(
			ParameterSetName = 'Patch',
			Mandatory = $true,
			ValueFromPipeline = $true
		)]
		[JumpCloud.SDK.V2.Models.IBulkUserUpdate[]]$Body,
		[Parameter(ParameterSetName = 'Patch')]
		[Alias(cf)][System.Management.Automation.SwitchParameter]$Confirm,
		[Parameter(ParameterSetName = 'Patch')]
		[Alias(wi)][System.Management.Automation.SwitchParameter]$WhatIf,
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
