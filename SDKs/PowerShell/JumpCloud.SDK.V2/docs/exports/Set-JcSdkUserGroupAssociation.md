---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Set-JcSdkUserGroupAssociation.md
schema: 2.0.0
---

# Set-JcSdkUserGroupAssociation

## SYNOPSIS
This endpoint manages the _direct_ associations of this User Group.\n\nA direct association can be a non-homogeneous relationship between 2 different objects, for example User Groups and Users.\n\n\n#### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/usergroups/{GroupID}/associations \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n    \"op\": \"add\",\n    \"type\": \"system\",\n    \"id\": \"{SystemID}\"\n}'\n\n```

## SYNTAX

### SetExpanded (Default)
```
Set-JcSdkUserGroupAssociation -GroupId <String> -Id <String> -Op <Op> -Type <Type2>
 [-Attributes <IUserGroupGraphManagementReqAttributes>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Set
```
Set-JcSdkUserGroupAssociation -GroupId <String> -Body <IUserGroupGraphManagementReq> [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### SetViaIdentity
```
Set-JcSdkUserGroupAssociation -InputObject <IJumpCloudApIsIdentity> -Body <IUserGroupGraphManagementReq>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### SetViaIdentityExpanded
```
Set-JcSdkUserGroupAssociation -InputObject <IJumpCloudApIsIdentity> -Id <String> -Op <Op> -Type <Type2>
 [-Attributes <IUserGroupGraphManagementReqAttributes>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
This endpoint manages the _direct_ associations of this User Group.\n\nA direct association can be a non-homogeneous relationship between 2 different objects, for example User Groups and Users.\n\n\n#### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/usergroups/{GroupID}/associations \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n    \"op\": \"add\",\n    \"type\": \"system\",\n    \"id\": \"{SystemID}\"\n}'\n\n```

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

### -Attributes
The graph connection's attributes.

```yaml
Type: JumpCloud.SDK.V2.Models.IUserGroupGraphManagementReqAttributes
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Body
UserGroupGraphManagementReq
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: JumpCloud.SDK.V2.Models.IUserGroupGraphManagementReq
Parameter Sets: Set, SetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -GroupId
ObjectID of the User Group.

```yaml
Type: System.String
Parameter Sets: Set, SetExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
The ObjectID of graph object being added or removed as an association.

```yaml
Type: System.String
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity
Parameter Sets: SetViaIdentity, SetViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Op
How to modify the graph connection.

```yaml
Type: JumpCloud.SDK.V2.Support.Op
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
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
```

### -Type
The graph type

```yaml
Type: JumpCloud.SDK.V2.Support.Type2
Parameter Sets: SetExpanded, SetViaIdentityExpanded
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

### JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity

### JumpCloud.SDK.V2.Models.IUserGroupGraphManagementReq

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODY <IUserGroupGraphManagementReq>: UserGroupGraphManagementReq
  - `Id <String>`: The ObjectID of graph object being added or removed as an association.
  - `Op <Op>`: How to modify the graph connection.
  - `Type <Type2>`: The graph type
  - `[Attributes <IUserGroupGraphManagementReqAttributes>]`: The graph connection's attributes.

INPUTOBJECT <IJumpCloudApIsIdentity>: Identity Parameter
  - `[AccountId <String>]`: 
  - `[ActivedirectoryId <String>]`: 
  - `[AppleMdmId <String>]`: 
  - `[ApplicationId <String>]`: ObjectID of the Application.
  - `[CommandId <String>]`: ObjectID of the Command.
  - `[DeviceId <String>]`: 
  - `[GroupId <String>]`: ObjectID of the System Group.
  - `[GsuiteId <String>]`: ObjectID of the G Suite instance.
  - `[Id <String>]`: 
  - `[JobId <String>]`: 
  - `[LdapserverId <String>]`: ObjectID of the LDAP Server.
  - `[Office365Id <String>]`: ObjectID of the Office 365 instance.
  - `[PolicyId <String>]`: ObjectID of the Policy.
  - `[ProviderId <String>]`: 
  - `[RadiusserverId <String>]`: ObjectID of the Radius Server.
  - `[SoftwareAppId <String>]`: ObjectID of the Software App.
  - `[SystemId <String>]`: ObjectID of the System.
  - `[UserId <String>]`: ObjectID of the User.
  - `[WorkdayId <String>]`: 

## RELATED LINKS

