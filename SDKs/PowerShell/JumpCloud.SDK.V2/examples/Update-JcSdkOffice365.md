### Example 1: Update an Office365 by Office365Id, and Body
```powershell
PS C:\> Update-JcSdkOffice365 -Office365Id:(<string>) -Body:(<JumpCloud.SDK.V2.Models.Office365>)



----                         ----------
DefaultDomainDomain          String
DefaultDomainId              String
GroupsEnabled                Boolean
Id                           String
Name                         String
UserLockoutAction            String
UserPasswordExpirationAction String


```

This function will Update an Office365 by Office365Id Body. Office365Id, and Body are required parameters.

### Example 2: Update an Office365 by Office365Id
```powershell
PS C:\> Update-JcSdkOffice365 -Office365Id:(<string>) -DefaultDomainId:(<string>) -GroupsEnabled:(<switch>) -Name:(<string>) -UserLockoutAction:(<string>) -UserPasswordExpirationAction:(<string>)



----                         ----------
DefaultDomainDomain          String
DefaultDomainId              String
GroupsEnabled                Boolean
Id                           String
Name                         String
UserLockoutAction            String
UserPasswordExpirationAction String


```

This function will Update an Office365 by Office365Id. Office365Id is a required parameter.

