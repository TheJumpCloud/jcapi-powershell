---
external help file:
Module Name: JumpCloud.SDK.V1
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V1/docs/exports/Get-JcSdkUserTotp.md
schema: 2.0.0
---

# Get-JcSdkUserTotp

## SYNOPSIS
This endpoint will return info for a specific System User's TOTP enrollment.

## SYNTAX

### Get (Default)
```
Get-JcSdkUserTotp -Id <String> [<CommonParameters>]
```

### GetViaIdentity
```
Get-JcSdkUserTotp -InputObject <IJumpCloudApiIdentity> [<CommonParameters>]
```

## DESCRIPTION
This endpoint will return info for a specific System User's TOTP enrollment.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Get-JCSdkUserTotp -ID <USERID>
```

Wednesday, November 27, 2024 5:33:45 PM

## PARAMETERS

### -Id
.

```yaml
Type: System.String
Parameter Sets: Get
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: JumpCloud.SDK.V1.Models.IJumpCloudApiIdentity
Parameter Sets: GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### JumpCloud.SDK.V1.Models.IJumpCloudApiIdentity

## OUTPUTS

### System.DateTime

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


INPUTOBJECT <IJumpCloudApiIdentity>: Identity Parameter
  - `[Id <String>]`:
  - `[SystemId <String>]`:
  - `[SystemuserId <String>]`:
  - `[Triggername <String>]`:

## RELATED LINKS

