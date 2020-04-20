#Requires -modules JumpCloud.SDK.V2
Function New-JCUserGroup
{
    [CmdletBinding(DefaultParameterSetName = 'CreateExpanded')]
    Param(
        [Parameter(
            ParameterSetName = 'Create',
            Mandatory = $true,
            ValueFromPipeline = $true
        )]
        [JumpCloud.SDK.V2.Models.IUserGroupPost]$Body,
        [Parameter(
            ParameterSetName = 'CreateExpanded',
            Mandatory = $true
        )]
        [System.String]$Name,
        [Parameter(ParameterSetName = 'CreateExpanded')]
        [JumpCloud.SDK.V2.Models.IUserGroupAttributesPosixGroupsItem[]]$AttributePosixGroups,
        [Parameter(ParameterSetName = 'CreateExpanded')]
        [System.Management.Automation.SwitchParameter]$AttributeSambaEnabled,
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
$Results = New-JcSdkUserGroup @PSBoundParameters
    }
    End
    {
Return $Results
    }
}
