### Example 1: List ApplicationTemplates
```powershell
PS C:\> Get-JcSdkApplicationTemplate



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


```

This function will return a list of all ApplicationTemplates.

### Example 2: Get an ApplicationTemplate by Id
```powershell
PS C:\> Get-JcSdkApplicationTemplate -Id:(<string>)



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


```

This function will Get an ApplicationTemplate by Id. Id is a required parameter.

