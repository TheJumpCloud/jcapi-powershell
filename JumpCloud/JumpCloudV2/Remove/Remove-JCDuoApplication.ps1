Function Remove-JCDuoApplication
{
    #Requires -modules JumpCloud.SDK.V2
    [OutputType([JumpCloud.SDK.V2.Models.IDuoApplication])]
    [CmdletBinding(DefaultParameterSetName='Delete', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
        [Parameter(
            ParameterSetName = 'Delete',
            Mandatory = $true
        )]
        [System.String]$AccountId,
        [Parameter(
            ParameterSetName = 'Delete',
            Mandatory = $true
        )]
        [System.String]$ApplicationId,
        [Parameter(
            ParameterSetName = 'DeleteViaIdentity',
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
        $Results = Remove-JcSdkDuoApplication @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}
