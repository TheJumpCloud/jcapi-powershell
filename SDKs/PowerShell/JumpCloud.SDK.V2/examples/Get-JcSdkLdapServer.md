### Example 1: List LdapServers
```powershell
PS C:\> Get-JcSdkLdapServer -Fields:(<string[]>) -Filter:(<string[]>) -Sort:(<string[]>)



----                         ----------
Id                           String
Name                         String
UserLockoutAction            String
UserPasswordExpirationAction String


```

This function will return a list of all LdapServers. Fields, Filter, and Sort are optional parameters.

### Example 2: Get a LdapServer by Id
```powershell
PS C:\> Get-JcSdkLdapServer -Id:(<string>)



----                         ----------
Id                           String
Name                         String
UserLockoutAction            String
UserPasswordExpirationAction String


```

This function will Get a LdapServer by Id. Id is a required parameter.

