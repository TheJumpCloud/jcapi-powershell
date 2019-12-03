#Requires -modules JumpCloudApiSdkV2
Function New-JCProviderAdmin
{
    
    Param(
        [Parameter(ParameterSetName = 'Create', Mandatory = $True, Position = -2147483648, ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [Parameter(ParameterSetName = 'CreateViaIdentity', Mandatory = $True, Position = -2147483648, ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [Alias()][JumpCloudApiSdkV2.Models.IProviderAdminReq]$Body,
        [Parameter(ParameterSetName = 'Create', Mandatory = $False, Position = -2147483648, ValueFromPipeline = $False, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [Parameter(ParameterSetName = 'CreateExpanded', Mandatory = $False, Position = -2147483648, ValueFromPipeline = $False, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [Parameter(ParameterSetName = 'CreateViaIdentity', Mandatory = $False, Position = -2147483648, ValueFromPipeline = $False, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [Parameter(ParameterSetName = 'CreateViaIdentityExpanded', Mandatory = $False, Position = -2147483648, ValueFromPipeline = $False, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [switch]$Confirm,
        [Parameter(ParameterSetName = 'CreateExpanded', Mandatory = $True, Position = -2147483648, ValueFromPipeline = $False, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [Parameter(ParameterSetName = 'CreateViaIdentityExpanded', Mandatory = $True, Position = -2147483648, ValueFromPipeline = $False, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [Alias()][string]$Email,
        [Parameter(ParameterSetName = 'CreateExpanded', Mandatory = $False, Position = -2147483648, ValueFromPipeline = $False, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [Parameter(ParameterSetName = 'CreateViaIdentityExpanded', Mandatory = $False, Position = -2147483648, ValueFromPipeline = $False, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [Alias()][switch]$EnableMultiFactor,
        [Parameter(ParameterSetName = 'CreateExpanded', Mandatory = $False, Position = -2147483648, ValueFromPipeline = $False, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [Parameter(ParameterSetName = 'CreateViaIdentityExpanded', Mandatory = $False, Position = -2147483648, ValueFromPipeline = $False, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [Alias()][string]$Firstname,
        [Parameter(ParameterSetName = 'CreateViaIdentity', Mandatory = $True, Position = -2147483648, ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [Parameter(ParameterSetName = 'CreateViaIdentityExpanded', Mandatory = $True, Position = -2147483648, ValueFromPipeline = $True, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [Alias()][JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentity]$InputObject,
        [Parameter(ParameterSetName = 'CreateExpanded', Mandatory = $False, Position = -2147483648, ValueFromPipeline = $False, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [Parameter(ParameterSetName = 'CreateViaIdentityExpanded', Mandatory = $False, Position = -2147483648, ValueFromPipeline = $False, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [Alias()][string]$Lastname,
        [Parameter(ParameterSetName = 'Create', Mandatory = $True, Position = -2147483648, ValueFromPipeline = $False, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [Parameter(ParameterSetName = 'CreateExpanded', Mandatory = $True, Position = -2147483648, ValueFromPipeline = $False, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [Alias()][string]$ProviderId,
        [Parameter(ParameterSetName = 'Create', Mandatory = $False, Position = -2147483648, ValueFromPipeline = $False, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [Parameter(ParameterSetName = 'CreateExpanded', Mandatory = $False, Position = -2147483648, ValueFromPipeline = $False, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [Parameter(ParameterSetName = 'CreateViaIdentity', Mandatory = $False, Position = -2147483648, ValueFromPipeline = $False, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [Parameter(ParameterSetName = 'CreateViaIdentityExpanded', Mandatory = $False, Position = -2147483648, ValueFromPipeline = $False, ValueFromPipelineByPropertyName = $False, ValueFromRemainingArguments = $False)]
        [switch]$WhatIf
    )
    Begin {
        $Results = @()
    }
    Process {
        $Results = New-JcSdkProviderAdmin @PSBoundParameters
    }
    End {
        Return $Results
    }
}

