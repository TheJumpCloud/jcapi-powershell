### Example 1: List IPLists
```powershell
PS C:\> Get-JcSdkIPList -Filter:(<string[]>) -Sort:(<string[]>) -XTotalCount:(<int>)



----        ----------
Description String
Id          String
Ips         String
Name        String


```

This function will return a list of all IPLists. Filter, Sort, and XTotalCount are optional parameters.

### Example 2: Get an IPList by Id
```powershell
PS C:\> Get-JcSdkIPList -Id:(<string>)



----        ----------
Description String
Id          String
Ips         String
Name        String


```

This function will Get an IPList by Id. Id is a required parameter.

