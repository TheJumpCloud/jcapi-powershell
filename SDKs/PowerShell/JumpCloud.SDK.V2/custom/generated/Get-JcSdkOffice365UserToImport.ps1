<#
.Synopsis
Lists Office 365 users available for import.
.Description
Lists Office 365 users available for import.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Outputs
JumpCloud.SDK.V2.Models.IPaths1J0ThkrOffice365SOffice365IdImportUsersGetResponses200ContentApplicationJsonSchema
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Get-JcSdkOffice365UserToImport.md
#>
 Function Get-JcSdkOffice365UserToImport
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
    [JumpCloud.SDK.V2.Category('Query')]
    [System.String]
    # Office 365 API token used to access the next page of results.
    # See https://docs.microsoft.com/en-us/graph/paging.
    ${SkipToken},

    [Parameter()]
    [JumpCloud.SDK.V2.Category('Query')]
    [System.Int32]
    # Office 365 API maximum number of results per page.
    # See https://docs.microsoft.com/en-us/graph/paging.
    ${Top},

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
        If ($Paginate -and $PSCmdlet.ParameterSetName -in ('List'))
        {
            $PSBoundParameters.Remove('Paginate') | Out-Null
            If ([System.String]::IsNullOrEmpty($PSBoundParameters.Skip))
            {
                $PSBoundParameters.Add('Skip', 0)
            }
            Do
            {
                Write-Debug ("Skip: $($PSBoundParameters.Skip); ");
                $Result = (JumpCloud.SDK.V2.internal\Get-JcSdkInternalOffice365UserToImport @PSBoundParameters).ToJsonString() | ConvertFrom-Json;
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
                    $ResultCount = ($Result | Measure-Object).Count;
                    $Results += $Result;
                    $PSBoundParameters.Skip += $ResultCount
                }
            }
            While (-not [System.String]::IsNullOrEmpty($Result))
        }
        Else
        {
            $PSBoundParameters.Remove('Paginate') | Out-Null
            $Result = (JumpCloud.SDK.V2.internal\Get-JcSdkInternalOffice365UserToImport @PSBoundParameters).ToJsonString() | ConvertFrom-Json;
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

