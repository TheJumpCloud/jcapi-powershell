### Example 1: Create a CustomEmailConfiguration by Subject, and Type
```powershell
PS C:\> New-JcSdkCustomEmailConfiguration -Subject:(<string>) -Type:(<string>) -Body:(<string>) -Button:(<string>) -Header:(<string>) -NextStepContactInfo:(<string>) -Title:(<string>)



----                ----------
Body                String
Button              String
Header              String
Id                  String
NextStepContactInfo String
Subject             String
Title               String
Type                String


```

This function will Create a CustomEmailConfiguration by Subject Type. Subject, and Type are required parameters.

### Example 2: Create a CustomEmailConfiguration by CustomEmail
```powershell
PS C:\> New-JcSdkCustomEmailConfiguration -CustomEmail:(<JumpCloud.SDK.V2.Models.CustomEmail>)



----                ----------
Body                String
Button              String
Header              String
Id                  String
NextStepContactInfo String
Subject             String
Title               String
Type                String


```

This function will Create a CustomEmailConfiguration by CustomEmail. CustomEmail is a required parameter.

