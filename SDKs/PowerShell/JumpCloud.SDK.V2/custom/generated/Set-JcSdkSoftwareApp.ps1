<#
.Synopsis
This endpoint updates a specific Software Application configuration for the organization.
displayName can be changed alone if no settings are provided.
If a setting is provided, it should include all its information since this endpoint will update all the settings' fields.
The optional isConfigEnabled and appConfiguration apple_vpp attributes are not included in the response.

#### Sample Request - displayName only
```
 curl -X PUT https://console.jumpcloud.com/api/v2/softwareapps/{id} \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"displayName\": \"My Software App\"
  }'
```

#### Sample Request - all attributes
```
 curl -X PUT https://console.jumpcloud.com/api/v2/softwareapps/{id} \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"displayName\": \"My Software App\",
    \"settings\": [
      {
        \"packageId\": \"123456\",
        \"autoUpdate\": false,
        \"allowUpdateDelay\": false,
        \"packageManager\": \"APPLE_VPP\",
        \"locationObjectId\": \"123456789012123456789012\",
        \"location\": \"123456\",
        \"desiredState\": \"Install\",
        \"appleVpp\": {
          \"appConfiguration\": \"<?xml version=\\\"1.0\\\" encoding=\\\"UTF-8\\\"?><!DOCTYPE plist PUBLIC \\\"-//Apple//DTD PLIST 1.0//EN\\\" \\\"http://www.apple.com/DTDs/PropertyList-1.0.dtd\\\"><plist version=\\\"1.0\\\"><dict><key>MyKey</key><string>My String</string></dict></plist>\",
          \"assignedLicenses\": 20,
          \"availableLicenses\": 10,
          \"details\": {},
          \"isConfigEnabled\": true,
          \"supportedDeviceFamilies\": [
            \"IPAD\",
            \"MAC\"
          ],
          \"totalLicenses\": 30
        },
        \"packageSubtitle\": \"My package subtitle\",
        \"packageVersion\": \"1.2.3\",
        \"packageKind\": \"software-package\",
        \"assetKind\": \"software\",
        \"assetSha256Size\": 256,
        \"assetSha256Strings\": [
          \"a123b123c123d123\"
        ],
        \"description\": \"My app description\"
      }
    ]
  }'
```
.Description
This endpoint updates a specific Software Application configuration for the organization.
displayName can be changed alone if no settings are provided.
If a setting is provided, it should include all its information since this endpoint will update all the settings' fields.
The optional isConfigEnabled and appConfiguration apple_vpp attributes are not included in the response.

#### Sample Request - displayName only
```
 curl -X PUT https://console.jumpcloud.com/api/v2/softwareapps/{id} \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"displayName\": \"My Software App\"
  }'
```

#### Sample Request - all attributes
```
 curl -X PUT https://console.jumpcloud.com/api/v2/softwareapps/{id} \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"displayName\": \"My Software App\",
    \"settings\": [
      {
        \"packageId\": \"123456\",
        \"autoUpdate\": false,
        \"allowUpdateDelay\": false,
        \"packageManager\": \"APPLE_VPP\",
        \"locationObjectId\": \"123456789012123456789012\",
        \"location\": \"123456\",
        \"desiredState\": \"Install\",
        \"appleVpp\": {
          \"appConfiguration\": \"<?xml version=\\\"1.0\\\" encoding=\\\"UTF-8\\\"?><!DOCTYPE plist PUBLIC \\\"-//Apple//DTD PLIST 1.0//EN\\\" \\\"http://www.apple.com/DTDs/PropertyList-1.0.dtd\\\"><plist version=\\\"1.0\\\"><dict><key>MyKey</key><string>My String</string></dict></plist>\",
          \"assignedLicenses\": 20,
          \"availableLicenses\": 10,
          \"details\": {},
          \"isConfigEnabled\": true,
          \"supportedDeviceFamilies\": [
            \"IPAD\",
            \"MAC\"
          ],
          \"totalLicenses\": 30
        },
        \"packageSubtitle\": \"My package subtitle\",
        \"packageVersion\": \"1.2.3\",
        \"packageKind\": \"software-package\",
        \"assetKind\": \"software\",
        \"assetSha256Size\": 256,
        \"assetSha256Strings\": [
          \"a123b123c123d123\"
        ],
        \"description\": \"My app description\"
      }
    ]
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
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Set-JcSdkSoftwareApp.md
#>
 Function Set-JcSdkSoftwareApp
{
    [OutputType([JumpCloud.SDK.V2.Models.ISoftwareApp])]
    [CmdletBinding(DefaultParameterSetName='SetExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
    [Parameter(ParameterSetName='Set', Mandatory)]
    [Parameter(ParameterSetName='SetExpanded', Mandatory)]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V2.Category('Path')]
    [System.String]
    # .
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
    [JumpCloud.SDK.V2.Models.ISoftwareApp]
    # Software Application Package
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # .
    ${DisplayName}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # .
    ${Id1}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
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
        do {
            $resultCounter++
            $Result = JumpCloud.SDK.V2.internal\Set-JcSdkInternalSoftwareApp @PSBoundParameters
            If ($JCHttpResponse.Result.StatusCode -eq 503) {
                Write-Debug ("StatusCode: " + "$($JCHttpResponse.Result.StatusCode)")
            } else {
                break
            }
            if ($resultCounter -eq $maxRetries) {
                break
            } else {
                Write-Warning ("503: Service Unavailable - retrying in " + ($resultCounter * 5) + " seconds")
                Start-Sleep -Seconds ($resultCounter * 5)
            }
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


