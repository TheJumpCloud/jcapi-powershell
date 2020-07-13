---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/jumpcloud.sdk.v2/get-jcsdkgraphactivedirectoryassociation
schema: 2.0.0
---

# Get-JcSdkGraphActiveDirectoryAssociation

## SYNOPSIS
This endpoint returns the direct associations of this Active Directory instance.\n\nA direct association can be a non-homogeneous relationship between 2 different objects, for example Active Directory and Users.\n\n\n#### Sample Request\n```\ncurl -X GET 'https://console.jumpcloud.com/api/v2/activedirectories/{ActiveDirectory_ID}/associations?targets=user \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

## SYNTAX

```
Get-JcSdkGraphActiveDirectoryAssociation -ActivedirectoryId <String> -Targets <String[]> [<CommonParameters>]
```

## DESCRIPTION
This endpoint returns the direct associations of this Active Directory instance.\n\nA direct association can be a non-homogeneous relationship between 2 different objects, for example Active Directory and Users.\n\n\n#### Sample Request\n```\ncurl -X GET 'https://console.jumpcloud.com/api/v2/activedirectories/{ActiveDirectory_ID}/associations?targets=user \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

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

### -ActivedirectoryId
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

### -Targets
.

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### JumpCloud.SDK.V2.Models.IGraphConnection

## NOTES

ALIASES

## RELATED LINKS

