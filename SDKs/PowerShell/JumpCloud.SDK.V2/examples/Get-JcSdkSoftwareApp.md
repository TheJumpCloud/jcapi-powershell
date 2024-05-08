### Example 1: List SoftwareApps
```powershell
PS C:\> Get-JcSdkSoftwareApp -Filter:(<string[]>) -Sort:(<string[]>)



----        ----------
DisplayName String
Id          String
Settings    JumpCloud.SDK.V2.Models.SoftwareAppSettings[]


```

This function will return a list of all SoftwareApps. Filter, and Sort are optional parameters.

### Example 2: Get a SoftwareApp by Id
```powershell
PS C:\> Get-JcSdkSoftwareApp -Id:(<string>)



----        ----------
DisplayName String
Id          String
Settings    JumpCloud.SDK.V2.Models.SoftwareAppSettings[]


```

This function will Get a SoftwareApp by Id. Id is a required parameter.

