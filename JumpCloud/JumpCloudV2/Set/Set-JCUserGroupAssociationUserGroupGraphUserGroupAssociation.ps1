Function Set-JCUserGroupAssociationUserGroupGraphUserGroupAssociation
{
    #Requires -modules JumpCloud.SDK.V2
    [OutputType([System.Boolean])]
    [CmdletBinding(DefaultParameterSetName='SetExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
        [Parameter(
            ParameterSetName = 'SetExpanded',
            Mandatory = $true
        )]
        [Parameter(
            ParameterSetName = 'Set',
            Mandatory = $true
        )]
        [System.String]$GroupId,
        [Parameter(
            ParameterSetName = 'SetViaIdentityExpanded',
            Mandatory = $true,
            ValueFromPipeline = $true
        )]
        [Parameter(
            ParameterSetName = 'SetViaIdentity',
            Mandatory = $true,
            ValueFromPipeline = $true
        )]
        [JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity]$InputObject,
        [Parameter(
            ParameterSetName = 'SetViaIdentity',
            Mandatory = $true,
            ValueFromPipeline = $true
        )]
        [Parameter(
            ParameterSetName = 'Set',
            Mandatory = $true,
            ValueFromPipeline = $true
        )]
        [JumpCloud.SDK.V2.Models.IUserGroupGraphManagementReq]$Body,
        [Parameter(
            ParameterSetName = 'SetViaIdentityExpanded',
            Mandatory = $true
        )]
        [Parameter(
            ParameterSetName = 'SetExpanded',
            Mandatory = $true
        )]
        [System.String]$Id,
        [Parameter(
            ParameterSetName = 'SetViaIdentityExpanded',
            Mandatory = $true
        )]
        [Parameter(
            ParameterSetName = 'SetExpanded',
            Mandatory = $true
        )]
        [System.String]$Op,
        [Parameter(
            ParameterSetName = 'SetViaIdentityExpanded',
            Mandatory = $true
        )]
        [Parameter(
            ParameterSetName = 'SetExpanded',
            Mandatory = $true
        )]
        [System.String]$Type,
        [Parameter(ParameterSetName = 'SetViaIdentityExpanded')]
        [Parameter(ParameterSetName = 'SetExpanded')]
        [JumpCloud.SDK.V2.Models.IUserGroupGraphManagementReqAttributes]$Attributes
    )
    Begin
    {
        $Results = @()
    }
    Process
    {
        $Results = Set-JcSdkUserGroupAssociationUserGroupGraphUserGroupAssociation @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}
