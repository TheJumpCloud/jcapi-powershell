<#
.Synopsis
Updates an Apple MDM configuration.
This endpoint is used to supply JumpCloud with a signed certificate from Apple in order to finalize the setup and allow JumpCloud to manage your devices.
It may also be used to update the DEP Settings.

#### Sample Request
```
  curl -X PUT https://console.jumpcloud.com/api/v2/applemdms/{ID} \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"name\": \"MDM name\",
    \"appleSignedCert\": \"{CERTIFICATE}\",
    \"encryptedDepServerToken\": \"{SERVER_TOKEN}\",
    \"dep\": {
      \"welcomeScreen\": {
        \"title\": \"Welcome\",
        \"paragraph\": \"In just a few steps, you will be working securely from your Mac.\",
        \"button\": \"continue\",
      },
    },
  }'
```
.Description
Updates an Apple MDM configuration.
This endpoint is used to supply JumpCloud with a signed certificate from Apple in order to finalize the setup and allow JumpCloud to manage your devices.
It may also be used to update the DEP Settings.

#### Sample Request
```
  curl -X PUT https://console.jumpcloud.com/api/v2/applemdms/{ID} \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"name\": \"MDM name\",
    \"appleSignedCert\": \"{CERTIFICATE}\",
    \"encryptedDepServerToken\": \"{SERVER_TOKEN}\",
    \"dep\": {
      \"welcomeScreen\": {
        \"title\": \"Welcome\",
        \"paragraph\": \"In just a few steps, you will be working securely from your Mac.\",
        \"button\": \"continue\",
      },
    },
  }'
```
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
JumpCloud.SDK.V2.Models.IAppleMdmPatch
.Inputs
JumpCloud.SDK.V2.Models.IJumpCloudApiIdentity
.Outputs
JumpCloud.SDK.V2.Models.IAppleMdm
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IAppleMdmPatch>:
  [AllowMobileUserEnrollment <Boolean?>]: A toggle to allow mobile device enrollment for an organization.
  [AppleCertCreatorAppleId <String>]: The Apple ID of the admin who created the Apple signed certificate.
  [AppleSignedCert <String>]: A signed certificate obtained from Apple after providing Apple with the plist file provided on POST.
  [DefaultIosUserEnrollmentDeviceGroupId <String>]: ObjectId uniquely identifying the MDM default iOS user enrollment device group.
  [DefaultSystemGroupId <String>]: ObjectId uniquely identifying the MDM default System Group.
  [DepEnableZeroTouchEnrollment <Boolean?>]: A toggle to determine if DEP registered devices should go through JumpCloud Zero Touch Enrollment.
  [DepSetupAssistantOptions <IDepSetupAssistantOption[]>]:
    [Option <String>]: Options to skip screens during MacOS and iOS setup:         * `accessibility` - Skips the Accessibility pane, only if the Mac is connected to Ethernet and the cloud config is downloaded.         * `appearance` - Skips the Choose Your Look screen.         * `appleID` - Skips Apple ID setup.         * `biometric` - Skips biometric setup.         * `diagnostics` - Skips the App Analytics pane.         * `displayTone` - Skips display tone setup.         * `fileVault` - Skips FileVault setup assistant screen.         * `icloudDiagnostics` - Skips iCloud analytics screen.         * `icloudStorage` - Skips iCloud documents and desktop screen.         * `location` - Skips location services setup.         * `payment` - Skips Apple Pay setup.         * `privacy` - Skips the Privacy setup.         * `restore` - Skips restoring from backup.         * `screenTime` - Skips screen time setup.         * `siri` - Skips Siri setup.         * `tos` - Skips terms and conditions.         * `appStore` - Skips the App Store pane.         * `deviceToDeviceMigration` - Skips Device to Device Migration pane.         * `displayZoom` - Skips zoom setup.         * `homeButton` - Skips the Meet the New Home Button screen on iPhone 7, iPhone 7 Plus, iPhone 8, iPhone 8 Plus and iPhone SE.         * `imessageAndFacetime` - Skips the iMessage and FaceTime screen in iOS.         * `messagingActivationUsingPhoneNumber` - Skips the iMessage pane.         * `moveFromAndroid` - If the Restore pane is not skipped, removes the Move from Android option in the Restore pane on iOS.O         * `passcode` - Hides and disables the passcode pane.         * `restoreComplete` - Skips the Restore Completed pane.         * `setupCellular` - Skips the add cellular plan pane.         * `softwareUpdate` - Skips the mandatory software update screen in iOS.         * `unlockWithWatch` - Skips Unlock Your Mac with your Apple Watch pane.         * `updateComplete` - Skips the Software Update Complete pane.         * `watchMigration` - Skips the screen for watch migration.         * `welcome` - Skips the Get Started pane.        
  [EncryptedDepServerToken <String>]: The S/MIME encoded DEP Server Token returned by Apple Business Manager when creating an MDM instance.
  [IoDefaultDeviceGroupObjectIds <String[]>]: An array of ObjectIDs identifying the default device groups for this specific type (based on the OS family) of automated device enrollment. Currently, only a single DeviceGroupID is supported.
  [IoEnableZeroTouchEnrollment <Boolean?>]: A toggle to determine if ADE registered devices should go through JumpCloud Zero Touch Enrollment.
  [IoSetupAssistantOptions <IDepSetupAssistantOption[]>]:
  [IosWelcomeScreenButton <String>]: Text to display on the button on the DEP Welcome Screen.
  [IosWelcomeScreenParagraph <String>]: A message to display on the DEP Welcome Screen.
  [IosWelcomeScreenTitle <String>]: The title to display on the DEP Welcome Screen.
  [MacoDefaultDeviceGroupObjectIds <String[]>]: An array of ObjectIDs identifying the default device groups for this specific type (based on the OS family) of automated device enrollment. Currently, only a single DeviceGroupID is supported.
  [MacoEnableZeroTouchEnrollment <Boolean?>]: A toggle to determine if ADE registered devices should go through JumpCloud Zero Touch Enrollment.
  [MacoSetupAssistantOptions <IDepSetupAssistantOption[]>]:
  [MacosWelcomeScreenButton <String>]: Text to display on the button on the DEP Welcome Screen.
  [MacosWelcomeScreenParagraph <String>]: A message to display on the DEP Welcome Screen.
  [MacosWelcomeScreenTitle <String>]: The title to display on the DEP Welcome Screen.
  [Name <String>]: A new name for the Apple MDM configuration.
  [WelcomeScreenButton <String>]: Text to display on the button on the DEP Welcome Screen.
  [WelcomeScreenParagraph <String>]: A message to display on the DEP Welcome Screen.
  [WelcomeScreenTitle <String>]: The title to display on the DEP Welcome Screen.

DEPSETUPASSISTANTOPTIONS <IDepSetupAssistantOption[]>:
  [Option <String>]: Options to skip screens during MacOS and iOS setup:         * `accessibility` - Skips the Accessibility pane, only if the Mac is connected to Ethernet and the cloud config is downloaded.         * `appearance` - Skips the Choose Your Look screen.         * `appleID` - Skips Apple ID setup.         * `biometric` - Skips biometric setup.         * `diagnostics` - Skips the App Analytics pane.         * `displayTone` - Skips display tone setup.         * `fileVault` - Skips FileVault setup assistant screen.         * `icloudDiagnostics` - Skips iCloud analytics screen.         * `icloudStorage` - Skips iCloud documents and desktop screen.         * `location` - Skips location services setup.         * `payment` - Skips Apple Pay setup.         * `privacy` - Skips the Privacy setup.         * `restore` - Skips restoring from backup.         * `screenTime` - Skips screen time setup.         * `siri` - Skips Siri setup.         * `tos` - Skips terms and conditions.         * `appStore` - Skips the App Store pane.         * `deviceToDeviceMigration` - Skips Device to Device Migration pane.         * `displayZoom` - Skips zoom setup.         * `homeButton` - Skips the Meet the New Home Button screen on iPhone 7, iPhone 7 Plus, iPhone 8, iPhone 8 Plus and iPhone SE.         * `imessageAndFacetime` - Skips the iMessage and FaceTime screen in iOS.         * `messagingActivationUsingPhoneNumber` - Skips the iMessage pane.         * `moveFromAndroid` - If the Restore pane is not skipped, removes the Move from Android option in the Restore pane on iOS.O         * `passcode` - Hides and disables the passcode pane.         * `restoreComplete` - Skips the Restore Completed pane.         * `setupCellular` - Skips the add cellular plan pane.         * `softwareUpdate` - Skips the mandatory software update screen in iOS.         * `unlockWithWatch` - Skips Unlock Your Mac with your Apple Watch pane.         * `updateComplete` - Skips the Software Update Complete pane.         * `watchMigration` - Skips the screen for watch migration.         * `welcome` - Skips the Get Started pane.        

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

IOSETUPASSISTANTOPTIONS <IDepSetupAssistantOption[]>:
  [Option <String>]: Options to skip screens during MacOS and iOS setup:         * `accessibility` - Skips the Accessibility pane, only if the Mac is connected to Ethernet and the cloud config is downloaded.         * `appearance` - Skips the Choose Your Look screen.         * `appleID` - Skips Apple ID setup.         * `biometric` - Skips biometric setup.         * `diagnostics` - Skips the App Analytics pane.         * `displayTone` - Skips display tone setup.         * `fileVault` - Skips FileVault setup assistant screen.         * `icloudDiagnostics` - Skips iCloud analytics screen.         * `icloudStorage` - Skips iCloud documents and desktop screen.         * `location` - Skips location services setup.         * `payment` - Skips Apple Pay setup.         * `privacy` - Skips the Privacy setup.         * `restore` - Skips restoring from backup.         * `screenTime` - Skips screen time setup.         * `siri` - Skips Siri setup.         * `tos` - Skips terms and conditions.         * `appStore` - Skips the App Store pane.         * `deviceToDeviceMigration` - Skips Device to Device Migration pane.         * `displayZoom` - Skips zoom setup.         * `homeButton` - Skips the Meet the New Home Button screen on iPhone 7, iPhone 7 Plus, iPhone 8, iPhone 8 Plus and iPhone SE.         * `imessageAndFacetime` - Skips the iMessage and FaceTime screen in iOS.         * `messagingActivationUsingPhoneNumber` - Skips the iMessage pane.         * `moveFromAndroid` - If the Restore pane is not skipped, removes the Move from Android option in the Restore pane on iOS.O         * `passcode` - Hides and disables the passcode pane.         * `restoreComplete` - Skips the Restore Completed pane.         * `setupCellular` - Skips the add cellular plan pane.         * `softwareUpdate` - Skips the mandatory software update screen in iOS.         * `unlockWithWatch` - Skips Unlock Your Mac with your Apple Watch pane.         * `updateComplete` - Skips the Software Update Complete pane.         * `watchMigration` - Skips the screen for watch migration.         * `welcome` - Skips the Get Started pane.        

MACOSETUPASSISTANTOPTIONS <IDepSetupAssistantOption[]>:
  [Option <String>]: Options to skip screens during MacOS and iOS setup:         * `accessibility` - Skips the Accessibility pane, only if the Mac is connected to Ethernet and the cloud config is downloaded.         * `appearance` - Skips the Choose Your Look screen.         * `appleID` - Skips Apple ID setup.         * `biometric` - Skips biometric setup.         * `diagnostics` - Skips the App Analytics pane.         * `displayTone` - Skips display tone setup.         * `fileVault` - Skips FileVault setup assistant screen.         * `icloudDiagnostics` - Skips iCloud analytics screen.         * `icloudStorage` - Skips iCloud documents and desktop screen.         * `location` - Skips location services setup.         * `payment` - Skips Apple Pay setup.         * `privacy` - Skips the Privacy setup.         * `restore` - Skips restoring from backup.         * `screenTime` - Skips screen time setup.         * `siri` - Skips Siri setup.         * `tos` - Skips terms and conditions.         * `appStore` - Skips the App Store pane.         * `deviceToDeviceMigration` - Skips Device to Device Migration pane.         * `displayZoom` - Skips zoom setup.         * `homeButton` - Skips the Meet the New Home Button screen on iPhone 7, iPhone 7 Plus, iPhone 8, iPhone 8 Plus and iPhone SE.         * `imessageAndFacetime` - Skips the iMessage and FaceTime screen in iOS.         * `messagingActivationUsingPhoneNumber` - Skips the iMessage pane.         * `moveFromAndroid` - If the Restore pane is not skipped, removes the Move from Android option in the Restore pane on iOS.O         * `passcode` - Hides and disables the passcode pane.         * `restoreComplete` - Skips the Restore Completed pane.         * `setupCellular` - Skips the add cellular plan pane.         * `softwareUpdate` - Skips the mandatory software update screen in iOS.         * `unlockWithWatch` - Skips Unlock Your Mac with your Apple Watch pane.         * `updateComplete` - Skips the Software Update Complete pane.         * `watchMigration` - Skips the screen for watch migration.         * `welcome` - Skips the Get Started pane.        
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Set-JcSdkAppleMdm.md
#>
 Function Set-JcSdkAppleMdm
{
    [OutputType([JumpCloud.SDK.V2.Models.IAppleMdm])]
    [CmdletBinding(DefaultParameterSetName='SetExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
    [Parameter(ParameterSetName='Set', Mandatory)]
    [Parameter(ParameterSetName='SetExpanded', Mandatory)]
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
    [JumpCloud.SDK.V2.Models.IAppleMdmPatch]
    # Apple MDM Patch
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # A toggle to allow mobile device enrollment for an organization.
    ${AllowMobileUserEnrollment}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # The Apple ID of the admin who created the Apple signed certificate.
    ${AppleCertCreatorAppleId}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # A signed certificate obtained from Apple after providing Apple with the plist file provided on POST.
    ${AppleSignedCert}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # ObjectId uniquely identifying the MDM default iOS user enrollment device group.
    ${DefaultIosUserEnrollmentDeviceGroupId}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # ObjectId uniquely identifying the MDM default System Group.
    ${DefaultSystemGroupId}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # A toggle to determine if DEP registered devices should go through JumpCloud Zero Touch Enrollment.
    ${DepEnableZeroTouchEnrollment}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [AllowEmptyCollection()]
    [JumpCloud.SDK.V2.Category('Body')]
    [JumpCloud.SDK.V2.Models.IDepSetupAssistantOption[]]
    # .
    # To construct, see NOTES section for DEPSETUPASSISTANTOPTIONS properties and create a hash table.
    ${DepSetupAssistantOptions}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # The S/MIME encoded DEP Server Token returned by Apple Business Manager when creating an MDM instance.
    ${EncryptedDepServerToken}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [AllowEmptyCollection()]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String[]]
    # An array of ObjectIDs identifying the default device groups for this specific type (based on the OS family) of automated device enrollment.
    # Currently, only a single DeviceGroupID is supported.
    ${IoDefaultDeviceGroupObjectIds}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # A toggle to determine if ADE registered devices should go through JumpCloud Zero Touch Enrollment.
    ${IoEnableZeroTouchEnrollment}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [AllowEmptyCollection()]
    [JumpCloud.SDK.V2.Category('Body')]
    [JumpCloud.SDK.V2.Models.IDepSetupAssistantOption[]]
    # .
    # To construct, see NOTES section for IOSETUPASSISTANTOPTIONS properties and create a hash table.
    ${IoSetupAssistantOptions}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # Text to display on the button on the DEP Welcome Screen.
    ${IosWelcomeScreenButton}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # A message to display on the DEP Welcome Screen.
    ${IosWelcomeScreenParagraph}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # The title to display on the DEP Welcome Screen.
    ${IosWelcomeScreenTitle}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [AllowEmptyCollection()]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String[]]
    # An array of ObjectIDs identifying the default device groups for this specific type (based on the OS family) of automated device enrollment.
    # Currently, only a single DeviceGroupID is supported.
    ${MacoDefaultDeviceGroupObjectIds}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # A toggle to determine if ADE registered devices should go through JumpCloud Zero Touch Enrollment.
    ${MacoEnableZeroTouchEnrollment}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [AllowEmptyCollection()]
    [JumpCloud.SDK.V2.Category('Body')]
    [JumpCloud.SDK.V2.Models.IDepSetupAssistantOption[]]
    # .
    # To construct, see NOTES section for MACOSETUPASSISTANTOPTIONS properties and create a hash table.
    ${MacoSetupAssistantOptions}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # Text to display on the button on the DEP Welcome Screen.
    ${MacosWelcomeScreenButton}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # A message to display on the DEP Welcome Screen.
    ${MacosWelcomeScreenParagraph}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # The title to display on the DEP Welcome Screen.
    ${MacosWelcomeScreenTitle}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # A new name for the Apple MDM configuration.
    ${Name}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # Text to display on the button on the DEP Welcome Screen.
    ${WelcomeScreenButton}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # A message to display on the DEP Welcome Screen.
    ${WelcomeScreenParagraph}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String]
    # The title to display on the DEP Welcome Screen.
    ${WelcomeScreenTitle}, 

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
        $Results = JumpCloud.SDK.V2.internal\Set-JcSdkInternalAppleMdm @PSBoundParameters
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


