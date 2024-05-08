### Example 1: Set a RadiusServer by Id, and Body
```powershell
PS C:\> Set-JcSdkRadiusServer -Id:(<string>) -Body:(<JumpCloud.SDK.V1.Models.PathsKeqea5RadiusserversIdPutRequestbodyContentApplicationJsonSchema>)



----                         ----------
AuthIdp                      String
CaCert                       String
DeviceCertEnabled            Boolean
Id                           String
Mfa                          String
Name                         String
NetworkSourceIP              String
UserCertEnabled              Boolean
UserLockoutAction            String
UserPasswordEnabled          Boolean
UserPasswordExpirationAction String


```

This function will Set a RadiusServer by Id Body. Id, and Body are required parameters.

### Example 2: Set a RadiusServer by Id, Name, NetworkSourceIP, and SharedSecret
```powershell
PS C:\> Set-JcSdkRadiusServer -Id:(<string>) -Name:(<string>) -NetworkSourceIP:(<string>) -SharedSecret:(<string>) -CaCert:(<string>) -DeviceCertEnabled:(<switch>) -Mfa:(<string>) -UserCertEnabled:(<switch>) -UserLockoutAction:(<string>) -UserPasswordEnabled:(<switch>) -UserPasswordExpirationAction:(<string>)



----                         ----------
AuthIdp                      String
CaCert                       String
DeviceCertEnabled            Boolean
Id                           String
Mfa                          String
Name                         String
NetworkSourceIP              String
UserCertEnabled              Boolean
UserLockoutAction            String
UserPasswordEnabled          Boolean
UserPasswordExpirationAction String


```

This function will Set a RadiusServer by Id Name NetworkSourceIP SharedSecret. Id, Name, NetworkSourceIP, and SharedSecret are required parameters.

