---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/CUT-4022_AccessRequests/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Set-JcSdkApprovalFlow.md
schema: 2.0.0
---

# Set-JcSdkApprovalFlow

## SYNOPSIS
Endpoint for updating a new access workflow

## SYNTAX

### SetExpanded (Default)
```
Set-JcSdkApprovalFlow -ConsoleHost <String> -ApprovalFlowId <String> [-ApprovalType <String>]
 [-ApproverRequirement <String>] [-ApproverResources <IJumpcloudIngressoApproverResource[]>]
 [-Description <String>] [-FixedDuration <String>] [-IconColor <String>] [-IconUrl <String>]
 [-MultiSelectDuration <String[]>] [-Name <String>] [-NonAdminApproval]
 [-OrganizationObjectIdInputFile <String>] [-ResourceId <String>]
 [-SlackConfig <IJumpcloudIngressoSlackConfig[]>] [-SlackEnabled] [-Status <String>] [-TimeBasedAccess]
 [-TtlConfig <String>] [-VisibleTo <String[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Set
```
Set-JcSdkApprovalFlow -ConsoleHost <String> -ApprovalFlowId <String>
 -Body <IPaths14Hfh8UApprovalflowsApprovalflowidPutRequestbodyContentApplicationJsonSchema> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### SetViaIdentity
```
Set-JcSdkApprovalFlow -ConsoleHost <String> -InputObject <IJumpCloudApiIdentity>
 -Body <IPaths14Hfh8UApprovalflowsApprovalflowidPutRequestbodyContentApplicationJsonSchema> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### SetViaIdentityExpanded
```
Set-JcSdkApprovalFlow -ConsoleHost <String> -InputObject <IJumpCloudApiIdentity> [-ApprovalType <String>]
 [-ApproverRequirement <String>] [-ApproverResources <IJumpcloudIngressoApproverResource[]>]
 [-Description <String>] [-FixedDuration <String>] [-IconColor <String>] [-IconUrl <String>]
 [-MultiSelectDuration <String[]>] [-Name <String>] [-NonAdminApproval]
 [-OrganizationObjectIdInputFile <String>] [-ResourceId <String>]
 [-SlackConfig <IJumpcloudIngressoSlackConfig[]>] [-SlackEnabled] [-Status <String>] [-TimeBasedAccess]
 [-TtlConfig <String>] [-VisibleTo <String[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Endpoint for updating a new access workflow

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Set-JcSdkApprovalFlow -ApprovalFlowId:(<string>) -ApprovalType:(<string>) -ApproverRequirement:(<string>) -ApproverResources:(<JumpCloud.SDK.V2.Models.JumpcloudIngressoApproverResource[]>) -Description:(<string>) -FixedDuration:(<string>) -IconColor:(<string>) -IconUrl:(<string>) -MultiSelectDuration:(<string[]>) -Name:(<string>) -NonAdminApproval:(<switch>) -OrganizationObjectIdInputFile:(<string>) -ResourceId:(<string>) -SlackConfig:(<JumpCloud.SDK.V2.Models.JumpcloudIngressoSlackConfig[]>) -SlackEnabled:(<switch>) -Status:(<string>) -TimeBasedAccess:(<switch>) -TtlConfig:(<string>) -VisibleTo:(<string[]>)
```



### -------------------------- EXAMPLE 2 --------------------------
```powershell
Set-JcSdkApprovalFlow -ApprovalFlowId:(<string>) -Body:(<JumpCloud.SDK.V2.Models.Paths14Hfh8UApprovalflowsApprovalflowidPutRequestbodyContentApplicationJsonSchema>)
```



## PARAMETERS

### -ApprovalFlowId
.

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

### -ApprovalType
.

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

### -ApproverRequirement
.

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

### -ApproverResources
.

```yaml
Type: JumpCloud.SDK.V2.Models.IJumpcloudIngressoApproverResource[]
Parameter Sets: SetExpanded, SetViaIdentityExpanded
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
Type: JumpCloud.SDK.V2.Models.IPaths14Hfh8UApprovalflowsApprovalflowidPutRequestbodyContentApplicationJsonSchema
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

### -Description
.

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

### -FixedDuration
.

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

### -IconColor
.

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

### -IconUrl
.

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

### -MultiSelectDuration
.

```yaml
Type: System.String[]
Parameter Sets: SetExpanded, SetViaIdentityExpanded
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
Parameter Sets: SetExpanded, SetViaIdentityExpanded
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
Parameter Sets: SetExpanded, SetViaIdentityExpanded
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
Parameter Sets: SetExpanded, SetViaIdentityExpanded
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
Parameter Sets: SetExpanded, SetViaIdentityExpanded
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
Parameter Sets: SetExpanded, SetViaIdentityExpanded
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
Parameter Sets: SetExpanded, SetViaIdentityExpanded
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
Parameter Sets: SetExpanded, SetViaIdentityExpanded
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
Parameter Sets: SetExpanded, SetViaIdentityExpanded
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
Parameter Sets: SetExpanded, SetViaIdentityExpanded
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

### JumpCloud.SDK.V2.Models.IPaths14Hfh8UApprovalflowsApprovalflowidPutRequestbodyContentApplicationJsonSchema

## OUTPUTS

### JumpCloud.SDK.V2.Models.IJumpcloudIngressoUpdateAccessWorkflowResponse

## NOTES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`APPROVERRESOURCES <IJumpcloudIngressoApproverResource[]>`: .
  - `[RequireAll <Boolean?>]`: 
  - `[ResourceId <String>]`: 
  - `[ResourceName <String>]`: 
  - `[ResourceOrder <Int32?>]`: 
  - `[ResourceType <String>]`: 

`BODY <IPaths14Hfh8UApprovalflowsApprovalflowidPutRequestbodyContentApplicationJsonSchema>`: .
  - `[ApprovalType <String>]`: 
  - `[ApproverRequirement <String>]`: 
  - `[ApproverResources <List<IJumpcloudIngressoApproverResource>>]`: 
    - `[RequireAll <Boolean?>]`: 
    - `[ResourceId <String>]`: 
    - `[ResourceName <String>]`: 
    - `[ResourceOrder <Int32?>]`: 
    - `[ResourceType <String>]`: 
  - `[Description <String>]`: 
  - `[FixedDuration <String>]`: 
  - `[IconColor <String>]`: 
  - `[IconUrl <String>]`: 
  - `[MultiSelectDuration <List<String>>]`: 
  - `[Name <String>]`: 
  - `[NonAdminApproval <Boolean?>]`: 
  - `[OrganizationObjectId <Byte[]>]`: 
  - `[ResourceId <String>]`: 
  - `[SlackConfig <List<IJumpcloudIngressoSlackConfig>>]`: 
    - `[SlackResourceId <String>]`: 
  - `[SlackEnabled <Boolean?>]`: 
  - `[Status <String>]`: 
  - `[TimeBasedAccess <Boolean?>]`: 
  - `[TtlConfig <String>]`: 
  - `[VisibleTo <List<String>>]`: 

`INPUTOBJECT <IJumpCloudApiIdentity>`: Identity Parameter
  - `[AccountId <String>]`: 
  - `[ActivedirectoryId <String>]`: 
  - `[AdministratorId <String>]`: 
  - `[AgentId <String>]`: 
  - `[AppleMdmId <String>]`: 
  - `[ApplicationId <String>]`: ObjectID of the Application.
  - `[ApprovalFlowId <String>]`: 
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

`SLACKCONFIG <IJumpcloudIngressoSlackConfig[]>`: .
  - `[SlackResourceId <String>]`: 

## RELATED LINKS

