### Example 1: Set an IPList by Id, and Body
```powershell
PS C:\> Set-JcSdkIPList -Id:(<string>) -Body:(<JumpCloud.SDK.V2.Models.IPListRequest>)



----        ----------
Description String
Id          String
Ips         String
Name        String


```

This function will Set an IPList by Id Body. Id, and Body are required parameters.

### Example 2: Set an IPList by Id
```powershell
PS C:\> Set-JcSdkIPList -Id:(<string>) -Description:(<string>) -Ips:(<string[]>) -Name:(<string>)



----        ----------
Description String
Id          String
Ips         String
Name        String


```

This function will Set an IPList by Id. Id is a required parameter.

