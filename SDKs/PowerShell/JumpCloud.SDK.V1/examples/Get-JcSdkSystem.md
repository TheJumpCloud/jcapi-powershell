### Example 1: List Systems
```powershell
PS C:\> Get-JcSdkSystem -Search:(<string>) -Sort:(<string>)



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

This function will return a list of all Systems. Search, and Sort are optional parameters.

### Example 2: Get a System by Id
```powershell
PS C:\> Get-JcSdkSystem -Id:(<string>)



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

This function will Get a System by Id. Id is a required parameter.

