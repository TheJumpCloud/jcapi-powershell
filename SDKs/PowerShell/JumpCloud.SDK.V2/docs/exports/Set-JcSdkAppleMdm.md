---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Set-JcSdkAppleMdm.md
schema: 2.0.0
---

# Set-JcSdkAppleMdm

## SYNOPSIS
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

## SYNTAX

### SetExpanded (Default)
```
Set-JcSdkAppleMdm -ConsoleHost <String> -Id <String> [-AllowMobileUserEnrollment]
 [-AppleCertCreatorAppleId <String>] [-AppleSignedCert <String>]
 [-DefaultIosUserEnrollmentDeviceGroupId <String>] [-DefaultSystemGroupId <String>]
 [-DepEnableZeroTouchEnrollment] [-DepSetupAssistantOptions <IDepSetupAssistantOption[]>]
 [-EncryptedDepServerToken <String>] [-IoDefaultDeviceGroupObjectIds <String[]>]
 [-IoEnableZeroTouchEnrollment] [-IoSetupAssistantOptions <IDepSetupAssistantOption[]>]
 [-IoSetupOptions <String[]>] [-IosWelcomeScreenButton <String>] [-IosWelcomeScreenParagraph <String>]
 [-IosWelcomeScreenTitle <String>] [-MacoDefaultDeviceGroupObjectIds <String[]>]
 [-MacoEnableZeroTouchEnrollment] [-MacoSetupAssistantOptions <IDepSetupAssistantOption[]>]
 [-MacoSetupOptions <String[]>] [-MacosWelcomeScreenButton <String>] [-MacosWelcomeScreenParagraph <String>]
 [-MacosWelcomeScreenTitle <String>] [-Name <String>] [-WelcomeScreenButton <String>]
 [-WelcomeScreenParagraph <String>] [-WelcomeScreenTitle <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Set
```
Set-JcSdkAppleMdm -ConsoleHost <String> -Id <String> -Body <IAppleMdmPatch> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### SetViaIdentity
```
Set-JcSdkAppleMdm -ConsoleHost <String> -InputObject <IJumpCloudApiIdentity> -Body <IAppleMdmPatch> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### SetViaIdentityExpanded
```
Set-JcSdkAppleMdm -ConsoleHost <String> -InputObject <IJumpCloudApiIdentity> [-AllowMobileUserEnrollment]
 [-AppleCertCreatorAppleId <String>] [-AppleSignedCert <String>]
 [-DefaultIosUserEnrollmentDeviceGroupId <String>] [-DefaultSystemGroupId <String>]
 [-DepEnableZeroTouchEnrollment] [-DepSetupAssistantOptions <IDepSetupAssistantOption[]>]
 [-EncryptedDepServerToken <String>] [-IoDefaultDeviceGroupObjectIds <String[]>]
 [-IoEnableZeroTouchEnrollment] [-IoSetupAssistantOptions <IDepSetupAssistantOption[]>]
 [-IoSetupOptions <String[]>] [-IosWelcomeScreenButton <String>] [-IosWelcomeScreenParagraph <String>]
 [-IosWelcomeScreenTitle <String>] [-MacoDefaultDeviceGroupObjectIds <String[]>]
 [-MacoEnableZeroTouchEnrollment] [-MacoSetupAssistantOptions <IDepSetupAssistantOption[]>]
 [-MacoSetupOptions <String[]>] [-MacosWelcomeScreenButton <String>] [-MacosWelcomeScreenParagraph <String>]
 [-MacosWelcomeScreenTitle <String>] [-Name <String>] [-WelcomeScreenButton <String>]
 [-WelcomeScreenParagraph <String>] [-WelcomeScreenTitle <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
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

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Set-JcSdkAppleMdm -Id:(<string>) -Body:(<JumpCloud.SDK.V2.Models.AppleMdmPatch>)
```

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

### -------------------------- EXAMPLE 2 --------------------------
```powershell
Set-JcSdkAppleMdm -Id:(<string>) -AllowMobileUserEnrollment:(<switch>) -AppleCertCreatorAppleId:(<string>) -AppleSignedCert:(<string>) -DefaultIosUserEnrollmentDeviceGroupId:(<string>) -DefaultSystemGroupId:(<string>) -DepEnableZeroTouchEnrollment:(<switch>) -DepSetupAssistantOptions:(<JumpCloud.SDK.V2.Models.DepSetupAssistantOption[]>) -EncryptedDepServerToken:(<string>) -IoDefaultDeviceGroupObjectIds:(<string[]>) -IoEnableZeroTouchEnrollment:(<switch>) -IoSetupAssistantOptions:(<JumpCloud.SDK.V2.Models.DepSetupAssistantOption[]>) -IoSetupOptions:(<string[]>) -IosWelcomeScreenButton:(<string>) -IosWelcomeScreenParagraph:(<string>) -IosWelcomeScreenTitle:(<string>) -MacoDefaultDeviceGroupObjectIds:(<string[]>) -MacoEnableZeroTouchEnrollment:(<switch>) -MacoSetupAssistantOptions:(<JumpCloud.SDK.V2.Models.DepSetupAssistantOption[]>) -MacoSetupOptions:(<string[]>) -MacosWelcomeScreenButton:(<string>) -MacosWelcomeScreenParagraph:(<string>) -MacosWelcomeScreenTitle:(<string>) -Name:(<string>) -WelcomeScreenButton:(<string>) -WelcomeScreenParagraph:(<string>) -WelcomeScreenTitle:(<string>)
```

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

## PARAMETERS

### -AllowMobileUserEnrollment
A toggle to allow mobile device enrollment for an organization.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AppleCertCreatorAppleId
The Apple ID of the admin who created the Apple signed certificate.

```yaml
Type: System.String
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AppleSignedCert
A signed certificate obtained from Apple after providing Apple with the plist file provided on POST.

```yaml
Type: System.String
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Body
Apple MDM Patch

```yaml
Type: JumpCloud.SDK.V2.Models.IAppleMdmPatch
Parameter Sets: Set, SetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ConsoleHost
Region for JumpCloud API host.
Use 'console' for US or 'console.eu' for EU.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultIosUserEnrollmentDeviceGroupId
ObjectId uniquely identifying the MDM default iOS user enrollment device group.

```yaml
Type: System.String
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultSystemGroupId
ObjectId uniquely identifying the MDM default System Group.

```yaml
Type: System.String
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DepEnableZeroTouchEnrollment
A toggle to determine if DEP registered devices should go through JumpCloud Zero Touch Enrollment.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DepSetupAssistantOptions
.

```yaml
Type: JumpCloud.SDK.V2.Models.IDepSetupAssistantOption[]
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EncryptedDepServerToken
The S/MIME encoded DEP Server Token returned by Apple Business Manager when creating an MDM instance.

```yaml
Type: System.String
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
.

```yaml
Type: System.String
Parameter Sets: Set, SetExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter

```yaml
Type: JumpCloud.SDK.V2.Models.IJumpCloudApiIdentity
Parameter Sets: SetViaIdentity, SetViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IoDefaultDeviceGroupObjectIds
An array of ObjectIDs identifying the default device groups for this specific type (based on the OS family) of automated device enrollment.
Currently, only a single DeviceGroupID is supported.

```yaml
Type: System.String[]
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IoEnableZeroTouchEnrollment
A toggle to determine if ADE registered devices should go through JumpCloud Zero Touch Enrollment.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IoSetupAssistantOptions
A Setup Option wrapped as an object

```yaml
Type: JumpCloud.SDK.V2.Models.IDepSetupAssistantOption[]
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IoSetupOptions
A list of configured setup options for this enrollment.

```yaml
Type: System.String[]
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IosWelcomeScreenButton
Text to display on the button on the DEP Welcome Screen.

```yaml
Type: System.String
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IosWelcomeScreenParagraph
A message to display on the DEP Welcome Screen.

```yaml
Type: System.String
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IosWelcomeScreenTitle
The title to display on the DEP Welcome Screen.

```yaml
Type: System.String
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MacoDefaultDeviceGroupObjectIds
An array of ObjectIDs identifying the default device groups for this specific type (based on the OS family) of automated device enrollment.
Currently, only a single DeviceGroupID is supported.

```yaml
Type: System.String[]
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MacoEnableZeroTouchEnrollment
A toggle to determine if ADE registered devices should go through JumpCloud Zero Touch Enrollment.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MacoSetupAssistantOptions
A Setup Option wrapped as an object

```yaml
Type: JumpCloud.SDK.V2.Models.IDepSetupAssistantOption[]
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MacoSetupOptions
A list of configured setup options for this enrollment.

```yaml
Type: System.String[]
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MacosWelcomeScreenButton
Text to display on the button on the DEP Welcome Screen.

```yaml
Type: System.String
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MacosWelcomeScreenParagraph
A message to display on the DEP Welcome Screen.

```yaml
Type: System.String
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MacosWelcomeScreenTitle
The title to display on the DEP Welcome Screen.

```yaml
Type: System.String
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
A new name for the Apple MDM configuration.

```yaml
Type: System.String
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WelcomeScreenButton
Text to display on the button on the DEP Welcome Screen.

```yaml
Type: System.String
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WelcomeScreenParagraph
A message to display on the DEP Welcome Screen.

```yaml
Type: System.String
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WelcomeScreenTitle
The title to display on the DEP Welcome Screen.

```yaml
Type: System.String
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### JumpCloud.SDK.V2.Models.IAppleMdmPatch

### JumpCloud.SDK.V2.Models.IJumpCloudApiIdentity

## OUTPUTS

### JumpCloud.SDK.V2.Models.IAppleMdm

## NOTES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODY <IAppleMdmPatch>`: Apple MDM Patch
  - `[AllowMobileUserEnrollment <Boolean?>]`: A toggle to allow mobile device enrollment for an organization.
  - `[AppleCertCreatorAppleId <String>]`: The Apple ID of the admin who created the Apple signed certificate.
  - `[AppleSignedCert <String>]`: A signed certificate obtained from Apple after providing Apple with the plist file provided on POST.
  - `[DefaultIosUserEnrollmentDeviceGroupId <String>]`: ObjectId uniquely identifying the MDM default iOS user enrollment device group.
  - `[DefaultSystemGroupId <String>]`: ObjectId uniquely identifying the MDM default System Group.
  - `[DepEnableZeroTouchEnrollment <Boolean?>]`: A toggle to determine if DEP registered devices should go through JumpCloud Zero Touch Enrollment.
  - `[DepSetupAssistantOptions <List<IDepSetupAssistantOption>>]`: 
    - `[Option <String>]`: Options to skip screens during MacOS and iOS setup:         * `accessibility` - Skips the Accessibility pane, only if the Mac is connected to Ethernet and the cloud config is downloaded.         * `actionButton` - Skips the Action Button configuration pane.         * `appearance` - Skips the Choose Your Look screen.         * `appleID` - Skips Apple ID setup.         * `biometric` - Skips biometric setup.         *  `cameraButton` - Skips the Camera Button configuration pane.         * `diagnostics` - Skips the App Analytics pane.         * `displayTone` - Skips display tone setup.         * `enableLockdownMode` - Skips the Lockdown Mode pane.         * `fileVault` - Skips FileVault setup assistant screen.         * `icloudDiagnostics` - Skips iCloud analytics screen.         * `icloudStorage` - Skips iCloud documents and desktop screen.         * `intelligence` - Skips the Intelligence pane.         * `location` - Skips location services setup.         * `payment` - Skips Apple Pay setup.         * `privacy` - Skips the Privacy setup.         * `restore` - Skips restoring from backup.         * `screenTime` - Skips screen time setup.         * `siri` - Skips Siri setup.         * `termsOfAddress` - Skips the Terms of Address pane.         * `tos` - Skips terms and conditions.         * `appStore` - Skips the App Store pane.         * `deviceToDeviceMigration` - Skips Device to Device Migration pane.         * `displayZoom` - Skips zoom setup.         * `homeButton` - Skips the Meet the New Home Button screen on iPhone 7, iPhone 7 Plus, iPhone 8, iPhone 8 Plus and iPhone SE.         * `imessageAndFacetime` - Skips the iMessage and FaceTime screen in iOS.         * `messagingActivationUsingPhoneNumber` - Skips the iMessage pane.         * `moveFromAndroid` - If the Restore pane is not skipped, removes the Move from Android option in the Restore pane on iOS.O         * `passcode` - Hides and disables the passcode pane.         * `restoreComplete` - Skips the Restore Completed pane.         * `safety` - Skips the Safety pane.         * `setupCellular` - Skips the add cellular plan pane.         * `softwareUpdate` - Skips the mandatory software update screen in iOS.         * `unlockWithWatch` - Skips Unlock Your Mac with your Apple Watch pane.         * `updateComplete` - Skips the Software Update Complete pane.         * `wallpaper` - Skips the Wallpaper setup.         * `watchMigration` - Skips the screen for watch migration.         * `welcome` - Skips the Get Started pane.         * `additionalPrivacySettings` - Skips the Additional Privacy Settings pane.         * `multitasking` - Skips the Multitasking pane.         * `osShowcase` - Skips the OS Showcase pane.         * `webContentFiltering` - Skips the Web Content Filtering pane.         * `safetyAndHandling` - Skips the Safety and Handling pane.         
  - `[EncryptedDepServerToken <String>]`: The S/MIME encoded DEP Server Token returned by Apple Business Manager when creating an MDM instance.
  - `[IoDefaultDeviceGroupObjectIds <List<String>>]`: An array of ObjectIDs identifying the default device groups for this specific type (based on the OS family) of automated device enrollment. Currently, only a single DeviceGroupID is supported.
  - `[IoEnableZeroTouchEnrollment <Boolean?>]`: A toggle to determine if ADE registered devices should go through JumpCloud Zero Touch Enrollment.
  - `[IoSetupAssistantOptions <List<IDepSetupAssistantOption>>]`: A Setup Option wrapped as an object
  - `[IoSetupOptions <List<String>>]`: A list of configured setup options for this enrollment.
  - `[IosWelcomeScreenButton <String>]`: Text to display on the button on the DEP Welcome Screen.
  - `[IosWelcomeScreenParagraph <String>]`: A message to display on the DEP Welcome Screen.
  - `[IosWelcomeScreenTitle <String>]`: The title to display on the DEP Welcome Screen.
  - `[MacoDefaultDeviceGroupObjectIds <List<String>>]`: An array of ObjectIDs identifying the default device groups for this specific type (based on the OS family) of automated device enrollment. Currently, only a single DeviceGroupID is supported.
  - `[MacoEnableZeroTouchEnrollment <Boolean?>]`: A toggle to determine if ADE registered devices should go through JumpCloud Zero Touch Enrollment.
  - `[MacoSetupAssistantOptions <List<IDepSetupAssistantOption>>]`: A Setup Option wrapped as an object
  - `[MacoSetupOptions <List<String>>]`: A list of configured setup options for this enrollment.
  - `[MacosWelcomeScreenButton <String>]`: Text to display on the button on the DEP Welcome Screen.
  - `[MacosWelcomeScreenParagraph <String>]`: A message to display on the DEP Welcome Screen.
  - `[MacosWelcomeScreenTitle <String>]`: The title to display on the DEP Welcome Screen.
  - `[Name <String>]`: A new name for the Apple MDM configuration.
  - `[WelcomeScreenButton <String>]`: Text to display on the button on the DEP Welcome Screen.
  - `[WelcomeScreenParagraph <String>]`: A message to display on the DEP Welcome Screen.
  - `[WelcomeScreenTitle <String>]`: The title to display on the DEP Welcome Screen.

`DEPSETUPASSISTANTOPTIONS <IDepSetupAssistantOption[]>`: .
  - `[Option <String>]`: Options to skip screens during MacOS and iOS setup:         * `accessibility` - Skips the Accessibility pane, only if the Mac is connected to Ethernet and the cloud config is downloaded.         * `actionButton` - Skips the Action Button configuration pane.         * `appearance` - Skips the Choose Your Look screen.         * `appleID` - Skips Apple ID setup.         * `biometric` - Skips biometric setup.         *  `cameraButton` - Skips the Camera Button configuration pane.         * `diagnostics` - Skips the App Analytics pane.         * `displayTone` - Skips display tone setup.         * `enableLockdownMode` - Skips the Lockdown Mode pane.         * `fileVault` - Skips FileVault setup assistant screen.         * `icloudDiagnostics` - Skips iCloud analytics screen.         * `icloudStorage` - Skips iCloud documents and desktop screen.         * `intelligence` - Skips the Intelligence pane.         * `location` - Skips location services setup.         * `payment` - Skips Apple Pay setup.         * `privacy` - Skips the Privacy setup.         * `restore` - Skips restoring from backup.         * `screenTime` - Skips screen time setup.         * `siri` - Skips Siri setup.         * `termsOfAddress` - Skips the Terms of Address pane.         * `tos` - Skips terms and conditions.         * `appStore` - Skips the App Store pane.         * `deviceToDeviceMigration` - Skips Device to Device Migration pane.         * `displayZoom` - Skips zoom setup.         * `homeButton` - Skips the Meet the New Home Button screen on iPhone 7, iPhone 7 Plus, iPhone 8, iPhone 8 Plus and iPhone SE.         * `imessageAndFacetime` - Skips the iMessage and FaceTime screen in iOS.         * `messagingActivationUsingPhoneNumber` - Skips the iMessage pane.         * `moveFromAndroid` - If the Restore pane is not skipped, removes the Move from Android option in the Restore pane on iOS.O         * `passcode` - Hides and disables the passcode pane.         * `restoreComplete` - Skips the Restore Completed pane.         * `safety` - Skips the Safety pane.         * `setupCellular` - Skips the add cellular plan pane.         * `softwareUpdate` - Skips the mandatory software update screen in iOS.         * `unlockWithWatch` - Skips Unlock Your Mac with your Apple Watch pane.         * `updateComplete` - Skips the Software Update Complete pane.         * `wallpaper` - Skips the Wallpaper setup.         * `watchMigration` - Skips the screen for watch migration.         * `welcome` - Skips the Get Started pane.         * `additionalPrivacySettings` - Skips the Additional Privacy Settings pane.         * `multitasking` - Skips the Multitasking pane.         * `osShowcase` - Skips the OS Showcase pane.         * `webContentFiltering` - Skips the Web Content Filtering pane.         * `safetyAndHandling` - Skips the Safety and Handling pane.         

`INPUTOBJECT <IJumpCloudApiIdentity>`: Identity Parameter
  - `[AccountId <String>]`: 
  - `[ActivedirectoryId <String>]`: 
  - `[AdministratorId <String>]`: 
  - `[AgentId <String>]`: 
  - `[AppleMdmId <String>]`: 
  - `[ApplicationId <String>]`: ObjectID of the Application.
  - `[CommandId <String>]`: ObjectID of the Command.
  - `[CustomEmailType <String>]`: 
  - `[DeviceId <String>]`: 
  - `[GroupId <String>]`: ObjectID of the Policy Group.
  - `[GsuiteId <String>]`: ObjectID of the G Suite instance.
  - `[Id <String>]`: ObjectID of this Active Directory instance.
  - `[JobId <String>]`: 
  - `[LdapserverId <String>]`: ObjectID of the LDAP Server.
  - `[Office365Id <String>]`: ObjectID of the Office 365 instance.
  - `[PolicyId <String>]`: ObjectID of the Policy.
  - `[ProviderId <String>]`: 
  - `[PushEndpointId <String>]`: 
  - `[RadiusserverId <String>]`: ObjectID of the Radius Server.
  - `[SoftwareAppId <String>]`: ObjectID of the Software App.
  - `[SystemId <String>]`: ObjectID of the System.
  - `[UserId <String>]`: ObjectID of the User.
  - `[WorkdayId <String>]`: 

`IOSETUPASSISTANTOPTIONS <IDepSetupAssistantOption[]>`: A Setup Option wrapped as an object
  - `[Option <String>]`: Options to skip screens during MacOS and iOS setup:         * `accessibility` - Skips the Accessibility pane, only if the Mac is connected to Ethernet and the cloud config is downloaded.         * `actionButton` - Skips the Action Button configuration pane.         * `appearance` - Skips the Choose Your Look screen.         * `appleID` - Skips Apple ID setup.         * `biometric` - Skips biometric setup.         *  `cameraButton` - Skips the Camera Button configuration pane.         * `diagnostics` - Skips the App Analytics pane.         * `displayTone` - Skips display tone setup.         * `enableLockdownMode` - Skips the Lockdown Mode pane.         * `fileVault` - Skips FileVault setup assistant screen.         * `icloudDiagnostics` - Skips iCloud analytics screen.         * `icloudStorage` - Skips iCloud documents and desktop screen.         * `intelligence` - Skips the Intelligence pane.         * `location` - Skips location services setup.         * `payment` - Skips Apple Pay setup.         * `privacy` - Skips the Privacy setup.         * `restore` - Skips restoring from backup.         * `screenTime` - Skips screen time setup.         * `siri` - Skips Siri setup.         * `termsOfAddress` - Skips the Terms of Address pane.         * `tos` - Skips terms and conditions.         * `appStore` - Skips the App Store pane.         * `deviceToDeviceMigration` - Skips Device to Device Migration pane.         * `displayZoom` - Skips zoom setup.         * `homeButton` - Skips the Meet the New Home Button screen on iPhone 7, iPhone 7 Plus, iPhone 8, iPhone 8 Plus and iPhone SE.         * `imessageAndFacetime` - Skips the iMessage and FaceTime screen in iOS.         * `messagingActivationUsingPhoneNumber` - Skips the iMessage pane.         * `moveFromAndroid` - If the Restore pane is not skipped, removes the Move from Android option in the Restore pane on iOS.O         * `passcode` - Hides and disables the passcode pane.         * `restoreComplete` - Skips the Restore Completed pane.         * `safety` - Skips the Safety pane.         * `setupCellular` - Skips the add cellular plan pane.         * `softwareUpdate` - Skips the mandatory software update screen in iOS.         * `unlockWithWatch` - Skips Unlock Your Mac with your Apple Watch pane.         * `updateComplete` - Skips the Software Update Complete pane.         * `wallpaper` - Skips the Wallpaper setup.         * `watchMigration` - Skips the screen for watch migration.         * `welcome` - Skips the Get Started pane.         * `additionalPrivacySettings` - Skips the Additional Privacy Settings pane.         * `multitasking` - Skips the Multitasking pane.         * `osShowcase` - Skips the OS Showcase pane.         * `webContentFiltering` - Skips the Web Content Filtering pane.         * `safetyAndHandling` - Skips the Safety and Handling pane.         

`MACOSETUPASSISTANTOPTIONS <IDepSetupAssistantOption[]>`: A Setup Option wrapped as an object
  - `[Option <String>]`: Options to skip screens during MacOS and iOS setup:         * `accessibility` - Skips the Accessibility pane, only if the Mac is connected to Ethernet and the cloud config is downloaded.         * `actionButton` - Skips the Action Button configuration pane.         * `appearance` - Skips the Choose Your Look screen.         * `appleID` - Skips Apple ID setup.         * `biometric` - Skips biometric setup.         *  `cameraButton` - Skips the Camera Button configuration pane.         * `diagnostics` - Skips the App Analytics pane.         * `displayTone` - Skips display tone setup.         * `enableLockdownMode` - Skips the Lockdown Mode pane.         * `fileVault` - Skips FileVault setup assistant screen.         * `icloudDiagnostics` - Skips iCloud analytics screen.         * `icloudStorage` - Skips iCloud documents and desktop screen.         * `intelligence` - Skips the Intelligence pane.         * `location` - Skips location services setup.         * `payment` - Skips Apple Pay setup.         * `privacy` - Skips the Privacy setup.         * `restore` - Skips restoring from backup.         * `screenTime` - Skips screen time setup.         * `siri` - Skips Siri setup.         * `termsOfAddress` - Skips the Terms of Address pane.         * `tos` - Skips terms and conditions.         * `appStore` - Skips the App Store pane.         * `deviceToDeviceMigration` - Skips Device to Device Migration pane.         * `displayZoom` - Skips zoom setup.         * `homeButton` - Skips the Meet the New Home Button screen on iPhone 7, iPhone 7 Plus, iPhone 8, iPhone 8 Plus and iPhone SE.         * `imessageAndFacetime` - Skips the iMessage and FaceTime screen in iOS.         * `messagingActivationUsingPhoneNumber` - Skips the iMessage pane.         * `moveFromAndroid` - If the Restore pane is not skipped, removes the Move from Android option in the Restore pane on iOS.O         * `passcode` - Hides and disables the passcode pane.         * `restoreComplete` - Skips the Restore Completed pane.         * `safety` - Skips the Safety pane.         * `setupCellular` - Skips the add cellular plan pane.         * `softwareUpdate` - Skips the mandatory software update screen in iOS.         * `unlockWithWatch` - Skips Unlock Your Mac with your Apple Watch pane.         * `updateComplete` - Skips the Software Update Complete pane.         * `wallpaper` - Skips the Wallpaper setup.         * `watchMigration` - Skips the screen for watch migration.         * `welcome` - Skips the Get Started pane.         * `additionalPrivacySettings` - Skips the Additional Privacy Settings pane.         * `multitasking` - Skips the Multitasking pane.         * `osShowcase` - Skips the OS Showcase pane.         * `webContentFiltering` - Skips the Web Content Filtering pane.         * `safetyAndHandling` - Skips the Safety and Handling pane.         

## RELATED LINKS

