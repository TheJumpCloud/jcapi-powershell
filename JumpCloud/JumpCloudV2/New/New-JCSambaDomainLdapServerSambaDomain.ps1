Function New-JCSambaDomainLdapServerSambaDomain
{
    #Requires -modules JumpCloud.SDK.V2
    [OutputType([JumpCloud.SDK.V2.Models.ISambaDomainOutput])]
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
        [System.String]$LdapserverId,
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
        [Parameter(ParameterSetName = 'CreateExpanded')]
        [Parameter(ParameterSetName = 'Create')]
        [Parameter(ParameterSetName = 'CreateViaIdentityExpanded')]
        [Parameter(ParameterSetName = 'CreateViaIdentity')]
        [System.String]$Accept,
        [Parameter(ParameterSetName = 'CreateExpanded')]
        [Parameter(ParameterSetName = 'Create')]
        [Parameter(ParameterSetName = 'CreateViaIdentityExpanded')]
        [Parameter(ParameterSetName = 'CreateViaIdentity')]
        [System.String]$ContentType,
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
        [JumpCloud.SDK.V2.Models.ISambaDomainInput]$Body,
        [Parameter(
            ParameterSetName = 'CreateViaIdentityExpanded',
            Mandatory = $true
        )]
        [Parameter(
            ParameterSetName = 'CreateExpanded',
            Mandatory = $true
        )]
        [System.String]$Name,
        [Parameter(
            ParameterSetName = 'CreateViaIdentityExpanded',
            Mandatory = $true
        )]
        [Parameter(
            ParameterSetName = 'CreateExpanded',
            Mandatory = $true
        )]
        [System.String]$Sid
    )
    Begin
    {
        $Results = @()
    }
    Process
    {
        $Results = New-JcSdkSambaDomainLdapServerSambaDomain @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}
