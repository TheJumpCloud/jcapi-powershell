---
external help file:
Module Name: JumpCloud.SDK.V1
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V1/docs/exports/New-JcSdkCommand.md
schema: 2.0.0
---

# New-JcSdkCommand

## SYNOPSIS
This endpoint allows you to create a new command.

NOTE: the system property in the command is not used.
Use a POST to /api/v2/commands/{id}/associations to bind a command to a system.

#### Sample Request
```
curl -X POST https://console.jumpcloud.com/api/commands/ \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json'
  -H 'x-api-key: {API_KEY}'
  -d '{\"name\":\"Test API Command\", \"command\":\"String\", \"user\":\"{UserID}\", \"schedule\":\"\", \"timeout\":\"100\"}'
```

## SYNTAX

### CreateExpanded (Default)
```
New-JcSdkCommand -Command <String> -CommandType <String> -Name <String> [-CommandRunners <String[]>]
 [-Files <String[]>] [-LaunchType <String>] [-ListensTo <String>] [-Organization <String>]
 [-Schedule <String>] [-ScheduleRepeatType <String>] [-ScheduleYear <Int32>] [-Shell <String>] [-Sudo]
 [-Template <String>] [-Timeout <String>] [-TimeToLiveSeconds <Int32>] [-Trigger <String>] [-User <String>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-JcSdkCommand -Body <ICommand> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
This endpoint allows you to create a new command.

NOTE: the system property in the command is not used.
Use a POST to /api/v2/commands/{id}/associations to bind a command to a system.

#### Sample Request
```
curl -X POST https://console.jumpcloud.com/api/commands/ \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json'
  -H 'x-api-key: {API_KEY}'
  -d '{\"name\":\"Test API Command\", \"command\":\"String\", \"user\":\"{UserID}\", \"schedule\":\"\", \"timeout\":\"100\"}'
```

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
New-JcSdkCommand -Command:(<string>) -CommandType:(<string>) -Name:(<string>) -CommandRunners:(<string[]>) -Files:(<string[]>) -LaunchType:(<string>) -ListensTo:(<string>) -Organization:(<string>) -Schedule:(<string>) -ScheduleRepeatType:(<string>) -ScheduleYear:(<int>) -Shell:(<string>) -Sudo:(<switch>) -Template:(<string>) -TimeToLiveSeconds:(<int>) -Timeout:(<string>) -Trigger:(<string>) -User:(<string>)
```

----               ----------
Command1           String
CommandRunners     String
CommandType        String
Files              String
LaunchType         String
ListensTo          String
Name               String
Organization       String
Schedule           String
ScheduleRepeatType String
ScheduleYear       Int
Shell              String
Sudo               Boolean
Template           String
Timeout            String
TimeToLiveSeconds  Int
Trigger            String
User               String

### -------------------------- EXAMPLE 2 --------------------------
```powershell
New-JcSdkCommand -Body:(<JumpCloud.SDK.V1.Models.Command>)
```

----               ----------
Command1           String
CommandRunners     String
CommandType        String
Files              String
LaunchType         String
ListensTo          String
Name               String
Organization       String
Schedule           String
ScheduleRepeatType String
ScheduleYear       Int
Shell              String
Sudo               Boolean
Template           String
Timeout            String
TimeToLiveSeconds  Int
Trigger            String
User               String

## PARAMETERS

### -Body
Command
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: JumpCloud.SDK.V1.Models.ICommand
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Command
The command to execute on the server.

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

### -CommandRunners
An array of IDs of the Command Runner Users that can execute this command.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CommandType
The Command OS

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

### -Files
An array of file IDs to include with the command.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LaunchType
How the command will execute.

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

### -ListensTo
.

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

### -Name
.

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

### -Organization
The ID of the organization.

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

### -Schedule
A crontab that consists of: [ (seconds) (minutes) (hours) (days of month) (months) (weekdays) ] or [ immediate ].
If you send this as an empty string, it will run immediately.

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

### -ScheduleRepeatType
When the command will repeat.

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

### -ScheduleYear
The year that a scheduled command will launch in.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Shell
The shell used to run the command.

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

### -Sudo
.

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

### -Template
The template this command was created from

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

### -Timeout
The time in seconds to allow the command to run for.
The maximum value is 86400 seconds (1 day).

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

### -TimeToLiveSeconds
Time in seconds a command can wait in the queue to be run before timing out

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Trigger
The name of the command trigger.

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

### -User
The ID of the system user to run the command as.
This field is required when creating a command with a commandType of "mac" or "linux".

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

### JumpCloud.SDK.V1.Models.ICommand

## OUTPUTS

### JumpCloud.SDK.V1.Models.ICommand

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODY <ICommand>: Command
  - `Command1 <String>`: The command to execute on the server.
  - `CommandType <String>`: The Command OS
  - `Name <String>`: 
  - `[CommandRunners <String[]>]`: An array of IDs of the Command Runner Users that can execute this command.
  - `[Files <String[]>]`: An array of file IDs to include with the command.
  - `[LaunchType <String>]`: How the command will execute.
  - `[ListensTo <String>]`: 
  - `[Organization <String>]`: The ID of the organization.
  - `[Schedule <String>]`: A crontab that consists of: [ (seconds) (minutes) (hours) (days of month) (months) (weekdays) ] or [ immediate ]. If you send this as an empty string, it will run immediately.         
  - `[ScheduleRepeatType <String>]`: When the command will repeat.
  - `[ScheduleYear <Int32?>]`: The year that a scheduled command will launch in.
  - `[Shell <String>]`: The shell used to run the command.
  - `[Sudo <Boolean?>]`: 
  - `[Template <String>]`: The template this command was created from
  - `[TimeToLiveSeconds <Int32?>]`: Time in seconds a command can wait in the queue to be run before timing out
  - `[Timeout <String>]`: The time in seconds to allow the command to run for. The maximum value is 86400 seconds (1 day).
  - `[Trigger <String>]`: The name of the command trigger.
  - `[User <String>]`: The ID of the system user to run the command as. This field is required when creating a command with a commandType of "mac" or "linux".

## RELATED LINKS

