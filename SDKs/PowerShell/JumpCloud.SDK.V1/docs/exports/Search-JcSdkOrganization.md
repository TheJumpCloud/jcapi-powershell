---
external help file:
Module Name: JumpCloud.SDK.V1
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V1/docs/exports/Search-JcSdkOrganization.md
schema: 2.0.0
---

# Search-JcSdkOrganization

## SYNOPSIS
This endpoint will return Organization data based on your search parameters.
This endpoint WILL NOT allow you to add a new Organization.

You can use the supported parameters and pass those in the body of request.

The parameters must be passed as Content-Type application/json.


#### Sample Request
```
curl -X POST https://console.jumpcloud.com/api/search/organizations \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
  \"search\":{
    \"fields\" : [\"settings.name\"],
    \"searchTerm\": \"Second\"
    },
  \"fields\": [\"_id\", \"displayName\", \"logoUrl\"],
  \"limit\" : 0,
  \"skip\" : 0
}'
```

## SYNTAX

### SearchExpanded (Default)
```
Search-JcSdkOrganization [-Fields <String>] [-Filter <Hashtable>] [-SearchFilter <Hashtable>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Search
```
Search-JcSdkOrganization -Body <ISearch> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
This endpoint will return Organization data based on your search parameters.
This endpoint WILL NOT allow you to add a new Organization.

You can use the supported parameters and pass those in the body of request.

The parameters must be passed as Content-Type application/json.


#### Sample Request
```
curl -X POST https://console.jumpcloud.com/api/search/organizations \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
  \"search\":{
    \"fields\" : [\"settings.name\"],
    \"searchTerm\": \"Second\"
    },
  \"fields\": [\"_id\", \"displayName\", \"logoUrl\"],
  \"limit\" : 0,
  \"skip\" : 0
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
Search
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: JumpCloud.SDK.V1.Models.ISearch
Parameter Sets: Search
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Fields
.

```yaml
Type: System.String
Parameter Sets: SearchExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Filter
Dictionary of \<any\>

```yaml
Type: System.Collections.Hashtable
Parameter Sets: SearchExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SearchFilter
Dictionary of \<any\>

```yaml
Type: System.Collections.Hashtable
Parameter Sets: SearchExpanded
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

### JumpCloud.SDK.V1.Models.ISearch

## OUTPUTS

### JumpCloud.SDK.V1.Models.IOrganizationslist

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODY <ISearch>: Search
  - `[Fields <String>]`: 
  - `[Filter <ISearchFilter>]`: Dictionary of <any>
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[SearchFilter <ISearchFilter1>]`: Dictionary of <any>
    - `[(Any) <Object>]`: This indicates any property can be added to this object.

## RELATED LINKS

