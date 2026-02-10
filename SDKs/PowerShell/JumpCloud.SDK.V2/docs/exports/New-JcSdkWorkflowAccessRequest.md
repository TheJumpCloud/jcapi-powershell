---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/CUT-4022_AccessRequests/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/New-JcSdkWorkflowAccessRequest.md
schema: 2.0.0
---

# New-JcSdkWorkflowAccessRequest

## SYNOPSIS
Endpoint for adding a new workflow access request

## SYNTAX

### CreateExpanded (Default)
```
New-JcSdkWorkflowAccessRequest -ConsoleHost <String> [-Id <String>] [-OrganizationObjectIdInputFile <String>]
 [-Reason <String>] [-RequestedDuration <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-JcSdkWorkflowAccessRequest -ConsoleHost <String> -Body <IJumpcloudIngressoCreateWorkflowAccessRequest>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Endpoint for adding a new workflow access request

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

### -Body
.

```yaml
Type: JumpCloud.SDK.V2.Models.IJumpcloudIngressoCreateWorkflowAccessRequest
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

### -Id
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

### -Reason
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

### -RequestedDuration
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

### JumpCloud.SDK.V2.Models.IJumpcloudIngressoCreateWorkflowAccessRequest

## OUTPUTS

### JumpCloud.SDK.V2.Models.IJumpcloudIngressoCreateWorkflowAccessRequestResponse

## NOTES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODY <IJumpcloudIngressoCreateWorkflowAccessRequest>`: .
  - `[Id <String>]`: 
  - `[OrganizationObjectId <Byte[]>]`: 
  - `[Reason <String>]`: 
  - `[RequestedDuration <String>]`: 

## RELATED LINKS

