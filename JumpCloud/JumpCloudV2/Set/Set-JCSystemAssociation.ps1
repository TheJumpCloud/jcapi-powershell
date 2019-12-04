#Requires -modules JumpCloudApiSdkV2
Function Set-JCSystemAssociation
{
    [CmdletBinding(DefaultParameterSetName = 'SetExpanded')]
	Param(
		[Parameter(
			ParameterSetName = 'SetExpanded',
			Mandatory = $true
		)],
		[Parameter(
			ParameterSetName = 'Set',
			Mandatory = $true
		)],
		
		,
		[,
		System.String,
		]$,
		SystemId,
		[Parameter(
			ParameterSetName = 'SetViaIdentityExpanded',
			Mandatory = $true,
			ValueFromPipeline = $true
		)],
		[Parameter(
			ParameterSetName = 'SetViaIdentity',
			Mandatory = $true,
			ValueFromPipeline = $true
		)],
		
		,
		[,
		JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentity,
		]$,
		InputObject,
		[Parameter(ParameterSetName = 'SetExpanded')]
		[Parameter(ParameterSetName = 'Set')]
		[Parameter(ParameterSetName = 'SetViaIdentityExpanded')]
		[Parameter(ParameterSetName = 'SetViaIdentity')]
		[System.String]$Authorization,
		[Parameter(ParameterSetName = 'SetExpanded')]
		[Parameter(ParameterSetName = 'Set')]
		[Parameter(ParameterSetName = 'SetViaIdentityExpanded')]
		[Parameter(ParameterSetName = 'SetViaIdentity')]
		[System.String]$Date,
		[Parameter(
			ParameterSetName = 'SetViaIdentity',
			Mandatory = $true,
			ValueFromPipeline = $true
		)],
		[Parameter(
			ParameterSetName = 'Set',
			Mandatory = $true,
			ValueFromPipeline = $true
		)],
		
		,
		[,
		JumpCloudApiSdkV2.Models.ISystemGraphManagementReq,
		]$,
		Body,
		[Parameter(
			ParameterSetName = 'SetViaIdentityExpanded',
			Mandatory = $true
		)],
		[Parameter(
			ParameterSetName = 'SetExpanded',
			Mandatory = $true
		)],
		
		,
		[,
		System.String,
		]$,
		Id,
		[Parameter(
			ParameterSetName = 'SetViaIdentityExpanded',
			Mandatory = $true
		)],
		[Parameter(
			ParameterSetName = 'SetExpanded',
			Mandatory = $true
		)],
		
		,
		[,
		System.String,
		]$,
		Op,
		[Parameter(
			ParameterSetName = 'SetViaIdentityExpanded',
			Mandatory = $true
		)],
		[Parameter(
			ParameterSetName = 'SetExpanded',
			Mandatory = $true
		)],
		
		,
		[,
		System.String,
		]$,
		Type,
		[Parameter(ParameterSetName = 'SetViaIdentityExpanded')],
		[Parameter(ParameterSetName = 'SetExpanded')],
		
		,
		[,
		System.Management.Automation.SwitchParameter,
		]$,
		SudoEnabled,
		[Parameter(ParameterSetName = 'SetViaIdentityExpanded')],
		[Parameter(ParameterSetName = 'SetExpanded')],
		
		,
		[,
		System.Management.Automation.SwitchParameter,
		]$,
		SudoWithoutPassword,
		[Parameter(ParameterSetName = 'SetExpanded')]
		[Parameter(ParameterSetName = 'Set')]
		[Parameter(ParameterSetName = 'SetViaIdentityExpanded')]
		[Parameter(ParameterSetName = 'SetViaIdentity')]
		[Alias(cf)][System.Management.Automation.SwitchParameter]$Confirm,
		[Parameter(ParameterSetName = 'SetExpanded')]
		[Parameter(ParameterSetName = 'Set')]
		[Parameter(ParameterSetName = 'SetViaIdentityExpanded')]
		[Parameter(ParameterSetName = 'SetViaIdentity')]
		[Alias(wi)][System.Management.Automation.SwitchParameter]$WhatIf,
		[System.Boolean]$Paginate = $true
	)
    Begin
    {
        $Results = @()
    }
    Process
    {
        $Results = Set-JcSdkSystemAssociation @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}
