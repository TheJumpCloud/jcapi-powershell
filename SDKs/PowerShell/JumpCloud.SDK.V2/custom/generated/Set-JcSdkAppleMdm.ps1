<#
.Synopsis
Set an Apple MDM configuration.
This endpoint is used to supply JumpCloud with a signed certificate from Apple in order to finalize the setup and allow JumpCloud to manage your devices.
It may also be used to set the DEP Settings.

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
Set an Apple MDM configuration.
This endpoint is used to supply JumpCloud with a signed certificate from Apple in order to finalize the setup and allow JumpCloud to manage your devices.
It may also be used to set the DEP Settings.

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
PS C:\> Set-JcSdkAppleMdm -Id:(<string>) -Body:(<JumpCloud.SDK.V2.Models.AppleMdmPatch>)



----                                  ----------
AllowMobileUserEnrollment             Boolean
ApnsCertExpiry                        String
ApnsPushTopic                         String
AppleCertCreatorAppleId               String
AppleCertSerialNumber                 String
DefaultIosUserEnrollmentDeviceGroupId String
DefaultSystemGroupId                  String
DepAccessTokenExpiry                  String
DepEnableZeroTouchEnrollment          Boolean
DepServerTokenState                   String
DepSetupAssistantOptions              JumpCloud.SDK.V2.Models.DepSetupAssistantOption[]
Id                                    String
IoDefaultDeviceGroupObjectIds         String
IoEnableZeroTouchEnrollment           Boolean
IoSetupAssistantOptions               JumpCloud.SDK.V2.Models.DepSetupAssistantOption[]
IoSetupOptions                        String
IosWelcomeScreenButton                String
IosWelcomeScreenParagraph             String
IosWelcomeScreenTitle                 String
MacoDefaultDeviceGroupObjectIds       String
MacoEnableZeroTouchEnrollment         Boolean
MacoSetupAssistantOptions             JumpCloud.SDK.V2.Models.DepSetupAssistantOption[]
MacoSetupOptions                      String
MacosWelcomeScreenButton              String
MacosWelcomeScreenParagraph           String
MacosWelcomeScreenTitle               String
Name                                  String
Organization                          String
WelcomeScreenButton                   String
WelcomeScreenParagraph                String
WelcomeScreenTitle                    String


.Example
PS C:\> Set-JcSdkAppleMdm -Id:(<string>) -AllowMobileUserEnrollment:(<switch>) -AppleCertCreatorAppleId:(<string>) -AppleSignedCert:(<string>) -DefaultIosUserEnrollmentDeviceGroupId:(<string>) -DefaultSystemGroupId:(<string>) -DepEnableZeroTouchEnrollment:(<switch>) -DepSetupAssistantOptions:(<JumpCloud.SDK.V2.Models.DepSetupAssistantOption[]>) -EncryptedDepServerToken:(<string>) -IoDefaultDeviceGroupObjectIds:(<string[]>) -IoEnableZeroTouchEnrollment:(<switch>) -IoSetupAssistantOptions:(<JumpCloud.SDK.V2.Models.DepSetupAssistantOption[]>) -IoSetupOptions:(<string[]>) -IosWelcomeScreenButton:(<string>) -IosWelcomeScreenParagraph:(<string>) -IosWelcomeScreenTitle:(<string>) -MacoDefaultDeviceGroupObjectIds:(<string[]>) -MacoEnableZeroTouchEnrollment:(<switch>) -MacoSetupAssistantOptions:(<JumpCloud.SDK.V2.Models.DepSetupAssistantOption[]>) -MacoSetupOptions:(<string[]>) -MacosWelcomeScreenButton:(<string>) -MacosWelcomeScreenParagraph:(<string>) -MacosWelcomeScreenTitle:(<string>) -Name:(<string>) -WelcomeScreenButton:(<string>) -WelcomeScreenParagraph:(<string>) -WelcomeScreenTitle:(<string>)



----                                  ----------
AllowMobileUserEnrollment             Boolean
ApnsCertExpiry                        String
ApnsPushTopic                         String
AppleCertCreatorAppleId               String
AppleCertSerialNumber                 String
DefaultIosUserEnrollmentDeviceGroupId String
DefaultSystemGroupId                  String
DepAccessTokenExpiry                  String
DepEnableZeroTouchEnrollment          Boolean
DepServerTokenState                   String
DepSetupAssistantOptions              JumpCloud.SDK.V2.Models.DepSetupAssistantOption[]
Id                                    String
IoDefaultDeviceGroupObjectIds         String
IoEnableZeroTouchEnrollment           Boolean
IoSetupAssistantOptions               JumpCloud.SDK.V2.Models.DepSetupAssistantOption[]
IoSetupOptions                        String
IosWelcomeScreenButton                String
IosWelcomeScreenParagraph             String
IosWelcomeScreenTitle                 String
MacoDefaultDeviceGroupObjectIds       String
MacoEnableZeroTouchEnrollment         Boolean
MacoSetupAssistantOptions             JumpCloud.SDK.V2.Models.DepSetupAssistantOption[]
MacoSetupOptions                      String
MacosWelcomeScreenButton              String
MacosWelcomeScreenParagraph           String
MacosWelcomeScreenTitle               String
Name                                  String
Organization                          String
WelcomeScreenButton                   String
WelcomeScreenParagraph                String
WelcomeScreenTitle                    String



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
  [DepSetupAssistantOptions <List<IDepSetupAssistantOption>>]:
    [Option <String>]: Options to skip screens during MacOS and iOS setup:         * `accessibility` - Skips the Accessibility pane, only if the Mac is connected to Ethernet and the cloud config is downloaded.         * `actionButton` - Skips the Action Button configuration pane.         * `appearance` - Skips the Choose Your Look screen.         * `appleID` - Skips Apple ID setup.         * `biometric` - Skips biometric setup.         *  `cameraButton` - Skips the Camera Button configuration pane.         * `diagnostics` - Skips the App Analytics pane.         * `displayTone` - Skips display tone setup.         * `enableLockdownMode` - Skips the Lockdown Mode pane.         * `fileVault` - Skips FileVault setup assistant screen.         * `icloudDiagnostics` - Skips iCloud analytics screen.         * `icloudStorage` - Skips iCloud documents and desktop screen.         * `intelligence` - Skips the Intelligence pane.         * `location` - Skips location services setup.         * `payment` - Skips Apple Pay setup.         * `privacy` - Skips the Privacy setup.         * `restore` - Skips restoring from backup.         * `screenTime` - Skips screen time setup.         * `siri` - Skips Siri setup.         * `termsOfAddress` - Skips the Terms of Address pane.         * `tos` - Skips terms and conditions.         * `appStore` - Skips the App Store pane.         * `deviceToDeviceMigration` - Skips Device to Device Migration pane.         * `displayZoom` - Skips zoom setup.         * `homeButton` - Skips the Meet the New Home Button screen on iPhone 7, iPhone 7 Plus, iPhone 8, iPhone 8 Plus and iPhone SE.         * `imessageAndFacetime` - Skips the iMessage and FaceTime screen in iOS.         * `messagingActivationUsingPhoneNumber` - Skips the iMessage pane.         * `moveFromAndroid` - If the Restore pane is not skipped, removes the Move from Android option in the Restore pane on iOS.O         * `passcode` - Hides and disables the passcode pane.         * `restoreComplete` - Skips the Restore Completed pane.         * `safety` - Skips the Safety pane.         * `setupCellular` - Skips the add cellular plan pane.         * `softwareUpdate` - Skips the mandatory software update screen in iOS.         * `unlockWithWatch` - Skips Unlock Your Mac with your Apple Watch pane.         * `updateComplete` - Skips the Software Update Complete pane.         * `wallpaper` - Skips the Wallpaper setup.         * `watchMigration` - Skips the screen for watch migration.         * `welcome` - Skips the Get Started pane.         * `additionalPrivacySettings` - Skips the Additional Privacy Settings pane.         * `multitasking` - Skips the Multitasking pane.         * `osShowcase` - Skips the OS Showcase pane.         * `webContentFiltering` - Skips the Web Content Filtering pane.         * `safetyAndHandling` - Skips the Safety and Handling pane.        
  [EncryptedDepServerToken <String>]: The S/MIME encoded DEP Server Token returned by Apple Business Manager when creating an MDM instance.
  [IoDefaultDeviceGroupObjectIds <List<String>>]: An array of ObjectIDs identifying the default device groups for this specific type (based on the OS family) of automated device enrollment. Currently, only a single DeviceGroupID is supported.
  [IoEnableZeroTouchEnrollment <Boolean?>]: A toggle to determine if ADE registered devices should go through JumpCloud Zero Touch Enrollment.
  [IoSetupAssistantOptions <List<IDepSetupAssistantOption>>]: A Setup Option wrapped as an object
  [IoSetupOptions <List<String>>]: A list of configured setup options for this enrollment.
  [IosWelcomeScreenButton <String>]: Text to display on the button on the DEP Welcome Screen.
  [IosWelcomeScreenParagraph <String>]: A message to display on the DEP Welcome Screen.
  [IosWelcomeScreenTitle <String>]: The title to display on the DEP Welcome Screen.
  [MacoDefaultDeviceGroupObjectIds <List<String>>]: An array of ObjectIDs identifying the default device groups for this specific type (based on the OS family) of automated device enrollment. Currently, only a single DeviceGroupID is supported.
  [MacoEnableZeroTouchEnrollment <Boolean?>]: A toggle to determine if ADE registered devices should go through JumpCloud Zero Touch Enrollment.
  [MacoSetupAssistantOptions <List<IDepSetupAssistantOption>>]: A Setup Option wrapped as an object
  [MacoSetupOptions <List<String>>]: A list of configured setup options for this enrollment.
  [MacosWelcomeScreenButton <String>]: Text to display on the button on the DEP Welcome Screen.
  [MacosWelcomeScreenParagraph <String>]: A message to display on the DEP Welcome Screen.
  [MacosWelcomeScreenTitle <String>]: The title to display on the DEP Welcome Screen.
  [Name <String>]: A new name for the Apple MDM configuration.
  [WelcomeScreenButton <String>]: Text to display on the button on the DEP Welcome Screen.
  [WelcomeScreenParagraph <String>]: A message to display on the DEP Welcome Screen.
  [WelcomeScreenTitle <String>]: The title to display on the DEP Welcome Screen.

DEPSETUPASSISTANTOPTIONS <IDepSetupAssistantOption[]>:
  [Option <String>]: Options to skip screens during MacOS and iOS setup:         * `accessibility` - Skips the Accessibility pane, only if the Mac is connected to Ethernet and the cloud config is downloaded.         * `actionButton` - Skips the Action Button configuration pane.         * `appearance` - Skips the Choose Your Look screen.         * `appleID` - Skips Apple ID setup.         * `biometric` - Skips biometric setup.         *  `cameraButton` - Skips the Camera Button configuration pane.         * `diagnostics` - Skips the App Analytics pane.         * `displayTone` - Skips display tone setup.         * `enableLockdownMode` - Skips the Lockdown Mode pane.         * `fileVault` - Skips FileVault setup assistant screen.         * `icloudDiagnostics` - Skips iCloud analytics screen.         * `icloudStorage` - Skips iCloud documents and desktop screen.         * `intelligence` - Skips the Intelligence pane.         * `location` - Skips location services setup.         * `payment` - Skips Apple Pay setup.         * `privacy` - Skips the Privacy setup.         * `restore` - Skips restoring from backup.         * `screenTime` - Skips screen time setup.         * `siri` - Skips Siri setup.         * `termsOfAddress` - Skips the Terms of Address pane.         * `tos` - Skips terms and conditions.         * `appStore` - Skips the App Store pane.         * `deviceToDeviceMigration` - Skips Device to Device Migration pane.         * `displayZoom` - Skips zoom setup.         * `homeButton` - Skips the Meet the New Home Button screen on iPhone 7, iPhone 7 Plus, iPhone 8, iPhone 8 Plus and iPhone SE.         * `imessageAndFacetime` - Skips the iMessage and FaceTime screen in iOS.         * `messagingActivationUsingPhoneNumber` - Skips the iMessage pane.         * `moveFromAndroid` - If the Restore pane is not skipped, removes the Move from Android option in the Restore pane on iOS.O         * `passcode` - Hides and disables the passcode pane.         * `restoreComplete` - Skips the Restore Completed pane.         * `safety` - Skips the Safety pane.         * `setupCellular` - Skips the add cellular plan pane.         * `softwareUpdate` - Skips the mandatory software update screen in iOS.         * `unlockWithWatch` - Skips Unlock Your Mac with your Apple Watch pane.         * `updateComplete` - Skips the Software Update Complete pane.         * `wallpaper` - Skips the Wallpaper setup.         * `watchMigration` - Skips the screen for watch migration.         * `welcome` - Skips the Get Started pane.         * `additionalPrivacySettings` - Skips the Additional Privacy Settings pane.         * `multitasking` - Skips the Multitasking pane.         * `osShowcase` - Skips the OS Showcase pane.         * `webContentFiltering` - Skips the Web Content Filtering pane.         * `safetyAndHandling` - Skips the Safety and Handling pane.        

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
  [Option <String>]: Options to skip screens during MacOS and iOS setup:         * `accessibility` - Skips the Accessibility pane, only if the Mac is connected to Ethernet and the cloud config is downloaded.         * `actionButton` - Skips the Action Button configuration pane.         * `appearance` - Skips the Choose Your Look screen.         * `appleID` - Skips Apple ID setup.         * `biometric` - Skips biometric setup.         *  `cameraButton` - Skips the Camera Button configuration pane.         * `diagnostics` - Skips the App Analytics pane.         * `displayTone` - Skips display tone setup.         * `enableLockdownMode` - Skips the Lockdown Mode pane.         * `fileVault` - Skips FileVault setup assistant screen.         * `icloudDiagnostics` - Skips iCloud analytics screen.         * `icloudStorage` - Skips iCloud documents and desktop screen.         * `intelligence` - Skips the Intelligence pane.         * `location` - Skips location services setup.         * `payment` - Skips Apple Pay setup.         * `privacy` - Skips the Privacy setup.         * `restore` - Skips restoring from backup.         * `screenTime` - Skips screen time setup.         * `siri` - Skips Siri setup.         * `termsOfAddress` - Skips the Terms of Address pane.         * `tos` - Skips terms and conditions.         * `appStore` - Skips the App Store pane.         * `deviceToDeviceMigration` - Skips Device to Device Migration pane.         * `displayZoom` - Skips zoom setup.         * `homeButton` - Skips the Meet the New Home Button screen on iPhone 7, iPhone 7 Plus, iPhone 8, iPhone 8 Plus and iPhone SE.         * `imessageAndFacetime` - Skips the iMessage and FaceTime screen in iOS.         * `messagingActivationUsingPhoneNumber` - Skips the iMessage pane.         * `moveFromAndroid` - If the Restore pane is not skipped, removes the Move from Android option in the Restore pane on iOS.O         * `passcode` - Hides and disables the passcode pane.         * `restoreComplete` - Skips the Restore Completed pane.         * `safety` - Skips the Safety pane.         * `setupCellular` - Skips the add cellular plan pane.         * `softwareUpdate` - Skips the mandatory software update screen in iOS.         * `unlockWithWatch` - Skips Unlock Your Mac with your Apple Watch pane.         * `updateComplete` - Skips the Software Update Complete pane.         * `wallpaper` - Skips the Wallpaper setup.         * `watchMigration` - Skips the screen for watch migration.         * `welcome` - Skips the Get Started pane.         * `additionalPrivacySettings` - Skips the Additional Privacy Settings pane.         * `multitasking` - Skips the Multitasking pane.         * `osShowcase` - Skips the OS Showcase pane.         * `webContentFiltering` - Skips the Web Content Filtering pane.         * `safetyAndHandling` - Skips the Safety and Handling pane.        

MACOSETUPASSISTANTOPTIONS <IDepSetupAssistantOption[]>:
  [Option <String>]: Options to skip screens during MacOS and iOS setup:         * `accessibility` - Skips the Accessibility pane, only if the Mac is connected to Ethernet and the cloud config is downloaded.         * `actionButton` - Skips the Action Button configuration pane.         * `appearance` - Skips the Choose Your Look screen.         * `appleID` - Skips Apple ID setup.         * `biometric` - Skips biometric setup.         *  `cameraButton` - Skips the Camera Button configuration pane.         * `diagnostics` - Skips the App Analytics pane.         * `displayTone` - Skips display tone setup.         * `enableLockdownMode` - Skips the Lockdown Mode pane.         * `fileVault` - Skips FileVault setup assistant screen.         * `icloudDiagnostics` - Skips iCloud analytics screen.         * `icloudStorage` - Skips iCloud documents and desktop screen.         * `intelligence` - Skips the Intelligence pane.         * `location` - Skips location services setup.         * `payment` - Skips Apple Pay setup.         * `privacy` - Skips the Privacy setup.         * `restore` - Skips restoring from backup.         * `screenTime` - Skips screen time setup.         * `siri` - Skips Siri setup.         * `termsOfAddress` - Skips the Terms of Address pane.         * `tos` - Skips terms and conditions.         * `appStore` - Skips the App Store pane.         * `deviceToDeviceMigration` - Skips Device to Device Migration pane.         * `displayZoom` - Skips zoom setup.         * `homeButton` - Skips the Meet the New Home Button screen on iPhone 7, iPhone 7 Plus, iPhone 8, iPhone 8 Plus and iPhone SE.         * `imessageAndFacetime` - Skips the iMessage and FaceTime screen in iOS.         * `messagingActivationUsingPhoneNumber` - Skips the iMessage pane.         * `moveFromAndroid` - If the Restore pane is not skipped, removes the Move from Android option in the Restore pane on iOS.O         * `passcode` - Hides and disables the passcode pane.         * `restoreComplete` - Skips the Restore Completed pane.         * `safety` - Skips the Safety pane.         * `setupCellular` - Skips the add cellular plan pane.         * `softwareUpdate` - Skips the mandatory software update screen in iOS.         * `unlockWithWatch` - Skips Unlock Your Mac with your Apple Watch pane.         * `updateComplete` - Skips the Software Update Complete pane.         * `wallpaper` - Skips the Wallpaper setup.         * `watchMigration` - Skips the screen for watch migration.         * `welcome` - Skips the Get Started pane.         * `additionalPrivacySettings` - Skips the Additional Privacy Settings pane.         * `multitasking` - Skips the Multitasking pane.         * `osShowcase` - Skips the OS Showcase pane.         * `webContentFiltering` - Skips the Web Content Filtering pane.         * `safetyAndHandling` - Skips the Safety and Handling pane.        
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/CUT-4908_userGroupDeviceGroupFilters/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Set-JcSdkAppleMdm.md
#>
 Function Set-JcSdkAppleMdm
{
    [OutputType([JumpCloud.SDK.V2.Models.IAppleMdm])]
    [CmdletBinding(DefaultParameterSetName='SetExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
    [Parameter(Mandatory)]
    [JumpCloud.SDK.V2.Category('Uri')]
    [System.String]
    # Region for JumpCloud API host.
    # Use 'console' for US or 'console.eu' for EU.
    ${HostEnv}, 

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
    ${InputObject}, 

    [Parameter(ParameterSetName='Set', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='SetViaIdentity', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V2.Category('Body')]
    [JumpCloud.SDK.V2.Models.IAppleMdmPatch]
    # Apple MDM Patch
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
    # A Setup Option wrapped as an object
    ${IoSetupAssistantOptions}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [AllowEmptyCollection()]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String[]]
    # A list of configured setup options for this enrollment.
    ${IoSetupOptions}, 

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
    # A Setup Option wrapped as an object
    ${MacoSetupAssistantOptions}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [AllowEmptyCollection()]
    [JumpCloud.SDK.V2.Category('Body')]
    [System.String[]]
    # A list of configured setup options for this enrollment.
    ${MacoSetupOptions}, 

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
        $maxRetries = 4
        $resultCounter = 0
        :retryLoop do {
            $resultCounter++
            $Results = JumpCloud.SDK.V2.internal\Set-JcSdkInternalAppleMdm @PSBoundParameters -errorAction SilentlyContinue -errorVariable sdkError
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


