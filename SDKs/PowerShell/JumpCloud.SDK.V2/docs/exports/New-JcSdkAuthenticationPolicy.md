---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/New-JcSdkAuthenticationPolicy.md
schema: 2.0.0
---

# New-JcSdkAuthenticationPolicy

## SYNOPSIS
Create an authentication policy.\n\n#### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/authn/policies \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n    \"name\": \"Sample Policy\",\n    \"disabled\": false,\n    \"effect\": {\n      \"action\": \"allow\"\n    },\n    \"targets\": {\n      \"users\": {\n        \"inclusions\": [\"ALL\"]\n      },\n      \"userGroups\": {\n        \"exclusions\": [{USER_GROUP_ID}]\n      },\n      \"resources\": [ {\"type\": \"user_portal\" } ]\n    },\n    \"conditions\":{\n      \"ipAddressIn\": [{IP_LIST_ID}]\n    }\n  }'\n```

## SYNTAX

### CreateExpanded (Default)
```
New-JcSdkAuthenticationPolicy [-Conditions <Hashtable>] [-Description <String>] [-Disabled]
 [-EffectAction <String>] [-MfaRequired] [-Name <String>] [-TargetResources <IAuthnPolicyResourceTarget[]>]
 [-UserGroupExclusions <String[]>] [-UserGroupInclusions <String[]>] [-UserInclusions <String[]>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Create
```
New-JcSdkAuthenticationPolicy -Body <IAuthnPolicyInput> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create an authentication policy.\n\n#### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/authn/policies \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n    \"name\": \"Sample Policy\",\n    \"disabled\": false,\n    \"effect\": {\n      \"action\": \"allow\"\n    },\n    \"targets\": {\n      \"users\": {\n        \"inclusions\": [\"ALL\"]\n      },\n      \"userGroups\": {\n        \"exclusions\": [{USER_GROUP_ID}]\n      },\n      \"resources\": [ {\"type\": \"user_portal\" } ]\n    },\n    \"conditions\":{\n      \"ipAddressIn\": [{IP_LIST_ID}]\n    }\n  }'\n```

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

### -Body
AuthnPolicyInput
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: JumpCloud.SDK.V2.Models.IAuthnPolicyInput
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Conditions
Dictionary of \<any\>

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

### -Description
.

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

### -Disabled
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

### -EffectAction
.

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

### -MfaRequired
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

### -Name
.

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

### -TargetResources
.
To construct, see NOTES section for TARGETRESOURCES properties and create a hash table.

```yaml
Type: JumpCloud.SDK.V2.Models.IAuthnPolicyResourceTarget[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserGroupExclusions
.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserGroupInclusions
.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserInclusions
.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded
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

### JumpCloud.SDK.V2.Models.IAuthnPolicyInput

## OUTPUTS

### JumpCloud.SDK.V2.Models.IAuthnPolicy

### System.String

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODY <IAuthnPolicyInput>: AuthnPolicyInput
  - `[Conditions <IAuthnPolicyInputConditions>]`: Dictionary of <any>
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Description <String>]`: 
  - `[Disabled <Boolean?>]`: 
  - `[EffectAction <String>]`: 
  - `[MfaRequired <Boolean?>]`: 
  - `[Name <String>]`: 
  - `[TargetResources <IAuthnPolicyResourceTarget[]>]`: 
    - `[Type <String>]`: 
  - `[UserGroupExclusions <String[]>]`: 
  - `[UserGroupInclusions <String[]>]`: 
  - `[UserInclusions <String[]>]`: 

TARGETRESOURCES <IAuthnPolicyResourceTarget[]>: .
  - `[Type <String>]`: 

## RELATED LINKS

