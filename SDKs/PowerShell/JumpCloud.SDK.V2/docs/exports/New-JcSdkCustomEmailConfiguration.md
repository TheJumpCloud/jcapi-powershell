---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/CUT-4908_userGroupDeviceGroupFilters/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/New-JcSdkCustomEmailConfiguration.md
schema: 2.0.0
---

# New-JcSdkCustomEmailConfiguration

## SYNOPSIS
Create the custom email configuration for the specified custom email type.

This action is only available to paying customers.

## SYNTAX

### CreateExpanded (Default)
```
New-JcSdkCustomEmailConfiguration -HostEnv <String> [-Body <String>] [-Button <String>] [-Header <String>]
 [-NextStepContactInfo <String>] [-Subject <String>] [-Title <String>] [-Type <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-JcSdkCustomEmailConfiguration -HostEnv <String> -CustomEmail <ICustomEmail> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create the custom email configuration for the specified custom email type.

This action is only available to paying customers.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
New-JcSdkCustomEmailConfiguration -Subject:(<string>) -Type:(<string>) -Body:(<string>) -Button:(<string>) -Header:(<string>) -NextStepContactInfo:(<string>) -Title:(<string>)
```

----                ----------
Body                String
Button              String
Header              String
Id                  String
NextStepContactInfo String
Subject             String
Title               String
Type                String

### -------------------------- EXAMPLE 2 --------------------------
```powershell
New-JcSdkCustomEmailConfiguration -CustomEmail:(<JumpCloud.SDK.V2.Models.CustomEmail>)
```

----                ----------
Body                String
Button              String
Header              String
Id                  String
NextStepContactInfo String
Subject             String
Title               String
Type                String

## PARAMETERS

### -Body
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

### -Button
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

### -CustomEmail
Custom email content created by the admin user to personalize emails sent to their system users.

```yaml
Type: JumpCloud.SDK.V2.Models.ICustomEmail
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Header
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

### -HostEnv
Region for JumpCloud API host.
Use 'console' for US or 'console.eu' for EU.

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

### -NextStepContactInfo
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

### -Subject
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

### -Title
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

### -Type
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

### JumpCloud.SDK.V2.Models.ICustomEmail

## OUTPUTS

### JumpCloud.SDK.V2.Models.ICustomEmail

## NOTES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`CUSTOMEMAIL <ICustomEmail>`: Custom email content created by the admin user to personalize emails sent to their system users.
  - `Subject <String>`: 
  - `Type <String>`: 
  - `[Body <String>]`: 
  - `[Button <String>]`: 
  - `[Header <String>]`: 
  - `[NextStepContactInfo <String>]`: 
  - `[Title <String>]`: 

## RELATED LINKS

