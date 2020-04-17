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
		[JumpCloud.SDK.DirectoryInsights.Models.IEventQuerySearchAfterItem[]]$SearchAfter,
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
                $Result = Get-JcSdkEvent @PSBoundParameters
                If (-not [System.String]::IsNullOrEmpty($Result))
                {
                    
                    $PSBoundParameters.Skip += $ResultCount
                }
            }
            While ($ResultCount -eq $PSBoundParameters.Limit)
        }
        Else
        {
            $PSBoundParameters.Remove('Paginate') | Out-Null
            $Result = Get-JcSdkEvent @PSBoundParameters
            If (-not [System.String]::IsNullOrEmpty($Result))
            {
                
                $PSBoundParameters.Skip += $ResultCount
            }
        }
    }
    End
    {
        Return $Results
    }
}
