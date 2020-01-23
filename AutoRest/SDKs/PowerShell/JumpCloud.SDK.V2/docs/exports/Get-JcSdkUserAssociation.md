---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://docs.microsoft.com/en-us/powershell/module/jumpcloud.sdk.v2/get-jcsdkuserassociation
schema: 2.0.0
---

# Get-JcSdkUserAssociation

## SYNOPSIS
This endpoint returns the _direct_ associations of a User.\n\nA direct association can be a non-homogeneous relationship between 2 different objects, for example Users and Systems.\n\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/users/{UserID}/associations?targets=system_group \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n\n```

## SYNTAX

```
Get-JcSdkUserAssociation -UserId <String> -Targets <String[]> [-Limit <Int32>] [-Skip <Int32>]
 [<CommonParameters>]
```

## DESCRIPTION
This endpoint returns the _direct_ associations of a User.\n\nA direct association can be a non-homogeneous relationship between 2 different objects, for example Users and Systems.\n\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/users/{UserID}/associations?targets=system_group \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n\n```

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
To view examples, please use the -Online parameter with Get-Help or navigate to: https://docs.microsoft.com/en-us/powershell/module/jumpcloud.sdk.v2/get-jcsdkuserassociation
```



## PARAMETERS

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

### -Targets
HELP MESSAGE MISSING

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -UserId
ObjectID of the User.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
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

### JumpCloud.SDK.V2.Models.IGraphConnection

## ALIASES

## NOTES

## RELATED LINKS

