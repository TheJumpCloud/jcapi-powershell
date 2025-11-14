---
external help file:
Module Name: JumpCloud.SDK.V1
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V1/docs/exports/Get-JcSdkApplicationTemplate.md
schema: 2.0.0
---

# Get-JcSdkApplicationTemplate

## SYNOPSIS
The endpoint returns a specific SSO / SAML Application Template.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/application-templates/{id} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'

```

## SYNTAX

### List (Default)
```
Get-JcSdkApplicationTemplate -ConsoleHost <String> [-Fields <String>] [-Filter <List<String>>]
 [-Sort <String>] [<CommonParameters>]
```

### Get
```
Get-JcSdkApplicationTemplate -ConsoleHost <String> -Id <String> [-Fields <String>] [-Filter <List<String>>]
 [-Sort <String>] [<CommonParameters>]
```

### GetViaIdentity
```
Get-JcSdkApplicationTemplate -ConsoleHost <String> -InputObject <IJumpCloudApiIdentity> [-Fields <String>]
 [-Filter <List<String>>] [-Sort <String>] [<CommonParameters>]
```

## DESCRIPTION
The endpoint returns a specific SSO / SAML Application Template.

#### Sample Request
```
curl -X GET https://console.jumpcloud.com/api/application-templates/{id} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}'

```

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Get-JcSdkApplicationTemplate
```

----                        ----------
Active                      Boolean
Beta                        Boolean
Color                       String
Config                      JumpCloud.SDK.V1.Models.ApplicationtemplateConfig
DisplayLabel                String
DisplayName                 String
Id                          String
IsConfigured                Boolean
JitAttributes               JumpCloud.SDK.V1.Models.ApplicationtemplateJitAttributes
JitCreateOnly               Boolean
Keywords                    String
LearnMore                   String
LogoUrl                     String
Name                        String
OidcGrantTypes              String
OidcRedirectUris            String
OidcSsoUrl                  String
OidcTokenEndpointAuthMethod String
ProvisionBeta               Boolean
ProvisionGroupsSupported    Boolean
ProvisionType               String
SsoBeta                     Boolean
SsoHidden                   Boolean
SsoIdpCertExpirationAt      Datetime
SsoIdpCertificateUpdatedAt  Datetime
SsoIdpPrivateKeyUpdatedAt   Datetime
SsoJit                      Boolean
SsoSpCertificateUpdatedAt   Datetime
SsoType                     String
SsoUrl                      String
Status                      String
Test                        String

### -------------------------- EXAMPLE 2 --------------------------
```powershell
Get-JcSdkApplicationTemplate -Id:(<string>)
```

----                        ----------
Active                      Boolean
Beta                        Boolean
Color                       String
Config                      JumpCloud.SDK.V1.Models.ApplicationtemplateConfig
DisplayLabel                String
DisplayName                 String
Id                          String
IsConfigured                Boolean
JitAttributes               JumpCloud.SDK.V1.Models.ApplicationtemplateJitAttributes
JitCreateOnly               Boolean
Keywords                    String
LearnMore                   String
LogoUrl                     String
Name                        String
OidcGrantTypes              String
OidcRedirectUris            String
OidcSsoUrl                  String
OidcTokenEndpointAuthMethod String
ProvisionBeta               Boolean
ProvisionGroupsSupported    Boolean
ProvisionType               String
SsoBeta                     Boolean
SsoHidden                   Boolean
SsoIdpCertExpirationAt      Datetime
SsoIdpCertificateUpdatedAt  Datetime
SsoIdpPrivateKeyUpdatedAt   Datetime
SsoJit                      Boolean
SsoSpCertificateUpdatedAt   Datetime
SsoType                     String
SsoUrl                      String
Status                      String
Test                        String

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
The space separated fields included in the returned records.
If omitted the default list of fields will be returned.

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

### -Sort
The space separated fields used to sort the collection.
Default sort is ascending, prefix with - to sort descending.

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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### JumpCloud.SDK.V1.Models.IJumpCloudApiIdentity

## OUTPUTS

### JumpCloud.SDK.V1.Models.IApplicationtemplate

### JumpCloud.SDK.V1.Models.IApplicationtemplateslist

## NOTES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`INPUTOBJECT <IJumpCloudApiIdentity>`: Identity Parameter
  - `[Id <String>]`: 
  - `[SystemId <String>]`: 
  - `[SystemuserId <String>]`: 
  - `[Triggername <String>]`: 

## RELATED LINKS

