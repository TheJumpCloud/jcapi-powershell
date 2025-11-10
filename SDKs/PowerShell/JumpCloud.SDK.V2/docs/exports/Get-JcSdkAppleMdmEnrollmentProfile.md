---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/CUT-4908_userGroupDeviceGroupFilters/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Get-JcSdkAppleMdmEnrollmentProfile.md
schema: 2.0.0
---

# Get-JcSdkAppleMdmEnrollmentProfile

## SYNOPSIS
Get a list of enrollment profiles for an apple mdm.

Note: currently only one enrollment profile is supported.

#### Sample Request
```
 curl https://console.jumpcloud.com/api/v2/applemdms/{APPLE_MDM_ID}/enrollmentprofiles \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

## SYNTAX

```
Get-JcSdkAppleMdmEnrollmentProfile -HostEnv <String> -AppleMdmId <String> [<CommonParameters>]
```

## DESCRIPTION
Get a list of enrollment profiles for an apple mdm.

Note: currently only one enrollment profile is supported.

#### Sample Request
```
 curl https://console.jumpcloud.com/api/v2/applemdms/{APPLE_MDM_ID}/enrollmentprofiles \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Get-JcSdkAppleMdmEnrollmentProfile -AppleMdmId 5ecfd88e63336c651d4f4n59
```

Get a list of enrollment profiles for an apple mdm

### -------------------------- EXAMPLE 2 --------------------------
```powershell
Get-JcSdkAppleMdmEnrollmentProfile -AppleMdmId 5ecfd88e63336c651d4f4n59 -Id 5ecfd88e63336c651d4f4n60
```

Get an enrollment profile by Id

## PARAMETERS

### -AppleMdmId
.

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

### -HostEnv
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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### JumpCloud.SDK.V2.Models.IAppleMdm

## NOTES

## RELATED LINKS

