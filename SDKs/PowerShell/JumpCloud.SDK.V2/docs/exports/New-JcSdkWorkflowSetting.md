---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/CUT-4022_AccessRequests/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/New-JcSdkWorkflowSetting.md
schema: 2.0.0
---

# New-JcSdkWorkflowSetting

## SYNOPSIS
Endpoint for adding a new access workflow Settings

## SYNTAX

### CreateExpanded (Default)
```
New-JcSdkWorkflowSetting -ConsoleHost <String> [-AdminApprovalEmail]
 [-ChannelEvents <IJumpcloudIngressoChannelEvent[]>] [-ExposeApprovalProgress]
 [-OrganizationObjectIdInputFile <String>] [-ResourceRequest] [-UserApprovalEmail] [-UserRequestEmail]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-JcSdkWorkflowSetting -ConsoleHost <String> -Body <IJumpcloudIngressoCreateAccessWorkflowSettingsRequest>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Endpoint for adding a new access workflow Settings

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```



### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```



## PARAMETERS

### -AdminApprovalEmail
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
.

```yaml
Type: JumpCloud.SDK.V2.Models.IJumpcloudIngressoCreateAccessWorkflowSettingsRequest
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ChannelEvents
.

```yaml
Type: JumpCloud.SDK.V2.Models.IJumpcloudIngressoChannelEvent[]
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

### -ExposeApprovalProgress
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

### -ResourceRequest
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

### -UserApprovalEmail
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

### -UserRequestEmail
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

### JumpCloud.SDK.V2.Models.IJumpcloudIngressoCreateAccessWorkflowSettingsRequest

## OUTPUTS

### JumpCloud.SDK.V2.Models.IJumpcloudIngressoCreateAccessWorkflowSettingsResponse

## NOTES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODY <IJumpcloudIngressoCreateAccessWorkflowSettingsRequest>`: .
  - `[AdminApprovalEmail <Boolean?>]`: 
  - `[ChannelEvents <List<IJumpcloudIngressoChannelEvent>>]`: 
    - `[ChannelObjectId <Byte[]>]`: 
    - `[EventTypes <List<String>>]`: 
  - `[ExposeApprovalProgress <Boolean?>]`: 
  - `[OrganizationObjectId <Byte[]>]`: 
  - `[ResourceRequest <Boolean?>]`: 
  - `[UserApprovalEmail <Boolean?>]`: 
  - `[UserRequestEmail <Boolean?>]`: 

`CHANNELEVENTS <IJumpcloudIngressoChannelEvent[]>`: .
  - `[ChannelObjectId <Byte[]>]`: 
  - `[EventTypes <List<String>>]`: 

## RELATED LINKS

