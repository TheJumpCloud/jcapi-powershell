#Requires -modules JumpCloudApiSdkV2
Function New-JCBulkUser
{
    [CmdletBinding(DefaultParameterSetName = 'WhatIf')]
Param(
        [Parameter(ParameterSetName = 'Create', Mandatory = $True, Position = -2147483648, ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [JumpCloudApiSdkV2.Models.IBulkUserCreate[]]$Body,
        [Parameter(ParameterSetName = 'Create', Mandatory = $False, Position = -2147483648, ValueFromPipeline = $False, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [Alias('cf')][switch]$Confirm,
        [Parameter(ParameterSetName = 'Create', Mandatory = $False, Position = -2147483648, ValueFromPipeline = $False, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [Alias('wi')][switch]$WhatIf
    )
    Begin {
        $Results = @()
    }
    Process {
        $Results = New-JcSdkBulkUser @PSBoundParameters
    }
    End {
        Return $Results
    }
}
        
