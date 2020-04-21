Function New-JCUserGroup
{
    #Requires -modules JumpCloud.SDK.V2
    [OutputType([JumpCloud.SDK.V2.Models.IUserGroup])]
    [CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
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
        [System.Management.Automation.SwitchParameter]$AttributeSambaEnabled
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
