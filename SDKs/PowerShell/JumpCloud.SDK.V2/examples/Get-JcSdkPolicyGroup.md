### Example 1: List PolicyGroups
```powershell
PS C:\> Get-JcSdkPolicyGroup -Fields:(<string[]>) -Filter:(<string[]>) -Sort:(<string[]>)



----        ----------
Attributes  JumpCloud.SDK.V2.Models.GraphAttributes
Description String
Email       String
Id          String
Name        String
Type        String


```

This function will return a list of all PolicyGroups. Fields, Filter, and Sort are optional parameters.

### Example 2: Get a PolicyGroup by Id
```powershell
PS C:\> Get-JcSdkPolicyGroup -Id:(<string>)



----        ----------
Attributes  JumpCloud.SDK.V2.Models.GraphAttributes
Description String
Email       String
Id          String
Name        String
Type        String


```

This function will Get a PolicyGroup by Id. Id is a required parameter.

