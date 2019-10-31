<#
.Synopsis
This endpoint allows you to create a new command.\n\n#### Sample Request\n\n```\ncurl -X POST https://console.jumpcloud.com/api/commands/ \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n\t\"name\":\"Test API Command\",\n\t\"command\":\"String\",\n\t\"user\":\"{UserID}\",\n\t\"schedule\":\"\",\n\t\"timeout\":\"100\"\n}'\n\n```
.Description
This endpoint allows you to create a new command.\n\n#### Sample Request\n\n```\ncurl -X POST https://console.jumpcloud.com/api/commands/ \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n\t\"name\":\"Test API Command\",\n\t\"command\":\"String\",\n\t\"user\":\"{UserID}\",\n\t\"schedule\":\"\",\n\t\"timeout\":\"100\"\n}'\n\n```
.Example
To view examples, please use the -Online parameter with Get-Help or navigate to: https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv1/new-jcsdkcommand
.Inputs
JumpCloudApiSdkV1.Models.ICommand
.Outputs
JumpCloudApiSdkV1.Models.ICommand
.Notes
COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <ICommand>: Command
  Command1 <String>: The command to execute on the server.
  [CommandRunners <String[]>]: An array of IDs of the Command Runner Users that can execute this command.
  [CommandType <String>]: The Command OS
  [Files <String[]>]: An array of file IDs to include with the command.
  [LaunchType <String>]: How the command will execute.
  [ListensTo <String>]: 
  [Name <String>]: 
  [Organization <String>]: The ID of the organization.
  [Schedule <String>]: A crontab that consists of: [ (seconds) (minutes) (hours) (days of month) (months) (weekdays) ] or [ immediate ]. If you send this as an empty string, it will run immediately.         
  [ScheduleRepeatType <String>]: When the command will repeat.
  [Sudo <Boolean?>]: 
  [Systems <String[]>]: An array of system IDs to run the command on. Not available if you are using Groups.
  [Timeout <String>]: The time in seconds to allow the command to run for.
  [Trigger <String>]: The name of the command trigger.
  [User <String>]: The ID of the system user to run the command as. This field is required when creating a command with a commandType of "mac" or "linux".
.Link
https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv1/new-jcsdkcommand
#>
function New-JcSdkCommand {
[OutputType([JumpCloudApiSdkV1.Models.ICommand])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Create', Mandatory, ValueFromPipeline)]
    [JumpCloudApiSdkV1.Category('Body')]
    [JumpCloudApiSdkV1.Models.ICommand]
    # Command
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.String]
    # The command to execute on the server.
    ${Command},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.String[]]
    # An array of IDs of the Command Runner Users that can execute this command.
    ${CommandRunners},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.String]
    # The Command OS
    ${CommandType},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.String[]]
    # An array of file IDs to include with the command.
    ${Files},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.String]
    # How the command will execute.
    ${LaunchType},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.String]
    # HELP MESSAGE MISSING
    ${ListensTo},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.String]
    # HELP MESSAGE MISSING
    ${Name},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.String]
    # The ID of the organization.
    ${Organization},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.String]
    # A crontab that consists of: [ (seconds) (minutes) (hours) (days of month) (months) (weekdays) ] or [ immediate ].
    # If you send this as an empty string, it will run immediately.
    ${Schedule},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.String]
    # When the command will repeat.
    ${ScheduleRepeatType},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # HELP MESSAGE MISSING
    ${Sudo},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.String[]]
    # An array of system IDs to run the command on.
    # Not available if you are using Groups.
    ${Systems},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.String]
    # The time in seconds to allow the command to run for.
    ${Timeout},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.String]
    # The name of the command trigger.
    ${Trigger},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.String]
    # The ID of the system user to run the command as.
    # This field is required when creating a command with a commandType of "mac" or "linux".
    ${User},

    [Parameter(DontShow)]
    [JumpCloudApiSdkV1.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [JumpCloudApiSdkV1.Category('Runtime')]
    [JumpCloudApiSdkV1.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [JumpCloudApiSdkV1.Category('Runtime')]
    [JumpCloudApiSdkV1.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [JumpCloudApiSdkV1.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Returns true when the command succeeds
    ${PassThru},

    [Parameter(DontShow)]
    [JumpCloudApiSdkV1.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [JumpCloudApiSdkV1.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [JumpCloudApiSdkV1.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            Create = 'JumpCloudApiSdkV1.private\New-JcSdkCommand_Create';
            CreateExpanded = 'JumpCloudApiSdkV1.private\New-JcSdkCommand_CreateExpanded';
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}
