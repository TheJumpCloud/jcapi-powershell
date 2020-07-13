<#
.Synopsis
This endpoint allows you to update an Organization.\n\nNote: `passwordPolicy` settings are only used when `passwordCompliance` is set to \"custom\".
We discourage the use of non-custom passwordCompliance values.\n\n`hasStripeCustomerId` is deprecated and will be removed.\n\n#### Sample Request\n\n```\ncurl -X PUT https://console.jumpcloud.com/api/organizations/{OrganizationID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n  \"settings\": {\n    \"contactName\": \"Admin Name\",\n    \"contactEmail\": \"admin@company.com\",\n    \"systemUsersCanEdit\":true,\n    \"passwordPolicy\": {\n      \"enableMaxHistory\": true,\n      \"maxHistory\": 3\n    }\n  }\n}'\n```
.Description
This endpoint allows you to update an Organization.\n\nNote: `passwordPolicy` settings are only used when `passwordCompliance` is set to \"custom\".
We discourage the use of non-custom passwordCompliance values.\n\n`hasStripeCustomerId` is deprecated and will be removed.\n\n#### Sample Request\n\n```\ncurl -X PUT https://console.jumpcloud.com/api/organizations/{OrganizationID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n  \"settings\": {\n    \"contactName\": \"Admin Name\",\n    \"contactEmail\": \"admin@company.com\",\n    \"systemUsersCanEdit\":true,\n    \"passwordPolicy\": {\n      \"enableMaxHistory\": true,\n      \"maxHistory\": 3\n    }\n  }\n}'\n```
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
JumpCloud.SDK.V1.Models.IJumpCloudApIsIdentity
.Inputs
JumpCloud.SDK.V1.Models.IPaths1Vyp8HsOrganizationsIdPutRequestbodyContentApplicationJsonSchema
.Outputs
JumpCloud.SDK.V1.Models.IOrganization
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IPaths1Vyp8HsOrganizationsIdPutRequestbodyContentApplicationJsonSchema>: 
  [Settings <IOrganizationsettingsput>]: OrganizationSettingsPut
    [ContactEmail <String>]: 
    [ContactName <String>]: 
    [DirectoryInsightPremiumEnabled <Boolean?>]: 
    [DisableGoogleLogin <Boolean?>]: 
    [DisableLdap <Boolean?>]: 
    [DisableUm <Boolean?>]: 
    [DuplicateLdapGroups <Boolean?>]: 
    [EmailDisclaimer <String>]: 
    [EnableManagedUid <Boolean?>]: 
    [Logo <String>]: 
    [Name <String>]: 
    [PasswordCompliance <String>]: 
    [PasswordPolicyAllowUsernameSubstring <Boolean?>]: 
    [PasswordPolicyDaysAfterExpirationToSelfRecover <Int32?>]: 
    [PasswordPolicyDaysBeforeExpirationToForceReset <Int32?>]: 
    [PasswordPolicyEnableDaysAfterExpirationToSelfRecover <Boolean?>]: 
    [PasswordPolicyEnableDaysBeforeExpirationToForceReset <Boolean?>]: 
    [PasswordPolicyEnableLockoutTimeInSeconds <Boolean?>]: 
    [PasswordPolicyEnableMaxHistory <Boolean?>]: 
    [PasswordPolicyEnableMaxLoginAttempts <Boolean?>]: 
    [PasswordPolicyEnableMinChangePeriodInDays <Boolean?>]: 
    [PasswordPolicyEnableMinLength <Boolean?>]: 
    [PasswordPolicyEnablePasswordExpirationInDays <Boolean?>]: 
    [PasswordPolicyLockoutTimeInSeconds <Int32?>]: 
    [PasswordPolicyMaxHistory <Int32?>]: 
    [PasswordPolicyMaxLoginAttempts <Int32?>]: 
    [PasswordPolicyMinChangePeriodInDays <Int32?>]: 
    [PasswordPolicyMinLength <Int32?>]: 
    [PasswordPolicyNeedsLowercase <Boolean?>]: 
    [PasswordPolicyNeedsNumeric <Boolean?>]: 
    [PasswordPolicyNeedsSymbolic <Boolean?>]: 
    [PasswordPolicyNeedsUppercase <Boolean?>]: 
    [PasswordPolicyPasswordExpirationInDays <Int32?>]: 
    [ShowIntro <Boolean?>]: 
    [SystemInsightEnableNewDarwin <Boolean?>]: 
    [SystemInsightEnableNewLinux <Boolean?>]: 
    [SystemInsightEnableNewWindows <Boolean?>]: 
    [SystemInsightEnabled <Boolean?>]: 
    [SystemUserPasswordExpirationInDays <Int32?>]: 
    [SystemUsersCanEdit <Boolean?>]: 
    [UserPortalIdleSessionDurationMinutes <Int32?>]: 

INPUTOBJECT <IJumpCloudApIsIdentity>: 
  [Id <String>]: 
  [SystemuserId <String>]: 
  [Triggername <String>]: 

SETTINGS <IOrganizationsettingsput>: 
  [ContactEmail <String>]: 
  [ContactName <String>]: 
  [DirectoryInsightPremiumEnabled <Boolean?>]: 
  [DisableGoogleLogin <Boolean?>]: 
  [DisableLdap <Boolean?>]: 
  [DisableUm <Boolean?>]: 
  [DuplicateLdapGroups <Boolean?>]: 
  [EmailDisclaimer <String>]: 
  [EnableManagedUid <Boolean?>]: 
  [Logo <String>]: 
  [Name <String>]: 
  [PasswordCompliance <String>]: 
  [PasswordPolicyAllowUsernameSubstring <Boolean?>]: 
  [PasswordPolicyDaysAfterExpirationToSelfRecover <Int32?>]: 
  [PasswordPolicyDaysBeforeExpirationToForceReset <Int32?>]: 
  [PasswordPolicyEnableDaysAfterExpirationToSelfRecover <Boolean?>]: 
  [PasswordPolicyEnableDaysBeforeExpirationToForceReset <Boolean?>]: 
  [PasswordPolicyEnableLockoutTimeInSeconds <Boolean?>]: 
  [PasswordPolicyEnableMaxHistory <Boolean?>]: 
  [PasswordPolicyEnableMaxLoginAttempts <Boolean?>]: 
  [PasswordPolicyEnableMinChangePeriodInDays <Boolean?>]: 
  [PasswordPolicyEnableMinLength <Boolean?>]: 
  [PasswordPolicyEnablePasswordExpirationInDays <Boolean?>]: 
  [PasswordPolicyLockoutTimeInSeconds <Int32?>]: 
  [PasswordPolicyMaxHistory <Int32?>]: 
  [PasswordPolicyMaxLoginAttempts <Int32?>]: 
  [PasswordPolicyMinChangePeriodInDays <Int32?>]: 
  [PasswordPolicyMinLength <Int32?>]: 
  [PasswordPolicyNeedsLowercase <Boolean?>]: 
  [PasswordPolicyNeedsNumeric <Boolean?>]: 
  [PasswordPolicyNeedsSymbolic <Boolean?>]: 
  [PasswordPolicyNeedsUppercase <Boolean?>]: 
  [PasswordPolicyPasswordExpirationInDays <Int32?>]: 
  [ShowIntro <Boolean?>]: 
  [SystemInsightEnableNewDarwin <Boolean?>]: 
  [SystemInsightEnableNewLinux <Boolean?>]: 
  [SystemInsightEnableNewWindows <Boolean?>]: 
  [SystemInsightEnabled <Boolean?>]: 
  [SystemUserPasswordExpirationInDays <Int32?>]: 
  [SystemUsersCanEdit <Boolean?>]: 
  [UserPortalIdleSessionDurationMinutes <Int32?>]: 
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V1/examples/Set-JcSdkOrganization.md
#>
 Function Set-JcSdkOrganization
{
    [OutputType([JumpCloud.SDK.V1.Models.IOrganization])]
    [CmdletBinding(DefaultParameterSetName='PutExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
    [Parameter(ParameterSetName='Put', Mandatory)]
    [Parameter(ParameterSetName='PutExpanded', Mandatory)]
    [JumpCloud.SDK.V1.Category('Path')]
    [System.String]
    # .
    ${Id},

    [Parameter(ParameterSetName='PutViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='PutViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V1.Category('Path')]
    [JumpCloud.SDK.V1.Models.IJumpCloudApIsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='Put', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='PutViaIdentity', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V1.Category('Body')]
    [JumpCloud.SDK.V1.Models.IPaths1Vyp8HsOrganizationsIdPutRequestbodyContentApplicationJsonSchema]
    # .
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='PutExpanded')]
    [Parameter(ParameterSetName='PutViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [JumpCloud.SDK.V1.Models.IOrganizationsettingsput]
    # OrganizationSettingsPut
    # To construct, see NOTES section for SETTINGS properties and create a hash table.
    ${Settings},

    [Parameter()]
    [JumpCloud.SDK.V1.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Returns true when the command succeeds
    ${PassThru}
    )
    Begin
    {
        $Results = @()
    }
    Process
    {
        $Results = JumpCloud.SDK.V1.internal\Set-JcSdkInternalOrganization @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}

