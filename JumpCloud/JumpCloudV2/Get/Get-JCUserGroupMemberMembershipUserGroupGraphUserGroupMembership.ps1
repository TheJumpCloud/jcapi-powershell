Function Get-JCUserGroupMemberMembershipUserGroupGraphUserGroupMembership
{
    #Requires -modules JumpCloud.SDK.V2
    [OutputType([JumpCloud.SDK.V2.Models.IGraphObjectWithPaths])]
    [CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
    Param(
        [Parameter(
            ParameterSetName = 'List',
            Mandatory = $true
        )]
        [System.String]$GroupId,
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
                $Result = Get-JcSdkUserGroupMemberMembershipUserGroupGraphUserGroupMembership @PSBoundParameters
                If (-not [System.String]::IsNullOrEmpty($Result))
                {
                    $ResultCount = ($Result | Measure-Object).Count;
                    $Results += $Result;
                    $PSBoundParameters.Skip += $ResultCount
                }
            }
            While ($ResultCount -eq $PSBoundParameters.Limit -and $Result)
        }
        Else
        {
            $PSBoundParameters.Remove('Paginate') | Out-Null
            $Result = Get-JcSdkUserGroupMemberMembershipUserGroupGraphUserGroupMembership @PSBoundParameters
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
