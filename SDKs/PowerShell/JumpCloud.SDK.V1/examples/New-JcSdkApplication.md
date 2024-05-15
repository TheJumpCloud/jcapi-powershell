### Example 1: Create an Application by Config, Name, and SsoUrl
```powershell
PS C:\> New-JcSdkApplication -Config:(<JumpCloud.SDK.V1.Models.ApplicationConfig>) -Name:(<string>) -SsoUrl:(<string>) -Active:(<switch>) -Beta:(<switch>) -Color:(<string>) -Created:(<string>) -DatabaseAttributes:(<JumpCloud.SDK.V1.Models.ApplicationDatabaseAttributesItem[]>) -Description:(<string>) -DisplayLabel:(<string>) -DisplayName:(<string>) -Id:(<string>) -LearnMore:(<string>) -LogoColor:(<string>) -LogoUrl:(<string>) -Organization:(<string>) -SsoBeta:(<switch>) -SsoHidden:(<switch>) -SsoIdpCertExpirationAt:(<datetime>) -SsoJit:(<switch>) -SsoType:(<string>)



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

This function will Create an Application by Config Name SsoUrl. Config, Name, and SsoUrl are required parameters.

### Example 2: Create an Application by Body
```powershell
PS C:\> New-JcSdkApplication -Body:(<JumpCloud.SDK.V1.Models.Application>)



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

This function will Create an Application by Body. Body is a required parameter.

