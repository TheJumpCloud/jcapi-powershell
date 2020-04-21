Function New-JCDuoAccount
{
    #Requires -modules JumpCloud.SDK.V2
    [OutputType([JumpCloud.SDK.V2.Models.IDuoAccount])]
    [CmdletBinding(DefaultParameterSetName='Create', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(

    )
    Begin
    {
        $Results = @()
    }
    Process
    {
        $Results = New-JcSdkDuoAccount @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}
