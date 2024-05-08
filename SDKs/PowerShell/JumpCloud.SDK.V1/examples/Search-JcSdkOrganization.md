### Example 1: Search an Organization by Body
```powershell
PS C:\> Search-JcSdkOrganization -Body:(<JumpCloud.SDK.V1.Models.Search>)



----       ----------
Results    JumpCloud.SDK.V1.Models.OrganizationslistResultsItem[]
TotalCount Int


```

This function will Search an Organization by Body. Body is a required parameter.

### Example 2: Search an Organization by
```powershell
PS C:\> Search-JcSdkOrganization -Fields:(<string>) -Filter:(<hashtable>) -SearchFilter:(<hashtable>)



----       ----------
Results    JumpCloud.SDK.V1.Models.OrganizationslistResultsItem[]
TotalCount Int


```

This function will Search an Organization by .

