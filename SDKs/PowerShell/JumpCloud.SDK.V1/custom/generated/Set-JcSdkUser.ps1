<#
.Synopsis
This endpoint allows you to update a system user.

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
This endpoint allows you to update a system user.

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
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

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
  [Addresses <ISystemuserputAddressesItem[]>]: type, poBox, extendedAddress, streetAddress, locality, region, postalCode, country
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
  [Attributes <ISystemuserputAttributesItem[]>]:
    [Name <String>]:
    [Value <String>]:
  [Company <String>]:
  [CostCenter <String>]:
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
  [PhoneNumbers <ISystemuserputPhoneNumbersItem[]>]:
    [Number <String>]:
    [Type <String>]:
  [PublicKey <String>]:
  [Relationships <ISystemuserputRelationshipsItem[]>]:
    [Type <String>]:
    [Value <String>]:
  [SambaServiceUser <Boolean?>]:
  [SshKeys <ISshkeypost[]>]:
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
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
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
    # To construct, see NOTES section for BODY properties and create a hash table.
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
    # To construct, see NOTES section for ADDRESSES properties and create a hash table.
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
    # To construct, see NOTES section for ATTRIBUTES properties and create a hash table.
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
    # To construct, see NOTES section for PHONENUMBERS properties and create a hash table.
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
    # To construct, see NOTES section for RELATIONSHIPS properties and create a hash table.
    ${Relationships}, 

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
    # To construct, see NOTES section for SSHKEYS properties and create a hash table.
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
            try {
                $Results = JumpCloud.SDK.V1.internal\Set-JcSdkInternalUser @PSBoundParameters -ErrorAction Stop
                break retryLoop
            } catch {
                If (($JCHttpResponse.Result.StatusCode -ne 503) -or ($resultCounter -eq $maxRetries)) {
                    throw $_
                } else {
                    Write-Warning ("An error occurred: $_.")
                    Write-Warning ("503: Service Unavailable - retrying in " + ($resultCounter * 5) + " seconds.")
                }
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


