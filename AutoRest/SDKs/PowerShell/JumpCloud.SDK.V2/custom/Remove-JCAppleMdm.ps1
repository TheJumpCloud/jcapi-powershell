<#
.Synopsis
Removes an Apple MDM configuration.\n\nWarning: This is a destructive operation and will remove your Apple Push Certificates.
We will no longer be able to manage your devices and the only recovery option is to re-register all devices into MDM.\n\n#### Sample Request\n```\ncurl -X DELETE https://console.jumpcloud.com/api/v2/applemdms/{id} \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```
.Description
Removes an Apple MDM configuration.\n\nWarning: This is a destructive operation and will remove your Apple Push Certificates.
We will no longer be able to manage your devices and the only recovery option is to re-register all devices into MDM.\n\n#### Sample Request\n```\ncurl -X DELETE https://console.jumpcloud.com/api/v2/applemdms/{id} \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity
.Outputs
JumpCloud.SDK.V2.Models.IAppleMdm
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

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
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/AutoRest/SDKs/PowerShell/jumpcloud.sdk.v2/remove-jcapplemdm
#>
 Function Remove-JCAppleMdm
{
    [OutputType([JumpCloud.SDK.V2.Models.IAppleMdm])]
    [CmdletBinding(DefaultParameterSetName='Delete', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
    [Parameter(ParameterSetName='Delete', Mandatory)]
    [JumpCloud.SDK.V2.Category('Path')]
    [System.String]
    # .
    ${Id},

    [Parameter(ParameterSetName='DeleteViaIdentity', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V2.Category('Path')]
    [JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject}
    )
    Begin
    {
        $Results = @()
    }
    Process
    {
        $Results = JumpCloud.SDK.V2.internal\Remove-JcSdkAppleMdm @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}

