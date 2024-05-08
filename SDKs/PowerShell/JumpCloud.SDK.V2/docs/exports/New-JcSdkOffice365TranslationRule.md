---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/New-JcSdkOffice365TranslationRule.md
schema: 2.0.0
---

# New-JcSdkOffice365TranslationRule

## SYNOPSIS
This endpoint allows you to create a translation rule for a specific Office 365 instance.
These rules specify how JumpCloud attributes translate to [Microsoft Graph](https://developer.microsoft.com/en-us/graph) attributes.

##### Sample Request
```
curl -X POST https://console.jumpcloud.com/api/v2/office365s/{office365_id}/translationrules \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    {Translation Rule Parameters}
  }'
```

## SYNTAX

### CreateExpanded (Default)
```
New-JcSdkOffice365TranslationRule -Office365Id <String> [-BuiltIn <String>] [-Direction <String>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Create
```
New-JcSdkOffice365TranslationRule -Office365Id <String> -Body <IOffice365TranslationRuleRequest> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-JcSdkOffice365TranslationRule -InputObject <IJumpCloudApiIdentity>
 -Body <IOffice365TranslationRuleRequest> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-JcSdkOffice365TranslationRule -InputObject <IJumpCloudApiIdentity> [-BuiltIn <String>]
 [-Direction <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
This endpoint allows you to create a translation rule for a specific Office 365 instance.
These rules specify how JumpCloud attributes translate to [Microsoft Graph](https://developer.microsoft.com/en-us/graph) attributes.

##### Sample Request
```
curl -X POST https://console.jumpcloud.com/api/v2/office365s/{office365_id}/translationrules \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    {Translation Rule Parameters}
  }'
```

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
New-JcSdkOffice365TranslationRule -Office365Id:(<string>) -BuiltIn:(<string>) -Direction:(<string>)
```

----      ----------
BuiltIn   String
Direction String
Id        String

### -------------------------- EXAMPLE 2 --------------------------
```powershell
New-JcSdkOffice365TranslationRule -Office365Id:(<string>) -Body:(<JumpCloud.SDK.V2.Models.Office365TranslationRuleRequest>)
```

----      ----------
BuiltIn   String
Direction String
Id        String

## PARAMETERS

### -Body
Office 365 Translation Rule Request
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: JumpCloud.SDK.V2.Models.IOffice365TranslationRuleRequest
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -BuiltIn
Built-in translations for Office 365 (Microsoft Graph) export:* `user_alternate_email` - Translate `alternateEmail` field of JumpCloud user to `otherMails` field of Microsoft Graph `user`* `user_business_phones` - Translate `number` field of first JumpCloud user `phoneNumber` of type `work` to `businessPhones` field of Microsoft Graph `user`* `user_city` - Translate `locality` field of JumpCloud user address of type `work` to `city` field of Microsoft Graph user* `user_country` - Translate `country` field of JumpCloud user address of type `work` to `country` field of Microsoft Graph `user`* `user_department` - Translate `department` field of JumpCloud user to `department` field of Microsoft Graph `user`* `user_job_title` - Translate `jobTitle` field of JumpCloud user to `jobTitle` field of Microsoft Graph `user`* `user_manager` - Translate `manager` field of JumpCloud user to `manager` field of Microsoft Graph `user`* `user_mobile_phone` - Translate `number` field of first JumpCloud user `phoneNumber` of type `mobile` to `mobilePhone` field of Microsoft Graph `user`* `user_office_location` - Translate `location` field of JumpCloud user to `officeLocation` field of Microsoft Graph `user`* `user_postal_code` - Translate `postalCode` field of JumpCloud user address of type `work` to `postalCode` field of Microsoft Graph `user`* `user_principal_name_from_alternate_email` - Translate user `alternateEmail` field of Jumpcloud user to `userPrincipalName` field of Microsoft Graph `user`* `user_state` - Translate `region` field of JumpCloud user address of type `work` to `state` field of Microsoft Graph `user`* `user_street_address` - Translate `streetAddress` field of JumpCloud user address of type `work` to `streetAddress` field of Microsoft Graph user

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Direction
Direction identify if a attribute is going to be exported or imported from Office365* `Export`- The data will exported from the user modal to Office365

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateViaIdentity, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Office365Id
.

```yaml
Type: System.String
Parameter Sets: Create, CreateExpanded
Aliases:

Required: True
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

### JumpCloud.SDK.V2.Models.IOffice365TranslationRuleRequest

## OUTPUTS

### JumpCloud.SDK.V2.Models.IOffice365TranslationRule

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODY <IOffice365TranslationRuleRequest>: Office 365 Translation Rule Request
  - `[BuiltIn <String>]`: Built-in translations for Office 365 (Microsoft Graph) export:         * `user_alternate_email` - Translate `alternateEmail` field of JumpCloud user to `otherMails` field of Microsoft Graph `user`         * `user_business_phones` - Translate `number` field of first JumpCloud user `phoneNumber` of type `work` to `businessPhones` field of Microsoft Graph `user`         * `user_city` - Translate `locality` field of JumpCloud user address of type `work` to `city` field of Microsoft Graph user         * `user_country` - Translate `country` field of JumpCloud user address of type `work` to `country` field of Microsoft Graph `user`         * `user_department` - Translate `department` field of JumpCloud user to `department` field of Microsoft Graph `user`         * `user_job_title` - Translate `jobTitle` field of JumpCloud user to `jobTitle` field of Microsoft Graph `user`         * `user_manager` - Translate `manager` field of JumpCloud user to `manager` field of Microsoft Graph `user`         * `user_mobile_phone` - Translate `number` field of first JumpCloud user `phoneNumber` of type `mobile` to `mobilePhone` field of Microsoft Graph `user`         * `user_office_location` - Translate `location` field of JumpCloud user to `officeLocation` field of Microsoft Graph `user`         * `user_postal_code` - Translate `postalCode` field of JumpCloud user address of type `work` to `postalCode` field of Microsoft Graph `user`         * `user_principal_name_from_alternate_email` - Translate user `alternateEmail` field of Jumpcloud user to `userPrincipalName` field of Microsoft Graph `user`         * `user_state` - Translate `region` field of JumpCloud user address of type `work` to `state` field of Microsoft Graph `user`         * `user_street_address` - Translate `streetAddress` field of JumpCloud user address of type `work` to `streetAddress` field of Microsoft Graph user
  - `[Direction <String>]`: Direction identify if a attribute is going to be exported or imported from Office365         * `Export`- The data will exported from the user modal to Office365         

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

## RELATED LINKS

