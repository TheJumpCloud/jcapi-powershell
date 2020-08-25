---
external help file:
Module Name: JumpCloud.SDK.DirectoryInsights
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.DirectoryInsights/docs/exports/Get-JcSdkEventDistinct.md
schema: 2.0.0
---

# Get-JcSdkEventDistinct

## SYNOPSIS
Query the API for a list of distinct values for a field

## SYNTAX

### GetExpanded (Default)
```
Get-JcSdkEventDistinct -Service <String[]> -StartTime <DateTime> [-EndTime <DateTime>] [-Field <String>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Get
```
Get-JcSdkEventDistinct -Body <IEventDistinctQuery> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Query the API for a list of distinct values for a field

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

### System.Int64

### System.String

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODY <IEventDistinctQuery>: EventDistinctQuery is the users' command to search our auth logs for distinct values of the specified field
  - `Service <String[]>`: service name to query. Known services: systems,radius,sso,directory,ldap,all
  - `StartTime <DateTime>`: query start time, UTC in RFC3339 format
  - `[EndTime <DateTime?>]`: optional query end time, UTC in RFC3339 format
  - `[Field <String>]`: field is what they wish to query on

## RELATED LINKS

