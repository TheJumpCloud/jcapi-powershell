### Example 1: List DuoAccounts
```powershell
PS C:\> Get-JcSdkDuoAccount



---- ----------
Id   String
Name String


```

This function will return a list of all DuoAccounts.

### Example 2: Get a DuoAccount by Id
```powershell
PS C:\> Get-JcSdkDuoAccount -Id:(<string>)



---- ----------
Id   String
Name String


```

This function will Get a DuoAccount by Id. Id is a required parameter.

