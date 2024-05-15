### Example 1: Get an EventInterval by Body
```powershell
PS C:\> Get-JcSdkEventInterval -Body:(<JumpCloud.SDK.DirectoryInsights.Models.EventIntervalQuery>)



----        ----------
DocCount    Int
Key         Int
KeyAsString


```

This function will Get an EventInterval by Body. Body is a required parameter.

### Example 2: Get an EventInterval by IntervalUnit, Service, and StartTime
```powershell
PS C:\> Get-JcSdkEventInterval -IntervalUnit:(<string>) -Service:(<string[]>) -StartTime:(<datetime>) -EndTime:(<datetime>) -IntervalValue:(<string>) -Q:(<string>) -SearchTermAnd:(<hashtable>) -SearchTermNot:(<hashtable>) -SearchTermOr:(<hashtable>) -Timezone:(<string>)



----        ----------
DocCount    Int
Key         Int
KeyAsString


```

This function will Get an EventInterval by IntervalUnit Service StartTime. IntervalUnit, Service, and StartTime are required parameters.

