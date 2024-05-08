### Example 1: Search a System by Body
```powershell
PS C:\> Search-JcSdkSystem -Body:(<JumpCloud.SDK.V1.Models.Search>)



----       ----------
Results    JumpCloud.SDK.V1.Models.JcSystem[]
TotalCount Int


```

This function will Search a System by Body. Body is a required parameter.

### Example 2: Search a System by
```powershell
PS C:\> Search-JcSdkSystem -Fields:(<string>) -Filter:(<hashtable>) -SearchFilter:(<hashtable>)



----       ----------
Results    JumpCloud.SDK.V1.Models.JcSystem[]
TotalCount Int


```

This function will Search a System by .

