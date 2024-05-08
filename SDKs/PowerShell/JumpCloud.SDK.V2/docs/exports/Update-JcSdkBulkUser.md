---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Update-JcSdkBulkUser.md
schema: 2.0.0
---

# Update-JcSdkBulkUser

## SYNOPSIS
The endpoint allows you to create a bulk job to asynchronously update users.
See [Update a System User](https://docs.jumpcloud.com/api/1.0/index.html#operation/systemusers_put) for full list of attributes.

#### Sample Request 
```
curl -X PATCH https://console.jumpcloud.com/api/v2/bulk/users \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '[
\t{
\t  \"id\":\"5be9fb4ddb01290001e85109\",
\t\t\"firstname\":\"{UPDATED_FIRSTNAME}\",
\t\t\"department\":\"{UPDATED_DEPARTMENT}\",
\t\t\"attributes\":[
\t\t\t{\"name\":\"Custom\",\"value\":\"{ATTRIBUTE_VALUE}\"}
\t\t]
\t},
\t{
\t  \"id\":\"5be9fb4ddb01290001e85109\",
\t\t\"firstname\":\"{UPDATED_FIRSTNAME}\",
\t\t\"costCenter\":\"{UPDATED_COST_CENTER}\",
\t\t\"phoneNumbers\":[
\t\t\t{\"type\":\"home\",\"number\":\"{HOME_PHONE_NUMBER}\"},
\t\t\t{\"type\":\"work\",\"number\":\"{WORK_PHONE_NUMBER}\"}
\t\t]
\t}
]
```

## SYNTAX

```
Update-JcSdkBulkUser -Body <IBulkUserUpdate[]> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
The endpoint allows you to create a bulk job to asynchronously update users.
See [Update a System User](https://docs.jumpcloud.com/api/1.0/index.html#operation/systemusers_put) for full list of attributes.

#### Sample Request 
```
curl -X PATCH https://console.jumpcloud.com/api/v2/bulk/users \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '[
\t{
\t  \"id\":\"5be9fb4ddb01290001e85109\",
\t\t\"firstname\":\"{UPDATED_FIRSTNAME}\",
\t\t\"department\":\"{UPDATED_DEPARTMENT}\",
\t\t\"attributes\":[
\t\t\t{\"name\":\"Custom\",\"value\":\"{ATTRIBUTE_VALUE}\"}
\t\t]
\t},
\t{
\t  \"id\":\"5be9fb4ddb01290001e85109\",
\t\t\"firstname\":\"{UPDATED_FIRSTNAME}\",
\t\t\"costCenter\":\"{UPDATED_COST_CENTER}\",
\t\t\"phoneNumbers\":[
\t\t\t{\"type\":\"home\",\"number\":\"{HOME_PHONE_NUMBER}\"},
\t\t\t{\"type\":\"work\",\"number\":\"{WORK_PHONE_NUMBER}\"}
\t\t]
\t}
]
```

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Update-JcSdkBulkUser
```



### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

## PARAMETERS

### -Body
Array of bulk-user-update
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: JumpCloud.SDK.V2.Models.IBulkUserUpdate[]
Parameter Sets: (All)
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

### JumpCloud.SDK.V2.Models.IBulkUserUpdate[]

## OUTPUTS

### System.String

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODY <IBulkUserUpdate[]>: Array of bulk-user-update
  - `[AccountLocked <Boolean?>]`: 
  - `[Addresses <IBulkUserUpdateAddressesItem[]>]`: type, poBox, extendedAddress, streetAddress, locality, region, postalCode, country
    - `[Country <String>]`: 
    - `[ExtendedAddress <String>]`: 
    - `[Locality <String>]`: 
    - `[PoBox <String>]`: 
    - `[PostalCode <String>]`: 
    - `[Region <String>]`: 
    - `[StreetAddress <String>]`: 
    - `[Type <String>]`: 
  - `[AllowPublicKey <Boolean?>]`: 
  - `[AlternateEmail <String>]`: 
  - `[Attributes <IBulkUserUpdateAttributesItem[]>]`: 
    - `[Name <String>]`: 
    - `[Value <String>]`: 
  - `[Company <String>]`: 
  - `[CostCenter <String>]`: 
  - `[Department <String>]`: 
  - `[Description <String>]`: 
  - `[DisableDeviceMaxLoginAttempts <Boolean?>]`: 
  - `[Displayname <String>]`: 
  - `[Email <String>]`: 
  - `[EmployeeIdentifier <String>]`: Must be unique per user. 
  - `[EmployeeType <String>]`: 
  - `[EnableManagedUid <Boolean?>]`: 
  - `[EnableUserPortalMultifactor <Boolean?>]`: 
  - `[ExternalDn <String>]`: 
  - `[ExternalPasswordExpirationDate <String>]`: 
  - `[ExternalSourceType <String>]`: 
  - `[ExternallyManaged <Boolean?>]`: 
  - `[Firstname <String>]`: 
  - `[Id <String>]`: Object ID of the user being updated
  - `[JobTitle <String>]`: 
  - `[Lastname <String>]`: 
  - `[LdapBindingUser <Boolean?>]`: 
  - `[Location <String>]`: 
  - `[ManagedAppleId <String>]`: 
  - `[Manager <String>]`: Relation with another systemuser to identify the last as a manager.
  - `[MfaConfigured <Boolean?>]`: 
  - `[MfaExclusion <Boolean?>]`: 
  - `[MfaExclusionDays <Int32?>]`: 
  - `[MfaExclusionUntil <DateTime?>]`: 
  - `[Middlename <String>]`: 
  - `[Organization <String>]`: Organization object id of the user
  - `[Password <String>]`: 
  - `[PasswordNeverExpires <Boolean?>]`: 
  - `[PhoneNumbers <IBulkUserUpdatePhoneNumbersItem[]>]`: 
    - `[Number <String>]`: 
    - `[Type <String>]`: 
  - `[PublicKey <String>]`: 
  - `[Relationships <IBulkUserUpdateRelationshipsItem[]>]`: 
    - `[Type <String>]`: 
    - `[Value <String>]`: 
  - `[SambaServiceUser <Boolean?>]`: 
  - `[SshKeys <IBulkUserUpdateSshKeysItem[]>]`: 
    - `Name <String>`: The name of the SSH key.
    - `PublicKey <String>`: The Public SSH key.
  - `[State <String>]`: 
  - `[Sudo <Boolean?>]`: 
  - `[Suspended <Boolean?>]`: 
  - `[UnixGuid <Int32?>]`: 
  - `[UnixUid <Int32?>]`: 
  - `[Username <String>]`: 

## RELATED LINKS

