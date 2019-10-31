---
external help file:
Module Name: JumpCloudApiSdkV2
online version: https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv2/new-jcsdkworkdayimportworkdayauthorization
schema: 2.0.0
---

# New-JcSdkWorkdayImportWorkdayAuthorization

## SYNOPSIS
This endpoint adds an authorization method to a workday instance.\n\nYou must supply a username and password for `Basic Authentication` that is the same as your WorkDay Integrator System User.
Failure to provide these credentials  will result in the request being rejected.\n\nCurrently `O-Auth` isn't a supported authentication protocol for WorkDay, but will be in the future.\n\n#### Sample Request\n\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/workdays/{WorkDayID}/auth \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n\t\"auth\":{\n\t  \"basic\": {\n\t\t\"username\": \"someDeveloper\",\t  \n\t\t\"password\": \"notTheRealPassword\"\n\n\t  }\n\t}\n}'\n\n```

## SYNTAX

### CreateExpanded (Default)
```
New-JcSdkWorkdayImportWorkdayAuthorization -WorkdayId <String> [-BasicPassword <String>]
 [-BasicUsername <String>] [-OauthCode <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-JcSdkWorkdayImportWorkdayAuthorization -WorkdayId <String> -Body <IAuthInputObject> [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-JcSdkWorkdayImportWorkdayAuthorization -InputObject <IJumpCloudApIsIdentity> -Body <IAuthInputObject>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-JcSdkWorkdayImportWorkdayAuthorization -InputObject <IJumpCloudApIsIdentity> [-BasicPassword <String>]
 [-BasicUsername <String>] [-OauthCode <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
This endpoint adds an authorization method to a workday instance.\n\nYou must supply a username and password for `Basic Authentication` that is the same as your WorkDay Integrator System User.
Failure to provide these credentials  will result in the request being rejected.\n\nCurrently `O-Auth` isn't a supported authentication protocol for WorkDay, but will be in the future.\n\n#### Sample Request\n\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/workdays/{WorkDayID}/auth \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n\t\"auth\":{\n\t  \"basic\": {\n\t\t\"username\": \"someDeveloper\",\t  \n\t\t\"password\": \"notTheRealPassword\"\n\n\t  }\n\t}\n}'\n\n```

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
To view examples, please use the -Online parameter with Get-Help or navigate to: https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv2/new-jcsdkworkdayimportworkdayauthorization
```



## PARAMETERS

### -BasicPassword
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

### -BasicUsername
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

### -Body
Auth Input Object
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: JumpCloudApiSdkV2.Models.IAuthInputObject
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentity
Parameter Sets: CreateViaIdentity, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -OauthCode
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

### -WorkdayId
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

### JumpCloudApiSdkV2.Models.IAuthInputObject

### JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentity

## OUTPUTS

### System.Boolean

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### BODY <IAuthInputObject>: Auth Input Object
  - `[BasicPassword <String>]`: 
  - `[BasicUsername <String>]`: 
  - `[OauthCode <String>]`: 

#### INPUTOBJECT <IJumpCloudApIsIdentity>: Identity Parameter
  - `[ActivedirectoryId <String>]`: ObjectID of the Active Directory instance.
  - `[ApplicationId <String>]`: ObjectID of the Application.
  - `[CommandId <String>]`: ObjectID of the Command.
  - `[GroupId <String>]`: ObjectID of the User Group.
  - `[GsuiteId <String>]`: ObjectID of the G Suite instance.
  - `[Id <String>]`: 
  - `[JobId <String>]`: 
  - `[LdapserverId <String>]`: ObjectID of the LDAP Server.
  - `[Office365Id <String>]`: ObjectID of the Office 365 instance.
  - `[PolicyId <String>]`: ObjectID of the Policy.
  - `[ProviderId <String>]`: 
  - `[RadiusserverId <String>]`: ObjectID of the Radius Server.
  - `[SystemId <String>]`: 
  - `[UserId <String>]`: ObjectID of the User.
  - `[WorkdayId <String>]`: 

## RELATED LINKS

