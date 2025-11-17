---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/New-JcSdkPolicy.md
schema: 2.0.0
---

# New-JcSdkPolicy

## SYNOPSIS
This endpoint allows you to create a policy.
Given the amount of configurable parameters required to create a Policy, we suggest you use the JumpCloud Admin Console to create new policies.

##### Sample Request
```
curl -X POST https://console.jumpcloud.com/api/v2/policies \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    {Policy_Parameters}
  }'
```

## SYNTAX

### CreateExpanded (Default)
```
New-JcSdkPolicy -ConsoleHost <String> [-Name <String>] [-Notes <String>] [-TemplateId <String>]
 [-Values <IPolicyValue[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-JcSdkPolicy -ConsoleHost <String> -Body <IPolicyCreateRequest> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
This endpoint allows you to create a policy.
Given the amount of configurable parameters required to create a Policy, we suggest you use the JumpCloud Admin Console to create new policies.

##### Sample Request
```
curl -X POST https://console.jumpcloud.com/api/v2/policies \\
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
New-JcSdkPolicy -Name:(<string>) -TemplateId:(<string>) -Notes:(<string>) -Values:(<JumpCloud.SDK.V2.Models.PolicyValue[]>)
```

----                   ----------
ConfigFields           JumpCloud.SDK.V2.Models.PolicyTemplateConfigField[]
Id                     String
Name                   String
Notes                  String
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
Values                 JumpCloud.SDK.V2.Models.PolicyValue[]

### -------------------------- EXAMPLE 2 --------------------------
```powershell
New-JcSdkPolicy -Body:(<JumpCloud.SDK.V2.Models.PolicyCreateRequest>)
```

----                   ----------
ConfigFields           JumpCloud.SDK.V2.Models.PolicyTemplateConfigField[]
Id                     String
Name                   String
Notes                  String
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
Values                 JumpCloud.SDK.V2.Models.PolicyValue[]

## PARAMETERS

### -Body
A request to create an instance of a policy template.

```yaml
Type: JumpCloud.SDK.V2.Models.IPolicyCreateRequest
Parameter Sets: Create
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

### -Name
The description for this specific Policy.

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

### -Notes
The notes for this specific Policy.

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

### -TemplateId
ObjectId uniquely identifying a Policy instance.

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

### -Values
.

```yaml
Type: JumpCloud.SDK.V2.Models.IPolicyValue[]
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

### JumpCloud.SDK.V2.Models.IPolicyCreateRequest

## OUTPUTS

### JumpCloud.SDK.V2.Models.IPolicyWithDetails

## NOTES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODY <IPolicyCreateRequest>`: A request to create an instance of a policy template.
  - `Name <String>`: The description for this specific Policy.
  - `TemplateId <String>`: ObjectId uniquely identifying a Policy instance.
  - `[Notes <String>]`: The notes for this specific Policy.
  - `[Values <List<IPolicyValue>>]`: 
    - `[ConfigFieldId <String>]`: The ObjectId of the corresponding Policy Template configuration field.
    - `[Sensitive <Boolean?>]`: Defines if the value is sensitive or not.
    - `[Value <String>]`: The value for the configuration field for this Policy instance.

`VALUES <IPolicyValue[]>`: .
  - `[ConfigFieldId <String>]`: The ObjectId of the corresponding Policy Template configuration field.
  - `[Sensitive <Boolean?>]`: Defines if the value is sensitive or not.
  - `[Value <String>]`: The value for the configuration field for this Policy instance.

## RELATED LINKS

