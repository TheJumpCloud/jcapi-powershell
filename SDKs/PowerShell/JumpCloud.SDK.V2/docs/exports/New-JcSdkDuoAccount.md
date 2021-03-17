---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/New-JcSdkDuoAccount.md
schema: 2.0.0
---

# New-JcSdkDuoAccount

## SYNOPSIS
Registers a Duo account for an organization.
Only one Duo account will be allowed,
in case an organization has a Duo account already a 409 (Conflict) code will be returned.

#### Sample Request
```
  curl -X POST https://console.jumpcloud.com/api/v2/duo/accounts \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{}'
```

## SYNTAX

```
New-JcSdkDuoAccount [-CreationSource <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Registers a Duo account for an organization.
Only one Duo account will be allowed,
in case an organization has a Duo account already a 409 (Conflict) code will be returned.

#### Sample Request
```
  curl -X POST https://console.jumpcloud.com/api/v2/duo/accounts \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{}'
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

### -CreationSource
Defines the creation-source header for gapps, o365 and workdays requests.
If the header isn't sent, the default value is `jumpcloud:bulk`, if you send the header with a malformed value you receive a 400 error.
Allowed: `jumpcloud:gapps`, `jumpcloud:o365`, `jumpcloud:workday`, `jumpcloud:bulk`.

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

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

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

### JumpCloud.SDK.V2.Models.IDuoAccount

## NOTES

ALIASES

## RELATED LINKS

