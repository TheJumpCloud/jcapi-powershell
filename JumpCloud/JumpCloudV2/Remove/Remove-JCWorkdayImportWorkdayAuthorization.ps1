Function Remove-JCWorkdayImportWorkdayAuthorization
{
    #Requires -modules JumpCloud.SDK.V2
    [OutputType([System.Boolean])]
    [CmdletBinding(DefaultParameterSetName='Remove', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
        [Parameter(
            ParameterSetName = 'Remove',
            Mandatory = $true
        )]
        [System.String]$WorkdayId,
        [Parameter(
            ParameterSetName = 'RemoveViaIdentity',
            Mandatory = $true,
            ValueFromPipeline = $true
        )]
        [JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity]$InputObject
    )
    Begin
    {
        $Results = @()
    }
    Process
    {
        $Results = Remove-JcSdkWorkdayImportWorkdayAuthorization @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}
