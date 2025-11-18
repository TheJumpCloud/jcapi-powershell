---
external help file:
Module Name: JumpCloud.SDK.V1
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V1/docs/exports/Get-JcSdkCommandResultByCommandId.md
schema: 2.0.0
---

# Get-JcSdkCommandResultByCommandId

## SYNOPSIS
This endpoint returns results for a specific command.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/commands/{id}/results \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
  ````

## SYNTAX

### Get (Default)
```
Get-JcSdkCommandResultByCommandId -ConsoleHost <String> -Id <String> [<CommonParameters>]
```

### GetViaIdentity
```
Get-JcSdkCommandResultByCommandId -ConsoleHost <String> -InputObject <IJumpCloudApiIdentity>
 [<CommonParameters>]
```

## DESCRIPTION
This endpoint returns results for a specific command.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/commands/{id}/results \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
  ````

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
get-JcSdkCommandResultByCommandId -Id 6406532738e1a32cafa24260
```



## PARAMETERS

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
.

```yaml
Type: System.String
Parameter Sets: Get
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
Parameter Sets: GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### JumpCloud.SDK.V1.Models.IJumpCloudApiIdentity

## OUTPUTS

### JumpCloud.SDK.V1.Models.ICommandresultbycommandid

## NOTES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`INPUTOBJECT <IJumpCloudApiIdentity>`: Identity Parameter
  - `[Id <String>]`: 
  - `[SystemId <String>]`: 
  - `[SystemuserId <String>]`: 
  - `[Triggername <String>]`: 

## RELATED LINKS

