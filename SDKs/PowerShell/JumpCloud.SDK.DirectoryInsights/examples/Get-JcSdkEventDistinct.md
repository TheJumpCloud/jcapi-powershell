### Example 1: Get an EventDistinct by Body
```powershell
PS C:\> Get-JcSdkEventDistinct -Body:(<JumpCloud.SDK.DirectoryInsights.Models.EventDistinctQuery>)



----                    ----------
Buckets                 JumpCloud.SDK.DirectoryInsights.Models.Post200ApplicationJsonPropertiesItemsItem[]
DocCountErrorUpperBound Int
SumOtherDocCount        Int


```

This function will Get an EventDistinct by Body. Body is a required parameter.

### Example 2: Get an EventDistinct by Field, Service, and StartTime
```powershell
PS C:\> Get-JcSdkEventDistinct -Field:(<string>) -Service:(<string[]>) -StartTime:(<datetime>) -EndTime:(<datetime>) -SearchTermAnd:(<hashtable>) -SearchTermNot:(<hashtable>) -SearchTermOr:(<hashtable>)



----                    ----------
Buckets                 JumpCloud.SDK.DirectoryInsights.Models.Post200ApplicationJsonPropertiesItemsItem[]
DocCountErrorUpperBound Int
SumOtherDocCount        Int


```

This function will Get an EventDistinct by Field Service StartTime. Field, Service, and StartTime are required parameters.

