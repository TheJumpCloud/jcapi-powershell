Function New-JCRadiusServer
{
    #Requires -modules JumpCloud.SDK.V1
    [OutputType([JumpCloud.SDK.V1.Models.IRadiusserver])]
    [CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
        [Parameter(
            ParameterSetName = 'Create',
            Mandatory = $true,
            ValueFromPipeline = $true
        )]
        [JumpCloud.SDK.V1.Models.IRadiusserverpost]$Body,
        [Parameter(
            ParameterSetName = 'CreateExpanded',
            Mandatory = $true
        )]
        [System.String]$Name,
        [Parameter(
            ParameterSetName = 'CreateExpanded',
            Mandatory = $true
        )]
        [System.String]$NetworkSourceIP,
        [Parameter(
            ParameterSetName = 'CreateExpanded',
            Mandatory = $true
        )]
        [System.String]$SharedSecret,
        [Parameter(ParameterSetName = 'CreateExpanded')]
        [System.String]$Mfa,
        [Parameter(ParameterSetName = 'CreateExpanded')]
        [System.String[]]$TagNames,
        [Parameter(ParameterSetName = 'CreateExpanded')]
        [System.String]$UserLockoutAction,
        [Parameter(ParameterSetName = 'CreateExpanded')]
        [System.String]$UserPasswordExpirationAction
    )
    Begin
    {
        $Results = @()
    }
    Process
    {
        $Results = New-JcSdkRadiusServer @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}
