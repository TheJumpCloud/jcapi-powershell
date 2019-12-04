#Requires -modules JumpCloudApiSdkV2
Function Get-JCUserGroupTraverseRadiusServer
{
    [CmdletBinding(DefaultParameterSetName = 'List')]
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
                $Result = Get-JcSdkUserGroupTraverseRadiusServer @PSBoundParameters
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
            $Result = Get-JcSdkUserGroupTraverseRadiusServer @PSBoundParameters
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
