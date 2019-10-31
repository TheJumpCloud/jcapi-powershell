---
external help file:
Module Name: JumpCloudApiSdkV1
online version: https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv1/set-jcsdkradiusserver
schema: 2.0.0
---

# Set-JcSdkRadiusServer

## SYNOPSIS
This endpoint allows you to update RADIUS servers in your organization.\n\n#### \n```\ncurl -X PUT https://console.jumpcloud.com/api/radiusservers/{ServerID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n    \"name\": \"{name_update}\",\n    \"networkSourceIp\": \"{0.0.0.0}\",\n    \"userLockoutAction\": \"REMOVE\",\n    \"userPasswordExpirationAction\": \"MAINTAIN\"\n}'\n```

## SYNTAX

### PutExpanded (Default)
```
Set-JcSdkRadiusServer -Id <String> -Name <String> -NetworkSourceIP <String> [-Mfa <String>] [-Tags <String[]>]
 [-UserLockoutAction <String>] [-UserPasswordExpirationAction <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Put
```
Set-JcSdkRadiusServer -Id <String> -Body <IBodyParameterRadiusServerPutRequestBody> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### PutViaIdentity
```
Set-JcSdkRadiusServer -InputObject <IJumpCloudApIsIdentity> -Body <IBodyParameterRadiusServerPutRequestBody>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### PutViaIdentityExpanded
```
Set-JcSdkRadiusServer -InputObject <IJumpCloudApIsIdentity> -Name <String> -NetworkSourceIP <String>
 [-Mfa <String>] [-Tags <String[]>] [-UserLockoutAction <String>] [-UserPasswordExpirationAction <String>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
This endpoint allows you to update RADIUS servers in your organization.\n\n#### \n```\ncurl -X PUT https://console.jumpcloud.com/api/radiusservers/{ServerID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n    \"name\": \"{name_update}\",\n    \"networkSourceIp\": \"{0.0.0.0}\",\n    \"userLockoutAction\": \"REMOVE\",\n    \"userPasswordExpirationAction\": \"MAINTAIN\"\n}'\n```

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
To view examples, please use the -Online parameter with Get-Help or navigate to: https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv1/set-jcsdkradiusserver
```



## PARAMETERS

### -Body
HELP MESSAGE MISSING
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: JumpCloudApiSdkV1.Models.IBodyParameterRadiusServerPutRequestBody
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
Type: JumpCloudApiSdkV1.Models.IJumpCloudApIsIdentity
Parameter Sets: PutViaIdentity, PutViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -Mfa
HELP MESSAGE MISSING

```yaml
Type: System.String
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Name
HELP MESSAGE MISSING

```yaml
Type: System.String
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -NetworkSourceIP
HELP MESSAGE MISSING

```yaml
Type: System.String
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Tags
HELP MESSAGE MISSING

```yaml
Type: System.String[]
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -UserLockoutAction
HELP MESSAGE MISSING

```yaml
Type: System.String
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -UserPasswordExpirationAction
HELP MESSAGE MISSING

```yaml
Type: System.String
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

### JumpCloudApiSdkV1.Models.IBodyParameterRadiusServerPutRequestBody

### JumpCloudApiSdkV1.Models.IJumpCloudApIsIdentity

## OUTPUTS

### JumpCloudApiSdkV1.Models.IRadiusserverput

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### BODY <IBodyParameterRadiusServerPutRequestBody>: HELP MESSAGE MISSING
  - `Name <String>`: 
  - `NetworkSourceIP <String>`: 
  - `[Mfa <String>]`: 
  - `[Tags <String[]>]`: 
  - `[UserLockoutAction <String>]`: 
  - `[UserPasswordExpirationAction <String>]`: 

#### INPUTOBJECT <IJumpCloudApIsIdentity>: Identity Parameter
  - `[Id <String>]`: 
  - `[SystemuserId <String>]`: 
  - `[Triggername <String>]`: 

## RELATED LINKS

