---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Get-JcSdkSystemInsightTpmInfo.md
schema: 2.0.0
---

# Get-JcSdkSystemInsightTpmInfo

## SYNOPSIS
Valid filter fields are `system_id`.

## SYNTAX

```
Get-JcSdkSystemInsightTpmInfo [-Filter <String[]>] [-Sort <String[]>] [<CommonParameters>]
```

## DESCRIPTION
Valid filter fields are `system_id`.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Get-JcSdkSystemInsightTpmInfo
```

----                    ----------
Activated               System.Nullable[float] Activated {get;set;}
CollectionTime          String
Enabled                 System.Nullable[float] Enabled {get;set;}
ManufacturerId          System.Nullable[float] ManufacturerId {get;set;}
ManufacturerName        String
ManufacturerVersion     String
Owned                   System.Nullable[float] Owned {get;set;}
PhysicalPresenceVersion String
ProductName             String
SpecVersion             String
SystemId                String

### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

## PARAMETERS

### -Filter
A filter to apply to the query.

**Filter structure**: `\<field\>:\<operator\>:\<value\>`.

**field** = Populate with a valid field from an endpoint response.

**operator** = Supported operators are: eq, ne, gt, ge, lt, le, between, search, in.
_Note: v1 operators differ from v2 operators._

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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### JumpCloud.SDK.V2.Models.ISystemInsightsTpmInfo

## NOTES

ALIASES

## RELATED LINKS

