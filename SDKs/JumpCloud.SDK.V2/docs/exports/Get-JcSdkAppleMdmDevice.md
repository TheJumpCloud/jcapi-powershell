---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Get-JcSdkAppleMdmDevice.md
schema: 2.0.0
---

# Get-JcSdkAppleMdmDevice

## SYNOPSIS
Lists all Apple MDM devices.

The filter and sort queries will allow the following fields:
`createdAt`
`depRegistered`
`enrolled`
`id`
`osVersion`
`serialNumber`
`udid`

#### Sample Request
```
  curl -X GET https://console.jumpcloud.com/api/v2/applemdms/{apple_mdm_id}/devices \\
  -H 'accept: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{}'
```

## SYNTAX

```
Get-JcSdkAppleMdmDevice -AppleMdmId <String> [-Filter <String[]>] [-Sort <String[]>] [-XTotalCount <Int32>]
 [-XUnfilteredTotalCount <Int32>] [<CommonParameters>]
```

## DESCRIPTION
Lists all Apple MDM devices.

The filter and sort queries will allow the following fields:
`createdAt`
`depRegistered`
`enrolled`
`id`
`osVersion`
`serialNumber`
`udid`

#### Sample Request
```
  curl -X GET https://console.jumpcloud.com/api/v2/applemdms/{apple_mdm_id}/devices \\
  -H 'accept: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{}'
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

### -AppleMdmId
.

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

### -Filter
A filter to apply to the query.
**Filter structure**: `\<field\>:\<operator\>:\<value\>`.
**field** = Populate with a valid field from an endpoint response.
**operator** = Supported operators are: eq, ne, gt, ge, lt, le, between, search, in.
**value** = Populate with the value you want to search for.
Is case sensitive.
Supports wild cards.
**EX:** `GET /api/v2/groups?filter=name:eq:Test+Group`

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

### JumpCloud.SDK.V2.Models.IAppleMdmDevice

## NOTES

ALIASES

## RELATED LINKS

