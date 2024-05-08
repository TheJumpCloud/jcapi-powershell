### Example 1: Search a Command by Body
```powershell
PS C:\> Search-JcSdkCommand -Body:(<JumpCloud.SDK.V1.Models.Search>)



----       ----------
Results    JumpCloud.SDK.V1.Models.CommandslistResultsItem[]
TotalCount Int


```

This function will Search a Command by Body. Body is a required parameter.

### Example 2: Search a Command by
```powershell
PS C:\> Search-JcSdkCommand -Fields:(<string>) -Filter:(<hashtable>) -SearchFilter:(<hashtable>)



----       ----------
Results    JumpCloud.SDK.V1.Models.CommandslistResultsItem[]
TotalCount Int


```

This function will Search a Command by .

