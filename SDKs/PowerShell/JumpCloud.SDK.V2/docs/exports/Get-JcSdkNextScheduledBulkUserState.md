---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Get-JcSdkNextScheduledBulkUserState.md
schema: 2.0.0
---

# Get-JcSdkNextScheduledBulkUserState

## SYNOPSIS
This endpoint is used to lookup the next upcoming scheduled state change for each user in the
given list.
The users parameter is limited to 100 items per request.
The results are also limited
to 100 items.
This endpoint returns a max of 1 event per state per user.
For example, if a user
has 3 ACTIVATED events scheduled it will return the next upcoming activation event.
However, if a
user also has a SUSPENDED event scheduled along with the ACTIVATED events it will return the next
upcoming activation event _and_ the next upcoming suspension event.

## SYNTAX

```
Get-JcSdkNextScheduledBulkUserState -Users <String[]> [<CommonParameters>]
```

## DESCRIPTION
This endpoint is used to lookup the next upcoming scheduled state change for each user in the
given list.
The users parameter is limited to 100 items per request.
The results are also limited
to 100 items.
This endpoint returns a max of 1 event per state per user.
For example, if a user
has 3 ACTIVATED events scheduled it will return the next upcoming activation event.
However, if a
user also has a SUSPENDED event scheduled along with the ACTIVATED events it will return the next
upcoming activation event _and_ the next upcoming suspension event.

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

### -Users
A list of system user IDs, limited to 100 items.

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### JumpCloud.SDK.V2.Models.IPathsUbbqf1BulkUserstatesEventlistNextGetResponses200ContentApplicationJsonSchema

## NOTES

ALIASES

## RELATED LINKS

