#Requires -modules JumpCloudApiSdkV2
Function Get-JCPolicyStatus
{
    [CmdletBinding(DefaultParameterSetName = 'List')]
	Param(
		[Parameter(
			ParameterSetName = 'List',
			Mandatory = $true
		)]
		[System.String]$SystemId,
		[Parameter(
			ParameterSetName = 'List1',
			Mandatory = $true
		)]
		[System.String]$PolicyId,
		[Parameter(ParameterSetName = 'List')]
		[Parameter(ParameterSetName = 'List1')]
		[System.String[]]$Filter,
		[Parameter(ParameterSetName = 'List')]
		[Parameter(ParameterSetName = 'List1')]
		[System.Int32]$Limit,
		[Parameter(ParameterSetName = 'List')]
		[Parameter(ParameterSetName = 'List1')]
		[System.Int32]$Skip,
		[Parameter(ParameterSetName = 'List')]
		[Parameter(ParameterSetName = 'List1')]
		[System.String[]]$Sort,
		[System.Boolean]$Paginate = $true
	)
    Begin
    {
        $Results = @()
        If ([System.String]::IsNullOrEmpty($PSBoundParameters.Skip))
        {
            $PSBoundParameters.Add('Skip',0)
        }
        If ([System.String]::IsNullOrEmpty($PSBoundParameters.Limit))
        {
            $PSBoundParameters.Add('Limit',100)
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
                $Result = Get-JcSdkPolicyStatus @PSBoundParameters
                If (-not [System.String]::IsNullOrEmpty($Result))
                {
                    $ResultCount = ($Result | Measure-Object).Count;
                $Results += $Result;
                    $PSBoundParameters.Skip += $ResultCount
                }
            }
            While ($ResultCount -eq $PSBoundParameters.Limit)
        }
        Else
        {
            $PSBoundParameters.Remove('Paginate') | Out-Null
            $Result = Get-JcSdkPolicyStatus @PSBoundParameters
            If (-not [System.String]::IsNullOrEmpty($Result))
            {
                $ResultCount = ($Result | Measure-Object).Count;
                $Results += $Result;
                $PSBoundParameters.Skip += $ResultCount
            }
        }
    }
    End
    {
        Return $Results
    }
}
