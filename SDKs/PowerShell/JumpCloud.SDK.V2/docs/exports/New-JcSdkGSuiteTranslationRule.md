---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/CUT-4908_userGroupDeviceGroupFilters/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/New-JcSdkGSuiteTranslationRule.md
schema: 2.0.0
---

# New-JcSdkGSuiteTranslationRule

## SYNOPSIS
This endpoint allows you to create a translation rule for a specific G Suite instance.
These rules specify how JumpCloud attributes translate to [G Suite Admin SDK](https://developers.google.com/admin-sdk/directory/) attributes.

##### Sample Request
```
curl -X POST https://console.jumpcloud.com/api/v2/gsuites/{gsuite_id}/translationrules \\
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
New-JcSdkGSuiteTranslationRule -HostEnv <String> -GsuiteId <String> [-BuiltIn <String>] [-Direction <String>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-JcSdkGSuiteTranslationRule -HostEnv <String> -GsuiteId <String> -Body <IGSuiteTranslationRuleRequest>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-JcSdkGSuiteTranslationRule -HostEnv <String> -InputObject <IJumpCloudApiIdentity>
 -Body <IGSuiteTranslationRuleRequest> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-JcSdkGSuiteTranslationRule -HostEnv <String> -InputObject <IJumpCloudApiIdentity> [-BuiltIn <String>]
 [-Direction <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
This endpoint allows you to create a translation rule for a specific G Suite instance.
These rules specify how JumpCloud attributes translate to [G Suite Admin SDK](https://developers.google.com/admin-sdk/directory/) attributes.

##### Sample Request
```
curl -X POST https://console.jumpcloud.com/api/v2/gsuites/{gsuite_id}/translationrules \\
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
New-JcSdkGSuiteTranslationRule -GsuiteId:(<string>) -BuiltIn:(<string>) -Direction:(<string>)
```

----      ----------
BuiltIn   String
Direction String
Id        String

### -------------------------- EXAMPLE 2 --------------------------
```powershell
New-JcSdkGSuiteTranslationRule -GsuiteId:(<string>) -Body:(<JumpCloud.SDK.V2.Models.GSuiteTranslationRuleRequest>)
```

----      ----------
BuiltIn   String
Direction String
Id        String

## PARAMETERS

### -Body
G Suite Translation Rule Request

```yaml
Type: JumpCloud.SDK.V2.Models.IGSuiteTranslationRuleRequest
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -BuiltIn
Built-in translations for G Suite export:* `user_home_addresses` - Translate all JumpCloud user addresses of type `home` to G Suite Directory user addresses of type `home`* `user_work_addresses` - Translate all JumpCloud user addresses of type `work` to G Suite Directory user addresses of type `work`* `user_other_addresses` - Translate all JumpCloud user addresses of type `other` to G Suite Directory user addresses of type `other`* `user_home_phone_numbers` - Translate all JumpCloud user phoneNumbers of type `home` to G Suite Directory user phones of type `home`* `user_mobile_phone_numbers` - Translate all JumpCloud user phoneNumbers of type `mobile` to G Suite Directory user phones of type `mobile`* `user_other_phone_numbers` - Translate all JumpCloud user phoneNumbers of type `other` to G Suite Directory user phones of type `other`* `user_work_phone_numbers` - Translate all JumpCloud user phoneNumbers of type `work` to G Suite Directory user phones of type `work`* `user_work_fax_phone_numbers` - Translate all JumpCloud user phoneNumbers of type `work_fax` to G Suite Directory user phones of type `work_fax`* `user_work_mobile_phone_numbers` - Translate all JumpCloud user phoneNumbers of type `work_mobile` to G Suite Directory user phones of type `work_mobile`* `user_manager` - Translate JumpCloud user `manager` to G Suite Directory user `relations-manager`* `user_primary_organization_cost_center` - Translate JumpCloud user `costCenter` to G Suite Directory user `costCenter` for `primary` organization* `user_primary_organization_department` - Translate JumpCloud user `department` to G Suite Directory user `department` for `primary` organization* `user_primary_organization_description` - Translate JumpCloud user `employeeType` to G Suite Directory user `description` for `primary` organization* `user_primary_organization_employee_id` - Translate JumpCloud user `employeeIdentifier` to G Suite Directory user `externalIds` element of type `organization`* `user_primary_organization_title` - Translate JumpCloud user `jobTitle` to G Suite Directory user `title` for `primary` organization* `user_alternate_email` - Translate JumpCloud user `alternateEmail` to G Suite Directory user `emails`* `user_status` - Translate JumpCloud user `status` to G Suite Directory user `status`* `user_password` - Translate JumpCloud user `password` to G Suite Directory user `password`

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
Direction identify if an attribute is going to be exported or imported from GSuite* `Import`- The data will be imported from GSuite into the user modal* `Export`- The data will be exported from the user modal to GSuite

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

### -GsuiteId
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

### -InputObject
Identity Parameter

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

### JumpCloud.SDK.V2.Models.IGSuiteTranslationRuleRequest

### JumpCloud.SDK.V2.Models.IJumpCloudApiIdentity

## OUTPUTS

### JumpCloud.SDK.V2.Models.IGSuiteTranslationRule

## NOTES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODY <IGSuiteTranslationRuleRequest>`: G Suite Translation Rule Request
  - `[BuiltIn <String>]`: Built-in translations for G Suite export:         * `user_home_addresses` - Translate all JumpCloud user addresses of type `home` to G Suite Directory user addresses of type `home`         * `user_work_addresses` - Translate all JumpCloud user addresses of type `work` to G Suite Directory user addresses of type `work`         * `user_other_addresses` - Translate all JumpCloud user addresses of type `other` to G Suite Directory user addresses of type `other`         * `user_home_phone_numbers` - Translate all JumpCloud user phoneNumbers of type `home` to G Suite Directory user phones of type `home`         * `user_mobile_phone_numbers` - Translate all JumpCloud user phoneNumbers of type `mobile` to G Suite Directory user phones of type `mobile`         * `user_other_phone_numbers` - Translate all JumpCloud user phoneNumbers of type `other` to G Suite Directory user phones of type `other`         * `user_work_phone_numbers` - Translate all JumpCloud user phoneNumbers of type `work` to G Suite Directory user phones of type `work`         * `user_work_fax_phone_numbers` - Translate all JumpCloud user phoneNumbers of type `work_fax` to G Suite Directory user phones of type `work_fax`         * `user_work_mobile_phone_numbers` - Translate all JumpCloud user phoneNumbers of type `work_mobile` to G Suite Directory user phones of type `work_mobile`         * `user_manager` - Translate JumpCloud user `manager` to G Suite Directory user `relations-manager`         * `user_primary_organization_cost_center` - Translate JumpCloud user  `costCenter` to G Suite Directory user `costCenter` for `primary` organization         * `user_primary_organization_department` - Translate JumpCloud user  `department` to G Suite Directory user `department` for `primary` organization         * `user_primary_organization_description` - Translate JumpCloud user  `employeeType` to G Suite Directory user `description` for `primary` organization         * `user_primary_organization_employee_id` - Translate JumpCloud user  `employeeIdentifier` to G Suite Directory user `externalIds` element of type `organization`         * `user_primary_organization_title` - Translate JumpCloud user  `jobTitle` to G Suite Directory user `title` for `primary` organization         * `user_alternate_email` - Translate JumpCloud user  `alternateEmail` to G Suite Directory user `emails`         * `user_status` - Translate JumpCloud user `status` to G Suite Directory user `status`         * `user_password` - Translate JumpCloud user `password` to G Suite Directory user `password`         
  - `[Direction <String>]`: Direction identify if an attribute is going to be exported or imported from GSuite         * `Import`- The data will be imported from GSuite into the user modal         * `Export`- The data will be exported from the user modal to GSuite         

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

## RELATED LINKS

