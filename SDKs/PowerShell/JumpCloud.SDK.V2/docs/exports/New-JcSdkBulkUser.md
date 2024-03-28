---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/New-JcSdkBulkUser.md
schema: 2.0.0
---

# New-JcSdkBulkUser

## SYNOPSIS
The endpoint allows you to create a bulk job to asynchronously create users.
See [Create a System User](https://docs.jumpcloud.com/api/1.0/index.html#operation/systemusers_post)
for the full list of attributes.

#### Default User State
The `state` of each user in the request can be explicitly passed in or
omitted.
If `state` is omitted, then the user will get created
using the value returned from the
[Get an Organization](https://docs.jumpcloud.com/api/1.0/index.html#operation/organizations_get)
endpoint.
The default user state for bulk created users depends on the
`creation-source` header.
For `creation-source:jumpcloud:bulk` the
default state is stored in `settings.newSystemUserStateDefaults.csvImport`.
For other `creation-source` header values, the default state is stored in
`settings.newSystemUserStateDefaults.applicationImport`

These default state values can be changed in the admin portal settings
or by using the
[Update an Organization](https://docs.jumpcloud.com/api/1.0/index.html#operation/organization_put)
endpoint.

#### Sample Request

```
curl -X POST https://console.jumpcloud.com/api/v2/bulk/users \\
-H 'Accept: application/json' \\
-H 'Content-Type: application/json' \\
-H 'x-api-key: {API_KEY}' \\
-d '[
  {
    \"email\":\"{email}\",
    \"firstname\":\"{firstname}\",
    \"lastname\":\"{firstname}\",
    \"username\":\"{username}\",
    \"attributes\":[
      {
        \"name\":\"EmployeeID\",
        \"value\":\"0000\"
      },
      {
        \"name\":\"Custom\",
        \"value\":\"attribute\"
      }
    ]
  }
]'
```

## SYNTAX

```
New-JcSdkBulkUser -Body <IBulkUserCreate[]> [-CreationSource <CreationSource2>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
The endpoint allows you to create a bulk job to asynchronously create users.
See [Create a System User](https://docs.jumpcloud.com/api/1.0/index.html#operation/systemusers_post)
for the full list of attributes.

#### Default User State
The `state` of each user in the request can be explicitly passed in or
omitted.
If `state` is omitted, then the user will get created
using the value returned from the
[Get an Organization](https://docs.jumpcloud.com/api/1.0/index.html#operation/organizations_get)
endpoint.
The default user state for bulk created users depends on the
`creation-source` header.
For `creation-source:jumpcloud:bulk` the
default state is stored in `settings.newSystemUserStateDefaults.csvImport`.
For other `creation-source` header values, the default state is stored in
`settings.newSystemUserStateDefaults.applicationImport`

These default state values can be changed in the admin portal settings
or by using the
[Update an Organization](https://docs.jumpcloud.com/api/1.0/index.html#operation/organization_put)
endpoint.

#### Sample Request

```
curl -X POST https://console.jumpcloud.com/api/v2/bulk/users \\
-H 'Accept: application/json' \\
-H 'Content-Type: application/json' \\
-H 'x-api-key: {API_KEY}' \\
-d '[
  {
    \"email\":\"{email}\",
    \"firstname\":\"{firstname}\",
    \"lastname\":\"{firstname}\",
    \"username\":\"{username}\",
    \"attributes\":[
      {
        \"name\":\"EmployeeID\",
        \"value\":\"0000\"
      },
      {
        \"name\":\"Custom\",
        \"value\":\"attribute\"
      }
    ]
  }
]'
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
Array of bulk-user-create
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: JumpCloud.SDK.V2.Models.IBulkUserCreate[]
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreationSource
Defines the creation-source header for gapps, o365 and workdays requests.
If the header isn't sent, the default value is `jumpcloud:bulk`, if you send the header with a malformed value you receive a 400 error.

```yaml
Type: JumpCloud.SDK.V2.Support.CreationSource2
Parameter Sets: (All)
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

### JumpCloud.SDK.V2.Models.IBulkUserCreate[]

## OUTPUTS

### System.String

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODY <IBulkUserCreate[]>: Array of bulk-user-create
  - `[AccountLocked <Boolean?>]`: 
  - `[Activated <Boolean?>]`: 
  - `[Addresses <IBulkUserCreateAddressesItem[]>]`: 
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
  - `[Attributes <IBulkUserCreateAttributesItem[]>]`: 
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
  - `[ExternalPasswordExpirationDate <DateTime?>]`: 
  - `[ExternalSourceType <String>]`: 
  - `[Firstname <String>]`: 
  - `[JobTitle <String>]`: 
  - `[Lastname <String>]`: 
  - `[LdapBindingUser <Boolean?>]`: 
  - `[Location <String>]`: 
  - `[ManagedAppleId <String>]`: 
  - `[Manager <String>]`: Relation with another systemuser to identify the last as a manager.
  - `[Middlename <String>]`: 
  - `[Password <String>]`: 
  - `[PasswordNeverExpires <Boolean?>]`: 
  - `[PasswordlessSudo <Boolean?>]`: 
  - `[PhoneNumbers <IBulkUserCreatePhoneNumbersItem[]>]`: 
    - `[Number <String>]`: 
    - `[Type <String>]`: 
  - `[PublicKey <String>]`: 
  - `[RecoveryEmailAddress <String>]`: 
  - `[Relationships <IBulkUserCreateRelationshipsItem[]>]`: 
    - `[Type <String>]`: 
    - `[Value <String>]`: 
  - `[SambaServiceUser <Boolean?>]`: 
  - `[State <String>]`: 
  - `[Sudo <Boolean?>]`: 
  - `[Suspended <Boolean?>]`: 
  - `[UnixGuid <Int32?>]`: 
  - `[UnixUid <Int32?>]`: 
  - `[Username <String>]`: 

## RELATED LINKS

