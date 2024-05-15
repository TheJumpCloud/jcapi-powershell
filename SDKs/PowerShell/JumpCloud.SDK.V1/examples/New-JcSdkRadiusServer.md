### Example 1: Create a RadiusServer by Name, NetworkSourceIP, and SharedSecret
```powershell
PS C:\> New-JcSdkRadiusServer -Name:(<string>) -NetworkSourceIP:(<string>) -SharedSecret:(<string>) -AuthIdp:(<string>) -CaCert:(<string>) -DeviceCertEnabled:(<switch>) -Mfa:(<string>) -UserCertEnabled:(<switch>) -UserLockoutAction:(<string>) -UserPasswordEnabled:(<switch>) -UserPasswordExpirationAction:(<string>)



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

This function will Create a RadiusServer by Name NetworkSourceIP SharedSecret. Name, NetworkSourceIP, and SharedSecret are required parameters.

### Example 2: Create a RadiusServer by Body
```powershell
PS C:\> New-JcSdkRadiusServer -Body:(<JumpCloud.SDK.V1.Models.Radiusserverpost>)



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

This function will Create a RadiusServer by Body. Body is a required parameter.

