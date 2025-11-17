---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Get-JcSdkAppleMdmDevice.md
schema: 2.0.0
---

# Get-JcSdkAppleMdmDevice

## SYNOPSIS
Gets a single Apple MDM device.

#### Sample Request
```
  curl -X GET https://console.jumpcloud.com/api/v2/applemdms/{apple_mdm_id}/devices/{device_id} \\
  -H 'accept: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

## SYNTAX

### List (Default)
```
Get-JcSdkAppleMdmDevice -ConsoleHost <String> -AppleMdmId <String> [-Filter <List<String>>]
 [-Sort <List<String>>] [-XTotalCount <Int32>] [<CommonParameters>]
```

### Get
```
Get-JcSdkAppleMdmDevice -ConsoleHost <String> -AppleMdmId <String> -DeviceId <String> [<CommonParameters>]
```

### GetViaIdentity
```
Get-JcSdkAppleMdmDevice -ConsoleHost <String> -InputObject <IJumpCloudApiIdentity> [<CommonParameters>]
```

## DESCRIPTION
Gets a single Apple MDM device.

#### Sample Request
```
  curl -X GET https://console.jumpcloud.com/api/v2/applemdms/{apple_mdm_id}/devices/{device_id} \\
  -H 'accept: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Get-JcSdkAppleMdmDevice -AppleMdmId:(<string>) -Filter:(<string[]>) -Sort:(<string[]>) -XTotalCount:(<int>)
```

----                                                  ----------
CreatedAt                                             String
DepRegistered                                         Boolean
DeviceInformationActivationLockAllowedWhileSupervised Boolean
DeviceInformationAvailableDeviceCapacity              System.Nullable[float] DeviceInformationAvailableDeviceCapacity {get;set;}
DeviceInformationDeviceCapacity                       System.Nullable[float] DeviceInformationDeviceCapacity {get;set;}
DeviceInformationDeviceName                           String
DeviceInformationIccid                                String
DeviceInformationImei                                 String
DeviceInformationIsSupervised                         Boolean
DeviceInformationModelName                            String
DeviceInformationSecondIccid                          String
DeviceInformationSecondImei                           String
DeviceInformationSecondSubscriberCarrierNetwork       String
DeviceInformationSubscriberCarrierNetwork             String
DeviceInformationWifiMac                              String
Enrolled                                              Boolean
HasActivationLockBypassCodes                          Boolean
Id                                                    String
OSVersion                                             String
SecurityInfoEnrolledViaDep                            Boolean
SecurityInfoIsActivationLockManageable                Boolean
SecurityInfoIsUserEnrollment                          Boolean
SecurityInfoPasscodePresent                           Boolean
SecurityInfoUserApprovedEnrollment                    Boolean
SerialNumber                                          String
Udid                                                  String

### -------------------------- EXAMPLE 2 --------------------------
```powershell
Get-JcSdkAppleMdmDevice -AppleMdmId:(<string>) -DeviceId:(<string>)
```

----                                                  ----------
CreatedAt                                             String
DepRegistered                                         Boolean
DeviceInformationActivationLockAllowedWhileSupervised Boolean
DeviceInformationAvailableDeviceCapacity              System.Nullable[float] DeviceInformationAvailableDeviceCapacity {get;set;}
DeviceInformationDeviceCapacity                       System.Nullable[float] DeviceInformationDeviceCapacity {get;set;}
DeviceInformationDeviceName                           String
DeviceInformationIccid                                String
DeviceInformationImei                                 String
DeviceInformationIsSupervised                         Boolean
DeviceInformationModelName                            String
DeviceInformationSecondIccid                          String
DeviceInformationSecondImei                           String
DeviceInformationSecondSubscriberCarrierNetwork       String
DeviceInformationSubscriberCarrierNetwork             String
DeviceInformationWifiMac                              String
Enrolled                                              Boolean
HasActivationLockBypassCodes                          Boolean
Id                                                    String
OSVersion                                             String
SecurityInfoEnrolledViaDep                            Boolean
SecurityInfoIsActivationLockManageable                Boolean
SecurityInfoIsUserEnrollment                          Boolean
SecurityInfoPasscodePresent                           Boolean
SecurityInfoUserApprovedEnrollment                    Boolean
SerialNumber                                          String
Udid                                                  String

## PARAMETERS

### -AppleMdmId
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

### -ConsoleHost
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

### -DeviceId
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

### -Filter
A filter to apply to the query.

**Filter structure**: `\<field\>:\<operator\>:\<value\>`.

**field** = Populate with a valid field from an endpoint response.

**operator** = Supported operators are: eq, ne, gt, ge, lt, le, between, search, in.
_Note: v1 operators differ from v2 operators._

**value** = Populate with the value you want to search for.
Is case sensitive.
Supports wild cards.

**EX:** `GET /api/v2/groups?filter=name:eq:Test+Group`

```yaml
Type: System.Collections.Generic.List`1[[System.String, System.Private.CoreLib, Version=9.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]]
Parameter Sets: List
Aliases:

Required: False
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

### -Sort
The comma separated fields used to sort the collection.
Default sort is ascending, prefix with `-` to sort descending.

```yaml
Type: System.Collections.Generic.List`1[[System.String, System.Private.CoreLib, Version=9.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]]
Parameter Sets: List
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -XTotalCount
.

```yaml
Type: System.Int32
Parameter Sets: List
Aliases:

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

## OUTPUTS

### JumpCloud.SDK.V2.Models.IAppleMdmDevice

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

