Function New-JCGSuiteTranslationRule
{
    #Requires -modules JumpCloud.SDK.V2
    [OutputType([JumpCloud.SDK.V2.Models.IGSuiteTranslationRule])]
    [CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
        [Parameter(
            ParameterSetName = 'CreateExpanded',
            Mandatory = $true
        )]
        [Parameter(
            ParameterSetName = 'Create',
            Mandatory = $true
        )]
        [System.String]$GsuiteId,
        [Parameter(
            ParameterSetName = 'CreateViaIdentityExpanded',
            Mandatory = $true,
            ValueFromPipeline = $true
        )]
        [Parameter(
            ParameterSetName = 'CreateViaIdentity',
            Mandatory = $true,
            ValueFromPipeline = $true
        )]
        [JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity]$InputObject,
        [Parameter(
            ParameterSetName = 'CreateViaIdentity',
            Mandatory = $true,
            ValueFromPipeline = $true
        )]
        [Parameter(
            ParameterSetName = 'Create',
            Mandatory = $true,
            ValueFromPipeline = $true
        )]
        [JumpCloud.SDK.V2.Models.IGSuiteTranslationRuleRequest]$Body,
        [Parameter(ParameterSetName = 'CreateViaIdentityExpanded')]
        [Parameter(ParameterSetName = 'CreateExpanded')]
        [System.String]$BuiltIn
    )
    Begin
    {
        $Results = @()
    }
    Process
    {
        $Results = New-JcSdkGSuiteTranslationRule @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}
