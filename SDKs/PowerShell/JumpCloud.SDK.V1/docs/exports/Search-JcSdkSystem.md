---
external help file:
Module Name: JumpCloud.SDK.V1
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V1/docs/exports/Search-JcSdkSystem.md
schema: 2.0.0
---

# Search-JcSdkSystem

## SYNOPSIS
Return Systems in multi-record format allowing for the passing of the `filter` and `searchFilter` parameters.
This WILL NOT allow you to add a new system.

To support advanced filtering you can use the `filter` and `searchFilter` parameters that can only be passed in the body of POST /api/search/* routes.
The `filter` and `searchFilter` parameters must be passed as Content-Type application/json.

The `filter` parameter is an object with a single property, either `and` or `or` with the value of the property being an array of query expressions.

This allows you to filter records using the logic of matching ALL or ANY records in the array of query expressions.
If the `and` or `or` are not included the default behavior is to match ALL query expressions.

The `searchFilter` parameter allows text searching on supported fields by specifying a `searchTerm` and a list of `fields` to query on.
If any `field` has a partial text match on the `searchTerm` the record will be returned.


#### Sample Request

Exact search for a list of hostnames
```
curl -X POST https://console.jumpcloud.com/api/search/systems \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
  \"filter\": {
    \"or\": [
      {\"hostname\" : \"my-hostname\"},
      {\"hostname\" : \"other-hostname\"}
    ]
  },
  \"fields\" : \"os hostname displayName\"
}'
```

Text search for a hostname or display name
```
curl -X POST https://console.jumpcloud.com/api/search/systems \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
  \"searchFilter\": {
    \"searchTerm\": \"my-host\",
    \"fields\": [\"hostname\", \"displayName\"]
  },
  \"fields\": \"os hostname displayName\"
}'
```

Text search for a multiple hostnames.
```
curl -X POST https://console.jumpcloud.com/api/search/systems \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
  \"searchFilter\": {
    \"searchTerm\": [\"my-host\", \"my-other-host\"],
    \"fields\": [\"hostname\"]
  },
  \"fields\": \"os hostname displayName\"
}'
```

Combining `filter` and `searchFilter` to search for names that match a given OS
```
curl -X POST https://console.jumpcloud.com/api/search/systems \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
  \"searchFilter\": {
    \"searchTerm\": \"my-host\",
    \"fields\": [\"hostname\", \"displayName\"]
  },
  \"filter\": {
    \"or\": [
      {\"os\" : \"Ubuntu\"},
      {\"os\" : \"Mac OS X\"}
    ]
  },
  \"fields\": \"os hostname displayName\"
}'
```

## SYNTAX

### SearchExpanded (Default)
```
Search-JcSdkSystem [-Fields <String>] [-Filter <Hashtable>] [-SearchFilter <Hashtable>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Search
```
Search-JcSdkSystem -Body <ISearch> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Return Systems in multi-record format allowing for the passing of the `filter` and `searchFilter` parameters.
This WILL NOT allow you to add a new system.

To support advanced filtering you can use the `filter` and `searchFilter` parameters that can only be passed in the body of POST /api/search/* routes.
The `filter` and `searchFilter` parameters must be passed as Content-Type application/json.

The `filter` parameter is an object with a single property, either `and` or `or` with the value of the property being an array of query expressions.

This allows you to filter records using the logic of matching ALL or ANY records in the array of query expressions.
If the `and` or `or` are not included the default behavior is to match ALL query expressions.

The `searchFilter` parameter allows text searching on supported fields by specifying a `searchTerm` and a list of `fields` to query on.
If any `field` has a partial text match on the `searchTerm` the record will be returned.


#### Sample Request

Exact search for a list of hostnames
```
curl -X POST https://console.jumpcloud.com/api/search/systems \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
  \"filter\": {
    \"or\": [
      {\"hostname\" : \"my-hostname\"},
      {\"hostname\" : \"other-hostname\"}
    ]
  },
  \"fields\" : \"os hostname displayName\"
}'
```

Text search for a hostname or display name
```
curl -X POST https://console.jumpcloud.com/api/search/systems \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
  \"searchFilter\": {
    \"searchTerm\": \"my-host\",
    \"fields\": [\"hostname\", \"displayName\"]
  },
  \"fields\": \"os hostname displayName\"
}'
```

Text search for a multiple hostnames.
```
curl -X POST https://console.jumpcloud.com/api/search/systems \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
  \"searchFilter\": {
    \"searchTerm\": [\"my-host\", \"my-other-host\"],
    \"fields\": [\"hostname\"]
  },
  \"fields\": \"os hostname displayName\"
}'
```

Combining `filter` and `searchFilter` to search for names that match a given OS
```
curl -X POST https://console.jumpcloud.com/api/search/systems \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
  \"searchFilter\": {
    \"searchTerm\": \"my-host\",
    \"fields\": [\"hostname\", \"displayName\"]
  },
  \"filter\": {
    \"or\": [
      {\"os\" : \"Ubuntu\"},
      {\"os\" : \"Mac OS X\"}
    ]
  },
  \"fields\": \"os hostname displayName\"
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

### JumpCloud.SDK.V1.Models.ISystemslist

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

