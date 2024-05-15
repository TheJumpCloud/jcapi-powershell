### Example 1: List Applications
```powershell
PS C:\> Get-JcSdkApplication -Fields:(<string>) -Filter:(<string[]>) -Sort:(<string>)



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

This function will return a list of all Applications. Fields, Filter, and Sort are optional parameters.

### Example 2: Get an Application by Id
```powershell
PS C:\> Get-JcSdkApplication -Id:(<string>)



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

This function will Get an Application by Id. Id is a required parameter.

