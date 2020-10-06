---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Get-JcSdkGroup.md
schema: 2.0.0
---

# Get-JcSdkGroup

## SYNOPSIS
This endpoint returns all Groups that exist in your organization.\n\n#### Available filter fields:\n  - `name`\n  - `disabled`\n  - `type`\n\n#### Sample Request\n\n```\n  curl -X GET \\\n  https://console.jumpcloud.com/api/v2/groups \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

## SYNTAX

```
Get-JcSdkGroup [-Fields <String[]>] [-Filter <String[]>] [-Sort <String[]>] [-XTotalCount <Int32>]
 [-XUnfilteredTotalCount <Int32>] [<CommonParameters>]
```

## DESCRIPTION
This endpoint returns all Groups that exist in your organization.\n\n#### Available filter fields:\n  - `name`\n  - `disabled`\n  - `type`\n\n#### Sample Request\n\n```\n  curl -X GET \\\n  https://console.jumpcloud.com/api/v2/groups \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

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
A filter to apply to the query.
**Filter structure**: `\<field\>:\<operator\>:\<value\>`.
**field** = Populate with a valid field from an endpoint response.
**operator** = Supported operators are: eq, ne, gt, ge, lt, le, between, search, in.
**value** = Populate with the value you want to search for.
Is case sensitive.
Supports wild cards.
**EX:** `GET /users?username=eq:testuser`

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

### -XTotalCount
.

```yaml
Type: System.Int32
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -XUnfilteredTotalCount
If provided in the request with any non-empty value, this header will be returned on the response populated with the total count of objects without filters taken into account

```yaml
Type: System.Int32
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

