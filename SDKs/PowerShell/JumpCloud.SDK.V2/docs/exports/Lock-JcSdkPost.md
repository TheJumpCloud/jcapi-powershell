---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Lock-JcSdkPost.md
schema: 2.0.0
---

# Lock-JcSdkPost

## SYNOPSIS
This endpoint triggers collecting information about the device in question.
It is not intended for public use.

## SYNTAX

### LockExpanded (Default)
```
Lock-JcSdkPost -AppleMdmId <String> -DeviceId <String> [-CreationSource <String>]
 [-ActivationLockAllowedWhileSupervised] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Lock
```
Lock-JcSdkPost -AppleMdmId <String> -DeviceId <String>
 -Body <IPaths1Foyt92ApplemdmsAppleMdmIdDevicesDeviceIdEnqueueactivationlockdebugcommandsPostRequestbodyContentApplicationJsonSchema>
 [-CreationSource <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### LockViaIdentity
```
Lock-JcSdkPost -InputObject <IJumpCloudApIsIdentity>
 -Body <IPaths1Foyt92ApplemdmsAppleMdmIdDevicesDeviceIdEnqueueactivationlockdebugcommandsPostRequestbodyContentApplicationJsonSchema>
 [-CreationSource <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### LockViaIdentityExpanded
```
Lock-JcSdkPost -InputObject <IJumpCloudApIsIdentity> [-CreationSource <String>]
 [-ActivationLockAllowedWhileSupervised] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
This endpoint triggers collecting information about the device in question.
It is not intended for public use.

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

### -ActivationLockAllowedWhileSupervised
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: LockExpanded, LockViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AppleMdmId
.

```yaml
Type: System.String
Parameter Sets: Lock, LockExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Body
.
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: JumpCloud.SDK.V2.Models.IPaths1Foyt92ApplemdmsAppleMdmIdDevicesDeviceIdEnqueueactivationlockdebugcommandsPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Lock, LockViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreationSource
Defines the creation-source header for gapps, o365 and workdays requests.
If the header isn't sent, the default value is `jumpcloud:bulk`, if you send the header with a malformed value you receive a 400 error.
Allowed: `jumpcloud:gapps`, `jumpcloud:o365`, `jumpcloud:workday`, `jumpcloud:bulk`.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceId
.

```yaml
Type: System.String
Parameter Sets: Lock, LockExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity
Parameter Sets: LockViaIdentity, LockViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity

### JumpCloud.SDK.V2.Models.IPaths1Foyt92ApplemdmsAppleMdmIdDevicesDeviceIdEnqueueactivationlockdebugcommandsPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### JumpCloud.SDK.V2.Models.IAny

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODY <IPaths1Foyt92ApplemdmsAppleMdmIdDevicesDeviceIdEnqueueactivationlockdebugcommandsPostRequestbodyContentApplicationJsonSchema>: .
  - `[ActivationLockAllowedWhileSupervised <Boolean?>]`: 

INPUTOBJECT <IJumpCloudApIsIdentity>: Identity Parameter
  - `[AccountId <String>]`: 
  - `[ActivedirectoryId <String>]`: 
  - `[AppleMdmId <String>]`: 
  - `[ApplicationId <String>]`: ObjectID of the Application.
  - `[CommandId <String>]`: ObjectID of the Command.
  - `[CustomEmailType <String>]`: 
  - `[DeviceId <String>]`: 
  - `[GroupId <String>]`: ObjectID of the System Group.
  - `[GsuiteId <String>]`: ObjectID of the G Suite instance.
  - `[Id <String>]`: ObjectID of this Active Directory instance.
  - `[JobId <String>]`: 
  - `[LdapserverId <String>]`: ObjectID of the LDAP Server.
  - `[Office365Id <String>]`: ObjectID of the Office 365 instance.
  - `[PolicyId <String>]`: ObjectID of the Policy.
  - `[ProviderId <String>]`: 
  - `[RadiusserverId <String>]`: ObjectID of the Radius Server.
  - `[SoftwareAppId <String>]`: ObjectID of the Software App.
  - `[SystemId <String>]`: ObjectID of the System.
  - `[UserId <String>]`: ObjectID of the User.
  - `[WorkdayId <String>]`: 

## RELATED LINKS

