<#
.Synopsis
This endpoint allows you to update a policy.
Given the amount of configurable parameters required to update a Policy, we suggest you use the JumpCloud Admin Console to create new policies.


##### Sample Request
```
curl -X PUT https://console.jumpcloud.com/api/v2/policies/59fced45c9118022172547ff \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    {Policy_Parameters}
  }'
```
.Description
This endpoint allows you to update a policy.
Given the amount of configurable parameters required to update a Policy, we suggest you use the JumpCloud Admin Console to create new policies.


##### Sample Request
```
curl -X PUT https://console.jumpcloud.com/api/v2/policies/59fced45c9118022172547ff \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    {Policy_Parameters}
  }'
```
.Example
PS C:\> Set-JcSdkPolicy -Id:(<string>) -Body:(<JumpCloud.SDK.V2.Models.PolicyUpdateRequest>)



----                   ----------
Id                     String
Name                   String
TemplateActivation     String
TemplateAlert          String
TemplateBehavior       String
TemplateDeliveryTypes  String
TemplateDescription    String
TemplateDisplayName    String
TemplateId             String
TemplateName           String
TemplateOSMetaFamily   String
TemplateOSRestrictions JumpCloud.SDK.V2.Models.OSRestriction[]
TemplateReference      String
TemplateState          String


.Example
PS C:\> Set-JcSdkPolicy -Id:(<string>) -Name:(<string>) -Notes:(<string>) -Values:(<JumpCloud.SDK.V2.Models.PolicyValue[]>)



----                   ----------
Id                     String
Name                   String
TemplateActivation     String
TemplateAlert          String
TemplateBehavior       String
TemplateDeliveryTypes  String
TemplateDescription    String
TemplateDisplayName    String
TemplateId             String
TemplateName           String
TemplateOSMetaFamily   String
TemplateOSRestrictions JumpCloud.SDK.V2.Models.OSRestriction[]
TemplateReference      String
TemplateState          String



.Inputs
JumpCloud.SDK.V2.Models.IJumpCloudApiIdentity
.Inputs
JumpCloud.SDK.V2.Models.IPolicyUpdateRequest
.Outputs
JumpCloud.SDK.V2.Models.IPolicy
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IPolicyUpdateRequest>:
  Name <String>: The description for this specific Policy.
  [Notes <String>]: The notes for this specific Policy.
  [Values <IPolicyValue[]>]:
    [ConfigFieldId <String>]: The ObjectId of the corresponding Policy Template configuration field.
    [Sensitive <Boolean?>]: Defines if the value is sensitive or not.
    [Value <String>]: The value for the configuration field for this Policy instance.

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

VALUES <IPolicyValue[]>:
  [ConfigFieldId <String>]: The ObjectId of the corresponding Policy Template configuration field.
  [Sensitive <Boolean?>]: Defines if the value is sensitive or not.
  [Value <String>]: The value for the configuration field for this Policy instance.
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Set-JcSdkPolicy.md
#>
 Function Set-JcSdkPolicy
{
    [OutputType([JumpCloud.SDK.V2.Models.IPolicy])]
    [CmdletBinding(DefaultParameterSetName='SetExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
    [Parameter(ParameterSetName='Set', Mandatory)]
    [Parameter(ParameterSetName='SetExpanded', Mandatory)]
    [JumpCloud.SDK.V2.Category('Path')]
    [System.String]
    # ObjectID of the Policy object.
    ${Id}, 

    [Parameter(ParameterSetName='SetViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='SetViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V2.Category('Path')]
    [JumpCloud.SDK.V2.Models.IJumpCloudApiIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject}, 

    [Parameter(ParameterSetName='Set', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='SetViaIdentity', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V2.Category('Body')]
    [JumpCloud.SDK.V2.Models.IPolicyUpdateRequest]
    # A request to update an instance of a policy template.
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body}, 

    [Parameter(ParameterSetName='SetExpanded', Mandatory)]
    [Parameter(ParameterSetName='SetViaIdentityExpanded', Mandatory)]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # The description for this specific Policy.
    ${Name}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # The notes for this specific Policy.
    ${Notes}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [AllowEmptyCollection()]
    [JumpCloud.SDK.V2.Category('Body')]
    [JumpCloud.SDK.V2.Models.IPolicyValue[]]
    # .
    # To construct, see NOTES section for VALUES properties and create a hash table.
    ${Values}, 

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
            $Results = JumpCloud.SDK.V2.internal\Set-JcSdkInternalPolicy @PSBoundParameters -errorAction SilentlyContinue -errorVariable sdkError
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


