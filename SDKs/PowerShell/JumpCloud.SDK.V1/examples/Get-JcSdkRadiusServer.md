### Example 1: List RadiusServers
```powershell
PS C:\> Get-JcSdkRadiusServer -Fields:(<string>) -Filter:(<string[]>) -Sort:(<string>)



----                         ----------
AuthIdp                      String
CaCert                       String
DeviceCertEnabled            Boolean
Id                           String
Mfa                          String
Name                         String
NetworkSourceIP              String
Organization                 String
SharedSecret                 String
UserCertEnabled              Boolean
UserLockoutAction            String
UserPasswordEnabled          Boolean
UserPasswordExpirationAction String


```

This function will return a list of all RadiusServers. Fields, Filter, and Sort are optional parameters.

### Example 2: Get a RadiusServer by Id
```powershell
PS C:\> Get-JcSdkRadiusServer -Id:(<string>)



----                         ----------
AuthIdp                      String
CaCert                       String
DeviceCertEnabled            Boolean
Id                           String
Mfa                          String
Name                         String
NetworkSourceIP              String
Organization                 String
SharedSecret                 String
UserCertEnabled              Boolean
UserLockoutAction            String
UserPasswordEnabled          Boolean
UserPasswordExpirationAction String


```

This function will Get a RadiusServer by Id. Id is a required parameter.

