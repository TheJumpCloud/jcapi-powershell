---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Get-JcSdkPolicyGroupAssociation.md
schema: 2.0.0
---

# Get-JcSdkPolicyGroupAssociation

## SYNOPSIS
This endpoint returns the _direct_ associations of this Configuration (Policy) Group.

A direct association can be a non-homogeneous relationship between 2 different objects, for example Configuration (Policy) Groups and Configurations (Policies).


#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/policygroups/{GroupID}/associations?targets=system \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

## SYNTAX

```
Get-JcSdkPolicyGroupAssociation -GroupId <String> -Targets <GraphTargetsActiveDirectoryTargets>
 [<CommonParameters>]
```

## DESCRIPTION
This endpoint returns the _direct_ associations of this Configuration (Policy) Group.

A direct association can be a non-homogeneous relationship between 2 different objects, for example Configuration (Policy) Groups and Configurations (Policies).


#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/policygroups/{GroupID}/associations?targets=system \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
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

### -GroupId
ObjectID of the Configuration (Policy) Group.

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

### -Targets
Targets which a "active_directory" can be associated to.

```yaml
Type: JumpCloud.SDK.V2.Support.GraphTargetsActiveDirectoryTargets
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### JumpCloud.SDK.V2.Models.IGraphConnection

## NOTES

ALIASES

## RELATED LINKS

