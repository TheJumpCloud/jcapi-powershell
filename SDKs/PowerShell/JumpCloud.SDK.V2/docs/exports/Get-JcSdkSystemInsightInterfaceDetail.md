---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Get-JcSdkSystemInsightInterfaceDetail.md
schema: 2.0.0
---

# Get-JcSdkSystemInsightInterfaceDetail

## SYNOPSIS


## SYNTAX

```
Get-JcSdkSystemInsightInterfaceDetail -ConsoleHost <String> [-Filter <List<String>>] [-Sort <List<String>>]
 [<CommonParameters>]
```

## DESCRIPTION


## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Get-JcSdkSystemInsightInterfaceDetail
```

----                       ----------
Collisions                 String
ConnectionId               String
ConnectionStatus           String
Description                String
DhcpEnabled                Int
DhcpLeaseExpires           String
DhcpLeaseObtained          String
DhcpServer                 String
DnsDomain                  String
DnsDomainSuffixSearchOrder String
DnsHostName                String
DnsServerSearchOrder       String
Enabled                    Int
Flags                      Int
FriendlyName               String
Ibytes                     String
Idrops                     String
Ierrors                    String
Interface                  String
Ipackets                   String
LastChange                 String
LinkSpeed                  String
Mac                        String
Manufacturer               String
Metric                     Int
Mtu                        Int
Obytes                     String
Odrops                     String
Oerrors                    String
Opackets                   String
PciSlot                    String
PhysicalAdapter            Int
Service                    String
Speed                      Int
SystemId                   String
Type                       Int

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

### JumpCloud.SDK.V2.Models.ISystemInsightsInterfaceDetails

## NOTES

## RELATED LINKS

