### Example 1: List ActiveDirectorys
```powershell
PS C:\> Get-JcSdkActiveDirectory -Fields:(<string[]>) -Filter:(<string[]>) -Sort:(<string[]>)



----         ----------
Domain       String
Id           String
PrimaryAgent String
UseCase      String


```

This function will return a list of all ActiveDirectorys. Fields, Filter, and Sort are optional parameters.

### Example 2: Get an ActiveDirectory by Id
```powershell
PS C:\> Get-JcSdkActiveDirectory -Id:(<string>)



----         ----------
Domain       String
Id           String
PrimaryAgent String
UseCase      String


```

This function will Get an ActiveDirectory by Id. Id is a required parameter.

