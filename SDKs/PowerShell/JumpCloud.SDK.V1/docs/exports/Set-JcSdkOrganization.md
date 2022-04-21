---
external help file:
Module Name: JumpCloud.SDK.V1
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V1/docs/exports/Set-JcSdkOrganization.md
schema: 2.0.0
---

# Set-JcSdkOrganization

## SYNOPSIS
This endpoint allows you to update an Organization.

Note: `passwordPolicy` settings are only used when `passwordCompliance` is set to \"custom\".
We discourage the use of non-custom passwordCompliance values.

`hasStripeCustomerId` is deprecated and will be removed.

#### Sample Request

```
curl -X PUT https://console.jumpcloud.com/api/organizations/{OrganizationID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
  \"settings\": {
    \"contactName\": \"Admin Name\",
    \"contactEmail\": \"admin@company.com\",
    \"systemUsersCanEdit\":true,
    \"passwordPolicy\": {
      \"enableMaxHistory\": true,
      \"maxHistory\": 3
    }
  }
}'
```

## SYNTAX

### SetExpanded (Default)
```
Set-JcSdkOrganization -Id <String> [-Settings <IOrganizationsettingsput>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Set
```
Set-JcSdkOrganization -Id <String>
 -Body <IPaths1Vyp8HsOrganizationsIdPutRequestbodyContentApplicationJsonSchema> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### SetViaIdentity
```
Set-JcSdkOrganization -InputObject <IJumpCloudApiIdentity>
 -Body <IPaths1Vyp8HsOrganizationsIdPutRequestbodyContentApplicationJsonSchema> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### SetViaIdentityExpanded
```
Set-JcSdkOrganization -InputObject <IJumpCloudApiIdentity> [-Settings <IOrganizationsettingsput>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
This endpoint allows you to update an Organization.

Note: `passwordPolicy` settings are only used when `passwordCompliance` is set to \"custom\".
We discourage the use of non-custom passwordCompliance values.

`hasStripeCustomerId` is deprecated and will be removed.

#### Sample Request

```
curl -X PUT https://console.jumpcloud.com/api/organizations/{OrganizationID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
  \"settings\": {
    \"contactName\": \"Admin Name\",
    \"contactEmail\": \"admin@company.com\",
    \"systemUsersCanEdit\":true,
    \"passwordPolicy\": {
      \"enableMaxHistory\": true,
      \"maxHistory\": 3
    }
  }
}'
```

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

## PARAMETERS

### -Body
.
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: JumpCloud.SDK.V1.Models.IPaths1Vyp8HsOrganizationsIdPutRequestbodyContentApplicationJsonSchema
Parameter Sets: Set, SetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Id
.

```yaml
Type: System.String
Parameter Sets: Set, SetExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: JumpCloud.SDK.V1.Models.IJumpCloudApiIdentity
Parameter Sets: SetViaIdentity, SetViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Settings
OrganizationSettingsPut
To construct, see NOTES section for SETTINGS properties and create a hash table.

```yaml
Type: JumpCloud.SDK.V1.Models.IOrganizationsettingsput
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### JumpCloud.SDK.V1.Models.IJumpCloudApiIdentity

### JumpCloud.SDK.V1.Models.IPaths1Vyp8HsOrganizationsIdPutRequestbodyContentApplicationJsonSchema

## OUTPUTS

### JumpCloud.SDK.V1.Models.IOrganization

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODY <IPaths1Vyp8HsOrganizationsIdPutRequestbodyContentApplicationJsonSchema>: .
  - `[Settings <IOrganizationsettingsput>]`: OrganizationSettingsPut
    - `[ContactEmail <String>]`: 
    - `[ContactName <String>]`: 
    - `[DeviceIdentificationEnabled <Boolean?>]`: 
    - `[DirectoryInsightEnabled <Boolean?>]`: 
    - `[DirectoryInsightPremiumCreatedAt <String>]`: 
    - `[DirectoryInsightPremiumEnabled <Boolean?>]`: 
    - `[DirectoryInsightPremiumUpdatedAt <String>]`: 
    - `[DisableGoogleLogin <Boolean?>]`: 
    - `[DisableLdap <Boolean?>]`: 
    - `[DisableUm <Boolean?>]`: 
    - `[DuplicateLdapGroups <Boolean?>]`: 
    - `[EmailDisclaimer <String>]`: 
    - `[EnableManagedUid <Boolean?>]`: 
    - `[GrowthData <IOrganizationsettingsputGrowthData>]`: Object containing Optimizely experimentIds and states corresponding to them
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Logo <String>]`: 
    - `[Name <String>]`: 
    - `[NewSystemUserStateDefaultApplicationImport <String>]`: 
    - `[NewSystemUserStateDefaultCsvImport <String>]`: 
    - `[NewSystemUserStateDefaultManualEntry <String>]`: 
    - `[PasswordCompliance <String>]`: 
    - `[PasswordPolicyAllowUsernameSubstring <Boolean?>]`: 
    - `[PasswordPolicyDaysAfterExpirationToSelfRecover <Int32?>]`: Deprecated field used for the legacy grace period feature.
    - `[PasswordPolicyDaysBeforeExpirationToForceReset <Int32?>]`: 
    - `[PasswordPolicyEffectiveDate <String>]`: 
    - `[PasswordPolicyEnableDaysAfterExpirationToSelfRecover <Boolean?>]`: 
    - `[PasswordPolicyEnableDaysBeforeExpirationToForceReset <Boolean?>]`: 
    - `[PasswordPolicyEnableLockoutTimeInSeconds <Boolean?>]`: 
    - `[PasswordPolicyEnableMaxHistory <Boolean?>]`: 
    - `[PasswordPolicyEnableMaxLoginAttempts <Boolean?>]`: 
    - `[PasswordPolicyEnableMinChangePeriodInDays <Boolean?>]`: 
    - `[PasswordPolicyEnableMinLength <Boolean?>]`: 
    - `[PasswordPolicyEnablePasswordExpirationInDays <Boolean?>]`: 
    - `[PasswordPolicyGracePeriodDate <String>]`: 
    - `[PasswordPolicyLockoutTimeInSeconds <Int32?>]`: 
    - `[PasswordPolicyMaxHistory <Int32?>]`: 
    - `[PasswordPolicyMaxLoginAttempts <Int32?>]`: 
    - `[PasswordPolicyMinChangePeriodInDays <Int32?>]`: 
    - `[PasswordPolicyMinLength <Int32?>]`: 
    - `[PasswordPolicyNeedsLowercase <Boolean?>]`: 
    - `[PasswordPolicyNeedsNumeric <Boolean?>]`: 
    - `[PasswordPolicyNeedsSymbolic <Boolean?>]`: 
    - `[PasswordPolicyNeedsUppercase <Boolean?>]`: 
    - `[PasswordPolicyPasswordExpirationInDays <Int32?>]`: 
    - `[ShowIntro <Boolean?>]`: 
    - `[SystemInsightCreatedAt <String>]`: 
    - `[SystemInsightEnableNewDarwin <Boolean?>]`: 
    - `[SystemInsightEnableNewLinux <Boolean?>]`: 
    - `[SystemInsightEnableNewWindows <Boolean?>]`: 
    - `[SystemInsightEnabled <Boolean?>]`: 
    - `[SystemInsightUpdatedAt <String>]`: 
    - `[SystemUserPasswordExpirationInDays <Int32?>]`: 
    - `[SystemUsersCanEdit <Boolean?>]`: 
    - `[SystemUsersCap <Int32?>]`: 
    - `[TrustedAppConfigTrustedApps <ITrustedappConfigPutTrustedAppsItem[]>]`: List of authorized apps for the organization 
      - `Name <String>`: Name of the trusted application
      - `[Path <String>]`: Absolute path for the app's location in user's device
      - `[Teamid <String>]`: App's Team ID
    - `[UserPortalIdleSessionDurationMinutes <Int32?>]`: 

INPUTOBJECT <IJumpCloudApiIdentity>: Identity Parameter
  - `[Id <String>]`: 
  - `[SystemId <String>]`: 
  - `[SystemuserId <String>]`: 
  - `[Triggername <String>]`: 

SETTINGS <IOrganizationsettingsput>: OrganizationSettingsPut
  - `[ContactEmail <String>]`: 
  - `[ContactName <String>]`: 
  - `[DeviceIdentificationEnabled <Boolean?>]`: 
  - `[DirectoryInsightEnabled <Boolean?>]`: 
  - `[DirectoryInsightPremiumCreatedAt <String>]`: 
  - `[DirectoryInsightPremiumEnabled <Boolean?>]`: 
  - `[DirectoryInsightPremiumUpdatedAt <String>]`: 
  - `[DisableGoogleLogin <Boolean?>]`: 
  - `[DisableLdap <Boolean?>]`: 
  - `[DisableUm <Boolean?>]`: 
  - `[DuplicateLdapGroups <Boolean?>]`: 
  - `[EmailDisclaimer <String>]`: 
  - `[EnableManagedUid <Boolean?>]`: 
  - `[GrowthData <IOrganizationsettingsputGrowthData>]`: Object containing Optimizely experimentIds and states corresponding to them
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Logo <String>]`: 
  - `[Name <String>]`: 
  - `[NewSystemUserStateDefaultApplicationImport <String>]`: 
  - `[NewSystemUserStateDefaultCsvImport <String>]`: 
  - `[NewSystemUserStateDefaultManualEntry <String>]`: 
  - `[PasswordCompliance <String>]`: 
  - `[PasswordPolicyAllowUsernameSubstring <Boolean?>]`: 
  - `[PasswordPolicyDaysAfterExpirationToSelfRecover <Int32?>]`: Deprecated field used for the legacy grace period feature.
  - `[PasswordPolicyDaysBeforeExpirationToForceReset <Int32?>]`: 
  - `[PasswordPolicyEffectiveDate <String>]`: 
  - `[PasswordPolicyEnableDaysAfterExpirationToSelfRecover <Boolean?>]`: 
  - `[PasswordPolicyEnableDaysBeforeExpirationToForceReset <Boolean?>]`: 
  - `[PasswordPolicyEnableLockoutTimeInSeconds <Boolean?>]`: 
  - `[PasswordPolicyEnableMaxHistory <Boolean?>]`: 
  - `[PasswordPolicyEnableMaxLoginAttempts <Boolean?>]`: 
  - `[PasswordPolicyEnableMinChangePeriodInDays <Boolean?>]`: 
  - `[PasswordPolicyEnableMinLength <Boolean?>]`: 
  - `[PasswordPolicyEnablePasswordExpirationInDays <Boolean?>]`: 
  - `[PasswordPolicyGracePeriodDate <String>]`: 
  - `[PasswordPolicyLockoutTimeInSeconds <Int32?>]`: 
  - `[PasswordPolicyMaxHistory <Int32?>]`: 
  - `[PasswordPolicyMaxLoginAttempts <Int32?>]`: 
  - `[PasswordPolicyMinChangePeriodInDays <Int32?>]`: 
  - `[PasswordPolicyMinLength <Int32?>]`: 
  - `[PasswordPolicyNeedsLowercase <Boolean?>]`: 
  - `[PasswordPolicyNeedsNumeric <Boolean?>]`: 
  - `[PasswordPolicyNeedsSymbolic <Boolean?>]`: 
  - `[PasswordPolicyNeedsUppercase <Boolean?>]`: 
  - `[PasswordPolicyPasswordExpirationInDays <Int32?>]`: 
  - `[ShowIntro <Boolean?>]`: 
  - `[SystemInsightCreatedAt <String>]`: 
  - `[SystemInsightEnableNewDarwin <Boolean?>]`: 
  - `[SystemInsightEnableNewLinux <Boolean?>]`: 
  - `[SystemInsightEnableNewWindows <Boolean?>]`: 
  - `[SystemInsightEnabled <Boolean?>]`: 
  - `[SystemInsightUpdatedAt <String>]`: 
  - `[SystemUserPasswordExpirationInDays <Int32?>]`: 
  - `[SystemUsersCanEdit <Boolean?>]`: 
  - `[SystemUsersCap <Int32?>]`: 
  - `[TrustedAppConfigTrustedApps <ITrustedappConfigPutTrustedAppsItem[]>]`: List of authorized apps for the organization 
    - `Name <String>`: Name of the trusted application
    - `[Path <String>]`: Absolute path for the app's location in user's device
    - `[Teamid <String>]`: App's Team ID
  - `[UserPortalIdleSessionDurationMinutes <Int32?>]`: 

## RELATED LINKS

