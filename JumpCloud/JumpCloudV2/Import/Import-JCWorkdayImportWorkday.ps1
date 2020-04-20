#Requires -modules JumpCloud.SDK.V2
Function Import-JCWorkdayImportWorkday
{
    [CmdletBinding(DefaultParameterSetName = 'Import')]
    Param(
        [Parameter(
            ParameterSetName = 'Import',
            Mandatory = $true
        )]
        [System.String]$WorkdayId,
        [Parameter(
            ParameterSetName = 'ImportViaIdentity',
            Mandatory = $true,
            ValueFromPipeline = $true
        )]
        [JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity]$InputObject,
        [Parameter(
            ParameterSetName = 'Import',
            Mandatory = $true,
            ValueFromPipeline = $true
        )]
        [Parameter(
            ParameterSetName = 'ImportViaIdentity',
            Mandatory = $true,
            ValueFromPipeline = $true
        )]
        [JumpCloud.SDK.V2.Models.IBulkUserCreate[]]$Body,
        [Parameter(ParameterSetName = 'Import')]
        [Parameter(ParameterSetName = 'ImportViaIdentity')]
        [Alias(cf)][System.Management.Automation.SwitchParameter]$Confirm,
        [Parameter(ParameterSetName = 'Import')]
        [Parameter(ParameterSetName = 'ImportViaIdentity')]
        [Alias(wi)][System.Management.Automation.SwitchParameter]$WhatIf,
        [System.Boolean]$Paginate = $true
    )
    Begin
    {
$Results = @()
    }
    Process
    {
$Results = Import-JcSdkWorkdayImportWorkday @PSBoundParameters
    }
    End
    {
Return $Results
    }
}
