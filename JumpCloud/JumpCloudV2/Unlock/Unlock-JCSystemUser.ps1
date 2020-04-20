Function Unlock-JCSystemUser
{
    #Requires -modules JumpCloud.SDK.V1
    [CmdletBinding(DefaultParameterSetName = 'Unlock')]
    Param(
        [Parameter(
            ParameterSetName = 'Unlock',
            Mandatory = $true
        )]
        [System.String]$Id,
        [Parameter(
            ParameterSetName = 'UnlockViaIdentity',
            Mandatory = $true,
            ValueFromPipeline = $true
        )]
        [JumpCloud.SDK.V1.Models.IJumpCloudApIsIdentity]$InputObject,
        [Parameter(ParameterSetName = 'Unlock')]
        [Parameter(ParameterSetName = 'UnlockViaIdentity')]
        [Alias(cf)][System.Management.Automation.SwitchParameter]$Confirm,
        [Parameter(ParameterSetName = 'Unlock')]
        [Parameter(ParameterSetName = 'UnlockViaIdentity')]
        [Alias(wi)][System.Management.Automation.SwitchParameter]$WhatIf,
        [System.Boolean]$Paginate = $true
    )
    Begin
    {
$Results = @()
    }
    Process
    {
$Results = Unlock-JcSdkSystemUser @PSBoundParameters
    }
    End
    {
Return $Results
    }
}
