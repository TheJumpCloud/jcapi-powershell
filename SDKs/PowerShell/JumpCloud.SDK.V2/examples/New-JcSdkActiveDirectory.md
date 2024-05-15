### Example 1: Create an ActiveDirectory by
```powershell
PS C:\> New-JcSdkActiveDirectory -Domain:(<string>) -UseCase:(<string>)



----         ----------
Domain       String
Id           String
PrimaryAgent String
UseCase      String


```

This function will Create an ActiveDirectory by .

### Example 2: Create an ActiveDirectory by Body
```powershell
PS C:\> New-JcSdkActiveDirectory -Body:(<JumpCloud.SDK.V2.Models.ActiveDirectory>)



----         ----------
Domain       String
Id           String
PrimaryAgent String
UseCase      String


```

This function will Create an ActiveDirectory by Body. Body is a required parameter.

