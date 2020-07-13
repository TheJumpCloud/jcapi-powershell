---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/jumpcloud.sdk.v2/new-jcsdkusergroup
schema: 2.0.0
---

# New-JcSdkUserGroup

## SYNOPSIS
This endpoint allows you to create a new User Group.\n\n#### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/usergroups \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n \"name\": \"{Group_Name}\"\n}'\n\n```

## SYNTAX

### CreateExpanded (Default)
```
New-JcSdkUserGroup -Name <String> [-AttributePosixGroups <IUserGroupAttributesPosixGroupsItem[]>]
 [-AttributeSambaEnabled] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-JcSdkUserGroup -Body <IUserGroupPost> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
This endpoint allows you to create a new User Group.\n\n#### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/usergroups \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n \"name\": \"{Group_Name}\"\n}'\n\n```

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

### -AttributePosixGroups
.
To construct, see NOTES section for ATTRIBUTEPOSIXGROUPS properties and create a hash table.

```yaml
Type: JumpCloud.SDK.V2.Models.IUserGroupAttributesPosixGroupsItem[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AttributeSambaEnabled
.

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


ATTRIBUTEPOSIXGROUPS <IUserGroupAttributesPosixGroupsItem[]>: .
  - `[Id <Int32?>]`: 
  - `[Name <String>]`: 

BODY <IUserGroupPost>: UserGroupPost
  - `Name <String>`: Display name of a User Group.
  - `[AttributePosixGroups <IUserGroupAttributesPosixGroupsItem[]>]`: 
    - `[Id <Int32?>]`: 
    - `[Name <String>]`: 
  - `[AttributeSambaEnabled <Boolean?>]`: 

## RELATED LINKS

