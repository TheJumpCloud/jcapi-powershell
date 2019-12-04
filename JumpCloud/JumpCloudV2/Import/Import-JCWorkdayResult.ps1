#Requires -modules JumpCloudApiSdkV2
Function Import-JCWorkdayResult
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
		[JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentity]$InputObject,
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
        $Results = Import-JcSdkWorkdayResult @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}
