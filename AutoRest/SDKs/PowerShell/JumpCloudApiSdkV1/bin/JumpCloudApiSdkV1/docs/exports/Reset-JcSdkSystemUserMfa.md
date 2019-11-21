---
external help file:
Module Name: JumpCloudApiSdkV1
online version: https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv1/reset-jcsdksystemusermfa
schema: 2.0.0
---

# Reset-JcSdkSystemUserMfa

## SYNOPSIS
This endpoint allows you to reset the TOTP key for a specified system user and put them in an TOTP MFA enrollment period.
This will result in the user being prompted to setup TOTP MFA when logging into userportal.
Please be aware that if the user does not complete TOTP MFA setup before the `exclusionUntil` date, they will be locked out of any resources that require TOTP MFA.\n\nPlease refer to our [Knowledge Base Article](https://support.jumpcloud.com/customer/en/portal/articles/2959138-using-multifactor-authentication-with-jumpcloud) on setting up MFA for more information.
\n\n#### Sample Request \n```\ncurl -X POST \\\n  https://console.jumpcloud.com/api/systemusers/{UserID}/resetmfa \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\"exclusion\": true, \"exclusionUntil\": \"{date-time}\"}'\n  \n\n```

## SYNTAX

### ResetExpanded (Default)
```
Reset-JcSdkSystemUserMfa -Id <String> [-Exclusion] [-ExclusionUntil <DateTime>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Reset
```
Reset-JcSdkSystemUserMfa -Id <String> -Body <IBodyParameterSystemUserMfaResetRequestBody> [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ResetViaIdentity
```
Reset-JcSdkSystemUserMfa -InputObject <IJumpCloudApIsIdentity>
 -Body <IBodyParameterSystemUserMfaResetRequestBody> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ResetViaIdentityExpanded
```
Reset-JcSdkSystemUserMfa -InputObject <IJumpCloudApIsIdentity> [-Exclusion] [-ExclusionUntil <DateTime>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
This endpoint allows you to reset the TOTP key for a specified system user and put them in an TOTP MFA enrollment period.
This will result in the user being prompted to setup TOTP MFA when logging into userportal.
Please be aware that if the user does not complete TOTP MFA setup before the `exclusionUntil` date, they will be locked out of any resources that require TOTP MFA.\n\nPlease refer to our [Knowledge Base Article](https://support.jumpcloud.com/customer/en/portal/articles/2959138-using-multifactor-authentication-with-jumpcloud) on setting up MFA for more information.
\n\n#### Sample Request \n```\ncurl -X POST \\\n  https://console.jumpcloud.com/api/systemusers/{UserID}/resetmfa \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\"exclusion\": true, \"exclusionUntil\": \"{date-time}\"}'\n  \n\n```

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
To view examples, please use the -Online parameter with Get-Help or navigate to: https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv1/reset-jcsdksystemusermfa
```



## PARAMETERS

### -Body
HELP MESSAGE MISSING
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: JumpCloudApiSdkV1.Models.IBodyParameterSystemUserMfaResetRequestBody
Parameter Sets: Reset, ResetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -Exclusion
HELP MESSAGE MISSING

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: ResetExpanded, ResetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ExclusionUntil
HELP MESSAGE MISSING

```yaml
Type: System.DateTime
Parameter Sets: ResetExpanded, ResetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Id
HELP MESSAGE MISSING

```yaml
Type: System.String
Parameter Sets: Reset, ResetExpanded
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
Type: JumpCloudApiSdkV1.Models.IJumpCloudApIsIdentity
Parameter Sets: ResetViaIdentity, ResetViaIdentityExpanded
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

### JumpCloudApiSdkV1.Models.IBodyParameterSystemUserMfaResetRequestBody

### JumpCloudApiSdkV1.Models.IJumpCloudApIsIdentity

## OUTPUTS

### System.String

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### BODY <IBodyParameterSystemUserMfaResetRequestBody>: HELP MESSAGE MISSING
  - `[Exclusion <Boolean?>]`: 
  - `[ExclusionUntil <DateTime?>]`: 

#### INPUTOBJECT <IJumpCloudApIsIdentity>: Identity Parameter
  - `[Id <String>]`: 
  - `[SystemuserId <String>]`: 
  - `[Triggername <String>]`: 

## RELATED LINKS

