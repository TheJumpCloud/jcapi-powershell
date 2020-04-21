Function New-JCBulkJobRequestBulkUser
{
    #Requires -modules JumpCloud.SDK.V2
    [OutputType([System.String])]
    [CmdletBinding(DefaultParameterSetName='Create', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
        [Parameter(
            ParameterSetName = 'Create',
            Mandatory = $true,
            ValueFromPipeline = $true
        )]
        [JumpCloud.SDK.V2.Models.IBulkUserCreate[]]$Body
    )
    Begin
    {
        $Results = @()
    }
    Process
    {
        $Results = New-JcSdkBulkJobRequestBulkUser @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}
