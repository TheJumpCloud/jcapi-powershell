<#
.Synopsis
Lists Office 365 users available for import.
.Description
Lists Office 365 users available for import.
.Example
PS C:\> Get-JcSdkOffice365UsersToImport



----      ----------
SkipToken String
Top       Int
Users     JumpCloud.SDK.V2.Models.Paths1Hu9JikOffice365SOffice365IdImportUsersGetResponses200ContentApplicationJsonSchemaPropertiesUsersItem…


.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Outputs
JumpCloud.SDK.V2.Models.IPaths1J0ThkrOffice365SOffice365IdImportUsersGetResponses200ContentApplicationJsonSchema
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Get-JcSdkOffice365UsersToImport.md
#>
 Function Get-JcSdkOffice365UsersToImport
{
    [OutputType([JumpCloud.SDK.V2.Models.IPaths1J0ThkrOffice365SOffice365IdImportUsersGetResponses200ContentApplicationJsonSchema])]
    [CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
    Param(
    [Parameter(Mandatory)]
    [JumpCloud.SDK.V2.Category('Path')]
    [System.String]
    # .
    ${Office365Id}, 

    [Parameter()]
    [JumpCloud.SDK.V2.Category('Query')]
    [System.Management.Automation.SwitchParameter]
    # Office 365 API count parameter.
    # See https://docs.microsoft.com/en-us/graph/api/user-list?view=graph-rest-1.0&tabs=http#optional-query-parameters.
    ${Count}, 

    [Parameter()]
    [JumpCloud.SDK.V2.Category('Query')]
    [System.String]
    # Office 365 API filter parameter.
    # See https://docs.microsoft.com/en-us/graph/api/user-list?view=graph-rest-1.0&tabs=http#optional-query-parameters.
    ${Filter}, 

    [Parameter()]
    [JumpCloud.SDK.V2.Category('Query')]
    [System.String]
    # Office 365 API orderby parameter.
    # See https://docs.microsoft.com/en-us/graph/api/user-list?view=graph-rest-1.0&tabs=http#optional-query-parameters.
    ${Orderby}, 

    [Parameter()]
    [JumpCloud.SDK.V2.Category('Query')]
    [System.String]
    # Office 365 API search parameter.
    # See https://docs.microsoft.com/en-us/graph/api/user-list?view=graph-rest-1.0&tabs=http#optional-query-parameters.
    ${Search}, 

    [Parameter()]
    [JumpCloud.SDK.V2.Category('Header')]
    [System.String]
    # Defines the consistency header for O365 requests.
    # See https://docs.microsoft.com/en-us/graph/api/user-list?view=graph-rest-1.0&tabs=http#request-headers
    ${ConsistencyLevel}, 

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
            If ([System.String]::IsNullOrEmpty($PSBoundParameters.top)) {
                $PSBoundParameters.Add('top', 100)
            }
            Do {
                Write-Debug ("Limit: $($PSBoundParameters.top); ");
                Write-Debug ("Skip: $($PSBoundParameters.skipToken); ");
                $maxRetries = 4
                $resultCounter = 0
                :retryLoop do {
                    $resultCounter++
                    $Result = (JumpCloud.SDK.V2.internal\Get-JcSdkInternalOffice365UsersToImport -ErrorAction SilentlyContinue -errorVariable sdkError @PSBoundParameters); if (-not [System.String]::IsNullOrEmpty($Result)) { $Result = $Result.ToJsonString() | ConvertFrom-Json };
                    If ($sdkError){
                        If ($resultCounter -eq $maxRetries){
                            throw $sdkError
                        }
                        If ($JCHttpResponse.Result.StatusCode -eq "503") {
                            Write-Warning ("503: Service Unavailable - retrying in " + ($resultCounter * 5) + " seconds.")
                        } else {
                            throw $sdkError
                        }
                    } else {
                        break retryLoop
                    }
                    Start-Sleep -Seconds ($resultCounter * 5)
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
                    $PSBoundParameters.skipToken = $result.skipToken
                }
        }
            While ($ResultCount -eq $PSBoundParameters.top -and -not [System.String]::IsNullOrEmpty($Result))
        } Else {
            $PSBoundParameters.Remove('Paginate') | Out-Null
            $maxRetries = 4
            $resultCounter = 0
            :retryLoop do {
                $resultCounter++
                $Result = (JumpCloud.SDK.V2.internal\Get-JcSdkInternalOffice365UsersToImport -ErrorAction SilentlyContinue -errorVariable sdkError @PSBoundParameters); if (-not [System.String]::IsNullOrEmpty($Result)) { $Result = $Result.ToJsonString() | ConvertFrom-Json };
                If ($sdkError){
                    If ($resultCounter -eq $maxRetries){
                        throw $sdkError
                    }
                    If ($JCHttpResponse.Result.StatusCode -eq "503") {
                        Write-Warning ("503: Service Unavailable - retrying in " + ($resultCounter * 5) + " seconds.")
                    } else {
                        throw $sdkError
                    }
                } else {
                    break retryLoop
                }
                Start-Sleep -Seconds ($resultCounter * 5)
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


