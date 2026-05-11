---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Set-JcSdkAccessRequestApproval.md
schema: 2.0.0
---

# Set-JcSdkAccessRequestApproval

## SYNOPSIS
Endpoint for user approval

## SYNTAX

### SetExpanded (Default)
```
Set-JcSdkAccessRequestApproval -ConsoleHost <String> [-ApprovedDuration <String>] [-Id <String>]
 [-OrganizationObjectIdInputFile <String>] [-Remarks <String>] [-Status <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Set
```
Set-JcSdkAccessRequestApproval -ConsoleHost <String> -Body <IJumpcloudIngressoUserApprovalRequest> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Endpoint for user approval

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Set-JcSdkAccessRequestApproval -ApprovedDuration:(<string>) -Id:(<string>) -OrganizationObjectIdInputFile:(<string>) -Remarks:(<string>) -Status:(<string>)
```



### -------------------------- EXAMPLE 2 --------------------------
```powershell
Set-JcSdkAccessRequestApproval -Body:(<JumpCloud.SDK.V2.Models.JumpcloudIngressoUserApprovalRequest>)
```



## PARAMETERS

### -ApprovedDuration
.

```yaml
Type: System.String
Parameter Sets: SetExpanded
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
Type: JumpCloud.SDK.V2.Models.IJumpcloudIngressoUserApprovalRequest
Parameter Sets: Set
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
Parameter Sets: SetExpanded
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
Parameter Sets: SetExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Remarks
.

```yaml
Type: System.String
Parameter Sets: SetExpanded
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
Parameter Sets: SetExpanded
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

### JumpCloud.SDK.V2.Models.IJumpcloudIngressoUserApprovalRequest

## OUTPUTS

### JumpCloud.SDK.V2.Models.IJumpcloudIngressoUserApprovalRequestResponse

## NOTES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODY <IJumpcloudIngressoUserApprovalRequest>`: .
  - `[ApprovedDuration <String>]`: 
  - `[Id <String>]`: 
  - `[OrganizationObjectId <Byte[]>]`: 
  - `[Remarks <String>]`: 
  - `[Status <String>]`: 

## RELATED LINKS

