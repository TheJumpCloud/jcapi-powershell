---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Set-JcSdkPolicy.md
schema: 2.0.0
---

# Set-JcSdkPolicy

## SYNOPSIS
This endpoint allows you to update a configuration (policy).
Given the amount of configurable parameters required to update a Configuration (Policy), we suggest you use the JumpCloud Admin Console to create new configurations (policies).


##### Sample Request
```
curl -X PUT https://console.jumpcloud.com/api/v2/policies/59fced45c9118022172547ff \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY' \\
  -d '{
    {Policy_Parameters}
  }'
```

## SYNTAX

### SetExpanded (Default)
```
Set-JcSdkPolicy -Id <String> -Name <String> [-TemplateId <String>] [-Values <IPolicyValue[]>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Set
```
Set-JcSdkPolicy -Id <String> -Body <IPolicyRequest> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### SetViaIdentity
```
Set-JcSdkPolicy -InputObject <IJumpCloudApIsIdentity> -Body <IPolicyRequest> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### SetViaIdentityExpanded
```
Set-JcSdkPolicy -InputObject <IJumpCloudApIsIdentity> -Name <String> [-TemplateId <String>]
 [-Values <IPolicyValue[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
This endpoint allows you to update a configuration (policy).
Given the amount of configurable parameters required to update a Configuration (Policy), we suggest you use the JumpCloud Admin Console to create new configurations (policies).


##### Sample Request
```
curl -X PUT https://console.jumpcloud.com/api/v2/policies/59fced45c9118022172547ff \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY' \\
  -d '{
    {Policy_Parameters}
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

### -Body
An instance of a configuration (policy) template.
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: JumpCloud.SDK.V2.Models.IPolicyRequest
Parameter Sets: Set, SetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Id
ObjectID of the Configuration (Policy) object.

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
Type: JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity
Parameter Sets: SetViaIdentity, SetViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Name
The description for this specific Configuration (Policy).

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

### -TemplateId
ObjectId uniquely identifying a Configuration (Policy) instance; only allowed on POST requests.

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

### -Values
.
To construct, see NOTES section for VALUES properties and create a hash table.

```yaml
Type: JumpCloud.SDK.V2.Models.IPolicyValue[]
Parameter Sets: SetExpanded, SetViaIdentityExpanded
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

### JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity

### JumpCloud.SDK.V2.Models.IPolicyRequest

## OUTPUTS

### JumpCloud.SDK.V2.Models.IPolicy

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODY <IPolicyRequest>: An instance of a configuration (policy) template.
  - `Name <String>`: The description for this specific Configuration (Policy).
  - `[TemplateId <String>]`: ObjectId uniquely identifying a Configuration (Policy) instance; only allowed on POST requests.
  - `[Values <IPolicyValue[]>]`: 
    - `[ConfigFieldId <String>]`: The ObjectId of the corresponding Configuration (Policy) Template configuration field.
    - `[Value <String>]`: The value for the configuration field for this Configuration (Policy) instance.

INPUTOBJECT <IJumpCloudApIsIdentity>: Identity Parameter
  - `[AccountId <String>]`: 
  - `[ActivedirectoryId <String>]`: 
  - `[AgentId <String>]`: 
  - `[AppleMdmId <String>]`: 
  - `[ApplicationId <String>]`: ObjectID of the Application.
  - `[CommandId <String>]`: ObjectID of the Command.
  - `[CustomEmailType <String>]`: 
  - `[DeviceId <String>]`: 
  - `[GroupId <String>]`: ObjectID of the Configuration (Policy) Group.
  - `[GsuiteId <String>]`: ObjectID of the G Suite instance.
  - `[Id <String>]`: ObjectID of this Active Directory instance.
  - `[JobId <String>]`: 
  - `[LdapserverId <String>]`: ObjectID of the LDAP Server.
  - `[Office365Id <String>]`: ObjectID of the Office 365 instance.
  - `[PolicyId <String>]`: ObjectID of the Configuration (Policy).
  - `[ProviderId <String>]`: 
  - `[RadiusserverId <String>]`: ObjectID of the Radius Server.
  - `[SoftwareAppId <String>]`: ObjectID of the Software App.
  - `[SystemId <String>]`: ObjectID of the System.
  - `[UserId <String>]`: ObjectID of the User.
  - `[WorkdayId <String>]`: 

VALUES <IPolicyValue[]>: .
  - `[ConfigFieldId <String>]`: The ObjectId of the corresponding Configuration (Policy) Template configuration field.
  - `[Value <String>]`: The value for the configuration field for this Configuration (Policy) instance.

## RELATED LINKS

