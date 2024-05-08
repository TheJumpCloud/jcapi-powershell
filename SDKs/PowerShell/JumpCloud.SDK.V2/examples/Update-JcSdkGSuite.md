### Example 1: Update a GSuite by Id, and Body
```powershell
PS C:\> Update-JcSdkGSuite -Id:(<string>) -Body:(<JumpCloud.SDK.V2.Models.Gsuite>)



----                         ----------
DefaultDomainDomain          String
DefaultDomainId              String
GroupsEnabled                Boolean
Id                           String
Name                         String
UserLockoutAction            String
UserPasswordExpirationAction String


```

This function will Update a GSuite by Id Body. Id, and Body are required parameters.

### Example 2: Update a GSuite by Id
```powershell
PS C:\> Update-JcSdkGSuite -Id:(<string>) -DefaultDomainId:(<string>) -GroupsEnabled:(<switch>) -Name:(<string>) -UserLockoutAction:(<string>) -UserPasswordExpirationAction:(<string>)



----                         ----------
DefaultDomainDomain          String
DefaultDomainId              String
GroupsEnabled                Boolean
Id                           String
Name                         String
UserLockoutAction            String
UserPasswordExpirationAction String


```

This function will Update a GSuite by Id. Id is a required parameter.

