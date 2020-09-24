---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Get-JcSdkGroup.md
schema: 2.0.0
---

# Get-JcSdkGroup

## SYNOPSIS
This endpoint returns all Groups that exist in your organization.\r\n\r\n#### Available filter fields:\r\n  - `name`\r\n  - `disabled`\r\n  - `type`\r\n\r\n#### Sample Request\r\n\r\n```\r\n  curl -X GET \\\r\n  https://console.jumpcloud.com/api/v2/groups \\\r\n  -H 'accept: application/json' \\\r\n  -H 'content-type: application/json' \\\r\n  -H 'x-api-key: {API_KEY}'\r\n```

## SYNTAX

```
Get-JcSdkGroup [-Fields <String[]>] [-Filter <String[]>] [-Sort <String[]>] [<CommonParameters>]
```

## DESCRIPTION
This endpoint returns all Groups that exist in your organization.\r\n\r\n#### Available filter fields:\r\n  - `name`\r\n  - `disabled`\r\n  - `type`\r\n\r\n#### Sample Request\r\n\r\n```\r\n  curl -X GET \\\r\n  https://console.jumpcloud.com/api/v2/groups \\\r\n  -H 'accept: application/json' \\\r\n  -H 'content-type: application/json' \\\r\n  -H 'x-api-key: {API_KEY}'\r\n```

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

### -Fields
The comma separated fields included in the returned records.
If omitted, the default list of fields will be returned.

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Filter
Supported operators are: eq, ne, gt, ge, lt, le, between, search, in

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Sort
The comma separated fields used to sort the collection.
Default sort is ascending, prefix with `-` to sort descending.

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### JumpCloud.SDK.V2.Models.IGroup

## NOTES

ALIASES

## RELATED LINKS

