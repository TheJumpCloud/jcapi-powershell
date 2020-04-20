#Requires -modules JumpCloud.SDK.V1
Function Set-JCOrganization
{
    [CmdletBinding(DefaultParameterSetName = 'PutExpanded')]
    Param(
        [Parameter(
            ParameterSetName = 'PutExpanded',
            Mandatory = $true
        )]
        [Parameter(
            ParameterSetName = 'Put',
            Mandatory = $true
        )]
        [System.String]$Id,
        [Parameter(
            ParameterSetName = 'PutViaIdentityExpanded',
            Mandatory = $true,
            ValueFromPipeline = $true
        )]
        [Parameter(
            ParameterSetName = 'PutViaIdentity',
            Mandatory = $true,
            ValueFromPipeline = $true
        )]
        [JumpCloud.SDK.V1.Models.IJumpCloudApIsIdentity]$InputObject,
        [Parameter(
            ParameterSetName = 'PutViaIdentity',
            Mandatory = $true,
            ValueFromPipeline = $true
        )]
        [Parameter(
            ParameterSetName = 'Put',
            Mandatory = $true,
            ValueFromPipeline = $true
        )]
        [JumpCloud.SDK.V1.Models.IPaths1Vyp8HsOrganizationsIdPutRequestbodyContentApplicationJsonSchema]$Body,
        [Parameter(ParameterSetName = 'PutViaIdentityExpanded')]
        [Parameter(ParameterSetName = 'PutExpanded')]
        [JumpCloud.SDK.V1.Models.IOrganizationsettingsput]$Settings,
        [Parameter(ParameterSetName = 'PutExpanded')]
        [Parameter(ParameterSetName = 'Put')]
        [Parameter(ParameterSetName = 'PutViaIdentityExpanded')]
        [Parameter(ParameterSetName = 'PutViaIdentity')]
        [Alias(cf)][System.Management.Automation.SwitchParameter]$Confirm,
        [Parameter(ParameterSetName = 'PutExpanded')]
        [Parameter(ParameterSetName = 'Put')]
        [Parameter(ParameterSetName = 'PutViaIdentityExpanded')]
        [Parameter(ParameterSetName = 'PutViaIdentity')]
        [Alias(wi)][System.Management.Automation.SwitchParameter]$WhatIf,
        [System.Boolean]$Paginate = $true
    )
    Begin
    {
$Results = @()
    }
    Process
    {
$Results = Set-JcSdkOrganization @PSBoundParameters
    }
    End
    {
Return $Results
    }
}
