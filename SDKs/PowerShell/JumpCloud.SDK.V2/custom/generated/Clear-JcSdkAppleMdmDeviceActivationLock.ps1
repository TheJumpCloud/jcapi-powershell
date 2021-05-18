<#
.Synopsis
<<<<<<< HEAD:SDKs/PowerShell/JumpCloud.SDK.V2/custom/generated/Remove-JcSdkOffice365.ps1
This endpoint deletes an existing Office 365 instance.

#####

Sample Request
=======
Clears the activation lock on the specified device.
>>>>>>> master:SDKs/PowerShell/JumpCloud.SDK.V2/custom/generated/Clear-JcSdkAppleMdmDeviceActivationLock.ps1

```
<<<<<<< HEAD:SDKs/PowerShell/JumpCloud.SDK.V2/custom/generated/Remove-JcSdkOffice365.ps1
curl -X DELETE https://console.jumpcloud.com/api/v2/office365s/{OFFICE365_ID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```
.Description
This endpoint deletes an existing Office 365 instance.

#####

Sample Request
=======
  curl -X POST https://console.jumpcloud.com/api/v2/applemdms/{apple_mdm_id}/devices/{device_id}/clearActivationLock \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{}'
```
.Description
Clears the activation lock on the specified device.
>>>>>>> master:SDKs/PowerShell/JumpCloud.SDK.V2/custom/generated/Clear-JcSdkAppleMdmDeviceActivationLock.ps1

```
<<<<<<< HEAD:SDKs/PowerShell/JumpCloud.SDK.V2/custom/generated/Remove-JcSdkOffice365.ps1
curl -X DELETE https://console.jumpcloud.com/api/v2/office365s/{OFFICE365_ID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
=======
  curl -X POST https://console.jumpcloud.com/api/v2/applemdms/{apple_mdm_id}/devices/{device_id}/clearActivationLock \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{}'
>>>>>>> master:SDKs/PowerShell/JumpCloud.SDK.V2/custom/generated/Clear-JcSdkAppleMdmDeviceActivationLock.ps1
```
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity
.Outputs
System.Boolean
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

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
<<<<<<< HEAD:SDKs/PowerShell/JumpCloud.SDK.V2/custom/generated/Remove-JcSdkOffice365.ps1
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Remove-JcSdkOffice365.md
#>
 Function Remove-JcSdkOffice365
{
    [OutputType([System.Boolean])]
    [CmdletBinding(DefaultParameterSetName='Delete', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
    [Parameter(ParameterSetName='Delete', Mandatory)]
=======
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Clear-JcSdkAppleMdmDeviceActivationLock.md
#>
 Function Clear-JcSdkAppleMdmDeviceActivationLock
{
    [OutputType([System.Boolean])]
    [CmdletBinding(DefaultParameterSetName='Clear', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
    [Parameter(ParameterSetName='Clear', Mandatory)]
>>>>>>> master:SDKs/PowerShell/JumpCloud.SDK.V2/custom/generated/Clear-JcSdkAppleMdmDeviceActivationLock.ps1
    [JumpCloud.SDK.V2.Category('Path')]
    [System.String]
    # ObjectID of the Office 365 instance.
    ${Office365Id},

<<<<<<< HEAD:SDKs/PowerShell/JumpCloud.SDK.V2/custom/generated/Remove-JcSdkOffice365.ps1
    [Parameter(ParameterSetName='DeleteViaIdentity', Mandatory, ValueFromPipeline)]
=======
    [Parameter(ParameterSetName='Clear', Mandatory)]
    [JumpCloud.SDK.V2.Category('Path')]
    [System.String]
    # .
    ${DeviceId},

    [Parameter(ParameterSetName='ClearViaIdentity', Mandatory, ValueFromPipeline)]
>>>>>>> master:SDKs/PowerShell/JumpCloud.SDK.V2/custom/generated/Clear-JcSdkAppleMdmDeviceActivationLock.ps1
    [JumpCloud.SDK.V2.Category('Path')]
    [JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

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
<<<<<<< HEAD:SDKs/PowerShell/JumpCloud.SDK.V2/custom/generated/Remove-JcSdkOffice365.ps1
        $Results = JumpCloud.SDK.V2.internal\Remove-JcSdkInternalOffice365 @PSBoundParameters
=======
        $Results = JumpCloud.SDK.V2.internal\Clear-JcSdkInternalAppleMdmDeviceActivationLock @PSBoundParameters
>>>>>>> master:SDKs/PowerShell/JumpCloud.SDK.V2/custom/generated/Clear-JcSdkAppleMdmDeviceActivationLock.ps1
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


