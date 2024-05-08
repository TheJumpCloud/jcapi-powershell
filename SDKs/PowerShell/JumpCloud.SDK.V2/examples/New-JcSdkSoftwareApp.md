### Example 1: Create a SoftwareApp by
```powershell
PS C:\> New-JcSdkSoftwareApp -DisplayName:(<string>) -Id:(<string>) -Settings:(<JumpCloud.SDK.V2.Models.SoftwareAppSettings[]>)



----        ----------
DisplayName String
Id          String
Settings    JumpCloud.SDK.V2.Models.SoftwareAppSettings[]
UploadUrl   String


```

This function will Create a SoftwareApp by .

### Example 2: Create a SoftwareApp by Body
```powershell
PS C:\> New-JcSdkSoftwareApp -Body:(<JumpCloud.SDK.V2.Models.SoftwareApp>)



----        ----------
DisplayName String
Id          String
Settings    JumpCloud.SDK.V2.Models.SoftwareAppSettings[]
UploadUrl   String


```

This function will Create a SoftwareApp by Body. Body is a required parameter.

