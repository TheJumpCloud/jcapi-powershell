Function Update-JCBulkJobRequestBulkUser
{
    #Requires -modules JumpCloud.SDK.V2
    [OutputType([System.String])]
    [CmdletBinding(DefaultParameterSetName='Patch', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
        [Parameter(
            ParameterSetName = 'Patch',
            Mandatory = $true,
            ValueFromPipeline = $true
        )]
        [JumpCloud.SDK.V2.Models.IBulkUserUpdate[]]$Body
    )
    Begin
    {
        $Results = @()
    }
    Process
    {
        $Results = Update-JcSdkBulkJobRequestBulkUser @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}
