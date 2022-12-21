---
external help file:
Module Name: JumpCloud.SDK.V1
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V1/docs/exports/Invoke-JcSdkSearchCommandresult.md
schema: 2.0.0
---

# Invoke-JcSdkSearchCommandresult

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

### PostExpanded (Default)
```
Invoke-JcSdkSearchCommandresult [-Fields <String>] [-Filter <String>] [-Fields1 <String>]
 [-Filter1 <Hashtable>] [-SearchFilter <Hashtable>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Post
```
Invoke-JcSdkSearchCommandresult -Body <ISearch> [-Fields <String>] [-Filter <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
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
Parameter Sets: Post
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Fields
Use a space seperated string of field parameters to include the data in the response.
If omitted, the default list of fields will be returned.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Fields1
.

```yaml
Type: System.String
Parameter Sets: PostExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Filter
A filter to apply to the query.
See the supported operators below.
For more complex searches,
see the related `/search/\<domain\>` endpoints,
e.g.
`/search/systems`.

**Filter structure**: `\<field\>:\<operator\>:\<value\>`.

**field** = Populate with a valid field from an endpoint response.

**operator** = Supported operators are:
- `$eq` (equals)
- `$ne` (does not equal)
- `$gt` (is greater than)
- `$gte` (is greater than or equal to)
- `$lt` (is less than)
- `$lte` (is less than or equal to)

_Note: v1 operators differ from v2 operators._

_Note: For v1 operators, excluding the `$` will result in undefined behavior._

**value** = Populate with the value you want to search for.
Is case sensitive.

**Examples**
- `GET /users?filter=username:$eq:testuser`
- `GET /systemusers?filter=password_expiration_date:$lte:2021-10-24`
- `GET /systemusers?filter=department:$ne:Accounting`
- `GET /systems?filter[0]=firstname:$eq:foo&filter[1]=lastname:$eq:bar` - this will
 AND the filters together.
- `GET /systems?filter[or][0]=lastname:$eq:foo&filter[or][1]=lastname:$eq:bar` - this will
 OR the filters together.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Filter1
Dictionary of \<any\>

```yaml
Type: System.Collections.Hashtable
Parameter Sets: PostExpanded
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
Parameter Sets: PostExpanded
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

### JumpCloud.SDK.V1.Models.ICommandresultslist

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

