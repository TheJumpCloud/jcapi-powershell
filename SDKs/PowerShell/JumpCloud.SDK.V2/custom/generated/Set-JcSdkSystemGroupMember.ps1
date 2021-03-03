<#
.Synopsis
This endpoint allows you to manage the system members of a System Group.

#### Sample Request
```
curl -X POST https://console.jumpcloud.com/api/v2/systemgroups/{Group_ID}/members \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"op\": \"add\",
    \"type\": \"system\",
    \"id\": \"{System_ID}\"
  }'
```
.Description
This endpoint allows you to manage the system members of a System Group.

#### Sample Request
```
curl -X POST https://console.jumpcloud.com/api/v2/systemgroups/{Group_ID}/members \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"op\": \"add\",
    \"type\": \"system\",
    \"id\": \"{System_ID}\"
  }'
```
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
JumpCloud.SDK.V2.Models.IGraphOperationSystemGroupMember
.Inputs
JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity
.Outputs
System.Boolean
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IGraphOperationSystemGroupMember>:
  Id <String>: The ObjectID of graph object being added or removed as an association.
  Op <String>: How to modify the graph connection.
  [Attributes <IGraphAttributes>]: The graph attributes.
    [(Any) <Object>]: This indicates any property can be added to this object.

INPUTOBJECT <IJumpCloudApIsIdentity>:
  [AccountId <String>]:
  [ActivedirectoryId <String>]:
  [AppleMdmId <String>]:
  [ApplicationId <String>]: ObjectID of the Application.
  [CommandId <String>]: ObjectID of the Command.
  [CustomEmailType <String>]:
  [DeviceId <String>]:
  [GroupId <String>]: ObjectID of the System Group.
  [GsuiteId <String>]: ObjectID of the G Suite instance.
  [Id <String>]: ObjectID of this Active Directory instance.
  [JobId <String>]:
  [LdapserverId <String>]: ObjectID of the LDAP Server.
  [Office365Id <String>]: ObjectID of the Office 365 instance.
  [PolicyId <String>]: ObjectID of the Policy.
  [ProviderId <String>]:
  [RadiusserverId <String>]: ObjectID of the Radius Server.
  [SoftwareAppId <String>]: ObjectID of the Software App.
  [SystemId <String>]: ObjectID of the System.
  [UserId <String>]: ObjectID of the User.
  [WorkdayId <String>]:
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Set-JcSdkSystemGroupMember.md
#>
Function Set-JcSdkSystemGroupMember
{
  [OutputType([System.Boolean])]
  [CmdletBinding(DefaultParameterSetName = 'SetExpanded', PositionalBinding = $false, SupportsShouldProcess, ConfirmImpact = 'Medium')]
  Param(
    [Parameter(ParameterSetName = 'Set', Mandatory)]
    [Parameter(ParameterSetName = 'SetExpanded', Mandatory)]
    [JumpCloud.SDK.V2.Category('Path')]
    [System.String]
    # ObjectID of the System Group.
    ${GroupId},

    [Parameter(ParameterSetName = 'SetViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName = 'SetViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V2.Category('Path')]
    [JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [JumpCloud.SDK.V2.Category('Header')]
    [System.String]
    # Authorization header for the System Context API
    ${Authorization},

    [Parameter()]
    [JumpCloud.SDK.V2.Category('Header')]
    [System.String]
    # Current date header for the System Context API
    ${Date},

    [Parameter(ParameterSetName = 'Set', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName = 'SetViaIdentity', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V2.Category('Body')]
    [JumpCloud.SDK.V2.Models.IGraphOperationSystemGroupMember]
    # GraphOperation (SystemGroup-Member)
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName = 'SetExpanded', Mandatory)]
    [Parameter(ParameterSetName = 'SetViaIdentityExpanded', Mandatory)]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # The ObjectID of graph object being added or removed as an association.
    ${Id},

    [Parameter(ParameterSetName = 'SetExpanded', Mandatory)]
    [Parameter(ParameterSetName = 'SetViaIdentityExpanded', Mandatory)]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # How to modify the graph connection.
    ${Op},

    [Parameter(ParameterSetName = 'SetExpanded')]
    [Parameter(ParameterSetName = 'SetViaIdentityExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [JumpCloud.SDK.V2.Runtime.Info(PossibleTypes = ([JumpCloud.SDK.V2.Models.IGraphAttributes]))]
    [System.Collections.Hashtable]
    # The graph attributes.
    ${Attributes},

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

    [Parameter()]
    [JumpCloud.SDK.V2.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Returns true when the command succeeds
    ${PassThru},

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
    $Results = JumpCloud.SDK.V2.internal\Set-JcSdkInternalSystemGroupMember @PSBoundParameters
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
      If ((Get-Variable -Scope:('Global')).Where( { $_.Name -eq $_ })) { Remove-Variable -Name:($_) -Scope:('Global') }
    }
    Return $Results
  }
}
