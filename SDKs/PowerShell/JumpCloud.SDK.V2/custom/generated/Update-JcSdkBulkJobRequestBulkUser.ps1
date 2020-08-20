<#
.Synopsis
The endpoint allows you to create a bulk job to asynchronously update users.
See [Update a System User](https://docs.jumpcloud.com/1.0/systemusers/update-a-system-user) for full list of attributes.\n\n#### Sample Request \n```\ncurl -X PATCH https://console.jumpcloud.com/api/v2/bulk/users \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '[\n\t{\n\t  \"id\":\"5be9fb4ddb01290001e85109\",\n\t\t\"firstname\":\"{UPDATED_FIRSTNAME}\",\n\t\t\"department\":\"{UPDATED_DEPARTMENT}\",\n\t\t\"attributes\":[\n\t\t\t{\"name\":\"Custom\",\"value\":\"{ATTRIBUTE_VALUE}\"}\n\t\t]\n\t},\n\t{\n\t  \"id\":\"5be9fb4ddb01290001e85109\",\n\t\t\"firstname\":\"{UPDATED_FIRSTNAME}\",\n\t\t\"costCenter\":\"{UPDATED_COST_CENTER}\",\n\t\t\"phoneNumbers\":[\n\t\t\t{\"type\":\"home\",\"number\":\"{HOME_PHONE_NUMBER}\"},\n\t\t\t{\"type\":\"work\",\"number\":\"{WORK_PHONE_NUMBER}\"}\n\t\t]\n\t}\n]\n```
.Description
The endpoint allows you to create a bulk job to asynchronously update users.
See [Update a System User](https://docs.jumpcloud.com/1.0/systemusers/update-a-system-user) for full list of attributes.\n\n#### Sample Request \n```\ncurl -X PATCH https://console.jumpcloud.com/api/v2/bulk/users \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '[\n\t{\n\t  \"id\":\"5be9fb4ddb01290001e85109\",\n\t\t\"firstname\":\"{UPDATED_FIRSTNAME}\",\n\t\t\"department\":\"{UPDATED_DEPARTMENT}\",\n\t\t\"attributes\":[\n\t\t\t{\"name\":\"Custom\",\"value\":\"{ATTRIBUTE_VALUE}\"}\n\t\t]\n\t},\n\t{\n\t  \"id\":\"5be9fb4ddb01290001e85109\",\n\t\t\"firstname\":\"{UPDATED_FIRSTNAME}\",\n\t\t\"costCenter\":\"{UPDATED_COST_CENTER}\",\n\t\t\"phoneNumbers\":[\n\t\t\t{\"type\":\"home\",\"number\":\"{HOME_PHONE_NUMBER}\"},\n\t\t\t{\"type\":\"work\",\"number\":\"{WORK_PHONE_NUMBER}\"}\n\t\t]\n\t}\n]\n```
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
JumpCloud.SDK.V2.Models.IBulkUserUpdate[]
.Outputs
System.String
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IBulkUserUpdate[]>:
  [Attributes <IBulkUserUpdateAttributesItem[]>]: Map of additional attributes.
  [Email <String>]:
  [Firstname <String>]:
  [Id <String>]: Object ID of the systemuser being updated
  [Lastname <String>]:
  [Username <String>]:
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Update-JcSdkBulkJobRequestBulkUser.md
#>
 Function Update-JcSdkBulkJobRequestBulkUser
{
    [OutputType([System.String])]
    [CmdletBinding(DefaultParameterSetName='Patch', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
    [Parameter(Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V2.Category('Body')]
    [JumpCloud.SDK.V2.Models.IBulkUserUpdate[]]
    # .
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body}
    )
    Begin
    {
        $Results = @()
        $PSBoundParameters.Add('HttpPipelineAppend', {
                param($req, $callback, $next)
                # call the next step in the Pipeline
                $ResponseTask = $next.SendAsync($req, $callback)
                $global:JCHttpRequest = $req
                $global:JCHttpRequestContent = If (-not [System.String]::IsNullOrEmpty($req.Content)) { $req.Content.ReadAsStringAsync() }
                $global:JCHttpResponse = $ResponseTask
                Return $ResponseTask
            }
        )
    }
    Process
    {
        $Results = JumpCloud.SDK.V2.internal\Update-JcSdkInternalBulkJobRequestBulkUser @PSBoundParameters
    }
    End
    {
        Write-Debug ('HttpRequest: ' + $JCHttpRequest);
        Write-Debug ('HttpRequestContent: ' + $JCHttpRequestContent.Result);
        Write-Debug ('HttpResponse: ' + $JCHttpResponse.Result);
        # Clean up global variables
        $GlobalVars = @('JCHttpRequest', 'JCHttpRequestContent', 'JCHttpResponse')
        $GlobalVars | ForEach-Object {
            If ((Get-Variable -Scope:('Global')).Where( { $_.Name -eq $_ })) { Remove-Variable -Name:($_) -Scope:('Global') }
        }
        Return $Results
    }
}

