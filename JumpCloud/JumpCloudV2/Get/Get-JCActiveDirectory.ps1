Function Get-JCActiveDirectory
{
    #Requires -modules JumpCloud.SDK.V2
    [CmdletBinding(DefaultParameterSetName = 'List')]
    Param(
        [Parameter(
            ParameterSetName = 'Get',
            Mandatory = $true
        )]
        [System.String]$Id,
        [Parameter(
            ParameterSetName = 'GetViaIdentity',
            Mandatory = $true,
            ValueFromPipeline = $true
        )]
        [JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity]$InputObject,
        [Parameter(ParameterSetName = 'List')]
        [System.String[]]$Fields,
        [Parameter(ParameterSetName = 'List')]
        [System.String[]]$Filter,
        [Parameter(ParameterSetName = 'List')]
        [System.Int32]$Limit,
        [Parameter(ParameterSetName = 'List')]
        [System.Int32]$Skip,
        [Parameter(ParameterSetName = 'List')]
        [System.String[]]$Sort,
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
                $Result = Get-JcSdkActiveDirectory @PSBoundParameters
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
            $Result = Get-JcSdkActiveDirectory @PSBoundParameters
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
