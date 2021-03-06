---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/New-JcSdkSoftwareApp.md
schema: 2.0.0
---

# New-JcSdkSoftwareApp

## SYNOPSIS
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

## SYNTAX

### CreateExpanded (Default)
```
New-JcSdkSoftwareApp [-DisplayName <String>] [-Id <String>] [-Settings <ISoftwareAppSettings[]>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Create
```
New-JcSdkSoftwareApp -Body <ISoftwareApp> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
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
Parameter Sets: Create
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Settings
.
To construct, see NOTES section for SETTINGS properties and create a hash table.

```yaml
Type: JumpCloud.SDK.V2.Models.ISoftwareAppSettings[]
Parameter Sets: CreateExpanded
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
    - `[AppleVppAssignedLicenses <Int32?>]`: 
    - `[AppleVppAvailableLicenses <Int32?>]`: 
    - `[AppleVppDetails <ISoftwareAppAppleVppDetails>]`: App details returned by iTunes API. See example. The properties in this field are out of our control and we cannot guarantee consistency, so it should be checked by the client and manage the details accordingly.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
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

SETTINGS <ISoftwareAppSettings[]>: .
  - `[AllowUpdateDelay <Boolean?>]`: 
  - `[AppleVppAssignedLicenses <Int32?>]`: 
  - `[AppleVppAvailableLicenses <Int32?>]`: 
  - `[AppleVppDetails <ISoftwareAppAppleVppDetails>]`: App details returned by iTunes API. See example. The properties in this field are out of our control and we cannot guarantee consistency, so it should be checked by the client and manage the details accordingly.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
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

