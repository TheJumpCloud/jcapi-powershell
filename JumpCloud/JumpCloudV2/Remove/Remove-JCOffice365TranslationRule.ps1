#Requires -modules JumpCloudApiSdkV2
Function Remove-JCOffice365TranslationRule
{
    [CmdletBinding(DefaultParameterSetName = 'WhatIf')]
Param(
        [Parameter(ParameterSetName = 'Delete', Mandatory = $False, Position = -2147483648, ValueFromPipeline = $False, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [Parameter(ParameterSetName = 'DeleteViaIdentity', Mandatory = $False, Position = -2147483648, ValueFromPipeline = $False, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [Alias('cf')][switch]$Confirm,
        [Parameter(ParameterSetName = 'Delete', Mandatory = $True, Position = -2147483648, ValueFromPipeline = $False, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [string]$Id,
        [Parameter(ParameterSetName = 'DeleteViaIdentity', Mandatory = $True, Position = -2147483648, ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentity]$InputObject,
        [Parameter(ParameterSetName = 'Delete', Mandatory = $True, Position = -2147483648, ValueFromPipeline = $False, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [string]$Office365Id,
        [Parameter(ParameterSetName = 'Delete', Mandatory = $False, Position = -2147483648, ValueFromPipeline = $False, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [Parameter(ParameterSetName = 'DeleteViaIdentity', Mandatory = $False, Position = -2147483648, ValueFromPipeline = $False, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [Alias('wi')][switch]$WhatIf
    )
    Begin {
        $Results = @()
    }
    Process {
        $Results = Remove-JcSdkOffice365TranslationRule @PSBoundParameters
    }
    End {
        Return $Results
    }
}
        
