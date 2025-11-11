---
external help file:
Module Name: JumpCloud.SDK.V1
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/CUT-4908_userGroupDeviceGroupFilters/SDKs/PowerShell/JumpCloud.SDK.V1/docs/exports/Set-JcSdkAdministratorUser.md
schema: 2.0.0
---

# Set-JcSdkAdministratorUser

## SYNOPSIS
This endpoint allows you to set a user.

## SYNTAX

### SetExpanded (Default)
```
Set-JcSdkAdministratorUser -HostEnv <String> -Id <String> [-ApiKeyAllowed] [-Email <String>]
 [-EnableMultiFactor] [-Firstname <String>] [-GrowthData <Hashtable>] [-Lastname <String>]
 [-LastWhatsNewChecked <DateTime>] [-RoleName <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Set
```
Set-JcSdkAdministratorUser -HostEnv <String> -Id <String> -Body <IUserput> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### SetViaIdentity
```
Set-JcSdkAdministratorUser -HostEnv <String> -InputObject <IJumpCloudApiIdentity> -Body <IUserput> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### SetViaIdentityExpanded
```
Set-JcSdkAdministratorUser -HostEnv <String> -InputObject <IJumpCloudApiIdentity> [-ApiKeyAllowed]
 [-Email <String>] [-EnableMultiFactor] [-Firstname <String>] [-GrowthData <Hashtable>] [-Lastname <String>]
 [-LastWhatsNewChecked <DateTime>] [-RoleName <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
This endpoint allows you to set a user.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Set-JcSdkAdministratorUser -Id:(<string>) -Body:(<JumpCloud.SDK.V1.Models.Userput>)
```

----                       ----------
ApiKeyAllowed              Boolean
ApiKeySet                  Boolean
ApiKeyUpdatedAt            Datetime
Created                    Datetime
DisableIntroduction        Boolean
Email                      String
EnableMultiFactor          Boolean
Firstname                  String
GrowthDataExperimentStates JumpCloud.SDK.V1.Models.UserreturnGrowthDataExperimentStates
GrowthDataOnboardingState  JumpCloud.SDK.V1.Models.UserreturnGrowthDataOnboardingState
Id                         String
Lastname                   String
LastWhatsNewChecked        Datetime
Organization               String
PasswordUpdatedAt          Datetime
Provider                   String
Role                       String
RoleName                   String
SessionCount               Int
Suspended                  Boolean
TotpEnrolled               Boolean
TotpUpdatedAt              Datetime
UsersTimeZone              String

### -------------------------- EXAMPLE 2 --------------------------
```powershell
Set-JcSdkAdministratorUser -Id:(<string>) -ApiKeyAllowed:(<switch>) -Email:(<string>) -EnableMultiFactor:(<switch>) -Firstname:(<string>) -GrowthData:(<hashtable>) -LastWhatsNewChecked:(<datetime>) -Lastname:(<string>) -RoleName:(<string>)
```

----                       ----------
ApiKeyAllowed              Boolean
ApiKeySet                  Boolean
ApiKeyUpdatedAt            Datetime
Created                    Datetime
DisableIntroduction        Boolean
Email                      String
EnableMultiFactor          Boolean
Firstname                  String
GrowthDataExperimentStates JumpCloud.SDK.V1.Models.UserreturnGrowthDataExperimentStates
GrowthDataOnboardingState  JumpCloud.SDK.V1.Models.UserreturnGrowthDataOnboardingState
Id                         String
Lastname                   String
LastWhatsNewChecked        Datetime
Organization               String
PasswordUpdatedAt          Datetime
Provider                   String
Role                       String
RoleName                   String
SessionCount               Int
Suspended                  Boolean
TotpEnrolled               Boolean
TotpUpdatedAt              Datetime
UsersTimeZone              String

## PARAMETERS

### -ApiKeyAllowed
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Body
UserPut

```yaml
Type: JumpCloud.SDK.V1.Models.IUserput
Parameter Sets: Set, SetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Email
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

### -EnableMultiFactor
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Firstname
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

### -GrowthData
Dictionary of \<any\>

```yaml
Type: System.Collections.Hashtable
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

### -Id
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

### -InputObject
Identity Parameter

```yaml
Type: JumpCloud.SDK.V1.Models.IJumpCloudApiIdentity
Parameter Sets: SetViaIdentity, SetViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Lastname
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

### -LastWhatsNewChecked
.

```yaml
Type: System.DateTime
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RoleName
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

### JumpCloud.SDK.V1.Models.IJumpCloudApiIdentity

### JumpCloud.SDK.V1.Models.IUserput

## OUTPUTS

### JumpCloud.SDK.V1.Models.IUserreturn

## NOTES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODY <IUserput>`: UserPut
  - `[ApiKeyAllowed <Boolean?>]`: 
  - `[Email <String>]`: 
  - `[EnableMultiFactor <Boolean?>]`: 
  - `[Firstname <String>]`: 
  - `[GrowthData <IUserputGrowthData>]`: Dictionary of <any>
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[LastWhatsNewChecked <DateTime?>]`: 
  - `[Lastname <String>]`: 
  - `[RoleName <String>]`: 

`INPUTOBJECT <IJumpCloudApiIdentity>`: Identity Parameter
  - `[Id <String>]`: 
  - `[SystemId <String>]`: 
  - `[SystemuserId <String>]`: 
  - `[Triggername <String>]`: 

## RELATED LINKS

