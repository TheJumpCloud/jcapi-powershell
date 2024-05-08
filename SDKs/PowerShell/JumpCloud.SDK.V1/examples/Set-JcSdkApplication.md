### Example 1: Set an Application by Id, and Body
```powershell
PS C:\> Set-JcSdkApplication -Id:(<string>) -Body:(<JumpCloud.SDK.V1.Models.Application>)



----                       ----------
Active                     Boolean
Beta                       Boolean
Color                      String
Config                     JumpCloud.SDK.V1.Models.ApplicationConfig
Created                    String
DatabaseAttributes         JumpCloud.SDK.V1.Models.ApplicationDatabaseAttributesItem[]
Description                String
DisplayLabel               String
DisplayName                String
Id                         String
LearnMore                  String
LogoColor                  String
LogoUrl                    String
Name                       String
Organization               String
SsoBeta                    Boolean
SsoHidden                  Boolean
SsoIdpCertExpirationAt     Datetime
SsoIdpCertificateUpdatedAt Datetime
SsoIdpPrivateKeyUpdatedAt  Datetime
SsoJit                     Boolean
SsoSpCertificateUpdatedAt  Datetime
SsoType                    String
SsoUrl                     String


```

This function will Set an Application by Id Body. Id, and Body are required parameters.

### Example 2: Set an Application by Id, Config, Name, and SsoUrl
```powershell
PS C:\> Set-JcSdkApplication -Id:(<string>) -Config:(<JumpCloud.SDK.V1.Models.ApplicationConfig>) -Name:(<string>) -SsoUrl:(<string>) -Active:(<switch>) -Beta:(<switch>) -Color:(<string>) -Created:(<string>) -DatabaseAttributes:(<JumpCloud.SDK.V1.Models.ApplicationDatabaseAttributesItem[]>) -Description:(<string>) -DisplayLabel:(<string>) -DisplayName:(<string>) -LearnMore:(<string>) -LogoColor:(<string>) -LogoUrl:(<string>) -Organization:(<string>) -SsoBeta:(<switch>) -SsoHidden:(<switch>) -SsoIdpCertExpirationAt:(<datetime>) -SsoJit:(<switch>) -SsoType:(<string>) -Id1:(<string>)



----                       ----------
Active                     Boolean
Beta                       Boolean
Color                      String
Config                     JumpCloud.SDK.V1.Models.ApplicationConfig
Created                    String
DatabaseAttributes         JumpCloud.SDK.V1.Models.ApplicationDatabaseAttributesItem[]
Description                String
DisplayLabel               String
DisplayName                String
Id                         String
LearnMore                  String
LogoColor                  String
LogoUrl                    String
Name                       String
Organization               String
SsoBeta                    Boolean
SsoHidden                  Boolean
SsoIdpCertExpirationAt     Datetime
SsoIdpCertificateUpdatedAt Datetime
SsoIdpPrivateKeyUpdatedAt  Datetime
SsoJit                     Boolean
SsoSpCertificateUpdatedAt  Datetime
SsoType                    String
SsoUrl                     String


```

This function will Set an Application by Id Config Name SsoUrl. Id, Config, Name, and SsoUrl are required parameters.

