#Requires -modules JumpCloud.SDK.V2
Function Import-JCWorkdayImportWorkdayResult
{
    [CmdletBinding(DefaultParameterSetName = 'Import')]
    Param(
        [Parameter(
            ParameterSetName = 'Import',
            Mandatory = $true
        )]
        [System.String]$Id,
        [Parameter(
            ParameterSetName = 'Import',
            Mandatory = $true
        )]
        [System.String]$JobId,
        [Parameter(
            ParameterSetName = 'ImportViaIdentity',
            Mandatory = $true,
            ValueFromPipeline = $true
        )]
        [JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity]$InputObject,
        [Parameter(ParameterSetName = 'Import')]
        [Parameter(ParameterSetName = 'ImportViaIdentity')]
        [System.Int32]$Limit,
        [Parameter(ParameterSetName = 'Import')]
        [Parameter(ParameterSetName = 'ImportViaIdentity')]
        [System.Int32]$Skip,
        [System.Boolean]$Paginate = $true
    )
    Begin
    {
$Results = @()
    }
    Process
    {
$Results = Import-JcSdkWorkdayImportWorkdayResult @PSBoundParameters
    }
    End
    {
Return $Results
    }
}
