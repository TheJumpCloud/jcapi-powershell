---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Set-JcSdkSoftwareApp.md
schema: 2.0.0
---

# Set-JcSdkSoftwareApp

## SYNOPSIS
This endpoint updates a specific Software Application configuration for the organization.
displayName can be changed alone if no settings are provided.
If a setting is provided, it should include all its information since this endpoint will update all the settings' fields.

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
          \"appConfiguration\": \"\<?xml version=\\\"1.0\\\" encoding=\\\"UTF-8\\\"?\>\<!DOCTYPE plist PUBLIC \\\"-//Apple//DTD PLIST 1.0//EN\\\" \\\"http://www.apple.com/DTDs/PropertyList-1.0.dtd\\\"\>\<plist version=\\\"1.0\\\"\>\<dict\>\<key\>MyKey\</key\>\<string\>My String\</string\>\</dict\>\</plist\>\",
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

## SYNTAX

### SetExpanded (Default)
```
Set-JcSdkSoftwareApp -Id <String> [-DisplayName <String>] [-Id1 <String>] [-Settings <ISoftwareAppSettings[]>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Set
```
Set-JcSdkSoftwareApp -Id <String> -Body <ISoftwareApp> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### SetViaIdentity
```
Set-JcSdkSoftwareApp -InputObject <IJumpCloudApiIdentity> -Body <ISoftwareApp> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### SetViaIdentityExpanded
```
Set-JcSdkSoftwareApp -InputObject <IJumpCloudApiIdentity> [-Id <String>] [-DisplayName <String>]
 [-Settings <ISoftwareAppSettings[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
This endpoint updates a specific Software Application configuration for the organization.
displayName can be changed alone if no settings are provided.
If a setting is provided, it should include all its information since this endpoint will update all the settings' fields.

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
          \"appConfiguration\": \"\<?xml version=\\\"1.0\\\" encoding=\\\"UTF-8\\\"?\>\<!DOCTYPE plist PUBLIC \\\"-//Apple//DTD PLIST 1.0//EN\\\" \\\"http://www.apple.com/DTDs/PropertyList-1.0.dtd\\\"\>\<plist version=\\\"1.0\\\"\>\<dict\>\<key\>MyKey\</key\>\<string\>My String\</string\>\</dict\>\</plist\>\",
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

### -Body
Software Application Package
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: JumpCloud.SDK.V2.Models.ISoftwareApp
Parameter Sets: Set, SetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DisplayName
.

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
Parameter Sets: Set, SetExpanded, SetViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id1
.

```yaml
Type: System.String
Parameter Sets: SetExpanded
Aliases:

Required: False
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

### -Settings
.
To construct, see NOTES section for SETTINGS properties and create a hash table.

```yaml
Type: JumpCloud.SDK.V2.Models.ISoftwareAppSettings[]
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

### JumpCloud.SDK.V2.Models.IJumpCloudApiIdentity

### JumpCloud.SDK.V2.Models.ISoftwareApp

## OUTPUTS

### JumpCloud.SDK.V2.Models.ISoftwareApp

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODY <ISoftwareApp>: Software Application Package
  - `[DisplayName <String>]`: 
  - `[Id <String>]`: 
  - `[Settings <ISoftwareAppSettings[]>]`: 
    - `[AllowUpdateDelay <Boolean?>]`: 
    - `[AppleVppAppConfiguration <String>]`: Text sent to configure the application, the text should be a valid plist.
    - `[AppleVppAssignedLicenses <Int32?>]`: 
    - `[AppleVppAvailableLicenses <Int32?>]`: 
    - `[AppleVppDetails <ISoftwareAppAppleVppDetails>]`: App details returned by iTunes API. See example. The properties in this field are out of our control and we cannot guarantee consistency, so it should be checked by the client and manage the details accordingly.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AppleVppIsConfigEnabled <Boolean?>]`: Denotes if configuration has been enabled for the application.
    - `[AppleVppSupportedDeviceFamilies <String[]>]`: The supported device families for this VPP Application.
    - `[AppleVppTotalLicenses <Int32?>]`: 
    - `[AssetKind <String>]`: The manifest asset kind (ex: software).
    - `[AssetSha256Size <Int32?>]`: The incremental size to use for summing the package as it is downloaded.
    - `[AssetSha256Strings <String[]>]`: The array of checksums, one each for the hash size up to the total size of the package.
    - `[AutoUpdate <Boolean?>]`: 
    - `[Description <String>]`: The software app description.
    - `[DesiredState <String>]`: State of Install or Uninstall
    - `[Location <String>]`: Repository where the app is located within the package manager
    - `[LocationObjectId <String>]`: ID of the repository where the app is located within the package manager
    - `[PackageId <String>]`: 
    - `[PackageKind <String>]`: The package manifest kind (ex: software-package).
    - `[PackageManager <String>]`: App store serving the app: APPLE_VPP, CHOCOLATEY, etc.
    - `[PackageSubtitle <String>]`: The package manifest subtitle.
    - `[PackageVersion <String>]`: The package manifest version.

INPUTOBJECT <IJumpCloudApiIdentity>: Identity Parameter
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

SETTINGS <ISoftwareAppSettings[]>: .
  - `[AllowUpdateDelay <Boolean?>]`: 
  - `[AppleVppAppConfiguration <String>]`: Text sent to configure the application, the text should be a valid plist.
  - `[AppleVppAssignedLicenses <Int32?>]`: 
  - `[AppleVppAvailableLicenses <Int32?>]`: 
  - `[AppleVppDetails <ISoftwareAppAppleVppDetails>]`: App details returned by iTunes API. See example. The properties in this field are out of our control and we cannot guarantee consistency, so it should be checked by the client and manage the details accordingly.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AppleVppIsConfigEnabled <Boolean?>]`: Denotes if configuration has been enabled for the application.
  - `[AppleVppSupportedDeviceFamilies <String[]>]`: The supported device families for this VPP Application.
  - `[AppleVppTotalLicenses <Int32?>]`: 
  - `[AssetKind <String>]`: The manifest asset kind (ex: software).
  - `[AssetSha256Size <Int32?>]`: The incremental size to use for summing the package as it is downloaded.
  - `[AssetSha256Strings <String[]>]`: The array of checksums, one each for the hash size up to the total size of the package.
  - `[AutoUpdate <Boolean?>]`: 
  - `[Description <String>]`: The software app description.
  - `[DesiredState <String>]`: State of Install or Uninstall
  - `[Location <String>]`: Repository where the app is located within the package manager
  - `[LocationObjectId <String>]`: ID of the repository where the app is located within the package manager
  - `[PackageId <String>]`: 
  - `[PackageKind <String>]`: The package manifest kind (ex: software-package).
  - `[PackageManager <String>]`: App store serving the app: APPLE_VPP, CHOCOLATEY, etc.
  - `[PackageSubtitle <String>]`: The package manifest subtitle.
  - `[PackageVersion <String>]`: The package manifest version.

## RELATED LINKS

