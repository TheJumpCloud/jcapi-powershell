---
external help file:
Module Name: JumpCloud.SDK.V1
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/CUT-4908_userGroupDeviceGroupFilters/SDKs/PowerShell/JumpCloud.SDK.V1/docs/exports/Reset-JcSdkUserMfa.md
schema: 2.0.0
---

# Reset-JcSdkUserMfa

## SYNOPSIS
This endpoint resets the user's TOTP key and initiates a new MFA enrollment period.
The user will be prompted to set up MFA at their next login.
If `Unified MFA is enabled`, this action will also delete the user's existing Push Notification endpoint.
Warning: The user must complete the setup before the `exclusionUntil` date to avoid being locked out of MFA-protected resources.

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
Reset-JcSdkUserMfa -HostEnv <String> -Id <String> [-Exclusion] [-ExclusionDays <Single>]
 [-ExclusionUntil <DateTime>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Reset
```
Reset-JcSdkUserMfa -HostEnv <String> -Id <String>
 -Body <IPathsYhix24SystemusersIdResetmfaPostRequestbodyContentApplicationJsonSchema> [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### ResetViaIdentity
```
Reset-JcSdkUserMfa -HostEnv <String> -InputObject <IJumpCloudApiIdentity>
 -Body <IPathsYhix24SystemusersIdResetmfaPostRequestbodyContentApplicationJsonSchema> [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### ResetViaIdentityExpanded
```
Reset-JcSdkUserMfa -HostEnv <String> -InputObject <IJumpCloudApiIdentity> [-Exclusion]
 [-ExclusionDays <Single>] [-ExclusionUntil <DateTime>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
This endpoint resets the user's TOTP key and initiates a new MFA enrollment period.
The user will be prompted to set up MFA at their next login.
If `Unified MFA is enabled`, this action will also delete the user's existing Push Notification endpoint.
Warning: The user must complete the setup before the `exclusionUntil` date to avoid being locked out of MFA-protected resources.

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
Reset-JcSdkUserMfa -Id:(<string>) -Body:(<JumpCloud.SDK.V1.Models.PathsYhix24SystemusersIdResetmfaPostRequestbodyContentApplicationJsonSchema>)
```



### -------------------------- EXAMPLE 2 --------------------------
```powershell
Reset-JcSdkUserMfa -Id:(<string>) -Exclusion:(<switch>) -ExclusionDays:(<float>) -ExclusionUntil:(<datetime>)
```



## PARAMETERS

### -Body
.

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

### -HostEnv
Region for JumpCloud API host.
Use 'console' for US or 'console.eu' for EU.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
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

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODY <IPathsYhix24SystemusersIdResetmfaPostRequestbodyContentApplicationJsonSchema>`: .
  - `[Exclusion <Boolean?>]`: 
  - `[ExclusionDays <Single?>]`: 
  - `[ExclusionUntil <DateTime?>]`: 

`INPUTOBJECT <IJumpCloudApiIdentity>`: Identity Parameter
  - `[Id <String>]`: 
  - `[SystemId <String>]`: 
  - `[SystemuserId <String>]`: 
  - `[Triggername <String>]`: 

## RELATED LINKS

