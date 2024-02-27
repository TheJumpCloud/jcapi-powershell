<#
.Synopsis
This endpoint allows updating some attributes of an LDAP server.

Sample Request

```
curl -X PATCH https://console.jumpcloud.com/api/v2/ldapservers/{LDAP_ID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"userLockoutAction\": \"remove\",
    \"userPasswordExpirationAction\": \"disable\"
  }'
```
.Description
This endpoint allows updating some attributes of an LDAP server.

Sample Request

```
curl -X PATCH https://console.jumpcloud.com/api/v2/ldapservers/{LDAP_ID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"userLockoutAction\": \"remove\",
    \"userPasswordExpirationAction\": \"disable\"
  }'
```
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
JumpCloud.SDK.V2.Models.IJumpCloudApiIdentity
.Inputs
JumpCloud.SDK.V2.Models.IPaths1Ka5IlhLdapserversIdPatchRequestbodyContentApplicationJsonSchema
.Outputs
JumpCloud.SDK.V2.Models.IPaths1Dvt4UsLdapserversIdPatchResponses200ContentApplicationJsonSchema
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IPaths1Ka5IlhLdapserversIdPatchRequestbodyContentApplicationJsonSchema>:
  [Id <String>]:
  [UserLockoutAction <String>]: LDAP Server Action
  [UserPasswordExpirationAction <String>]: LDAP Server Action

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
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Update-JcSdkLdapServer.md
#>
 Function Update-JcSdkLdapServer
{
    [OutputType([JumpCloud.SDK.V2.Models.IPaths1Dvt4UsLdapserversIdPatchResponses200ContentApplicationJsonSchema])]
    [CmdletBinding(DefaultParameterSetName='UpdateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
    [Parameter(ParameterSetName='Update', Mandatory)]
    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [JumpCloud.SDK.V2.Category('Path')]
    [System.String]
    # Unique identifier of the LDAP server.
    ${Id}, 

    [Parameter(ParameterSetName='UpdateViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V2.Category('Path')]
    [JumpCloud.SDK.V2.Models.IJumpCloudApiIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject}, 

    [Parameter(ParameterSetName='Update', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='UpdateViaIdentity', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V2.Category('Body')]
    [JumpCloud.SDK.V2.Models.IPaths1Ka5IlhLdapserversIdPatchRequestbodyContentApplicationJsonSchema]
    # .
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body}, 

    [Parameter(ParameterSetName='UpdateExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # .
    ${Id1}, 

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # LDAP Server Action
    ${UserLockoutAction}, 

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # LDAP Server Action
    ${UserPasswordExpirationAction}, 

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
            try {
                $Results = (JumpCloud.SDK.V2.internal\Update-JcSdkInternalLdapServer -ErrorAction Stop @PSBoundParameters).ToJsonString() | ConvertFrom-Json;
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


