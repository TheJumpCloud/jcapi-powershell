Function Get-JcSdkSystemInsights
{
    [CmdletBinding(DefaultParameterSetName = 'List', PositionalBinding = $false)]
    Param(
        [Parameter(Mandatory)]
        [System.String]
        # Name of the SystemInsights table to query. See docs.jumpcloud.com for list of avalible table endpoints.
        [ArgumentCompleter( { param ( $CommandName, $ParameterName, $WordToComplete, $CommandAst, $FakeBoundParameters )
                $SystemInsightsPrefix = 'Get-JcSdkSystemInsight';
                $SystemInsightsTables = [Ordered]@{};
                $Commands = Get-Command -Module:('JumpCloud.SDK.V2') -Name:("$($SystemInsightsPrefix)*") | Where-Object { $_.Name -ne "$($SystemInsightsPrefix)s" };
                $Commands | ForEach-Object { $Help = Get-Help -Name:($_.Name); $SystemInsightsTables.Add($_.Name.Replace($SystemInsightsPrefix, ''), $Help.Description.Text + ' ' + $Help.parameters.parameter.Where( { $_.Name -eq 'filter' }).Description.Text + ' EX: {field}:{operator}:{searchValue}' ); };
                $FilterFilter = $fakeBoundParameter.Filter;
                $SystemInsightsTables.Keys | Where-Object { $_ -like "${wordToComplete}*" } | Where-Object { $SystemInsightsTables.$_ -like "${FilterFilter}*" };
            })]
        $Table,

        [Parameter()]
        [JumpCloud.SDK.V2.Category('Query')]
        [System.String]
        [ArgumentCompleter( { param ( $CommandName, $ParameterName, $WordToComplete, $CommandAst, $FakeBoundParameters )
                $SystemInsightsPrefix = 'Get-JcSdkSystemInsight';
                $SystemInsightsTables = [Ordered]@{};
                $Commands = Get-Command -Module:('JumpCloud.SDK.V2') -Name:("$($SystemInsightsPrefix)*") | Where-Object { $_.Name -ne "$($SystemInsightsPrefix)s" };
                $Commands | ForEach-Object { $Help = Get-Help -Name:($_.Name); $SystemInsightsTables.Add($_.Name.Replace($SystemInsightsPrefix, ''), $Help.Description.Text + ' ' + $Help.parameters.parameter.Where( { $_.Name -eq 'filter' }).Description.Text + ' EX: {field}:{operator}:{searchValue}' ); };
                $TypeFilter = $fakeBoundParameter.Table;
                return $SystemInsightsTables.Keys | Where-Object { $_ -like "${TypeFilter}*" } | ForEach-Object { $SystemInsightsTables.$_ | Where-Object { $_ -like "${wordToComplete}*" } } | Sort-Object -Unique;
            })]
        ${Filter},

        [Parameter()]
        [JumpCloud.SDK.V2.Category('Query')]
        [System.String[]]
        # The comma separated fields used to sort the collection.
        # Default sort is ascending, prefix with `-` to sort descending.
        ${Sort},

        [Parameter(DontShow)]
        [System.Boolean]
        # Set to $true to return all results. This will overwrite any skip and limit parameter.
        $Paginate = $true
    )
    Begin
    {
        $Results = @()
    }
    Process
    {
        $PSBoundParameters.Remove('Table') | Out-Null
        $Command = "JumpCloud.SDK.V2\Get-JcSdkSystemInsight$Table @PSBoundParameters"
        $Results = Invoke-Expression -Command:($Command)
    }
    End
    {
        Return $Results
    }
}