<#
.Synopsis
This endpoint allows you to create a Software Application that will be managed by JumpCloud on associated JumpCloud systems.

#### Sample Request
```
$ curl -X POST https://console.jumpcloud.com/api/v2/softwareapps \\
-H 'Accept: application/json' \\
-H 'Content-Type: application/json' \\
-H 'x-api-key: {API_KEY}' \\
-d '{
  \"displayName\": \"Adobe Reader\",
  \"settings\": [{\"packageId\": \"adobereader\"}]
}'
```
.Description
This endpoint allows you to create a Software Application that will be managed by JumpCloud on associated JumpCloud systems.

#### Sample Request
```
$ curl -X POST https://console.jumpcloud.com/api/v2/softwareapps \\
-H 'Accept: application/json' \\
-H 'Content-Type: application/json' \\
-H 'x-api-key: {API_KEY}' \\
-d '{
  \"displayName\": \"Adobe Reader\",
  \"settings\": [{\"packageId\": \"adobereader\"}]
}'
```
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
JumpCloud.SDK.V2.Models.ISoftwareApp
.Outputs
JumpCloud.SDK.V2.Models.ISoftwareApp
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <ISoftwareApp>:
  [DisplayName <String>]:
  [Id <String>]:
  [Settings <ISoftwareAppSettings[]>]:
    [AllowUpdateDelay <Boolean?>]:
    [AppleVppAppConfiguration <String>]: Text sent to configure the application.
    [AppleVppAssignedLicenses <Int32?>]:
    [AppleVppAvailableLicenses <Int32?>]:
    [AppleVppDetails <ISoftwareAppAppleVppDetails>]: App details returned by iTunes API. See example. The properties in this field are out of our control and we cannot guarantee consistency, so it should be checked by the client and manage the details accordingly.
      [(Any) <Object>]: This indicates any property can be added to this object.
    [AppleVppIsConfigEnabled <Boolean?>]: Denotes if configuration has been enabled for the application.
    [AppleVppSupportedDeviceFamilies <String[]>]: The supported device families for this VPP Application.
    [AppleVppTotalLicenses <Int32?>]:
    [AssetKind <String>]: The manifest asset kind (ex: software).
    [AssetSha256Size <Int32?>]: The incremental size to use for summing the package as it is downloaded.
    [AssetSha256Strings <String[]>]: The array of checksums, one each for the hash size up to the total size of the package.
    [AutoUpdate <Boolean?>]:
    [Description <String>]: The software app description.
    [DesiredState <String>]: State of Install or Uninstall
    [Location <String>]: Repository where the app is located within the package manager
    [LocationObjectId <String>]: ID of the repository where the app is located within the package manager
    [PackageId <String>]:
    [PackageKind <String>]: The package manifest kind (ex: software-package).
    [PackageManager <String>]: App store serving the app: APPLE_VPP, CHOCOLATEY, etc.
    [PackageSubtitle <String>]: The package manifest subtitle.
    [PackageVersion <String>]: The package manifest version.

SETTINGS <ISoftwareAppSettings[]>:
  [AllowUpdateDelay <Boolean?>]:
  [AppleVppAppConfiguration <String>]: Text sent to configure the application.
  [AppleVppAssignedLicenses <Int32?>]:
  [AppleVppAvailableLicenses <Int32?>]:
  [AppleVppDetails <ISoftwareAppAppleVppDetails>]: App details returned by iTunes API. See example. The properties in this field are out of our control and we cannot guarantee consistency, so it should be checked by the client and manage the details accordingly.
    [(Any) <Object>]: This indicates any property can be added to this object.
  [AppleVppIsConfigEnabled <Boolean?>]: Denotes if configuration has been enabled for the application.
  [AppleVppSupportedDeviceFamilies <String[]>]: The supported device families for this VPP Application.
  [AppleVppTotalLicenses <Int32?>]:
  [AssetKind <String>]: The manifest asset kind (ex: software).
  [AssetSha256Size <Int32?>]: The incremental size to use for summing the package as it is downloaded.
  [AssetSha256Strings <String[]>]: The array of checksums, one each for the hash size up to the total size of the package.
  [AutoUpdate <Boolean?>]:
  [Description <String>]: The software app description.
  [DesiredState <String>]: State of Install or Uninstall
  [Location <String>]: Repository where the app is located within the package manager
  [LocationObjectId <String>]: ID of the repository where the app is located within the package manager
  [PackageId <String>]:
  [PackageKind <String>]: The package manifest kind (ex: software-package).
  [PackageManager <String>]: App store serving the app: APPLE_VPP, CHOCOLATEY, etc.
  [PackageSubtitle <String>]: The package manifest subtitle.
  [PackageVersion <String>]: The package manifest version.
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/New-JcSdkSoftwareApp.md
#>
 Function New-JcSdkSoftwareApp
{
    [OutputType([JumpCloud.SDK.V2.Models.ISoftwareApp])]
    [CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
    [Parameter(ParameterSetName='Create', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V2.Category('Body')]
    [JumpCloud.SDK.V2.Models.ISoftwareApp]
    # Software Application Package
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # .
    ${DisplayName},

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # .
    ${Id},

    [Parameter(ParameterSetName='CreateExpanded')]
    [AllowEmptyCollection()]
    [JumpCloud.SDK.V2.Category('Body')]
    [JumpCloud.SDK.V2.Models.ISoftwareAppSettings[]]
    # .
    # To construct, see NOTES section for SETTINGS properties and create a hash table.
    ${Settings},

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
        $Results = JumpCloud.SDK.V2.internal\New-JcSdkInternalSoftwareApp @PSBoundParameters
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


