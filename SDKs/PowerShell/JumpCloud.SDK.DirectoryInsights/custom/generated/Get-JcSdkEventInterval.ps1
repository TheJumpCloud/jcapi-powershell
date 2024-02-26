<#
.Synopsis
Query the API for a list of counts by time interval
#### Sample Request
```
curl -X POST 'https://api.jumpcloud.com/insights/directory/v1/events/interval' -H 'Content-Type: application/json' -H 'x-api-key: REPLACE_KEY_VALUE' --data '{\"service\": [\"all\"], \"start_time\": \"2021-07-14T23:00:00Z\", \"end_time\": \"2021-07-28T14:00:00Z\", \"timezone\": \"-0500\", \"interval_unit\": \"h\", \"interval_value\": \"2\"}'
```
.Description
Query the API for a list of counts by time interval
#### Sample Request
```
curl -X POST 'https://api.jumpcloud.com/insights/directory/v1/events/interval' -H 'Content-Type: application/json' -H 'x-api-key: REPLACE_KEY_VALUE' --data '{\"service\": [\"all\"], \"start_time\": \"2021-07-14T23:00:00Z\", \"end_time\": \"2021-07-28T14:00:00Z\", \"timezone\": \"-0500\", \"interval_unit\": \"h\", \"interval_value\": \"2\"}'
```
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
JumpCloud.SDK.DirectoryInsights.Models.IEventIntervalQuery
.Outputs
JumpCloud.SDK.DirectoryInsights.Models.IPathsD98A8EventsIntervalPostResponses200ContentApplicationJsonSchemaPropertiesBucketsItems
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IEventIntervalQuery>:
  Service <String[]>: service name to query.
  StartTime <DateTime>: query start time, UTC in RFC3339 format
  IntervalUnit <String>:
  [EndTime <DateTime?>]: optional query end time, UTC in RFC3339 format
  [IntervalValue <String>]: Interval Value. This specifies how many units you want to bucket the event counts by
  [Q <String>]: optional string for specifying a full text query
  [SearchTermAnd <ITermConjunction>]: TermConjunction represents a conjunction (and/or)         NOTE: the validator limits what the operator can be, not the object         for future-proof-ness         and a list of sub-values
    [(Any) <Object>]: This indicates any property can be added to this object.
  [SearchTermNot <ITermConjunction>]: TermConjunction represents a conjunction (and/or)         NOTE: the validator limits what the operator can be, not the object         for future-proof-ness         and a list of sub-values
  [SearchTermOr <ITermConjunction>]: TermConjunction represents a conjunction (and/or)         NOTE: the validator limits what the operator can be, not the object         for future-proof-ness         and a list of sub-values
  [Timezone <String>]: TimeZone. Specify the timezone in which the user is in         optional
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.DirectoryInsights/docs/exports/Get-JcSdkEventInterval.md
#>
 Function Get-JcSdkEventInterval
{
    [OutputType([JumpCloud.SDK.DirectoryInsights.Models.IPathsD98A8EventsIntervalPostResponses200ContentApplicationJsonSchemaPropertiesBucketsItems])]
    [CmdletBinding(DefaultParameterSetName='GetExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
    [Parameter(ParameterSetName='Get', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.DirectoryInsights.Category('Body')]
    [JumpCloud.SDK.DirectoryInsights.Models.IEventIntervalQuery]
    # EventIntervalQuery is the users' command to search our auth logs for bucketed counts of values of the specified field
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body}, 

    [Parameter(ParameterSetName='GetExpanded', Mandatory)]
    [JumpCloud.SDK.DirectoryInsights.Category('Body')]
    [System.String]
    # .
    ${IntervalUnit}, 

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
    [JumpCloud.SDK.DirectoryInsights.Category('Body')]
    [System.String]
    # Interval Value.
    # This specifies how many units you want to bucket the event counts by
    ${IntervalValue}, 

    [Parameter(ParameterSetName='GetExpanded')]
    [JumpCloud.SDK.DirectoryInsights.Category('Body')]
    [System.String]
    # optional string for specifying a full text query
    ${Q}, 

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
    # TimeZone.
    # Specify the timezone in which the user is inoptional
    ${Timezone}, 

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
                do {
                    $resultCounter++
                    $Result = (JumpCloud.SDK.DirectoryInsights.internal\Get-JcSdkInternalEventInterval @PSBoundParameters).ToJsonString() | ConvertFrom-Json;
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
            do {
                $resultCounter++
                $Result = (JumpCloud.SDK.DirectoryInsights.internal\Get-JcSdkInternalEventInterval @PSBoundParameters).ToJsonString() | ConvertFrom-Json;
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


