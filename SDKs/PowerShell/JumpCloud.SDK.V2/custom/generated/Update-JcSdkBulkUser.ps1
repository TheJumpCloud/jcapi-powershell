<#
.Synopsis
The endpoint allows you to create a bulk job to asynchronously update users.
See [Update a System User](https://docs.jumpcloud.com/api/1.0/index.html#operation/systemusers_put) for full list of attributes.

#### Sample Request 
```
curl -X PATCH https://console.jumpcloud.com/api/v2/bulk/users \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '[
\t{
\t  \"id\":\"5be9fb4ddb01290001e85109\",
\t\t\"firstname\":\"{UPDATED_FIRSTNAME}\",
\t\t\"department\":\"{UPDATED_DEPARTMENT}\",
\t\t\"attributes\":[
\t\t\t{\"name\":\"Custom\",\"value\":\"{ATTRIBUTE_VALUE}\"}
\t\t]
\t},
\t{
\t  \"id\":\"5be9fb4ddb01290001e85109\",
\t\t\"firstname\":\"{UPDATED_FIRSTNAME}\",
\t\t\"costCenter\":\"{UPDATED_COST_CENTER}\",
\t\t\"phoneNumbers\":[
\t\t\t{\"type\":\"home\",\"number\":\"{HOME_PHONE_NUMBER}\"},
\t\t\t{\"type\":\"work\",\"number\":\"{WORK_PHONE_NUMBER}\"}
\t\t]
\t}
]
```
.Description
The endpoint allows you to create a bulk job to asynchronously update users.
See [Update a System User](https://docs.jumpcloud.com/api/1.0/index.html#operation/systemusers_put) for full list of attributes.

#### Sample Request 
```
curl -X PATCH https://console.jumpcloud.com/api/v2/bulk/users \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '[
\t{
\t  \"id\":\"5be9fb4ddb01290001e85109\",
\t\t\"firstname\":\"{UPDATED_FIRSTNAME}\",
\t\t\"department\":\"{UPDATED_DEPARTMENT}\",
\t\t\"attributes\":[
\t\t\t{\"name\":\"Custom\",\"value\":\"{ATTRIBUTE_VALUE}\"}
\t\t]
\t},
\t{
\t  \"id\":\"5be9fb4ddb01290001e85109\",
\t\t\"firstname\":\"{UPDATED_FIRSTNAME}\",
\t\t\"costCenter\":\"{UPDATED_COST_CENTER}\",
\t\t\"phoneNumbers\":[
\t\t\t{\"type\":\"home\",\"number\":\"{HOME_PHONE_NUMBER}\"},
\t\t\t{\"type\":\"work\",\"number\":\"{WORK_PHONE_NUMBER}\"}
\t\t]
\t}
]
```
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
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Update-JcSdkBulkUser.md
#>
 Function Update-JcSdkBulkUser
{
    [OutputType([System.String])]
    [CmdletBinding(DefaultParameterSetName='Update', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
    [Parameter(Mandatory, ValueFromPipeline)]
    [AllowEmptyCollection()]
    [JumpCloud.SDK.V2.Category('Body')]
    [JumpCloud.SDK.V2.Models.IBulkUserUpdate[]]
    # Array of bulk-user-update
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body}, 

    [Parameter(DontShow)]
    [JumpCloud.SDK.V2.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break}, 

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [JumpCloud.SDK.V2.Category('Runtime')]
    [JumpCloud.SDK.V2.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend}, 

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [JumpCloud.SDK.V2.Category('Runtime')]
    [JumpCloud.SDK.V2.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend}, 

    [Parameter(DontShow)]
    [JumpCloud.SDK.V2.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy}, 

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [JumpCloud.SDK.V2.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential}, 

    [Parameter(DontShow)]
    [JumpCloud.SDK.V2.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
    )
    Begin
    {
        $Results = @()
        $PSBoundParameters.Add('HttpPipelineAppend', {
                param($req, $callback, $next)
                # call the next step in the Pipeline
                $ResponseTask = $next.SendAsync($req, $callback)
                $global:JCHttpRequest = $req
                # $global:JCHttpRequestContent = If (-not [System.String]::IsNullOrEmpty($req.Content)) { $req.Content.ReadAsStringAsync() }
                $global:JCHttpResponse = $ResponseTask
                # $global:JCHttpResponseContent = If (-not [System.String]::IsNullOrEmpty($ResponseTask.Result.Content)) { $ResponseTask.Result.Content.ReadAsStringAsync() }
                Return $ResponseTask
            }
        )
    }
    Process
    {
        $Results = JumpCloud.SDK.V2.internal\Update-JcSdkInternalBulkUser @PSBoundParameters
    }
    End
    {
        Write-Debug ('HttpRequest: ' + $JCHttpRequest);
        # Write-Debug ('HttpRequestContent: ' + $JCHttpRequestContent.Result);
        Write-Debug ('HttpResponse: ' + $JCHttpResponse.Result);
        # Write-Debug ('HttpResponseContent: ' + $JCHttpResponseContent.Result);
        # Clean up global variables
        $GlobalVars = @('JCHttpRequest', 'JCHttpRequestContent', 'JCHttpResponse', 'JCHttpResponseContent')
        $GlobalVars | ForEach-Object {
            If ((Get-Variable -Scope:('Global')).Where( { $_.Name -eq $_ })) {
                Remove-Variable -Name:($_) -Scope:('Global')
            }
        }
        Return $Results
    }
}


