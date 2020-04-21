Function Import-JCWorkdayImportWorkday
{
    #Requires -modules JumpCloud.SDK.V2
    [OutputType([System.String])]
    [CmdletBinding(DefaultParameterSetName='Import', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
        [Parameter(
            ParameterSetName = 'Import',
            Mandatory = $true
        )]
        [System.String]$WorkdayId,
        [Parameter(
            ParameterSetName = 'ImportViaIdentity',
            Mandatory = $true,
            ValueFromPipeline = $true
        )]
        [JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity]$InputObject,
        [Parameter(
            ParameterSetName = 'Import',
            Mandatory = $true,
            ValueFromPipeline = $true
        )]
        [Parameter(
            ParameterSetName = 'ImportViaIdentity',
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
        $Results = Import-JcSdkWorkdayImportWorkday @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}
