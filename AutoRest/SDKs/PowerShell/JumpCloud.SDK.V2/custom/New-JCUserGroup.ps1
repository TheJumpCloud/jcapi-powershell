<#
.Synopsis
This endpoint allows you to create a new User Group.\n\n#### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/usergroups \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n \"name\": \"{Group_Name}\"\n}'\n\n```
.Description
This endpoint allows you to create a new User Group.\n\n#### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/usergroups \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n \"name\": \"{Group_Name}\"\n}'\n\n```
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
JumpCloud.SDK.V2.Models.IUserGroupPost
.Outputs
JumpCloud.SDK.V2.Models.IUserGroup
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

ATTRIBUTEPOSIXGROUPS <IUserGroupAttributesPosixGroupsItem[]>: 
  [Id <Int32?>]: 
  [Name <String>]: 

BODY <IUserGroupPost>: 
  Name <String>: Display name of a User Group.
  [AttributePosixGroups <IUserGroupAttributesPosixGroupsItem[]>]: 
    [Id <Int32?>]: 
    [Name <String>]: 
  [AttributeSambaEnabled <Boolean?>]: 
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/AutoRest/SDKs/PowerShell/jumpcloud.sdk.v2/new-jcusergroup
#>
 Function New-JCUserGroup
{
    [OutputType([JumpCloud.SDK.V2.Models.IUserGroup])]
    [CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
    [Parameter(ParameterSetName='Create', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V2.Category('Body')]
    [JumpCloud.SDK.V2.Models.IUserGroupPost]
    # UserGroupPost
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # Display name of a User Group.
    ${Name},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [JumpCloud.SDK.V2.Models.IUserGroupAttributesPosixGroupsItem[]]
    # .
    # To construct, see NOTES section for ATTRIBUTEPOSIXGROUPS properties and create a hash table.
    ${AttributePosixGroups},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # .
    ${AttributeSambaEnabled}
    )
    Begin
    {
        $Results = @()
    }
    Process
    {
        $Results = JumpCloud.SDK.V2.internal\New-JcSdkUserGroup @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}

