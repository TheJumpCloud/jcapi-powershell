### Example 1: Set a System by Id, and Body
```powershell
PS C:\> Set-JcSdkSystem -Id:(<string>) -Body:(<JumpCloud.SDK.V1.Models.Systemput>)



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


```

This function will Set a System by Id Body. Id, and Body are required parameters.

### Example 2: Set a System by Id
```powershell
PS C:\> Set-JcSdkSystem -Id:(<string>) -AgentBoundMessages:(<JumpCloud.SDK.V1.Models.SystemputAgentBoundMessagesItem[]>) -AllowMultiFactorAuthentication:(<switch>) -AllowPublicKeyAuthentication:(<switch>) -AllowSshPasswordAuthentication:(<switch>) -AllowSshRootLogin:(<switch>) -DisplayName:(<string>)



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


```

This function will Set a System by Id. Id is a required parameter.

