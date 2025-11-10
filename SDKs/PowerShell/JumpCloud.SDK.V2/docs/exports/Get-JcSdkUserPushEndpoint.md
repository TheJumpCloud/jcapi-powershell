---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/CUT-4908_userGroupDeviceGroupFilters/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Get-JcSdkUserPushEndpoint.md
schema: 2.0.0
---

# Get-JcSdkUserPushEndpoint

## SYNOPSIS
This endpoint will retrieve a push endpoint associated with a user.

## SYNTAX

### List (Default)
```
Get-JcSdkUserPushEndpoint -HostEnv <String> -UserId <String> [<CommonParameters>]
```

### Get
```
Get-JcSdkUserPushEndpoint -HostEnv <String> -PushEndpointId <String> -UserId <String> [<CommonParameters>]
```

### GetViaIdentity
```
Get-JcSdkUserPushEndpoint -HostEnv <String> -InputObject <IJumpCloudApiIdentity> [<CommonParameters>]
```

## DESCRIPTION
This endpoint will retrieve a push endpoint associated with a user.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Get-JcSdkUserPushEndpoint -UserId:(<string>)
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
Get-JcSdkUserPushEndpoint -UserId:(<string>) -PushEndpointId:(<string>)
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
Parameter Sets: GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -PushEndpointId
.

```yaml
Type: System.String
Parameter Sets: Get
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserId
.

```yaml
Type: System.String
Parameter Sets: Get, List
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

### JumpCloud.SDK.V2.Models.IJumpCloudApiIdentity

## OUTPUTS

### JumpCloud.SDK.V2.Models.IPushEndpointResponse

## NOTES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


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

