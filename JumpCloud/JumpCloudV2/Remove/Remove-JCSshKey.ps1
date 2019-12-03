#Requires -modules JumpCloudApiSdkV1
Function Remove-JCSshKey
{
    [CmdletBinding(DefaultParameterSetName = 'WhatIf')]
    Param(
        [Parameter(ParameterSetName = 'Delete', Mandatory = $False, Position = -2147483648, ValueFromPipeline = $False, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [Parameter(ParameterSetName = 'DeleteViaIdentity', Mandatory = $False, Position = -2147483648, ValueFromPipeline = $False, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [switch]$Confirm,
        [Parameter(ParameterSetName = 'Delete', Mandatory = $True, Position = -2147483648, ValueFromPipeline = $False, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [Alias()][string]$Id,
        [Parameter(ParameterSetName = 'DeleteViaIdentity', Mandatory = $True, Position = -2147483648, ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [Alias()][JumpCloudApiSdkV1.Models.IJumpCloudApIsIdentity]$InputObject,
        [Parameter(ParameterSetName = 'Delete', Mandatory = $True, Position = -2147483648, ValueFromPipeline = $False, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [Alias()][string]$SystemuserId,
        [Parameter(ParameterSetName = 'Delete', Mandatory = $False, Position = -2147483648, ValueFromPipeline = $False, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [Parameter(ParameterSetName = 'DeleteViaIdentity', Mandatory = $False, Position = -2147483648, ValueFromPipeline = $False, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [switch]$WhatIf
    )
    Begin {
        $Results = @()
    }
    Process {
        $Results = Remove-JcSdkSshKey @PSBoundParameters
    }
    End {
        Return $Results
    }
}

