---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Get-JcSdkAppleMdm.md
schema: 2.0.0
---

# Get-JcSdkAppleMdm

## SYNOPSIS
Get a list of all Apple MDM configurations.
An empty topic indicates that a signed certificate from Apple has not been provided to the PUT endpoint yet.

Note: currently only one MDM configuration per organization is supported.

#### Sample Request
```
curl https://console.jumpcloud.com/api/v2/applemdms \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

## SYNTAX

```
Get-JcSdkAppleMdm [<CommonParameters>]
```

## DESCRIPTION
Get a list of all Apple MDM configurations.
An empty topic indicates that a signed certificate from Apple has not been provided to the PUT endpoint yet.

Note: currently only one MDM configuration per organization is supported.

#### Sample Request
```
curl https://console.jumpcloud.com/api/v2/applemdms \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Get-JcSdkAppleMdm
```

Get Apple MDM Server information within a JumpCloud Tenant

## PARAMETERS

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### JumpCloud.SDK.V2.Models.IAppleMdm

## NOTES

ALIASES

## RELATED LINKS

