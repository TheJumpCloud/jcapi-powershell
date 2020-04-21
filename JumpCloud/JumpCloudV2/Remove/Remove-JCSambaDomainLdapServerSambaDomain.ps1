Function Remove-JCSambaDomainLdapServerSambaDomain
{
    #Requires -modules JumpCloud.SDK.V2
    [OutputType([System.String])]
    [CmdletBinding(DefaultParameterSetName='Delete', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
        [Parameter(
            ParameterSetName = 'Delete',
            Mandatory = $true
        )]
        [System.String]$Id,
        [Parameter(
            ParameterSetName = 'Delete',
            Mandatory = $true
        )]
        [System.String]$LdapserverId,
        [Parameter(
            ParameterSetName = 'DeleteViaIdentity',
            Mandatory = $true,
            ValueFromPipeline = $true
        )]
        [JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity]$InputObject,
        [Parameter(ParameterSetName = 'Delete')]
        [Parameter(ParameterSetName = 'DeleteViaIdentity')]
        [System.String]$Accept,
        [Parameter(ParameterSetName = 'Delete')]
        [Parameter(ParameterSetName = 'DeleteViaIdentity')]
        [System.String]$ContentType
    )
    Begin
    {
        $Results = @()
    }
    Process
    {
        $Results = Remove-JcSdkSambaDomainLdapServerSambaDomain @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}
