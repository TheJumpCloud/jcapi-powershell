Function Remove-JCApplication
{
    #Requires -modules JumpCloud.SDK.V1
    [OutputType([JumpCloud.SDK.V1.Models.IApplication])]
    [CmdletBinding(DefaultParameterSetName='Delete', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
        [Parameter(
            ParameterSetName = 'Delete',
            Mandatory = $true
        )]
        [System.String]$Id,
        [Parameter(
            ParameterSetName = 'DeleteViaIdentity',
            Mandatory = $true,
            ValueFromPipeline = $true
        )]
        [JumpCloud.SDK.V1.Models.IJumpCloudApIsIdentity]$InputObject,
        [Parameter(ParameterSetName = 'Delete')]
        [Parameter(ParameterSetName = 'DeleteViaIdentity')]
        [System.String]$Accept,
        [Parameter(ParameterSetName = 'Delete')]
        [Parameter(ParameterSetName = 'DeleteViaIdentity')]
        [System.String]$ContentType,
        [Parameter(ParameterSetName = 'Delete')]
        [Parameter(ParameterSetName = 'DeleteViaIdentity')]
        [System.String]$XOrgId
    )
    Begin
    {
        $Results = @()
    }
    Process
    {
        $Results = Remove-JcSdkApplication @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}
