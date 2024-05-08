### Example 1: Update a LdapServer by Id, and Body
```powershell
PS C:\> Update-JcSdkLdapServer -Id:(<string>) -Body:(<JumpCloud.SDK.V2.Models.Paths1Ka5IlhLdapserversIdPatchRequestbodyContentApplicationJsonSchema>)



----                         ----------
Id                           String
Name                         String
UserLockoutAction            String
UserPasswordExpirationAction String


```

This function will Update a LdapServer by Id Body. Id, and Body are required parameters.

### Example 2: Update a LdapServer by Id
```powershell
PS C:\> Update-JcSdkLdapServer -Id:(<string>) -Id1:(<string>) -UserLockoutAction:(<string>) -UserPasswordExpirationAction:(<string>)



----                         ----------
Id                           String
Name                         String
UserLockoutAction            String
UserPasswordExpirationAction String


```

This function will Update a LdapServer by Id. Id is a required parameter.

