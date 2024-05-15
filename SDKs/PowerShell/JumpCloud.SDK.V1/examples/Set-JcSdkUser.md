### Example 1: Set an User by Id, and Body
```powershell
PS C:\> Set-JcSdkUser -Id:(<string>) -Body:(<JumpCloud.SDK.V1.Models.Systemuserput>)



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


```

This function will Set an User by Id Body. Id, and Body are required parameters.

### Example 2: Set an User by Id
```powershell
PS C:\> Set-JcSdkUser -Id:(<string>) -AccountLocked:(<switch>) -Addresses:(<JumpCloud.SDK.V1.Models.SystemuserputAddressesItem[]>) -AllowPublicKey:(<switch>) -AlternateEmail:(<string>) -Attributes:(<JumpCloud.SDK.V1.Models.SystemuserputAttributesItem[]>) -Company:(<string>) -CostCenter:(<string>) -Department:(<string>) -Description:(<string>) -DisableDeviceMaxLoginAttempts:(<switch>) -Displayname:(<string>) -Email:(<string>) -EmployeeIdentifier:(<string>) -EmployeeType:(<string>) -EnableManagedUid:(<switch>) -EnableUserPortalMultifactor:(<switch>) -ExternalDn:(<string>) -ExternalPasswordExpirationDate:(<string>) -ExternalSourceType:(<string>) -ExternallyManaged:(<switch>) -Firstname:(<string>) -JobTitle:(<string>) -Lastname:(<string>) -LdapBindingUser:(<switch>) -Location:(<string>) -ManagedAppleId:(<string>) -Manager:(<string>) -MfaConfigured:(<switch>) -MfaExclusion:(<switch>) -MfaExclusionDays:(<int>) -MfaExclusionUntil:(<datetime>) -Middlename:(<string>) -Password:(<string>) -PasswordNeverExpires:(<switch>) -PhoneNumbers:(<JumpCloud.SDK.V1.Models.SystemuserputPhoneNumbersItem[]>) -PublicKey:(<string>) -Relationships:(<JumpCloud.SDK.V1.Models.SystemuserputRelationshipsItem[]>) -RestrictedFields:(<JumpCloud.SDK.V1.Models.RestrictedField1[]>) -SambaServiceUser:(<switch>) -SshKeys:(<JumpCloud.SDK.V1.Models.Sshkeypost[]>) -State:(<string>) -Sudo:(<switch>) -Suspended:(<switch>) -UnixGuid:(<int>) -UnixUid:(<int>) -Username:(<string>)



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


```

This function will Set an User by Id. Id is a required parameter.

