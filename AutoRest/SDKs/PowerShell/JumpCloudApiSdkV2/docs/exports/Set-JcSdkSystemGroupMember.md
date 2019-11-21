---
external help file:
Module Name: JumpCloudApiSdkV2
online version: https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv2/set-jcsdksystemgroupmember
schema: 2.0.0
---

# Set-JcSdkSystemGroupMember

## SYNOPSIS
This endpoint allows you to manage the system members of a System Group.\n\n#### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/systemgroups/{Group_ID}/members \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n    \"op\": \"add\",\n    \"type\": \"system\",\n    \"id\": \"{System_ID}\"\n}'\n```

## SYNTAX

### SetExpanded (Default)
```
Set-JcSdkSystemGroupMember -GroupId <String> -Id <String> -Op <String> [-Authorization <String>]
 [-Date <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Set
```
Set-JcSdkSystemGroupMember -GroupId <String> -Body <ISystemGroupMembersReq> [-Authorization <String>]
 [-Date <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### SetViaIdentity
```
Set-JcSdkSystemGroupMember -InputObject <IJumpCloudApIsIdentity> -Body <ISystemGroupMembersReq>
 [-Authorization <String>] [-Date <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### SetViaIdentityExpanded
```
Set-JcSdkSystemGroupMember -InputObject <IJumpCloudApIsIdentity> -Id <String> -Op <String>
 [-Authorization <String>] [-Date <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
This endpoint allows you to manage the system members of a System Group.\n\n#### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/systemgroups/{Group_ID}/members \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n    \"op\": \"add\",\n    \"type\": \"system\",\n    \"id\": \"{System_ID}\"\n}'\n```

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
To view examples, please use the -Online parameter with Get-Help or navigate to: https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv2/set-jcsdksystemgroupmember
```



## PARAMETERS

### -Authorization
Authorization header for the System Context API

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Body
SystemGroupMembersReq
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: JumpCloudApiSdkV2.Models.ISystemGroupMembersReq
Parameter Sets: Set, SetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -Date
Current date header for the System Context API

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -GroupId
ObjectID of the System Group.

```yaml
Type: System.String
Parameter Sets: Set, SetExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Id
The ObjectID of member being added or removed.

```yaml
Type: System.String
Parameter Sets: SetExpanded, SetViaIdentityExpanded
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
Type: JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentity
Parameter Sets: SetViaIdentity, SetViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -Op
How to modify the membership connection.

```yaml
Type: System.String
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: True
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

### JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentity

### JumpCloudApiSdkV2.Models.ISystemGroupMembersReq

## OUTPUTS

### System.Boolean

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### BODY <ISystemGroupMembersReq>: SystemGroupMembersReq
  - `Id <String>`: The ObjectID of member being added or removed.
  - `Op <String>`: How to modify the membership connection.

#### INPUTOBJECT <IJumpCloudApIsIdentity>: Identity Parameter
  - `[ActivedirectoryId <String>]`: ObjectID of the Active Directory instance.
  - `[ApplicationId <String>]`: ObjectID of the Application.
  - `[CommandId <String>]`: ObjectID of the Command.
  - `[GroupId <String>]`: ObjectID of the User Group.
  - `[GsuiteId <String>]`: ObjectID of the G Suite instance.
  - `[Id <String>]`: ObjectID of the User Group.
  - `[JobId <String>]`: 
  - `[LdapserverId <String>]`: ObjectID of the LDAP Server.
  - `[Office365Id <String>]`: ObjectID of the Office 365 instance.
  - `[PolicyId <String>]`: ObjectID of the Policy.
  - `[ProviderId <String>]`: 
  - `[RadiusserverId <String>]`: ObjectID of the Radius Server.
  - `[SystemId <String>]`: 
  - `[UserId <String>]`: ObjectID of the User.
  - `[WorkdayId <String>]`: 

## RELATED LINKS

