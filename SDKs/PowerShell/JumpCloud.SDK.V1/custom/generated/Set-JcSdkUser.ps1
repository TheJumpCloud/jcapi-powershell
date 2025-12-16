<#
.Synopsis
This endpoint allows you to set a system user.

#### Sample Request

```
curl -X PUT https://console.jumpcloud.com/api/systemusers/{UserID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
\t\"email\":\"{email_address}\",
\t\"firstname\":\"{Name}\",
\t\"lastname\":\"{Name}\"
}'
```
.Description
This endpoint allows you to set a system user.

#### Sample Request

```
curl -X PUT https://console.jumpcloud.com/api/systemusers/{UserID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
\t\"email\":\"{email_address}\",
\t\"firstname\":\"{Name}\",
\t\"lastname\":\"{Name}\"
}'
```
.Example
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


.Example
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



.Inputs
JumpCloud.SDK.V1.Models.IJumpCloudApiIdentity
.Inputs
JumpCloud.SDK.V1.Models.ISystemuserput
.Outputs
JumpCloud.SDK.V1.Models.ISystemuserreturn
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

ADDRESSES <ISystemuserputAddressesItem[]>:
  [Country <String>]:
  [ExtendedAddress <String>]:
  [Locality <String>]:
  [PoBox <String>]:
  [PostalCode <String>]:
  [Region <String>]:
  [StreetAddress <String>]:
  [Type <String>]:

ATTRIBUTES <ISystemuserputAttributesItem[]>:
  [Name <String>]:
  [Value <String>]:

BODY <ISystemuserput>:
  [AccountLocked <Boolean?>]:
  [Addresses <List<ISystemuserputAddressesItem>>]: type, poBox, extendedAddress, streetAddress, locality, region, postalCode, country
    [Country <String>]:
    [ExtendedAddress <String>]:
    [Locality <String>]:
    [PoBox <String>]:
    [PostalCode <String>]:
    [Region <String>]:
    [StreetAddress <String>]:
    [Type <String>]:
  [AllowPublicKey <Boolean?>]:
  [AlternateEmail <String>]:
  [Attributes <List<ISystemuserputAttributesItem>>]:
    [Name <String>]:
    [Value <String>]:
  [Company <String>]:
  [CostCenter <String>]:
  [DelegatedAuthorityId <String>]: ObjectId of the target Active Directory connection
  [DelegatedAuthorityName <String>]: Authority name
  [Department <String>]:
  [Description <String>]:
  [DisableDeviceMaxLoginAttempts <Boolean?>]:
  [Displayname <String>]:
  [Email <String>]:
  [EmployeeIdentifier <String>]: Must be unique per user.
  [EmployeeType <String>]:
  [EnableManagedUid <Boolean?>]:
  [EnableUserPortalMultifactor <Boolean?>]:
  [ExternalDn <String>]:
  [ExternalPasswordExpirationDate <String>]:
  [ExternalSourceType <String>]:
  [ExternallyManaged <Boolean?>]: The externally_managed property has been deprecated. Whenever a user has their externally_managed field modified their restrictedFields property gets populated with the appropriate value, even if it is already set to a value an administrator manually set.
  [Firstname <String>]:
  [JobTitle <String>]:
  [Lastname <String>]:
  [LdapBindingUser <Boolean?>]:
  [Location <String>]:
  [ManagedAppleId <String>]:
  [Manager <String>]: Relation with another systemuser to identify the last as a manager.
  [MfaConfigured <Boolean?>]:
  [MfaExclusion <Boolean?>]:
  [MfaExclusionDays <Int32?>]:
  [MfaExclusionUntil <DateTime?>]:
  [Middlename <String>]:
  [Password <String>]:
  [PasswordNeverExpires <Boolean?>]:
  [PhoneNumbers <List<ISystemuserputPhoneNumbersItem>>]:
    [Number <String>]:
    [Type <String>]:
  [PublicKey <String>]:
  [Relationships <List<ISystemuserputRelationshipsItem>>]:
    [Type <String>]:
    [Value <String>]:
  [RestrictedFields <List<IRestrictedField1>>]:
    [Field <String>]:
    [Id <String>]:
    [Type <String>]:
  [SambaServiceUser <Boolean?>]:
  [SshKeys <List<ISshkeypost>>]:
    Name <String>: The name of the SSH key.
    PublicKey <String>: The Public SSH key.
  [State <String>]:
  [Sudo <Boolean?>]:
  [Suspended <Boolean?>]:
  [UnixGuid <Int32?>]:
  [UnixUid <Int32?>]:
  [Username <String>]:

INPUTOBJECT <IJumpCloudApiIdentity>:
  [Id <String>]:
  [SystemId <String>]:
  [SystemuserId <String>]:
  [Triggername <String>]:

PHONENUMBERS <ISystemuserputPhoneNumbersItem[]>:
  [Number <String>]:
  [Type <String>]:

RELATIONSHIPS <ISystemuserputRelationshipsItem[]>:
  [Type <String>]:
  [Value <String>]:

RESTRICTEDFIELDS <IRestrictedField1[]>:
  [Field <String>]:
  [Id <String>]:
  [Type <String>]:

SSHKEYS <ISshkeypost[]>:
  Name <String>: The name of the SSH key.
  PublicKey <String>: The Public SSH key.
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V1/docs/exports/Set-JcSdkUser.md
#>
 Function Set-JcSdkUser
{
    [OutputType([JumpCloud.SDK.V1.Models.ISystemuserreturn])]
    [CmdletBinding(DefaultParameterSetName='SetExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
    [Parameter(Mandatory)]
    [JumpCloud.SDK.V1.Category('Uri')]
    [System.String]
    # Region for JumpCloud API host.
    # Use 'console' for US or 'console.eu' for EU.
    ${ConsoleHost}, 

    [Parameter(ParameterSetName='Set', Mandatory)]
    [Parameter(ParameterSetName='SetExpanded', Mandatory)]
    [JumpCloud.SDK.V1.Category('Path')]
    [System.String]
    # .
    ${Id}, 

    [Parameter(ParameterSetName='SetViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='SetViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V1.Category('Path')]
    [JumpCloud.SDK.V1.Models.IJumpCloudApiIdentity]
    # Identity Parameter
    ${InputObject}, 

    [Parameter()]
    [JumpCloud.SDK.V1.Category('Query')]
    [System.String]
    # .
    ${FullValidationDetails}, 

    [Parameter(ParameterSetName='Set', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='SetViaIdentity', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V1.Category('Body')]
    [JumpCloud.SDK.V1.Models.ISystemuserput]
    # SystemUserPut
    ${Body}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # .
    ${AccountLocked}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [AllowEmptyCollection()]
    [JumpCloud.SDK.V1.Category('Body')]
    [JumpCloud.SDK.V1.Models.ISystemuserputAddressesItem[]]
    # type, poBox, extendedAddress, streetAddress, locality, region, postalCode, country
    ${Addresses}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # .
    ${AllowPublicKey}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${AlternateEmail}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [AllowEmptyCollection()]
    [JumpCloud.SDK.V1.Category('Body')]
    [JumpCloud.SDK.V1.Models.ISystemuserputAttributesItem[]]
    # .
    ${Attributes}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${Company}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${CostCenter}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # ObjectId of the target Active Directory connection
    ${DelegatedAuthorityId}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # Authority name
    ${DelegatedAuthorityName}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${Department}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${Description}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # .
    ${DisableDeviceMaxLoginAttempts}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${Displayname}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${Email}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # Must be unique per user.
    ${EmployeeIdentifier}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${EmployeeType}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # .
    ${EnableManagedUid}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # .
    ${EnableUserPortalMultifactor}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${ExternalDn}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${ExternalPasswordExpirationDate}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${ExternalSourceType}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # The externally_managed property has been deprecated.
    # Whenever a user has their externally_managed field modified their restrictedFields property gets populated with the appropriate value, even if it is already set to a value an administrator manually set.
    ${ExternallyManaged}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${Firstname}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${JobTitle}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${Lastname}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # .
    ${LdapBindingUser}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${Location}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${ManagedAppleId}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # Relation with another systemuser to identify the last as a manager.
    ${Manager}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # .
    ${MfaConfigured}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # .
    ${MfaExclusion}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.Int32]
    # .
    ${MfaExclusionDays}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.DateTime]
    # .
    ${MfaExclusionUntil}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${Middlename}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${Password}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # .
    ${PasswordNeverExpires}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [AllowEmptyCollection()]
    [JumpCloud.SDK.V1.Category('Body')]
    [JumpCloud.SDK.V1.Models.ISystemuserputPhoneNumbersItem[]]
    # .
    ${PhoneNumbers}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${PublicKey}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [AllowEmptyCollection()]
    [JumpCloud.SDK.V1.Category('Body')]
    [JumpCloud.SDK.V1.Models.ISystemuserputRelationshipsItem[]]
    # .
    ${Relationships}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [AllowEmptyCollection()]
    [JumpCloud.SDK.V1.Category('Body')]
    [JumpCloud.SDK.V1.Models.IRestrictedField1[]]
    # .
    ${RestrictedFields}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # .
    ${SambaServiceUser}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [AllowEmptyCollection()]
    [JumpCloud.SDK.V1.Category('Body')]
    [JumpCloud.SDK.V1.Models.ISshkeypost[]]
    # .
    ${SshKeys}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${State}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # .
    ${Sudo}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # .
    ${Suspended}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.Int32]
    # .
    ${UnixGuid}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.Int32]
    # .
    ${UnixUid}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${Username}, 

    [Parameter(DontShow)]
    [JumpCloud.SDK.V1.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break}, 

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [JumpCloud.SDK.V1.Category('Runtime')]
    [JumpCloud.SDK.V1.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend}, 

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [JumpCloud.SDK.V1.Category('Runtime')]
    [JumpCloud.SDK.V1.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend}, 

    [Parameter(DontShow)]
    [JumpCloud.SDK.V1.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy}, 

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [JumpCloud.SDK.V1.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential}, 

    [Parameter(DontShow)]
    [JumpCloud.SDK.V1.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
    )
    Begin
    {
        $Results = @()
        $PSBoundParameters.Add('HttpPipelineAppend', {
                param($req, $callback, $next)
                # call the next step in the Pipeline
                $ResponseTask = $next.SendAsync($req, $callback)
                $global:JCHttpRequest = $req
                # $global:JCHttpRequestContent = If (-not [System.String]::IsNullOrEmpty($req.Content)) { $req.Content.ReadAsStringAsync() }
                $global:JCHttpResponse = $ResponseTask
                # $global:JCHttpResponseContent = If (-not [System.String]::IsNullOrEmpty($ResponseTask.Result.Content)) { $ResponseTask.Result.Content.ReadAsStringAsync() }
                Return $ResponseTask
            }
        )
    }
    Process
    {
        $maxRetries = 4
        $resultCounter = 0
        :retryLoop do {
            $resultCounter++
            $Results = JumpCloud.SDK.V1.internal\Set-JcSdkInternalUser @PSBoundParameters -errorAction SilentlyContinue -errorVariable sdkError
            If ($sdkError){
                If ($resultCounter -eq $maxRetries){
                    throw $sdkError
                }
                If ($JCHttpResponse.Result.StatusCode -eq "503") {
                    Write-Warning ("503: Service Unavailable - retrying in " + ($resultCounter * 5) + " seconds.")
                } else {
                    throw $sdkError
                }
            } else {
                break retryLoop
            }
            Start-Sleep -Seconds ($resultCounter * 5)
        } while ($resultCounter -lt $maxRetries)
    }
    End
    {
        Write-Debug ('HttpRequest: ' + $JCHttpRequest);
        # Write-Debug ('HttpRequestContent: ' + $JCHttpRequestContent.Result);
        Write-Debug ('HttpResponse: ' + $JCHttpResponse.Result);
        # Write-Debug ('HttpResponseContent: ' + $JCHttpResponseContent.Result);
        # Clean up global variables
        $GlobalVars = @('JCHttpRequest', 'JCHttpRequestContent', 'JCHttpResponse', 'JCHttpResponseContent')
        $GlobalVars | ForEach-Object {
            If ((Get-Variable -Scope:('Global')).Where( { $_.Name -eq $_ })) {
                Remove-Variable -Name:($_) -Scope:('Global')
            }
        }
        Return $Results
    }
}


