Function Get-JCApplication
{
    #Requires -modules JumpCloud.SDK.V1
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
        [JumpCloud.SDK.V1.Models.IJumpCloudApIsIdentity]$InputObject,
        [Parameter(ParameterSetName = 'List')]
        [System.String]$Fields,
        [Parameter(ParameterSetName = 'List')]
        [System.String]$Filter,
        [Parameter(ParameterSetName = 'List')]
        [System.Int32]$Limit,
        [Parameter(ParameterSetName = 'List')]
        [System.Int32]$Skip,
        [Parameter(ParameterSetName = 'List')]
        [System.String]$Sort,
        [Parameter(ParameterSetName = 'GetViaIdentity')]
        [Parameter(ParameterSetName = 'Get')]
        [System.String]$Accept,
        [Parameter(ParameterSetName = 'GetViaIdentity')]
        [Parameter(ParameterSetName = 'Get')]
        [System.String]$ContentType,
        [Parameter(ParameterSetName = 'GetViaIdentity')]
        [Parameter(ParameterSetName = 'Get')]
        [System.String]$XOrgId,
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
        If ($PSBoundParameters.Paginate)
        {
            $PSBoundParameters.Remove('Paginate') | Out-Null
            Do
            {
                Write-Debug ("Skip: $($PSBoundParameters.Skip); Limit: $($PSBoundParameters.Limit);");
                $Result = Get-JcSdkApplication @PSBoundParameters
                If (-not [System.String]::IsNullOrEmpty($Result))
                {
                    $ResultCount = ($Result.results | Measure-Object).Count;
                    $Results += $Result.results;
                    $PSBoundParameters.Skip += $ResultCount
                }
            }
            While ($ResultCount -eq $PSBoundParameters.Limit)
        }
        Else
        {
            $PSBoundParameters.Remove('Paginate') | Out-Null
            $Result = Get-JcSdkApplication @PSBoundParameters
            If (-not [System.String]::IsNullOrEmpty($Result))
            {
                $ResultCount = ($Result.results | Measure-Object).Count;
                $Results += $Result.results;
                $PSBoundParameters.Skip += $ResultCount
            }
        }
    }
    End
    {
        Return $Results
    }
}
