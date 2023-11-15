---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Set-JcSdkUserGroup.md
schema: 2.0.0
---

# Set-JcSdkUserGroup

## SYNOPSIS
This endpoint allows you to do a full update of the User Group.

See the [Dynamic Group Configuration KB article](https://jumpcloud.com/support/configure-dynamic-device-groups) for more details on maintaining a Dynamic Group.

#### Sample Request
```
curl -X PUT https://console.jumpcloud.com/api/v2/usergroups/{Group_ID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"name\": \"group_update\"
  }'
```

## SYNTAX

### SetExpanded (Default)
```
Set-JcSdkUserGroup -Id <String> -Name <String> [-Attributes <Hashtable>] [-Description <String>]
 [-Email <String>] [-MemberQueryExemptions <IGraphObject[]>] [-MemberQueryFilters <IFilter[]>]
 [-MembershipMethod <String>] [-MemberSuggestionsNotify] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Set
```
Set-JcSdkUserGroup -Id <String> -Body <IUserGroupPut> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### SetViaIdentity
```
Set-JcSdkUserGroup -InputObject <IJumpCloudApiIdentity> -Body <IUserGroupPut> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### SetViaIdentityExpanded
```
Set-JcSdkUserGroup -InputObject <IJumpCloudApiIdentity> -Name <String> [-Attributes <Hashtable>]
 [-Description <String>] [-Email <String>] [-MemberQueryExemptions <IGraphObject[]>]
 [-MemberQueryFilters <IFilter[]>] [-MembershipMethod <String>] [-MemberSuggestionsNotify] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
This endpoint allows you to do a full update of the User Group.

See the [Dynamic Group Configuration KB article](https://jumpcloud.com/support/configure-dynamic-device-groups) for more details on maintaining a Dynamic Group.

#### Sample Request
```
curl -X PUT https://console.jumpcloud.com/api/v2/usergroups/{Group_ID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"name\": \"group_update\"
  }'
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

### -Attributes
The graph attributes for a UserGroup.

```yaml
Type: System.Collections.Hashtable
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Body
UserGroupPut
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: JumpCloud.SDK.V2.Models.IUserGroupPut
Parameter Sets: Set, SetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Description
Description of a User Group

```yaml
Type: System.String
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Email
Email address of a User Group

```yaml
Type: System.String
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
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

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: JumpCloud.SDK.V2.Models.IJumpCloudApiIdentity
Parameter Sets: SetViaIdentity, SetViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -MemberQueryExemptions
Array of GraphObjects exempted from the query
To construct, see NOTES section for MEMBERQUERYEXEMPTIONS properties and create a hash table.

```yaml
Type: JumpCloud.SDK.V2.Models.IGraphObject[]
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MemberQueryFilters
.
To construct, see NOTES section for MEMBERQUERYFILTERS properties and create a hash table.

```yaml
Type: JumpCloud.SDK.V2.Models.IFilter[]
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MembershipMethod
The type of membership method for this group.
Valid values include NOTSET, STATIC, DYNAMIC_REVIEW_REQUIRED, and DYNAMIC_AUTOMATED.Note DYNAMIC_AUTOMATED and DYNAMIC_REVIEW_REQUIRED group rules will supersede any group enrollment for [group-associated MDM-enrolled devices](https://jumpcloud.com/support/change-a-default-device-group-for-apple-devices).Use caution when creating dynamic device groups with MDM-enrolled devices to avoid creating conflicting rule sets.

```yaml
Type: System.String
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MemberSuggestionsNotify
True if notification emails are to be sent for membership suggestions.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
Display name of a User Group.

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

### JumpCloud.SDK.V2.Models.IUserGroupPut

## OUTPUTS

### JumpCloud.SDK.V2.Models.IUserGroup

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODY <IUserGroupPut>: UserGroupPut
  - `Name <String>`: Display name of a User Group.
  - `[Attributes <IGroupAttributesUserGroup>]`: The graph attributes for a UserGroup.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[SudoEnabled <Boolean?>]`: Enables sudo
    - `[SudoWithoutPassword <Boolean?>]`: Enable sudo without password (requires 'enabled' to be true)
    - `[LdapGroups <ILdapGroup[]>]`: 
      - `[Name <String>]`: 
    - `[PosixGroups <IGraphAttributePosixGroupsItem[]>]`: 
      - `Id <Int32>`: 
      - `Name <String>`: 
    - `[RadiusReply <IGraphAttributeRadiusReplyItem[]>]`: 
      - `Name <String>`: 
      - `Value <String>`: 
    - `[SambaEnabled <Boolean?>]`: 
  - `[Description <String>]`: Description of a User Group
  - `[Email <String>]`: Email address of a User Group
  - `[MemberQueryExemptions <IGraphObject[]>]`: Array of GraphObjects exempted from the query
    - `Id <String>`: The ObjectID of the graph object.
    - `Type <String>`: The type of graph object.
    - `[Attributes <IGraphAttributes>]`: The graph attributes.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[MemberQueryFilters <IFilter[]>]`: 
    - `Field <String>`: Name of field in filter target object.
    - `Operator <String>`: Filter comparison operator.
    - `Value <String>`: Filter comparison value.
  - `[MemberSuggestionsNotify <Boolean?>]`: True if notification emails are to be sent for membership suggestions.
  - `[MembershipMethod <String>]`: The type of membership method for this group. Valid values include NOTSET, STATIC, DYNAMIC_REVIEW_REQUIRED, and DYNAMIC_AUTOMATED.          Note DYNAMIC_AUTOMATED and DYNAMIC_REVIEW_REQUIRED group rules will supersede any group enrollment for [group-associated MDM-enrolled devices](https://jumpcloud.com/support/change-a-default-device-group-for-apple-devices).          Use caution when creating dynamic device groups with MDM-enrolled devices to avoid creating conflicting rule sets.

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

MEMBERQUERYEXEMPTIONS <IGraphObject[]>: Array of GraphObjects exempted from the query
  - `Id <String>`: The ObjectID of the graph object.
  - `Type <String>`: The type of graph object.
  - `[Attributes <IGraphAttributes>]`: The graph attributes.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.

MEMBERQUERYFILTERS <IFilter[]>: .
  - `Field <String>`: Name of field in filter target object.
  - `Operator <String>`: Filter comparison operator.
  - `Value <String>`: Filter comparison value.

## RELATED LINKS

