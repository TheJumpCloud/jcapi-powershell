### Example 1: Create a LdapServerSambaDomain by LdapserverId, Name, and Sid
```powershell
PS C:\> New-JcSdkLdapServerSambaDomain -LdapserverId:(<string>) -Name:(<string>) -Sid:(<string>)



---- ----------
Id   String
Name String
Sid  String


```

This function will Create a LdapServerSambaDomain by LdapserverId Name Sid. LdapserverId, Name, and Sid are required parameters.

### Example 2: Create a LdapServerSambaDomain by LdapserverId, and Body
```powershell
PS C:\> New-JcSdkLdapServerSambaDomain -LdapserverId:(<string>) -Body:(<JumpCloud.SDK.V2.Models.SambaDomain>)



---- ----------
Id   String
Name String
Sid  String


```

This function will Create a LdapServerSambaDomain by LdapserverId Body. LdapserverId, and Body are required parameters.

