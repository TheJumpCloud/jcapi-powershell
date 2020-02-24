#Requires -modules JumpCloud.SDK.V2
Function Remove-JCWorkdayAuthorization
{
    [CmdletBinding(DefaultParameterSetName = 'Remove')]
	Param(
		[Parameter(
			ParameterSetName = 'Remove',
			Mandatory = $true
		)]
		[System.String]$WorkdayId,
		[Parameter(
			ParameterSetName = 'RemoveViaIdentity',
			Mandatory = $true,
			ValueFromPipeline = $true
		)]
		[JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity]$InputObject,
		[Parameter(ParameterSetName = 'Remove')]
		[Parameter(ParameterSetName = 'RemoveViaIdentity')]
		[Alias(cf)][System.Management.Automation.SwitchParameter]$Confirm,
		[Parameter(ParameterSetName = 'Remove')]
		[Parameter(ParameterSetName = 'RemoveViaIdentity')]
		[Alias(wi)][System.Management.Automation.SwitchParameter]$WhatIf,
		[System.Boolean]$Paginate = $true
	)
    Begin
    {
        $Results = @()
    }
    Process
    {
        $Results = Remove-JcSdkWorkdayAuthorization @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}
