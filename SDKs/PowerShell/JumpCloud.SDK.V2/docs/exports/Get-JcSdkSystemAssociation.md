---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Get-JcSdkSystemAssociation.md
schema: 2.0.0
---

# Get-JcSdkSystemAssociation

## SYNOPSIS
This endpoint returns the _direct_ associations of a System.

A direct association can be a non-homogeneous relationship between 2 different objects, for example Systems and Users.


#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/systems/{System_ID}/associations?targets=user \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'

```

## SYNTAX

### Get (Default)
```
Get-JcSdkSystemAssociation -SystemId <String> -Targets <GraphTargetsActiveDirectoryTargets>
 [-Authorization <String>] [-Date <String>] [<CommonParameters>]
```

### GetViaIdentity
```
Get-JcSdkSystemAssociation -InputObject <IJumpCloudApIsIdentity> -Targets <GraphTargetsActiveDirectoryTargets>
 [-Authorization <String>] [-Date <String>] [<CommonParameters>]
```

## DESCRIPTION
This endpoint returns the _direct_ associations of a System.

A direct association can be a non-homogeneous relationship between 2 different objects, for example Systems and Users.


#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/systems/{System_ID}/associations?targets=user \\
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

### -Authorization
Authorization header for the System Context API

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Date
Current date header for the System Context API

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
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
Parameter Sets: GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -SystemId
ObjectID of the System.

```yaml
Type: System.String
Parameter Sets: Get
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

### JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity

## OUTPUTS

### JumpCloud.SDK.V2.Models.IGraphConnection

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


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

