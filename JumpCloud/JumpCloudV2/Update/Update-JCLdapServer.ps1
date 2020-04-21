Function Update-JCLdapServer
{
    #Requires -modules JumpCloud.SDK.V2
    [OutputType([JumpCloud.SDK.V2.Models.IPaths1Dvt4UsLdapserversIdPatchResponses200ContentApplicationJsonSchema], [System.String])]
    [CmdletBinding(DefaultParameterSetName='PatchExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
        [Parameter(ParameterSetName = 'PatchViaIdentityExpanded')]
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
        [Parameter(ParameterSetName = 'PatchExpanded')]
        [Parameter(ParameterSetName = 'PatchViaIdentityExpanded')]
        [Parameter(ParameterSetName = 'Patch')]
        [Parameter(ParameterSetName = 'PatchViaIdentity')]
        [System.String]$XApiKey,
        [Parameter(ParameterSetName = 'PatchExpanded')]
        [Parameter(ParameterSetName = 'PatchViaIdentityExpanded')]
        [Parameter(ParameterSetName = 'Patch')]
        [Parameter(ParameterSetName = 'PatchViaIdentity')]
        [System.String]$XOrgId,
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
        [JumpCloud.SDK.V2.Models.IPaths1Ka5IlhLdapserversIdPatchRequestbodyContentApplicationJsonSchema]$Body,
        [Parameter(ParameterSetName = 'PatchExpanded')]
        [System.String]$Id1,
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
        $Results = Update-JcSdkLdapServer @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}
