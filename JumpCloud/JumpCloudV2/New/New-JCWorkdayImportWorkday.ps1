Function New-JCWorkdayImportWorkday
{
    #Requires -modules JumpCloud.SDK.V2
    [OutputType([JumpCloud.SDK.V2.Models.IWorkdayOutput])]
    [CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
        [Parameter(
            ParameterSetName = 'Create',
            Mandatory = $true,
            ValueFromPipeline = $true
        )]
        [JumpCloud.SDK.V2.Models.IWorkdayInput]$Body,
        [Parameter(ParameterSetName = 'CreateExpanded')]
        [System.String]$BasicPassword,
        [Parameter(ParameterSetName = 'CreateExpanded')]
        [System.String]$BasicUsername,
        [Parameter(ParameterSetName = 'CreateExpanded')]
        [System.String]$Name,
        [Parameter(ParameterSetName = 'CreateExpanded')]
        [System.String]$OauthCode,
        [Parameter(ParameterSetName = 'CreateExpanded')]
        [System.String]$ReportUrl
    )
    Begin
    {
        $Results = @()
    }
    Process
    {
        $Results = New-JcSdkWorkdayImportWorkday @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}
