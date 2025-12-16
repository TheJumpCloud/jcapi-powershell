<#
.Synopsis
\"This endpoint allows you to create a new system user.

#### Default User State
The `state` of the user can be explicitly passed in or omitted.
If
`state` is omitted from the request, then the user will get created
using the value returned from the
[Get an Organization](https://docs.jumpcloud.com/api/1.0/index.html#operation/organizations_get)
endpoint.
The default user state for manually created users is stored in
`settings.newSystemUserStateDefaults.manualEntry`

These default state values can be changed in the admin portal settings
or by using the
[create an Organization](https://docs.jumpcloud.com/api/1.0/index.html#operation/organization_put)
endpoint.

#### Sample Request

```
curl -X POST https://console.jumpcloud.com/api/systemusers \\
-H 'Accept: application/json' \\
-H 'Content-Type: application/json' \\
-H 'x-api-key: {API_KEY}' \\
-d '{
      \"username\":\"{username}\",
      \"email\":\"{email_address}\",
      \"firstname\":\"{Name}\",
      \"lastname\":\"{Name}\"
    }'
```
.Description
\"This endpoint allows you to create a new system user.

#### Default User State
The `state` of the user can be explicitly passed in or omitted.
If
`state` is omitted from the request, then the user will get created
using the value returned from the
[Get an Organization](https://docs.jumpcloud.com/api/1.0/index.html#operation/organizations_get)
endpoint.
The default user state for manually created users is stored in
`settings.newSystemUserStateDefaults.manualEntry`

These default state values can be changed in the admin portal settings
or by using the
[create an Organization](https://docs.jumpcloud.com/api/1.0/index.html#operation/organization_put)
endpoint.

#### Sample Request

```
curl -X POST https://console.jumpcloud.com/api/systemusers \\
-H 'Accept: application/json' \\
-H 'Content-Type: application/json' \\
-H 'x-api-key: {API_KEY}' \\
-d '{
      \"username\":\"{username}\",
      \"email\":\"{email_address}\",
      \"firstname\":\"{Name}\",
      \"lastname\":\"{Name}\"
    }'
```
.Example
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


.Example
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



.Inputs
JumpCloud.SDK.V1.Models.ISystemuserputpost
.Outputs
JumpCloud.SDK.V1.Models.ISystemuserreturn
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

ADDRESSES <ISystemuserputpostAddressesItem[]>:
  [Country <String>]:
  [ExtendedAddress <String>]:
  [Locality <String>]:
  [PoBox <String>]:
  [PostalCode <String>]:
  [Region <String>]:
  [StreetAddress <String>]:
  [Type <String>]:

ATTRIBUTES <ISystemuserputpostAttributesItem[]>:
  [Name <String>]:
  [Value <String>]:

BODY <ISystemuserputpost>:
  Email <String>:
  Username <String>:
  [AccountLocked <Boolean?>]:
  [Activated <Boolean?>]:
  [Addresses <List<ISystemuserputpostAddressesItem>>]:
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
  [Attributes <List<ISystemuserputpostAttributesItem>>]:
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
  [EmployeeIdentifier <String>]: Must be unique per user.
  [EmployeeType <String>]:
  [EnableManagedUid <Boolean?>]:
  [EnableUserPortalMultifactor <Boolean?>]:
  [ExternalDn <String>]:
  [ExternalPasswordExpirationDate <DateTime?>]:
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
  [PasswordlessSudo <Boolean?>]:
  [PhoneNumbers <List<ISystemuserputpostPhoneNumbersItem>>]:
    [Number <String>]:
    [Type <String>]:
  [PublicKey <String>]:
  [RecoveryEmailAddress <String>]:
  [Relationships <List<ISystemuserputpostRelationshipsItem>>]:
    [Type <String>]:
    [Value <String>]:
  [RestrictedFields <List<IRestrictedField1>>]:
    [Field <String>]:
    [Id <String>]:
    [Type <String>]:
  [SambaServiceUser <Boolean?>]:
  [State <String>]:
  [Sudo <Boolean?>]:
  [Suspended <Boolean?>]:
  [UnixGuid <Int32?>]:
  [UnixUid <Int32?>]:

PHONENUMBERS <ISystemuserputpostPhoneNumbersItem[]>:
  [Number <String>]:
  [Type <String>]:

RELATIONSHIPS <ISystemuserputpostRelationshipsItem[]>:
  [Type <String>]:
  [Value <String>]:

RESTRICTEDFIELDS <IRestrictedField1[]>:
  [Field <String>]:
  [Id <String>]:
  [Type <String>]:
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V1/docs/exports/New-JcSdkUser.md
#>
 Function New-JcSdkUser
{
    [OutputType([JumpCloud.SDK.V1.Models.ISystemuserreturn])]
    [CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
    [Parameter(Mandatory)]
    [JumpCloud.SDK.V1.Category('Uri')]
    [System.String]
    # Region for JumpCloud API host.
    # Use 'console' for US or 'console.eu' for EU.
    ${ConsoleHost}, 

    [Parameter()]
    [JumpCloud.SDK.V1.Category('Query')]
    [System.String]
    # .
    ${FullValidationDetails}, 

    [Parameter(ParameterSetName='Create', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V1.Category('Body')]
    [JumpCloud.SDK.V1.Models.ISystemuserputpost]
    # SystemUserPost
    ${Body}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # .
    ${AccountLocked}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # .
    ${Activated}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [AllowEmptyCollection()]
    [JumpCloud.SDK.V1.Category('Body')]
    [JumpCloud.SDK.V1.Models.ISystemuserputpostAddressesItem[]]
    # .
    ${Addresses}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # .
    ${AllowPublicKey}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${AlternateEmail}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [AllowEmptyCollection()]
    [JumpCloud.SDK.V1.Category('Body')]
    [JumpCloud.SDK.V1.Models.ISystemuserputpostAttributesItem[]]
    # .
    ${Attributes}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${Company}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${CostCenter}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # ObjectId of the target Active Directory connection
    ${DelegatedAuthorityId}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # Authority name
    ${DelegatedAuthorityName}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${Department}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${Description}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # .
    ${DisableDeviceMaxLoginAttempts}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${Displayname}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${Email}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # Must be unique per user.
    ${EmployeeIdentifier}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${EmployeeType}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # .
    ${EnableManagedUid}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # .
    ${EnableUserPortalMultifactor}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${ExternalDn}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.DateTime]
    # .
    ${ExternalPasswordExpirationDate}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${ExternalSourceType}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # The externally_managed property has been deprecated.
    # Whenever a user has their externally_managed field modified their restrictedFields property gets populated with the appropriate value, even if it is already set to a value an administrator manually set.
    ${ExternallyManaged}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${Firstname}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${JobTitle}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${Lastname}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # .
    ${LdapBindingUser}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${Location}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${ManagedAppleId}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # Relation with another systemuser to identify the last as a manager.
    ${Manager}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # .
    ${MfaConfigured}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # .
    ${MfaExclusion}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.Int32]
    # .
    ${MfaExclusionDays}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.DateTime]
    # .
    ${MfaExclusionUntil}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${Middlename}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${Password}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # .
    ${PasswordNeverExpires}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # .
    ${PasswordlessSudo}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [AllowEmptyCollection()]
    [JumpCloud.SDK.V1.Category('Body')]
    [JumpCloud.SDK.V1.Models.ISystemuserputpostPhoneNumbersItem[]]
    # .
    ${PhoneNumbers}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${PublicKey}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${RecoveryEmailAddress}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [AllowEmptyCollection()]
    [JumpCloud.SDK.V1.Category('Body')]
    [JumpCloud.SDK.V1.Models.ISystemuserputpostRelationshipsItem[]]
    # .
    ${Relationships}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [AllowEmptyCollection()]
    [JumpCloud.SDK.V1.Category('Body')]
    [JumpCloud.SDK.V1.Models.IRestrictedField1[]]
    # .
    ${RestrictedFields}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # .
    ${SambaServiceUser}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${State}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # .
    ${Sudo}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # .
    ${Suspended}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.Int32]
    # .
    ${UnixGuid}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.Int32]
    # .
    ${UnixUid}, 

    [Parameter(ParameterSetName='CreateExpanded')]
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
            $Results = JumpCloud.SDK.V1.internal\New-JcSdkInternalUser @PSBoundParameters -errorAction SilentlyContinue -errorVariable sdkError
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


