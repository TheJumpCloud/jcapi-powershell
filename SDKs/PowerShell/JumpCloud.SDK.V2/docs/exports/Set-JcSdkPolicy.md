---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Set-JcSdkPolicy.md
schema: 2.0.0
---

# Set-JcSdkPolicy

## SYNOPSIS
This endpoint allows you to set a policy.
Given the amount of configurable parameters required to set a Policy, we suggest you use the JumpCloud Admin Console to set new policies.


##### Sample Request
```
curl -X PUT https://console.jumpcloud.com/api/v2/policies/59fced45c9118022172547ff \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    {Policy_Parameters}
  }'
```

## SYNTAX

### SetExpanded (Default)
```
Set-JcSdkPolicy -ConsoleHost <String> -Id <String> [-Name <String>] [-Notes <String>]
 [-Values <IPolicyValue[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Set
```
Set-JcSdkPolicy -ConsoleHost <String> -Id <String> -Body <IPolicyUpdateRequest> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### SetViaIdentity
```
Set-JcSdkPolicy -ConsoleHost <String> -InputObject <IJumpCloudApiIdentity> -Body <IPolicyUpdateRequest>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### SetViaIdentityExpanded
```
Set-JcSdkPolicy -ConsoleHost <String> -InputObject <IJumpCloudApiIdentity> [-Name <String>] [-Notes <String>]
 [-Values <IPolicyValue[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
This endpoint allows you to set a policy.
Given the amount of configurable parameters required to set a Policy, we suggest you use the JumpCloud Admin Console to set new policies.


##### Sample Request
```
curl -X PUT https://console.jumpcloud.com/api/v2/policies/59fced45c9118022172547ff \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    {Policy_Parameters}
  }'
```

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Set-JcSdkPolicy -Id:(<string>) -Body:(<JumpCloud.SDK.V2.Models.PolicyUpdateRequest>)
```

----                   ----------
Id                     String
Name                   String
TemplateActivation     String
TemplateAlert          String
TemplateBehavior       String
TemplateDeliveryTypes  String
TemplateDescription    String
TemplateDisplayName    String
TemplateId             String
TemplateName           String
TemplateOSMetaFamily   String
TemplateOSRestrictions JumpCloud.SDK.V2.Models.OSRestriction[]
TemplateReference      String
TemplateState          String

### -------------------------- EXAMPLE 2 --------------------------
```powershell
Set-JcSdkPolicy -Id:(<string>) -Name:(<string>) -Notes:(<string>) -Values:(<JumpCloud.SDK.V2.Models.PolicyValue[]>)
```

----                   ----------
Id                     String
Name                   String
TemplateActivation     String
TemplateAlert          String
TemplateBehavior       String
TemplateDeliveryTypes  String
TemplateDescription    String
TemplateDisplayName    String
TemplateId             String
TemplateName           String
TemplateOSMetaFamily   String
TemplateOSRestrictions JumpCloud.SDK.V2.Models.OSRestriction[]
TemplateReference      String
TemplateState          String

## PARAMETERS

### -Body
A request to update an instance of a policy template.

```yaml
Type: JumpCloud.SDK.V2.Models.IPolicyUpdateRequest
Parameter Sets: Set, SetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ConsoleHost
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
ObjectID of the Policy object.

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

### -Name
The description for this specific Policy.

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

### -Notes
The notes for this specific Policy.

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

### JumpCloud.SDK.V2.Models.IJumpCloudApiIdentity

### JumpCloud.SDK.V2.Models.IPolicyUpdateRequest

## OUTPUTS

### JumpCloud.SDK.V2.Models.IPolicy

## NOTES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODY <IPolicyUpdateRequest>`: A request to update an instance of a policy template.
  - `Name <String>`: The description for this specific Policy.
  - `[Notes <String>]`: The notes for this specific Policy.
  - `[Values <List<IPolicyValue>>]`: 
    - `[ConfigFieldId <String>]`: The ObjectId of the corresponding Policy Template configuration field.
    - `[Sensitive <Boolean?>]`: Defines if the value is sensitive or not.
    - `[Value <String>]`: The value for the configuration field for this Policy instance.

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

`VALUES <IPolicyValue[]>`: .
  - `[ConfigFieldId <String>]`: The ObjectId of the corresponding Policy Template configuration field.
  - `[Sensitive <Boolean?>]`: Defines if the value is sensitive or not.
  - `[Value <String>]`: The value for the configuration field for this Policy instance.

## RELATED LINKS

