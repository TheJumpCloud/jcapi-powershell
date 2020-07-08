<#
.Synopsis
This endpoint allows you to update a system.\n\n#### Sample Request \n```\ncurl -X PUT https://console.jumpcloud.com/api/systems/{SystemID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n\t\"displayName\":\"Name_Update\",\n\t\"allowSshPasswordAuthentication\":\"true\",\n\t\"allowSshRootLogin\":\"true\",\n\t\"allowMultiFactorAuthentication\":\"true\",\n\t\"allowPublicKeyAuthentication\":\"false\"\n}'\n```
.Description
This endpoint allows you to update a system.\n\n#### Sample Request \n```\ncurl -X PUT https://console.jumpcloud.com/api/systems/{SystemID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n\t\"displayName\":\"Name_Update\",\n\t\"allowSshPasswordAuthentication\":\"true\",\n\t\"allowSshRootLogin\":\"true\",\n\t\"allowMultiFactorAuthentication\":\"true\",\n\t\"allowPublicKeyAuthentication\":\"false\"\n}'\n```
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
JumpCloud.SDK.V1.Models.IJumpCloudApIsIdentity
.Inputs
JumpCloud.SDK.V1.Models.ISystemput
.Outputs
JumpCloud.SDK.V1.Models.IJcSystem
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

AGENTBOUNDMESSAGES <ISystemputAgentBoundMessagesItem[]>: 
  [Cmd <String>]: 

BODY <ISystemput>: 
  [AgentBoundMessages <ISystemputAgentBoundMessagesItem[]>]: 
    [Cmd <String>]: 
  [AllowMultiFactorAuthentication <Boolean?>]: 
  [AllowPublicKeyAuthentication <Boolean?>]: 
  [AllowSshPasswordAuthentication <Boolean?>]: 
  [AllowSshRootLogin <Boolean?>]: 
  [DisplayName <String>]: 
  [Tags <String[]>]: 

INPUTOBJECT <IJumpCloudApIsIdentity>: 
  [Id <String>]: 
  [SystemuserId <String>]: 
  [Triggername <String>]: 
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/jumpcloud.sdk.v1/set-jcsdksystem
#>
 Function Set-JcSdkSystem
{
    [OutputType([JumpCloud.SDK.V1.Models.IJcSystem])]
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
    [JumpCloud.SDK.V1.Models.ISystemput]
    # SystemPut
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='PutExpanded')]
    [Parameter(ParameterSetName='PutViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [JumpCloud.SDK.V1.Models.ISystemputAgentBoundMessagesItem[]]
    # .
    # To construct, see NOTES section for AGENTBOUNDMESSAGES properties and create a hash table.
    ${AgentBoundMessages},

    [Parameter(ParameterSetName='PutExpanded')]
    [Parameter(ParameterSetName='PutViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # .
    ${AllowMultiFactorAuthentication},

    [Parameter(ParameterSetName='PutExpanded')]
    [Parameter(ParameterSetName='PutViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # .
    ${AllowPublicKeyAuthentication},

    [Parameter(ParameterSetName='PutExpanded')]
    [Parameter(ParameterSetName='PutViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # .
    ${AllowSshPasswordAuthentication},

    [Parameter(ParameterSetName='PutExpanded')]
    [Parameter(ParameterSetName='PutViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # .
    ${AllowSshRootLogin},

    [Parameter(ParameterSetName='PutExpanded')]
    [Parameter(ParameterSetName='PutViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${DisplayName},

    [Parameter(ParameterSetName='PutExpanded')]
    [Parameter(ParameterSetName='PutViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String[]]
    # .
    ${Tags}
    )
    Begin
    {
        $Results = @()
    }
    Process
    {
        $Results = JumpCloud.SDK.V1.internal\Set-JcSdkInternalSystem @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}

