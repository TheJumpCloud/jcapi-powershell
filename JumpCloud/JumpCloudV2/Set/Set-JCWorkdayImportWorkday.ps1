<#
.Synopsis
This endpoint allows you to update the name and Custom Report URL for a Workday Instance.\n\nCurrently, the name can not be changed from the default of `Workday Import`.\n\n##### Sample Request\n```\ncurl -X PUT https://console.jumpcloud.com/api/v2/workdays/{WorkdayID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n\t\"reportUrl\":\"{Report_URL}\",\n\t\"name\":\"{Name}\"\n}\t'\n```
.Description
This endpoint allows you to update the name and Custom Report URL for a Workday Instance.\n\nCurrently, the name can not be changed from the default of `Workday Import`.\n\n##### Sample Request\n```\ncurl -X PUT https://console.jumpcloud.com/api/v2/workdays/{WorkdayID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n\t\"reportUrl\":\"{Report_URL}\",\n\t\"name\":\"{Name}\"\n}\t'\n```
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity
.Inputs
JumpCloud.SDK.V2.Models.IWorkdayFields
.Outputs
JumpCloud.SDK.V2.Models.IWorkdayOutput
.Notes
COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IWorkdayFields>: Workday Fields
  [Name <String>]: 
  [ReportUrl <String>]: 

INPUTOBJECT <IJumpCloudApIsIdentity>: Identity Parameter
  [AccountId <String>]: 
  [ActivedirectoryId <String>]: 
  [ApplicationId <String>]: 
  [CommandId <String>]: ObjectID of the Command.
  [GroupId <String>]: ObjectID of the User Group.
  [GsuiteId <String>]: ObjectID of the G Suite instance.
  [Id <String>]: ObjectID of the User Group.
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
https://github.com/TheJumpCloud/support/wiki/Set-JCWorkdayImportWorkday
#>
Function Set-JCWorkdayImportWorkday
{
    #Requires -Modules JumpCloud.SDK.V2
    [OutputType([JumpCloud.SDK.V2.Models.IWorkdayOutput])]
    [CmdletBinding(DefaultParameterSetName='PutExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
    [Parameter(ParameterSetName='Put', Mandatory)]
    [Parameter(ParameterSetName='PutExpanded', Mandatory)]
    [JumpCloud.SDK.V2.Category('Path')]
    [System.String]
    # .
    ${Id},

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
    [JumpCloud.SDK.V2.Models.IWorkdayFields]
    # Workday Fields
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='PutExpanded')]
    [Parameter(ParameterSetName='PutViaIdentityExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # .
    ${Name},

    [Parameter(ParameterSetName='PutExpanded')]
    [Parameter(ParameterSetName='PutViaIdentityExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # .
    ${ReportUrl}
    )
    Begin
    {
        $Results = @()
    }
    Process
    {
        $Results = Set-JcSdkWorkdayImportWorkday @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}
