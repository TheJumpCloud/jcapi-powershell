<#
.Synopsis
Query the API for a count of matching events
.Description
Query the API for a count of matching events
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
.Outputs
System.String
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IEventQuery>: 
  Service <String[]>: service name to query. Known services: systems,radius,sso,directory,ldap,all
  StartTime <DateTime>: query start time, UTC in RFC3339 format
  [EndTime <DateTime?>]: optional query end time, UTC in RFC3339 format
  [Fields <String[]>]: optional list of fields to return from query
  [Limit <Int64?>]: Max number of rows to return
  [SearchAfter <String[]>]: Specific query to search after, see x-* response headers for next values
  [SearchTermAnd <ISearchTermAnd>]: list of event terms. If all terms match the event will be returned by the service.
    [(Any) <Object>]: This indicates any property can be added to this object.
  [SearchTermOr <ISearchTermOr>]: list of event terms. If any term matches, the event will be returned by the service.
    [(Any) <Object>]: This indicates any property can be added to this object.
  [Sort <String>]: ASC or DESC order for timestamp
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/jumpcloud.sdk.directoryinsights/get-jcsdkeventcount
#>
 Function Get-JcSdkEventCount
{
    [OutputType([System.Int64], [System.String])]
    [CmdletBinding(DefaultParameterSetName='GetExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
    [Parameter(ParameterSetName='Get', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.DirectoryInsights.Category('Body')]
    [JumpCloud.SDK.DirectoryInsights.Models.IEventQuery]
    # EventQuery is the users' command to search our auth logs
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='GetExpanded', Mandatory)]
    [JumpCloud.SDK.DirectoryInsights.Category('Body')]
    [System.String[]]
    # service name to query.
    # Known services: systems,radius,sso,directory,ldap,all
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
    [System.String[]]
    # optional list of fields to return from query
    ${Fields},

    [Parameter(ParameterSetName='GetExpanded')]
    [JumpCloud.SDK.DirectoryInsights.Category('Body')]
    [System.String[]]
    # Specific query to search after, see x-* response headers for next values
    ${SearchAfter},

    [Parameter(ParameterSetName='GetExpanded')]
    [JumpCloud.SDK.DirectoryInsights.Category('Body')]
    [JumpCloud.SDK.DirectoryInsights.Runtime.Info(PossibleTypes=([JumpCloud.SDK.DirectoryInsights.Models.ISearchTermAnd]))]
    [System.Collections.Hashtable]
    # list of event terms.
    # If all terms match the event will be returned by the service.
    ${SearchTermAnd},

    [Parameter(ParameterSetName='GetExpanded')]
    [JumpCloud.SDK.DirectoryInsights.Category('Body')]
    [JumpCloud.SDK.DirectoryInsights.Runtime.Info(PossibleTypes=([JumpCloud.SDK.DirectoryInsights.Models.ISearchTermOr]))]
    [System.Collections.Hashtable]
    # list of event terms.
    # If any term matches, the event will be returned by the service.
    ${SearchTermOr},

    [Parameter(ParameterSetName='GetExpanded')]
    [JumpCloud.SDK.DirectoryInsights.Category('Body')]
    [System.String]
    # ASC or DESC order for timestamp
    ${Sort},

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
                $global:JCHttpRequestContent = $req.Content.ReadAsStringAsync()
                $global:JCHttpResponse = $ResponseTask
                Return $ResponseTask
            }
        )
    }
    Process
    {
        If ($Paginate -and $PSCmdlet.ParameterSetName -in ('GetExpanded'))
        {
            $PSBoundParameters.Remove('Paginate') | Out-Null
            Do
            {
                $Result = JumpCloud.SDK.DirectoryInsights.internal\Get-JcSdkInternalEventCount @PSBoundParameters
                If ($JCHttpResponse.Result.Headers.Contains('X-Search_after'))
                {
                    If (-not [System.String]::IsNullOrEmpty($Result))
                    {
                        $XResultSearchAfter = ($JCHttpResponse.Result.Headers.GetValues('X-Search_after') | ConvertFrom-Json);
                        If ([System.String]::IsNullOrEmpty($PSBoundParameters.SearchAfter))
                        {
                            If ([System.String]::IsNullOrEmpty($PSBoundParameters.Body))
                            {
                                $PSBoundParameters.Add('SearchAfter', $XResultSearchAfter)
                            }
                            Else
                            {
                                $PSBoundParameters.Body.SearchAfter = $XResultSearchAfter
                            }
                        }
                        Else
                        {
                            $PSBoundParameters.SearchAfter = $XResultSearchAfter
                        }
                        $XResultCount = $JCHttpResponse.Result.Headers.GetValues('X-Result-Count')
                        $XLimit = $JCHttpResponse.Result.Headers.GetValues('X-Limit')
                        $Results += If ('ToJsonString' -in ($Result | Get-Member ).Name)
                        {
                            $Result.ToJsonString() | ConvertFrom-Json;
                        }
                        Else
                        {
                            $Result
                        }
                        Write-Debug ("ResultCount: $($XResultCount); Limit: $($XLimit); XResultSearchAfter: $($XResultSearchAfter); ");
                        Write-Debug ('HttpRequest: ' + $JCHttpRequest);
                        Write-Debug ('HttpRequestContent: ' + $JCHttpRequestContent.Result);
                    }
                }
                Else
                {
                    $Results += If ('ToJsonString' -in ($Result | Get-Member ).Name)
                    {
                        $Result.ToJsonString() | ConvertFrom-Json;
                    }
                    Else
                    {
                        $Result
                    }
                    Break
                }
            }
            While ($XResultCount -eq $XLimit -and -not [System.String]::IsNullOrEmpty($Result))
        }
        Else
        {
            $PSBoundParameters.Remove('Paginate') | Out-Null
            $Result = JumpCloud.SDK.DirectoryInsights.internal\Get-JcSdkInternalEventCount @PSBoundParameters
            Write-Debug ('HttpRequest: ' + $JCHttpRequest);
            Write-Debug ('HttpRequestContent: ' + $JCHttpRequestContent.Result);
            If (-not [System.String]::IsNullOrEmpty($Result))
            {
                $Results += If ('ToJsonString' -in ($Result | Get-Member ).Name)
                {
                    $Result.ToJsonString() | ConvertFrom-Json;
                }
                Else
                {
                    $Result
                }
            }
        }
    }
    End
    {
        # Clean up global variables
        $GlobalVars = @('JCHttpRequest', 'JCHttpRequestContent', 'JCHttpResponse')
        $GlobalVars | ForEach-Object {
            If ((Get-Variable -Scope:('Global')).Where( { $_.Name -eq $_ })) { Remove-Variable -Name:($_) -Scope:('Global') }
        }
        Return $Results
    }
}

