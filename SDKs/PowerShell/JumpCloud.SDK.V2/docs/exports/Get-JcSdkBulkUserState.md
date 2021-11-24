---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Get-JcSdkBulkUserState.md
schema: 2.0.0
---

# Get-JcSdkBulkUserState

## SYNOPSIS
The endpoint allows you to list scheduled statechange jobs.
#### Sample Request
```
curl -X GET \"https://console.jumpcloud.com/api/v2/bulk/userstates\" \\
  -H 'x-api-key: {API_KEY}' \\
  -H 'Content-Type: application/json' \\
  -H 'Accept: application/json'
```

## SYNTAX

```
Get-JcSdkBulkUserState [-Userid <String>] [<CommonParameters>]
```

## DESCRIPTION
The endpoint allows you to list scheduled statechange jobs.
#### Sample Request
```
curl -X GET \"https://console.jumpcloud.com/api/v2/bulk/userstates\" \\
  -H 'x-api-key: {API_KEY}' \\
  -H 'Content-Type: application/json' \\
  -H 'Accept: application/json'
```

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

### -Userid
The systemuser id to filter by.

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

### JumpCloud.SDK.V2.Models.IScheduledUserstateResult

## NOTES

ALIASES

## RELATED LINKS

