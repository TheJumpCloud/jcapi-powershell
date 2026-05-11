---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Get-JcSdkSystemInsightWifiNetwork.md
schema: 2.0.0
---

# Get-JcSdkSystemInsightWifiNetwork

## SYNOPSIS


## SYNTAX

```
Get-JcSdkSystemInsightWifiNetwork -ConsoleHost <String> [-Filter <List<String>>] [-Sort <List<String>>]
 [<CommonParameters>]
```

## DESCRIPTION


## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Get-JcSdkSystemInsightWifiNetwork
```

----                ----------
AutoLogin           System.Nullable[float] AutoLogin {get;set;}
CaptivePortal       System.Nullable[float] CaptivePortal {get;set;}
CollectionTime      String
Disabled            System.Nullable[float] Disabled {get;set;}
LastConnected       System.Nullable[float] LastConnected {get;set;}
NetworkName         String
Passpoint           System.Nullable[float] Passpoint {get;set;}
PossiblyHidden      System.Nullable[float] PossiblyHidden {get;set;}
Roaming             System.Nullable[float] Roaming {get;set;}
RoamingProfile      String
SecurityType        String
Ssid                String
SystemId            String
TemporarilyDisabled System.Nullable[float] TemporarilyDisabled {get;set;}

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

### JumpCloud.SDK.V2.Models.ISystemInsightsWifiNetworks

## NOTES

## RELATED LINKS

