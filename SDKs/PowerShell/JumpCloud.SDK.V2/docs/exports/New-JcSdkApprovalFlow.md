---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/New-JcSdkApprovalFlow.md
schema: 2.0.0
---

# New-JcSdkApprovalFlow

## SYNOPSIS
Endpoint for adding a new access workflow

## SYNTAX

### CreateExpanded (Default)
```
New-JcSdkApprovalFlow -ConsoleHost <String> [-ApprovalType <String>] [-ApproverRequirement <String>]
 [-ApproverResources <IJumpcloudIngressoApproverResource[]>] [-Category <String>] [-Description <String>]
 [-FixedDuration <String>] [-IconColor <String>] [-IconUrl <String>] [-MultiSelectDuration <String[]>]
 [-Name <String>] [-NonAdminApproval] [-OrganizationObjectIdInputFile <String>] [-ResourceId <String>]
 [-ResourceType <String>] [-SlackConfig <IJumpcloudIngressoSlackConfig[]>] [-SlackEnabled] [-Status <String>]
 [-TimeBasedAccess] [-TtlConfig <String>] [-VisibleTo <String[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-JcSdkApprovalFlow -ConsoleHost <String> -Body <IJumpcloudIngressoCreateAccessWorkflowRequest> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Endpoint for adding a new access workflow

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
New-JcSdkApprovalFlow -ApprovalType 'manual' -Category "Application" -Description "A new workflow" -MultiSelectDuration @("P5D") -Name "New Workflow" -ResourceId 5d67fd481da3c52aa1faa883 -ResourceType "user_group" -Status "active" -TimeBasedAccess -TtlConfig "TTL_CONFIG_MULTI_SELECT_DURATIONS" -VisibleTo @('6148cd739d38866f0814e874')
```



## PARAMETERS

### -ApprovalType
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

### -ApproverRequirement
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

### -ApproverResources
.

```yaml
Type: JumpCloud.SDK.V2.Models.IJumpcloudIngressoApproverResource[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Body
.

```yaml
Type: JumpCloud.SDK.V2.Models.IJumpcloudIngressoCreateAccessWorkflowRequest
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Category
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

### -FixedDuration
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

### -IconColor
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

### -IconUrl
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

### -MultiSelectDuration
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

### -NonAdminApproval
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

### -OrganizationObjectIdInputFile
Input File for OrganizationObjectId (.)

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

### -ResourceId
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

### -ResourceType
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

### -SlackConfig
.

```yaml
Type: JumpCloud.SDK.V2.Models.IJumpcloudIngressoSlackConfig[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SlackEnabled
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

### -Status
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

### -TimeBasedAccess
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

### -TtlConfig
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

### -VisibleTo
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

### JumpCloud.SDK.V2.Models.IJumpcloudIngressoCreateAccessWorkflowRequest

## OUTPUTS

### JumpCloud.SDK.V2.Models.IJumpcloudIngressoCreateAccessWorkflowResponse

## NOTES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`APPROVERRESOURCES <IJumpcloudIngressoApproverResource[]>`: .
  - `[RequireAll <Boolean?>]`: 
  - `[ResourceId <String>]`: 
  - `[ResourceName <String>]`: 
  - `[ResourceOrder <Int32?>]`: 
  - `[ResourceType <String>]`: 

`BODY <IJumpcloudIngressoCreateAccessWorkflowRequest>`: .
  - `[ApprovalType <String>]`: 
  - `[ApproverRequirement <String>]`: 
  - `[ApproverResources <List<IJumpcloudIngressoApproverResource>>]`: 
    - `[RequireAll <Boolean?>]`: 
    - `[ResourceId <String>]`: 
    - `[ResourceName <String>]`: 
    - `[ResourceOrder <Int32?>]`: 
    - `[ResourceType <String>]`: 
  - `[Category <String>]`: 
  - `[Description <String>]`: 
  - `[FixedDuration <String>]`: 
  - `[IconColor <String>]`: 
  - `[IconUrl <String>]`: 
  - `[MultiSelectDuration <List<String>>]`: 
  - `[Name <String>]`: 
  - `[NonAdminApproval <Boolean?>]`: 
  - `[OrganizationObjectId <Byte[]>]`: 
  - `[ResourceId <String>]`: 
  - `[ResourceType <String>]`: 
  - `[SlackConfig <List<IJumpcloudIngressoSlackConfig>>]`: 
    - `[SlackResourceId <String>]`: 
  - `[SlackEnabled <Boolean?>]`: 
  - `[Status <String>]`: 
  - `[TimeBasedAccess <Boolean?>]`: 
  - `[TtlConfig <String>]`: 
  - `[VisibleTo <List<String>>]`: 

`SLACKCONFIG <IJumpcloudIngressoSlackConfig[]>`: .
  - `[SlackResourceId <String>]`: 

## RELATED LINKS

