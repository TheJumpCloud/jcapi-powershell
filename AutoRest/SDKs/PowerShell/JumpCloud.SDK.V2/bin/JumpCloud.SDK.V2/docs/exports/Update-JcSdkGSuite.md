---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://docs.microsoft.com/en-us/powershell/module/jumpcloud.sdk.v2/update-jcsdkgsuite
schema: 2.0.0
---

# Update-JcSdkGSuite

## SYNOPSIS
This endpoint allows updating some attributes of a G Suite.\n\n##### Sample Request\n\n```\ncurl -X PATCH https://console.jumpcloud.com/api/v2/gsuites/{GSUITE_ID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n    \"userLockoutAction\": \"suspend\",\n    \"userPasswordExpirationAction\": \"maintain\"\n  }'\n```

## SYNTAX

### PatchExpanded (Default)
```
Update-JcSdkGSuite -Id <String> [-UserLockoutAction <String>] [-UserPasswordExpirationAction <String>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Patch
```
Update-JcSdkGSuite -Id <String> -Body <IGsuitePatchInput> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### PatchViaIdentity
```
Update-JcSdkGSuite -InputObject <IJumpCloudApIsIdentity> -Body <IGsuitePatchInput> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### PatchViaIdentityExpanded
```
Update-JcSdkGSuite -InputObject <IJumpCloudApIsIdentity> [-UserLockoutAction <String>]
 [-UserPasswordExpirationAction <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
This endpoint allows updating some attributes of a G Suite.\n\n##### Sample Request\n\n```\ncurl -X PATCH https://console.jumpcloud.com/api/v2/gsuites/{GSUITE_ID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n    \"userLockoutAction\": \"suspend\",\n    \"userPasswordExpirationAction\": \"maintain\"\n  }'\n```

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
To view examples, please use the -Online parameter with Get-Help or navigate to: https://docs.microsoft.com/en-us/powershell/module/jumpcloud.sdk.v2/update-jcsdkgsuite
```



## PARAMETERS

### -Body
GSuite Patch Input
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: JumpCloud.SDK.V2.Models.IGsuitePatchInput
Parameter Sets: Patch, PatchViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -Id
Unique identifier of the GSuite.

```yaml
Type: System.String
Parameter Sets: Patch, PatchExpanded
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
Type: JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity
Parameter Sets: PatchViaIdentity, PatchViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -UserLockoutAction
HELP MESSAGE MISSING

```yaml
Type: System.String
Parameter Sets: PatchExpanded, PatchViaIdentityExpanded
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
Parameter Sets: PatchExpanded, PatchViaIdentityExpanded
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

### JumpCloud.SDK.V2.Models.IGsuitePatchInput

### JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity

## OUTPUTS

### JumpCloud.SDK.V2.Models.IGsuiteOutput

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### BODY <IGsuitePatchInput>: GSuite Patch Input
  - `[UserLockoutAction <String>]`: 
  - `[UserPasswordExpirationAction <String>]`: 

#### INPUTOBJECT <IJumpCloudApIsIdentity>: Identity Parameter
  - `[AccountId <String>]`: 
  - `[ActivedirectoryId <String>]`: ObjectID of the Active Directory instance.
  - `[ApplicationId <String>]`: 
  - `[CommandId <String>]`: ObjectID of the Command.
  - `[GroupId <String>]`: ObjectID of the User Group.
  - `[GsuiteId <String>]`: ObjectID of the G Suite instance.
  - `[Id <String>]`: ObjectID of the User Group.
  - `[JobId <String>]`: 
  - `[LdapserverId <String>]`: ObjectID of the LDAP Server.
  - `[Office365Id <String>]`: ObjectID of the Office 365 instance.
  - `[PolicyId <String>]`: 
  - `[ProviderId <String>]`: 
  - `[RadiusserverId <String>]`: ObjectID of the Radius Server.
  - `[SystemId <String>]`: ObjectID of the System.
  - `[UserId <String>]`: ObjectID of the User.
  - `[WorkdayId <String>]`: 

## RELATED LINKS

