---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Get-JcSdkApplicationTraverseUser.md
schema: 2.0.0
---

# Get-JcSdkApplicationTraverseUser

## SYNOPSIS
This endpoint will return all Users bound to an Application, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.

Each element will contain the type, id, attributes and paths.

The `attributes` object is a key/value hash of compiled graph attributes for all paths followed.

The `paths` array enumerates each path from this Application to the corresponding User; this array represents all grouping and/or associations that would have to be removed to deprovision the User from this Application.

See `/members` and `/associations` endpoints to manage those collections.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/applications/{Application_ID}/users \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

## SYNTAX

### Get (Default)
```
Get-JcSdkApplicationTraverseUser -ApplicationId <String> [-Filter <String[]>] [<CommonParameters>]
```

### GetViaIdentity
```
Get-JcSdkApplicationTraverseUser -InputObject <IJumpCloudApiIdentity> [-Filter <String[]>]
 [<CommonParameters>]
```

## DESCRIPTION
This endpoint will return all Users bound to an Application, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.

Each element will contain the type, id, attributes and paths.

The `attributes` object is a key/value hash of compiled graph attributes for all paths followed.

The `paths` array enumerates each path from this Application to the corresponding User; this array represents all grouping and/or associations that would have to be removed to deprovision the User from this Application.

See `/members` and `/associations` endpoints to manage those collections.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/v2/applications/{Application_ID}/users \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Get-JcSdkApplicationTraverseUser -ApplicationId:(<string>)
```

----               ----------
CompiledAttributes JumpCloud.SDK.V2.Models.GraphAttributes
Id                 String
Paths              JumpCloud.SDK.V2.Models.GraphConnection[][]
Type               String

### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

## PARAMETERS

### -ApplicationId
ObjectID of the Application.

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

### -Filter
A filter to apply to the query.

**Filter structure**: `\<field\>:\<operator\>:\<value\>`.

**field** = Populate with a valid field from an endpoint response.

**operator** = Supported operators are: eq, ne, gt, ge, lt, le, between, search, in.
_Note: v1 operators differ from v2 operators._

**value** = Populate with the value you want to search for.
Is case sensitive.
Supports wild cards.

**EX:** `GET /api/v2/groups?filter=name:eq:Test+Group`

```yaml
Type: System.String[]
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
Type: JumpCloud.SDK.V2.Models.IJumpCloudApiIdentity
Parameter Sets: GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### JumpCloud.SDK.V2.Models.IJumpCloudApiIdentity

## OUTPUTS

### JumpCloud.SDK.V2.Models.IGraphObjectWithPaths

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


INPUTOBJECT <IJumpCloudApiIdentity>: Identity Parameter
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

## RELATED LINKS

