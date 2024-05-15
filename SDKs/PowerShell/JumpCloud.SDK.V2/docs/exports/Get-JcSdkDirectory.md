---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Get-JcSdkDirectory.md
schema: 2.0.0
---

# Get-JcSdkDirectory

## SYNOPSIS
This endpoint returns all active directories (LDAP, O365 Suite, G-Suite).

#### Sample Request
```
 curl -X GET https://console.jumpcloud.com/api/v2/directories \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

## SYNTAX

```
Get-JcSdkDirectory [-Fields <String[]>] [-Sort <String[]>] [<CommonParameters>]
```

## DESCRIPTION
This endpoint returns all active directories (LDAP, O365 Suite, G-Suite).

#### Sample Request
```
 curl -X GET https://console.jumpcloud.com/api/v2/directories \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Get-JcSdkDirectory
```

----                ----------
DefaultDomainDomain String
DefaultDomainId     String
Id                  String
Name                String
OAuthStatus         JumpCloud.SDK.V2.Models.DirectoryOAuthStatus
Type                String

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

### JumpCloud.SDK.V2.Models.IDirectory

## NOTES

ALIASES

## RELATED LINKS

