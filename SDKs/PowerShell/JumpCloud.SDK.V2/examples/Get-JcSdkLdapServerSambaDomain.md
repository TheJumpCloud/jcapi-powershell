### Example 1: List LdapServerSambaDomains
```powershell
PS C:\> Get-JcSdkLdapServerSambaDomain -LdapserverId:(<string>) -Fields:(<string[]>) -Filter:(<string[]>) -Sort:(<string[]>)



---- ----------
Id   String
Name String
Sid  String


```

This function will return a list of all LdapServerSambaDomains. Fields, Filter, and Sort are optional parameters.

### Example 2: Get a LdapServerSambaDomain by LdapserverId, and Id
```powershell
PS C:\> Get-JcSdkLdapServerSambaDomain -LdapserverId:(<string>) -Id:(<string>)



---- ----------
Id   String
Name String
Sid  String


```

This function will Get a LdapServerSambaDomain by LdapserverId Id. LdapserverId, and Id are required parameters.

