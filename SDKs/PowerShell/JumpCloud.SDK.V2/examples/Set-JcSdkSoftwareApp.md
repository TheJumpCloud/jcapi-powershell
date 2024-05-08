### Example 1: Set a SoftwareApp by Id, and Body
```powershell
PS C:\> Set-JcSdkSoftwareApp -Id:(<string>) -Body:(<JumpCloud.SDK.V2.Models.SoftwareApp>)



----        ----------
DisplayName String
Id          String
Settings    JumpCloud.SDK.V2.Models.SoftwareAppSettings[]


```

This function will Set a SoftwareApp by Id Body. Id, and Body are required parameters.

### Example 2: Set a SoftwareApp by Id
```powershell
PS C:\> Set-JcSdkSoftwareApp -Id:(<string>) -DisplayName:(<string>) -Id1:(<string>) -Settings:(<JumpCloud.SDK.V2.Models.SoftwareAppSettings[]>)



----        ----------
DisplayName String
Id          String
Settings    JumpCloud.SDK.V2.Models.SoftwareAppSettings[]


```

This function will Set a SoftwareApp by Id. Id is a required parameter.

