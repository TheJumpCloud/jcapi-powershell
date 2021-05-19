---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/New-JcSdkPolicyGroup.md
schema: 2.0.0
---

# New-JcSdkPolicyGroup

## SYNOPSIS
This endpoint allows you to create a new Configuration (Policy) Group.

#### Sample Request
```
curl -X POST https://console.jumpcloud.com/api/v2/policygroups \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"name\": \"{Group_Name}\"
  }'
```

## SYNTAX

### NewExpanded (Default)
```
New-JcSdkPolicyGroup -Name <String> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### New
```
New-JcSdkPolicyGroup -Body <IPolicyGroupData> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
This endpoint allows you to create a new Configuration (Policy) Group.

#### Sample Request
```
curl -X POST https://console.jumpcloud.com/api/v2/policygroups \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"name\": \"{Group_Name}\"
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
PolicyGroupData
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: JumpCloud.SDK.V2.Models.IPolicyGroupData
Parameter Sets: New
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Name
Display name of a Configuration (Policy) Group.

```yaml
Type: System.String
Parameter Sets: NewExpanded
Aliases:

Required: True
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

### JumpCloud.SDK.V2.Models.IPolicyGroupData

## OUTPUTS

### JumpCloud.SDK.V2.Models.IPolicyGroup

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODY <IPolicyGroupData>: PolicyGroupData
  - `Name <String>`: Display name of a Configuration (Policy) Group.

## RELATED LINKS

