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
[Update an Organization](https://docs.jumpcloud.com/api/1.0/index.html#operation/organization_put)
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
[Update an Organization](https://docs.jumpcloud.com/api/1.0/index.html#operation/organization_put)
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
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

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
  [Addresses <ISystemuserputpostAddressesItem[]>]:
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
  [Attributes <ISystemuserputpostAttributesItem[]>]:
    [Name <String>]:
    [Value <String>]:
  [Company <String>]:
  [CostCenter <String>]:
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
  [PhoneNumbers <ISystemuserputpostPhoneNumbersItem[]>]:
    [Number <String>]:
    [Type <String>]:
  [PublicKey <String>]:
  [RecoveryEmailAddress <String>]:
  [Relationships <ISystemuserputpostRelationshipsItem[]>]:
    [Type <String>]:
    [Value <String>]:
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
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V1/docs/exports/New-JcSdkUser.md
#>
 Function New-JcSdkUser
{
    [OutputType([JumpCloud.SDK.V1.Models.ISystemuserreturn])]
    [CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
    [Parameter()]
    [JumpCloud.SDK.V1.Category('Query')]
    [System.String]
    # .
    ${FullValidationDetails}, 

    [Parameter(ParameterSetName='Create', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V1.Category('Body')]
    [JumpCloud.SDK.V1.Models.ISystemuserputpost]
    # SystemUserPost
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body}, 

    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${Email}, 

    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${Username}, 

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
    # To construct, see NOTES section for ADDRESSES properties and create a hash table.
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
    # To construct, see NOTES section for ATTRIBUTES properties and create a hash table.
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
    # To construct, see NOTES section for PHONENUMBERS properties and create a hash table.
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
    # To construct, see NOTES section for RELATIONSHIPS properties and create a hash table.
    ${Relationships}, 

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
                $Results = JumpCloud.SDK.V1.internal\New-JcSdkInternalUser @PSBoundParameters -errorAction SilentlyContinue
                break retryLoop
            } catch {
                If ($JCHttpResponse.Result.StatusCode -eq 503) {
                    Write-Warning ("503: Service Unavailable - retrying in " + ($resultCounter * 5) + " seconds.")
                } else {
                    Write-Warning ("An error occurred: $_.")
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


