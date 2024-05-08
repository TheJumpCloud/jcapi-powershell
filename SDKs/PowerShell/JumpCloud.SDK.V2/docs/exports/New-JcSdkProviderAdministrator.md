---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/New-JcSdkProviderAdministrator.md
schema: 2.0.0
---

# New-JcSdkProviderAdministrator

## SYNOPSIS
This endpoint allows you to create a provider administrator.
You must be associated with the provider to use this route.
You must provide either `role` or `roleName`.

## SYNTAX

### CreateExpanded (Default)
```
New-JcSdkProviderAdministrator -ProviderId <String> -Email <String> [-ApiKeyAllowed] [-BindNoOrgs]
 [-EnableMultiFactor] [-Firstname <String>] [-Lastname <String>] [-Role <String>] [-RoleName <String>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-JcSdkProviderAdministrator -ProviderId <String> -Body <IProviderAdminReq> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### CreateViaIdentity
```
New-JcSdkProviderAdministrator -InputObject <IJumpCloudApiIdentity> -Body <IProviderAdminReq> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-JcSdkProviderAdministrator -InputObject <IJumpCloudApiIdentity> -Email <String> [-ApiKeyAllowed]
 [-BindNoOrgs] [-EnableMultiFactor] [-Firstname <String>] [-Lastname <String>] [-Role <String>]
 [-RoleName <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
This endpoint allows you to create a provider administrator.
You must be associated with the provider to use this route.
You must provide either `role` or `roleName`.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
New-JcSdkProviderAdministrator -ProviderId:(<string>) -Email:(<string>) -ApiKeyAllowed:(<switch>) -BindNoOrgs:(<switch>) -EnableMultiFactor:(<switch>) -Firstname:(<string>) -Lastname:(<string>) -Role:(<string>) -RoleName:(<string>)
```

----                    ----------
ApiKeyAllowed           Boolean
ApiKeySet               Boolean
Email                   String
EnableMultiFactor       Boolean
Firstname               String
Id                      String
Lastname                String
OrganizationAccessTotal System.Nullable[float] OrganizationAccessTotal {get;set;}
Registered              Boolean
Role                    String
RoleName                String
Suspended               Boolean

### -------------------------- EXAMPLE 2 --------------------------
```powershell
New-JcSdkProviderAdministrator -ProviderId:(<string>) -Body:(<JumpCloud.SDK.V2.Models.ProviderAdminReq>)
```

----                    ----------
ApiKeyAllowed           Boolean
ApiKeySet               Boolean
Email                   String
EnableMultiFactor       Boolean
Firstname               String
Id                      String
Lastname                String
OrganizationAccessTotal System.Nullable[float] OrganizationAccessTotal {get;set;}
Registered              Boolean
Role                    String
RoleName                String
Suspended               Boolean

## PARAMETERS

### -ApiKeyAllowed
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BindNoOrgs
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Body
ProviderAdminReq
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: JumpCloud.SDK.V2.Models.IProviderAdminReq
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Email
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EnableMultiFactor
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Firstname
.

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

### -Lastname
.

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

### -ProviderId
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

### -Role
.

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

### -RoleName
.

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

### JumpCloud.SDK.V2.Models.IProviderAdminReq

## OUTPUTS

### JumpCloud.SDK.V2.Models.IAdministrator

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODY <IProviderAdminReq>: ProviderAdminReq
  - `Email <String>`: 
  - `[ApiKeyAllowed <Boolean?>]`: 
  - `[BindNoOrgs <Boolean?>]`: 
  - `[EnableMultiFactor <Boolean?>]`: 
  - `[Firstname <String>]`: 
  - `[Lastname <String>]`: 
  - `[Role <String>]`: 
  - `[RoleName <String>]`: 

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

