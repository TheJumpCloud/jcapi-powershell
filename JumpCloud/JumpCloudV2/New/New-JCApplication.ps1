#Requires -modules JumpCloud.SDK.V1
Function New-JCApplication
{
    [CmdletBinding(DefaultParameterSetName = 'CreateExpanded')]
	Param(
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[Parameter(ParameterSetName = 'Create')]
		[System.String]$Accept,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[Parameter(ParameterSetName = 'Create')]
		[System.String]$ContentType,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[Parameter(ParameterSetName = 'Create')]
		[System.String]$XOrgId,
		[Parameter(
			ParameterSetName = 'Create',
			Mandatory = $true,
			ValueFromPipeline = $true
		)]
		[JumpCloud.SDK.V1.Models.IApplication]$Body,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.Management.Automation.SwitchParameter]$Beta,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[JumpCloud.SDK.V1.Models.IApplicationConfig]$Config,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.String]$Created,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.String]$DisplayLabel,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.String]$DisplayName,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.String]$Id,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.String]$LearnMore,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.String]$Name,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.String]$Organization,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.String]$SsoUrl,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[Parameter(ParameterSetName = 'Create')]
		[Alias(cf)][System.Management.Automation.SwitchParameter]$Confirm,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[Parameter(ParameterSetName = 'Create')]
		[Alias(wi)][System.Management.Automation.SwitchParameter]$WhatIf,
		[System.Boolean]$Paginate = $true
	)
    Begin
    {
        $Results = @()
    }
    Process
    {
        $Results = New-JcSdkApplication @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}
