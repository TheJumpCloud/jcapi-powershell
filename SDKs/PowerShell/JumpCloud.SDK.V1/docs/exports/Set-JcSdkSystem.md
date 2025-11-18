---
external help file:
Module Name: JumpCloud.SDK.V1
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V1/docs/exports/Set-JcSdkSystem.md
schema: 2.0.0
---

# Set-JcSdkSystem

## SYNOPSIS
This endpoint allows you to set a system.

#### Sample Request 
```
curl -X PUT https://console.jumpcloud.com/api/systems/{SystemID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
\t\"displayName\":\"Name_set ,
\t\"allowSshPasswordAuthentication\":\"true\",
\t\"allowSshRootLogin\":\"true\",
\t\"allowMultiFactorAuthentication\":\"true\",
\t\"allowPublicKeyAuthentication\":\"false\"
}'
```

## SYNTAX

### SetExpanded (Default)
```
Set-JcSdkSystem -ConsoleHost <String> -Id <String> [-AgentBoundMessages <ISystemputAgentBoundMessagesItem[]>]
 [-AllowMultiFactorAuthentication] [-AllowPublicKeyAuthentication] [-AllowSshPasswordAuthentication]
 [-AllowSshRootLogin] [-Attributes <IAttribute[]>] [-DisplayName <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Set
```
Set-JcSdkSystem -ConsoleHost <String> -Id <String> -Body <ISystemput> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### SetViaIdentity
```
Set-JcSdkSystem -ConsoleHost <String> -InputObject <IJumpCloudApiIdentity> -Body <ISystemput> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### SetViaIdentityExpanded
```
Set-JcSdkSystem -ConsoleHost <String> -InputObject <IJumpCloudApiIdentity>
 [-AgentBoundMessages <ISystemputAgentBoundMessagesItem[]>] [-AllowMultiFactorAuthentication]
 [-AllowPublicKeyAuthentication] [-AllowSshPasswordAuthentication] [-AllowSshRootLogin]
 [-Attributes <IAttribute[]>] [-DisplayName <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
This endpoint allows you to set a system.

#### Sample Request 
```
curl -X PUT https://console.jumpcloud.com/api/systems/{SystemID} \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
\t\"displayName\":\"Name_set ,
\t\"allowSshPasswordAuthentication\":\"true\",
\t\"allowSshRootLogin\":\"true\",
\t\"allowMultiFactorAuthentication\":\"true\",
\t\"allowPublicKeyAuthentication\":\"false\"
}'
```

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Set-JcSdkSystem -Id:(<string>) -Body:(<JumpCloud.SDK.V1.Models.Systemput>)
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
Set-JcSdkSystem -Id:(<string>) -AgentBoundMessages:(<JumpCloud.SDK.V1.Models.SystemputAgentBoundMessagesItem[]>) -AllowMultiFactorAuthentication:(<switch>) -AllowPublicKeyAuthentication:(<switch>) -AllowSshPasswordAuthentication:(<switch>) -AllowSshRootLogin:(<switch>) -DisplayName:(<string>)
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

### -AgentBoundMessages
.

```yaml
Type: JumpCloud.SDK.V1.Models.ISystemputAgentBoundMessagesItem[]
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AllowMultiFactorAuthentication
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

### -AllowPublicKeyAuthentication
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

### -AllowSshPasswordAuthentication
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

### -AllowSshRootLogin
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

### -Attributes
.

```yaml
Type: JumpCloud.SDK.V1.Models.IAttribute[]
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Body
SystemPut

```yaml
Type: JumpCloud.SDK.V1.Models.ISystemput
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

### -DisplayName
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

### -Id
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

### -InputObject
Identity Parameter

```yaml
Type: JumpCloud.SDK.V1.Models.IJumpCloudApiIdentity
Parameter Sets: SetViaIdentity, SetViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### JumpCloud.SDK.V1.Models.IJumpCloudApiIdentity

### JumpCloud.SDK.V1.Models.ISystemput

## OUTPUTS

### JumpCloud.SDK.V1.Models.IJcSystem

## NOTES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`AGENTBOUNDMESSAGES <ISystemputAgentBoundMessagesItem[]>`: .
  - `[Cmd <String>]`: 

`ATTRIBUTES <IAttribute[]>`: .
  - `[Name <String>]`: 
  - `[Value <String>]`: 

`BODY <ISystemput>`: SystemPut
  - `[AgentBoundMessages <List<ISystemputAgentBoundMessagesItem>>]`: 
    - `[Cmd <String>]`: 
  - `[AllowMultiFactorAuthentication <Boolean?>]`: 
  - `[AllowPublicKeyAuthentication <Boolean?>]`: 
  - `[AllowSshPasswordAuthentication <Boolean?>]`: 
  - `[AllowSshRootLogin <Boolean?>]`: 
  - `[Attributes <List<IAttribute>>]`: 
    - `[Name <String>]`: 
    - `[Value <String>]`: 
  - `[DisplayName <String>]`: 

`INPUTOBJECT <IJumpCloudApiIdentity>`: Identity Parameter
  - `[Id <String>]`: 
  - `[SystemId <String>]`: 
  - `[SystemuserId <String>]`: 
  - `[Triggername <String>]`: 

## RELATED LINKS

