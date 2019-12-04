#Requires -modules JumpCloudApiSdkV2
Function Update-JCBulkUser
{
    [CmdletBinding(DefaultParameterSetName = 'WhatIf')]
Param(
        [Parameter(ParameterSetName = 'Update', Mandatory = $True, Position = -2147483648, ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [JumpCloudApiSdkV2.Models.IBulkUserUpdate[]]$Body,
        [Parameter(ParameterSetName = 'Update', Mandatory = $False, Position = -2147483648, ValueFromPipeline = $False, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [Alias('cf')][switch]$Confirm,
        [Parameter(ParameterSetName = 'Update', Mandatory = $False, Position = -2147483648, ValueFromPipeline = $False, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [Alias('wi')][switch]$WhatIf
    )
    Begin {
        $Results = @()
    }
    Process {
        $Results = Update-JcSdkBulkUser @PSBoundParameters
    }
    End {
        Return $Results
    }
}
        
