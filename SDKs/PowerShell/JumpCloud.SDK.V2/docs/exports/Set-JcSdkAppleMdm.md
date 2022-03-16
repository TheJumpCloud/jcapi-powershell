---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Set-JcSdkAppleMdm.md
schema: 2.0.0
---

# Set-JcSdkAppleMdm

## SYNOPSIS
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

## SYNTAX

### SetExpanded (Default)
```
Set-JcSdkAppleMdm -Id <String> [-AllowMobileUserEnrollment] [-AppleSignedCert <String>]
 [-DefaultIosUserEnrollmentDeviceGroupId <String>] [-DefaultSystemGroupId <String>]
 [-DepEnableZeroTouchEnrollment] [-DepSetupAssistantOptions <IDepSetupAssistantOption[]>]
 [-EncryptedDepServerToken <String>] [-IoDefaultDeviceGroupObjectIds <String[]>]
 [-IoEnableZeroTouchEnrollment] [-IoSetupAssistantOptions <IDepSetupAssistantOption[]>]
 [-IosWelcomeScreenButton <String>] [-IosWelcomeScreenParagraph <String>] [-IosWelcomeScreenTitle <String>]
 [-MacoDefaultDeviceGroupObjectIds <String[]>] [-MacoEnableZeroTouchEnrollment]
 [-MacoSetupAssistantOptions <IDepSetupAssistantOption[]>] [-MacosWelcomeScreenButton <String>]
 [-MacosWelcomeScreenParagraph <String>] [-MacosWelcomeScreenTitle <String>] [-Name <String>]
 [-WelcomeScreenButton <String>] [-WelcomeScreenParagraph <String>] [-WelcomeScreenTitle <String>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Set
```
Set-JcSdkAppleMdm -Id <String> -Body <IAppleMdmPatchInput> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### SetViaIdentity
```
Set-JcSdkAppleMdm -InputObject <IJumpCloudApiIdentity> -Body <IAppleMdmPatchInput> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### SetViaIdentityExpanded
```
Set-JcSdkAppleMdm -InputObject <IJumpCloudApiIdentity> [-AllowMobileUserEnrollment]
 [-AppleSignedCert <String>] [-DefaultIosUserEnrollmentDeviceGroupId <String>]
 [-DefaultSystemGroupId <String>] [-DepEnableZeroTouchEnrollment]
 [-DepSetupAssistantOptions <IDepSetupAssistantOption[]>] [-EncryptedDepServerToken <String>]
 [-IoDefaultDeviceGroupObjectIds <String[]>] [-IoEnableZeroTouchEnrollment]
 [-IoSetupAssistantOptions <IDepSetupAssistantOption[]>] [-IosWelcomeScreenButton <String>]
 [-IosWelcomeScreenParagraph <String>] [-IosWelcomeScreenTitle <String>]
 [-MacoDefaultDeviceGroupObjectIds <String[]>] [-MacoEnableZeroTouchEnrollment]
 [-MacoSetupAssistantOptions <IDepSetupAssistantOption[]>] [-MacosWelcomeScreenButton <String>]
 [-MacosWelcomeScreenParagraph <String>] [-MacosWelcomeScreenTitle <String>] [-Name <String>]
 [-WelcomeScreenButton <String>] [-WelcomeScreenParagraph <String>] [-WelcomeScreenTitle <String>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
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

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

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
Apple MDM Patch Input
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: JumpCloud.SDK.V2.Models.IAppleMdmPatchInput
Parameter Sets: Set, SetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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
To construct, see NOTES section for DEPSETUPASSISTANTOPTIONS properties and create a hash table.

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
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

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
.
To construct, see NOTES section for IOSETUPASSISTANTOPTIONS properties and create a hash table.

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
.
To construct, see NOTES section for MACOSETUPASSISTANTOPTIONS properties and create a hash table.

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

### JumpCloud.SDK.V2.Models.IAppleMdmPatchInput

### JumpCloud.SDK.V2.Models.IJumpCloudApiIdentity

## OUTPUTS

### JumpCloud.SDK.V2.Models.IAppleMdm

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODY <IAppleMdmPatchInput>: Apple MDM Patch Input
  - `[AllowMobileUserEnrollment <Boolean?>]`: A toggle to allow mobile device enrollment for an organization.
  - `[AppleSignedCert <String>]`: A signed certificate obtained from Apple after providing Apple with the plist file provided on POST.
  - `[DefaultIosUserEnrollmentDeviceGroupId <String>]`: ObjectId uniquely identifying the MDM default iOS user enrollment device group.
  - `[DefaultSystemGroupId <String>]`: ObjectId uniquely identifying the MDM default System Group.
  - `[DepEnableZeroTouchEnrollment <Boolean?>]`: A toggle to determine if DEP registered devices should go through JumpCloud Zero Touch Enrollment.
  - `[DepSetupAssistantOptions <IDepSetupAssistantOption[]>]`: 
    - `[Option <String>]`: Options to skip screens during MacOS and iOS setup:         * `accessibility` - Skips the Accessibility pane, only if the Mac is connected to Ethernet and the cloud config is downloaded.         * `appearance` - Skips the Choose Your Look screen.         * `appleID` - Skips Apple ID setup.         * `biometric` - Skips biometric setup.         * `diagnostics` - Skips the App Analytics pane.         * `displayTone` - Skips display tone setup.         * `fileVault` - Skips FileVault setup assistant screen.         * `icloudDiagnostics` - Skips iCloud analytics screen.         * `icloudStorage` - Skips iCloud documents and desktop screen.         * `location` - Skips location services setup.         * `payment` - Skips Apple Pay setup.         * `privacy` - Skips the Privacy setup.         * `restore` - Skips restoring from backup.         * `screenTime` - Skips screen time setup.         * `siri` - Skips Siri setup.         * `tos` - Skips terms and conditions.         * `appStore` - Skips the App Store pane.         * `deviceToDeviceMigration` - Skips Device to Device Migration pane.         * `displayZoom` - Skips zoom setup.         * `homeButton` - Skips the Meet the New Home Button screen on iPhone 7, iPhone 7 Plus, iPhone 8, iPhone 8 Plus and iPhone SE.         * `imessageAndFacetime` - Skips the iMessage and FaceTime screen in iOS.         * `messagingActivationUsingPhoneNumber` - Skips the iMessage pane.         * `moveFromAndroid` - If the Restore pane is not skipped, removes the Move from Android option in the Restore pane on iOS.O         * `passcode` - Hides and disables the passcode pane.         * `restoreComplete` - Skips the Restore Completed pane.         * `setupCellular` - Skips the add cellular plan pane.         * `softwareUpdate` - Skips the mandatory software update screen in iOS.         * `unlockWithWatch` - Skips Unlock Your Mac with your Apple Watch pane.         * `updateComplete` - Skips the Software Update Complete pane.         * `watchMigration` - Skips the screen for watch migration.         * `welcome` - Skips the Get Started pane.         
  - `[EncryptedDepServerToken <String>]`: The S/MIME encoded DEP Server Token returned by Apple Business Manager when creating an MDM instance.
  - `[IoDefaultDeviceGroupObjectIds <String[]>]`: An array of ObjectIDs identifying the default device groups for this specific type (based on the OS family) of automated device enrollment. Currently, only a single DeviceGroupID is supported.
  - `[IoEnableZeroTouchEnrollment <Boolean?>]`: A toggle to determine if ADE registered devices should go through JumpCloud Zero Touch Enrollment.
  - `[IoSetupAssistantOptions <IDepSetupAssistantOption[]>]`: 
  - `[IosWelcomeScreenButton <String>]`: Text to display on the button on the DEP Welcome Screen.
  - `[IosWelcomeScreenParagraph <String>]`: A message to display on the DEP Welcome Screen.
  - `[IosWelcomeScreenTitle <String>]`: The title to display on the DEP Welcome Screen.
  - `[MacoDefaultDeviceGroupObjectIds <String[]>]`: An array of ObjectIDs identifying the default device groups for this specific type (based on the OS family) of automated device enrollment. Currently, only a single DeviceGroupID is supported.
  - `[MacoEnableZeroTouchEnrollment <Boolean?>]`: A toggle to determine if ADE registered devices should go through JumpCloud Zero Touch Enrollment.
  - `[MacoSetupAssistantOptions <IDepSetupAssistantOption[]>]`: 
  - `[MacosWelcomeScreenButton <String>]`: Text to display on the button on the DEP Welcome Screen.
  - `[MacosWelcomeScreenParagraph <String>]`: A message to display on the DEP Welcome Screen.
  - `[MacosWelcomeScreenTitle <String>]`: The title to display on the DEP Welcome Screen.
  - `[Name <String>]`: A new name for the Apple MDM configuration.
  - `[WelcomeScreenButton <String>]`: Text to display on the button on the DEP Welcome Screen.
  - `[WelcomeScreenParagraph <String>]`: A message to display on the DEP Welcome Screen.
  - `[WelcomeScreenTitle <String>]`: The title to display on the DEP Welcome Screen.

DEPSETUPASSISTANTOPTIONS <IDepSetupAssistantOption[]>: .
  - `[Option <String>]`: Options to skip screens during MacOS and iOS setup:         * `accessibility` - Skips the Accessibility pane, only if the Mac is connected to Ethernet and the cloud config is downloaded.         * `appearance` - Skips the Choose Your Look screen.         * `appleID` - Skips Apple ID setup.         * `biometric` - Skips biometric setup.         * `diagnostics` - Skips the App Analytics pane.         * `displayTone` - Skips display tone setup.         * `fileVault` - Skips FileVault setup assistant screen.         * `icloudDiagnostics` - Skips iCloud analytics screen.         * `icloudStorage` - Skips iCloud documents and desktop screen.         * `location` - Skips location services setup.         * `payment` - Skips Apple Pay setup.         * `privacy` - Skips the Privacy setup.         * `restore` - Skips restoring from backup.         * `screenTime` - Skips screen time setup.         * `siri` - Skips Siri setup.         * `tos` - Skips terms and conditions.         * `appStore` - Skips the App Store pane.         * `deviceToDeviceMigration` - Skips Device to Device Migration pane.         * `displayZoom` - Skips zoom setup.         * `homeButton` - Skips the Meet the New Home Button screen on iPhone 7, iPhone 7 Plus, iPhone 8, iPhone 8 Plus and iPhone SE.         * `imessageAndFacetime` - Skips the iMessage and FaceTime screen in iOS.         * `messagingActivationUsingPhoneNumber` - Skips the iMessage pane.         * `moveFromAndroid` - If the Restore pane is not skipped, removes the Move from Android option in the Restore pane on iOS.O         * `passcode` - Hides and disables the passcode pane.         * `restoreComplete` - Skips the Restore Completed pane.         * `setupCellular` - Skips the add cellular plan pane.         * `softwareUpdate` - Skips the mandatory software update screen in iOS.         * `unlockWithWatch` - Skips Unlock Your Mac with your Apple Watch pane.         * `updateComplete` - Skips the Software Update Complete pane.         * `watchMigration` - Skips the screen for watch migration.         * `welcome` - Skips the Get Started pane.         

INPUTOBJECT <IJumpCloudApiIdentity>: Identity Parameter
  - `[AccountId <String>]`: 
  - `[ActivedirectoryId <String>]`: 
  - `[AdministratorId <String>]`: 
  - `[AgentId <String>]`: 
  - `[AgreementId <String>]`: 
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
  - `[Uuid <String>]`: 
  - `[WorkdayId <String>]`: 

IOSETUPASSISTANTOPTIONS <IDepSetupAssistantOption[]>: .
  - `[Option <String>]`: Options to skip screens during MacOS and iOS setup:         * `accessibility` - Skips the Accessibility pane, only if the Mac is connected to Ethernet and the cloud config is downloaded.         * `appearance` - Skips the Choose Your Look screen.         * `appleID` - Skips Apple ID setup.         * `biometric` - Skips biometric setup.         * `diagnostics` - Skips the App Analytics pane.         * `displayTone` - Skips display tone setup.         * `fileVault` - Skips FileVault setup assistant screen.         * `icloudDiagnostics` - Skips iCloud analytics screen.         * `icloudStorage` - Skips iCloud documents and desktop screen.         * `location` - Skips location services setup.         * `payment` - Skips Apple Pay setup.         * `privacy` - Skips the Privacy setup.         * `restore` - Skips restoring from backup.         * `screenTime` - Skips screen time setup.         * `siri` - Skips Siri setup.         * `tos` - Skips terms and conditions.         * `appStore` - Skips the App Store pane.         * `deviceToDeviceMigration` - Skips Device to Device Migration pane.         * `displayZoom` - Skips zoom setup.         * `homeButton` - Skips the Meet the New Home Button screen on iPhone 7, iPhone 7 Plus, iPhone 8, iPhone 8 Plus and iPhone SE.         * `imessageAndFacetime` - Skips the iMessage and FaceTime screen in iOS.         * `messagingActivationUsingPhoneNumber` - Skips the iMessage pane.         * `moveFromAndroid` - If the Restore pane is not skipped, removes the Move from Android option in the Restore pane on iOS.O         * `passcode` - Hides and disables the passcode pane.         * `restoreComplete` - Skips the Restore Completed pane.         * `setupCellular` - Skips the add cellular plan pane.         * `softwareUpdate` - Skips the mandatory software update screen in iOS.         * `unlockWithWatch` - Skips Unlock Your Mac with your Apple Watch pane.         * `updateComplete` - Skips the Software Update Complete pane.         * `watchMigration` - Skips the screen for watch migration.         * `welcome` - Skips the Get Started pane.         

MACOSETUPASSISTANTOPTIONS <IDepSetupAssistantOption[]>: .
  - `[Option <String>]`: Options to skip screens during MacOS and iOS setup:         * `accessibility` - Skips the Accessibility pane, only if the Mac is connected to Ethernet and the cloud config is downloaded.         * `appearance` - Skips the Choose Your Look screen.         * `appleID` - Skips Apple ID setup.         * `biometric` - Skips biometric setup.         * `diagnostics` - Skips the App Analytics pane.         * `displayTone` - Skips display tone setup.         * `fileVault` - Skips FileVault setup assistant screen.         * `icloudDiagnostics` - Skips iCloud analytics screen.         * `icloudStorage` - Skips iCloud documents and desktop screen.         * `location` - Skips location services setup.         * `payment` - Skips Apple Pay setup.         * `privacy` - Skips the Privacy setup.         * `restore` - Skips restoring from backup.         * `screenTime` - Skips screen time setup.         * `siri` - Skips Siri setup.         * `tos` - Skips terms and conditions.         * `appStore` - Skips the App Store pane.         * `deviceToDeviceMigration` - Skips Device to Device Migration pane.         * `displayZoom` - Skips zoom setup.         * `homeButton` - Skips the Meet the New Home Button screen on iPhone 7, iPhone 7 Plus, iPhone 8, iPhone 8 Plus and iPhone SE.         * `imessageAndFacetime` - Skips the iMessage and FaceTime screen in iOS.         * `messagingActivationUsingPhoneNumber` - Skips the iMessage pane.         * `moveFromAndroid` - If the Restore pane is not skipped, removes the Move from Android option in the Restore pane on iOS.O         * `passcode` - Hides and disables the passcode pane.         * `restoreComplete` - Skips the Restore Completed pane.         * `setupCellular` - Skips the add cellular plan pane.         * `softwareUpdate` - Skips the mandatory software update screen in iOS.         * `unlockWithWatch` - Skips Unlock Your Mac with your Apple Watch pane.         * `updateComplete` - Skips the Software Update Complete pane.         * `watchMigration` - Skips the screen for watch migration.         * `welcome` - Skips the Get Started pane.         

## RELATED LINKS

