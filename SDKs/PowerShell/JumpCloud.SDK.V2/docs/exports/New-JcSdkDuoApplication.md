---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/New-JcSdkDuoApplication.md
schema: 2.0.0
---

# New-JcSdkDuoApplication

## SYNOPSIS
Creates a Duo application for your organization and the specified account.

#### Sample Request
```
  curl -X POST https://console.jumpcloud.com/api/v2/duo/accounts/{ACCOUNT_ID}/applications \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"name\": \"Application Name\",
    \"apiHost\": \"api-1234.duosecurity.com\",
    \"integrationKey\": \"1234\",
    \"secretKey\": \"5678\"
  }'
```

## SYNTAX

### CreateExpanded (Default)
```
New-JcSdkDuoApplication -AccountId <String> -ApiHost <String> -IntegrationKey <String> -Name <String>
 -SecretKey <String> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-JcSdkDuoApplication -AccountId <String> -Body <IDuoApplicationReq> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### CreateViaIdentity
```
New-JcSdkDuoApplication -InputObject <IJumpCloudApiIdentity> -Body <IDuoApplicationReq> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-JcSdkDuoApplication -InputObject <IJumpCloudApiIdentity> -ApiHost <String> -IntegrationKey <String>
 -Name <String> -SecretKey <String> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Creates a Duo application for your organization and the specified account.

#### Sample Request
```
  curl -X POST https://console.jumpcloud.com/api/v2/duo/accounts/{ACCOUNT_ID}/applications \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"name\": \"Application Name\",
    \"apiHost\": \"api-1234.duosecurity.com\",
    \"integrationKey\": \"1234\",
    \"secretKey\": \"5678\"
  }'
```

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
New-JcSdkDuoApplication -AccountId:(<string>) -ApiHost:(<string>) -IntegrationKey:(<string>) -Name:(<string>) -SecretKey:(<string>)
```

----           ----------
ApiHost        String
Id             String
IntegrationKey String
Name           String

### -------------------------- EXAMPLE 2 --------------------------
```powershell
New-JcSdkDuoApplication -AccountId:(<string>) -Body:(<JumpCloud.SDK.V2.Models.DuoApplicationReq>)
```

----           ----------
ApiHost        String
Id             String
IntegrationKey String
Name           String

## PARAMETERS

### -AccountId
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

### -ApiHost
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

### -Body
DuoApplicationReq
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: JumpCloud.SDK.V2.Models.IDuoApplicationReq
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### -IntegrationKey
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

### -Name
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

### -SecretKey
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

### JumpCloud.SDK.V2.Models.IDuoApplicationReq

### JumpCloud.SDK.V2.Models.IJumpCloudApiIdentity

## OUTPUTS

### JumpCloud.SDK.V2.Models.IDuoApplication

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODY <IDuoApplicationReq>: DuoApplicationReq
  - `ApiHost <String>`: 
  - `IntegrationKey <String>`: 
  - `Name <String>`: 
  - `SecretKey <String>`: 

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

