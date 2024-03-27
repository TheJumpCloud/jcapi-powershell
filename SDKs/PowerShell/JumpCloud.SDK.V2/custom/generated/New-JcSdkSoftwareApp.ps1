<#
.Synopsis
This endpoint allows you to create a Software Application that will be managed by JumpCloud on associated JumpCloud systems.
The optional isConfigEnabled and appConfiguration apple_vpp attributes are not included in the response.

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
The optional isConfigEnabled and appConfiguration apple_vpp attributes are not included in the response.

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
JumpCloud.SDK.V2.Models.ISoftwareAppCreate
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <ISoftwareApp>:
  [DisplayName <String>]:
  [Id <String>]:
  [Settings <ISoftwareAppSettings[]>]:
    [AllowUpdateDelay <Boolean?>]:
    [AppleVppAppConfiguration <String>]: Text sent to configure the application, the text should be a valid plist.  Returned only by 'GET /softwareapps/{id}'.
    [AppleVppAssignedLicenses <Int32?>]:
    [AppleVppAvailableLicenses <Int32?>]:
    [AppleVppDetails <ISoftwareAppAppleVppDetails>]: App details returned by iTunes API. See example. The properties in this field are out of our control and we cannot guarantee consistency, so it should be checked by the client and manage the details accordingly.
      [(Any) <Object>]: This indicates any property can be added to this object.
    [AppleVppIsConfigEnabled <Boolean?>]: Denotes if configuration has been enabled for the application.  Returned only by ''GET /softwareapps/{id}''.
    [AppleVppSupportedDeviceFamilies <String[]>]: The supported device families for this VPP Application.
    [AppleVppTotalLicenses <Int32?>]:
    [AssetKind <String>]: The manifest asset kind (ex: software).
    [AssetSha256Size <Int32?>]: The incremental size to use for summing the package as it is downloaded.
    [AssetSha256Strings <String[]>]: The array of checksums, one each for the hash size up to the total size of the package.
    [AutoUpdate <Boolean?>]:
    [CommandLineArguments <String>]: Command line arguments to use with the application.
    [Description <String>]: The software app description.
    [DesiredState <String>]: State of Install or Uninstall
    [EnterpriseObjectId <String>]: ID of the Enterprise with which this app is associated
    [GoogleAndroidAppPricing <String>]: Whether this app is free, free with in-app purchases, or paid.
    [GoogleAndroidAppVersion <String>]: Latest version currently available for this app.
    [GoogleAndroidAuthor <String>]: The name of the author of this app.
    [GoogleAndroidAutoUpdateMode <String>]: Controls the auto-update mode for the app.
    [GoogleAndroidCategory <String>]: The app category (e.g. COMMUNICATION, SOCIAL, etc.).
    [GoogleAndroidContentRating <String>]: The content rating for this app.
    [GoogleAndroidDisplayMode <String>]: The display mode of the web app.
    [GoogleAndroidDistributionChannel <String>]: How and to whom the package is made available.
    [GoogleAndroidFeatures <String[]>]: The array of android features for the app.
    [GoogleAndroidFullDescription <String>]: Full app description, if available.
    [GoogleAndroidIconUrl <String>]: A link to an image that can be used as an icon for the app.
    [GoogleAndroidInstallType <String>]: The type of installation to perform for an app.
    [GoogleAndroidManagedConfigurationTemplateId <String>]: The managed configurations template for the app.
    [GoogleAndroidManagedProperties <Boolean?>]: Indicates whether this app has managed properties or not.
    [GoogleAndroidMinSdkVersion <Int32?>]: The minimum Android SDK necessary to run the app.
    [GoogleAndroidName <String>]: The name of the app in the form enterprises/{enterprise}/applications/{packageName}.
    [GoogleAndroidPermissionGrants <ISoftwareAppPermissionGrants[]>]:
      [Id <String>]: An opaque string uniquely identifying the Android permission, e.g. android.permission.READ_CALENDAR.
      [Policy <String>]: The policy for granting the permission.
    [GoogleAndroidRuntimePermission <String>]: The policy for granting permission requests to apps.
    [GoogleAndroidStartUrl <String>]: The start URL, i.e. the URL that should load when the user opens the application. Applicable only for webapps.
    [GoogleAndroidType <String>]: Type of this android application.
    [GoogleAndroidUpdateTime <String>]: The approximate time (within 7 days) the app was last published.
    [GoogleAndroidVersionCode <Int32?>]: The current version of the web app.
    [Location <String>]: Repository where the app is located within the package manager
    [LocationObjectId <String>]: ID of the repository where the app is located within the package manager
    [MicrosoftStoreDoNotUpdate <Boolean?>]: Indicates whether the app can be updated or not.
    [MicrosoftStoreNonRemovable <Boolean?>]: Indicates whether the app is removable by the users or not.
    [MicrosoftStorePackageFamilyName <String>]: Package Family Name for the app from Microsoft App Store.
    [ObjectId <String>]:
    [PackageId <String>]:
    [PackageKind <String>]: The package manifest kind (ex: software-package).
    [PackageManager <String>]: App store serving the app: APPLE_VPP, CHOCOLATEY, etc.
    [PackageSubtitle <String>]: The package manifest subtitle.
    [PackageVersion <String>]: The package manifest version.
    [StoredPackageObjectId <String>]: ID of the stored package this app uses to reference the stored install media.
    [StoredPackageVersions <IObjectStorageVersion[]>]:
      [Metadata <IObjectStorageVersionMetadata>]: Dictionary of <any>
        [(Any) <Object>]: This indicates any property can be added to this object.
      [Name <String>]:
      [RejectedReason <String>]:
      [Sha256Sum <String>]:
      [Size <Int32?>]:
      [Status <String>]:
      [Version <Int32?>]:

SETTINGS <ISoftwareAppSettings[]>:
  [AllowUpdateDelay <Boolean?>]:
  [AppleVppAppConfiguration <String>]: Text sent to configure the application, the text should be a valid plist.  Returned only by 'GET /softwareapps/{id}'.
  [AppleVppAssignedLicenses <Int32?>]:
  [AppleVppAvailableLicenses <Int32?>]:
  [AppleVppDetails <ISoftwareAppAppleVppDetails>]: App details returned by iTunes API. See example. The properties in this field are out of our control and we cannot guarantee consistency, so it should be checked by the client and manage the details accordingly.
    [(Any) <Object>]: This indicates any property can be added to this object.
  [AppleVppIsConfigEnabled <Boolean?>]: Denotes if configuration has been enabled for the application.  Returned only by ''GET /softwareapps/{id}''.
  [AppleVppSupportedDeviceFamilies <String[]>]: The supported device families for this VPP Application.
  [AppleVppTotalLicenses <Int32?>]:
  [AssetKind <String>]: The manifest asset kind (ex: software).
  [AssetSha256Size <Int32?>]: The incremental size to use for summing the package as it is downloaded.
  [AssetSha256Strings <String[]>]: The array of checksums, one each for the hash size up to the total size of the package.
  [AutoUpdate <Boolean?>]:
  [CommandLineArguments <String>]: Command line arguments to use with the application.
  [Description <String>]: The software app description.
  [DesiredState <String>]: State of Install or Uninstall
  [EnterpriseObjectId <String>]: ID of the Enterprise with which this app is associated
  [GoogleAndroidAppPricing <String>]: Whether this app is free, free with in-app purchases, or paid.
  [GoogleAndroidAppVersion <String>]: Latest version currently available for this app.
  [GoogleAndroidAuthor <String>]: The name of the author of this app.
  [GoogleAndroidAutoUpdateMode <String>]: Controls the auto-update mode for the app.
  [GoogleAndroidCategory <String>]: The app category (e.g. COMMUNICATION, SOCIAL, etc.).
  [GoogleAndroidContentRating <String>]: The content rating for this app.
  [GoogleAndroidDisplayMode <String>]: The display mode of the web app.
  [GoogleAndroidDistributionChannel <String>]: How and to whom the package is made available.
  [GoogleAndroidFeatures <String[]>]: The array of android features for the app.
  [GoogleAndroidFullDescription <String>]: Full app description, if available.
  [GoogleAndroidIconUrl <String>]: A link to an image that can be used as an icon for the app.
  [GoogleAndroidInstallType <String>]: The type of installation to perform for an app.
  [GoogleAndroidManagedConfigurationTemplateId <String>]: The managed configurations template for the app.
  [GoogleAndroidManagedProperties <Boolean?>]: Indicates whether this app has managed properties or not.
  [GoogleAndroidMinSdkVersion <Int32?>]: The minimum Android SDK necessary to run the app.
  [GoogleAndroidName <String>]: The name of the app in the form enterprises/{enterprise}/applications/{packageName}.
  [GoogleAndroidPermissionGrants <ISoftwareAppPermissionGrants[]>]:
    [Id <String>]: An opaque string uniquely identifying the Android permission, e.g. android.permission.READ_CALENDAR.
    [Policy <String>]: The policy for granting the permission.
  [GoogleAndroidRuntimePermission <String>]: The policy for granting permission requests to apps.
  [GoogleAndroidStartUrl <String>]: The start URL, i.e. the URL that should load when the user opens the application. Applicable only for webapps.
  [GoogleAndroidType <String>]: Type of this android application.
  [GoogleAndroidUpdateTime <String>]: The approximate time (within 7 days) the app was last published.
  [GoogleAndroidVersionCode <Int32?>]: The current version of the web app.
  [Location <String>]: Repository where the app is located within the package manager
  [LocationObjectId <String>]: ID of the repository where the app is located within the package manager
  [MicrosoftStoreDoNotUpdate <Boolean?>]: Indicates whether the app can be updated or not.
  [MicrosoftStoreNonRemovable <Boolean?>]: Indicates whether the app is removable by the users or not.
  [MicrosoftStorePackageFamilyName <String>]: Package Family Name for the app from Microsoft App Store.
  [ObjectId <String>]:
  [PackageId <String>]:
  [PackageKind <String>]: The package manifest kind (ex: software-package).
  [PackageManager <String>]: App store serving the app: APPLE_VPP, CHOCOLATEY, etc.
  [PackageSubtitle <String>]: The package manifest subtitle.
  [PackageVersion <String>]: The package manifest version.
  [StoredPackageObjectId <String>]: ID of the stored package this app uses to reference the stored install media.
  [StoredPackageVersions <IObjectStorageVersion[]>]:
    [Metadata <IObjectStorageVersionMetadata>]: Dictionary of <any>
      [(Any) <Object>]: This indicates any property can be added to this object.
    [Name <String>]:
    [RejectedReason <String>]:
    [Sha256Sum <String>]:
    [Size <Int32?>]:
    [Status <String>]:
    [Version <Int32?>]:
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/New-JcSdkSoftwareApp.md
#>
 Function New-JcSdkSoftwareApp
{
    [OutputType([JumpCloud.SDK.V2.Models.ISoftwareAppCreate])]
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
        $maxRetries = 4
        $resultCounter = 0
        :retryLoop do {
            $resultCounter++
            $Results = JumpCloud.SDK.V2.internal\New-JcSdkInternalSoftwareApp @PSBoundParameters -ErrorVariable StopVar
            If ($stopVar){
                If ($JCHttpResponse.Result.StatusCode -eq 503) {
                    Write-Warning ("503: Service Unavailable - retrying in " + ($resultCounter * 5) + " seconds.")
                } else {
                    break retryLoop
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


