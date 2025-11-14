---
external help file:
Module Name: JumpCloud.SDK.V1
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V1/docs/exports/Start-JcSdkCommand.md
schema: 2.0.0
---

# Start-JcSdkCommand

## SYNOPSIS
This endpoint allows you to run a command.
#### Sample Request

```
curl -X POST https://console.jumpcloud.com/api/runCommand \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
  -d '{\"_id\":\"{commandID}\", \"systemIds\":[\"systemId\"]}'
```

## SYNTAX

### RunExpanded (Default)
```
Start-JcSdkCommand -ConsoleHost <String> [-Id <String>] [-SystemIds <String[]>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Run
```
Start-JcSdkCommand -ConsoleHost <String>
 -Body <IPathsPnxbyeRuncommandPostRequestbodyContentApplicationJsonSchema> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
This endpoint allows you to run a command.
#### Sample Request

```
curl -X POST https://console.jumpcloud.com/api/runCommand \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
  -d '{\"_id\":\"{commandID}\", \"systemIds\":[\"systemId\"]}'
```

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Start-JcSdkCommand -Body:(<JumpCloud.SDK.V1.Models.PathsPnxbyeRuncommandPostRequestbodyContentApplicationJsonSchema>)
```

----               ----------
QueueIds           String
WorkflowInstanceId String

### -------------------------- EXAMPLE 2 --------------------------
```powershell
Start-JcSdkCommand -Id:(<string>) -SystemIds:(<string[]>)
```

----               ----------
QueueIds           String
WorkflowInstanceId String

## PARAMETERS

### -Body
.

```yaml
Type: JumpCloud.SDK.V1.Models.IPathsPnxbyeRuncommandPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Run
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ConsoleHost
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
The ID of the command.

```yaml
Type: System.String
Parameter Sets: RunExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SystemIds
An optional list of device IDs to run the command on.
If omitted, the command will run on devices bound to the command.

```yaml
Type: System.String[]
Parameter Sets: RunExpanded
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

### JumpCloud.SDK.V1.Models.IPathsPnxbyeRuncommandPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### JumpCloud.SDK.V1.Models.IPaths3Rrc57RuncommandPostResponses200ContentApplicationJsonSchema

## NOTES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODY <IPathsPnxbyeRuncommandPostRequestbodyContentApplicationJsonSchema>`: .
  - `[Id <String>]`: The ID of the command.
  - `[SystemIds <List<String>>]`: An optional list of device IDs to run the command on. If omitted, the command will run on devices bound to the command.

## RELATED LINKS

