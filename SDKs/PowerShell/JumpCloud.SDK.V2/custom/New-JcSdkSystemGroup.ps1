<#
.Synopsis
This endpoint allows you to create a new System Group.\n\n#### Sample Request\n\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/systemgroups \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n \"name\": \"{Group_Name}\"\n}'\n\n```
.Description
This endpoint allows you to create a new System Group.\n\n#### Sample Request\n\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/systemgroups \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n \"name\": \"{Group_Name}\"\n}'\n\n```
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
JumpCloud.SDK.V2.Models.ISystemGroupData
.Outputs
JumpCloud.SDK.V2.Models.ISystemGroup
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <ISystemGroupData>: 
  Name <String>: Display name of a System Group.
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/New-JcSdkSystemGroup.md
#>
 Function New-JcSdkSystemGroup
{
    [OutputType([JumpCloud.SDK.V2.Models.ISystemGroup])]
    [CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
    [Parameter(ParameterSetName='Create', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V2.Category('Body')]
    [JumpCloud.SDK.V2.Models.ISystemGroupData]
    # SystemGroupData
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # Display name of a System Group.
    ${Name}
    )
    Begin
    {
        $Results = @()
    }
    Process
    {
        $Results = JumpCloud.SDK.V2.internal\New-JcSdkInternalSystemGroup @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}

