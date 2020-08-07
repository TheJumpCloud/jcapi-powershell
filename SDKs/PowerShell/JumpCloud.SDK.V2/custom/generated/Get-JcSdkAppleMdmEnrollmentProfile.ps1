<#
.Synopsis
Get an enrollment profile\n\nCurrently only requesting the mobileconfig is supported.\n\n#### Sample Request\n\n```\ncurl https://console.jumpcloud.com/api/v2/applemdms/{APPLE_MDM_ID}/enrollmentprofiles/{ID} \\\n  -H 'accept: application/x-apple-aspen-config' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```
.Description
Get an enrollment profile\n\nCurrently only requesting the mobileconfig is supported.\n\n#### Sample Request\n\n```\ncurl https://console.jumpcloud.com/api/v2/applemdms/{APPLE_MDM_ID}/enrollmentprofiles/{ID} \\\n  -H 'accept: application/x-apple-aspen-config' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```
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
.Outputs
System.String
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
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Get-JcSdkAppleMdmEnrollmentProfile.md
#>
 Function Get-JcSdkAppleMdmEnrollmentProfile
{
    [OutputType([System.String], [JumpCloud.SDK.V2.Models.IAppleMdm])]
    [CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
    Param(
    [Parameter(ParameterSetName='Get', Mandatory)]
    [Parameter(ParameterSetName='List', Mandatory)]
    [JumpCloud.SDK.V2.Category('Path')]
    [System.String]
    # .
    ${AppleMdmId},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [JumpCloud.SDK.V2.Category('Path')]
    [System.String]
    # .
    ${Id},

    [Parameter(ParameterSetName='GetViaIdentity', Mandatory, ValueFromPipeline)]
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
        $Result = JumpCloud.SDK.V2.internal\Get-JcSdkInternalAppleMdmEnrollmentProfile @PSBoundParameters
        $Result = If ('Results' -in $Result.PSObject.Properties.Name)
        {
            $Result.results
        }
        Else
        {
            $Result
        }
        If (-not [System.String]::IsNullOrEmpty($Result))
        {
            $Results += $Result;
        }
    }
    End
    {
        Return $Results
    }
}
