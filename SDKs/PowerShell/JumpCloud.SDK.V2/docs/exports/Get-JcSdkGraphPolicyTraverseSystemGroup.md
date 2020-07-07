---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/AutoRest/SDKs/PowerShell/jumpcloud.sdk.v2/get-jcsdkgraphpolicytraversesystemgroup
schema: 2.0.0
---

# Get-JcSdkGraphPolicyTraverseSystemGroup

## SYNOPSIS
This endpoint will return all Systems Groups bound to a Policy, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the group's type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this Policy to the corresponding System Group; this array represents all grouping and/or associations that would have to be removed to deprovision the System Group from this Policy.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET  https://console.jumpcloud.com/api/v2/policies/{Policy_ID}/systemgroups \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

## SYNTAX

```
Get-JcSdkGraphPolicyTraverseSystemGroup -PolicyId <String> [-Filter <String[]>] [<CommonParameters>]
```

## DESCRIPTION
This endpoint will return all Systems Groups bound to a Policy, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the group's type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this Policy to the corresponding System Group; this array represents all grouping and/or associations that would have to be removed to deprovision the System Group from this Policy.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET  https://console.jumpcloud.com/api/v2/policies/{Policy_ID}/systemgroups \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

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

### -Filter
Supported operators are: eq, ne, gt, ge, lt, le, between, search, in

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PolicyId
ObjectID of the Command.

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

### JumpCloud.SDK.V2.Models.IGraphObjectWithPaths

## NOTES

ALIASES

## RELATED LINKS
