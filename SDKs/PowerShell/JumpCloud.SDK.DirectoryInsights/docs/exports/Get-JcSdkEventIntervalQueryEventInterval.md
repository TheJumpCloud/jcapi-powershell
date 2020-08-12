---
external help file:
Module Name: JumpCloud.SDK.DirectoryInsights
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.DirectoryInsights/docs/exports/Get-JcSdkEventIntervalQueryEventInterval.md
schema: 2.0.0
---

# Get-JcSdkEventIntervalQueryEventInterval

## SYNOPSIS
Query the API for a list of counts by time interval

## SYNTAX

### GetExpanded (Default)
```
Get-JcSdkEventIntervalQueryEventInterval -IntervalUnit <String> -Service <String[]> -StartTime <DateTime>
 [-EndTime <DateTime>] [-IntervalValue <String>] [-SearchTermAnd <Hashtable>] [-SearchTermOr <Hashtable>]
 [-Timezone <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Get
```
Get-JcSdkEventIntervalQueryEventInterval -Body <IEventIntervalQuery> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Query the API for a list of counts by time interval

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
EventIntervalQuery is the users' command to search our auth logs for bucketed counts of values of the specified field
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: JumpCloud.SDK.DirectoryInsights.Models.IEventIntervalQuery
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

### -IntervalUnit
.

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

### -IntervalValue
Interval Value.
This specifies how many units you want to bucket the event counts byoptional

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

### -SearchTermAnd
TermConjunction

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
TermConjunction

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

### -Timezone
TimeZone.
Specify the timezone in which the user is inoptional

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

### JumpCloud.SDK.DirectoryInsights.Models.IEventIntervalQuery

## OUTPUTS

### JumpCloud.SDK.DirectoryInsights.Models.IPaths8Vdch8EventsIntervalPostResponses200ContentApplicationJsonSchemaItems

### System.String

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODY <IEventIntervalQuery>: EventIntervalQuery is the users' command to search our auth logs for bucketed counts of values of the specified field
  - `IntervalUnit <String>`: 
  - `Service <String[]>`: service name to query. Known services: systems,radius,sso,directory,ldap,all
  - `StartTime <DateTime>`: query start time, UTC in RFC3339 format
  - `[EndTime <DateTime?>]`: optional query end time, UTC in RFC3339 format
  - `[IntervalValue <String>]`: Interval Value. This specifies how many units you want to bucket the event counts by         optional
  - `[SearchTermAnd <ITermConjunction>]`: TermConjunction
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[SearchTermOr <ITermConjunction>]`: TermConjunction
  - `[Timezone <String>]`: TimeZone. Specify the timezone in which the user is in         optional

## RELATED LINKS

