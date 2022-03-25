---
external help file:
Module Name: JumpCloud.SDK.V1
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V1/docs/exports/Reset-JcSdkUserMfa.md
schema: 2.0.0
---

# Reset-JcSdkUserMfa

## SYNOPSIS
This endpoint allows you to reset the TOTP key for a specified system user and put them in an TOTP MFA enrollment period.
This will result in the user being prompted to setup TOTP MFA when logging into userportal.
Please be aware that if the user does not complete TOTP MFA setup before the `exclusionUntil` date, they will be locked out of any resources that require TOTP MFA.

Please refer to our [Knowledge Base Article](https://support.jumpcloud.com/customer/en/portal/articles/2959138-using-multifactor-authentication-with-jumpcloud) on setting up MFA for more information.

#### Sample Request
```
curl -X POST \\
  https://console.jumpcloud.com/api/systemusers/{UserID}/resetmfa \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{\"exclusion\": true, \"exclusionUntil\": \"{date-time}\"}'

```

## SYNTAX

### ResetExpanded (Default)
```
Reset-JcSdkUserMfa -Id <String> [-Exclusion] [-ExclusionDays <Single>] [-ExclusionUntil <DateTime>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Reset
```
Reset-JcSdkUserMfa -Id <String>
 -Body <IPathsYhix24SystemusersIdResetmfaPostRequestbodyContentApplicationJsonSchema> [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### ResetViaIdentity
```
Reset-JcSdkUserMfa -InputObject <IJumpCloudApiIdentity>
 -Body <IPathsYhix24SystemusersIdResetmfaPostRequestbodyContentApplicationJsonSchema> [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### ResetViaIdentityExpanded
```
Reset-JcSdkUserMfa -InputObject <IJumpCloudApiIdentity> [-Exclusion] [-ExclusionDays <Single>]
 [-ExclusionUntil <DateTime>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
This endpoint allows you to reset the TOTP key for a specified system user and put them in an TOTP MFA enrollment period.
This will result in the user being prompted to setup TOTP MFA when logging into userportal.
Please be aware that if the user does not complete TOTP MFA setup before the `exclusionUntil` date, they will be locked out of any resources that require TOTP MFA.

Please refer to our [Knowledge Base Article](https://support.jumpcloud.com/customer/en/portal/articles/2959138-using-multifactor-authentication-with-jumpcloud) on setting up MFA for more information.

#### Sample Request
```
curl -X POST \\
  https://console.jumpcloud.com/api/systemusers/{UserID}/resetmfa \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{\"exclusion\": true, \"exclusionUntil\": \"{date-time}\"}'

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
Type: JumpCloud.SDK.V1.Models.IPathsYhix24SystemusersIdResetmfaPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Reset, ResetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Exclusion
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: ResetExpanded, ResetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExclusionDays
.

```yaml
Type: System.Single
Parameter Sets: ResetExpanded, ResetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExclusionUntil
.

```yaml
Type: System.DateTime
Parameter Sets: ResetExpanded, ResetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
.

```yaml
Type: System.String
Parameter Sets: Reset, ResetExpanded
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
Parameter Sets: ResetViaIdentity, ResetViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
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

### JumpCloud.SDK.V1.Models.IPathsYhix24SystemusersIdResetmfaPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODY <IPathsYhix24SystemusersIdResetmfaPostRequestbodyContentApplicationJsonSchema>: .
  - `[Exclusion <Boolean?>]`: 
  - `[ExclusionDays <Single?>]`: 
  - `[ExclusionUntil <DateTime?>]`: 

INPUTOBJECT <IJumpCloudApiIdentity>: Identity Parameter
  - `[Id <String>]`: 
  - `[SystemId <String>]`: 
  - `[SystemuserId <String>]`: 
  - `[Triggername <String>]`: 

## RELATED LINKS

