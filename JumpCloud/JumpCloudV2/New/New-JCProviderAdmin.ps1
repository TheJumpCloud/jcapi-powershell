#Requires -modules JumpCloudApiSdkV2
Function New-JCProviderAdmin
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
		ProviderId,
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
		JumpCloudApiSdkV2.Models.IProviderAdminReq,
		]$,
		Body,
		[Parameter(
			ParameterSetName = 'CreateViaIdentityExpanded',
			Mandatory = $true
		)],
		[Parameter(
			ParameterSetName = 'CreateExpanded',
			Mandatory = $true
		)],
		
		,
		[,
		System.String,
		]$,
		Email,
		[Parameter(ParameterSetName = 'CreateViaIdentityExpanded')],
		[Parameter(ParameterSetName = 'CreateExpanded')],
		
		,
		[,
		System.Management.Automation.SwitchParameter,
		]$,
		EnableMultiFactor,
		[Parameter(ParameterSetName = 'CreateViaIdentityExpanded')],
		[Parameter(ParameterSetName = 'CreateExpanded')],
		
		,
		[,
		System.String,
		]$,
		Firstname,
		[Parameter(ParameterSetName = 'CreateViaIdentityExpanded')],
		[Parameter(ParameterSetName = 'CreateExpanded')],
		
		,
		[,
		System.String,
		]$,
		Lastname,
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
        $Results = New-JcSdkProviderAdmin @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}
