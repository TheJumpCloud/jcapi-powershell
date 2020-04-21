Function Set-JCSystem
{
    #Requires -modules JumpCloud.SDK.V1
    [OutputType([JumpCloud.SDK.V1.Models.IJcSystem])]
    [CmdletBinding(DefaultParameterSetName='PutExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
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
        [JumpCloud.SDK.V1.Models.ISystemput]$Body,
        [Parameter(ParameterSetName = 'PutViaIdentityExpanded')]
        [Parameter(ParameterSetName = 'PutExpanded')]
        [JumpCloud.SDK.V1.Models.ISystemputAgentBoundMessagesItem[]]$AgentBoundMessages,
        [Parameter(ParameterSetName = 'PutViaIdentityExpanded')]
        [Parameter(ParameterSetName = 'PutExpanded')]
        [System.Management.Automation.SwitchParameter]$AllowMultiFactorAuthentication,
        [Parameter(ParameterSetName = 'PutViaIdentityExpanded')]
        [Parameter(ParameterSetName = 'PutExpanded')]
        [System.Management.Automation.SwitchParameter]$AllowPublicKeyAuthentication,
        [Parameter(ParameterSetName = 'PutViaIdentityExpanded')]
        [Parameter(ParameterSetName = 'PutExpanded')]
        [System.Management.Automation.SwitchParameter]$AllowSshPasswordAuthentication,
        [Parameter(ParameterSetName = 'PutViaIdentityExpanded')]
        [Parameter(ParameterSetName = 'PutExpanded')]
        [System.Management.Automation.SwitchParameter]$AllowSshRootLogin,
        [Parameter(ParameterSetName = 'PutViaIdentityExpanded')]
        [Parameter(ParameterSetName = 'PutExpanded')]
        [System.String]$DisplayName,
        [Parameter(ParameterSetName = 'PutViaIdentityExpanded')]
        [Parameter(ParameterSetName = 'PutExpanded')]
        [System.String[]]$Tags
    )
    Begin
    {
        $Results = @()
    }
    Process
    {
        $Results = Set-JcSdkSystem @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}
