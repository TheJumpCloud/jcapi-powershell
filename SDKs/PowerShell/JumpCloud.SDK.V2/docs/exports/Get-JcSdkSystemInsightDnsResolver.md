---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Get-JcSdkSystemInsightDnsResolver.md
schema: 2.0.0
---

# Get-JcSdkSystemInsightDnsResolver

## SYNOPSIS
Valid filter fields are `system_id` and `type`.

## SYNTAX

```
Get-JcSdkSystemInsightDnsResolver [-Filter <String[]>] [-Sort <String[]>] [-CreationSource <String>]
 [<CommonParameters>]
```

## DESCRIPTION
Valid filter fields are `system_id` and `type`.

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

### -CreationSource
Defines the creation-source header for gapps, o365 and workdays requests.
If the header isn't sent, the default value is `jumpcloud:bulk`, if you send the header with a malformed value you receive a 400 error.
Allowed: `jumpcloud:gapps`, `jumpcloud:o365`, `jumpcloud:workday`, `jumpcloud:bulk`.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Filter
Supported operators are: eq, in.
e.g:
Filter for single value:
`filter=field:eq:value`
Filter for any value in a list: (note “pipe” character: `|` separating values)
`filter=field:in:value1|value2|value3`

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
e.g:
Sort by single field:
`sort=field`
Sort descending by single field:
`sort=-field`
Sort by multiple fields:
`sort=field1,-field2,field3`

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

### JumpCloud.SDK.V2.Models.ISystemInsightsDnsResolvers

## NOTES

ALIASES

## RELATED LINKS

