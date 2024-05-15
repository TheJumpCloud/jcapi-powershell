### Example 1: Create an User by Email, and Username
```powershell
PS C:\> New-JcSdkUser -Email:(<string>) -Username:(<string>) -AccountLocked:(<switch>) -Activated:(<switch>) -Addresses:(<JumpCloud.SDK.V1.Models.SystemuserputpostAddressesItem[]>) -AllowPublicKey:(<switch>) -AlternateEmail:(<string>) -Attributes:(<JumpCloud.SDK.V1.Models.SystemuserputpostAttributesItem[]>) -Company:(<string>) -CostCenter:(<string>) -Department:(<string>) -Description:(<string>) -DisableDeviceMaxLoginAttempts:(<switch>) -Displayname:(<string>) -EmployeeIdentifier:(<string>) -EmployeeType:(<string>) -EnableManagedUid:(<switch>) -EnableUserPortalMultifactor:(<switch>) -ExternalDn:(<string>) -ExternalPasswordExpirationDate:(<datetime>) -ExternalSourceType:(<string>) -ExternallyManaged:(<switch>) -Firstname:(<string>) -JobTitle:(<string>) -Lastname:(<string>) -LdapBindingUser:(<switch>) -Location:(<string>) -ManagedAppleId:(<string>) -Manager:(<string>) -MfaConfigured:(<switch>) -MfaExclusion:(<switch>) -MfaExclusionDays:(<int>) -MfaExclusionUntil:(<datetime>) -Middlename:(<string>) -Password:(<string>) -PasswordNeverExpires:(<switch>) -PasswordlessSudo:(<switch>) -PhoneNumbers:(<JumpCloud.SDK.V1.Models.SystemuserputpostPhoneNumbersItem[]>) -PublicKey:(<string>) -RecoveryEmailAddress:(<string>) -Relationships:(<JumpCloud.SDK.V1.Models.SystemuserputpostRelationshipsItem[]>) -RestrictedFields:(<JumpCloud.SDK.V1.Models.RestrictedField1[]>) -SambaServiceUser:(<switch>) -State:(<string>) -Sudo:(<switch>) -Suspended:(<switch>) -UnixGuid:(<int>) -UnixUid:(<int>)



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

This function will Create an User by Email Username. Email, and Username are required parameters.

### Example 2: Create an User by Body
```powershell
PS C:\> New-JcSdkUser -Body:(<JumpCloud.SDK.V1.Models.Systemuserputpost>)



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

This function will Create an User by Body. Body is a required parameter.

