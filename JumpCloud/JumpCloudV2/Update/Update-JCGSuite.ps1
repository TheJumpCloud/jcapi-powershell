Function Update-JCGSuite
{
    #Requires -modules JumpCloud.SDK.V2
    [OutputType([JumpCloud.SDK.V2.Models.IGsuiteOutput])]
    [CmdletBinding(DefaultParameterSetName='PatchExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
        [Parameter(
            ParameterSetName = 'PatchExpanded',
            Mandatory = $true
        )]
        [Parameter(
            ParameterSetName = 'Patch',
            Mandatory = $true
        )]
        [System.String]$Id,
        [Parameter(
            ParameterSetName = 'PatchViaIdentityExpanded',
            Mandatory = $true,
            ValueFromPipeline = $true
        )]
        [Parameter(
            ParameterSetName = 'PatchViaIdentity',
            Mandatory = $true,
            ValueFromPipeline = $true
        )]
        [JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity]$InputObject,
        [Parameter(
            ParameterSetName = 'PatchViaIdentity',
            Mandatory = $true,
            ValueFromPipeline = $true
        )]
        [Parameter(
            ParameterSetName = 'Patch',
            Mandatory = $true,
            ValueFromPipeline = $true
        )]
        [JumpCloud.SDK.V2.Models.IGsuitePatchInput]$Body,
        [Parameter(ParameterSetName = 'PatchViaIdentityExpanded')]
        [Parameter(ParameterSetName = 'PatchExpanded')]
        [System.String]$UserLockoutAction,
        [Parameter(ParameterSetName = 'PatchViaIdentityExpanded')]
        [Parameter(ParameterSetName = 'PatchExpanded')]
        [System.String]$UserPasswordExpirationAction
    )
    Begin
    {
        $Results = @()
    }
    Process
    {
        $Results = Update-JcSdkGSuite @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}
