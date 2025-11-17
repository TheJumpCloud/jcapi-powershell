---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Get-JcSdkSystemInsightApp.md
schema: 2.0.0
---

# Get-JcSdkSystemInsightApp

## SYNOPSIS
Lists all apps for macOS devices.
For Windows devices, use [List System Insights Programs](#operation/systeminsights_list_programs).

Valid filter fields are `system_id` and `bundle_name`.

## SYNTAX

```
Get-JcSdkSystemInsightApp -ConsoleHost <String> [-Filter <List<String>>] [-Sort <List<String>>]
 [<CommonParameters>]
```

## DESCRIPTION
Lists all apps for macOS devices.
For Windows devices, use [List System Insights Programs](#operation/systeminsights_list_programs).

Valid filter fields are `system_id` and `bundle_name`.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Get-JcSdkSystemInsightApp
```

----                 ----------
ApplescriptEnabled   String
BundleExecutable     String
BundleIdentifier     String
BundleName           String
BundlePackageType    String
BundleShortVersion   String
BundleVersion        String
Category             String
CollectionTime       String
Compiler             String
Copyright            String
DevelopmentRegion    String
DisplayName          String
Element              String
Environment          String
InfoString
LastOpenedTime       System.Nullable[float] LastOpenedTime {get;set;}
MinimumSystemVersion String
Name                 String
Path                 String
SystemId             String

### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

## PARAMETERS

### -ConsoleHost
Region for JumpCloud API host.
Use 'console' for US or 'console.eu' for EU.

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
_Note: v1 operators differ from v2 operators._

**value** = Populate with the value you want to search for.
Is case sensitive.
Supports wild cards.

**EX:** `GET /api/v2/groups?filter=name:eq:Test+Group`

```yaml
Type: System.Collections.Generic.List`1[[System.String, System.Private.CoreLib, Version=9.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]]
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
Type: System.Collections.Generic.List`1[[System.String, System.Private.CoreLib, Version=9.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]]
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

### JumpCloud.SDK.V2.Models.ISystemInsightsApps

## NOTES

## RELATED LINKS

