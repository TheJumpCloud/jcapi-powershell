---
external help file:
Module Name: JumpCloud.SDK.V1
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V1/docs/exports/Get-JcSdkRadiusServer.md
schema: 2.0.0
---

# Get-JcSdkRadiusServer

## SYNOPSIS
This endpoint allows you to get a RADIUS server in your organization.

####
```
curl -X PUT https://console.jumpcloud.com/api/radiusservers/{ServerID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
```

## SYNTAX

### List (Default)
```
Get-JcSdkRadiusServer [-Fields <String>] [-Filter <String[]>] [-Sort <String>] [<CommonParameters>]
```

### Get
```
Get-JcSdkRadiusServer -Id <String> [<CommonParameters>]
```

### GetViaIdentity
```
Get-JcSdkRadiusServer -InputObject <IJumpCloudApiIdentity> [<CommonParameters>]
```

## DESCRIPTION
This endpoint allows you to get a RADIUS server in your organization.

####
```
curl -X PUT https://console.jumpcloud.com/api/radiusservers/{ServerID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
```

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Get-JcSdkRadiusServer -Fields:(<string>) -Filter:(<string[]>) -Sort:(<string>)
```

----                         ----------
AuthIdp                      String
CaCert                       String
DeviceCertEnabled            Boolean
Id                           String
Mfa                          String
Name                         String
NetworkSourceIP              String
Organization                 String
SharedSecret                 String
UserCertEnabled              Boolean
UserLockoutAction            String
UserPasswordEnabled          Boolean
UserPasswordExpirationAction String

### -------------------------- EXAMPLE 2 --------------------------
```powershell
Get-JcSdkRadiusServer -Id:(<string>)
```

----                         ----------
AuthIdp                      String
CaCert                       String
DeviceCertEnabled            Boolean
Id                           String
Mfa                          String
Name                         String
NetworkSourceIP              String
Organization                 String
SharedSecret                 String
UserCertEnabled              Boolean
UserLockoutAction            String
UserPasswordEnabled          Boolean
UserPasswordExpirationAction String

## PARAMETERS

### -Fields
Use a space seperated string of field parameters to include the data in the response.
If omitted, the default list of fields will be returned.

```yaml
Type: System.String
Parameter Sets: List
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Filter
A filter to apply to the query.
See the supported operators below.
For more complex searches,
see the related `/search/\<domain\>` endpoints,
e.g.
`/search/systems`.

**Filter structure**: `\<field\>:\<operator\>:\<value\>`.

**field** = Populate with a valid field from an endpoint response.

**operator** = Supported operators are:
- `$eq` (equals)
- `$ne` (does not equal)
- `$gt` (is greater than)
- `$gte` (is greater than or equal to)
- `$lt` (is less than)
- `$lte` (is less than or equal to)

_Note: v1 operators differ from v2 operators._

_Note: For v1 operators, excluding the `$` will result in undefined behavior._

**value** = Populate with the value you want to search for.
Is case sensitive.

**Examples**
- `GET /users?filter=username:$eq:testuser`
- `GET /systemusers?filter=password_expiration_date:$lte:2021-10-24`
- `GET /systemusers?filter=department:$ne:Accounting`
- `GET /systems?filter[0]=firstname:$eq:foo&filter[1]=lastname:$eq:bar` - this will
 AND the filters together.
- `GET /systems?filter[or][0]=lastname:$eq:foo&filter[or][1]=lastname:$eq:bar` - this will
 OR the filters together.

```yaml
Type: System.String[]
Parameter Sets: List
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
.

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

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: JumpCloud.SDK.V1.Models.IJumpCloudApiIdentity
Parameter Sets: GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Sort
Use space separated sort parameters to sort the collection.
Default sort is ascending.
Prefix with `-` to sort descending.

```yaml
Type: System.String
Parameter Sets: List
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

### JumpCloud.SDK.V1.Models.IJumpCloudApiIdentity

## OUTPUTS

### JumpCloud.SDK.V1.Models.IRadiusserver

### JumpCloud.SDK.V1.Models.IRadiusserverslist

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


INPUTOBJECT <IJumpCloudApiIdentity>: Identity Parameter
  - `[Id <String>]`: 
  - `[SystemId <String>]`: 
  - `[SystemuserId <String>]`: 
  - `[Triggername <String>]`: 

## RELATED LINKS

