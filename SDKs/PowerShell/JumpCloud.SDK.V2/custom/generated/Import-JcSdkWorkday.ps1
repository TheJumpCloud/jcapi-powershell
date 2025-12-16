<#
.Synopsis
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
.Description
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
.Example
PS C:\> Import-JcSdkWorkday -WorkdayId:(<string>)


.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
JumpCloud.SDK.V2.Models.IJumpCloudApiIdentity
.Inputs
System.Collections.Generic.List`1[[JumpCloud.SDK.V2.Models.IBulkUserCreate, JumpCloud.SDK.V2.private, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]
.Outputs
JumpCloud.SDK.V2.Models.IJobIdResult
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <List<IBulkUserCreate>>:
  [AccountLocked <Boolean?>]:
  [Activated <Boolean?>]:
  [Addresses <List<IBulkUserCreateAddressesItem>>]:
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
  [Attributes <List<IBulkUserCreateAttributesItem>>]:
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
  [ExternalPasswordExpirationDate <DateTime?>]:
  [ExternalSourceType <String>]:
  [ExternallyManaged <Boolean?>]:
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
  [PhoneNumbers <List<IBulkUserCreatePhoneNumbersItem>>]:
    [Number <String>]:
    [Type <String>]:
  [PublicKey <String>]:
  [RecoveryEmailAddress <String>]:
  [Relationships <List<IBulkUserCreateRelationshipsItem>>]:
    [Type <String>]:
    [Value <String>]:
  [RestrictedField <String>]:
  [RestrictedFieldId <String>]:
  [RestrictedFieldType <String>]:
  [SambaServiceUser <Boolean?>]:
  [State <String>]:
  [Sudo <Boolean?>]:
  [Suspended <Boolean?>]:
  [UnixGuid <Int32?>]:
  [UnixUid <Int32?>]:
  [Username <String>]:

INPUTOBJECT <IJumpCloudApiIdentity>:
  [AccountId <String>]:
  [ActivedirectoryId <String>]:
  [AdministratorId <String>]:
  [AgentId <String>]:
  [AppleMdmId <String>]:
  [ApplicationId <String>]: ObjectID of the Application.
  [CommandId <String>]: ObjectID of the Command.
  [CustomEmailType <String>]:
  [DeviceId <String>]:
  [GroupId <String>]: ObjectID of the Policy Group.
  [GsuiteId <String>]: ObjectID of the G Suite instance.
  [Id <String>]: ObjectID of this Active Directory instance.
  [JobId <String>]:
  [LdapserverId <String>]: ObjectID of the LDAP Server.
  [Office365Id <String>]: ObjectID of the Office 365 instance.
  [PolicyId <String>]: ObjectID of the Policy.
  [ProviderId <String>]:
  [PushEndpointId <String>]:
  [RadiusserverId <String>]: ObjectID of the Radius Server.
  [SoftwareAppId <String>]: ObjectID of the Software App.
  [SystemId <String>]: ObjectID of the System.
  [UserId <String>]: ObjectID of the User.
  [WorkdayId <String>]:
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Import-JcSdkWorkday.md
#>
 Function Import-JcSdkWorkday
{
    [OutputType([JumpCloud.SDK.V2.Models.IJobIdResult])]
    [CmdletBinding(DefaultParameterSetName='Import', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
    [Parameter(Mandatory)]
    [JumpCloud.SDK.V2.Category('Uri')]
    [System.String]
    # Region for JumpCloud API host.
    # Use 'console' for US or 'console.eu' for EU.
    ${ConsoleHost}, 

    [Parameter(ParameterSetName='Import', Mandatory)]
    [JumpCloud.SDK.V2.Category('Path')]
    [System.String]
    # .
    ${WorkdayId}, 

    [Parameter(ParameterSetName='ImportViaIdentity', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V2.Category('Path')]
    [JumpCloud.SDK.V2.Models.IJumpCloudApiIdentity]
    # Identity Parameter
    ${InputObject}, 

    [Parameter(Mandatory, ValueFromPipeline)]
    [AllowEmptyCollection()]
    [JumpCloud.SDK.V2.Category('Body')]
    [JumpCloud.SDK.V2.Runtime.Info(Required, PossibleTypes=([JumpCloud.SDK.V2.Models.IBulkUserCreate]))]
    [System.Collections.Generic.List[JumpCloud.SDK.V2.Models.IBulkUserCreate]]
    # Array of bulk-user-create
    ${Body}, 

    [Parameter(DontShow)]
    [JumpCloud.SDK.V2.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break}, 

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [JumpCloud.SDK.V2.Category('Runtime')]
    [JumpCloud.SDK.V2.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend}, 

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [JumpCloud.SDK.V2.Category('Runtime')]
    [JumpCloud.SDK.V2.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend}, 

    [Parameter(DontShow)]
    [JumpCloud.SDK.V2.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy}, 

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [JumpCloud.SDK.V2.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential}, 

    [Parameter(DontShow)]
    [JumpCloud.SDK.V2.Category('Runtime')]
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
            $Results = JumpCloud.SDK.V2.internal\Import-JcSdkInternalWorkday @PSBoundParameters -errorAction SilentlyContinue -errorVariable sdkError
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


