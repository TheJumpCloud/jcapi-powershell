### Example 1: List Workdays
```powershell
PS C:\> Get-JcSdkWorkday -Fields:(<string[]>) -Filter:(<string[]>) -Sort:(<string[]>)



----         ----------
BasicExpiry  String
BasicIsValid Boolean
BasicMessage String
Id           String
LastImport   String
Name         String
OauthExpiry  String
OauthIsValid Boolean
OauthMessage String
ReportUrl    String


```

This function will return a list of all Workdays. Fields, Filter, and Sort are optional parameters.

### Example 2: Get a Workday by Id
```powershell
PS C:\> Get-JcSdkWorkday -Id:(<string>)



----         ----------
BasicExpiry  String
BasicIsValid Boolean
BasicMessage String
Id           String
LastImport   String
Name         String
OauthExpiry  String
OauthIsValid Boolean
OauthMessage String
ReportUrl    String


```

This function will Get a Workday by Id. Id is a required parameter.

