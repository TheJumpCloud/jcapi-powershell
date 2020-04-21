Function New-JCProviderAdmin
{
    #Requires -modules JumpCloud.SDK.V2
    [OutputType([JumpCloud.SDK.V2.Models.IAdministrator], [System.String])]
    [CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
        [Parameter(
            ParameterSetName = 'CreateExpanded',
            Mandatory = $true
        )]
        [Parameter(
            ParameterSetName = 'Create',
            Mandatory = $true
        )]
        [System.String]$ProviderId,
        [Parameter(
            ParameterSetName = 'CreateViaIdentityExpanded',
            Mandatory = $true,
            ValueFromPipeline = $true
        )]
        [Parameter(
            ParameterSetName = 'CreateViaIdentity',
            Mandatory = $true,
            ValueFromPipeline = $true
        )]
        [JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity]$InputObject,
        [Parameter(
            ParameterSetName = 'CreateViaIdentity',
            Mandatory = $true,
            ValueFromPipeline = $true
        )]
        [Parameter(
            ParameterSetName = 'Create',
            Mandatory = $true,
            ValueFromPipeline = $true
        )]
        [JumpCloud.SDK.V2.Models.IProviderAdminReq]$Body,
        [Parameter(
            ParameterSetName = 'CreateViaIdentityExpanded',
            Mandatory = $true
        )]
        [Parameter(
            ParameterSetName = 'CreateExpanded',
            Mandatory = $true
        )]
        [System.String]$Email,
        [Parameter(ParameterSetName = 'CreateViaIdentityExpanded')]
        [Parameter(ParameterSetName = 'CreateExpanded')]
        [System.Management.Automation.SwitchParameter]$EnableMultiFactor,
        [Parameter(ParameterSetName = 'CreateViaIdentityExpanded')]
        [Parameter(ParameterSetName = 'CreateExpanded')]
        [System.String]$Firstname,
        [Parameter(ParameterSetName = 'CreateViaIdentityExpanded')]
        [Parameter(ParameterSetName = 'CreateExpanded')]
        [System.String]$Lastname
    )
    Begin
    {
        $Results = @()
    }
    Process
    {
        $Results = New-JcSdkProviderAdmin @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}
