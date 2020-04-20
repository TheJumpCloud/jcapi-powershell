#Requires -modules JumpCloud.SDK.DirectoryInsights
Function Get-JCEvent
{
    [CmdletBinding(DefaultParameterSetName = 'GetExpanded')]
    Param(
        [Parameter(
            ParameterSetName = 'Get',
            Mandatory = $true,
            ValueFromPipeline = $true
        )]
        [JumpCloud.SDK.DirectoryInsights.Models.IEventQuery]$EventQueryBody,
        [Parameter(ParameterSetName = 'GetExpanded')]
        [System.String]$EndTime,
        [Parameter(ParameterSetName = 'GetExpanded')]
        [System.String[]]$Fields,
        [Parameter(ParameterSetName = 'GetExpanded')]
        [System.Int64]$Limit,
        [Parameter(ParameterSetName = 'GetExpanded')]
        [System.String[]]$SearchAfter,
        [Parameter(ParameterSetName = 'GetExpanded')]
        [System.Collections.Hashtable]$SearchTermAnd,
        [Parameter(ParameterSetName = 'GetExpanded')]
        [System.Collections.Hashtable]$SearchTermOr,
        [Parameter(ParameterSetName = 'GetExpanded')]
        [System.String[]]$Service,
        [Parameter(ParameterSetName = 'GetExpanded')]
        [System.String]$Sort,
        [Parameter(ParameterSetName = 'GetExpanded')]
        [System.String]$StartTime,
        [System.Boolean]$Paginate = $true
    )
    Begin
    {
        $Results = @()
        $PSBoundParameters.Add('HttpPipelineAppend', {
                param($req, $callback, $next )
                # call the next step in the Pipeline
                $ResponseTask = $next.SendAsync($req, $callback)
                $global:JCHttpRequest = $req
                $global:JCHttpResponse = $ResponseTask.Result
                Return $ResponseTask
            }
        )
    }
    Process
    {
        Do
        {
            Write-Debug ("ResultCount: $($XResultCount); Limit: $($XLimit); XResultSearchAfter: $($XResultSearchAfter); ");
            $Result = Get-JcSdkEvent @PSBoundParameters
            If (-not [System.String]::IsNullOrEmpty($Result))
            {
                $XResultSearchAfter = ($JCHttpResponse.Headers.GetValues('X-Search_after') | ConvertFrom-Json);
                If ([System.String]::IsNullOrEmpty($PSBoundParameters.SearchAfter))
                {
                    $PSBoundParameters.Add('SearchAfter', $XResultSearchAfter)
                }
                Else
                {
                    $PSBoundParameters.SearchAfter = $XResultSearchAfter
                }
                $XResultCount = $JCHttpResponse.Headers.GetValues('X-Result-Count')
                $XLimit = $JCHttpResponse.Headers.GetValues('X-Limit')
                $Results += ($Result).ToJsonString() | ConvertFrom-Json;
            }
            Else
            {
                Write-Warning ('No Results Found')
            }
        }
        While ($XResultCount -eq $XLimit)
    }
    End
    {
        # Clean up global variables
        If ((Get-Variable -Scope:('Global')).Where( { $_.Name -eq 'JCHttpRequest' })) { Remove-Variable -Name:('JCHttpRequest') -Scope:('Global') }
        If ((Get-Variable -Scope:('Global')).Where( { $_.Name -eq 'JCHttpResponse' })) { Remove-Variable -Name:('JCHttpResponse') -Scope:('Global') }
        Return $Results
    }
}
