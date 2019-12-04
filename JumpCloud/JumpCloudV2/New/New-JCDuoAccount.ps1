#Requires -modules JumpCloudApiSdkV2
Function New-JCDuoAccount
{
    [CmdletBinding(DefaultParameterSetName = 'WhatIf')]
Param(
        [Parameter(ParameterSetName = 'Create', Mandatory = $False, Position = -2147483648, ValueFromPipeline = $False, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [Alias('cf')][switch]$Confirm,
        [Parameter(ParameterSetName = 'Create', Mandatory = $False, Position = -2147483648, ValueFromPipeline = $False, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [Alias('wi')][switch]$WhatIf
    )
    Begin {
        $Results = @()
    }
    Process {
        $Results = New-JcSdkDuoAccount @PSBoundParameters
    }
    End {
        Return $Results
    }
}
        
