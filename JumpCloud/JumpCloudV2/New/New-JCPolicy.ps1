#Requires -modules JumpCloud.SDK.V2
Function New-JCPolicy
{
    [CmdletBinding(DefaultParameterSetName = 'CreateExpanded')]
    Param(
        [Parameter(
            ParameterSetName = 'Create',
            Mandatory = $true,
            ValueFromPipeline = $true
        )]
        [JumpCloud.SDK.V2.Models.IPolicyRequest]$Body,
        [Parameter(
            ParameterSetName = 'CreateExpanded',
            Mandatory = $true
        )]
        [System.String]$Name,
        [Parameter(ParameterSetName = 'CreateExpanded')]
        [System.String]$TemplateId,
        [Parameter(ParameterSetName = 'CreateExpanded')]
        [JumpCloud.SDK.V2.Models.IPolicyValue[]]$Values,
        [Parameter(ParameterSetName = 'CreateExpanded')]
        [Parameter(ParameterSetName = 'Create')]
        [Alias(cf)][System.Management.Automation.SwitchParameter]$Confirm,
        [Parameter(ParameterSetName = 'CreateExpanded')]
        [Parameter(ParameterSetName = 'Create')]
        [Alias(wi)][System.Management.Automation.SwitchParameter]$WhatIf,
        [System.Boolean]$Paginate = $true
    )
    Begin
    {
$Results = @()
    }
    Process
    {
$Results = New-JcSdkPolicy @PSBoundParameters
    }
    End
    {
Return $Results
    }
}
