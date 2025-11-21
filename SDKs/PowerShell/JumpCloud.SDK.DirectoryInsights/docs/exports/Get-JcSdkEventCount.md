---
external help file:
Module Name: JumpCloud.SDK.DirectoryInsights
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/CUT-4981_v2EUSupport/SDKs/PowerShell/JumpCloud.SDK.DirectoryInsights/docs/exports/Get-JcSdkEventCount.md
schema: 2.0.0
---

# Get-JcSdkEventCount

## SYNOPSIS
Query the API for a count of matching events
#### Sample Request
```
curl -X POST 'https://api.jumpcloud.com/insights/directory/v1/events/count' -H 'Content-Type: application/json' -H 'x-api-key: REPLACE_KEY_VALUE' --data '{\"service\": [\"all\"], \"start_time\": \"2021-07-14T23:00:00Z\", \"end_time\": \"2021-07-28T14:00:00Z\", \"sort\": \"DESC\", \"fields\": [\"timestamp\", \"event_type\", \"initiated_by\", \"success\", \"client_ip\", \"provider\", \"organization\"]}'
```

## SYNTAX

### GetExpanded (Default)
```
Get-JcSdkEventCount -ApiHost <String> -Service <String[]> -StartTime <DateTime> [-EndTime <DateTime>]
 [-ExactMatch <String>] [-Fields <String[]>] [-Q <String>] [-SearchAfter <String[]>]
 [-SearchTermAnd <Hashtable>] [-SearchTermNot <Hashtable>] [-SearchTermOr <Hashtable>] [-Sort <String>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Get
```
Get-JcSdkEventCount -ApiHost <String> -Body <IEventQuery> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Query the API for a count of matching events
#### Sample Request
```
curl -X POST 'https://api.jumpcloud.com/insights/directory/v1/events/count' -H 'Content-Type: application/json' -H 'x-api-key: REPLACE_KEY_VALUE' --data '{\"service\": [\"all\"], \"start_time\": \"2021-07-14T23:00:00Z\", \"end_time\": \"2021-07-28T14:00:00Z\", \"sort\": \"DESC\", \"fields\": [\"timestamp\", \"event_type\", \"initiated_by\", \"success\", \"client_ip\", \"provider\", \"organization\"]}'
```

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
) -StartTime:(<datetime>) -EndTime:(<datetime>) -ExactMatch:(<string>) -Fields:(<string[]>) -Q:(<string>) -SearchAfter:(<string[]>) -SearchTermAnd:(<hashtable>) -SearchTermNot:(<hashtable>) -SearchTermOr:(<hashtable>) -Sort:(<string>)
```



### -------------------------- EXAMPLE 2 --------------------------
```powershell
)
```



## PARAMETERS

### -ApiHost
Region for JumpCloud API host.
Use 'api' for US or 'api.eu' for EU.

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

### -Body
EventQuery is the users' command to search our auth logs

```yaml
Type: JumpCloud.SDK.DirectoryInsights.Models.IEventQuery
Parameter Sets: Get
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -EndTime
optional query end time, UTC in RFC3339 format

```yaml
Type: System.DateTime
Parameter Sets: GetExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExactMatch
optional string for specifying exact match query, do not use with full text query

```yaml
Type: System.String
Parameter Sets: GetExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Fields
optional list of fields to return from query

```yaml
Type: System.String[]
Parameter Sets: GetExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Q
optional string for specifying a full text query

```yaml
Type: System.String
Parameter Sets: GetExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SearchAfter
Specific query to search after, see x-* response headers for next values

```yaml
Type: System.String[]
Parameter Sets: GetExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SearchTermAnd
TermConjunction represents a conjunction (and/or)NOTE: the validator limits what the operator can be, not the objectfor future-proof-nessand a list of sub-values

```yaml
Type: System.Collections.Hashtable
Parameter Sets: GetExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SearchTermNot
TermConjunction represents a conjunction (and/or)NOTE: the validator limits what the operator can be, not the objectfor future-proof-nessand a list of sub-values

```yaml
Type: System.Collections.Hashtable
Parameter Sets: GetExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SearchTermOr
TermConjunction represents a conjunction (and/or)NOTE: the validator limits what the operator can be, not the objectfor future-proof-nessand a list of sub-values

```yaml
Type: System.Collections.Hashtable
Parameter Sets: GetExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Service
service name to query.

```yaml
Type: System.String[]
Parameter Sets: GetExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Sort
ASC or DESC order for timestamp

```yaml
Type: System.String
Parameter Sets: GetExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StartTime
query start time, UTC in RFC3339 format

```yaml
Type: System.DateTime
Parameter Sets: GetExpanded
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

### JumpCloud.SDK.DirectoryInsights.Models.IEventQuery

## OUTPUTS

### JumpCloud.SDK.DirectoryInsights.Models.IEventCount

## NOTES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODY <IEventQuery>`: EventQuery is the users' command to search our auth logs
  - `Service <List<String>>`: service name to query.
  - `StartTime <DateTime>`: query start time, UTC in RFC3339 format
  - `[EndTime <DateTime?>]`: optional query end time, UTC in RFC3339 format
  - `[ExactMatch <String>]`: optional string for specifying exact match query, do not use with full text query
  - `[Fields <List<String>>]`: optional list of fields to return from query
  - `[Limit <Int64?>]`: Max number of rows to return
  - `[Q <String>]`: optional string for specifying a full text query
  - `[SearchAfter <List<String>>]`: Specific query to search after, see x-* response headers for next values
  - `[SearchTermAnd <ITermConjunction>]`: TermConjunction represents a conjunction (and/or)         NOTE: the validator limits what the operator can be, not the object         for future-proof-ness         and a list of sub-values
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[SearchTermNot <ITermConjunction>]`: TermConjunction represents a conjunction (and/or)         NOTE: the validator limits what the operator can be, not the object         for future-proof-ness         and a list of sub-values
  - `[SearchTermOr <ITermConjunction>]`: TermConjunction represents a conjunction (and/or)         NOTE: the validator limits what the operator can be, not the object         for future-proof-ness         and a list of sub-values
  - `[Skip <Int64?>]`: optional offset into the result set to start with when returning
  - `[Sort <String>]`: ASC or DESC order for timestamp

## RELATED LINKS

