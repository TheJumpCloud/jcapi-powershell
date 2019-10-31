---
external help file:
Module Name: JumpCloudApiSdkV1
online version: https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv1/set-jcsdksystemuser
schema: 2.0.0
---

# Set-JcSdkSystemUser

## SYNOPSIS
This endpoint allows you to update a system user.\n\n#### Sample Request\n\n```\ncurl -X PUT https://console.jumpcloud.com/api/systemusers/{UserID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n\t\"email\":\"{email_address}\",\n\t\"firstname\":\"{Name}\",\n\t\"lastname\":\"{Name}\"\n}'\n```

## SYNTAX

### PutExpanded (Default)
```
Set-JcSdkSystemUser -Id <String> [-AccountLocked] [-Addresses <ISystemuserputAddressesItem[]>]
 [-AllowPublicKey] [-Attributes <ISystemuserputAttributesItem[]>] [-Company <String>] [-CostCenter <String>]
 [-Department <String>] [-Description <String>] [-Displayname <String>] [-Email <String>]
 [-EmployeeIdentifier <String>] [-EmployeeType <String>] [-EnableManagedUid] [-EnableUserPortalMultifactor]
 [-ExternalDn <String>] [-ExternallyManaged] [-ExternalSourceType <String>] [-Firstname <String>]
 [-JobTitle <String>] [-Lastname <String>] [-LdapBindingUser] [-Location <String>] [-MfaConfigured]
 [-MfaExclusion] [-MfaExclusionUntil <DateTime>] [-Middlename <String>] [-Password <String>]
 [-PasswordNeverExpires] [-PhoneNumbers <ISystemuserputPhoneNumbersItem[]>] [-PublicKey <String>]
 [-Relationships <ISystemuserputRelationshipsItem[]>] [-SambaServiceUser] [-SshKeys <ISshkeypost[]>] [-Sudo]
 [-Tags <String[]>] [-UnixGuid <Int32>] [-UnixUid <Int32>] [-Username <String>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Put
```
Set-JcSdkSystemUser -Id <String> -Body <ISystemuserput> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### PutViaIdentity
```
Set-JcSdkSystemUser -InputObject <IJumpCloudApIsIdentity> -Body <ISystemuserput> [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### PutViaIdentityExpanded
```
Set-JcSdkSystemUser -InputObject <IJumpCloudApIsIdentity> [-AccountLocked]
 [-Addresses <ISystemuserputAddressesItem[]>] [-AllowPublicKey] [-Attributes <ISystemuserputAttributesItem[]>]
 [-Company <String>] [-CostCenter <String>] [-Department <String>] [-Description <String>]
 [-Displayname <String>] [-Email <String>] [-EmployeeIdentifier <String>] [-EmployeeType <String>]
 [-EnableManagedUid] [-EnableUserPortalMultifactor] [-ExternalDn <String>] [-ExternallyManaged]
 [-ExternalSourceType <String>] [-Firstname <String>] [-JobTitle <String>] [-Lastname <String>]
 [-LdapBindingUser] [-Location <String>] [-MfaConfigured] [-MfaExclusion] [-MfaExclusionUntil <DateTime>]
 [-Middlename <String>] [-Password <String>] [-PasswordNeverExpires]
 [-PhoneNumbers <ISystemuserputPhoneNumbersItem[]>] [-PublicKey <String>]
 [-Relationships <ISystemuserputRelationshipsItem[]>] [-SambaServiceUser] [-SshKeys <ISshkeypost[]>] [-Sudo]
 [-Tags <String[]>] [-UnixGuid <Int32>] [-UnixUid <Int32>] [-Username <String>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
This endpoint allows you to update a system user.\n\n#### Sample Request\n\n```\ncurl -X PUT https://console.jumpcloud.com/api/systemusers/{UserID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n\t\"email\":\"{email_address}\",\n\t\"firstname\":\"{Name}\",\n\t\"lastname\":\"{Name}\"\n}'\n```

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
To view examples, please use the -Online parameter with Get-Help or navigate to: https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv1/set-jcsdksystemuser
```



## PARAMETERS

### -AccountLocked
HELP MESSAGE MISSING

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Addresses
type, poBox, extendedAddress, streetAddress, locality, region, postalCode, country
To construct, see NOTES section for ADDRESSES properties and create a hash table.

```yaml
Type: JumpCloudApiSdkV1.Models.ISystemuserputAddressesItem[]
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -AllowPublicKey
HELP MESSAGE MISSING

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Attributes
HELP MESSAGE MISSING

```yaml
Type: JumpCloudApiSdkV1.Models.ISystemuserputAttributesItem[]
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Body
SystemUserPut
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: JumpCloudApiSdkV1.Models.ISystemuserput
Parameter Sets: Put, PutViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -Company
HELP MESSAGE MISSING

```yaml
Type: System.String
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -CostCenter
HELP MESSAGE MISSING

```yaml
Type: System.String
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Department
HELP MESSAGE MISSING

```yaml
Type: System.String
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Description
HELP MESSAGE MISSING

```yaml
Type: System.String
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Displayname
HELP MESSAGE MISSING

```yaml
Type: System.String
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Email
HELP MESSAGE MISSING

```yaml
Type: System.String
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -EmployeeIdentifier
Must be unique per user.

```yaml
Type: System.String
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -EmployeeType
HELP MESSAGE MISSING

```yaml
Type: System.String
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -EnableManagedUid
HELP MESSAGE MISSING

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -EnableUserPortalMultifactor
HELP MESSAGE MISSING

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ExternalDn
HELP MESSAGE MISSING

```yaml
Type: System.String
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ExternallyManaged
HELP MESSAGE MISSING

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ExternalSourceType
HELP MESSAGE MISSING

```yaml
Type: System.String
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Firstname
HELP MESSAGE MISSING

```yaml
Type: System.String
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Id
HELP MESSAGE MISSING

```yaml
Type: System.String
Parameter Sets: Put, PutExpanded
Aliases:

Required: True
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
Type: JumpCloudApiSdkV1.Models.IJumpCloudApIsIdentity
Parameter Sets: PutViaIdentity, PutViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -JobTitle
HELP MESSAGE MISSING

```yaml
Type: System.String
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Lastname
HELP MESSAGE MISSING

```yaml
Type: System.String
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -LdapBindingUser
HELP MESSAGE MISSING

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Location
HELP MESSAGE MISSING

```yaml
Type: System.String
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -MfaConfigured
HELP MESSAGE MISSING

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -MfaExclusion
HELP MESSAGE MISSING

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -MfaExclusionUntil
HELP MESSAGE MISSING

```yaml
Type: System.DateTime
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Middlename
HELP MESSAGE MISSING

```yaml
Type: System.String
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -PassThru
Returns true when the command succeeds

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Password
HELP MESSAGE MISSING

```yaml
Type: System.String
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -PasswordNeverExpires
HELP MESSAGE MISSING

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -PhoneNumbers
HELP MESSAGE MISSING
To construct, see NOTES section for PHONENUMBERS properties and create a hash table.

```yaml
Type: JumpCloudApiSdkV1.Models.ISystemuserputPhoneNumbersItem[]
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -PublicKey
HELP MESSAGE MISSING

```yaml
Type: System.String
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Relationships
HELP MESSAGE MISSING

```yaml
Type: JumpCloudApiSdkV1.Models.ISystemuserputRelationshipsItem[]
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SambaServiceUser
HELP MESSAGE MISSING

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SshKeys
HELP MESSAGE MISSING
To construct, see NOTES section for SSHKEYS properties and create a hash table.

```yaml
Type: JumpCloudApiSdkV1.Models.ISshkeypost[]
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Sudo
HELP MESSAGE MISSING

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Tags
HELP MESSAGE MISSING

```yaml
Type: System.String[]
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -UnixGuid
HELP MESSAGE MISSING

```yaml
Type: System.Int32
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -UnixUid
HELP MESSAGE MISSING

```yaml
Type: System.Int32
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Username
HELP MESSAGE MISSING

```yaml
Type: System.String
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
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

### JumpCloudApiSdkV1.Models.IJumpCloudApIsIdentity

### JumpCloudApiSdkV1.Models.ISystemuserput

## OUTPUTS

### JumpCloudApiSdkV1.Models.ISystemuserreturn

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### ADDRESSES <ISystemuserputAddressesItem[]>: type, poBox, extendedAddress, streetAddress, locality, region, postalCode, country
  - `[Country <String>]`: 
  - `[ExtendedAddress <String>]`: 
  - `[Locality <String>]`: 
  - `[PoBox <String>]`: 
  - `[PostalCode <String>]`: 
  - `[Region <String>]`: 
  - `[StreetAddress <String>]`: 
  - `[Type <String>]`: 

#### BODY <ISystemuserput>: SystemUserPut
  - `[AccountLocked <Boolean?>]`: 
  - `[Addresses <ISystemuserputAddressesItem[]>]`: type, poBox, extendedAddress, streetAddress, locality, region, postalCode, country
    - `[Country <String>]`: 
    - `[ExtendedAddress <String>]`: 
    - `[Locality <String>]`: 
    - `[PoBox <String>]`: 
    - `[PostalCode <String>]`: 
    - `[Region <String>]`: 
    - `[StreetAddress <String>]`: 
    - `[Type <String>]`: 
  - `[AllowPublicKey <Boolean?>]`: 
  - `[Attributes <ISystemuserputAttributesItem[]>]`: 
  - `[Company <String>]`: 
  - `[CostCenter <String>]`: 
  - `[Department <String>]`: 
  - `[Description <String>]`: 
  - `[Displayname <String>]`: 
  - `[Email <String>]`: 
  - `[EmployeeIdentifier <String>]`: Must be unique per user. 
  - `[EmployeeType <String>]`: 
  - `[EnableManagedUid <Boolean?>]`: 
  - `[EnableUserPortalMultifactor <Boolean?>]`: 
  - `[ExternalDn <String>]`: 
  - `[ExternalSourceType <String>]`: 
  - `[ExternallyManaged <Boolean?>]`: 
  - `[Firstname <String>]`: 
  - `[JobTitle <String>]`: 
  - `[Lastname <String>]`: 
  - `[LdapBindingUser <Boolean?>]`: 
  - `[Location <String>]`: 
  - `[MfaConfigured <Boolean?>]`: 
  - `[MfaExclusion <Boolean?>]`: 
  - `[MfaExclusionUntil <DateTime?>]`: 
  - `[Middlename <String>]`: 
  - `[Password <String>]`: 
  - `[PasswordNeverExpires <Boolean?>]`: 
  - `[PhoneNumbers <ISystemuserputPhoneNumbersItem[]>]`: 
    - `[Number <String>]`: 
    - `[Type <String>]`: 
  - `[PublicKey <String>]`: 
  - `[Relationships <ISystemuserputRelationshipsItem[]>]`: 
  - `[SambaServiceUser <Boolean?>]`: 
  - `[SshKeys <ISshkeypost[]>]`: 
    - `Name <String>`: The name of the SSH key.
    - `PublicKey <String>`: The Public SSH key.
  - `[Sudo <Boolean?>]`: 
  - `[Tags <String[]>]`: 
  - `[UnixGuid <Int32?>]`: 
  - `[UnixUid <Int32?>]`: 
  - `[Username <String>]`: 

#### INPUTOBJECT <IJumpCloudApIsIdentity>: Identity Parameter
  - `[Id <String>]`: 
  - `[SystemuserId <String>]`: 
  - `[Triggername <String>]`: 

#### PHONENUMBERS <ISystemuserputPhoneNumbersItem[]>: HELP MESSAGE MISSING
  - `[Number <String>]`: 
  - `[Type <String>]`: 

#### SSHKEYS <ISshkeypost[]>: HELP MESSAGE MISSING
  - `Name <String>`: The name of the SSH key.
  - `PublicKey <String>`: The Public SSH key.

## RELATED LINKS

