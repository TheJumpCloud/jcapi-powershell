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
It may also be used to update the DEP Settings.\n\n#### Sample Request\n```\n  curl -X PUT https://console.jumpcloud.com/api/v2/applemdms/{ID} \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n    \"name\": \"MDM name\",\n    \"appleSignedCert\": \"{CERTIFICATE}\",\n    \"encryptedDepServerToken\": \"{SERVER_TOKEN}\",\n    \"dep\": {\n      \"welcomeScreen\": {\n        \"title\": \"Welcome\",\n        \"paragraph\": \"In just a few steps, you will be working securely from your Mac.\",\n        \"button\": \"continue\",\n      },\n    },\n  }'\n```

## SYNTAX

### SetExpanded (Default)
```
Set-JcSdkAppleMdm -Id <String> [-AppleSignedCert <String>] [-DefaultSystemGroupId <String>]
 [-DepSetupAssistantOptions <IDepSetupAssistantOption[]>] [-EncryptedDepServerToken <String>] [-Name <String>]
 [-WelcomeScreenButton <String>] [-WelcomeScreenParagraph <String>] [-WelcomeScreenTitle <String>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Set
```
Set-JcSdkAppleMdm -Id <String> -Body <IAppleMdmPatchInput> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### SetViaIdentity
```
Set-JcSdkAppleMdm -InputObject <IJumpCloudApIsIdentity> -Body <IAppleMdmPatchInput> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### SetViaIdentityExpanded
```
Set-JcSdkAppleMdm -InputObject <IJumpCloudApIsIdentity> [-AppleSignedCert <String>]
 [-DefaultSystemGroupId <String>] [-DepSetupAssistantOptions <IDepSetupAssistantOption[]>]
 [-EncryptedDepServerToken <String>] [-Name <String>] [-WelcomeScreenButton <String>]
 [-WelcomeScreenParagraph <String>] [-WelcomeScreenTitle <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Updates an Apple MDM configuration.
This endpoint is used to supply JumpCloud with a signed certificate from Apple in order to finalize the setup and allow JumpCloud to manage your devices.
It may also be used to update the DEP Settings.\n\n#### Sample Request\n```\n  curl -X PUT https://console.jumpcloud.com/api/v2/applemdms/{ID} \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n    \"name\": \"MDM name\",\n    \"appleSignedCert\": \"{CERTIFICATE}\",\n    \"encryptedDepServerToken\": \"{SERVER_TOKEN}\",\n    \"dep\": {\n      \"welcomeScreen\": {\n        \"title\": \"Welcome\",\n        \"paragraph\": \"In just a few steps, you will be working securely from your Mac.\",\n        \"button\": \"continue\",\n      },\n    },\n  }'\n```

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
Type: JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity
Parameter Sets: SetViaIdentity, SetViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity

## OUTPUTS

### JumpCloud.SDK.V2.Models.IAppleMdmSetApplicationJsonResponse

### System.String

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODY <IAppleMdmPatchInput>: Apple MDM Patch Input
  - `[AppleSignedCert <String>]`: A signed certificate obtained from Apple after providing Apple with the plist file provided on POST.
  - `[DefaultSystemGroupId <String>]`: ObjectId uniquely identifying the MDM default System Group.
  - `[DepSetupAssistantOptions <IDepSetupAssistantOption[]>]`: 
    - `[Option <SetupAssistantOption?>]`: Options to skip screens during MacOS setup:         * `accessibility` - Skips the Accessibility pane, only if the Mac is connected to Ethernet and the cloud config is downloaded.         * `appearance` - Skips the Choose Your Look screen.         * `appleID` - Skips Apple ID setup.         * `biometric` - Skips biometric setup.         * `diagnostics` - Skips the App Analytics pane.         * `displayTone` - Skips display tone setup.         * `fileVault` - Skips FileVault setup assistant screen.         * `icloudDiagnostics` - Skips iCloud analytics screen.         * `icloudStorage` - Skips iCloud documents and desktop screen.         * `location` - Skips location services setup.         * `payment` - Skips Apple Pay setup.         * `privacy` - Skips the Privacy setup.         * `restore` - Skips restoring from backup.         * `screenTime` - Skips screen time setup.         * `siri` - Skips Siri setup.         * `tos` - Skips terms and conditions.         
  - `[EncryptedDepServerToken <String>]`: The S/MIME encoded DEP Server Token returned by Apple Business Manager when creating an MDM instance.
  - `[Name <String>]`: A new name for the Apple MDM configuration.
  - `[WelcomeScreenButton <String>]`: Text to display on the button on the DEP Welcome Screen.
  - `[WelcomeScreenParagraph <String>]`: A message to display on the DEP Welcome Screen.
  - `[WelcomeScreenTitle <String>]`: The title to display on the DEP Welcome Screen.

DEPSETUPASSISTANTOPTIONS <IDepSetupAssistantOption[]>: .
  - `[Option <SetupAssistantOption?>]`: Options to skip screens during MacOS setup:         * `accessibility` - Skips the Accessibility pane, only if the Mac is connected to Ethernet and the cloud config is downloaded.         * `appearance` - Skips the Choose Your Look screen.         * `appleID` - Skips Apple ID setup.         * `biometric` - Skips biometric setup.         * `diagnostics` - Skips the App Analytics pane.         * `displayTone` - Skips display tone setup.         * `fileVault` - Skips FileVault setup assistant screen.         * `icloudDiagnostics` - Skips iCloud analytics screen.         * `icloudStorage` - Skips iCloud documents and desktop screen.         * `location` - Skips location services setup.         * `payment` - Skips Apple Pay setup.         * `privacy` - Skips the Privacy setup.         * `restore` - Skips restoring from backup.         * `screenTime` - Skips screen time setup.         * `siri` - Skips Siri setup.         * `tos` - Skips terms and conditions.         

INPUTOBJECT <IJumpCloudApIsIdentity>: Identity Parameter
  - `[AccountId <String>]`: 
  - `[ActivedirectoryId <String>]`: 
  - `[AppleMdmId <String>]`: 
  - `[ApplicationId <String>]`: ObjectID of the Application.
  - `[CommandId <String>]`: ObjectID of the Command.
  - `[DeviceId <String>]`: 
  - `[GroupId <String>]`: ObjectID of the System Group.
  - `[GsuiteId <String>]`: ObjectID of the G Suite instance.
  - `[Id <String>]`: 
  - `[JobId <String>]`: 
  - `[LdapserverId <String>]`: ObjectID of the LDAP Server.
  - `[Office365Id <String>]`: ObjectID of the Office 365 instance.
  - `[PolicyId <String>]`: ObjectID of the Policy.
  - `[ProviderId <String>]`: 
  - `[RadiusserverId <String>]`: ObjectID of the Radius Server.
  - `[SoftwareAppId <String>]`: ObjectID of the Software App.
  - `[SystemId <String>]`: ObjectID of the System.
  - `[UserId <String>]`: ObjectID of the User.
  - `[WorkdayId <String>]`: 

## RELATED LINKS

