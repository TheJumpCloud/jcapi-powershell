<#
.Synopsis
Locks a DEP-enrolled device.

#### Sample Request
```
  curl -X POST https://console.jumpcloud.com/api/v2/applemdms/{apple_mdm_id}/devices/{device_id}/lock \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{}'
```
.Description
Locks a DEP-enrolled device.

#### Sample Request
```
  curl -X POST https://console.jumpcloud.com/api/v2/applemdms/{apple_mdm_id}/devices/{device_id}/lock \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{}'
```
.Example
PS C:\> Lock-JcSdkAppleMdmDevice -AppleMdmId:(<string>) -DeviceId:(<string>) -Pin:(<string>)


.Example
PS C:\> Lock-JcSdkAppleMdmDevice -AppleMdmId:(<string>) -DeviceId:(<string>) -Body:(<JumpCloud.SDK.V2.Models.PathsLf7IzoApplemdmsAppleMdmIdDevicesDeviceIdLockPostRequestbodyContentApplicationJsonSchema>)



.Inputs
JumpCloud.SDK.V2.Models.IJumpCloudApiIdentity
.Inputs
JumpCloud.SDK.V2.Models.IPathsLf7IzoApplemdmsAppleMdmIdDevicesDeviceIdLockPostRequestbodyContentApplicationJsonSchema
.Outputs
System.Boolean
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IPathsLf7IzoApplemdmsAppleMdmIdDevicesDeviceIdLockPostRequestbodyContentApplicationJsonSchema>:
  [Pin <String>]: 6-digit PIN, required for MacOS, to lock the device

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
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Lock-JcSdkAppleMdmDevice.md
#>
 Function Lock-JcSdkAppleMdmDevice
{
    [OutputType([System.Boolean])]
    [CmdletBinding(DefaultParameterSetName='LockExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
    [Parameter(ParameterSetName='Lock', Mandatory)]
    [Parameter(ParameterSetName='LockExpanded', Mandatory)]
    [JumpCloud.SDK.V2.Category('Path')]
    [System.String]
    # .
    ${AppleMdmId}, 

    [Parameter(ParameterSetName='Lock', Mandatory)]
    [Parameter(ParameterSetName='LockExpanded', Mandatory)]
    [JumpCloud.SDK.V2.Category('Path')]
    [System.String]
    # .
    ${DeviceId}, 

    [Parameter(ParameterSetName='LockViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='LockViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V2.Category('Path')]
    [JumpCloud.SDK.V2.Models.IJumpCloudApiIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject}, 

    [Parameter(ParameterSetName='Lock', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='LockViaIdentity', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V2.Category('Body')]
    [JumpCloud.SDK.V2.Models.IPathsLf7IzoApplemdmsAppleMdmIdDevicesDeviceIdLockPostRequestbodyContentApplicationJsonSchema]
    # .
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body}, 

    [Parameter(ParameterSetName='LockExpanded')]
    [Parameter(ParameterSetName='LockViaIdentityExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # 6-digit PIN, required for MacOS, to lock the device
    ${Pin}, 

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
        $maxRetries = 4
        $resultCounter = 0
        :retryLoop do {
            $resultCounter++
            $Results = JumpCloud.SDK.V2.internal\Lock-JcSdkInternalAppleMdmDevice @PSBoundParameters -errorAction SilentlyContinue -errorVariable sdkError
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


