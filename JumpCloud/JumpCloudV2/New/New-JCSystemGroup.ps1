Function New-JCSystemGroup
{
    #Requires -modules JumpCloud.SDK.V2
    [OutputType([JumpCloud.SDK.V2.Models.ISystemGroup])]
    [CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
        [Parameter(
            ParameterSetName = 'Create',
            Mandatory = $true,
            ValueFromPipeline = $true
        )]
        [JumpCloud.SDK.V2.Models.ISystemGroupData]$Body,
        [Parameter(
            ParameterSetName = 'CreateExpanded',
            Mandatory = $true
        )]
        [System.String]$Name
    )
    Begin
    {
        $Results = @()
    }
    Process
    {
        $Results = New-JcSdkSystemGroup @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}
