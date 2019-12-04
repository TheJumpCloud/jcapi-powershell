#Requires -modules JumpCloudApiSdkV1
Function New-JCSshKey
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
		Id,
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
		JumpCloudApiSdkV1.Models.IJumpCloudApIsIdentity,
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
		JumpCloudApiSdkV1.Models.ISshkeypost,
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
		Name,
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
		PublicKey,
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
        $Results = New-JcSdkSshKey @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}
