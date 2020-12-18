---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/New-JcSdkIPList.md
schema: 2.0.0
---

# New-JcSdkIPList

## SYNOPSIS
Create an IP list.\n\n#### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/iplists \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n  \"name\": \"Sample IP List\",\n  \"ips\": [\n    \"192.168.10.12\",\n    \"192.168.10.20 - 192.168.10.30\",\n    \"123.225.10.0/32\"\n  ]\n}'\n```

## SYNTAX

### CreateExpanded (Default)
```
New-JcSdkIPList [-Description <String>] [-Ips <String[]>] [-Name <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-JcSdkIPList -Body <IIPListRequest> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create an IP list.\n\n#### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/iplists \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n  \"name\": \"Sample IP List\",\n  \"ips\": [\n    \"192.168.10.12\",\n    \"192.168.10.20 - 192.168.10.30\",\n    \"123.225.10.0/32\"\n  ]\n}'\n```

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
IPListRequest
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: JumpCloud.SDK.V2.Models.IIPListRequest
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Description
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Ips
.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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

### JumpCloud.SDK.V2.Models.IIPListRequest

## OUTPUTS

### JumpCloud.SDK.V2.Models.IIPList

### System.String

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODY <IIPListRequest>: IPListRequest
  - `[Description <String>]`: 
  - `[Ips <String[]>]`: 
  - `[Name <String>]`: 

## RELATED LINKS

