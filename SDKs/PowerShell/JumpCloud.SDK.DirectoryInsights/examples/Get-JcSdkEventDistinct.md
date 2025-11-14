### Example 1: Get an EventDistinct by Field, Service, and StartTime
```powershell
Get-JcSdkEventDistinct -Field:(<string>) -Service:(<string[]>) -StartTime:(<datetime>) -EndTime:(<datetime>) -SearchTermAnd:(<hashtable>) -SearchTermNot:(<hashtable>) -SearchTermOr:(<hashtable>)
```

```output
{{ Add output here (remove the output block if the example doesn't have an output) }}
```

This function will Get an EventDistinct by Field Service StartTime. Field, Service, and StartTime are required parameters.

### Example 2: Get an EventDistinct by Body
```powershell
Get-JcSdkEventDistinct -Body:(<JumpCloud.SDK.DirectoryInsights.Models.EventDistinctQuery>)
```

```output
{{ Add output here (remove the output block if the example doesn't have an output) }}
```

This function will Get an EventDistinct by Body. Body is a required parameter.

