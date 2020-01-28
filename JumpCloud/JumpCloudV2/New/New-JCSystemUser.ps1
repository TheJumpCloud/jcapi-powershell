#Requires -modules JumpCloud.SDK.V1
Function New-JCSystemUser
{
    [CmdletBinding(DefaultParameterSetName = 'CreateExpanded')]
	Param(
		[Parameter(
			ParameterSetName = 'Create',
			Mandatory = $true,
			ValueFromPipeline = $true
		)]
		[JumpCloud.SDK.V1.Models.ISystemuserputpost]$Body,
		[Parameter(
			ParameterSetName = 'CreateExpanded',
			Mandatory = $true
		)]
		[System.String]$Email,
		[Parameter(
			ParameterSetName = 'CreateExpanded',
			Mandatory = $true
		)]
		[System.String]$Username,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.Management.Automation.SwitchParameter]$AccountLocked,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.Management.Automation.SwitchParameter]$Activated,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[JumpCloud.SDK.V1.Models.ISystemuserputpostAddressesItem[]]$Addresses,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.Management.Automation.SwitchParameter]$AllowPublicKey,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[JumpCloud.SDK.V1.Models.ISystemuserputpostAttributesItem[]]$Attributes,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.String]$Company,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.String]$CostCenter,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.String]$Department,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.String]$Description,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.String]$Displayname,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.String]$EmployeeIdentifier,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.String]$EmployeeType,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.Management.Automation.SwitchParameter]$EnableManagedUid,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.Management.Automation.SwitchParameter]$EnableUserPortalMultifactor,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.String]$ExternalDn,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.String]$ExternalPasswordExpirationDate,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.String]$ExternalSourceType,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.Management.Automation.SwitchParameter]$ExternallyManaged,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.String]$Firstname,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.String]$JobTitle,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.String]$Lastname,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.Management.Automation.SwitchParameter]$LdapBindingUser,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.String]$Location,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.Management.Automation.SwitchParameter]$MfaConfigured,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.Management.Automation.SwitchParameter]$MfaExclusion,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.DateTime]$MfaExclusionUntil,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.String]$Middlename,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.String]$Password,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.Management.Automation.SwitchParameter]$PasswordNeverExpires,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.Management.Automation.SwitchParameter]$PasswordlessSudo,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[JumpCloud.SDK.V1.Models.ISystemuserputpostPhoneNumbersItem[]]$PhoneNumbers,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.String]$PublicKey,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[JumpCloud.SDK.V1.Models.ISystemuserputpostRelationshipsItem[]]$Relationships,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.Management.Automation.SwitchParameter]$SambaServiceUser,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.Management.Automation.SwitchParameter]$Sudo,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.Management.Automation.SwitchParameter]$Suspended,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.String[]]$Tags,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.Int32]$UnixGuid,
		[Parameter(ParameterSetName = 'CreateExpanded')]
		[System.Int32]$UnixUid,
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
        $Results = New-JcSdkSystemUser @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}
