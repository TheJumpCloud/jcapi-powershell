---
external help file:
Module Name: JumpCloud.SDK.V1
online version: https://docs.microsoft.com/en-us/powershell/module/jumpcloud.sdk.v1/get-jcsdkradiusserver
schema: 2.0.0
---

# Get-JcSdkRadiusServer

## SYNOPSIS
This endpoint allows you to get a list of all RADIUS servers in your organization.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/radiusservers/ \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n```

## SYNTAX

```
Get-JcSdkRadiusServer [-Fields <String>] [-Filter <String>] [-Limit <Int32>] [-Skip <Int32>] [-Sort <String>]
 [<CommonParameters>]
```

## DESCRIPTION
This endpoint allows you to get a list of all RADIUS servers in your organization.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/radiusservers/ \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n```

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
To view examples, please use the -Online parameter with Get-Help or navigate to: https://docs.microsoft.com/en-us/powershell/module/jumpcloud.sdk.v1/get-jcsdkradiusserver
```



## PARAMETERS

### -Fields
Use a space seperated string of field parameters to include the data in the response.
If omitted, the default list of fields will be returned.

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

### -Filter
A filter to apply to the query.

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

### -Limit
The number of records to return at once.
Limited to 100.

```yaml
Type: System.Int32
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Skip
The offset into the records to return.

```yaml
Type: System.Int32
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Sort
Use space separated sort parameters to sort the collection.
Default sort is ascending.
Prefix with `-` to sort descending.

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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### JumpCloud.SDK.V1.Models.IRadiusserverslist

## ALIASES

## NOTES

## RELATED LINKS

