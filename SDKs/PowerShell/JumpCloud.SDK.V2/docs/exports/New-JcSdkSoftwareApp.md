---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/New-JcSdkSoftwareApp.md
schema: 2.0.0
---

# New-JcSdkSoftwareApp

## SYNOPSIS
This endpoint allows you to create a Software Application that will be managed by JumpCloud on associated JumpCloud systems.\n\n#### Sample Request\n```\n$ curl -X POST https://console.jumpcloud.com/api/v2/softwareapps \\\n-H 'Accept: application/json' \\\n-H 'Content-Type: application/json' \\\n-H 'x-api-key: {API_KEY}' \\\n-d '{\n\"displayName\": \"Adobe Reader\",\n\"settings\": [{\"packageId\": \"adobereader\"}]\n}'\n```

## SYNTAX

### CreateExpanded (Default)
```
New-JcSdkSoftwareApp [-DisplayName <String>] [-Id <String>] [-Settings <IPostContentSchemaSettingsItem[]>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-JcSdkSoftwareApp -Body <ISoftwareApplicationPackageObject> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
This endpoint allows you to create a Software Application that will be managed by JumpCloud on associated JumpCloud systems.\n\n#### Sample Request\n```\n$ curl -X POST https://console.jumpcloud.com/api/v2/softwareapps \\\n-H 'Accept: application/json' \\\n-H 'Content-Type: application/json' \\\n-H 'x-api-key: {API_KEY}' \\\n-d '{\n\"displayName\": \"Adobe Reader\",\n\"settings\": [{\"packageId\": \"adobereader\"}]\n}'\n```

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
Software Application Package Object
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: JumpCloud.SDK.V2.Models.ISoftwareApplicationPackageObject
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DisplayName
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Settings
.
To construct, see NOTES section for SETTINGS properties and create a hash table.

```yaml
Type: JumpCloud.SDK.V2.Models.IPostContentSchemaSettingsItem[]
Parameter Sets: CreateExpanded
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

### JumpCloud.SDK.V2.Models.ISoftwareApplicationPackageObject

## OUTPUTS

### JumpCloud.SDK.V2.Models.ISoftwareApplicationPackageObject0

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODY <ISoftwareApplicationPackageObject>: Software Application Package Object
  - `[DisplayName <String>]`: 
  - `[Id <String>]`: 
  - `[Settings <IPostContentSchemaSettingsItem[]>]`: 
    - `[PackageId <String>]`: 

SETTINGS <IPostContentSchemaSettingsItem[]>: .
  - `[PackageId <String>]`: 

## RELATED LINKS

