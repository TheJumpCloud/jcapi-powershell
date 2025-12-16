---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Import-JcSdkWorkday.md
schema: 2.0.0
---

# Import-JcSdkWorkday

## SYNOPSIS
The endpoint allows you to import a Workday Import request.

#### Sample Request 
```
curl -X POST https://console.jumpcloud.com/api/v2/workdays/{WorkdayID}/import \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '[
\t{
\t\t\"email\":\"{email}\",
\t\t\"firstname\":\"{firstname}\",
\t\t\"lastname\":\"{firstname}\",
\t\t\"username\":\"{username}\",
\t\t\"attributes\":[
\t\t\t{\"name\":\"EmployeeID\",\"value\":\"0000\"},
\t\t\t{\"name\":\"WorkdayID\",\"value\":\"name.name\"}
\t\t\t]
\t\t
\t}
]
```

## SYNTAX

### Import (Default)
```
Import-JcSdkWorkday -ConsoleHost <String> -WorkdayId <String> -Body <List<IBulkUserCreate>> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### ImportViaIdentity
```
Import-JcSdkWorkday -ConsoleHost <String> -InputObject <IJumpCloudApiIdentity> -Body <List<IBulkUserCreate>>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
The endpoint allows you to import a Workday Import request.

#### Sample Request 
```
curl -X POST https://console.jumpcloud.com/api/v2/workdays/{WorkdayID}/import \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '[
\t{
\t\t\"email\":\"{email}\",
\t\t\"firstname\":\"{firstname}\",
\t\t\"lastname\":\"{firstname}\",
\t\t\"username\":\"{username}\",
\t\t\"attributes\":[
\t\t\t{\"name\":\"EmployeeID\",\"value\":\"0000\"},
\t\t\t{\"name\":\"WorkdayID\",\"value\":\"name.name\"}
\t\t\t]
\t\t
\t}
]
```

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Import-JcSdkWorkday -WorkdayId:(<string>)
```



### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

## PARAMETERS

### -Body
Array of bulk-user-create

```yaml
Type: System.Collections.Generic.List`1[[JumpCloud.SDK.V2.Models.IBulkUserCreate, JumpCloud.SDK.V2.private, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### -InputObject
Identity Parameter

```yaml
Type: JumpCloud.SDK.V2.Models.IJumpCloudApiIdentity
Parameter Sets: ImportViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -WorkdayId
.

```yaml
Type: System.String
Parameter Sets: Import
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

### System.Collections.Generic.List`1[[JumpCloud.SDK.V2.Models.IBulkUserCreate, JumpCloud.SDK.V2.private, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]

## OUTPUTS

### JumpCloud.SDK.V2.Models.IJobIdResult

## NOTES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODY <List<IBulkUserCreate>>`: Array of bulk-user-create
  - `[AccountLocked <Boolean?>]`: 
  - `[Activated <Boolean?>]`: 
  - `[Addresses <List<IBulkUserCreateAddressesItem>>]`: 
    - `[Country <String>]`: 
    - `[ExtendedAddress <String>]`: 
    - `[Locality <String>]`: 
    - `[PoBox <String>]`: 
    - `[PostalCode <String>]`: 
    - `[Region <String>]`: 
    - `[StreetAddress <String>]`: 
    - `[Type <String>]`: 
  - `[AllowPublicKey <Boolean?>]`: 
  - `[AlternateEmail <String>]`: 
  - `[Attributes <List<IBulkUserCreateAttributesItem>>]`: 
    - `[Name <String>]`: 
    - `[Value <String>]`: 
  - `[Company <String>]`: 
  - `[CostCenter <String>]`: 
  - `[DelegatedAuthorityId <String>]`: ObjectId of the target Active Directory connection
  - `[DelegatedAuthorityName <String>]`: Authority name
  - `[Department <String>]`: 
  - `[Description <String>]`: 
  - `[DisableDeviceMaxLoginAttempts <Boolean?>]`: 
  - `[Displayname <String>]`: 
  - `[Email <String>]`: 
  - `[EmployeeIdentifier <String>]`: Must be unique per user. 
  - `[EmployeeType <String>]`: 
  - `[EnableManagedUid <Boolean?>]`: 
  - `[EnableUserPortalMultifactor <Boolean?>]`: 
  - `[ExternalDn <String>]`: 
  - `[ExternalPasswordExpirationDate <DateTime?>]`: 
  - `[ExternalSourceType <String>]`: 
  - `[ExternallyManaged <Boolean?>]`: 
  - `[Firstname <String>]`: 
  - `[JobTitle <String>]`: 
  - `[Lastname <String>]`: 
  - `[LdapBindingUser <Boolean?>]`: 
  - `[Location <String>]`: 
  - `[ManagedAppleId <String>]`: 
  - `[Manager <String>]`: Relation with another systemuser to identify the last as a manager.
  - `[MfaConfigured <Boolean?>]`: 
  - `[MfaExclusion <Boolean?>]`: 
  - `[MfaExclusionDays <Int32?>]`: 
  - `[MfaExclusionUntil <DateTime?>]`: 
  - `[Middlename <String>]`: 
  - `[Password <String>]`: 
  - `[PasswordNeverExpires <Boolean?>]`: 
  - `[PasswordlessSudo <Boolean?>]`: 
  - `[PhoneNumbers <List<IBulkUserCreatePhoneNumbersItem>>]`: 
    - `[Number <String>]`: 
    - `[Type <String>]`: 
  - `[PublicKey <String>]`: 
  - `[RecoveryEmailAddress <String>]`: 
  - `[Relationships <List<IBulkUserCreateRelationshipsItem>>]`: 
    - `[Type <String>]`: 
    - `[Value <String>]`: 
  - `[RestrictedField <String>]`: 
  - `[RestrictedFieldId <String>]`: 
  - `[RestrictedFieldType <String>]`: 
  - `[SambaServiceUser <Boolean?>]`: 
  - `[State <String>]`: 
  - `[Sudo <Boolean?>]`: 
  - `[Suspended <Boolean?>]`: 
  - `[UnixGuid <Int32?>]`: 
  - `[UnixUid <Int32?>]`: 
  - `[Username <String>]`: 

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

