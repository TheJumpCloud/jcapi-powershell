---
external help file:
Module Name: JumpCloud.SDK.V1
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V1/docs/exports/Get-JcSdkSystem.md
schema: 2.0.0
---

# Get-JcSdkSystem

## SYNOPSIS
This endpoint returns an individual system.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/systems/{SystemID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
  ```

## SYNTAX

### List (Default)
```
Get-JcSdkSystem -ConsoleHost <String> [-Fields <String>] [-Filter <List<String>>] [-Search <String>]
 [-Sort <String>] [<CommonParameters>]
```

### Get
```
Get-JcSdkSystem -ConsoleHost <String> -Id <String> [-Fields <String>] [-Filter <List<String>>]
 [<CommonParameters>]
```

### GetViaIdentity
```
Get-JcSdkSystem -ConsoleHost <String> -InputObject <IJumpCloudApiIdentity> [-Fields <String>]
 [-Filter <List<String>>] [<CommonParameters>]
```

## DESCRIPTION
This endpoint returns an individual system.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/systems/{SystemID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'
  ```

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Get-JcSdkSystem -Search:(<string>) -Sort:(<string>)
```

----                                 ----------
Active                               Boolean
AgentVersion                         String
AllowMultiFactorAuthentication       Boolean
AllowPublicKeyAuthentication         Boolean
AllowSshPasswordAuthentication       Boolean
AllowSshRootLogin                    Boolean
AmazonInstanceId                     String
Arch                                 String
ArchFamily                           String
AzureAdJoined                        Boolean
BuiltInCommands                      JumpCloud.SDK.V1.Models.JcSystemBuiltInCommandsItem[]
ConnectionHistory                    JumpCloud.SDK.V1.Models.JcSystemConnectionHistoryItem[]
Created                              Datetime
Description                          String
DesktopCapable                       Boolean
DisplayManager                       String
DisplayName                          String
DomainInfoDomainName                 String
DomainInfoPartOfDomain               Boolean
FdeActive                            Boolean
FdeKeyPresent                        Boolean
FileSystem                           String
HasServiceAccount                    Boolean
Hostname                             String
HwVendor                             String
Id                                   String
IsPolicyBound                        Boolean
LastContact                          Datetime
MdmDep                               Boolean
MdmProfileIdentifier                 String
MdmProviderId                        String
MdmUserApproved                      Boolean
MdmVendor                            String
ModifySshdConfig                     Boolean
NetworkInterfaces                    JumpCloud.SDK.V1.Models.JcSystemNetworkInterfacesItem[]
Organization                         String
OS                                   String
OSFamily                             String
OSVersionDetailDistributionName      String
OSVersionDetailMajor                 String
OSVersionDetailMajorNumber           Int
OSVersionDetailMinor                 String
OSVersionDetailMinorNumber           Int
OSVersionDetailOsname                String
OSVersionDetailPatch                 String
OSVersionDetailPatchNumber           Int
OSVersionDetailReleaseName           String
OSVersionDetailRevision              String
OSVersionDetailVersion               String
PolicyStatDuplicate                  Int
PolicyStatFailed                     Int
PolicyStatPending                    Int
PolicyStatSuccess                    Int
PolicyStatTotal                      Int
PolicyStatUnsupportedOS              Int
ProvisionerId                        String
ProvisionerType                      String
RemoteIP                             String
SecureLoginEnabled                   Boolean
SecureLoginSupported                 Boolean
SerialNumber                         String
ServiceAccountStateHasSecureToken    Boolean
ServiceAccountStatePasswordApfsValid Boolean
ServiceAccountStatePasswordOdValid   Boolean
SshdParams                           JumpCloud.SDK.V1.Models.JcSystemSshdParamsItem[]
SshRootEnabled                       Boolean
SystemInsightState                   String
SystemTimezone                       Int
TemplateName                         String
UserMetrics                          JumpCloud.SDK.V1.Models.JcSystemUserMetricsItem[]
Version                              String
WindowUpn                            String

### -------------------------- EXAMPLE 2 --------------------------
```powershell
Get-JcSdkSystem -Id:(<string>)
```

----                                 ----------
Active                               Boolean
AgentVersion                         String
AllowMultiFactorAuthentication       Boolean
AllowPublicKeyAuthentication         Boolean
AllowSshPasswordAuthentication       Boolean
AllowSshRootLogin                    Boolean
AmazonInstanceId                     String
Arch                                 String
ArchFamily                           String
AzureAdJoined                        Boolean
BuiltInCommands                      JumpCloud.SDK.V1.Models.JcSystemBuiltInCommandsItem[]
ConnectionHistory                    JumpCloud.SDK.V1.Models.JcSystemConnectionHistoryItem[]
Created                              Datetime
Description                          String
DesktopCapable                       Boolean
DisplayManager                       String
DisplayName                          String
DomainInfoDomainName                 String
DomainInfoPartOfDomain               Boolean
FdeActive                            Boolean
FdeKeyPresent                        Boolean
FileSystem                           String
HasServiceAccount                    Boolean
Hostname                             String
HwVendor                             String
Id                                   String
IsPolicyBound                        Boolean
LastContact                          Datetime
MdmDep                               Boolean
MdmProfileIdentifier                 String
MdmProviderId                        String
MdmUserApproved                      Boolean
MdmVendor                            String
ModifySshdConfig                     Boolean
NetworkInterfaces                    JumpCloud.SDK.V1.Models.JcSystemNetworkInterfacesItem[]
Organization                         String
OS                                   String
OSFamily                             String
OSVersionDetailDistributionName      String
OSVersionDetailMajor                 String
OSVersionDetailMajorNumber           Int
OSVersionDetailMinor                 String
OSVersionDetailMinorNumber           Int
OSVersionDetailOsname                String
OSVersionDetailPatch                 String
OSVersionDetailPatchNumber           Int
OSVersionDetailReleaseName           String
OSVersionDetailRevision              String
OSVersionDetailVersion               String
PolicyStatDuplicate                  Int
PolicyStatFailed                     Int
PolicyStatPending                    Int
PolicyStatSuccess                    Int
PolicyStatTotal                      Int
PolicyStatUnsupportedOS              Int
ProvisionerId                        String
ProvisionerType                      String
RemoteIP                             String
SecureLoginEnabled                   Boolean
SecureLoginSupported                 Boolean
SerialNumber                         String
ServiceAccountStateHasSecureToken    Boolean
ServiceAccountStatePasswordApfsValid Boolean
ServiceAccountStatePasswordOdValid   Boolean
SshdParams                           JumpCloud.SDK.V1.Models.JcSystemSshdParamsItem[]
SshRootEnabled                       Boolean
SystemInsightState                   String
SystemTimezone                       Int
TemplateName                         String
UserMetrics                          JumpCloud.SDK.V1.Models.JcSystemUserMetricsItem[]
Version                              String
WindowUpn                            String

## PARAMETERS

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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### JumpCloud.SDK.V1.Models.IJumpCloudApiIdentity

## OUTPUTS

### JumpCloud.SDK.V1.Models.IJcSystem

### JumpCloud.SDK.V1.Models.ISystemslist

## NOTES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`INPUTOBJECT <IJumpCloudApiIdentity>`: Identity Parameter
  - `[Id <String>]`: 
  - `[SystemId <String>]`: 
  - `[SystemuserId <String>]`: 
  - `[Triggername <String>]`: 

## RELATED LINKS

