Function Get-JCApplicationTemplate
{
    #Requires -modules JumpCloud.SDK.V1
    [OutputType([JumpCloud.SDK.V1.Models.IApplicationtemplate], [JumpCloud.SDK.V1.Models.IApplicationtemplateslist])]
    [CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
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
        [Parameter(ParameterSetName = 'Get')]
        [Parameter(ParameterSetName = 'GetViaIdentity')]
        [System.String]$Fields,
        [Parameter(ParameterSetName = 'List')]
        [Parameter(ParameterSetName = 'Get')]
        [Parameter(ParameterSetName = 'GetViaIdentity')]
        [System.String]$Filter,
        [Parameter(ParameterSetName = 'List')]
        [Parameter(ParameterSetName = 'Get')]
        [Parameter(ParameterSetName = 'GetViaIdentity')]
        [System.Int32]$Limit,
        [Parameter(ParameterSetName = 'List')]
        [Parameter(ParameterSetName = 'Get')]
        [Parameter(ParameterSetName = 'GetViaIdentity')]
        [System.Int32]$Skip,
        [Parameter(ParameterSetName = 'List')]
        [Parameter(ParameterSetName = 'Get')]
        [Parameter(ParameterSetName = 'GetViaIdentity')]
        [System.String]$Sort,
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
                $Result = Get-JcSdkApplicationTemplate @PSBoundParameters
                If (-not [System.String]::IsNullOrEmpty($Result))
                {
                    $ResultCount = ($Result.results | Measure-Object).Count;
                    $Results += $Result.results;
                    $PSBoundParameters.Skip += $ResultCount
                }
            }
            While ($ResultCount -eq $PSBoundParameters.Limit -and $Result)
        }
        Else
        {
            $PSBoundParameters.Remove('Paginate') | Out-Null
            $Result = Get-JcSdkApplicationTemplate @PSBoundParameters
            If (-not [System.String]::IsNullOrEmpty($Result))
            {
                $Results += $Result.results;
            }
        }
    }
    End
    {
        Return $Results
    }
}
