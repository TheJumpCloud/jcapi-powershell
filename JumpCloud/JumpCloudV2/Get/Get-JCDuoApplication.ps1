#Requires -modules JumpCloudApiSdkV2
Function Get-JCDuoApplication
{
    [CmdletBinding(DefaultParameterSetName = 'WarningVariable')]
    Param(
        [Parameter(ParameterSetName = 'Get', Mandatory = $True, Position = -2147483648, ValueFromPipeline = $False, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [Parameter(ParameterSetName = 'List', Mandatory = $True, Position = -2147483648, ValueFromPipeline = $False, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [Alias()][string]$AccountId,
        [Parameter(ParameterSetName = 'Get', Mandatory = $True, Position = -2147483648, ValueFromPipeline = $False, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [Alias()][string]$ApplicationId,
        [Parameter(ParameterSetName = 'GetViaIdentity', Mandatory = $True, Position = -2147483648, ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [Alias()][JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentity]$InputObject
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
            $Result = Get-JcSdkDuoApplication @PSBoundParameters
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

