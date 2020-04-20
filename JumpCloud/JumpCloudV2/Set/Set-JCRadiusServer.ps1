#Requires -modules JumpCloud.SDK.V1
Function Set-JCRadiusServer
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
        [JumpCloud.SDK.V1.Models.IPathsKeqea5RadiusserversIdPutRequestbodyContentApplicationJsonSchema]$Body,
        [Parameter(
            ParameterSetName = 'PutViaIdentityExpanded',
            Mandatory = $true
        )]
        [Parameter(
            ParameterSetName = 'PutExpanded',
            Mandatory = $true
        )]
        [System.String]$Name,
        [Parameter(
            ParameterSetName = 'PutViaIdentityExpanded',
            Mandatory = $true
        )]
        [Parameter(
            ParameterSetName = 'PutExpanded',
            Mandatory = $true
        )]
        [System.String]$NetworkSourceIP,
        [Parameter(ParameterSetName = 'PutViaIdentityExpanded')]
        [Parameter(ParameterSetName = 'PutExpanded')]
        [System.String]$Mfa,
        [Parameter(ParameterSetName = 'PutViaIdentityExpanded')]
        [Parameter(ParameterSetName = 'PutExpanded')]
        [System.String[]]$Tags,
        [Parameter(ParameterSetName = 'PutViaIdentityExpanded')]
        [Parameter(ParameterSetName = 'PutExpanded')]
        [System.String]$UserLockoutAction,
        [Parameter(ParameterSetName = 'PutViaIdentityExpanded')]
        [Parameter(ParameterSetName = 'PutExpanded')]
        [System.String]$UserPasswordExpirationAction,
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
$Results = Set-JcSdkRadiusServer @PSBoundParameters
    }
    End
    {
Return $Results
    }
}
