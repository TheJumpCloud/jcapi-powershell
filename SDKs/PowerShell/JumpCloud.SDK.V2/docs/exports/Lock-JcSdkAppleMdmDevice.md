---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Lock-JcSdkAppleMdmDevice.md
schema: 2.0.0
---

# Lock-JcSdkAppleMdmDevice

## SYNOPSIS
Locks a DEP-enrolled device.

#### Sample Request
```
  curl -X POST https://console.jumpcloud.com/api/v2/applemdms/{apple_mdm_id}/devices/{device_id}/lock \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{}'
```

## SYNTAX

### LockExpanded (Default)
```
Lock-JcSdkAppleMdmDevice -AppleMdmId <String> -DeviceId <String> [-Pin <String>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Lock
```
Lock-JcSdkAppleMdmDevice -AppleMdmId <String> -DeviceId <String>
 -Body <IPathsLf7IzoApplemdmsAppleMdmIdDevicesDeviceIdLockPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### LockViaIdentity
```
Lock-JcSdkAppleMdmDevice -InputObject <IJumpCloudApiIdentity>
 -Body <IPathsLf7IzoApplemdmsAppleMdmIdDevicesDeviceIdLockPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### LockViaIdentityExpanded
```
Lock-JcSdkAppleMdmDevice -InputObject <IJumpCloudApiIdentity> [-Pin <String>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Locks a DEP-enrolled device.

#### Sample Request
```
  curl -X POST https://console.jumpcloud.com/api/v2/applemdms/{apple_mdm_id}/devices/{device_id}/lock \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{}'
```

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Lock-JcSdkAppleMdmDevice -AppleMdmId:(<string>) -DeviceId:(<string>) -Pin:(<string>)
```



### -------------------------- EXAMPLE 2 --------------------------
```powershell
Lock-JcSdkAppleMdmDevice -AppleMdmId:(<string>) -DeviceId:(<string>) -Body:(<JumpCloud.SDK.V2.Models.PathsLf7IzoApplemdmsAppleMdmIdDevicesDeviceIdLockPostRequestbodyContentApplicationJsonSchema>)
```



## PARAMETERS

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
Type: JumpCloud.SDK.V2.Models.IPathsLf7IzoApplemdmsAppleMdmIdDevicesDeviceIdLockPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Lock, LockViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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
Type: JumpCloud.SDK.V2.Models.IJumpCloudApiIdentity
Parameter Sets: LockViaIdentity, LockViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
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
```

### -Pin
6-digit PIN, required for MacOS, to lock the device

```yaml
Type: System.String
Parameter Sets: LockExpanded, LockViaIdentityExpanded
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

### JumpCloud.SDK.V2.Models.IJumpCloudApiIdentity

### JumpCloud.SDK.V2.Models.IPathsLf7IzoApplemdmsAppleMdmIdDevicesDeviceIdLockPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODY <IPathsLf7IzoApplemdmsAppleMdmIdDevicesDeviceIdLockPostRequestbodyContentApplicationJsonSchema>: .
  - `[Pin <String>]`: 6-digit PIN, required for MacOS, to lock the device

INPUTOBJECT <IJumpCloudApiIdentity>: Identity Parameter
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

