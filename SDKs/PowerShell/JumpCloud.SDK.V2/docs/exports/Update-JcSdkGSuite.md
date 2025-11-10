---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/CUT-4908_userGroupDeviceGroupFilters/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Update-JcSdkGSuite.md
schema: 2.0.0
---

# Update-JcSdkGSuite

## SYNOPSIS
This endpoint allows updating some attributes of a G Suite.

##### Sample Request

```
curl -X PATCH https://console.jumpcloud.com/api/v2/gsuites/{GSUITE_ID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"userLockoutAction\": \"suspend\",
    \"userPasswordExpirationAction\": \"maintain\"
  }'
```
Sample Request, set a default domain

```
curl -X PATCH https://console.jumpcloud.com/api/v2/gsuites/{GSUITE_ID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"defaultDomain\": {
        \"id\": \"{domainObjectID}\"
      }
  }'
```

Sample Request, unset the default domain

```
curl -X PATCH https://console.jumpcloud.com/api/v2/gsuites/{GSUITE_ID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"defaultDomain\": {}
  }'
```

## SYNTAX

### UpdateExpanded (Default)
```
Update-JcSdkGSuite -HostEnv <String> -Id <String> [-DefaultDomainId <String>] [-GroupsEnabled]
 [-ImportFilter <String>] [-Name <String>] [-UserLockoutAction <String>]
 [-UserPasswordExpirationAction <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-JcSdkGSuite -HostEnv <String> -Id <String> -Body <IGsuite> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-JcSdkGSuite -HostEnv <String> -InputObject <IJumpCloudApiIdentity> -Body <IGsuite> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-JcSdkGSuite -HostEnv <String> -InputObject <IJumpCloudApiIdentity> [-DefaultDomainId <String>]
 [-GroupsEnabled] [-ImportFilter <String>] [-Name <String>] [-UserLockoutAction <String>]
 [-UserPasswordExpirationAction <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
This endpoint allows updating some attributes of a G Suite.

##### Sample Request

```
curl -X PATCH https://console.jumpcloud.com/api/v2/gsuites/{GSUITE_ID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"userLockoutAction\": \"suspend\",
    \"userPasswordExpirationAction\": \"maintain\"
  }'
```
Sample Request, set a default domain

```
curl -X PATCH https://console.jumpcloud.com/api/v2/gsuites/{GSUITE_ID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"defaultDomain\": {
        \"id\": \"{domainObjectID}\"
      }
  }'
```

Sample Request, unset the default domain

```
curl -X PATCH https://console.jumpcloud.com/api/v2/gsuites/{GSUITE_ID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"defaultDomain\": {}
  }'
```

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Update-JcSdkGSuite -Id:(<string>) -Body:(<JumpCloud.SDK.V2.Models.Gsuite>)
```

----                         ----------
DefaultDomainDomain          String
DefaultDomainId              String
GroupsEnabled                Boolean
Id                           String
Name                         String
UserLockoutAction            String
UserPasswordExpirationAction String

### -------------------------- EXAMPLE 2 --------------------------
```powershell
Update-JcSdkGSuite -Id:(<string>) -DefaultDomainId:(<string>) -GroupsEnabled:(<switch>) -Name:(<string>) -UserLockoutAction:(<string>) -UserPasswordExpirationAction:(<string>)
```

----                         ----------
DefaultDomainDomain          String
DefaultDomainId              String
GroupsEnabled                Boolean
Id                           String
Name                         String
UserLockoutAction            String
UserPasswordExpirationAction String

## PARAMETERS

### -Body
GSuite

```yaml
Type: JumpCloud.SDK.V2.Models.IGsuite
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DefaultDomainId
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GroupsEnabled
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
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

### -Id
Unique identifier of the GSuite.

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ImportFilter
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter

```yaml
Type: JumpCloud.SDK.V2.Models.IJumpCloudApiIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Name
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserLockoutAction
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserPasswordExpirationAction
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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

### JumpCloud.SDK.V2.Models.IGsuite

### JumpCloud.SDK.V2.Models.IJumpCloudApiIdentity

## OUTPUTS

### JumpCloud.SDK.V2.Models.IGsuite

## NOTES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODY <IGsuite>`: GSuite
  - `[DefaultDomainId <String>]`: 
  - `[GroupsEnabled <Boolean?>]`: 
  - `[ImportFilter <String>]`: 
  - `[Name <String>]`: 
  - `[UserLockoutAction <String>]`: 
  - `[UserPasswordExpirationAction <String>]`: 

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

