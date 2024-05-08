### Example 1: Create a PolicyGroup by Name
```powershell
PS C:\> New-JcSdkPolicyGroup -Name:(<string>)



----        ----------
Attributes  JumpCloud.SDK.V2.Models.GraphAttributes
Description String
Email       String
Id          String
Name        String
Type        String


```

This function will Create a PolicyGroup by Name. Name is a required parameter.

### Example 2: Create a PolicyGroup by Body
```powershell
PS C:\> New-JcSdkPolicyGroup -Body:(<JumpCloud.SDK.V2.Models.PolicyGroupData>)



----        ----------
Attributes  JumpCloud.SDK.V2.Models.GraphAttributes
Description String
Email       String
Id          String
Name        String
Type        String


```

This function will Create a PolicyGroup by Body. Body is a required parameter.

