#Requires -modules JumpCloudApiSdkV1
Function New-JCCommand
{
    [CmdletBinding(DefaultParameterSetName = 'CreateExpanded')]
	Param(
		[Parameter(
			ParameterSetName = 'Create',
			Mandatory = $true,
			ValueFromPipeline = $true
		)]
		[JumpCloudApiSdkV1.Models.ICommand]$Body,
		[Parameter(
			ParameterSetName = 'CreateExpanded',
			Mandatory = $true
		)]
		[System.String]$Command,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.String[]]$CommandRunners,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.String]$CommandType,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.String[]]$Files,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.String]$LaunchType,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.String]$ListensTo,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.String]$Name,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.String]$Organization,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.String]$Schedule,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.String]$ScheduleRepeatType,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.Management.Automation.SwitchParameter]$Sudo,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.String[]]$Systems,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.String]$Timeout,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.String]$Trigger,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.String]$User,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[Parameter(ParameterSetName = 'Create')]
		[Alias(wi)][System.Management.Automation.SwitchParameter]$WhatIf,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[Parameter(ParameterSetName = 'Create')]
		[Alias(cf)][System.Management.Automation.SwitchParameter]$Confirm,
		[System.Boolean]$Paginate = $true
	)
    Begin
    {
        $Results = @()
    }
    Process
    {
        $Results = New-JcSdkCommand @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}
