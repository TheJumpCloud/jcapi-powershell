---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Get-JcSdkAppleMdmEnrollmentProfile.md
schema: 2.0.0
---

# Get-JcSdkAppleMdmEnrollmentProfile

## SYNOPSIS
Get an enrollment profile\n\nCurrently only requesting the mobileconfig is supported.\n\n#### Sample Request\n\n```\ncurl https://console.jumpcloud.com/api/v2/applemdms/{APPLE_MDM_ID}/enrollmentprofiles/{ID} \\\n  -H 'accept: application/x-apple-aspen-config' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

## SYNTAX

### List (Default)
```
Get-JcSdkAppleMdmEnrollmentProfile -AppleMdmId <String> [<CommonParameters>]
```

### Get
```
Get-JcSdkAppleMdmEnrollmentProfile -AppleMdmId <String> -Id <String> [<CommonParameters>]
```

### GetViaIdentity
```
Get-JcSdkAppleMdmEnrollmentProfile -InputObject <IJumpCloudApIsIdentity> [<CommonParameters>]
```

## DESCRIPTION
Get an enrollment profile\n\nCurrently only requesting the mobileconfig is supported.\n\n#### Sample Request\n\n```\ncurl https://console.jumpcloud.com/api/v2/applemdms/{APPLE_MDM_ID}/enrollmentprofiles/{ID} \\\n  -H 'accept: application/x-apple-aspen-config' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

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
Parameter Sets: Get, List
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
.

```yaml
Type: System.String
Parameter Sets: Get
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
Parameter Sets: GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity

## OUTPUTS

### JumpCloud.SDK.V2.Models.IAppleMdmEnrollmentProfileGetApplicationJsonResponse

### JumpCloud.SDK.V2.Models.IPaths127NticApplemdmsAppleMdmIdEnrollmentprofilesGetResponses200ContentApplicationJsonSchemaItems

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


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

