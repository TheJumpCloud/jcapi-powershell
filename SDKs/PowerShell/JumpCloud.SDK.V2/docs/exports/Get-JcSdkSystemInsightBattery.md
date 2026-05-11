---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Get-JcSdkSystemInsightBattery.md
schema: 2.0.0
---

# Get-JcSdkSystemInsightBattery

## SYNOPSIS


## SYNTAX

```
Get-JcSdkSystemInsightBattery -ConsoleHost <String> [-Filter <List<String>>] [-Sort <List<String>>]
 [<CommonParameters>]
```

## DESCRIPTION


## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Get-JcSdkSystemInsightBattery
```

----                ----------
Amperage            Int
Charged             Int
Charging            Int
CollectionTime      String
Condition           String
CurrentCapacity     Int
CycleCount          Int
DesignedCapacity    Int
Health              String
ManufactureDate     Int
Manufacturer        String
MaxCapacity         Int
MinutesToFullCharge Int
MinutesUntilEmpty   Int
Model               String
PercentRemaining    Int
SerialNumber        String
State               String
SystemId            String
Voltage             Int

### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

## PARAMETERS

### -ConsoleHost


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


```yaml
Type: System.Collections.Generic.List`1[[System.String, System.Private.CoreLib, Version=10.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Sort


```yaml
Type: System.Collections.Generic.List`1[[System.String, System.Private.CoreLib, Version=10.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]]
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

### JumpCloud.SDK.V2.Models.ISystemInsightsBattery

## NOTES

## RELATED LINKS

