---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Get-JcSdkSoftwareAppStatus.md
schema: 2.0.0
---

# Get-JcSdkSoftwareAppStatus

## SYNOPSIS
This endpoint allows you to get the status of the provided Software Application on associated JumpCloud systems.\n\n#### Sample Request\n```\n$ curl -X GET https://console.jumpcloud.com/api/v2/softwareapps/{software_app_id}/statuses \\\n-H 'Accept: application/json' \\\n-H 'Content-Type: application/json' \\\n-H 'x-api-key: {API_KEY}' \\\n```

## SYNTAX

### Get (Default)
```
Get-JcSdkSoftwareAppStatus -SoftwareAppId <String> [-Filter <String[]>] [-Sort <String[]>]
 [<CommonParameters>]
```

### GetViaIdentity
```
Get-JcSdkSoftwareAppStatus -InputObject <IJumpCloudApIsIdentity> [-Filter <String[]>] [-Sort <String[]>]
 [<CommonParameters>]
```

## DESCRIPTION
This endpoint allows you to get the status of the provided Software Application on associated JumpCloud systems.\n\n#### Sample Request\n```\n$ curl -X GET https://console.jumpcloud.com/api/v2/softwareapps/{software_app_id}/statuses \\\n-H 'Accept: application/json' \\\n-H 'Content-Type: application/json' \\\n-H 'x-api-key: {API_KEY}' \\\n```

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

### -Filter
A filter to apply to the query.
**Filter structure**: `\<field\>:\<operator\>:\<value\>`.
**field** = Populate with a valid field from an endpoint response.
**operator** = Supported operators are: eq, ne, gt, ge, lt, le, between, search, in.
**value** = Populate with the value you want to search for.
Is case sensitive.
Supports wild cards.
**EX:** `GET /users?username=eq:testuser`

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
Type: JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity
Parameter Sets: GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -SoftwareAppId
ObjectID of the Software App.

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

### -Sort
The comma separated fields used to sort the collection.
Default sort is ascending, prefix with `-` to sort descending.

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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity

## OUTPUTS

### JumpCloud.SDK.V2.Models.IPathsR1Xng3SoftwareappsSoftwareAppIdStatusesGetResponses200ContentApplicationJsonSchemaItems

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


INPUTOBJECT <IJumpCloudApIsIdentity>: Identity Parameter
  - `[AccountId <String>]`: 
  - `[ActivedirectoryId <String>]`: 
  - `[AppleMdmId <String>]`: 
  - `[ApplicationId <String>]`: ObjectID of the Application.
  - `[CommandId <String>]`: ObjectID of the Command.
  - `[DeviceId <String>]`: 
  - `[GroupId <String>]`: ObjectID of the System Group.
  - `[GsuiteId <String>]`: ObjectID of the G Suite instance.
  - `[Id <String>]`: ObjectID of the System Group.
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

