<#
.Synopsis
Query the API for a list of counts by time interval
.Description
Query the API for a list of counts by time interval
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
JumpCloud.SDK.DirectoryInsights.Models.IEventIntervalQuery
.Outputs
JumpCloud.SDK.DirectoryInsights.Models.IPaths8Vdch8EventsIntervalPostResponses200ContentApplicationJsonSchemaItems
.Outputs
System.String
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IEventIntervalQuery>:
  IntervalUnit <String>:
  Service <String[]>: service name to query. Known services: systems,radius,sso,directory,ldap,all
  StartTime <DateTime>: query start time, UTC in RFC3339 format
  [EndTime <DateTime?>]: optional query end time, UTC in RFC3339 format
  [IntervalValue <String>]: Interval Value. This specifies how many units you want to bucket the event counts by         optional
  [SearchTermAnd <ITermConjunction>]: TermConjunction
    [(Any) <Object>]: This indicates any property can be added to this object.
  [SearchTermOr <ITermConjunction>]: TermConjunction
  [Timezone <String>]: TimeZone. Specify the timezone in which the user is in         optional
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.DirectoryInsights/docs/exports/Get-JcSdkEventIntervalQueryEventInterval.md
#>
 Function Get-JcSdkEventIntervalQueryEventInterval
{
    [OutputType([JumpCloud.SDK.DirectoryInsights.Models.IPaths8Vdch8EventsIntervalPostResponses200ContentApplicationJsonSchemaItems], [System.String])]
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
    [System.String]
    # Interval Value.
    # This specifies how many units you want to bucket the event counts byoptional
    ${IntervalValue},

    [Parameter(ParameterSetName='GetExpanded')]
    [JumpCloud.SDK.DirectoryInsights.Category('Body')]
    [JumpCloud.SDK.DirectoryInsights.Runtime.Info(PossibleTypes=([JumpCloud.SDK.DirectoryInsights.Models.ITermConjunction]))]
    [System.Collections.Hashtable]
    # TermConjunction
    ${SearchTermAnd},

    [Parameter(ParameterSetName='GetExpanded')]
    [JumpCloud.SDK.DirectoryInsights.Category('Body')]
    [JumpCloud.SDK.DirectoryInsights.Runtime.Info(PossibleTypes=([JumpCloud.SDK.DirectoryInsights.Models.ITermConjunction]))]
    [System.Collections.Hashtable]
    # TermConjunction
    ${SearchTermOr},

    [Parameter(ParameterSetName='GetExpanded')]
    [JumpCloud.SDK.DirectoryInsights.Category('Body')]
    [System.String]
    # TimeZone.
    # Specify the timezone in which the user is inoptional
    ${Timezone}
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
        $Result = JumpCloud.SDK.DirectoryInsights.internal\Get-JcSdkInternalEventIntervalQueryEventInterval @PSBoundParameters
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

