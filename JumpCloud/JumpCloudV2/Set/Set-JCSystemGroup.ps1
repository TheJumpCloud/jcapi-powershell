#Requires -modules JumpCloudApiSdkV2
Function Set-JCSystemGroup
{
    Param(
        [Parameter(ParameterSetName = 'Put', Mandatory = $True, Position = -2147483648, ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [Parameter(ParameterSetName = 'PutViaIdentity', Mandatory = $True, Position = -2147483648, ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [JumpCloudApiSdkV2.Models.ISystemGroupData]$Body,
        [Parameter(ParameterSetName = 'Put', Mandatory = $False, Position = -2147483648, ValueFromPipeline = $False, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [Parameter(ParameterSetName = 'PutExpanded', Mandatory = $False, Position = -2147483648, ValueFromPipeline = $False, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [Parameter(ParameterSetName = 'PutViaIdentity', Mandatory = $False, Position = -2147483648, ValueFromPipeline = $False, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [Parameter(ParameterSetName = 'PutViaIdentityExpanded', Mandatory = $False, Position = -2147483648, ValueFromPipeline = $False, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [Alias('cf')][switch]$Confirm,
        [Parameter(ParameterSetName = 'Put', Mandatory = $True, Position = -2147483648, ValueFromPipeline = $False, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [Parameter(ParameterSetName = 'PutExpanded', Mandatory = $True, Position = -2147483648, ValueFromPipeline = $False, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [string]$Id,
        [Parameter(ParameterSetName = 'PutViaIdentity', Mandatory = $True, Position = -2147483648, ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [Parameter(ParameterSetName = 'PutViaIdentityExpanded', Mandatory = $True, Position = -2147483648, ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentity]$InputObject,
        [Parameter(ParameterSetName = 'PutExpanded', Mandatory = $True, Position = -2147483648, ValueFromPipeline = $False, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [Parameter(ParameterSetName = 'PutViaIdentityExpanded', Mandatory = $True, Position = -2147483648, ValueFromPipeline = $False, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [string]$Name,
        [Parameter(ParameterSetName = 'Put', Mandatory = $False, Position = -2147483648, ValueFromPipeline = $False, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [Parameter(ParameterSetName = 'PutExpanded', Mandatory = $False, Position = -2147483648, ValueFromPipeline = $False, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [Parameter(ParameterSetName = 'PutViaIdentity', Mandatory = $False, Position = -2147483648, ValueFromPipeline = $False, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [Parameter(ParameterSetName = 'PutViaIdentityExpanded', Mandatory = $False, Position = -2147483648, ValueFromPipeline = $False, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [Alias('wi')][switch]$WhatIf
    )
    Begin {
        $Results = @()
    }
    Process {
        $Results = Set-JcSdkSystemGroup @PSBoundParameters
    }
    End {
        Return $Results
    }
}
        
