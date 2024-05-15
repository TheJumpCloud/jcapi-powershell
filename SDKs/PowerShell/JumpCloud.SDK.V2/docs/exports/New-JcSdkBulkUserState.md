---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/New-JcSdkBulkUserState.md
schema: 2.0.0
---

# New-JcSdkBulkUserState

## SYNOPSIS
This endpoint allows you to create scheduled statechange jobs.
#### Sample Request
```
curl -X POST \"https://console.jumpcloud.com/api/v2/bulk/userstates\" \\
  -H 'x-api-key: {API_KEY}' \\
  -H 'Content-Type: application/json' \\
  -H 'Accept: application/json' \\
  -d '{
    \"user_ids\": [\"{User_ID_1}\", \"{User_ID_2}\", \"{User_ID_3}\"],
    \"state\": \"SUSPENDED\",
    \"start_date\": \"2000-01-01T00:00:00.000Z\"
  }'
```

## SYNTAX

### CreateExpanded (Default)
```
New-JcSdkBulkUserState -StartDate <DateTime> -State <String> -UserIds <String[]>
 [-ActivationEmailOverride <String>] [-SendActivationEmails] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-JcSdkBulkUserState -Body <IBulkScheduledStatechangeCreate> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
This endpoint allows you to create scheduled statechange jobs.
#### Sample Request
```
curl -X POST \"https://console.jumpcloud.com/api/v2/bulk/userstates\" \\
  -H 'x-api-key: {API_KEY}' \\
  -H 'Content-Type: application/json' \\
  -H 'Accept: application/json' \\
  -d '{
    \"user_ids\": [\"{User_ID_1}\", \"{User_ID_2}\", \"{User_ID_3}\"],
    \"state\": \"SUSPENDED\",
    \"start_date\": \"2000-01-01T00:00:00.000Z\"
  }'
```

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
New-JcSdkBulkUserState -StartDate:(<datetime>) -State:(<string>) -UserIds:(<string[]>) -ActivationEmailOverride:(<string>) -SendActivationEmails:(<switch>)
```

----           ----------
ScheduledDate  String
ScheduledJobId String
State          String
SystemUserId   String

### -------------------------- EXAMPLE 2 --------------------------
```powershell
New-JcSdkBulkUserState -Body:(<JumpCloud.SDK.V2.Models.BulkScheduledStatechangeCreate>)
```

----           ----------
ScheduledDate  String
ScheduledJobId String
State          String
SystemUserId   String

## PARAMETERS

### -ActivationEmailOverride
Send the activation or welcome email to the specified email address upon activation.
Can only be used with a single user_id and scheduled activation.
This field will be ignored if `send_activation_emails` is explicitly set to false.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Body
Model to support bulk scheduling of a state change for one or more users
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: JumpCloud.SDK.V2.Models.IBulkScheduledStatechangeCreate
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -SendActivationEmails
Set to true to send activation or welcome email(s) to each user_id upon activation.
Set to false to suppress emails.
Can only be used with scheduled activation(s).

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StartDate
Date and time that scheduled action should occur

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -State
The state to move the user(s) to

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserIds
Array of system user ids to schedule for a state change

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded
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

### JumpCloud.SDK.V2.Models.IBulkScheduledStatechangeCreate

## OUTPUTS

### JumpCloud.SDK.V2.Models.IScheduledUserstateResult

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODY <IBulkScheduledStatechangeCreate>: Model to support bulk scheduling of a state change for one or more users
  - `StartDate <DateTime>`: Date and time that scheduled action should occur
  - `State <String>`: The state to move the user(s) to
  - `UserIds <String[]>`: Array of system user ids to schedule for a state change
  - `[ActivationEmailOverride <String>]`: Send the activation or welcome email to the specified email address upon activation. Can only be used with a single user_id and scheduled activation. This field will be ignored if `send_activation_emails` is explicitly set to false.
  - `[SendActivationEmails <Boolean?>]`: Set to true to send activation or welcome email(s) to each user_id upon activation. Set to false to suppress emails. Can only be used with scheduled activation(s).

## RELATED LINKS

