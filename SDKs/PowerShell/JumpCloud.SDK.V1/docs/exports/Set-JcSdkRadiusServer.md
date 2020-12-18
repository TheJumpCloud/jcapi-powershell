---
external help file:
Module Name: JumpCloud.SDK.V1
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V1/docs/exports/Set-JcSdkRadiusServer.md
schema: 2.0.0
---

# Set-JcSdkRadiusServer

## SYNOPSIS
This endpoint allows you to update RADIUS servers in your organization.\n\n####\n```\ncurl -X PUT https://console.jumpcloud.com/api/radiusservers/{ServerID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n    \"name\": \"{name_update}\",\n    \"networkSourceIp\": \"{0.0.0.0}\",\n    \"sharedSecret\": \"{secret_password}\",\n    \"userLockoutAction\": \"REMOVE\",\n    \"userPasswordExpirationAction\": \"MAINTAIN\"\n}'\n```

## SYNTAX

### SetExpanded (Default)
```
Set-JcSdkRadiusServer -Id <String> -Name <String> -NetworkSourceIP <String> -SharedSecret <String>
 [-Mfa <Mfa>] [-UserLockoutAction <String>] [-UserPasswordExpirationAction <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Set
```
Set-JcSdkRadiusServer -Id <String>
 -Body <IPathsKeqea5RadiusserversIdPutRequestbodyContentApplicationJsonSchema> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### SetViaIdentity
```
Set-JcSdkRadiusServer -InputObject <IJumpCloudApIsIdentity>
 -Body <IPathsKeqea5RadiusserversIdPutRequestbodyContentApplicationJsonSchema> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### SetViaIdentityExpanded
```
Set-JcSdkRadiusServer -InputObject <IJumpCloudApIsIdentity> -Name <String> -NetworkSourceIP <String>
 -SharedSecret <String> [-Mfa <Mfa>] [-UserLockoutAction <String>] [-UserPasswordExpirationAction <String>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
This endpoint allows you to update RADIUS servers in your organization.\n\n####\n```\ncurl -X PUT https://console.jumpcloud.com/api/radiusservers/{ServerID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n    \"name\": \"{name_update}\",\n    \"networkSourceIp\": \"{0.0.0.0}\",\n    \"sharedSecret\": \"{secret_password}\",\n    \"userLockoutAction\": \"REMOVE\",\n    \"userPasswordExpirationAction\": \"MAINTAIN\"\n}'\n```

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
Type: JumpCloud.SDK.V1.Models.IPathsKeqea5RadiusserversIdPutRequestbodyContentApplicationJsonSchema
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
Type: JumpCloud.SDK.V1.Models.IJumpCloudApIsIdentity
Parameter Sets: SetViaIdentity, SetViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Mfa
.

```yaml
Type: JumpCloud.SDK.V1.Support.Mfa
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
.

```yaml
Type: System.String
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NetworkSourceIP
.

```yaml
Type: System.String
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SharedSecret
.

```yaml
Type: System.String
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserLockoutAction
.

```yaml
Type: System.String
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserPasswordExpirationAction
.

```yaml
Type: System.String
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

### JumpCloud.SDK.V1.Models.IJumpCloudApIsIdentity

### JumpCloud.SDK.V1.Models.IPathsKeqea5RadiusserversIdPutRequestbodyContentApplicationJsonSchema

## OUTPUTS

### JumpCloud.SDK.V1.Models.IRadiusServerSetResponse

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODY <IPathsKeqea5RadiusserversIdPutRequestbodyContentApplicationJsonSchema>: .
  - `Name <String>`: 
  - `NetworkSourceIP <String>`: 
  - `SharedSecret <String>`: 
  - `[Mfa <Mfa?>]`: 
  - `[UserLockoutAction <String>]`: 
  - `[UserPasswordExpirationAction <String>]`: 

INPUTOBJECT <IJumpCloudApIsIdentity>: Identity Parameter
  - `[Id <String>]`: 
  - `[SystemId <String>]`: 
  - `[SystemuserId <String>]`: 
  - `[Triggername <String>]`: 

## RELATED LINKS

