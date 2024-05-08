### Example 1: Create a Workday by
```powershell
PS C:\> New-JcSdkWorkday -BasicPassword:(<string>) -BasicUsername:(<string>) -Name:(<string>) -OauthCode:(<string>) -ReportUrl:(<string>)



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

This function will Create a Workday by .

### Example 2: Create a Workday by Body
```powershell
PS C:\> New-JcSdkWorkday -Body:(<JumpCloud.SDK.V2.Models.WorkdayInput>)



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

This function will Create a Workday by Body. Body is a required parameter.

