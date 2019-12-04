#Requires -modules JumpCloudApiSdkV1
Function Set-JCSystemUser
{
    [CmdletBinding(DefaultParameterSetName = 'PutExpanded')]
	Param(
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
		JumpCloudApiSdkV1.Models.ISystemuserput,
		]$,
		Body,
		[Parameter(ParameterSetName = 'PutViaIdentityExpanded')],
		[Parameter(ParameterSetName = 'PutExpanded')],
		
		,
		[,
		System.Management.Automation.SwitchParameter,
		]$,
		AccountLocked,
		[Parameter(ParameterSetName = 'PutViaIdentityExpanded')],
		[Parameter(ParameterSetName = 'PutExpanded')],
		
		,
		[,
		JumpCloudApiSdkV1.Models.ISystemuserputAddressesItem[],
		]$,
		Addresses,
		[Parameter(ParameterSetName = 'PutViaIdentityExpanded')],
		[Parameter(ParameterSetName = 'PutExpanded')],
		
		,
		[,
		System.Management.Automation.SwitchParameter,
		]$,
		AllowPublicKey,
		[Parameter(ParameterSetName = 'PutViaIdentityExpanded')],
		[Parameter(ParameterSetName = 'PutExpanded')],
		
		,
		[,
		JumpCloudApiSdkV1.Models.ISystemuserputAttributesItem[],
		]$,
		Attributes,
		[Parameter(ParameterSetName = 'PutViaIdentityExpanded')],
		[Parameter(ParameterSetName = 'PutExpanded')],
		
		,
		[,
		System.String,
		]$,
		Company,
		[Parameter(ParameterSetName = 'PutViaIdentityExpanded')],
		[Parameter(ParameterSetName = 'PutExpanded')],
		
		,
		[,
		System.String,
		]$,
		CostCenter,
		[Parameter(ParameterSetName = 'PutViaIdentityExpanded')],
		[Parameter(ParameterSetName = 'PutExpanded')],
		
		,
		[,
		System.String,
		]$,
		Department,
		[Parameter(ParameterSetName = 'PutViaIdentityExpanded')],
		[Parameter(ParameterSetName = 'PutExpanded')],
		
		,
		[,
		System.String,
		]$,
		Description,
		[Parameter(ParameterSetName = 'PutViaIdentityExpanded')],
		[Parameter(ParameterSetName = 'PutExpanded')],
		
		,
		[,
		System.String,
		]$,
		Displayname,
		[Parameter(ParameterSetName = 'PutViaIdentityExpanded')],
		[Parameter(ParameterSetName = 'PutExpanded')],
		
		,
		[,
		System.String,
		]$,
		Email,
		[Parameter(ParameterSetName = 'PutViaIdentityExpanded')],
		[Parameter(ParameterSetName = 'PutExpanded')],
		
		,
		[,
		System.String,
		]$,
		EmployeeIdentifier,
		[Parameter(ParameterSetName = 'PutViaIdentityExpanded')],
		[Parameter(ParameterSetName = 'PutExpanded')],
		
		,
		[,
		System.String,
		]$,
		EmployeeType,
		[Parameter(ParameterSetName = 'PutViaIdentityExpanded')],
		[Parameter(ParameterSetName = 'PutExpanded')],
		
		,
		[,
		System.Management.Automation.SwitchParameter,
		]$,
		EnableManagedUid,
		[Parameter(ParameterSetName = 'PutViaIdentityExpanded')],
		[Parameter(ParameterSetName = 'PutExpanded')],
		
		,
		[,
		System.Management.Automation.SwitchParameter,
		]$,
		EnableUserPortalMultifactor,
		[Parameter(ParameterSetName = 'PutViaIdentityExpanded')],
		[Parameter(ParameterSetName = 'PutExpanded')],
		
		,
		[,
		System.String,
		]$,
		ExternalDn,
		[Parameter(ParameterSetName = 'PutViaIdentityExpanded')],
		[Parameter(ParameterSetName = 'PutExpanded')],
		
		,
		[,
		System.String,
		]$,
		ExternalSourceType,
		[Parameter(ParameterSetName = 'PutViaIdentityExpanded')],
		[Parameter(ParameterSetName = 'PutExpanded')],
		
		,
		[,
		System.Management.Automation.SwitchParameter,
		]$,
		ExternallyManaged,
		[Parameter(ParameterSetName = 'PutViaIdentityExpanded')],
		[Parameter(ParameterSetName = 'PutExpanded')],
		
		,
		[,
		System.String,
		]$,
		Firstname,
		[Parameter(ParameterSetName = 'PutViaIdentityExpanded')],
		[Parameter(ParameterSetName = 'PutExpanded')],
		
		,
		[,
		System.String,
		]$,
		JobTitle,
		[Parameter(ParameterSetName = 'PutViaIdentityExpanded')],
		[Parameter(ParameterSetName = 'PutExpanded')],
		
		,
		[,
		System.String,
		]$,
		Lastname,
		[Parameter(ParameterSetName = 'PutViaIdentityExpanded')],
		[Parameter(ParameterSetName = 'PutExpanded')],
		
		,
		[,
		System.Management.Automation.SwitchParameter,
		]$,
		LdapBindingUser,
		[Parameter(ParameterSetName = 'PutViaIdentityExpanded')],
		[Parameter(ParameterSetName = 'PutExpanded')],
		
		,
		[,
		System.String,
		]$,
		Location,
		[Parameter(ParameterSetName = 'PutViaIdentityExpanded')],
		[Parameter(ParameterSetName = 'PutExpanded')],
		
		,
		[,
		System.Management.Automation.SwitchParameter,
		]$,
		MfaConfigured,
		[Parameter(ParameterSetName = 'PutViaIdentityExpanded')],
		[Parameter(ParameterSetName = 'PutExpanded')],
		
		,
		[,
		System.Management.Automation.SwitchParameter,
		]$,
		MfaExclusion,
		[Parameter(ParameterSetName = 'PutViaIdentityExpanded')],
		[Parameter(ParameterSetName = 'PutExpanded')],
		
		,
		[,
		System.DateTime,
		]$,
		MfaExclusionUntil,
		[Parameter(ParameterSetName = 'PutViaIdentityExpanded')],
		[Parameter(ParameterSetName = 'PutExpanded')],
		
		,
		[,
		System.String,
		]$,
		Middlename,
		[Parameter(ParameterSetName = 'PutViaIdentityExpanded')],
		[Parameter(ParameterSetName = 'PutExpanded')],
		
		,
		[,
		System.String,
		]$,
		Password,
		[Parameter(ParameterSetName = 'PutViaIdentityExpanded')],
		[Parameter(ParameterSetName = 'PutExpanded')],
		
		,
		[,
		System.Management.Automation.SwitchParameter,
		]$,
		PasswordNeverExpires,
		[Parameter(ParameterSetName = 'PutViaIdentityExpanded')],
		[Parameter(ParameterSetName = 'PutExpanded')],
		
		,
		[,
		JumpCloudApiSdkV1.Models.ISystemuserputPhoneNumbersItem[],
		]$,
		PhoneNumbers,
		[Parameter(ParameterSetName = 'PutViaIdentityExpanded')],
		[Parameter(ParameterSetName = 'PutExpanded')],
		
		,
		[,
		System.String,
		]$,
		PublicKey,
		[Parameter(ParameterSetName = 'PutViaIdentityExpanded')],
		[Parameter(ParameterSetName = 'PutExpanded')],
		
		,
		[,
		JumpCloudApiSdkV1.Models.ISystemuserputRelationshipsItem[],
		]$,
		Relationships,
		[Parameter(ParameterSetName = 'PutViaIdentityExpanded')],
		[Parameter(ParameterSetName = 'PutExpanded')],
		
		,
		[,
		System.Management.Automation.SwitchParameter,
		]$,
		SambaServiceUser,
		[Parameter(ParameterSetName = 'PutViaIdentityExpanded')],
		[Parameter(ParameterSetName = 'PutExpanded')],
		
		,
		[,
		JumpCloudApiSdkV1.Models.ISshkeypost[],
		]$,
		SshKeys,
		[Parameter(ParameterSetName = 'PutViaIdentityExpanded')],
		[Parameter(ParameterSetName = 'PutExpanded')],
		
		,
		[,
		System.Management.Automation.SwitchParameter,
		]$,
		Sudo,
		[Parameter(ParameterSetName = 'PutViaIdentityExpanded')],
		[Parameter(ParameterSetName = 'PutExpanded')],
		
		,
		[,
		System.Management.Automation.SwitchParameter,
		]$,
		Suspended,
		[Parameter(ParameterSetName = 'PutViaIdentityExpanded')],
		[Parameter(ParameterSetName = 'PutExpanded')],
		
		,
		[,
		System.String[],
		]$,
		Tags,
		[Parameter(ParameterSetName = 'PutViaIdentityExpanded')],
		[Parameter(ParameterSetName = 'PutExpanded')],
		
		,
		[,
		System.Int32,
		]$,
		UnixGuid,
		[Parameter(ParameterSetName = 'PutViaIdentityExpanded')],
		[Parameter(ParameterSetName = 'PutExpanded')],
		
		,
		[,
		System.Int32,
		]$,
		UnixUid,
		[Parameter(ParameterSetName = 'PutViaIdentityExpanded')],
		[Parameter(ParameterSetName = 'PutExpanded')],
		
		,
		[,
		System.String,
		]$,
		Username,
		[Parameter(ParameterSetName = 'PutExpanded')]
		[Parameter(ParameterSetName = 'Put')]
		[Parameter(ParameterSetName = 'PutViaIdentityExpanded')]
		[Parameter(ParameterSetName = 'PutViaIdentity')]
		[Alias(cf)][System.Management.Automation.SwitchParameter]$Confirm,
		[Parameter(ParameterSetName = 'PutExpanded')]
		[Parameter(ParameterSetName = 'Put')]
		[Parameter(ParameterSetName = 'PutViaIdentityExpanded')]
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
        $Results = Set-JcSdkSystemUser @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}
