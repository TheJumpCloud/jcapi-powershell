<#
.Synopsis
This endpoint allows you to create a new command.

NOTE: the system property in the command is not used.
Use a POST to /api/v2/commands/{id}/associations to bind a command to a system.

#### Sample Request
```
curl -X POST https://console.jumpcloud.com/api/commands/ \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json'
  -H 'x-api-key: {API_KEY}'
  -d '{\"name\":\"Test API Command\", \"command\":\"String\", \"user\":\"{UserID}\", \"schedule\":\"\", \"timeout\":\"100\"}'
```
.Description
This endpoint allows you to create a new command.

NOTE: the system property in the command is not used.
Use a POST to /api/v2/commands/{id}/associations to bind a command to a system.

#### Sample Request
```
curl -X POST https://console.jumpcloud.com/api/commands/ \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json'
  -H 'x-api-key: {API_KEY}'
  -d '{\"name\":\"Test API Command\", \"command\":\"String\", \"user\":\"{UserID}\", \"schedule\":\"\", \"timeout\":\"100\"}'
```
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
JumpCloud.SDK.V1.Models.ICommand
.Outputs
JumpCloud.SDK.V1.Models.ICommand
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <ICommand>:
  Command1 <String>: The command to execute on the server.
  CommandType <String>: The Command OS
  Name <String>:
  [CommandRunners <String[]>]: An array of IDs of the Command Runner Users that can execute this command.
  [Files <String[]>]: An array of file IDs to include with the command.
  [LaunchType <String>]: How the command will execute.
  [ListensTo <String>]:
  [Organization <String>]: The ID of the organization.
  [Schedule <String>]: A crontab that consists of: [ (seconds) (minutes) (hours) (days of month) (months) (weekdays) ] or [ immediate ]. If you send this as an empty string, it will run immediately.        
  [ScheduleRepeatType <String>]: When the command will repeat.
  [ScheduleYear <Int32?>]: The year that a scheduled command will launch in.
  [Shell <String>]: The shell used to run the command.
  [Sudo <Boolean?>]:
  [Template <String>]: The template this command was created from
  [TimeToLiveSeconds <Int32?>]: Time in seconds a command can wait in the queue to be run before timing out
  [Timeout <String>]: The time in seconds to allow the command to run for. The maximum value is 86400 seconds (1 day).
  [Trigger <String>]: The name of the command trigger.
  [User <String>]: The ID of the system user to run the command as. This field is required when creating a command with a commandType of "mac" or "linux".
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V1/docs/exports/New-JcSdkCommand.md
#>
 Function New-JcSdkCommand
{
    [OutputType([JumpCloud.SDK.V1.Models.ICommand])]
    [CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
    [Parameter(ParameterSetName='Create', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V1.Category('Body')]
    [JumpCloud.SDK.V1.Models.ICommand]
    # Command
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body}, 

    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # The command to execute on the server.
    ${Command}, 

    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # The Command OS
    ${CommandType}, 

    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${Name}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [AllowEmptyCollection()]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String[]]
    # An array of IDs of the Command Runner Users that can execute this command.
    ${CommandRunners}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [AllowEmptyCollection()]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String[]]
    # An array of file IDs to include with the command.
    ${Files}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # How the command will execute.
    ${LaunchType}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${ListensTo}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # The ID of the organization.
    ${Organization}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # A crontab that consists of: [ (seconds) (minutes) (hours) (days of month) (months) (weekdays) ] or [ immediate ].
    # If you send this as an empty string, it will run immediately.
    ${Schedule}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # When the command will repeat.
    ${ScheduleRepeatType}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.Int32]
    # The year that a scheduled command will launch in.
    ${ScheduleYear}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # The shell used to run the command.
    ${Shell}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # .
    ${Sudo}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # The template this command was created from
    ${Template}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.Int32]
    # Time in seconds a command can wait in the queue to be run before timing out
    ${TimeToLiveSeconds}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # The time in seconds to allow the command to run for.
    # The maximum value is 86400 seconds (1 day).
    ${Timeout}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # The name of the command trigger.
    ${Trigger}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # The ID of the system user to run the command as.
    # This field is required when creating a command with a commandType of "mac" or "linux".
    ${User}, 

    [Parameter(DontShow)]
    [JumpCloud.SDK.V1.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break}, 

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [JumpCloud.SDK.V1.Category('Runtime')]
    [JumpCloud.SDK.V1.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend}, 

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [JumpCloud.SDK.V1.Category('Runtime')]
    [JumpCloud.SDK.V1.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend}, 

    [Parameter(DontShow)]
    [JumpCloud.SDK.V1.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy}, 

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [JumpCloud.SDK.V1.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential}, 

    [Parameter(DontShow)]
    [JumpCloud.SDK.V1.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
    )
    Begin
    {
        $Results = @()
        $PSBoundParameters.Add('HttpPipelineAppend', {
                param($req, $callback, $next)
                # call the next step in the Pipeline
                $ResponseTask = $next.SendAsync($req, $callback)
                $global:JCHttpRequest = $req
                # $global:JCHttpRequestContent = If (-not [System.String]::IsNullOrEmpty($req.Content)) { $req.Content.ReadAsStringAsync() }
                $global:JCHttpResponse = $ResponseTask
                # $global:JCHttpResponseContent = If (-not [System.String]::IsNullOrEmpty($ResponseTask.Result.Content)) { $ResponseTask.Result.Content.ReadAsStringAsync() }
                Return $ResponseTask
            }
        )
    }
    Process
    {
        $maxRetries = 4
        $resultCounter = 0
        :retryLoop do {
            $resultCounter++
            $Results = JumpCloud.SDK.V1.internal\New-JcSdkInternalCommand @PSBoundParameters -errorAction SilentlyContinue -errorVariable sdkError
            If ($sdkError){
                If ($resultCounter -eq $maxRetries){
                    throw $sdkError
                }
                If ($JCHttpResponse.Result.StatusCode -eq "503") {
                    Write-Warning ("503: Service Unavailable - retrying in " + ($resultCounter * 5) + " seconds.")
                } else {
                    throw $sdkError
                }
            } else {
                break retryLoop
            }
            Start-Sleep -Seconds ($resultCounter * 5)
        } while ($resultCounter -lt $maxRetries)
    }
    End
    {
        Write-Debug ('HttpRequest: ' + $JCHttpRequest);
        # Write-Debug ('HttpRequestContent: ' + $JCHttpRequestContent.Result);
        Write-Debug ('HttpResponse: ' + $JCHttpResponse.Result);
        # Write-Debug ('HttpResponseContent: ' + $JCHttpResponseContent.Result);
        # Clean up global variables
        $GlobalVars = @('JCHttpRequest', 'JCHttpRequestContent', 'JCHttpResponse', 'JCHttpResponseContent')
        $GlobalVars | ForEach-Object {
            If ((Get-Variable -Scope:('Global')).Where( { $_.Name -eq $_ })) {
                Remove-Variable -Name:($_) -Scope:('Global')
            }
        }
        Return $Results
    }
}


