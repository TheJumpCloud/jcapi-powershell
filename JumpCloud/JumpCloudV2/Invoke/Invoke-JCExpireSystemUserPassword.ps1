Function Invoke-JCExpireSystemUserPassword
{
    #Requires -modules JumpCloud.SDK.V1
    [CmdletBinding(DefaultParameterSetName = 'Post')]
    Param(
        [Parameter(
            ParameterSetName = 'Post',
            Mandatory = $true
        )]
        [System.String]$Id,
        [Parameter(
            ParameterSetName = 'PostViaIdentity',
            Mandatory = $true,
            ValueFromPipeline = $true
        )]
        [JumpCloud.SDK.V1.Models.IJumpCloudApIsIdentity]$InputObject,
        [Parameter(ParameterSetName = 'Post')]
        [Parameter(ParameterSetName = 'PostViaIdentity')]
        [Alias(cf)][System.Management.Automation.SwitchParameter]$Confirm,
        [Parameter(ParameterSetName = 'Post')]
        [Parameter(ParameterSetName = 'PostViaIdentity')]
        [Alias(wi)][System.Management.Automation.SwitchParameter]$WhatIf,
        [System.Boolean]$Paginate = $true
    )
    Begin
    {
$Results = @()
    }
    Process
    {
$Results = Import-JcSdkWorkdayImportWorkdayResult @PSBoundParameters
    }
    End
    {
Return $Results
    }
}
