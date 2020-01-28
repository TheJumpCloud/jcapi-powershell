#Requires -modules JumpCloud.SDK.V1
Function Search-JCOrganization
{
    [CmdletBinding(DefaultParameterSetName = 'SearchExpanded')]
	Param(
		[Parameter(ParameterSetName = 'SearchExpanded')]
		[Parameter(ParameterSetName = 'Search')]
		[System.String]$Fields,
		[Parameter(ParameterSetName = 'SearchExpanded')]
		[Parameter(ParameterSetName = 'Search')]
		[System.String]$Filter,
		[Parameter(ParameterSetName = 'SearchExpanded')]
		[Parameter(ParameterSetName = 'Search')]
		[System.Int32]$Limit,
		[Parameter(ParameterSetName = 'SearchExpanded')]
		[Parameter(ParameterSetName = 'Search')]
		[System.Int32]$Skip,
		[Parameter(
			ParameterSetName = 'Search',
			Mandatory = $true,
			ValueFromPipeline = $true
		)]
		[JumpCloud.SDK.V1.Models.ISearch]$Body,
		[Parameter(ParameterSetName = 'SearchExpanded')]
		[System.String]$Fields1,
		[Parameter(ParameterSetName = 'SearchExpanded')]
		[JumpCloud.SDK.V1.Models.ISearchFilter]$Filter1,
		[Parameter(ParameterSetName = 'SearchExpanded')]
		[JumpCloud.SDK.V1.Models.ISearchFilter1]$SearchFilter,
		[Parameter(ParameterSetName = 'SearchExpanded')]
		[Parameter(ParameterSetName = 'Search')]
		[Alias(cf)][System.Management.Automation.SwitchParameter]$Confirm,
		[Parameter(ParameterSetName = 'SearchExpanded')]
		[Parameter(ParameterSetName = 'Search')]
		[Alias(wi)][System.Management.Automation.SwitchParameter]$WhatIf,
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
                # Write-Host ("Skip: $($PSBoundParameters.Skip); Limit: $($PSBoundParameters.Limit); ");
                $Result = Search-JcSdkOrganization @PSBoundParameters
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
            $Result = Search-JcSdkOrganization @PSBoundParameters
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
