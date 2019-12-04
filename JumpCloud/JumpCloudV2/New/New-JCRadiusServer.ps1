#Requires -modules JumpCloudApiSdkV1
Function New-JCRadiusServer
{
    [CmdletBinding(DefaultParameterSetName = 'CreateExpanded')]
	Param(
		[Parameter(
			ParameterSetName = 'Create',
			Mandatory = $true,
			ValueFromPipeline = $true
		)]
		[JumpCloudApiSdkV1.Models.IRadiusserverpost]$Body,
		[Parameter(
			ParameterSetName = 'CreateExpanded',
			Mandatory = $true
		)]
		[System.String]$Name,
		[Parameter(
			ParameterSetName = 'CreateExpanded',
			Mandatory = $true
		)]
		[System.String]$NetworkSourceIP,
		[Parameter(
			ParameterSetName = 'CreateExpanded',
			Mandatory = $true
		)]
		[System.String]$SharedSecret,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.String]$Mfa,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.String[]]$TagNames,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.String]$UserLockoutAction,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.String]$UserPasswordExpirationAction,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[Parameter(ParameterSetName = 'Create')]
		[Alias(cf)][System.Management.Automation.SwitchParameter]$Confirm,
		[Parameter(ParameterSetName = 'CreateExpanded')]
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
        $Results = New-JcSdkRadiusServer @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}
