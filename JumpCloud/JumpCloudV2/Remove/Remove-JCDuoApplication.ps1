#Requires -modules JumpCloudApiSdkV2
Function Remove-JCDuoApplication
{
    [CmdletBinding(DefaultParameterSetName = 'WhatIf')]
    Param(
        [Parameter(ParameterSetName = 'Delete', Mandatory = $True, Position = -2147483648, ValueFromPipeline = $False, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [Alias()][string]$AccountId,
        [Parameter(ParameterSetName = 'Delete', Mandatory = $True, Position = -2147483648, ValueFromPipeline = $False, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [Alias()][string]$ApplicationId,
        [Parameter(ParameterSetName = 'Delete', Mandatory = $False, Position = -2147483648, ValueFromPipeline = $False, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [Parameter(ParameterSetName = 'DeleteViaIdentity', Mandatory = $False, Position = -2147483648, ValueFromPipeline = $False, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [switch]$Confirm,
        [Parameter(ParameterSetName = 'DeleteViaIdentity', Mandatory = $True, Position = -2147483648, ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [Alias()][JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentity]$InputObject,
        [Parameter(ParameterSetName = 'Delete', Mandatory = $False, Position = -2147483648, ValueFromPipeline = $False, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [Parameter(ParameterSetName = 'DeleteViaIdentity', Mandatory = $False, Position = -2147483648, ValueFromPipeline = $False, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [switch]$WhatIf
    )
    Begin {
        $Results = @()
    }
    Process {
        $Results = Remove-JcSdkDuoApplication @PSBoundParameters
    }
    End {
        Return $Results
    }
}

