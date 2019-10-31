---
external help file:
Module Name: JumpCloudApiSdkV2
online version: https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv2/new-jcsdkpolicy
schema: 2.0.0
---

# New-JcSdkPolicy

## SYNOPSIS
This endpoint allows you to create a policy.
Given the amount of configurable parameters required to create a Policy, we suggest you use the JumpCloud Admin Console to create new policies.\n\n##### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/policies \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n  {Policy_Parameters}\n}'\n\n```

## SYNTAX

### CreateExpanded (Default)
```
New-JcSdkPolicy -Name <String> [-TemplateId <String>] [-Values <IPolicyValue[]>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-JcSdkPolicy -Body <IPolicyRequest> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
This endpoint allows you to create a policy.
Given the amount of configurable parameters required to create a Policy, we suggest you use the JumpCloud Admin Console to create new policies.\n\n##### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/policies \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n  {Policy_Parameters}\n}'\n\n```

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
To view examples, please use the -Online parameter with Get-Help or navigate to: https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv2/new-jcsdkpolicy
```



## PARAMETERS

### -Body
An instance of a policy template.
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: JumpCloudApiSdkV2.Models.IPolicyRequest
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -Name
The description for this specific Policy.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -TemplateId
ObjectId uniquely identifying a Policy instance; only allowed on POST requests.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Values
HELP MESSAGE MISSING
To construct, see NOTES section for VALUES properties and create a hash table.

```yaml
Type: JumpCloudApiSdkV2.Models.IPolicyValue[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
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
Dynamic: False
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
Dynamic: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### JumpCloudApiSdkV2.Models.IPolicyRequest

## OUTPUTS

### JumpCloudApiSdkV2.Models.IPolicyWithDetails

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### BODY <IPolicyRequest>: An instance of a policy template.
  - `Name <String>`: The description for this specific Policy.
  - `[TemplateId <String>]`: ObjectId uniquely identifying a Policy instance; only allowed on POST requests.
  - `[Values <IPolicyValue[]>]`: 
    - `[ConfigFieldId <String>]`: The ObjectId of the corresponding Policy Template configuration field.
    - `[Value <String>]`: The value for the configuration field for this Policy instance.

#### VALUES <IPolicyValue[]>: HELP MESSAGE MISSING
  - `[ConfigFieldId <String>]`: The ObjectId of the corresponding Policy Template configuration field.
  - `[Value <String>]`: The value for the configuration field for this Policy instance.

## RELATED LINKS

