<#
.Synopsis
The endpoint allows you to create a bulk job to asynchronously create users.
See [Create a System User](https://docs.jumpcloud.com/1.0/systemusers/create-a-system-user) for full list of attributes.\n\n#### Sample Request \n```\ncurl -X POST https://console.jumpcloud.com/api/v2/bulk/users \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '[\n\t{\n\t\t\"email\":\"{email}\",\n\t\t\"firstname\":\"{firstname}\",\n\t\t\"lastname\":\"{firstname}\",\n\t\t\"username\":\"{username}\",\n\t\t\"attributes\":[\n\t\t\t{\"name\":\"EmployeeID\",\"value\":\"0000\"},\n\t\t\t{\"name\":\"Custom\",\"value\":\"attribute\"}\n\t\t]\n\t}\n]\n```
.Description
The endpoint allows you to create a bulk job to asynchronously create users.
See [Create a System User](https://docs.jumpcloud.com/1.0/systemusers/create-a-system-user) for full list of attributes.\n\n#### Sample Request \n```\ncurl -X POST https://console.jumpcloud.com/api/v2/bulk/users \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '[\n\t{\n\t\t\"email\":\"{email}\",\n\t\t\"firstname\":\"{firstname}\",\n\t\t\"lastname\":\"{firstname}\",\n\t\t\"username\":\"{username}\",\n\t\t\"attributes\":[\n\t\t\t{\"name\":\"EmployeeID\",\"value\":\"0000\"},\n\t\t\t{\"name\":\"Custom\",\"value\":\"attribute\"}\n\t\t]\n\t}\n]\n```
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
JumpCloud.SDK.V2.Models.IBulkUserCreate[]
.Outputs
System.String
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IBulkUserCreate[]>:
  [Attributes <IBulkUserCreateAttributesItem[]>]: Map of additional attributes.
  [Email <String>]:
  [Firstname <String>]:
  [Lastname <String>]:
  [Username <String>]:
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/New-JcSdkBulkJobRequestBulkUser.md
#>
 Function New-JcSdkBulkJobRequestBulkUser
{
    [OutputType([System.String])]
    [CmdletBinding(DefaultParameterSetName='Create', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
    [Parameter(Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V2.Category('Body')]
    [JumpCloud.SDK.V2.Models.IBulkUserCreate[]]
    # .
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body}
    )
    Begin
    {
        $Results = @()
    }
    Process
    {
        $Results = JumpCloud.SDK.V2.internal\New-JcSdkInternalBulkJobRequestBulkUser @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}

