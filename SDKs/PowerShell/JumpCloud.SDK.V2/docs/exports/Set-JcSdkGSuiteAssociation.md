---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Set-JcSdkGSuiteAssociation.md
schema: 2.0.0
---

# Set-JcSdkGSuiteAssociation

## SYNOPSIS
This endpoint returns the _direct_ associations of this G Suite instance.

A direct association can be a non-homogeneous relationship between 2 different objects, for example G Suite and Users.


#### Sample Request
```
curl -X POST https://console.jumpcloud.com/api/v2/gsuites/{Gsuite_ID}/associations \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"op\": \"add\",
    \"type\": \"user_group\",
    \"id\": \"{Group_ID}\"
  }'
```

## SYNTAX

### SetExpanded (Default)
```
Set-JcSdkGSuiteAssociation -GsuiteId <String> -Id <String> -Op <String> -Type <GraphOperationGSuite>
 [-Attributes <Hashtable>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Set
```
Set-JcSdkGSuiteAssociation -GsuiteId <String> -Body <IGraphOperationGSuite1> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### SetViaIdentity
```
Set-JcSdkGSuiteAssociation -InputObject <IJumpCloudApIsIdentity> -Body <IGraphOperationGSuite1> [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### SetViaIdentityExpanded
```
Set-JcSdkGSuiteAssociation -InputObject <IJumpCloudApIsIdentity> -Id <String> -Op <String>
 -Type <GraphOperationGSuite> [-Attributes <Hashtable>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
This endpoint returns the _direct_ associations of this G Suite instance.

A direct association can be a non-homogeneous relationship between 2 different objects, for example G Suite and Users.


#### Sample Request
```
curl -X POST https://console.jumpcloud.com/api/v2/gsuites/{Gsuite_ID}/associations \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"op\": \"add\",
    \"type\": \"user_group\",
    \"id\": \"{Group_ID}\"
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

### -Attributes
The graph attributes.

```yaml
Type: System.Collections.Hashtable
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Body
GraphOperation (GSuite)
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: JumpCloud.SDK.V2.Models.IGraphOperationGSuite1
Parameter Sets: Set, SetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -GsuiteId
ObjectID of the G Suite instance.

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

### -Id
The ObjectID of graph object being added or removed as an association.

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

### -Op
How to modify the graph connection.

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
```

### -Type
Targets which a "g_suite" can be associated to.

```yaml
Type: JumpCloud.SDK.V2.Support.GraphOperationGSuite
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: True
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

### JumpCloud.SDK.V2.Models.IGraphOperationGSuite1

### JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODY <IGraphOperationGSuite1>: GraphOperation (GSuite)
  - `Id <String>`: The ObjectID of graph object being added or removed as an association.
  - `Op <String>`: How to modify the graph connection.
  - `Type <GraphOperationGSuite>`: Targets which a "g_suite" can be associated to.
  - `[Attributes <IGraphAttributes>]`: The graph attributes.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.

INPUTOBJECT <IJumpCloudApIsIdentity>: Identity Parameter
  - `[AccountId <String>]`: 
  - `[ActivedirectoryId <String>]`: 
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
  - `[RadiusserverId <String>]`: ObjectID of the Radius Server.
  - `[SoftwareAppId <String>]`: ObjectID of the Software App.
  - `[SystemId <String>]`: ObjectID of the System.
  - `[UserId <String>]`: ObjectID of the User.
  - `[WorkdayId <String>]`: 

## RELATED LINKS

