---
external help file:
Module Name: JumpCloud.SDK.V1
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/CUT-4908_userGroupDeviceGroupFilters/SDKs/PowerShell/JumpCloud.SDK.V1/docs/exports/Get-JcSdkOrganization.md
schema: 2.0.0
---

# Get-JcSdkOrganization

## SYNOPSIS
This endpoint returns a particular Organization.

#### Sample Request

```
curl -X GET https://console.jumpcloud.com/api/organizations/{OrganizationID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

## SYNTAX

### List (Default)
```
Get-JcSdkOrganization -HostEnv <String> [-Fields <String>] [-Filter <List<String>>] [-Search <String>]
 [-Sort <String>] [-SortIgnoreCase <String>] [<CommonParameters>]
```

### Get
```
Get-JcSdkOrganization -HostEnv <String> -Id <String> [-Fields <String>] [-Filter <List<String>>]
 [<CommonParameters>]
```

### GetViaIdentity
```
Get-JcSdkOrganization -HostEnv <String> -InputObject <IJumpCloudApiIdentity> [-Fields <String>]
 [-Filter <List<String>>] [<CommonParameters>]
```

## DESCRIPTION
This endpoint returns a particular Organization.

#### Sample Request

```
curl -X GET https://console.jumpcloud.com/api/organizations/{OrganizationID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Get-JcSdkOrganization -Search:(<string>) -Sort:(<string>) -SortIgnoreCase:(<string>)
```

----                             ----------
AccessRestriction                String
AccountsReceivable               String
Created                          String
DisplayName                      String
EntitlementBillingModel          String
EntitlementIsManuallyBilled      Boolean
EntitlementPricePerUserSum       Int
EntitlementProducts              JumpCloud.SDK.V1.Models.OrganizationentitlementEntitlementProductsItem[]
HasCreditCard                    Boolean
HasStripeCustomerId              Boolean
Id                               String
LastEstimateCalculationTimeStamp String
LastSfdcSyncStatus               JumpCloud.SDK.V1.Models.OrganizationLastSfdcSyncStatus
LogoUrl                          String
Provider                         String
Settings                         JumpCloud.SDK.V1.Models.Organizationsettings
TotalBillingEstimate             Int

### -------------------------- EXAMPLE 2 --------------------------
```powershell
Get-JcSdkOrganization -Id:(<string>)
```

----                             ----------
AccessRestriction                String
AccountsReceivable               String
Created                          String
DisplayName                      String
EntitlementBillingModel          String
EntitlementIsManuallyBilled      Boolean
EntitlementPricePerUserSum       Int
EntitlementProducts              JumpCloud.SDK.V1.Models.OrganizationentitlementEntitlementProductsItem[]
HasCreditCard                    Boolean
HasStripeCustomerId              Boolean
Id                               String
LastEstimateCalculationTimeStamp String
LastSfdcSyncStatus               JumpCloud.SDK.V1.Models.OrganizationLastSfdcSyncStatus
LogoUrl                          String
Provider                         String
Settings                         JumpCloud.SDK.V1.Models.Organizationsettings
TotalBillingEstimate             Int

## PARAMETERS

### -Fields
Use a space seperated string of field parameters to include the data in the response.
If omitted, the default list of fields will be returned.

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

### -Filter
A filter to apply to the query.
Populate with a valid field from an endpoint response.

```yaml
Type: System.Collections.Generic.List`1[[System.String, System.Private.CoreLib, Version=9.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -HostEnv
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

### -Search
A nested object containing a `searchTerm` string or array of strings and a list of `fields` to search on.

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

### -SortIgnoreCase
Use space separated sort parameters to sort the collection, ignoring case.
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

### JumpCloud.SDK.V1.Models.IOrganization

### JumpCloud.SDK.V1.Models.IOrganizationslist

## NOTES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`INPUTOBJECT <IJumpCloudApiIdentity>`: Identity Parameter
  - `[Id <String>]`: 
  - `[SystemId <String>]`: 
  - `[SystemuserId <String>]`: 
  - `[Triggername <String>]`: 

## RELATED LINKS

