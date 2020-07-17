<#
.Synopsis
Erases a DEP-enrolled device.\n\n#### Sample Request\n```\n  curl -X POST https://console.jumpcloud.com/api/v2/applemdms/{apple_mdm_id}/devices/{device_id}/erase \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{}'\n```
.Description
Erases a DEP-enrolled device.\n\n#### Sample Request\n```\n  curl -X POST https://console.jumpcloud.com/api/v2/applemdms/{apple_mdm_id}/devices/{device_id}/erase \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{}'\n```
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity
.Inputs
JumpCloud.SDK.V2.Models.IPaths1FfbqfwApplemdmsAppleMdmIdDevicesDeviceIdErasePostRequestbodyContentApplicationJsonSchema
.Outputs
System.String
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IPaths1FfbqfwApplemdmsAppleMdmIdDevicesDeviceIdErasePostRequestbodyContentApplicationJsonSchema>: 
  Pin <String>: 6-digit PIN required to erase the device

INPUTOBJECT <IJumpCloudApIsIdentity>: 
  [AccountId <String>]: 
  [ActivedirectoryId <String>]: 
  [AppleMdmId <String>]: 
  [ApplicationId <String>]: ObjectID of the Application.
  [CommandId <String>]: ObjectID of the Command.
  [DeviceId <String>]: 
  [GroupId <String>]: ObjectID of the System Group.
  [GsuiteId <String>]: ObjectID of the G Suite instance.
  [Id <String>]: ObjectID of the System Group.
  [JobId <String>]: 
  [LdapserverId <String>]: ObjectID of the LDAP Server.
  [Office365Id <String>]: ObjectID of the Office 365 instance.
  [PolicyId <String>]: ObjectID of the Policy.
  [ProviderId <String>]: 
  [RadiusserverId <String>]: ObjectID of the Radius Server.
  [SystemId <String>]: ObjectID of the System.
  [UserId <String>]: ObjectID of the User.
  [WorkdayId <String>]: 
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Clear-JcSdkAppleMdmDevice.md
#>
 Function Clear-JcSdkAppleMdmDevice
{
    [OutputType([System.String])]
    [CmdletBinding(DefaultParameterSetName='EraseExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
    [Parameter(ParameterSetName='Erase', Mandatory)]
    [Parameter(ParameterSetName='EraseExpanded', Mandatory)]
    [JumpCloud.SDK.V2.Category('Path')]
    [System.String]
    # .
    ${AppleMdmId},

    [Parameter(ParameterSetName='Erase', Mandatory)]
    [Parameter(ParameterSetName='EraseExpanded', Mandatory)]
    [JumpCloud.SDK.V2.Category('Path')]
    [System.String]
    # .
    ${DeviceId},

    [Parameter(ParameterSetName='EraseViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='EraseViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V2.Category('Path')]
    [JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='Erase', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='EraseViaIdentity', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V2.Category('Body')]
    [JumpCloud.SDK.V2.Models.IPaths1FfbqfwApplemdmsAppleMdmIdDevicesDeviceIdErasePostRequestbodyContentApplicationJsonSchema]
    # .
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='EraseExpanded', Mandatory)]
    [Parameter(ParameterSetName='EraseViaIdentityExpanded', Mandatory)]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # 6-digit PIN required to erase the device
    ${Pin},

    [Parameter()]
    [JumpCloud.SDK.V2.Category('Runtime')]
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
        $Results = JumpCloud.SDK.V2.internal\Clear-JcSdkInternalAppleMdmDevice @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}

