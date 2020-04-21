Function Reset-JCSystemUserMfa
{
    #Requires -modules JumpCloud.SDK.V1
    [OutputType([System.String])]
    [CmdletBinding(DefaultParameterSetName='ResetExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
        [Parameter(
            ParameterSetName = 'ResetExpanded',
            Mandatory = $true
        )]
        [Parameter(
            ParameterSetName = 'Reset',
            Mandatory = $true
        )]
        [System.String]$Id,
        [Parameter(
            ParameterSetName = 'ResetViaIdentityExpanded',
            Mandatory = $true,
            ValueFromPipeline = $true
        )]
        [Parameter(
            ParameterSetName = 'ResetViaIdentity',
            Mandatory = $true,
            ValueFromPipeline = $true
        )]
        [JumpCloud.SDK.V1.Models.IJumpCloudApIsIdentity]$InputObject,
        [Parameter(
            ParameterSetName = 'ResetViaIdentity',
            Mandatory = $true,
            ValueFromPipeline = $true
        )]
        [Parameter(
            ParameterSetName = 'Reset',
            Mandatory = $true,
            ValueFromPipeline = $true
        )]
        [JumpCloud.SDK.V1.Models.IPathsYhix24SystemusersIdResetmfaPostRequestbodyContentApplicationJsonSchema]$Body,
        [Parameter(ParameterSetName = 'ResetViaIdentityExpanded')]
        [Parameter(ParameterSetName = 'ResetExpanded')]
        [System.Management.Automation.SwitchParameter]$Exclusion,
        [Parameter(ParameterSetName = 'ResetViaIdentityExpanded')]
        [Parameter(ParameterSetName = 'ResetExpanded')]
        [System.DateTime]$ExclusionUntil
    )
    Begin
    {
        $Results = @()
    }
    Process
    {
        $Results = Reset-JcSdkSystemUserMfa @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}
