### Example 1: Create an IPList by
```powershell
PS C:\> New-JcSdkIPList -Description:(<string>) -Ips:(<string[]>) -Name:(<string>)



----        ----------
Description String
Id          String
Ips         String
Name        String


```

This function will Create an IPList by .

### Example 2: Create an IPList by Body
```powershell
PS C:\> New-JcSdkIPList -Body:(<JumpCloud.SDK.V2.Models.IPListRequest>)



----        ----------
Description String
Id          String
Ips         String
Name        String


```

This function will Create an IPList by Body. Body is a required parameter.

