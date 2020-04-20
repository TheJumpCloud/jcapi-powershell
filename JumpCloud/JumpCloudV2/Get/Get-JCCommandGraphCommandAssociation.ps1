Function Get-JCCommandGraphCommandAssociation
{
    #Requires -modules JumpCloud.SDK.V2
    [CmdletBinding(DefaultParameterSetName = 'List')]
    Param(
        [Parameter(
            ParameterSetName = 'List',
            Mandatory = $true
        )]
        [System.String]$CommandId,
        [Parameter(
            ParameterSetName = 'List',
            Mandatory = $true
        )]
        [System.String[]]$Targets,
        [Parameter(ParameterSetName = 'List')]
        [System.Int32]$Limit,
        [Parameter(ParameterSetName = 'List')]
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
                $Result = Get-JcSdkCommandGraphCommandAssociation @PSBoundParameters
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
            $Result = Get-JcSdkCommandGraphCommandAssociation @PSBoundParameters
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
