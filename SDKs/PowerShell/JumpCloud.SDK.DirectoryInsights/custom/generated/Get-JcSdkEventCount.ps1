<#
.Synopsis
Query the API for a count of matching events
#### Sample Request
```
curl -X POST 'https://api.jumpcloud.com/insights/directory/v1/events/count' -H 'Content-Type: application/json' -H 'x-api-key: REPLACE_KEY_VALUE' --data '{\"service\": [\"all\"], \"start_time\": \"2021-07-14T23:00:00Z\", \"end_time\": \"2021-07-28T14:00:00Z\", \"sort\": \"DESC\", \"fields\": [\"timestamp\", \"event_type\", \"initiated_by\", \"success\", \"client_ip\", \"provider\", \"organization\"]}'
```
.Description
Query the API for a count of matching events
#### Sample Request
```
curl -X POST 'https://api.jumpcloud.com/insights/directory/v1/events/count' -H 'Content-Type: application/json' -H 'x-api-key: REPLACE_KEY_VALUE' --data '{\"service\": [\"all\"], \"start_time\": \"2021-07-14T23:00:00Z\", \"end_time\": \"2021-07-28T14:00:00Z\", \"sort\": \"DESC\", \"fields\": [\"timestamp\", \"event_type\", \"initiated_by\", \"success\", \"client_ip\", \"provider\", \"organization\"]}'
```
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
JumpCloud.SDK.DirectoryInsights.Models.IEventQuery
.Outputs
System.Int64
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IEventQuery>:
  Service <String[]>: service name to query.
  StartTime <DateTime>: query start time, UTC in RFC3339 format
  [EndTime <DateTime?>]: optional query end time, UTC in RFC3339 format
  [Fields <String[]>]: optional list of fields to return from query
  [Limit <Int64?>]: Max number of rows to return
  [Q <String>]: optional string for specifying a full text query
  [SearchAfter <String[]>]: Specific query to search after, see x-* response headers for next values
  [SearchTermAnd <ITermConjunction>]: TermConjunction represents a conjunction (and/or)         NOTE: the validator limits what the operator can be, not the object         for future-proof-ness         and a list of sub-values
    [(Any) <Object>]: This indicates any property can be added to this object.
  [SearchTermNot <ITermConjunction>]: TermConjunction represents a conjunction (and/or)         NOTE: the validator limits what the operator can be, not the object         for future-proof-ness         and a list of sub-values
  [SearchTermOr <ITermConjunction>]: TermConjunction represents a conjunction (and/or)         NOTE: the validator limits what the operator can be, not the object         for future-proof-ness         and a list of sub-values
  [Sort <String>]: ASC or DESC order for timestamp
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.DirectoryInsights/docs/exports/Get-JcSdkEventCount.md
#>
 Function Get-JcSdkEventCount
{
    [OutputType([System.Int64])]
    [CmdletBinding(DefaultParameterSetName='GetExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
    [Parameter(ParameterSetName='Get', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.DirectoryInsights.Category('Body')]
    [JumpCloud.SDK.DirectoryInsights.Models.IEventQuery]
    # EventQuery is the users' command to search our auth logs
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body}, 

    [Parameter(ParameterSetName='GetExpanded', Mandatory)]
    [AllowEmptyCollection()]
    [JumpCloud.SDK.DirectoryInsights.Category('Body')]
    [System.String[]]
    # service name to query.
    ${Service}, 

    [Parameter(ParameterSetName='GetExpanded', Mandatory)]
    [JumpCloud.SDK.DirectoryInsights.Category('Body')]
    [System.DateTime]
    # query start time, UTC in RFC3339 format
    ${StartTime}, 

    [Parameter(ParameterSetName='GetExpanded')]
    [JumpCloud.SDK.DirectoryInsights.Category('Body')]
    [System.DateTime]
    # optional query end time, UTC in RFC3339 format
    ${EndTime}, 

    [Parameter(ParameterSetName='GetExpanded')]
    [AllowEmptyCollection()]
    [JumpCloud.SDK.DirectoryInsights.Category('Body')]
    [System.String[]]
    # optional list of fields to return from query
    ${Fields}, 

    [Parameter(ParameterSetName='GetExpanded')]
    [JumpCloud.SDK.DirectoryInsights.Category('Body')]
    [System.String]
    # optional string for specifying a full text query
    ${Q}, 

    [Parameter(ParameterSetName='GetExpanded')]
    [AllowEmptyCollection()]
    [JumpCloud.SDK.DirectoryInsights.Category('Body')]
    [System.String[]]
    # Specific query to search after, see x-* response headers for next values
    ${SearchAfter}, 

    [Parameter(ParameterSetName='GetExpanded')]
    [JumpCloud.SDK.DirectoryInsights.Category('Body')]
    [JumpCloud.SDK.DirectoryInsights.Runtime.Info(PossibleTypes=([JumpCloud.SDK.DirectoryInsights.Models.ITermConjunction]))]
    [System.Collections.Hashtable]
    # TermConjunction represents a conjunction (and/or)NOTE: the validator limits what the operator can be, not the objectfor future-proof-nessand a list of sub-values
    ${SearchTermAnd}, 

    [Parameter(ParameterSetName='GetExpanded')]
    [JumpCloud.SDK.DirectoryInsights.Category('Body')]
    [JumpCloud.SDK.DirectoryInsights.Runtime.Info(PossibleTypes=([JumpCloud.SDK.DirectoryInsights.Models.ITermConjunction]))]
    [System.Collections.Hashtable]
    # TermConjunction represents a conjunction (and/or)NOTE: the validator limits what the operator can be, not the objectfor future-proof-nessand a list of sub-values
    ${SearchTermNot}, 

    [Parameter(ParameterSetName='GetExpanded')]
    [JumpCloud.SDK.DirectoryInsights.Category('Body')]
    [JumpCloud.SDK.DirectoryInsights.Runtime.Info(PossibleTypes=([JumpCloud.SDK.DirectoryInsights.Models.ITermConjunction]))]
    [System.Collections.Hashtable]
    # TermConjunction represents a conjunction (and/or)NOTE: the validator limits what the operator can be, not the objectfor future-proof-nessand a list of sub-values
    ${SearchTermOr}, 

    [Parameter(ParameterSetName='GetExpanded')]
    [JumpCloud.SDK.DirectoryInsights.Category('Body')]
    [System.String]
    # ASC or DESC order for timestamp
    ${Sort}, 

    [Parameter(DontShow)]
    [JumpCloud.SDK.DirectoryInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break}, 

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [JumpCloud.SDK.DirectoryInsights.Category('Runtime')]
    [JumpCloud.SDK.DirectoryInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend}, 

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [JumpCloud.SDK.DirectoryInsights.Category('Runtime')]
    [JumpCloud.SDK.DirectoryInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend}, 

    [Parameter(DontShow)]
    [JumpCloud.SDK.DirectoryInsights.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy}, 

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [JumpCloud.SDK.DirectoryInsights.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential}, 

    [Parameter(DontShow)]
    [JumpCloud.SDK.DirectoryInsights.Category('Runtime')]
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
        If ($Paginate -and $PSCmdlet.ParameterSetName -in ('GetExpanded')) {
            $PSBoundParameters.Remove('Paginate') | Out-Null
            Do {
                $maxRetries = 4
                $resultCounter = 0
                :retryLoop do {
                    $resultCounter++
                    try {
                        $Result = JumpCloud.SDK.DirectoryInsights.internal\Get-JcSdkInternalEventCount @PSBoundParameters -errorAction SilentlyContinue
                        break retryLoop
                    } catch {
                        If ($JCHttpResponse.Result.StatusCode -eq 503) {
                            Write-Warning ("503: Service Unavailable - retrying in " + ($resultCounter * 5) + " seconds.")
                        } else {
                            Write-Warning ("An error occurred: $_.")
                        }
                    }
                    Start-Sleep -Seconds ($resultCounter * 5)
                } while ($resultCounter -lt $maxRetries)
                If ($JCHttpResponse.Result.Headers.Contains('X-Search_after')) {
                    If (-not [System.String]::IsNullOrEmpty($Result)) {
                        $XResultSearchAfter = ($JCHttpResponse.Result.Headers.GetValues('X-Search_after') | ConvertFrom-Json);
                        If ([System.String]::IsNullOrEmpty($PSBoundParameters.SearchAfter)) {
                            If ([System.String]::IsNullOrEmpty($PSBoundParameters.Body)) {
                                $PSBoundParameters.Add('SearchAfter', $XResultSearchAfter)
                            } Else {
                                $PSBoundParameters.Body.SearchAfter = $XResultSearchAfter
                            }
                        } Else {
                            $PSBoundParameters.SearchAfter = $XResultSearchAfter
                        }
                        $XResultCount = $JCHttpResponse.Result.Headers.GetValues('X-Result-Count')
                        $XLimit = $JCHttpResponse.Result.Headers.GetValues('X-Limit')
                        $Results += $Result
                        Write-Debug ("ResultCount: $($XResultCount); Limit: $($XLimit); XResultSearchAfter: $($XResultSearchAfter); ");
                        Write-Debug ('HttpRequest: ' + $JCHttpRequest);
                        Write-Debug ('HttpRequestContent: ' + $JCHttpRequestContent.Result);
                        Write-Debug ('HttpResponse: ' + $JCHttpResponse.Result);
                        # Write-Debug ('HttpResponseContent: ' + $JCHttpResponseContent.Result);
                    }
                } Else {
                    $Results += $Result
                    Break
                }
            }
            While ($XResultCount -eq $XLimit -and -not [System.String]::IsNullOrEmpty($Result))
        } Else {
            $PSBoundParameters.Remove('Paginate') | Out-Null
            $maxRetries = 4
            $resultCounter = 0
            :retryLoop do {
                $resultCounter++
                try {
                    $Result = JumpCloud.SDK.DirectoryInsights.internal\Get-JcSdkInternalEventCount @PSBoundParameters -errorAction SilentlyContinue
                    break retryLoop
                } catch {
                    If ($JCHttpResponse.Result.StatusCode -eq 503) {
                        Write-Warning ("503: Service Unavailable - retrying in " + ($resultCounter * 5) + " seconds.")
                    } else {
                        Write-Warning ("An error occurred: $_.")
                    }
                }
                Start-Sleep -Seconds ($resultCounter * 5)
            } while ($resultCounter -lt $maxRetries)
            Write-Debug ('HttpRequest: ' + $JCHttpRequest);
            Write-Debug ('HttpRequestContent: ' + $JCHttpRequestContent.Result);
            Write-Debug ('HttpResponse: ' + $JCHttpResponse.Result);
            # Write-Debug ('HttpResponseContent: ' + $JCHttpResponseContent.Result);
            If (-not [System.String]::IsNullOrEmpty($Result)) {
                $Results += $Result
            }
        }
    }
    End
    {
        # Clean up global variables
        $GlobalVars = @('JCHttpRequest', 'JCHttpRequestContent', 'JCHttpResponse', 'JCHttpResponseContent')
        $GlobalVars | ForEach-Object {
            If ((Get-Variable -Scope:('Global')).Where( { $_.Name -eq $_ })) { Remove-Variable -Name:($_) -Scope:('Global') }
        }
        Return $Results
    }
}


