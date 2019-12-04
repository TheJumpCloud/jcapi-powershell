#Requires -modules JumpCloudApiSdkV2
Function New-JCDuoAccount
{
    [CmdletBinding(DefaultParameterSetName = 'Create')]
	Param(
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
        $Results = New-JcSdkDuoAccount @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}
