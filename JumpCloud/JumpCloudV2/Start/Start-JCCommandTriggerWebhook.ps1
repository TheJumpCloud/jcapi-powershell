#Requires -modules JumpCloudApiSdkV1
Function Start-JCCommandTriggerWebhook
{
    [CmdletBinding(DefaultParameterSetName = 'Start')]
	Param(
		[Parameter(
			ParameterSetName = 'Start',
			Mandatory = $true
		)]
		[System.String]$Triggername,
		[Parameter(
			ParameterSetName = 'StartViaIdentity',
			Mandatory = $true,
			ValueFromPipeline = $true
		)]
		[JumpCloudApiSdkV1.Models.IJumpCloudApIsIdentity]$InputObject,
		[Parameter(ParameterSetName = 'Start')]
		[Parameter(ParameterSetName = 'StartViaIdentity')]
		[Alias(wi)][System.Management.Automation.SwitchParameter]$WhatIf,
		[Parameter(ParameterSetName = 'Start')]
		[Parameter(ParameterSetName = 'StartViaIdentity')]
		[Alias(cf)][System.Management.Automation.SwitchParameter]$Confirm,
		[System.Boolean]$Paginate = $true
	)
    Begin
    {
        $Results = @()
    }
    Process
    {
        $Results = Start-JcSdkCommandTriggerWebhook @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}
