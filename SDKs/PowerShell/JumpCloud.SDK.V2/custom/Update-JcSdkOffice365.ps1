<#
.Synopsis
This endpoint allows updating some attributes of an Office 365 instance.\n\n#####\n\nSample Request\n\n```\ncurl -X PATCH https://console.jumpcloud.com/api/v2/office365s/{O365_ID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n    \"userLockoutAction\": \"maintain\",\n    \"userPasswordExpirationAction\": \"suspend\"\n  }'\n\n```
.Description
This endpoint allows updating some attributes of an Office 365 instance.\n\n#####\n\nSample Request\n\n```\ncurl -X PATCH https://console.jumpcloud.com/api/v2/office365s/{O365_ID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n    \"userLockoutAction\": \"maintain\",\n    \"userPasswordExpirationAction\": \"suspend\"\n  }'\n\n```
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity
.Inputs
JumpCloud.SDK.V2.Models.IOffice365PatchInput
.Outputs
JumpCloud.SDK.V2.Models.IOffice365Output
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IOffice365PatchInput>: 
  [UserLockoutAction <String>]: 
  [UserPasswordExpirationAction <String>]: 

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
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/jumpcloud.sdk.v2/update-jcsdkoffice365
#>
 Function Update-JcSdkOffice365
{
    [OutputType([JumpCloud.SDK.V2.Models.IOffice365Output])]
    [CmdletBinding(DefaultParameterSetName='PatchExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
    [Parameter(ParameterSetName='Patch', Mandatory)]
    [Parameter(ParameterSetName='PatchExpanded', Mandatory)]
    [JumpCloud.SDK.V2.Category('Path')]
    [System.String]
    # ObjectID of the Office 365 instance.
    ${Office365Id},

    [Parameter(ParameterSetName='PatchViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='PatchViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V2.Category('Path')]
    [JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='Patch', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='PatchViaIdentity', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V2.Category('Body')]
    [JumpCloud.SDK.V2.Models.IOffice365PatchInput]
    # Office 365 Patch Input
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='PatchExpanded')]
    [Parameter(ParameterSetName='PatchViaIdentityExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # .
    ${UserLockoutAction},

    [Parameter(ParameterSetName='PatchExpanded')]
    [Parameter(ParameterSetName='PatchViaIdentityExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # .
    ${UserPasswordExpirationAction}
    )
    Begin
    {
        $Results = @()
    }
    Process
    {
        $Results = JumpCloud.SDK.V2.internal\Update-JcSdkInternalOffice365 @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}

