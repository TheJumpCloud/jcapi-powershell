---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/New-JcSdkActiveDirectory.md
schema: 2.0.0
---

# New-JcSdkActiveDirectory

## SYNOPSIS
This endpoint allows you to create a new Active Directory.


#### Sample Request
```
curl -X POST https://console.jumpcloud.com/api/v2/activedirectories/ \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"domain\": \"{DC=AD_domain_name;DC=com}\"
  }'
```

## SYNTAX

### NewExpanded (Default)
```
New-JcSdkActiveDirectory [-Domain <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### New
```
New-JcSdkActiveDirectory -Body <IActiveDirectoryInput> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
This endpoint allows you to create a new Active Directory.


#### Sample Request
```
curl -X POST https://console.jumpcloud.com/api/v2/activedirectories/ \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"domain\": \"{DC=AD_domain_name;DC=com}\"
  }'
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

### -Body
Active Directory Input
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: JumpCloud.SDK.V2.Models.IActiveDirectoryInput
Parameter Sets: New
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Domain
Domain name for this Active Directory instance.

```yaml
Type: System.String
Parameter Sets: NewExpanded
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

### JumpCloud.SDK.V2.Models.IActiveDirectoryInput

## OUTPUTS

### JumpCloud.SDK.V2.Models.IActiveDirectoryOutput

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODY <IActiveDirectoryInput>: Active Directory Input
  - `[Domain <String>]`: Domain name for this Active Directory instance.

## RELATED LINKS

