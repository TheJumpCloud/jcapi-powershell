<#
.Synopsis
This endpoint Updates a command based on the command ID and returns the modified command record.\n\n#### Sample Request\n```\ncurl -X PUT https://console.jumpcloud.com/api/commands/{CommandID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n\t\"name\":\"Test API Command\",\n\t\"command\":\"String\",\n\t\"user\":\"{UserID}\",\n\t\"schedule\":\"\",\n\t\"timeout\":\"100\"\n}'\n\n```
.Description
This endpoint Updates a command based on the command ID and returns the modified command record.\n\n#### Sample Request\n```\ncurl -X PUT https://console.jumpcloud.com/api/commands/{CommandID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n\t\"name\":\"Test API Command\",\n\t\"command\":\"String\",\n\t\"user\":\"{UserID}\",\n\t\"schedule\":\"\",\n\t\"timeout\":\"100\"\n}'\n\n```
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
JumpCloud.SDK.V1.Models.ICommand
.Inputs
JumpCloud.SDK.V1.Models.IJumpCloudApIsIdentity
.Outputs
JumpCloud.SDK.V1.Models.ICommand
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <ICommand>:
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
  [Shell <String>]: The shell used to run the command.
  [Sudo <Boolean?>]:
  [Systems <String[]>]: An array of system IDs to run the command on. Not available if you are using Groups.
  [Timeout <String>]: The time in seconds to allow the command to run for.
  [Trigger <String>]: The name of the command trigger.
  [User <String>]: The ID of the system user to run the command as. This field is required when creating a command with a commandType of "mac" or "linux".

INPUTOBJECT <IJumpCloudApIsIdentity>:
  [Id <String>]:
  [SystemuserId <String>]:
  [Triggername <String>]:
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V1/docs/exports/Set-JcSdkCommand.md
#>
 Function Set-JcSdkCommand
{
    [OutputType([JumpCloud.SDK.V1.Models.ICommand])]
    [CmdletBinding(DefaultParameterSetName='PutExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
    [Parameter(ParameterSetName='Put', Mandatory)]
    [Parameter(ParameterSetName='PutExpanded', Mandatory)]
    [JumpCloud.SDK.V1.Category('Path')]
    [System.String]
    # .
    ${Id},

    [Parameter(ParameterSetName='PutViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='PutViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V1.Category('Path')]
    [JumpCloud.SDK.V1.Models.IJumpCloudApIsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='Put', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='PutViaIdentity', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V1.Category('Body')]
    [JumpCloud.SDK.V1.Models.ICommand]
    # Command
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='PutExpanded', Mandatory)]
    [Parameter(ParameterSetName='PutViaIdentityExpanded', Mandatory)]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # The command to execute on the server.
    ${Command},

    [Parameter(ParameterSetName='PutExpanded')]
    [Parameter(ParameterSetName='PutViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String[]]
    # An array of IDs of the Command Runner Users that can execute this command.
    ${CommandRunners},

    [Parameter(ParameterSetName='PutExpanded')]
    [Parameter(ParameterSetName='PutViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # The Command OS
    ${CommandType},

    [Parameter(ParameterSetName='PutExpanded')]
    [Parameter(ParameterSetName='PutViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String[]]
    # An array of file IDs to include with the command.
    ${Files},

    [Parameter(ParameterSetName='PutExpanded')]
    [Parameter(ParameterSetName='PutViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # How the command will execute.
    ${LaunchType},

    [Parameter(ParameterSetName='PutExpanded')]
    [Parameter(ParameterSetName='PutViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${ListensTo},

    [Parameter(ParameterSetName='PutExpanded')]
    [Parameter(ParameterSetName='PutViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${Name},

    [Parameter(ParameterSetName='PutExpanded')]
    [Parameter(ParameterSetName='PutViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # The ID of the organization.
    ${Organization},

    [Parameter(ParameterSetName='PutExpanded')]
    [Parameter(ParameterSetName='PutViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # A crontab that consists of: [ (seconds) (minutes) (hours) (days of month) (months) (weekdays) ] or [ immediate ].
    # If you send this as an empty string, it will run immediately.
    ${Schedule},

    [Parameter(ParameterSetName='PutExpanded')]
    [Parameter(ParameterSetName='PutViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # When the command will repeat.
    ${ScheduleRepeatType},

    [Parameter(ParameterSetName='PutExpanded')]
    [Parameter(ParameterSetName='PutViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # The shell used to run the command.
    ${Shell},

    [Parameter(ParameterSetName='PutExpanded')]
    [Parameter(ParameterSetName='PutViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # .
    ${Sudo},

    [Parameter(ParameterSetName='PutExpanded')]
    [Parameter(ParameterSetName='PutViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String[]]
    # An array of system IDs to run the command on.
    # Not available if you are using Groups.
    ${Systems},

    [Parameter(ParameterSetName='PutExpanded')]
    [Parameter(ParameterSetName='PutViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # The time in seconds to allow the command to run for.
    ${Timeout},

    [Parameter(ParameterSetName='PutExpanded')]
    [Parameter(ParameterSetName='PutViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # The name of the command trigger.
    ${Trigger},

    [Parameter(ParameterSetName='PutExpanded')]
    [Parameter(ParameterSetName='PutViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # The ID of the system user to run the command as.
    # This field is required when creating a command with a commandType of "mac" or "linux".
    ${User},

    [Parameter()]
    [JumpCloud.SDK.V1.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Returns true when the command succeeds
    ${PassThru}
    )
    Begin
    {
        $Results = @()
        $PSBoundParameters.Add('HttpPipelineAppend', {
                param($req, $callback, $next)
                # call the next step in the Pipeline
                $ResponseTask = $next.SendAsync($req, $callback)
                $global:JCHttpRequest = $req
                $global:JCHttpRequestContent = If (-not [System.String]::IsNullOrEmpty($req.Content)) { $req.Content.ReadAsStringAsync() }
                $global:JCHttpResponse = $ResponseTask
                Return $ResponseTask
            }
        )
    }
    Process
    {
        $Results = JumpCloud.SDK.V1.internal\Set-JcSdkInternalCommand @PSBoundParameters
    }
    End
    {
        Write-Debug ('HttpRequest: ' + $JCHttpRequest);
        Write-Debug ('HttpRequestContent: ' + $JCHttpRequestContent.Result);
        Write-Debug ('HttpResponse: ' + $JCHttpResponse.Result);
        # Clean up global variables
        $GlobalVars = @('JCHttpRequest', 'JCHttpRequestContent', 'JCHttpResponse')
        $GlobalVars | ForEach-Object {
            If ((Get-Variable -Scope:('Global')).Where( { $_.Name -eq $_ })) { Remove-Variable -Name:($_) -Scope:('Global') }
        }
        Return $Results
    }
}

