#Requires -modules JumpCloudApiSdkV1
Function Unlock-JCSystemUser
{
    [CmdletBinding(DefaultParameterSetName = 'Unlock')]
	Param(
		[Parameter(
			ParameterSetName = 'Unlock',
			Mandatory = $true
		)]
		[System.String]$Id,
		[Parameter(
			ParameterSetName = 'UnlockViaIdentity',
			Mandatory = $true,
			ValueFromPipeline = $true
		)]
		[JumpCloudApiSdkV1.Models.IJumpCloudApIsIdentity]$InputObject,
		[Parameter(ParameterSetName = 'Unlock')]
		[Parameter(ParameterSetName = 'UnlockViaIdentity')]
		[Alias(wi)][System.Management.Automation.SwitchParameter]$WhatIf,
		[Parameter(ParameterSetName = 'Unlock')]
		[Parameter(ParameterSetName = 'UnlockViaIdentity')]
		[Alias(cf)][System.Management.Automation.SwitchParameter]$Confirm,
		[System.Boolean]$Paginate = $true
	)
    Begin
    {
        $Results = @()
    }
    Process
    {
        $Results = Unlock-JcSdkSystemUser @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}
