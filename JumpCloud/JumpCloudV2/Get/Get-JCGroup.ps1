#Requires -modules JumpCloudApiSdkV2
Function Get-JCGroup
{
    [CmdletBinding(DefaultParameterSetName = 'WarningVariable')]
    Param(
        [Parameter(ParameterSetName = 'List', Mandatory = $False, Position = -2147483648, ValueFromPipeline = $False, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [Alias()][string[]]$Filter,
        [Parameter(ParameterSetName = 'List', Mandatory = $False, Position = -2147483648, ValueFromPipeline = $False, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [Alias()][int]$Limit,
        [Parameter(ParameterSetName = 'List', Mandatory = $False, Position = -2147483648, ValueFromPipeline = $False, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [Alias()][int]$Skip,
        [Parameter(ParameterSetName = 'List', Mandatory = $False, Position = -2147483648, ValueFromPipeline = $False, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [Alias()][string[]]$Sort
    )
    Begin {
        $Results = @()
        If([System.String]::IsNullOrEmpty($PSBoundParameters.Skip))
        {
            $PSBoundParameters.Add('Skip',0)
        }
        If([System.String]::IsNullOrEmpty($PSBoundParameters.Limit))
        {
            $PSBoundParameters.Add('Limit',100)
        }
    }
    Process {
        Do
        {
            # Write-Host ("Skip: $($PSBoundParameters.Skip); Limit: $($PSBoundParameters.Limit); ");
            $Result = Get-JcSdkGroup @PSBoundParameters
            If(-not [System.String]::IsNullOrEmpty($Result))
            {
                $ResultCount = ($Result | Measure-Object).Count;
                $Results += $Result;
                $PSBoundParameters.Skip += $ResultCount
            }
        }
        While ($ResultCount -eq $PSBoundParameters.Limit)
    }
    End {
        Return $Results
    }
}

