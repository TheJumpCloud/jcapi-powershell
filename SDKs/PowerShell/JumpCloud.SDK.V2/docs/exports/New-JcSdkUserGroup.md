---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/New-JcSdkUserGroup.md
schema: 2.0.0
---

# New-JcSdkUserGroup

## SYNOPSIS
This endpoint allows you to create a new User Group.

#### Sample Request
```
curl -X POST https://console.jumpcloud.com/api/v2/usergroups \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"name\": \"{Group_Name}\"
  }'
```

## SYNTAX

### CreateExpanded (Default)
```
New-JcSdkUserGroup -Name <String> [-Attributes <Hashtable>] [-Description <String>] [-Email <String>]
 [-MemberQueryExemptions <IGraphObject[]>] [-MemberQueryFilters <IFilter[]>] [-MembershipAutomated]
 [-MembershipMethod <String>] [-MemberSuggestionsNotify] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-JcSdkUserGroup -Body <IUserGroupPost> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
This endpoint allows you to create a new User Group.

#### Sample Request
```
curl -X POST https://console.jumpcloud.com/api/v2/usergroups \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"name\": \"{Group_Name}\"
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Body
UserGroupPost
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: JumpCloud.SDK.V2.Models.IUserGroupPost
Parameter Sets: Create
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MemberQueryExemptions
Array of GraphObjects exempted from the query
To construct, see NOTES section for MEMBERQUERYEXEMPTIONS properties and create a hash table.

```yaml
Type: JumpCloud.SDK.V2.Models.IGraphObject[]
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MembershipAutomated
True if membership of this group is automatically updated based on the Member Query and Member Query Exemptions, if configured

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MembershipMethod
The type of membership method for this group.
Valid values include NOTSET, STATIC, DYNAMIC_REVIEW_REQUIRED, and DYNAMIC_AUTOMATED.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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

### JumpCloud.SDK.V2.Models.IUserGroupPost

## OUTPUTS

### JumpCloud.SDK.V2.Models.IUserGroup

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODY <IUserGroupPost>: UserGroupPost
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
  - `[MembershipAutomated <Boolean?>]`: True if membership of this group is automatically updated based on the Member Query and Member Query Exemptions, if configured
  - `[MembershipMethod <String>]`: The type of membership method for this group. Valid values include NOTSET, STATIC, DYNAMIC_REVIEW_REQUIRED, and DYNAMIC_AUTOMATED.

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

