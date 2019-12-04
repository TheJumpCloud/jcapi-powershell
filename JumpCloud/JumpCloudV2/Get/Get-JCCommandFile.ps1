#Requires -modules JumpCloudApiSdkV1
Function Get-JCCommandFile
{
    [CmdletBinding(DefaultParameterSetName = 'Get')]
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
		[JumpCloudApiSdkV1.Models.IJumpCloudApIsIdentity]$InputObject,
		[Parameter(ParameterSetName = 'Get')]
		[Parameter(ParameterSetName = 'GetViaIdentity')]
		[System.String]$Fields,
		[Parameter(ParameterSetName = 'Get')]
		[Parameter(ParameterSetName = 'GetViaIdentity')]
		[System.Int32]$Limit,
		[Parameter(ParameterSetName = 'Get')]
		[Parameter(ParameterSetName = 'GetViaIdentity')]
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
                $Result = Get-JcSdkCommandFile @PSBoundParameters
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
            $Result = Get-JcSdkCommandFile @PSBoundParameters
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
