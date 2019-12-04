#Requires -modules JumpCloudApiSdkV2
Function New-JCGSuiteTranslationRule
{
    [CmdletBinding(DefaultParameterSetName = 'CreateExpanded')]
	Param(
		[Parameter(
			ParameterSetName = 'CreateExpanded',
			Mandatory = $true
		)],
		[Parameter(
			ParameterSetName = 'Create',
			Mandatory = $true
		)],
		
		,
		[,
		System.String,
		]$,
		GsuiteId,
		[Parameter(
			ParameterSetName = 'CreateViaIdentityExpanded',
			Mandatory = $true,
			ValueFromPipeline = $true
		)],
		[Parameter(
			ParameterSetName = 'CreateViaIdentity',
			Mandatory = $true,
			ValueFromPipeline = $true
		)],
		
		,
		[,
		JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentity,
		]$,
		InputObject,
		[Parameter(
			ParameterSetName = 'CreateViaIdentity',
			Mandatory = $true,
			ValueFromPipeline = $true
		)],
		[Parameter(
			ParameterSetName = 'Create',
			Mandatory = $true,
			ValueFromPipeline = $true
		)],
		
		,
		[,
		JumpCloudApiSdkV2.Models.IGSuiteTranslationRuleRequest,
		]$,
		Body,
		[Parameter(ParameterSetName = 'CreateViaIdentityExpanded')],
		[Parameter(ParameterSetName = 'CreateExpanded')],
		
		,
		[,
		System.String,
		]$,
		BuiltIn,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[Parameter(ParameterSetName = 'Create')]
		[Parameter(ParameterSetName = 'CreateViaIdentityExpanded')]
		[Parameter(ParameterSetName = 'CreateViaIdentity')]
		[Alias(cf)][System.Management.Automation.SwitchParameter]$Confirm,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[Parameter(ParameterSetName = 'Create')]
		[Parameter(ParameterSetName = 'CreateViaIdentityExpanded')]
		[Parameter(ParameterSetName = 'CreateViaIdentity')]
		[Alias(wi)][System.Management.Automation.SwitchParameter]$WhatIf,
		[System.Boolean]$Paginate = $true
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
