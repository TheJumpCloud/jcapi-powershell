---
external help file:
Module Name: JumpCloudApiSdkV2
online version: https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv2/new-jcsdkduoaccount
schema: 2.0.0
---

# New-JcSdkDuoAccount

## SYNOPSIS
Registers a Duo account for an organization.
Only one Duo account will be allowed,\nin case an organization has a Duo account already a 409 (Conflict) code will be returned.\n\n#### Sample Request\n```\n  curl -X POST https://console.jumpcloud.com/api/v2/duo/accounts \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{}'\n```

## SYNTAX

```
New-JcSdkDuoAccount [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Registers a Duo account for an organization.
Only one Duo account will be allowed,\nin case an organization has a Duo account already a 409 (Conflict) code will be returned.\n\n#### Sample Request\n```\n  curl -X POST https://console.jumpcloud.com/api/v2/duo/accounts \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{}'\n```

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
To view examples, please use the -Online parameter with Get-Help or navigate to: https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv2/new-jcsdkduoaccount
```



## PARAMETERS

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

## OUTPUTS

### JumpCloudApiSdkV2.Models.IDuoAccount

### System.String

## ALIASES

## NOTES

## RELATED LINKS

