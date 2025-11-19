---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Get-JcSdkSubscription.md
schema: 2.0.0
---

# Get-JcSdkSubscription

## SYNOPSIS
This endpoint returns all pricing & packaging subscriptions.

##### Sample Request

```
 curl -X GET  https://console.jumpcloud.com/api/v2/subscriptions \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
  ```

## SYNTAX

```
Get-JcSdkSubscription -ConsoleHost <String> [<CommonParameters>]
```

## DESCRIPTION
This endpoint returns all pricing & packaging subscriptions.

##### Sample Request

```
 curl -X GET  https://console.jumpcloud.com/api/v2/subscriptions \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
  ```

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Get-JcSdkSubscription
```

----                  ----------
AnnualPrice           float AnnualPrice {get;set;}
DisplayName           String
Features              JumpCloud.SDK.V2.Models.Feature[]
ListPrice             float ListPrice {get;set;}
ProductCode           String
UpgradeRecommendation String

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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### JumpCloud.SDK.V2.Models.ISubscription

## NOTES

## RELATED LINKS

