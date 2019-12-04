#Requires -modules JumpCloudApiSdkV2
Function New-JCWorkday
{
    [CmdletBinding(DefaultParameterSetName = 'CreateExpanded')]
	Param(
		[Parameter(
			ParameterSetName = 'Create',
			Mandatory = $true,
			ValueFromPipeline = $true
		)]
		[JumpCloudApiSdkV2.Models.IWorkdayInput]$Body,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.String]$BasicPassword,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.String]$BasicUsername,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.String]$Name,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.String]$OauthCode,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.String]$ReportUrl,
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
        $Results = New-JcSdkWorkday @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}
