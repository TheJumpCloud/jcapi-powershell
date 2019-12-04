#Requires -modules JumpCloudApiSdkV2
Function New-JCPolicy
{
    [CmdletBinding(DefaultParameterSetName = 'CreateExpanded')]
	Param(
		[Parameter(
			ParameterSetName = 'Create',
			Mandatory = $true,
			ValueFromPipeline = $true
		)]
		[JumpCloudApiSdkV2.Models.IPolicyRequest]$Body,
		[Parameter(
			ParameterSetName = 'CreateExpanded',
			Mandatory = $true
		)]
		[System.String]$Name,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.String]$TemplateId,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[JumpCloudApiSdkV2.Models.IPolicyValue[]]$Values,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[Parameter(ParameterSetName = 'Create')]
		[Alias(wi)][System.Management.Automation.SwitchParameter]$WhatIf,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[Parameter(ParameterSetName = 'Create')]
		[Alias(cf)][System.Management.Automation.SwitchParameter]$Confirm,
		[System.Boolean]$Paginate = $true
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
