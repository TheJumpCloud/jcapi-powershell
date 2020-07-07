<#
.Synopsis
This endpoint allows you to launch a command based on a defined trigger.\n\n#### Sample Requests\n\n**Launch a Command via a Trigger**\n\n```\ncurl --silent \\\n     -X 'POST' \\\n     -H \"x-api-key: {API_KEY}\" \\\n     \"https://console.jumpcloud.com/api/command/trigger/{TriggerName}\"\n```\n**Launch a Command via a Trigger passing a JSON object to the command**\n```\ncurl --silent \\\n     -X 'POST' \\\n     -H \"x-api-key: {API_KEY}\" \\\n     -H 'Accept: application/json' \\\n     -H 'Content-Type: application/json' \\\n     -d '{ \"srcip\":\"192.168.2.32\", \"attack\":\"Cross Site Scripting Attempt\" }' \\\n     \"https://console.jumpcloud.com/api/command/trigger/{TriggerName}\"\n```
.Description
This endpoint allows you to launch a command based on a defined trigger.\n\n#### Sample Requests\n\n**Launch a Command via a Trigger**\n\n```\ncurl --silent \\\n     -X 'POST' \\\n     -H \"x-api-key: {API_KEY}\" \\\n     \"https://console.jumpcloud.com/api/command/trigger/{TriggerName}\"\n```\n**Launch a Command via a Trigger passing a JSON object to the command**\n```\ncurl --silent \\\n     -X 'POST' \\\n     -H \"x-api-key: {API_KEY}\" \\\n     -H 'Accept: application/json' \\\n     -H 'Content-Type: application/json' \\\n     -d '{ \"srcip\":\"192.168.2.32\", \"attack\":\"Cross Site Scripting Attempt\" }' \\\n     \"https://console.jumpcloud.com/api/command/trigger/{TriggerName}\"\n```
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
JumpCloud.SDK.V1.Models.IJumpCloudApIsIdentity
.Outputs
System.String
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IJumpCloudApIsIdentity>: 
  [Id <String>]: 
  [SystemuserId <String>]: 
  [Triggername <String>]: 
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/AutoRest/SDKs/PowerShell/jumpcloud.sdk.v1/invoke-jcsdkcommandtrigger
#>
 Function Invoke-JcSdkCommandTrigger
{
    [OutputType([System.String])]
    [CmdletBinding(DefaultParameterSetName='Post', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
    [Parameter(ParameterSetName='Post', Mandatory)]
    [JumpCloud.SDK.V1.Category('Path')]
    [System.String]
    # .
    ${Triggername},

    [Parameter(ParameterSetName='PostViaIdentity', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V1.Category('Path')]
    [JumpCloud.SDK.V1.Models.IJumpCloudApIsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [JumpCloud.SDK.V1.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Returns true when the command succeeds
    ${PassThru}
    )
    Begin
    {
        $Results = @()
    }
    Process
    {
        $Results = JumpCloud.SDK.V1.internal\Invoke-JcSdkInternalCommandTrigger @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}
