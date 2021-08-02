<#
.Synopsis
This endpoint adds an authorization method to a workday instance.

You must supply a username and password for `Basic Authentication` that is the same as your WorkDay Integrator System User.
Failure to provide these credentials  will result in the request being rejected.

Currently `O-Auth` isn't a supported authentication protocol for WorkDay, but will be in the future.

#### Sample Request

```
curl -X POST https://console.jumpcloud.com/api/v2/workdays/{WorkDayID}/auth \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
\t\"auth\":{
\t  \"basic\": {
\t\t\"username\": \"someDeveloper\",\t  
\t\t\"password\": \"notTheRealPassword\"

\t  }
\t}
}'

```
.Description
This endpoint adds an authorization method to a workday instance.

You must supply a username and password for `Basic Authentication` that is the same as your WorkDay Integrator System User.
Failure to provide these credentials  will result in the request being rejected.

Currently `O-Auth` isn't a supported authentication protocol for WorkDay, but will be in the future.

#### Sample Request

```
curl -X POST https://console.jumpcloud.com/api/v2/workdays/{WorkDayID}/auth \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
\t\"auth\":{
\t  \"basic\": {
\t\t\"username\": \"someDeveloper\",\t  
\t\t\"password\": \"notTheRealPassword\"

\t  }
\t}
}'

```
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
JumpCloud.SDK.V2.Models.IAuthInputObject
.Inputs
JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity
.Outputs
System.Boolean
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IAuthInputObject>:
  [BasicPassword <String>]:
  [BasicUsername <String>]:
  [OauthCode <String>]:

INPUTOBJECT <IJumpCloudApIsIdentity>:
  [AccountId <String>]:
  [ActivedirectoryId <String>]:
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
  [RadiusserverId <String>]: ObjectID of the Radius Server.
  [SoftwareAppId <String>]: ObjectID of the Software App.
  [SystemId <String>]: ObjectID of the System.
  [UserId <String>]: ObjectID of the User.
  [WorkdayId <String>]:
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Grant-JcSdkWorkday.md
#>
 Function Grant-JcSdkWorkday
{
    [OutputType([System.Boolean])]
    [CmdletBinding(DefaultParameterSetName='AuthorizeExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
    [Parameter(ParameterSetName='Authorize', Mandatory)]
    [Parameter(ParameterSetName='AuthorizeExpanded', Mandatory)]
    [JumpCloud.SDK.V2.Category('Path')]
    [System.String]
    # .
    ${WorkdayId},

    [Parameter(ParameterSetName='AuthorizeViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='AuthorizeViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V2.Category('Path')]
    [JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='Authorize', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='AuthorizeViaIdentity', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V2.Category('Body')]
    [JumpCloud.SDK.V2.Models.IAuthInputObject]
    # Auth Input Object
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='AuthorizeExpanded')]
    [Parameter(ParameterSetName='AuthorizeViaIdentityExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # .
    ${BasicPassword},

    [Parameter(ParameterSetName='AuthorizeExpanded')]
    [Parameter(ParameterSetName='AuthorizeViaIdentityExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # .
    ${BasicUsername},

    [Parameter(ParameterSetName='AuthorizeExpanded')]
    [Parameter(ParameterSetName='AuthorizeViaIdentityExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # .
    ${OauthCode},

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
        $Results = JumpCloud.SDK.V2.internal\Grant-JcSdkInternalWorkday @PSBoundParameters
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


