---
external help file:
Module Name: JumpCloud.SDK.DirectoryInsights
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/AutoRest/SDKs/PowerShell/jumpcloud.sdk.directoryinsights/get-jcsdkevent
schema: 2.0.0
---

# Get-JcSdkEvent

## SYNOPSIS
Query the API for Directory Insights events

## SYNTAX

### GetExpanded (Default)
```
Get-JcSdkEvent -Service <String[]> -StartTime <DateTime> [-EndTime <DateTime>] [-Fields <String[]>]
 [-Limit <Int64>] [-SearchAfter <String[]>] [-SearchTermAnd <Hashtable>] [-SearchTermOr <Hashtable>]
 [-Sort <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Get
```
Get-JcSdkEvent -Body <IEventQuery> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Query the API for Directory Insights events

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
EventQuery is the users' command to search our auth logs
To construct, see NOTES section for BODY properties and create a hash table.

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

### -Limit
Max number of rows to return

```yaml
Type: System.Int64
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
list of event terms.
If all terms match the event will be returned by the service.

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
list of event terms.
If any term matches, the event will be returned by the service.

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
Known services: systems,radius,sso,directory,ldap,all

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

### JumpCloud.SDK.DirectoryInsights.Models.IPost200ApplicationJsonItemsItem

### System.String

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODY <IEventQuery>: EventQuery is the users' command to search our auth logs
  - `Service <String[]>`: service name to query. Known services: systems,radius,sso,directory,ldap,all
  - `StartTime <DateTime>`: query start time, UTC in RFC3339 format
  - `[EndTime <DateTime?>]`: optional query end time, UTC in RFC3339 format
  - `[Fields <String[]>]`: optional list of fields to return from query
  - `[Limit <Int64?>]`: Max number of rows to return
  - `[SearchAfter <String[]>]`: Specific query to search after, see x-* response headers for next values
  - `[SearchTermAnd <ISearchTermAnd>]`: list of event terms. If all terms match the event will be returned by the service.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[SearchTermOr <ISearchTermOr>]`: list of event terms. If any term matches, the event will be returned by the service.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Sort <String>]`: ASC or DESC order for timestamp

## RELATED LINKS
