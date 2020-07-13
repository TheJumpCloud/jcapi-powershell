---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/jumpcloud.sdk.v2/get-jcsdkapplemdmdevice
schema: 2.0.0
---

# Get-JcSdkAppleMdmDevice

## SYNOPSIS
Lists all Apple MDM devices.\n\nThe filter and sort queries will allow the following fields:\n`createdAt`\n`depRegistered`\n`enrolled`\n`id`\n`osVersion`\n`serialNumber`\n`udid`\n\n#### Sample Request\n```\n  curl -X GET https://console.jumpcloud.com/api/v2/applemdms/{apple_mdm_id}/devices \\\n  -H 'accept: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{}'\n```

## SYNTAX

```
Get-JcSdkAppleMdmDevice -AppleMdmId <String> [-Filter <String[]>] [-Sort <String[]>] [-XTotalCount <Int32>]
 [<CommonParameters>]
```

## DESCRIPTION
Lists all Apple MDM devices.\n\nThe filter and sort queries will allow the following fields:\n`createdAt`\n`depRegistered`\n`enrolled`\n`id`\n`osVersion`\n`serialNumber`\n`udid`\n\n#### Sample Request\n```\n  curl -X GET https://console.jumpcloud.com/api/v2/applemdms/{apple_mdm_id}/devices \\\n  -H 'accept: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{}'\n```

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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### JumpCloud.SDK.V2.Models.IAppleMdmDevice

### System.String

## NOTES

ALIASES

## RELATED LINKS
