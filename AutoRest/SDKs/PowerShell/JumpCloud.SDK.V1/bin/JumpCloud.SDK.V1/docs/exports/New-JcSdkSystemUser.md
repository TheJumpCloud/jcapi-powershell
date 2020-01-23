---
external help file:
Module Name: JumpCloud.SDK.V1
online version: https://docs.microsoft.com/en-us/powershell/module/jumpcloud.sdk.v1/new-jcsdksystemuser
schema: 2.0.0
---

# New-JcSdkSystemUser

## SYNOPSIS
This endpoint allows you to create a new system user.\n\n#### Sample Request\n\n```\ncurl -X POST https://console.jumpcloud.com/api/systemusers \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n\t\"username\":\"{username}\",\n\t\"email\":\"{email_address}\",\n\t\"firstname\":\"{Name}\",\n\t\"lastname\":\"{Name}\"\n}'\n```

## SYNTAX

### CreateExpanded (Default)
```
New-JcSdkSystemUser -Email <String> -Username <String> [-AccountLocked] [-Activated]
 [-Addresses <ISystemuserputpostAddressesItem[]>] [-AllowPublicKey]
 [-Attributes <ISystemuserputpostAttributesItem[]>] [-Company <String>] [-CostCenter <String>]
 [-Department <String>] [-Description <String>] [-Displayname <String>] [-EmployeeIdentifier <String>]
 [-EmployeeType <String>] [-EnableManagedUid] [-EnableUserPortalMultifactor] [-ExternalDn <String>]
 [-ExternallyManaged] [-ExternalPasswordExpirationDate <String>] [-ExternalSourceType <String>]
 [-Firstname <String>] [-JobTitle <String>] [-Lastname <String>] [-LdapBindingUser] [-Location <String>]
 [-MfaConfigured] [-MfaExclusion] [-MfaExclusionUntil <DateTime>] [-Middlename <String>] [-Password <String>]
 [-PasswordlessSudo] [-PasswordNeverExpires] [-PhoneNumbers <ISystemuserputpostPhoneNumbersItem[]>]
 [-PublicKey <String>] [-Relationships <ISystemuserputpostRelationshipsItem[]>] [-SambaServiceUser] [-Sudo]
 [-Suspended] [-Tags <String[]>] [-UnixGuid <Int32>] [-UnixUid <Int32>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-JcSdkSystemUser -Body <ISystemuserputpost> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
This endpoint allows you to create a new system user.\n\n#### Sample Request\n\n```\ncurl -X POST https://console.jumpcloud.com/api/systemusers \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n\t\"username\":\"{username}\",\n\t\"email\":\"{email_address}\",\n\t\"firstname\":\"{Name}\",\n\t\"lastname\":\"{Name}\"\n}'\n```

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
To view examples, please use the -Online parameter with Get-Help or navigate to: https://docs.microsoft.com/en-us/powershell/module/jumpcloud.sdk.v1/new-jcsdksystemuser
```



## PARAMETERS

### -AccountLocked
HELP MESSAGE MISSING

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Activated
HELP MESSAGE MISSING

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Addresses
HELP MESSAGE MISSING
To construct, see NOTES section for ADDRESSES properties and create a hash table.

```yaml
Type: JumpCloud.SDK.V1.Models.ISystemuserputpostAddressesItem[]
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Type: JumpCloud.SDK.V1.Models.ISystemuserputpostAttributesItem[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Body
SystemUserPost
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: JumpCloud.SDK.V1.Models.ISystemuserputpost
Parameter Sets: Create
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: True
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ExternalPasswordExpirationDate
HELP MESSAGE MISSING

```yaml
Type: System.String
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -JobTitle
HELP MESSAGE MISSING

```yaml
Type: System.String
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -PasswordlessSudo
HELP MESSAGE MISSING

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Type: JumpCloud.SDK.V1.Models.ISystemuserputpostPhoneNumbersItem[]
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Type: JumpCloud.SDK.V1.Models.ISystemuserputpostRelationshipsItem[]
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Suspended
HELP MESSAGE MISSING

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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

### JumpCloud.SDK.V1.Models.ISystemuserputpost

## OUTPUTS

### JumpCloud.SDK.V1.Models.ISystemuserreturn

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### ADDRESSES <ISystemuserputpostAddressesItem[]>: HELP MESSAGE MISSING
  - `[Country <String>]`: 
  - `[ExtendedAddress <String>]`: 
  - `[Locality <String>]`: 
  - `[PoBox <String>]`: 
  - `[PostalCode <String>]`: 
  - `[Region <String>]`: 
  - `[StreetAddress <String>]`: 
  - `[Type <String>]`: 

#### BODY <ISystemuserputpost>: SystemUserPost
  - `Email <String>`: 
  - `Username <String>`: 
  - `[AccountLocked <Boolean?>]`: 
  - `[Activated <Boolean?>]`: 
  - `[Addresses <ISystemuserputpostAddressesItem[]>]`: 
    - `[Country <String>]`: 
    - `[ExtendedAddress <String>]`: 
    - `[Locality <String>]`: 
    - `[PoBox <String>]`: 
    - `[PostalCode <String>]`: 
    - `[Region <String>]`: 
    - `[StreetAddress <String>]`: 
    - `[Type <String>]`: 
  - `[AllowPublicKey <Boolean?>]`: 
  - `[Attributes <ISystemuserputpostAttributesItem[]>]`: 
  - `[Company <String>]`: 
  - `[CostCenter <String>]`: 
  - `[Department <String>]`: 
  - `[Description <String>]`: 
  - `[Displayname <String>]`: 
  - `[EmployeeIdentifier <String>]`: Must be unique per user. 
  - `[EmployeeType <String>]`: 
  - `[EnableManagedUid <Boolean?>]`: 
  - `[EnableUserPortalMultifactor <Boolean?>]`: 
  - `[ExternalDn <String>]`: 
  - `[ExternalPasswordExpirationDate <String>]`: 
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
  - `[PasswordlessSudo <Boolean?>]`: 
  - `[PhoneNumbers <ISystemuserputpostPhoneNumbersItem[]>]`: 
    - `[Number <String>]`: 
    - `[Type <String>]`: 
  - `[PublicKey <String>]`: 
  - `[Relationships <ISystemuserputpostRelationshipsItem[]>]`: 
  - `[SambaServiceUser <Boolean?>]`: 
  - `[Sudo <Boolean?>]`: 
  - `[Suspended <Boolean?>]`: 
  - `[Tags <String[]>]`: 
  - `[UnixGuid <Int32?>]`: 
  - `[UnixUid <Int32?>]`: 

#### PHONENUMBERS <ISystemuserputpostPhoneNumbersItem[]>: HELP MESSAGE MISSING
  - `[Number <String>]`: 
  - `[Type <String>]`: 

## RELATED LINKS

