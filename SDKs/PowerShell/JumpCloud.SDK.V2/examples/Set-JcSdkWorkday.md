### Example 1: Set a Workday by Id, and Body
```powershell
PS C:\> Set-JcSdkWorkday -Id:(<string>) -Body:(<JumpCloud.SDK.V2.Models.WorkdayFields>)



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

This function will Set a Workday by Id Body. Id, and Body are required parameters.

### Example 2: Set a Workday by Id
```powershell
PS C:\> Set-JcSdkWorkday -Id:(<string>) -Name:(<string>) -ReportUrl:(<string>)



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

This function will Set a Workday by Id. Id is a required parameter.

