Function Remove-JCSambaDomainLdapServerSambaDomain
{
    #Requires -modules JumpCloud.SDK.V2
    [CmdletBinding(DefaultParameterSetName = 'Delete')]
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
        [System.String]$ContentType,
        [Parameter(ParameterSetName = 'Delete')]
        [Parameter(ParameterSetName = 'DeleteViaIdentity')]
        [Alias(cf)][System.Management.Automation.SwitchParameter]$Confirm,
        [Parameter(ParameterSetName = 'Delete')]
        [Parameter(ParameterSetName = 'DeleteViaIdentity')]
        [Alias(wi)][System.Management.Automation.SwitchParameter]$WhatIf,
        [System.Boolean]$Paginate = $true
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
