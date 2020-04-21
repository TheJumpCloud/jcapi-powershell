Function New-JCPolicy
{
    #Requires -modules JumpCloud.SDK.V2
    [OutputType([JumpCloud.SDK.V2.Models.IPolicyWithDetails])]
    [CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
        [Parameter(
            ParameterSetName = 'Create',
            Mandatory = $true,
            ValueFromPipeline = $true
        )]
        [JumpCloud.SDK.V2.Models.IPolicyRequest]$Body,
        [Parameter(
            ParameterSetName = 'CreateExpanded',
            Mandatory = $true
        )]
        [System.String]$Name,
        [Parameter(ParameterSetName = 'CreateExpanded')]
        [System.String]$TemplateId,
        [Parameter(ParameterSetName = 'CreateExpanded')]
        [JumpCloud.SDK.V2.Models.IPolicyValue[]]$Values
    )
    Begin
    {
        $Results = @()
    }
    Process
    {
        $Results = New-JcSdkPolicy @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}
