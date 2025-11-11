---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/CUT-4908_userGroupDeviceGroupFilters/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Update-JcSdkUserPushEndpoint.md
schema: 2.0.0
---

# Update-JcSdkUserPushEndpoint

## SYNOPSIS
This endpoint will update a push endpoint associated with a user.

## SYNTAX

### UpdateExpanded (Default)
```
Update-JcSdkUserPushEndpoint -HostEnv <String> -PushEndpointId <String> -UserId <String> [-Name <String>]
 [-State <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-JcSdkUserPushEndpoint -HostEnv <String> -PushEndpointId <String> -UserId <String>
 -Body <IPathsO4Si39UsersUserIdPushendpointsPushEndpointIdPatchRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-JcSdkUserPushEndpoint -HostEnv <String> -InputObject <IJumpCloudApiIdentity>
 -Body <IPathsO4Si39UsersUserIdPushendpointsPushEndpointIdPatchRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-JcSdkUserPushEndpoint -HostEnv <String> -InputObject <IJumpCloudApiIdentity> [-Name <String>]
 [-State <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
This endpoint will update a push endpoint associated with a user.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Update-JcSdkUserPushEndpoint -PushEndpointId:(<string>) -UserId:(<string>) -Body:(<JumpCloud.SDK.V2.Models.PathsO4Si39UsersUserIdPushendpointsPushEndpointIdPatchRequestbodyContentApplicationJsonSchema>)
```

----             ----------
DeviceAppVersion String
DeviceMake       String
DeviceModel      String
DeviceOS         String
DeviceOSVersion  String
DeviceUvEnabled  Boolean
EnrollmentDate   Datetime
Id               String
LastUsedDate     Datetime
Name             String
State            String

### -------------------------- EXAMPLE 2 --------------------------
```powershell
Update-JcSdkUserPushEndpoint -PushEndpointId:(<string>) -UserId:(<string>) -Name:(<string>) -State:(<string>)
```

----             ----------
DeviceAppVersion String
DeviceMake       String
DeviceModel      String
DeviceOS         String
DeviceOSVersion  String
DeviceUvEnabled  Boolean
EnrollmentDate   Datetime
Id               String
LastUsedDate     Datetime
Name             String
State            String

## PARAMETERS

### -Body
.

```yaml
Type: JumpCloud.SDK.V2.Models.IPathsO4Si39UsersUserIdPushendpointsPushEndpointIdPatchRequestbodyContentApplicationJsonSchema
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Name
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PushEndpointId
.

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -State
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserId
.

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
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

### JumpCloud.SDK.V2.Models.IJumpCloudApiIdentity

### JumpCloud.SDK.V2.Models.IPathsO4Si39UsersUserIdPushendpointsPushEndpointIdPatchRequestbodyContentApplicationJsonSchema

## OUTPUTS

### JumpCloud.SDK.V2.Models.IPushEndpointResponse

## NOTES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODY <IPathsO4Si39UsersUserIdPushendpointsPushEndpointIdPatchRequestbodyContentApplicationJsonSchema>`: .
  - `[Name <String>]`: 
  - `[State <String>]`: 

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

