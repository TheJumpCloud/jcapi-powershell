Function Unlock-JCSystemUser
{
    #Requires -modules JumpCloud.SDK.V1
    [OutputType([System.String])]
    [CmdletBinding(DefaultParameterSetName='Unlock', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
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
        [JumpCloud.SDK.V1.Models.IJumpCloudApIsIdentity]$InputObject
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
