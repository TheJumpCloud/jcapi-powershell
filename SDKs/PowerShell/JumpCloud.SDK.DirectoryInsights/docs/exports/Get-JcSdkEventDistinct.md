---
external help file:
Module Name: JumpCloud.SDK.DirectoryInsights
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.DirectoryInsights/docs/exports/Get-JcSdkEventDistinct.md
schema: 2.0.0
---

# Get-JcSdkEventDistinct

## SYNOPSIS
Query the API for a list of distinct values for a field
#### Sample Request
```
curl -X POST 'https://api.jumpcloud.com/insights/directory/v1/events/distinct' -H 'Content-Type: application/json' -H 'x-api-key: REPLACE_KEY_VALUE' --data '{\"service\": [\"all\"], \"start_time\": \"2021-07-14T23:00:00Z\", \"end_time\": \"2021-07-28T14:00:00Z\", \"sort\": \"DESC\", \"field\": \"event_type\"}'
```

## SYNTAX

### GetExpanded (Default)
```
Get-JcSdkEventDistinct -Field <String> -Service <String[]> -StartTime <DateTime> [-EndTime <DateTime>]
 [-SearchTermAnd <Hashtable>] [-SearchTermNot <Hashtable>] [-SearchTermOr <Hashtable>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Get
```
Get-JcSdkEventDistinct -Body <IEventDistinctQuery> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Query the API for a list of distinct values for a field
#### Sample Request
```
curl -X POST 'https://api.jumpcloud.com/insights/directory/v1/events/distinct' -H 'Content-Type: application/json' -H 'x-api-key: REPLACE_KEY_VALUE' --data '{\"service\": [\"all\"], \"start_time\": \"2021-07-14T23:00:00Z\", \"end_time\": \"2021-07-28T14:00:00Z\", \"sort\": \"DESC\", \"field\": \"event_type\"}'
```

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Get-JcSdkEventDistinct -Body:(<JumpCloud.SDK.DirectoryInsights.Models.EventDistinctQuery>)
```

----                    ----------
Buckets                 JumpCloud.SDK.DirectoryInsights.Models.Post200ApplicationJsonPropertiesItemsItem[]
DocCountErrorUpperBound Int
SumOtherDocCount        Int

### -------------------------- EXAMPLE 2 --------------------------
```powershell
Get-JcSdkEventDistinct -Field:(<string>) -Service:(<string[]>) -StartTime:(<datetime>) -EndTime:(<datetime>) -SearchTermAnd:(<hashtable>) -SearchTermNot:(<hashtable>) -SearchTermOr:(<hashtable>)
```

----                    ----------
Buckets                 JumpCloud.SDK.DirectoryInsights.Models.Post200ApplicationJsonPropertiesItemsItem[]
DocCountErrorUpperBound Int
SumOtherDocCount        Int

## PARAMETERS

### -Body
EventDistinctQuery is the users' command to search our auth logs for distinct values of the specified field
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: JumpCloud.SDK.DirectoryInsights.Models.IEventDistinctQuery
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

### -Field
field is what they wish to query on

```yaml
Type: System.String
Parameter Sets: GetExpanded
Aliases:

Required: True
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

### JumpCloud.SDK.DirectoryInsights.Models.IEventDistinctQuery

## OUTPUTS

### JumpCloud.SDK.DirectoryInsights.Models.IPaths1Sc3SuiEventsDistinctPostResponses200ContentApplicationJsonSchema

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODY <IEventDistinctQuery>: EventDistinctQuery is the users' command to search our auth logs for distinct values of the specified field
  - `Service <String[]>`: service name to query.
  - `StartTime <DateTime>`: query start time, UTC in RFC3339 format
  - `Field <String>`: field is what they wish to query on
  - `[EndTime <DateTime?>]`: optional query end time, UTC in RFC3339 format
  - `[SearchTermAnd <ITermConjunction>]`: TermConjunction represents a conjunction (and/or)         NOTE: the validator limits what the operator can be, not the object         for future-proof-ness         and a list of sub-values
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[SearchTermNot <ITermConjunction>]`: TermConjunction represents a conjunction (and/or)         NOTE: the validator limits what the operator can be, not the object         for future-proof-ness         and a list of sub-values
  - `[SearchTermOr <ITermConjunction>]`: TermConjunction represents a conjunction (and/or)         NOTE: the validator limits what the operator can be, not the object         for future-proof-ness         and a list of sub-values

## RELATED LINKS

