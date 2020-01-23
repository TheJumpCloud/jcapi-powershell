---
external help file:
Module Name: JumpCloud.SDK.V1
online version: https://docs.microsoft.com/en-us/powershell/module/jumpcloud.sdk.v1/set-jcsdkcommand
schema: 2.0.0
---

# Set-JcSdkCommand

## SYNOPSIS
This endpoint Updates a command based on the command ID and returns the modified command record.\n\n#### Sample Request\n```\ncurl -X PUT https://console.jumpcloud.com/api/commands/{CommandID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n\t\"name\":\"Test API Command\",\n\t\"command\":\"String\",\n\t\"user\":\"{UserID}\",\n\t\"schedule\":\"\",\n\t\"timeout\":\"100\"\n}'\n\n```

## SYNTAX

### PutExpanded (Default)
```
Set-JcSdkCommand -Id <String> -Command <String> [-CommandRunners <String[]>] [-CommandType <String>]
 [-Files <String[]>] [-LaunchType <String>] [-ListensTo <String>] [-Name <String>] [-Organization <String>]
 [-Schedule <String>] [-ScheduleRepeatType <String>] [-Sudo] [-Systems <String[]>] [-Timeout <String>]
 [-Trigger <String>] [-User <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Put
```
Set-JcSdkCommand -Id <String> -Body <ICommand> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### PutViaIdentity
```
Set-JcSdkCommand -InputObject <IJumpCloudApIsIdentity> -Body <ICommand> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### PutViaIdentityExpanded
```
Set-JcSdkCommand -InputObject <IJumpCloudApIsIdentity> -Command <String> [-CommandRunners <String[]>]
 [-CommandType <String>] [-Files <String[]>] [-LaunchType <String>] [-ListensTo <String>] [-Name <String>]
 [-Organization <String>] [-Schedule <String>] [-ScheduleRepeatType <String>] [-Sudo] [-Systems <String[]>]
 [-Timeout <String>] [-Trigger <String>] [-User <String>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
This endpoint Updates a command based on the command ID and returns the modified command record.\n\n#### Sample Request\n```\ncurl -X PUT https://console.jumpcloud.com/api/commands/{CommandID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n\t\"name\":\"Test API Command\",\n\t\"command\":\"String\",\n\t\"user\":\"{UserID}\",\n\t\"schedule\":\"\",\n\t\"timeout\":\"100\"\n}'\n\n```

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
To view examples, please use the -Online parameter with Get-Help or navigate to: https://docs.microsoft.com/en-us/powershell/module/jumpcloud.sdk.v1/set-jcsdkcommand
```



## PARAMETERS

### -Body
Command
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: JumpCloud.SDK.V1.Models.ICommand
Parameter Sets: Put, PutViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -Command
The command to execute on the server.

```yaml
Type: System.String
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -CommandRunners
An array of IDs of the Command Runner Users that can execute this command.

```yaml
Type: System.String[]
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -CommandType
The Command OS

```yaml
Type: System.String
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Files
An array of file IDs to include with the command.

```yaml
Type: System.String[]
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Id
HELP MESSAGE MISSING

```yaml
Type: System.String
Parameter Sets: Put, PutExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: JumpCloud.SDK.V1.Models.IJumpCloudApIsIdentity
Parameter Sets: PutViaIdentity, PutViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -LaunchType
How the command will execute.

```yaml
Type: System.String
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ListensTo
HELP MESSAGE MISSING

```yaml
Type: System.String
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Name
HELP MESSAGE MISSING

```yaml
Type: System.String
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Organization
The ID of the organization.

```yaml
Type: System.String
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -PassThru
Returns true when the command succeeds

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Schedule
A crontab that consists of: [ (seconds) (minutes) (hours) (days of month) (months) (weekdays) ] or [ immediate ].
If you send this as an empty string, it will run immediately.

```yaml
Type: System.String
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ScheduleRepeatType
When the command will repeat.

```yaml
Type: System.String
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Sudo
HELP MESSAGE MISSING

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Systems
An array of system IDs to run the command on.
Not available if you are using Groups.

```yaml
Type: System.String[]
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Timeout
The time in seconds to allow the command to run for.

```yaml
Type: System.String
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Trigger
The name of the command trigger.

```yaml
Type: System.String
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -User
The ID of the system user to run the command as.
This field is required when creating a command with a commandType of "mac" or "linux".

```yaml
Type: System.String
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
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
Dynamic: False
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
Dynamic: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### JumpCloud.SDK.V1.Models.ICommand

### JumpCloud.SDK.V1.Models.IJumpCloudApIsIdentity

## OUTPUTS

### JumpCloud.SDK.V1.Models.ICommand

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### BODY <ICommand>: Command
  - `Command1 <String>`: The command to execute on the server.
  - `[CommandRunners <String[]>]`: An array of IDs of the Command Runner Users that can execute this command.
  - `[CommandType <String>]`: The Command OS
  - `[Files <String[]>]`: An array of file IDs to include with the command.
  - `[LaunchType <String>]`: How the command will execute.
  - `[ListensTo <String>]`: 
  - `[Name <String>]`: 
  - `[Organization <String>]`: The ID of the organization.
  - `[Schedule <String>]`: A crontab that consists of: [ (seconds) (minutes) (hours) (days of month) (months) (weekdays) ] or [ immediate ]. If you send this as an empty string, it will run immediately.         
  - `[ScheduleRepeatType <String>]`: When the command will repeat.
  - `[Sudo <Boolean?>]`: 
  - `[Systems <String[]>]`: An array of system IDs to run the command on. Not available if you are using Groups.
  - `[Timeout <String>]`: The time in seconds to allow the command to run for.
  - `[Trigger <String>]`: The name of the command trigger.
  - `[User <String>]`: The ID of the system user to run the command as. This field is required when creating a command with a commandType of "mac" or "linux".

#### INPUTOBJECT <IJumpCloudApIsIdentity>: Identity Parameter
  - `[Id <String>]`: 
  - `[SystemuserId <String>]`: 
  - `[Triggername <String>]`: 

## RELATED LINKS

