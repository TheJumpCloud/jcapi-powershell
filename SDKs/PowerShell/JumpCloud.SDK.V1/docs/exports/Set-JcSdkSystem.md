---
external help file:
Module Name: JumpCloud.SDK.V1
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V1/docs/exports/Set-JcSdkSystem.md
schema: 2.0.0
---

# Set-JcSdkSystem

## SYNOPSIS
This endpoint allows you to update a system.

#### Sample Request 
```
curl -X PUT https://console.jumpcloud.com/api/systems/{SystemID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
\t\"displayName\":\"Name_Update\",
\t\"allowSshPasswordAuthentication\":\"true\",
\t\"allowSshRootLogin\":\"true\",
\t\"allowMultiFactorAuthentication\":\"true\",
\t\"allowPublicKeyAuthentication\":\"false\"
}'
```

## SYNTAX

### SetExpanded (Default)
```
Set-JcSdkSystem -Id <String> [-AgentBoundMessages <ISystemputAgentBoundMessagesItem[]>]
 [-AllowMultiFactorAuthentication] [-AllowPublicKeyAuthentication] [-AllowSshPasswordAuthentication]
 [-AllowSshRootLogin] [-DisplayName <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Set
```
Set-JcSdkSystem -Id <String> -Body <ISystemput> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### SetViaIdentity
```
Set-JcSdkSystem -InputObject <IJumpCloudApiIdentity> -Body <ISystemput> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### SetViaIdentityExpanded
```
Set-JcSdkSystem -InputObject <IJumpCloudApiIdentity>
 [-AgentBoundMessages <ISystemputAgentBoundMessagesItem[]>] [-AllowMultiFactorAuthentication]
 [-AllowPublicKeyAuthentication] [-AllowSshPasswordAuthentication] [-AllowSshRootLogin]
 [-DisplayName <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
This endpoint allows you to update a system.

#### Sample Request 
```
curl -X PUT https://console.jumpcloud.com/api/systems/{SystemID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
\t\"displayName\":\"Name_Update\",
\t\"allowSshPasswordAuthentication\":\"true\",
\t\"allowSshRootLogin\":\"true\",
\t\"allowMultiFactorAuthentication\":\"true\",
\t\"allowPublicKeyAuthentication\":\"false\"
}'
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

### -AgentBoundMessages
.
To construct, see NOTES section for AGENTBOUNDMESSAGES properties and create a hash table.

```yaml
Type: JumpCloud.SDK.V1.Models.ISystemputAgentBoundMessagesItem[]
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AllowMultiFactorAuthentication
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AllowPublicKeyAuthentication
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AllowSshPasswordAuthentication
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AllowSshRootLogin
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Body
SystemPut
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: JumpCloud.SDK.V1.Models.ISystemput
Parameter Sets: Set, SetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DisplayName
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
Type: JumpCloud.SDK.V1.Models.IJumpCloudApiIdentity
Parameter Sets: SetViaIdentity, SetViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### JumpCloud.SDK.V1.Models.ISystemput

## OUTPUTS

### JumpCloud.SDK.V1.Models.IJcSystem

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


AGENTBOUNDMESSAGES <ISystemputAgentBoundMessagesItem[]>: .
  - `[Cmd <String>]`: 

BODY <ISystemput>: SystemPut
  - `[AgentBoundMessages <ISystemputAgentBoundMessagesItem[]>]`: 
    - `[Cmd <String>]`: 
  - `[AllowMultiFactorAuthentication <Boolean?>]`: 
  - `[AllowPublicKeyAuthentication <Boolean?>]`: 
  - `[AllowSshPasswordAuthentication <Boolean?>]`: 
  - `[AllowSshRootLogin <Boolean?>]`: 
  - `[DisplayName <String>]`: 

INPUTOBJECT <IJumpCloudApiIdentity>: Identity Parameter
  - `[Id <String>]`: 
  - `[SystemId <String>]`: 
  - `[SystemuserId <String>]`: 
  - `[Triggername <String>]`: 

## RELATED LINKS

