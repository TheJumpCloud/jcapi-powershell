<#
.Synopsis
This endpoint allows you to update the samba domain information for an LDAP server.\n\n##### Sample Request\n```\ncurl -X PUT https://console.jumpcloud.com/api/v2/ldapservers/{LDAP_ID}/sambadomains/{SAMBA_ID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n\"sid\":\"{SID_ID}\",\n\"name\":\"{WORKGROUP_NAME}\"\n}'\n\n```
.Description
This endpoint allows you to update the samba domain information for an LDAP server.\n\n##### Sample Request\n```\ncurl -X PUT https://console.jumpcloud.com/api/v2/ldapservers/{LDAP_ID}/sambadomains/{SAMBA_ID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n\"sid\":\"{SID_ID}\",\n\"name\":\"{WORKGROUP_NAME}\"\n}'\n\n```
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity
.Inputs
JumpCloud.SDK.V2.Models.ISambaDomainInput
.Outputs
JumpCloud.SDK.V2.Models.ISambaDomainOutput
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <ISambaDomainInput>: 
  Name <String>: Name of this domain's WorkGroup
  Sid <String>: Security identifier of this domain

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
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/AutoRest/SDKs/PowerShell/jumpcloud.sdk.v2/set-jcsambadomainldapserversambadomain
#>
 Function Set-JCSambaDomainLdapServerSambaDomain
{
    [OutputType([JumpCloud.SDK.V2.Models.ISambaDomainOutput])]
    [CmdletBinding(DefaultParameterSetName='PutExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
    [Parameter(ParameterSetName='Put', Mandatory)]
    [Parameter(ParameterSetName='PutExpanded', Mandatory)]
    [JumpCloud.SDK.V2.Category('Path')]
    [System.String]
    # Unique identifier of the samba domain.
    ${Id},

    [Parameter(ParameterSetName='Put', Mandatory)]
    [Parameter(ParameterSetName='PutExpanded', Mandatory)]
    [JumpCloud.SDK.V2.Category('Path')]
    [System.String]
    # Unique identifier of the LDAP server.
    ${LdapserverId},

    [Parameter(ParameterSetName='PutViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='PutViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V2.Category('Path')]
    [JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='Put', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='PutViaIdentity', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V2.Category('Body')]
    [JumpCloud.SDK.V2.Models.ISambaDomainInput]
    # Samba Domain Input
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='PutExpanded', Mandatory)]
    [Parameter(ParameterSetName='PutViaIdentityExpanded', Mandatory)]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # Name of this domain's WorkGroup
    ${Name},

    [Parameter(ParameterSetName='PutExpanded', Mandatory)]
    [Parameter(ParameterSetName='PutViaIdentityExpanded', Mandatory)]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # Security identifier of this domain
    ${Sid}
    )
    Begin
    {
        $Results = @()
    }
    Process
    {
        $Results = JumpCloud.SDK.V2.internal\Set-JcSdkSambaDomainLdapServerSambaDomain @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}

