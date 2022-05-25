<#
.Synopsis
Lists available G Suite users for import, translated to the Jumpcloud user schema.
.Description
Lists available G Suite users for import, translated to the Jumpcloud user schema.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Outputs
JumpCloud.SDK.V2.Models.IPathsKa8FhwGsuitesGsuiteIdImportJumpcloudusersGetResponses200ContentApplicationJsonSchema
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Get-JcSdkGsuiteUsersToImportFormated.md
#>
 Function Get-JcSdkGsuiteUsersToImportFormated
{
    [OutputType([JumpCloud.SDK.V2.Models.IPathsKa8FhwGsuitesGsuiteIdImportJumpcloudusersGetResponses200ContentApplicationJsonSchema])]
    [CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
    Param(
    [Parameter(Mandatory)]
    [JumpCloud.SDK.V2.Category('Path')]
    [System.String]
    # .
    ${GsuiteId},

    [Parameter()]
    [JumpCloud.SDK.V2.Category('Query')]
    [System.Int32]
    # Google Directory API maximum number of results per page.
    # See https://developers.google.com/admin-sdk/directory/reference/rest/v1/users/list.
    ${MaxResults},

    [Parameter()]
    [JumpCloud.SDK.V2.Category('Query')]
    [System.String]
    # Google Directory API sort field parameter.
    # See https://developers.google.com/admin-sdk/directory/reference/rest/v1/users/list.
    ${OrderBy},

    [Parameter()]
    [JumpCloud.SDK.V2.Category('Query')]
    [System.String]
    # Google Directory API token used to access the next page of results.
    # See https://developers.google.com/admin-sdk/directory/reference/rest/v1/users/list.
    ${PageToken},

    [Parameter()]
    [JumpCloud.SDK.V2.Category('Query')]
    [System.String]
    # Google Directory API search parameter.
    # See https://developers.google.com/admin-sdk/directory/v1/guides/search-users.
    ${Query},

    [Parameter()]
    [JumpCloud.SDK.V2.Category('Query')]
    [System.String]
    # Google Directory API sort direction parameter.
    # See https://developers.google.com/admin-sdk/directory/reference/rest/v1/users/list.
    ${SortOrder},

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
                $global:JCHttpRequestContent = If (-not [System.String]::IsNullOrEmpty($req.Content)) { $req.Content.ReadAsStringAsync() }
                $global:JCHttpResponse = $ResponseTask
                # $global:JCHttpResponseContent = If (-not [System.String]::IsNullOrEmpty($ResponseTask.Result.Content)) { $ResponseTask.Result.Content.ReadAsStringAsync() }
                Return $ResponseTask
            }
        )
    }
    Process
    {
        $Result = (JumpCloud.SDK.V2.internal\Get-JcSdkInternalGsuiteUsersToImportFormated @PSBoundParameters).ToJsonString() | ConvertFrom-Json;
        Write-Debug ('HttpRequest: ' + $JCHttpRequest);
        Write-Debug ('HttpRequestContent: ' + $JCHttpRequestContent.Result);
        Write-Debug ('HttpResponse: ' + $JCHttpResponse.Result);
        # Write-Debug ('HttpResponseContent: ' + $JCHttpResponseContent.Result);
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
        # Clean up global variables
        $GlobalVars = @('JCHttpRequest', 'JCHttpRequestContent', 'JCHttpResponse','JCHttpResponseContent')
        $GlobalVars | ForEach-Object {
            If ((Get-Variable -Scope:('Global')).Where( { $_.Name -eq $_ })) { Remove-Variable -Name:($_) -Scope:('Global') }
        }
        Return $Results
    }
}


