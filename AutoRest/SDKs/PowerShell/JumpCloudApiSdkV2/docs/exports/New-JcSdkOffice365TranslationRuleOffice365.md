---
external help file:
Module Name: JumpCloudApiSdkV2
online version: https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv2/new-jcsdkoffice365translationruleoffice365
schema: 2.0.0
---

# New-JcSdkOffice365TranslationRuleOffice365

## SYNOPSIS
This endpoint allows you to create a translation rule for a specific Office 365 instance.
These rules specify how JumpCloud attributes translate to [Microsoft Graph](https://developer.microsoft.com/en-us/graph) attributes.\n\n##### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/office365s/{office365_id}/translationrules \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n  {Translation Rule Parameters}\n}'\n\n```

## SYNTAX

### CreateExpanded (Default)
```
New-JcSdkOffice365TranslationRuleOffice365 -Office365Id <String> [-BuiltIn <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-JcSdkOffice365TranslationRuleOffice365 -Office365Id <String> -Body <IOffice365TranslationRuleRequest>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-JcSdkOffice365TranslationRuleOffice365 -InputObject <IJumpCloudApIsIdentity>
 -Body <IOffice365TranslationRuleRequest> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-JcSdkOffice365TranslationRuleOffice365 -InputObject <IJumpCloudApIsIdentity> [-BuiltIn <String>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
This endpoint allows you to create a translation rule for a specific Office 365 instance.
These rules specify how JumpCloud attributes translate to [Microsoft Graph](https://developer.microsoft.com/en-us/graph) attributes.\n\n##### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/office365s/{office365_id}/translationrules \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n  {Translation Rule Parameters}\n}'\n\n```

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
To view examples, please use the -Online parameter with Get-Help or navigate to: https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv2/new-jcsdkoffice365translationruleoffice365
```



## PARAMETERS

### -Body
Office 365 Translation Rule Request
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: JumpCloudApiSdkV2.Models.IOffice365TranslationRuleRequest
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -BuiltIn
Built-in translations for Office 365 (Microsoft Graph) export:* `user_street_address` - Translate `streetAddress` field of JumpCloud user address of type `work` to `city` field of Microsoft Graph user* `user_city` - Translate `locality` field of JumpCloud user address of type `work` to `city` field of Microsoft Graph user* `user_state` - Translate `region` field of JumpCloud user address of type `work` to `state` field of Microsoft Graph `user`* `user_country` - Translate `country` field of JumpCloud user address of type `work` to `country` field of Microsoft Graph `user`* `user_postal_code` - Translate `postalCode` field of JumpCloud user address of type `work` to `postalCode` field of Microsoft Graph `user`* `user_business_phones` - Translate `number` field of first JumpCloud user `phoneNumber` of type `work` to `businessPhones` field of Microsoft Graph `user`* `user_mobile_phone` - Translate `number` field of first JumpCloud user `phoneNumber` of type `mobile` to `mobilePhone` field of Microsoft Graph `user`* `user_department` - Translate `department` field of JumpCloud user to `department` field of Microsoft Graph `user`* `user_job_title` - Translate `jobTitle` field of JumpCloud user to `jobTitle` field of Microsoft Graph `user`* `user_office_location` - Translate `location` field of JumpCloud user to `officeLocation` field of Microsoft Graph `user`

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentity
Parameter Sets: CreateViaIdentity, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -Office365Id
HELP MESSAGE MISSING

```yaml
Type: System.String
Parameter Sets: Create, CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
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
Dynamic: False
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
Dynamic: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentity

### JumpCloudApiSdkV2.Models.IOffice365TranslationRuleRequest

## OUTPUTS

### JumpCloudApiSdkV2.Models.IOffice365TranslationRule

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### BODY <IOffice365TranslationRuleRequest>: Office 365 Translation Rule Request
  - `[BuiltIn <String>]`: Built-in translations for Office 365 (Microsoft Graph) export:         * `user_street_address` - Translate `streetAddress` field of JumpCloud user address of type `work` to `city` field of Microsoft Graph user         * `user_city` - Translate `locality` field of JumpCloud user address of type `work` to `city` field of Microsoft Graph user         * `user_state` - Translate `region` field of JumpCloud user address of type `work` to `state` field of Microsoft Graph `user`         * `user_country` - Translate `country` field of JumpCloud user address of type `work` to `country` field of Microsoft Graph `user`         * `user_postal_code` - Translate `postalCode` field of JumpCloud user address of type `work` to `postalCode` field of Microsoft Graph `user`         * `user_business_phones` - Translate `number` field of first JumpCloud user `phoneNumber` of type `work` to `businessPhones` field of Microsoft Graph `user`         * `user_mobile_phone` - Translate `number` field of first JumpCloud user `phoneNumber` of type `mobile` to `mobilePhone` field of Microsoft Graph `user`         * `user_department` - Translate `department` field of JumpCloud user to `department` field of Microsoft Graph `user`         * `user_job_title` - Translate `jobTitle` field of JumpCloud user to `jobTitle` field of Microsoft Graph `user`         * `user_office_location` - Translate `location` field of JumpCloud user to `officeLocation` field of Microsoft Graph `user`

#### INPUTOBJECT <IJumpCloudApIsIdentity>: Identity Parameter
  - `[ActivedirectoryId <String>]`: ObjectID of the Active Directory instance.
  - `[ApplicationId <String>]`: ObjectID of the Application.
  - `[CommandId <String>]`: ObjectID of the Command.
  - `[GroupId <String>]`: ObjectID of the User Group.
  - `[GsuiteId <String>]`: ObjectID of the G Suite instance.
  - `[Id <String>]`: 
  - `[JobId <String>]`: 
  - `[LdapserverId <String>]`: ObjectID of the LDAP Server.
  - `[Office365Id <String>]`: ObjectID of the Office 365 instance.
  - `[PolicyId <String>]`: ObjectID of the Policy.
  - `[ProviderId <String>]`: 
  - `[RadiusserverId <String>]`: ObjectID of the Radius Server.
  - `[SystemId <String>]`: 
  - `[UserId <String>]`: ObjectID of the User.
  - `[WorkdayId <String>]`: 

## RELATED LINKS

