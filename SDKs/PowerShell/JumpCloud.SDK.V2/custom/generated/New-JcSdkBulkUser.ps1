<#
.Synopsis
The endpoint allows you to create a bulk job to asynchronously create users.
See [Create a System User](https://docs.jumpcloud.com/api/1.0/index.html#operation/systemusers_post)
for the full list of attributes.

#### Default User State
The `state` of each user in the request can be explicitly passed in or
omitted.
If `state` is omitted, then the user will get created
using the value returned from the
[Get an Organization](https://docs.jumpcloud.com/api/1.0/index.html#operation/organizations_get)
endpoint.
The default user state for bulk created users depends on the
`creation-source` header.
For `creation-source:jumpcloud:bulk` the
default state is stored in `settings.newSystemUserStateDefaults.csvImport`.
For other `creation-source` header values, the default state is stored in
`settings.newSystemUserStateDefaults.applicationImport`

These default state values can be changed in the admin portal settings
or by using the
[Update an Organization](https://docs.jumpcloud.com/api/1.0/index.html#operation/organization_put)
endpoint.

#### Sample Request

```
curl -X POST https://console.jumpcloud.com/api/v2/bulk/users \\
-H 'Accept: application/json' \\
-H 'Content-Type: application/json' \\
-H 'x-api-key: {API_KEY}' \\
-d '[
  {
    \"email\":\"{email}\",
    \"firstname\":\"{firstname}\",
    \"lastname\":\"{firstname}\",
    \"username\":\"{username}\",
    \"attributes\":[
      {
        \"name\":\"EmployeeID\",
        \"value\":\"0000\"
      },
      {
        \"name\":\"Custom\",
        \"value\":\"attribute\"
      }
    ]
  }
]'
```
.Description
The endpoint allows you to create a bulk job to asynchronously create users.
See [Create a System User](https://docs.jumpcloud.com/api/1.0/index.html#operation/systemusers_post)
for the full list of attributes.

#### Default User State
The `state` of each user in the request can be explicitly passed in or
omitted.
If `state` is omitted, then the user will get created
using the value returned from the
[Get an Organization](https://docs.jumpcloud.com/api/1.0/index.html#operation/organizations_get)
endpoint.
The default user state for bulk created users depends on the
`creation-source` header.
For `creation-source:jumpcloud:bulk` the
default state is stored in `settings.newSystemUserStateDefaults.csvImport`.
For other `creation-source` header values, the default state is stored in
`settings.newSystemUserStateDefaults.applicationImport`

These default state values can be changed in the admin portal settings
or by using the
[Update an Organization](https://docs.jumpcloud.com/api/1.0/index.html#operation/organization_put)
endpoint.

#### Sample Request

```
curl -X POST https://console.jumpcloud.com/api/v2/bulk/users \\
-H 'Accept: application/json' \\
-H 'Content-Type: application/json' \\
-H 'x-api-key: {API_KEY}' \\
-d '[
  {
    \"email\":\"{email}\",
    \"firstname\":\"{firstname}\",
    \"lastname\":\"{firstname}\",
    \"username\":\"{username}\",
    \"attributes\":[
      {
        \"name\":\"EmployeeID\",
        \"value\":\"0000\"
      },
      {
        \"name\":\"Custom\",
        \"value\":\"attribute\"
      }
    ]
  }
]'
```
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
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/New-JcSdkBulkUser.md
#>
 Function New-JcSdkBulkUser
{
    [OutputType([System.String])]
    [CmdletBinding(DefaultParameterSetName='Create', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
    [Parameter()]
    [ArgumentCompleter([JumpCloud.SDK.V2.Support.CreationSource2])]
    [JumpCloud.SDK.V2.Category('Header')]
    [JumpCloud.SDK.V2.Support.CreationSource2]
    # Defines the creation-source header for gapps, o365 and workdays requests.
    # If the header isn't sent, the default value is `jumpcloud:bulk`, if you send the header with a malformed value you receive a 400 error.
    ${CreationSource}, 

    [Parameter(Mandatory, ValueFromPipeline)]
    [AllowEmptyCollection()]
    [JumpCloud.SDK.V2.Category('Body')]
    [JumpCloud.SDK.V2.Models.IBulkUserCreate[]]
    # Array of bulk-user-create
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
        $Results = JumpCloud.SDK.V2.internal\New-JcSdkInternalBulkUser @PSBoundParameters
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


