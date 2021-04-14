---
external help file:
Module Name: JumpCloud.SDK.V1
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V1/docs/exports/Invoke-JcSdkCommandTrigger.md
schema: 2.0.0
---

# Invoke-JcSdkCommandTrigger

## SYNOPSIS
This endpoint allows you to launch a command based on a defined trigger.

#### Sample Requests

**Launch a Command via a Trigger**

```
curl --silent \\
     -X 'POST' \\
     -H \"x-api-key: {API_KEY}\" \\
     \"https://console.jumpcloud.com/api/command/trigger/{TriggerName}\"
```
**Launch a Command via a Trigger passing a JSON object to the command**
```
curl --silent \\
     -X 'POST' \\
     -H \"x-api-key: {API_KEY}\" \\
     -H 'Accept: application/json' \\
     -H 'Content-Type: application/json' \\
     -d '{ \"srcip\":\"192.168.2.32\", \"attack\":\"Cross Site Scripting Attempt\" }' \\
     \"https://console.jumpcloud.com/api/command/trigger/{TriggerName}\"
```

## SYNTAX

### PostExpanded (Default)
```
Invoke-JcSdkCommandTrigger -Triggername <String> [-AdditionalProperties <Hashtable>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Post
```
Invoke-JcSdkCommandTrigger -Triggername <String> -Body <Hashtable> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### PostViaIdentity
```
Invoke-JcSdkCommandTrigger -InputObject <IJumpCloudApIsIdentity> -Body <Hashtable> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### PostViaIdentityExpanded
```
Invoke-JcSdkCommandTrigger -InputObject <IJumpCloudApIsIdentity> [-AdditionalProperties <Hashtable>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
This endpoint allows you to launch a command based on a defined trigger.

#### Sample Requests

**Launch a Command via a Trigger**

```
curl --silent \\
     -X 'POST' \\
     -H \"x-api-key: {API_KEY}\" \\
     \"https://console.jumpcloud.com/api/command/trigger/{TriggerName}\"
```
**Launch a Command via a Trigger passing a JSON object to the command**
```
curl --silent \\
     -X 'POST' \\
     -H \"x-api-key: {API_KEY}\" \\
     -H 'Accept: application/json' \\
     -H 'Content-Type: application/json' \\
     -d '{ \"srcip\":\"192.168.2.32\", \"attack\":\"Cross Site Scripting Attempt\" }' \\
     \"https://console.jumpcloud.com/api/command/trigger/{TriggerName}\"
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

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: PostExpanded, PostViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Body
Dictionary of \<any\>

```yaml
Type: System.Collections.Hashtable
Parameter Sets: Post, PostViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: JumpCloud.SDK.V1.Models.IJumpCloudApIsIdentity
Parameter Sets: PostViaIdentity, PostViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Triggername
.

```yaml
Type: System.String
Parameter Sets: Post, PostExpanded
Aliases:

Required: True
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

### System.Collections.Hashtable

## OUTPUTS

### System.String

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


INPUTOBJECT <IJumpCloudApIsIdentity>: Identity Parameter
  - `[Id <String>]`: 
  - `[SystemId <String>]`: 
  - `[SystemuserId <String>]`: 
  - `[Triggername <String>]`: 

## RELATED LINKS

