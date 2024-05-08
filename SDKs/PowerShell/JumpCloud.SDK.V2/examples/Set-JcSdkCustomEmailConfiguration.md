### Example 1: Set a CustomEmailConfiguration by CustomEmailType, and CustomEmail
```powershell
PS C:\> Set-JcSdkCustomEmailConfiguration -CustomEmailType:(<string>) -CustomEmail:(<JumpCloud.SDK.V2.Models.CustomEmail>)



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

This function will Set a CustomEmailConfiguration by CustomEmailType CustomEmail. CustomEmailType, and CustomEmail are required parameters.

### Example 2: Set a CustomEmailConfiguration by CustomEmailType, Subject, and Type
```powershell
PS C:\> Set-JcSdkCustomEmailConfiguration -CustomEmailType:(<string>) -Subject:(<string>) -Type:(<string>) -Body:(<string>) -Button:(<string>) -Header:(<string>) -NextStepContactInfo:(<string>) -Title:(<string>)



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

This function will Set a CustomEmailConfiguration by CustomEmailType Subject Type. CustomEmailType, Subject, and Type are required parameters.

