---
external help file:
Module Name: JumpCloud.SDK.V1
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V1/docs/exports/Search-JcSdkCommandResult.md
schema: 2.0.0
---

# Search-JcSdkCommandResult

## SYNOPSIS
Return Command Results in multi-record format allowing for the passing of the `filter` parameter.

To support advanced filtering you can use the `filter` and `searchFilter` parameters that can only be passed in the body of POST /api/search/commandresults route.
The `filter` parameter must be passed as Content-Type application/json.

The `filter` parameter is an object with a single property, either `and` or `or` with the value of the property being an array of query expressions.

This allows you to filter records using the logic of matching ALL or ANY records in the array of query expressions.
If the `and` or `or` are not included the default behavior is to match ALL query expressions.


#### Sample Request

Exact search for a specific command result
```
curl -X POST https://console.jumpcloud.com/api/search/commandresults \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
  \"filter\" : \"workflowInstanceId:$eq:62f3c599ec4e928499069c7f\",
  \"fields\" : \"name workflowId sudo\"
}'
```

## SYNTAX

### SearchExpanded (Default)
```
Search-JcSdkCommandResult [-Fields <String>] [-Filter <Hashtable>] [-SearchFilter <Hashtable>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Search
```
Search-JcSdkCommandResult -Body <ISearch> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Return Command Results in multi-record format allowing for the passing of the `filter` parameter.

To support advanced filtering you can use the `filter` and `searchFilter` parameters that can only be passed in the body of POST /api/search/commandresults route.
The `filter` parameter must be passed as Content-Type application/json.

The `filter` parameter is an object with a single property, either `and` or `or` with the value of the property being an array of query expressions.

This allows you to filter records using the logic of matching ALL or ANY records in the array of query expressions.
If the `and` or `or` are not included the default behavior is to match ALL query expressions.


#### Sample Request

Exact search for a specific command result
```
curl -X POST https://console.jumpcloud.com/api/search/commandresults \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
  \"filter\" : \"workflowInstanceId:$eq:62f3c599ec4e928499069c7f\",
  \"fields\" : \"name workflowId sudo\"
}'
```

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
search-JcSdkCommandResult -filter @{'and' = @("name:`$regex:RadiusCert*", "workflowId:`$eq:6406532738e1a32cafa24260")} -fields "response.data.exitCode name system workflowId"
```



### -------------------------- EXAMPLE 2 --------------------------
```powershell
$body = @{
    'filter' = @{
        'and' = @("workflowId:`$eq:6406532738e1a32cafa24260")
    }
}
Search-JcSdkCommandResult -Body $body
```



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

### JumpCloud.SDK.V1.Models.ICommandresultssearchlist

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

