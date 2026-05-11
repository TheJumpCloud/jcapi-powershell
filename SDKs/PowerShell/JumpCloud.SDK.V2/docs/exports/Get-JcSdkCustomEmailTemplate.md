---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Get-JcSdkCustomEmailTemplate.md
schema: 2.0.0
---

# Get-JcSdkCustomEmailTemplate

## SYNOPSIS
Get the list of custom email templates

## SYNTAX

```
Get-JcSdkCustomEmailTemplate -ConsoleHost <String> [<CommonParameters>]
```

## DESCRIPTION
Get the list of custom email templates

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Get-JcSdkCustomEmailTemplate
```

----        ----------
Description String
DisplayName String
Fields      JumpCloud.SDK.V2.Models.CustomEmailTemplateField[]
Type        String

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

### JumpCloud.SDK.V2.Models.ICustomEmailTemplate

## NOTES

## RELATED LINKS

