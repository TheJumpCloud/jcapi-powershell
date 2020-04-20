Function Get-JCSystemInsightStartupItem
{
    #Requires -modules JumpCloud.SDK.V2
    [CmdletBinding(DefaultParameterSetName = 'Get')]
    Param(
        [Parameter(ParameterSetName = 'Get')]
        [System.String[]]$Filter,
        [Parameter(ParameterSetName = 'Get')]
        [System.Int32]$Limit,
        [Parameter(ParameterSetName = 'Get')]
        [System.Int32]$Skip,
        [System.Boolean]$Paginate = $true
    )
    Begin
    {
        $Results = @()
        If ([System.String]::IsNullOrEmpty($PSBoundParameters.Skip))
        {
            $PSBoundParameters.Add('Skip', 0)
        }
        If ([System.String]::IsNullOrEmpty($PSBoundParameters.Limit))
        {
            $PSBoundParameters.Add('Limit', 100)
        }
    }
    Process
    {
        If ($Paginate)
        {
            $PSBoundParameters.Remove('Paginate') | Out-Null
            Do
            {
                Write-Debug ("Skip: $($PSBoundParameters.Skip); Limit: $($PSBoundParameters.Limit);");
                $Result = Get-JcSdkSystemInsightStartupItem @PSBoundParameters
                If (-not [System.String]::IsNullOrEmpty($Result))
                {
                    $ResultCount = ($Result | Measure-Object).Count;
                    $Results += $Result;
                    $PSBoundParameters.Skip += $ResultCount
                }
            }
            While ($ResultCount -eq $PSBoundParameters.Limit -and [System.String]::IsNullOrEmpty($Error)))
        }
        Else
        {
            $PSBoundParameters.Remove('Paginate') | Out-Null
            $Result = Get-JcSdkSystemInsightStartupItem @PSBoundParameters
            If (-not [System.String]::IsNullOrEmpty($Result))
            {
                $Results += $Result;
            }
        }
    }
    End
    {
        Return $Results
    }
}
