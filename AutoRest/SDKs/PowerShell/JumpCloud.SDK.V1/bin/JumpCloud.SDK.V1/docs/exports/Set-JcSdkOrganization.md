---
external help file:
Module Name: JumpCloud.SDK.V1
online version: https://docs.microsoft.com/en-us/powershell/module/jumpcloud.sdk.v1/set-jcsdkorganization
schema: 2.0.0
---

# Set-JcSdkOrganization

## SYNOPSIS
This endpoint allows you to update an Organization.\n\nNote: `passwordPolicy` settings are only used when `passwordCompliance` is set to \"custom\".
We discourage the use of non-custom passwordCompliance values.\n\n`hasStripeCustomerId` is deprecated and will be removed.\n\n#### Sample Request\n\n```\ncurl -X PUT https://console.jumpcloud.com/api/organizations/{OrganizationID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n  \"settings\": {\n    \"contactName\": \"Admin Name\",\n    \"contactEmail\": \"admin@company.com\",\n    \"systemUsersCanEdit\":true,\n    \"passwordPolicy\": {\n      \"enableMaxHistory\": true,\n      \"maxHistory\": 3\n    }\n  }\n}'\n```

## SYNTAX

### PutExpanded (Default)
```
Set-JcSdkOrganization -Id <String> [-Settings <IOrganizationsettingsput>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Put
```
Set-JcSdkOrganization -Id <String> -Body <IBodyParameterOrganizationPutRequestBody> [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### PutViaIdentity
```
Set-JcSdkOrganization -InputObject <IJumpCloudApIsIdentity> -Body <IBodyParameterOrganizationPutRequestBody>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### PutViaIdentityExpanded
```
Set-JcSdkOrganization -InputObject <IJumpCloudApIsIdentity> [-Settings <IOrganizationsettingsput>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
This endpoint allows you to update an Organization.\n\nNote: `passwordPolicy` settings are only used when `passwordCompliance` is set to \"custom\".
We discourage the use of non-custom passwordCompliance values.\n\n`hasStripeCustomerId` is deprecated and will be removed.\n\n#### Sample Request\n\n```\ncurl -X PUT https://console.jumpcloud.com/api/organizations/{OrganizationID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n  \"settings\": {\n    \"contactName\": \"Admin Name\",\n    \"contactEmail\": \"admin@company.com\",\n    \"systemUsersCanEdit\":true,\n    \"passwordPolicy\": {\n      \"enableMaxHistory\": true,\n      \"maxHistory\": 3\n    }\n  }\n}'\n```

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
To view examples, please use the -Online parameter with Get-Help or navigate to: https://docs.microsoft.com/en-us/powershell/module/jumpcloud.sdk.v1/set-jcsdkorganization
```



## PARAMETERS

### -Body
HELP MESSAGE MISSING
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: JumpCloud.SDK.V1.Models.IBodyParameterOrganizationPutRequestBody
Parameter Sets: Put, PutViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -Id
HELP MESSAGE MISSING

```yaml
Type: System.String
Parameter Sets: Put, PutExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: JumpCloud.SDK.V1.Models.IJumpCloudApIsIdentity
Parameter Sets: PutViaIdentity, PutViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -PassThru
Returns true when the command succeeds

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Settings
OrganizationSettingsPut
To construct, see NOTES section for SETTINGS properties and create a hash table.

```yaml
Type: JumpCloud.SDK.V1.Models.IOrganizationsettingsput
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
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
Dynamic: False
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
Dynamic: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### JumpCloud.SDK.V1.Models.IBodyParameterOrganizationPutRequestBody

### JumpCloud.SDK.V1.Models.IJumpCloudApIsIdentity

## OUTPUTS

### JumpCloud.SDK.V1.Models.IOrganization

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### BODY <IBodyParameterOrganizationPutRequestBody>: HELP MESSAGE MISSING
  - `[Settings <IOrganizationsettingsput>]`: OrganizationSettingsPut
    - `[ContactEmail <String>]`: 
    - `[ContactName <String>]`: 
    - `[DisableLdap <Boolean?>]`: 
    - `[DisableUm <Boolean?>]`: 
    - `[DuplicateLdapGroups <Boolean?>]`: 
    - `[EmailDisclaimer <String>]`: 
    - `[EnableManagedUid <Boolean?>]`: 
    - `[Logo <String>]`: 
    - `[Name <String>]`: 
    - `[PasswordCompliance <String>]`: 
    - `[PasswordPolicyAllowUsernameSubstring <Boolean?>]`: 
    - `[PasswordPolicyDaysAfterExpirationToSelfRecover <Int32?>]`: 
    - `[PasswordPolicyDaysBeforeExpirationToForceReset <Int32?>]`: 
    - `[PasswordPolicyEnableDaysAfterExpirationToSelfRecover <Boolean?>]`: 
    - `[PasswordPolicyEnableDaysBeforeExpirationToForceReset <Boolean?>]`: 
    - `[PasswordPolicyEnableLockoutTimeInSeconds <Boolean?>]`: 
    - `[PasswordPolicyEnableMaxHistory <Boolean?>]`: 
    - `[PasswordPolicyEnableMaxLoginAttempts <Boolean?>]`: 
    - `[PasswordPolicyEnableMinChangePeriodInDays <Boolean?>]`: 
    - `[PasswordPolicyEnableMinLength <Boolean?>]`: 
    - `[PasswordPolicyEnablePasswordExpirationInDays <Boolean?>]`: 
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
    - `[SystemInsightEnabled <Boolean?>]`: 
    - `[SystemUserPasswordExpirationInDays <Int32?>]`: 
    - `[SystemUsersCanEdit <Boolean?>]`: 
    - `[UserPortalIdleSessionDurationMinutes <Int32?>]`: 

#### INPUTOBJECT <IJumpCloudApIsIdentity>: Identity Parameter
  - `[Id <String>]`: 
  - `[SystemuserId <String>]`: 
  - `[Triggername <String>]`: 

#### SETTINGS <IOrganizationsettingsput>: OrganizationSettingsPut
  - `[ContactEmail <String>]`: 
  - `[ContactName <String>]`: 
  - `[DisableLdap <Boolean?>]`: 
  - `[DisableUm <Boolean?>]`: 
  - `[DuplicateLdapGroups <Boolean?>]`: 
  - `[EmailDisclaimer <String>]`: 
  - `[EnableManagedUid <Boolean?>]`: 
  - `[Logo <String>]`: 
  - `[Name <String>]`: 
  - `[PasswordCompliance <String>]`: 
  - `[PasswordPolicyAllowUsernameSubstring <Boolean?>]`: 
  - `[PasswordPolicyDaysAfterExpirationToSelfRecover <Int32?>]`: 
  - `[PasswordPolicyDaysBeforeExpirationToForceReset <Int32?>]`: 
  - `[PasswordPolicyEnableDaysAfterExpirationToSelfRecover <Boolean?>]`: 
  - `[PasswordPolicyEnableDaysBeforeExpirationToForceReset <Boolean?>]`: 
  - `[PasswordPolicyEnableLockoutTimeInSeconds <Boolean?>]`: 
  - `[PasswordPolicyEnableMaxHistory <Boolean?>]`: 
  - `[PasswordPolicyEnableMaxLoginAttempts <Boolean?>]`: 
  - `[PasswordPolicyEnableMinChangePeriodInDays <Boolean?>]`: 
  - `[PasswordPolicyEnableMinLength <Boolean?>]`: 
  - `[PasswordPolicyEnablePasswordExpirationInDays <Boolean?>]`: 
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
  - `[SystemInsightEnabled <Boolean?>]`: 
  - `[SystemUserPasswordExpirationInDays <Int32?>]`: 
  - `[SystemUsersCanEdit <Boolean?>]`: 
  - `[UserPortalIdleSessionDurationMinutes <Int32?>]`: 

## RELATED LINKS

