Function Get-JCEvent
{
    #Requires -modules JumpCloud.SDK.DirectoryInsights
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
                param($req, $callback, $next)
                # call the next step in the Pipeline
                $ResponseTask = $next.SendAsync($req, $callback)
                $global:JCHttpRequest = $req
                $global:JCHttpRequestContent = $req
                $global:JCHttpResponse = $ResponseTask
                Return $ResponseTask
            }
        )
    }
    Process
    {
        If ($Paginate)
        {
            $PSBoundParameters.Remove('Paginate') | Out-Null
            Do
            {
                Write-Debug ("ResultCount: $($XResultCount); Limit: $($XLimit); XResultSearchAfter: $($XResultSearchAfter); ");
                $Result = Get-JcSdkEvent @PSBoundParameters
                If (-not [System.String]::IsNullOrEmpty($Result))
                {
                    $XResultSearchAfter = ($JCHttpResponse.Result.Headers.GetValues('X-Search_after') | ConvertFrom-Json);
                    If ([System.String]::IsNullOrEmpty($PSBoundParameters.SearchAfter))
                    {
                        $PSBoundParameters.Add('SearchAfter', $XResultSearchAfter)
                    }
                    Else
                    {
                        $PSBoundParameters.SearchAfter = $XResultSearchAfter
                    }
                    $XResultCount = $JCHttpResponse.Result.Headers.GetValues('X-Result-Count')
                    $XLimit = $JCHttpResponse.Result.Headers.GetValues('X-Limit')
                    $Results += ($Result).ToJsonString() | ConvertFrom-Json;
                }
            }
            While ($XResultCount -eq $XLimit -and [System.String]::IsNullOrEmpty($Error))
        }
        Else
        {
            $PSBoundParameters.Remove('Paginate') | Out-Null
            $Result = Get-JcSdkEvent @PSBoundParameters
            If (-not [System.String]::IsNullOrEmpty($Result))
            {
                $Results += ($Result).ToJsonString() | ConvertFrom-Json;
            }
        }
    }
    End
    {
        Write-Debug ('HttpRequest: ' + $JCHttpRequest)
        Write-Debug ('HttpRequestContent: ' + $JCHttpRequestContent.Result)
        # Clean up global variables
        $GlobalVars = @('JCHttpRequest', 'JCHttpRequestContent', 'JCHttpResponse')
        $GlobalVars | ForEach-Object {
            If ((Get-Variable -Scope:('Global')).Where( { $_.Name -eq $_ })) { Remove-Variable -Name:($_) -Scope:('Global') }
        }
        Return $Results
    }
}