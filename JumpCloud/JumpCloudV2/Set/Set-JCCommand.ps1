Function Set-JCCommand
{
    #Requires -modules JumpCloud.SDK.V1
    [OutputType([JumpCloud.SDK.V1.Models.ICommand])]
    [CmdletBinding(DefaultParameterSetName='PutExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
        [Parameter(
            ParameterSetName = 'PutExpanded',
            Mandatory = $true
        )]
        [Parameter(
            ParameterSetName = 'Put',
            Mandatory = $true
        )]
        [System.String]$Id,
        [Parameter(
            ParameterSetName = 'PutViaIdentityExpanded',
            Mandatory = $true,
            ValueFromPipeline = $true
        )]
        [Parameter(
            ParameterSetName = 'PutViaIdentity',
            Mandatory = $true,
            ValueFromPipeline = $true
        )]
        [JumpCloud.SDK.V1.Models.IJumpCloudApIsIdentity]$InputObject,
        [Parameter(
            ParameterSetName = 'PutViaIdentity',
            Mandatory = $true,
            ValueFromPipeline = $true
        )]
        [Parameter(
            ParameterSetName = 'Put',
            Mandatory = $true,
            ValueFromPipeline = $true
        )]
        [JumpCloud.SDK.V1.Models.ICommand]$Body,
        [Parameter(
            ParameterSetName = 'PutViaIdentityExpanded',
            Mandatory = $true
        )]
        [Parameter(
            ParameterSetName = 'PutExpanded',
            Mandatory = $true
        )]
        [System.String]$Command,
        [Parameter(ParameterSetName = 'PutViaIdentityExpanded')]
        [Parameter(ParameterSetName = 'PutExpanded')]
        [System.String[]]$CommandRunners,
        [Parameter(ParameterSetName = 'PutViaIdentityExpanded')]
        [Parameter(ParameterSetName = 'PutExpanded')]
        [System.String]$CommandType,
        [Parameter(ParameterSetName = 'PutViaIdentityExpanded')]
        [Parameter(ParameterSetName = 'PutExpanded')]
        [System.String[]]$Files,
        [Parameter(ParameterSetName = 'PutViaIdentityExpanded')]
        [Parameter(ParameterSetName = 'PutExpanded')]
        [System.String]$LaunchType,
        [Parameter(ParameterSetName = 'PutViaIdentityExpanded')]
        [Parameter(ParameterSetName = 'PutExpanded')]
        [System.String]$ListensTo,
        [Parameter(ParameterSetName = 'PutViaIdentityExpanded')]
        [Parameter(ParameterSetName = 'PutExpanded')]
        [System.String]$Name,
        [Parameter(ParameterSetName = 'PutViaIdentityExpanded')]
        [Parameter(ParameterSetName = 'PutExpanded')]
        [System.String]$Organization,
        [Parameter(ParameterSetName = 'PutViaIdentityExpanded')]
        [Parameter(ParameterSetName = 'PutExpanded')]
        [System.String]$Schedule,
        [Parameter(ParameterSetName = 'PutViaIdentityExpanded')]
        [Parameter(ParameterSetName = 'PutExpanded')]
        [System.String]$ScheduleRepeatType,
        [Parameter(ParameterSetName = 'PutViaIdentityExpanded')]
        [Parameter(ParameterSetName = 'PutExpanded')]
        [System.Management.Automation.SwitchParameter]$Sudo,
        [Parameter(ParameterSetName = 'PutViaIdentityExpanded')]
        [Parameter(ParameterSetName = 'PutExpanded')]
        [System.String[]]$Systems,
        [Parameter(ParameterSetName = 'PutViaIdentityExpanded')]
        [Parameter(ParameterSetName = 'PutExpanded')]
        [System.String]$Timeout,
        [Parameter(ParameterSetName = 'PutViaIdentityExpanded')]
        [Parameter(ParameterSetName = 'PutExpanded')]
        [System.String]$Trigger,
        [Parameter(ParameterSetName = 'PutViaIdentityExpanded')]
        [Parameter(ParameterSetName = 'PutExpanded')]
        [System.String]$User
    )
    Begin
    {
        $Results = @()
    }
    Process
    {
        $Results = Set-JcSdkCommand @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}
