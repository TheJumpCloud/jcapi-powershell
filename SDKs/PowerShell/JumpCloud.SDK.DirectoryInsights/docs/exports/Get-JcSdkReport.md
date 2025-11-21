---
external help file:
Module Name: JumpCloud.SDK.DirectoryInsights
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/CUT-4981_v2EUSupport/SDKs/PowerShell/JumpCloud.SDK.DirectoryInsights/docs/exports/Get-JcSdkReport.md
schema: 2.0.0
---

# Get-JcSdkReport

## SYNOPSIS
Ordered list of report metadata

## SYNTAX

```
Get-JcSdkReport -ApiHost <String> [-Sort <String>] [<CommonParameters>]
```

## DESCRIPTION
Ordered list of report metadata

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Get-JcSdkReport
```



### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```



## PARAMETERS

### -ApiHost
Region for JumpCloud API host.
Use 'api' for US or 'api.eu' for EU.

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

### -Sort
Sort type and direction.
Default sort is descending, prefix with - to sort ascending.

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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### JumpCloud.SDK.DirectoryInsights.Models.IGet200ApplicationJsonItemsItem

## NOTES

## RELATED LINKS

