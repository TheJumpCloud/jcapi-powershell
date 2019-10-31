---
external help file:
Module Name: JumpCloudApiSdkV1
online version: https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv1/set-jcsdksystem
schema: 2.0.0
---

# Set-JcSdkSystem

## SYNOPSIS
This endpoint allows you to update a system.\n\n#### Sample Request \n```\ncurl -X PUT https://console.jumpcloud.com/api/systems/{SystemID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n\t\"displayName\":\"Name_Update\",\n\t\"allowSshPasswordAuthentication\":\"true\",\n\t\"allowSshRootLogin\":\"true\",\n\t\"allowMultiFactorAuthentication\":\"true\",\n\t\"allowPublicKeyAuthentication\":\"false\"\n}'\n```

## SYNTAX

### PutExpanded (Default)
```
Set-JcSdkSystem -Id <String> [-Authorization <String>] [-Date <String>]
 [-AgentBoundMessages <ISystemputAgentBoundMessagesItem[]>] [-AllowMultiFactorAuthentication]
 [-AllowPublicKeyAuthentication] [-AllowSshPasswordAuthentication] [-AllowSshRootLogin]
 [-DisplayName <String>] [-Tags <String[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Put
```
Set-JcSdkSystem -Id <String> -Body <ISystemput> [-Authorization <String>] [-Date <String>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### PutViaIdentity
```
Set-JcSdkSystem -InputObject <IJumpCloudApIsIdentity> -Body <ISystemput> [-Authorization <String>]
 [-Date <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### PutViaIdentityExpanded
```
Set-JcSdkSystem -InputObject <IJumpCloudApIsIdentity> [-Authorization <String>] [-Date <String>]
 [-AgentBoundMessages <ISystemputAgentBoundMessagesItem[]>] [-AllowMultiFactorAuthentication]
 [-AllowPublicKeyAuthentication] [-AllowSshPasswordAuthentication] [-AllowSshRootLogin]
 [-DisplayName <String>] [-Tags <String[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
This endpoint allows you to update a system.\n\n#### Sample Request \n```\ncurl -X PUT https://console.jumpcloud.com/api/systems/{SystemID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n\t\"displayName\":\"Name_Update\",\n\t\"allowSshPasswordAuthentication\":\"true\",\n\t\"allowSshRootLogin\":\"true\",\n\t\"allowMultiFactorAuthentication\":\"true\",\n\t\"allowPublicKeyAuthentication\":\"false\"\n}'\n```

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
To view examples, please use the -Online parameter with Get-Help or navigate to: https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv1/set-jcsdksystem
```



## PARAMETERS

### -AgentBoundMessages
HELP MESSAGE MISSING
To construct, see NOTES section for AGENTBOUNDMESSAGES properties and create a hash table.

```yaml
Type: JumpCloudApiSdkV1.Models.ISystemputAgentBoundMessagesItem[]
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -AllowMultiFactorAuthentication
HELP MESSAGE MISSING

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -AllowPublicKeyAuthentication
HELP MESSAGE MISSING

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -AllowSshPasswordAuthentication
HELP MESSAGE MISSING

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -AllowSshRootLogin
HELP MESSAGE MISSING

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Authorization
Authorization header for the System Context API

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Body
SystemPut
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: JumpCloudApiSdkV1.Models.ISystemput
Parameter Sets: Put, PutViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -Date
Current date header for the System Context API

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -DisplayName
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

### JumpCloudApiSdkV1.Models.IJumpCloudApIsIdentity

### JumpCloudApiSdkV1.Models.ISystemput

## OUTPUTS

### JumpCloudApiSdkV1.Models.IJcSystem

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### AGENTBOUNDMESSAGES <ISystemputAgentBoundMessagesItem[]>: HELP MESSAGE MISSING
  - `[Cmd <String>]`: 

#### BODY <ISystemput>: SystemPut
  - `[AgentBoundMessages <ISystemputAgentBoundMessagesItem[]>]`: 
    - `[Cmd <String>]`: 
  - `[AllowMultiFactorAuthentication <Boolean?>]`: 
  - `[AllowPublicKeyAuthentication <Boolean?>]`: 
  - `[AllowSshPasswordAuthentication <Boolean?>]`: 
  - `[AllowSshRootLogin <Boolean?>]`: 
  - `[DisplayName <String>]`: 
  - `[Tags <String[]>]`: 

#### INPUTOBJECT <IJumpCloudApIsIdentity>: Identity Parameter
  - `[Id <String>]`: 
  - `[SystemuserId <String>]`: 
  - `[Triggername <String>]`: 

## RELATED LINKS

