#Requires -modules JumpCloudApiSdkV1
Function Set-JCApplication
{
    [CmdletBinding(DefaultParameterSetName = 'PutExpanded')]
	Param(
		[Parameter(ParameterSetName = 'PutViaIdentityExpanded')],
		[Parameter(
			ParameterSetName = 'PutExpanded',
			Mandatory = $true
		)],
		[Parameter(
			ParameterSetName = 'Put',
			Mandatory = $true
		)],
		
		,
		[,
		System.String,
		]$,
		Id,
		[Parameter(
			ParameterSetName = 'PutViaIdentityExpanded',
			Mandatory = $true,
			ValueFromPipeline = $true
		)],
		[Parameter(
			ParameterSetName = 'PutViaIdentity',
			Mandatory = $true,
			ValueFromPipeline = $true
		)],
		
		,
		[,
		JumpCloudApiSdkV1.Models.IJumpCloudApIsIdentity,
		]$,
		InputObject,
		[Parameter(ParameterSetName = 'PutExpanded')]
		[Parameter(ParameterSetName = 'PutViaIdentityExpanded')]
		[Parameter(ParameterSetName = 'Put')]
		[Parameter(ParameterSetName = 'PutViaIdentity')]
		[System.String]$Accept,
		[Parameter(ParameterSetName = 'PutExpanded')]
		[Parameter(ParameterSetName = 'PutViaIdentityExpanded')]
		[Parameter(ParameterSetName = 'Put')]
		[Parameter(ParameterSetName = 'PutViaIdentity')]
		[System.String]$ContentType,
		[Parameter(ParameterSetName = 'PutExpanded')]
		[Parameter(ParameterSetName = 'PutViaIdentityExpanded')]
		[Parameter(ParameterSetName = 'Put')]
		[Parameter(ParameterSetName = 'PutViaIdentity')]
		[System.String]$XOrgId,
		[Parameter(
			ParameterSetName = 'PutViaIdentity',
			Mandatory = $true,
			ValueFromPipeline = $true
		)],
		[Parameter(
			ParameterSetName = 'Put',
			Mandatory = $true,
			ValueFromPipeline = $true
		)],
		
		,
		[,
		JumpCloudApiSdkV1.Models.IApplication,
		]$,
		Body,
		[Parameter(ParameterSetName = 'PutViaIdentityExpanded')],
		[Parameter(ParameterSetName = 'PutExpanded')],
		
		,
		[,
		System.Management.Automation.SwitchParameter,
		]$,
		Beta,
		[Parameter(ParameterSetName = 'PutViaIdentityExpanded')],
		[Parameter(ParameterSetName = 'PutExpanded')],
		
		,
		[,
		JumpCloudApiSdkV1.Models.IApplicationConfig,
		]$,
		Config,
		[Parameter(ParameterSetName = 'PutViaIdentityExpanded')],
		[Parameter(ParameterSetName = 'PutExpanded')],
		
		,
		[,
		System.String,
		]$,
		DisplayLabel,
		[Parameter(ParameterSetName = 'PutViaIdentityExpanded')],
		[Parameter(ParameterSetName = 'PutExpanded')],
		
		,
		[,
		System.String,
		]$,
		DisplayName,
		[Parameter(ParameterSetName = 'PutExpanded')]
		[System.String]$Id1,
		[Parameter(ParameterSetName = 'PutViaIdentityExpanded')],
		[Parameter(ParameterSetName = 'PutExpanded')],
		
		,
		[,
		System.String,
		]$,
		LearnMore,
		[Parameter(ParameterSetName = 'PutViaIdentityExpanded')],
		[Parameter(ParameterSetName = 'PutExpanded')],
		
		,
		[,
		System.String,
		]$,
		Name,
		[Parameter(ParameterSetName = 'PutViaIdentityExpanded')],
		[Parameter(ParameterSetName = 'PutExpanded')],
		
		,
		[,
		System.String,
		]$,
		Organization,
		[Parameter(ParameterSetName = 'PutViaIdentityExpanded')],
		[Parameter(ParameterSetName = 'PutExpanded')],
		
		,
		[,
		System.String,
		]$,
		SsoUrl,
		[Parameter(ParameterSetName = 'PutExpanded')]
		[Parameter(ParameterSetName = 'PutViaIdentityExpanded')]
		[Parameter(ParameterSetName = 'Put')]
		[Parameter(ParameterSetName = 'PutViaIdentity')]
		[Alias(cf)][System.Management.Automation.SwitchParameter]$Confirm,
		[Parameter(ParameterSetName = 'PutExpanded')]
		[Parameter(ParameterSetName = 'PutViaIdentityExpanded')]
		[Parameter(ParameterSetName = 'Put')]
		[Parameter(ParameterSetName = 'PutViaIdentity')]
		[Alias(wi)][System.Management.Automation.SwitchParameter]$WhatIf,
		[System.Boolean]$Paginate = $true
	)
    Begin
    {
        $Results = @()
    }
    Process
    {
        $Results = Set-JcSdkApplication @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}
