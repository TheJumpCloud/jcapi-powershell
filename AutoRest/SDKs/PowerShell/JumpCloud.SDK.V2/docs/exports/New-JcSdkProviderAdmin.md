---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://docs.microsoft.com/en-us/powershell/module/jumpcloud.sdk.v2/new-jcsdkprovideradmin
schema: 2.0.0
---

# New-JcSdkProviderAdmin

## SYNOPSIS
This endpoint allows you to create a provider administrator.
You must be associated to the provider to use this route.\n\n**Sample Request**\n\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/providers/{ProviderID}/administrators \\\n    -H 'Accept: application/json' \\\n    -H 'Context-Type: application/json' \\\n    -H 'x-api-key: {API_KEY}' \\\n    -d '{\n      \"email\":\"{ADMIN_EMAIL}\"\n    }'\n```

## SYNTAX

### CreateExpanded (Default)
```
New-JcSdkProviderAdmin -ProviderId <String> -Email <String> [-EnableMultiFactor] [-Firstname <String>]
 [-Lastname <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-JcSdkProviderAdmin -ProviderId <String> -Body <IProviderAdminReq> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### CreateViaIdentity
```
New-JcSdkProviderAdmin -InputObject <IJumpCloudApIsIdentity> -Body <IProviderAdminReq> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-JcSdkProviderAdmin -InputObject <IJumpCloudApIsIdentity> -Email <String> [-EnableMultiFactor]
 [-Firstname <String>] [-Lastname <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
This endpoint allows you to create a provider administrator.
You must be associated to the provider to use this route.\n\n**Sample Request**\n\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/providers/{ProviderID}/administrators \\\n    -H 'Accept: application/json' \\\n    -H 'Context-Type: application/json' \\\n    -H 'x-api-key: {API_KEY}' \\\n    -d '{\n      \"email\":\"{ADMIN_EMAIL}\"\n    }'\n```

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
To view examples, please use the -Online parameter with Get-Help or navigate to: https://docs.microsoft.com/en-us/powershell/module/jumpcloud.sdk.v2/new-jcsdkprovideradmin
```



## PARAMETERS

### -Body
ProviderAdminReq
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: JumpCloud.SDK.V2.Models.IProviderAdminReq
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -Email
HELP MESSAGE MISSING

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -EnableMultiFactor
HELP MESSAGE MISSING

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Firstname
HELP MESSAGE MISSING

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
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
Parameter Sets: CreateViaIdentity, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -Lastname
HELP MESSAGE MISSING

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ProviderId
HELP MESSAGE MISSING

```yaml
Type: System.String
Parameter Sets: Create, CreateExpanded
Aliases:

Required: True
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

### JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity

### JumpCloud.SDK.V2.Models.IProviderAdminReq

## OUTPUTS

### JumpCloud.SDK.V2.Models.IAdministrator

### System.String

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### BODY <IProviderAdminReq>: ProviderAdminReq
  - `Email <String>`: 
  - `[EnableMultiFactor <Boolean?>]`: 
  - `[Firstname <String>]`: 
  - `[Lastname <String>]`: 

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

