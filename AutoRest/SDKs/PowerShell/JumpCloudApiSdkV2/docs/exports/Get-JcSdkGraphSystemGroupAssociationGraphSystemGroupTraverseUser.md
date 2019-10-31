---
external help file:
Module Name: JumpCloudApiSdkV2
online version: https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv2/get-jcsdkgraphsystemgroupassociationgraphsystemgrouptraverseuser
schema: 2.0.0
---

# Get-JcSdkGraphSystemGroupAssociationGraphSystemGroupTraverseUser

## SYNOPSIS
This endpoint will return all Users bound to a System Group, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this System Group to the corresponding User; this array represents all grouping and/or associations that would have to be removed to deprovision the User from this System Group.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/systemgroups/{GroupID}/users \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

## SYNTAX

```
Get-JcSdkGraphSystemGroupAssociationGraphSystemGroupTraverseUser -GroupId <String> [-Filter <String[]>]
 [-Limit <Int32>] [-Skip <Int32>] [<CommonParameters>]
```

## DESCRIPTION
This endpoint will return all Users bound to a System Group, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this System Group to the corresponding User; this array represents all grouping and/or associations that would have to be removed to deprovision the User from this System Group.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/systemgroups/{GroupID}/users \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
To view examples, please use the -Online parameter with Get-Help or navigate to: https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv2/get-jcsdkgraphsystemgroupassociationgraphsystemgrouptraverseuser
```



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
Dynamic: False
```

### -GroupId
ObjectID of the System Group.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Limit
The number of records to return at once.
Limited to 100.

```yaml
Type: System.Int32
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Skip
The offset into the records to return.

```yaml
Type: System.Int32
Parameter Sets: (All)
Aliases:

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

### JumpCloudApiSdkV2.Models.IGraphObjectWithPaths

## ALIASES

## NOTES

## RELATED LINKS

