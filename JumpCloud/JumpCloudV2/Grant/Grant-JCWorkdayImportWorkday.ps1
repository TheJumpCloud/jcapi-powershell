Function Grant-JCWorkdayImportWorkday
{
    #Requires -modules JumpCloud.SDK.V2
    [OutputType([System.Boolean])]
    [CmdletBinding(DefaultParameterSetName='AuthorizeExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
        [Parameter(
            ParameterSetName = 'AuthorizeExpanded',
            Mandatory = $true
        )]
        [Parameter(
            ParameterSetName = 'Authorize',
            Mandatory = $true
        )]
        [System.String]$WorkdayId,
        [Parameter(
            ParameterSetName = 'AuthorizeViaIdentityExpanded',
            Mandatory = $true,
            ValueFromPipeline = $true
        )]
        [Parameter(
            ParameterSetName = 'AuthorizeViaIdentity',
            Mandatory = $true,
            ValueFromPipeline = $true
        )]
        [JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity]$InputObject,
        [Parameter(
            ParameterSetName = 'AuthorizeViaIdentity',
            Mandatory = $true,
            ValueFromPipeline = $true
        )]
        [Parameter(
            ParameterSetName = 'Authorize',
            Mandatory = $true,
            ValueFromPipeline = $true
        )]
        [JumpCloud.SDK.V2.Models.IAuthInputObject]$Body,
        [Parameter(ParameterSetName = 'AuthorizeViaIdentityExpanded')]
        [Parameter(ParameterSetName = 'AuthorizeExpanded')]
        [System.String]$BasicPassword,
        [Parameter(ParameterSetName = 'AuthorizeViaIdentityExpanded')]
        [Parameter(ParameterSetName = 'AuthorizeExpanded')]
        [System.String]$BasicUsername,
        [Parameter(ParameterSetName = 'AuthorizeViaIdentityExpanded')]
        [Parameter(ParameterSetName = 'AuthorizeExpanded')]
        [System.String]$OauthCode
    )
    Begin
    {
        $Results = @()
    }
    Process
    {
        $Results = Grant-JcSdkWorkdayImportWorkday @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}
