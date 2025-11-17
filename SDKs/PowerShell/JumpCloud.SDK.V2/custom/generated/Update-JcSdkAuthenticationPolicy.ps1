<#
.Synopsis
Patch the specified authentication policy.

#### Sample Request
```
curl -X PATCH https://console.jumpcloud.com/api/v2/authn/policies/{id} \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{ \"disabled\": false }'
```
.Description
Patch the specified authentication policy.

#### Sample Request
```
curl -X PATCH https://console.jumpcloud.com/api/v2/authn/policies/{id} \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{ \"disabled\": false }'
```
.Example
PS C:\> Update-JcSdkAuthenticationPolicy -Id:(<string>) -Body:(<JumpCloud.SDK.V2.Models.AuthnPolicy>)



----                        ----------
Conditions                  JumpCloud.SDK.V2.Models.AuthnPolicyConditions
Description                 String
Disabled                    Boolean
EffectAction                String
Id                          String
MfaRequired                 Boolean
Name                        String
TargetResources             JumpCloud.SDK.V2.Models.AuthnPolicyResourceTarget[]
Type                        String
UserAttributeExclusions     JumpCloud.SDK.V2.Models.AuthnPolicyUserAttributeFilter[]
UserAttributeInclusions     JumpCloud.SDK.V2.Models.AuthnPolicyUserAttributeFilter[]
UserGroupExclusions         String
UserGroupInclusions         String
UserInclusions              String
UserVerificationRequirement String


.Example
PS C:\> Update-JcSdkAuthenticationPolicy -Id:(<string>) -Conditions:(<hashtable>) -Description:(<string>) -Disabled:(<switch>) -EffectAction:(<string>) -MfaRequired:(<switch>) -Name:(<string>) -TargetResources:(<JumpCloud.SDK.V2.Models.AuthnPolicyResourceTarget[]>) -Type:(<string>) -UserAttributeExclusions:(<JumpCloud.SDK.V2.Models.AuthnPolicyUserAttributeFilter[]>) -UserAttributeInclusions:(<JumpCloud.SDK.V2.Models.AuthnPolicyUserAttributeFilter[]>) -UserGroupExclusions:(<string[]>) -UserGroupInclusions:(<string[]>) -UserInclusions:(<string[]>) -UserVerificationRequirement:(<string>)



----                        ----------
Conditions                  JumpCloud.SDK.V2.Models.AuthnPolicyConditions
Description                 String
Disabled                    Boolean
EffectAction                String
Id                          String
MfaRequired                 Boolean
Name                        String
TargetResources             JumpCloud.SDK.V2.Models.AuthnPolicyResourceTarget[]
Type                        String
UserAttributeExclusions     JumpCloud.SDK.V2.Models.AuthnPolicyUserAttributeFilter[]
UserAttributeInclusions     JumpCloud.SDK.V2.Models.AuthnPolicyUserAttributeFilter[]
UserGroupExclusions         String
UserGroupInclusions         String
UserInclusions              String
UserVerificationRequirement String



.Inputs
JumpCloud.SDK.V2.Models.IAuthnPolicy
.Inputs
JumpCloud.SDK.V2.Models.IJumpCloudApiIdentity
.Outputs
JumpCloud.SDK.V2.Models.IAuthnPolicy
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IAuthnPolicy>:
  [Conditions <IAuthnPolicyConditions>]: Dictionary of <any>
    [(Any) <Object>]: This indicates any property can be added to this object.
  [CustomErrorMessage <String>]: The custom error message to be displayed when the policy is applied.
  [CustomErrorMessageEnabled <Boolean?>]: Indicates whether the custom error message is enabled or not.
  [Description <String>]:
  [Disabled <Boolean?>]:
  [EffectAction <String>]:
  [MfaRequired <Boolean?>]:
  [Name <String>]:
  [ObligationMfaFactors <List<IAuthnPolicyObligationsMfaFactorsItem>>]:
    [Type <String>]:
  [PrimaryHelpText <String>]: The text to be displayed for the help link.
  [PrimaryHelpUrl <String>]: The URL to be opened when the help link is clicked.
  [SecondaryHelpText <String>]: The text to be displayed for the help link.
  [SecondaryHelpUrl <String>]: The URL to be opened when the help link is clicked.
  [TargetResources <List<IAuthnPolicyResourceTarget>>]:
    Type <String>:
    [Id <String>]: Object ID of the resource target. If undefined, then all resources of the given type are targeted.
  [Type <String>]: AuthnPolicyType
  [UserAttributeExclusions <List<IAuthnPolicyUserAttributeFilter>>]:
    [Field <String>]: The only field that is currently supported is ldap_binding_user
    [Operator <String>]:
    [Value <IAny>]: Can be any value - string, number, boolean, array or object.
  [UserAttributeInclusions <List<IAuthnPolicyUserAttributeFilter>>]:
  [UserGroupExclusions <List<String>>]:
  [UserGroupInclusions <List<String>>]:
  [UserInclusions <List<String>>]:
  [UserVerificationRequirement <String>]:

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

OBLIGATIONMFAFACTORS <IAuthnPolicyObligationsMfaFactorsItem[]>:
  [Type <String>]:

TARGETRESOURCES <IAuthnPolicyResourceTarget[]>:
  Type <String>:
  [Id <String>]: Object ID of the resource target. If undefined, then all resources of the given type are targeted.

USERATTRIBUTEEXCLUSIONS <IAuthnPolicyUserAttributeFilter[]>:
  [Field <String>]: The only field that is currently supported is ldap_binding_user
  [Operator <String>]:
  [Value <IAny>]: Can be any value - string, number, boolean, array or object.

USERATTRIBUTEINCLUSIONS <IAuthnPolicyUserAttributeFilter[]>:
  [Field <String>]: The only field that is currently supported is ldap_binding_user
  [Operator <String>]:
  [Value <IAny>]: Can be any value - string, number, boolean, array or object.
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Update-JcSdkAuthenticationPolicy.md
#>
 Function Update-JcSdkAuthenticationPolicy
{
    [OutputType([JumpCloud.SDK.V2.Models.IAuthnPolicy])]
    [CmdletBinding(DefaultParameterSetName='UpdateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
    [Parameter(Mandatory)]
    [JumpCloud.SDK.V2.Category('Uri')]
    [System.String]
    # Region for JumpCloud API host.
    # Use 'console' for US or 'console.eu' for EU.
    ${ConsoleHost}, 

    [Parameter(ParameterSetName='Update', Mandatory)]
    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [JumpCloud.SDK.V2.Category('Path')]
    [System.String]
    # Unique identifier of the authentication policy
    ${Id}, 

    [Parameter(ParameterSetName='UpdateViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V2.Category('Path')]
    [JumpCloud.SDK.V2.Models.IJumpCloudApiIdentity]
    # Identity Parameter
    ${InputObject}, 

    [Parameter(ParameterSetName='Update', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='UpdateViaIdentity', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V2.Category('Body')]
    [JumpCloud.SDK.V2.Models.IAuthnPolicy]
    # This represents an authentication policy.
    # See the details of each field for valid values and restrictions.
    ${Body}, 

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [JumpCloud.SDK.V2.Runtime.Info(PossibleTypes=([JumpCloud.SDK.V2.Models.IAuthnPolicyConditions]))]
    [System.Collections.Hashtable]
    # Dictionary of <any>
    ${Conditions}, 

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # The custom error message to be displayed when the policy is applied.
    ${CustomErrorMessage}, 

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Indicates whether the custom error message is enabled or not.
    ${CustomErrorMessageEnabled}, 

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # .
    ${Description}, 

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # .
    ${Disabled}, 

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # .
    ${EffectAction}, 

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # .
    ${MfaRequired}, 

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # .
    ${Name}, 

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [AllowEmptyCollection()]
    [JumpCloud.SDK.V2.Category('Body')]
    [JumpCloud.SDK.V2.Models.IAuthnPolicyObligationsMfaFactorsItem[]]
    # .
    ${ObligationMfaFactors}, 

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # The text to be displayed for the help link.
    ${PrimaryHelpText}, 

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # The URL to be opened when the help link is clicked.
    ${PrimaryHelpUrl}, 

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # The text to be displayed for the help link.
    ${SecondaryHelpText}, 

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # The URL to be opened when the help link is clicked.
    ${SecondaryHelpUrl}, 

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [AllowEmptyCollection()]
    [JumpCloud.SDK.V2.Category('Body')]
    [JumpCloud.SDK.V2.Models.IAuthnPolicyResourceTarget[]]
    # .
    ${TargetResources}, 

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # AuthnPolicyType
    ${Type}, 

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [AllowEmptyCollection()]
    [JumpCloud.SDK.V2.Category('Body')]
    [JumpCloud.SDK.V2.Models.IAuthnPolicyUserAttributeFilter[]]
    # .
    ${UserAttributeExclusions}, 

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [AllowEmptyCollection()]
    [JumpCloud.SDK.V2.Category('Body')]
    [JumpCloud.SDK.V2.Models.IAuthnPolicyUserAttributeFilter[]]
    # .
    ${UserAttributeInclusions}, 

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [AllowEmptyCollection()]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String[]]
    # .
    ${UserGroupExclusions}, 

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [AllowEmptyCollection()]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String[]]
    # .
    ${UserGroupInclusions}, 

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [AllowEmptyCollection()]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String[]]
    # .
    ${UserInclusions}, 

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # .
    ${UserVerificationRequirement}, 

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
            $Results = JumpCloud.SDK.V2.internal\Update-JcSdkInternalAuthenticationPolicy @PSBoundParameters -errorAction SilentlyContinue -errorVariable sdkError
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


