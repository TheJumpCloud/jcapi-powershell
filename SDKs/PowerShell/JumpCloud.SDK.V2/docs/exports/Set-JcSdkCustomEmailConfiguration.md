---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/CUT-4908_userGroupDeviceGroupFilters/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Set-JcSdkCustomEmailConfiguration.md
schema: 2.0.0
---

# Set-JcSdkCustomEmailConfiguration

## SYNOPSIS
Set the custom email configuration for the specified custom email type.

This action is only available to paying customers.

## SYNTAX

### SetExpanded (Default)
```
Set-JcSdkCustomEmailConfiguration -HostEnv <String> -CustomEmailType <String> [-Body <String>]
 [-Button <String>] [-Header <String>] [-NextStepContactInfo <String>] [-Subject <String>] [-Title <String>]
 [-Type <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Set
```
Set-JcSdkCustomEmailConfiguration -HostEnv <String> -CustomEmailType <String> -CustomEmail <ICustomEmail>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### SetViaIdentity
```
Set-JcSdkCustomEmailConfiguration -HostEnv <String> -InputObject <IJumpCloudApiIdentity>
 -CustomEmail <ICustomEmail> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### SetViaIdentityExpanded
```
Set-JcSdkCustomEmailConfiguration -HostEnv <String> -InputObject <IJumpCloudApiIdentity> [-Body <String>]
 [-Button <String>] [-Header <String>] [-NextStepContactInfo <String>] [-Subject <String>] [-Title <String>]
 [-Type <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Set the custom email configuration for the specified custom email type.

This action is only available to paying customers.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Set-JcSdkCustomEmailConfiguration -CustomEmailType:(<string>) -CustomEmail:(<JumpCloud.SDK.V2.Models.CustomEmail>)
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
Set-JcSdkCustomEmailConfiguration -CustomEmailType:(<string>) -Subject:(<string>) -Type:(<string>) -Body:(<string>) -Button:(<string>) -Header:(<string>) -NextStepContactInfo:(<string>) -Title:(<string>)
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
Parameter Sets: SetExpanded, SetViaIdentityExpanded
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
Parameter Sets: SetExpanded, SetViaIdentityExpanded
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
Parameter Sets: Set, SetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CustomEmailType
.

```yaml
Type: System.String
Parameter Sets: Set, SetExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Header
.

```yaml
Type: System.String
Parameter Sets: SetExpanded, SetViaIdentityExpanded
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

### -InputObject
Identity Parameter

```yaml
Type: JumpCloud.SDK.V2.Models.IJumpCloudApiIdentity
Parameter Sets: SetViaIdentity, SetViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -NextStepContactInfo
.

```yaml
Type: System.String
Parameter Sets: SetExpanded, SetViaIdentityExpanded
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
Parameter Sets: SetExpanded, SetViaIdentityExpanded
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
Parameter Sets: SetExpanded, SetViaIdentityExpanded
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
Parameter Sets: SetExpanded, SetViaIdentityExpanded
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

### JumpCloud.SDK.V2.Models.IJumpCloudApiIdentity

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

`INPUTOBJECT <IJumpCloudApiIdentity>`: Identity Parameter
  - `[AccountId <String>]`: 
  - `[ActivedirectoryId <String>]`: 
  - `[AdministratorId <String>]`: 
  - `[AgentId <String>]`: 
  - `[AppleMdmId <String>]`: 
  - `[ApplicationId <String>]`: ObjectID of the Application.
  - `[CommandId <String>]`: ObjectID of the Command.
  - `[CustomEmailType <String>]`: 
  - `[DeviceId <String>]`: 
  - `[GroupId <String>]`: ObjectID of the Policy Group.
  - `[GsuiteId <String>]`: ObjectID of the G Suite instance.
  - `[Id <String>]`: ObjectID of this Active Directory instance.
  - `[JobId <String>]`: 
  - `[LdapserverId <String>]`: ObjectID of the LDAP Server.
  - `[Office365Id <String>]`: ObjectID of the Office 365 instance.
  - `[PolicyId <String>]`: ObjectID of the Policy.
  - `[ProviderId <String>]`: 
  - `[PushEndpointId <String>]`: 
  - `[RadiusserverId <String>]`: ObjectID of the Radius Server.
  - `[SoftwareAppId <String>]`: ObjectID of the Software App.
  - `[SystemId <String>]`: ObjectID of the System.
  - `[UserId <String>]`: ObjectID of the User.
  - `[WorkdayId <String>]`: 

## RELATED LINKS

