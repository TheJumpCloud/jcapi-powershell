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
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Get-JcSdkGsuiteUsersToImportFormatted.md
#>
 Function Get-JcSdkGsuiteUsersToImportFormatted
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
    [System.String]
    # Google Directory API sort field parameter.
    # See https://developers.google.com/admin-sdk/directory/reference/rest/v1/users/list.
    ${OrderBy}, 

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
    ${ProxyUseDefaultCredentials}, 

    [Parameter(DontShow)]
    [System.Boolean]
    # Set to $true to return all results. This will overwrite any skip and limit parameter.
    $Paginate = $true
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
        If ($Paginate -and $PSCmdlet.ParameterSetName -in ('List')) {
            $PSBoundParameters.Remove('Paginate') | Out-Null
            If ([System.String]::IsNullOrEmpty($PSBoundParameters.maxResults)) {
                $PSBoundParameters.Add('maxResults', 100)
            }
            Do {
                Write-Debug ("Limit: $($PSBoundParameters.maxResults); ");
                Write-Debug ("Skip: $($PSBoundParameters.pageToken); ");
                $maxRetries = 4
                $resultCounter = 0
                do {
                    $resultCounter++
                    $Result = (JumpCloud.SDK.V2.internal\Get-JcSdkInternalGsuiteUsersToImportFormatted @PSBoundParameters).ToJsonString() | ConvertFrom-Json;
                    If ($JCHttpResponse.Result.StatusCode -eq 503) {
                        Write-Debug ("StatusCode: " + "$($JCHttpResponse.Result.StatusCode)")
                    } else {
                        break
                    }
                    if ($resultCounter -eq $maxRetries) {
                        break
                    } else {
                        Write-Warning ("503: Service Unavailable - retrying in " + ($resultCounter * 5) + " seconds")
                        Start-Sleep -Seconds ($resultCounter * 5)
                    }
                } while ($resultCounter -lt $maxRetries)
                Write-Debug ('HttpRequest: ' + $JCHttpRequest);
                Write-Debug ('HttpRequestContent: ' + $JCHttpRequestContent.Result);
                Write-Debug ('HttpResponse: ' + $JCHttpResponse.Result);
                # Write-Debug ('HttpResponseContent: ' + $JCHttpResponseContent.Result);
                $Result = If ('Results' -in $Result.PSObject.Properties.Name) {
                    $Result.results
                } Else {
                    $Result
                }
                If (-not [System.String]::IsNullOrEmpty($Result))
                {
                    $ResultCount = ($Result.users | Measure-Object).Count;
                    $Results += $Result.users;
                    $PSBoundParameters.pageToken = $result.nextPageToken
                }
        }
            While ($ResultCount -eq $PSBoundParameters.maxResults -and -not [System.String]::IsNullOrEmpty($Result))
        } Else {
            $PSBoundParameters.Remove('Paginate') | Out-Null
            $maxRetries = 4
            $resultCounter = 0
            do {
                $resultCounter++
                $Result = (JumpCloud.SDK.V2.internal\Get-JcSdkInternalGsuiteUsersToImportFormatted @PSBoundParameters).ToJsonString() | ConvertFrom-Json;
                If ($JCHttpResponse.Result.StatusCode -eq 503) {
                    Write-Debug ("StatusCode: " + "$($JCHttpResponse.Result.StatusCode)")
                } else {
                    break
                }
                if ($resultCounter -eq $maxRetries) {
                    break
                } else {
                    Write-Warning ("503: Service Unavailable - retrying in " + ($resultCounter * 5) + " seconds")
                    Start-Sleep -Seconds ($resultCounter * 5)
                }
            } while ($resultCounter -lt $maxRetries)
            Write-Debug ('HttpRequest: ' + $JCHttpRequest);
            Write-Debug ('HttpRequestContent: ' + $JCHttpRequestContent.Result);
            Write-Debug ('HttpResponse: ' + $JCHttpResponse.Result);
            # Write-Debug ('HttpResponseContent: ' + $JCHttpResponseContent.Result);
            $Result = If ('Results' -in $Result.PSObject.Properties.Name) {
                $Result.results
            } Else {
                $Result
            }
            If (-not [System.String]::IsNullOrEmpty($Result)) {
                $Results += $Result.users;
            }
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


