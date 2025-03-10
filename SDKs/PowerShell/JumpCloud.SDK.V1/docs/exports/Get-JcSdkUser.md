---
external help file:
Module Name: JumpCloud.SDK.V1
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V1/docs/exports/Get-JcSdkUser.md
schema: 2.0.0
---

# Get-JcSdkUser

## SYNOPSIS
This endpoint returns a particular System User.

#### Sample Request

```
curl -X GET https://console.jumpcloud.com/api/systemusers/{UserID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

## SYNTAX

### List (Default)
```
Get-JcSdkUser [-Fields <String>] [-Filter <String[]>] [-Search <String>] [-Sort <String>] [<CommonParameters>]
```

### Get
```
Get-JcSdkUser -Id <String> [-Fields <String>] [-Filter <String[]>] [<CommonParameters>]
```

### GetViaIdentity
```
Get-JcSdkUser -InputObject <IJumpCloudApiIdentity> [-Fields <String>] [-Filter <String[]>]
 [<CommonParameters>]
```

## DESCRIPTION
This endpoint returns a particular System User.

#### Sample Request

```
curl -X GET https://console.jumpcloud.com/api/systemusers/{UserID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Get-JcSdkUser -Search:(<string>) -Sort:(<string>)
```

----                           ----------
AccountLocked                  Boolean
AccountLockedDate              String
Activated                      Boolean
Addresses                      JumpCloud.SDK.V1.Models.SystemuserreturnAddressesItem[]
AllowPublicKey                 Boolean
AlternateEmail                 String
Attributes                     JumpCloud.SDK.V1.Models.SystemuserreturnAttributesItem[]
BadLoginAttempts               Int
Company                        String
CostCenter                     String
Created                        String
CreationSource                 String
Department                     String
Description                    String
DisableDeviceMaxLoginAttempts  Boolean
Displayname                    String
Email                          String
EmployeeIdentifier             String
EmployeeType                   String
EnableManagedUid               Boolean
EnableUserPortalMultifactor    Boolean
ExternalDn                     String
ExternallyManaged              Boolean
ExternalPasswordExpirationDate String
ExternalSourceType             String
Firstname                      String
Id                             String
JobTitle                       String
Lastname                       String
LdapBindingUser                Boolean
Location                       String
ManagedAppleId                 String
Manager                        String
MfaConfigured                  Boolean
MfaEnrollmentOverallStatus     String
MfaEnrollmentPushStatus        String
MfaEnrollmentTotpStatus        String
MfaEnrollmentWebAuthnStatus    String
MfaExclusion                   Boolean
MfaExclusionDays               Int
MfaExclusionUntil              Datetime
Middlename                     String
Organization                   String
PasswordDate                   String
PasswordExpirationDate         String
PasswordExpired                Boolean
PasswordlessSudo               Boolean
PasswordNeverExpires           Boolean
PhoneNumbers                   JumpCloud.SDK.V1.Models.SystemuserreturnPhoneNumbersItem[]
PublicKey                      String
RecoveryEmailAddress           String
RecoveryEmailVerified          Boolean
RecoveryEmailVerifiedAt        String
Relationships                  JumpCloud.SDK.V1.Models.SystemuserreturnRelationshipsItem[]
RestrictedFields               JumpCloud.SDK.V1.Models.RestrictedField1[]
SambaServiceUser               Boolean
SshKeys                        JumpCloud.SDK.V1.Models.Sshkeylist[]
State                          String
Sudo                           Boolean
Suspended                      Boolean
TotpEnabled                    Boolean
UnixGuid                       Int
UnixUid                        Int
Username                       String

### -------------------------- EXAMPLE 2 --------------------------
```powershell
Get-JcSdkUser -Id:(<string>)
```

----                           ----------
AccountLocked                  Boolean
AccountLockedDate              String
Activated                      Boolean
Addresses                      JumpCloud.SDK.V1.Models.SystemuserreturnAddressesItem[]
AllowPublicKey                 Boolean
AlternateEmail                 String
Attributes                     JumpCloud.SDK.V1.Models.SystemuserreturnAttributesItem[]
BadLoginAttempts               Int
Company                        String
CostCenter                     String
Created                        String
CreationSource                 String
Department                     String
Description                    String
DisableDeviceMaxLoginAttempts  Boolean
Displayname                    String
Email                          String
EmployeeIdentifier             String
EmployeeType                   String
EnableManagedUid               Boolean
EnableUserPortalMultifactor    Boolean
ExternalDn                     String
ExternallyManaged              Boolean
ExternalPasswordExpirationDate String
ExternalSourceType             String
Firstname                      String
Id                             String
JobTitle                       String
Lastname                       String
LdapBindingUser                Boolean
Location                       String
ManagedAppleId                 String
Manager                        String
MfaConfigured                  Boolean
MfaEnrollmentOverallStatus     String
MfaEnrollmentPushStatus        String
MfaEnrollmentTotpStatus        String
MfaEnrollmentWebAuthnStatus    String
MfaExclusion                   Boolean
MfaExclusionDays               Int
MfaExclusionUntil              Datetime
Middlename                     String
Organization                   String
PasswordDate                   String
PasswordExpirationDate         String
PasswordExpired                Boolean
PasswordlessSudo               Boolean
PasswordNeverExpires           Boolean
PhoneNumbers                   JumpCloud.SDK.V1.Models.SystemuserreturnPhoneNumbersItem[]
PublicKey                      String
RecoveryEmailAddress           String
RecoveryEmailVerified          Boolean
RecoveryEmailVerifiedAt        String
Relationships                  JumpCloud.SDK.V1.Models.SystemuserreturnRelationshipsItem[]
RestrictedFields               JumpCloud.SDK.V1.Models.RestrictedField1[]
SambaServiceUser               Boolean
SshKeys                        JumpCloud.SDK.V1.Models.Sshkeylist[]
State                          String
Sudo                           Boolean
Suspended                      Boolean
TotpEnabled                    Boolean
UnixGuid                       Int
UnixUid                        Int
Username                       String

## PARAMETERS

### -Fields
Use a space seperated string of field parameters to include the data in the response.
If omitted, the default list of fields will be returned.

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

### -Filter
A filter to apply to the query.
Populate with a valid field from an endpoint response.

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
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

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: JumpCloud.SDK.V1.Models.IJumpCloudApiIdentity
Parameter Sets: GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Search
A nested object containing a `searchTerm` string or array of strings and a list of `fields` to search on.

```yaml
Type: System.String
Parameter Sets: List
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Sort
The space separated fields used to sort the collection.
Default sort is ascending, prefix with `-` to sort descending.

```yaml
Type: System.String
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

### JumpCloud.SDK.V1.Models.IJumpCloudApiIdentity

## OUTPUTS

### JumpCloud.SDK.V1.Models.ISystemuserreturn

### JumpCloud.SDK.V1.Models.ISystemuserslist

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


INPUTOBJECT <IJumpCloudApiIdentity>: Identity Parameter
  - `[Id <String>]`: 
  - `[SystemId <String>]`: 
  - `[SystemuserId <String>]`: 
  - `[Triggername <String>]`: 

## RELATED LINKS

