### Example 1: Get an EventInterval by IntervalUnit, Service, and StartTime
```powershell
Get-JcSdkEventInterval -IntervalUnit:(<string>) -Service:(<string[]>) -StartTime:(<datetime>) -EndTime:(<datetime>) -ExactMatch:(<string>) -IntervalValue:(<string>) -Q:(<string>) -SearchTermAnd:(<hashtable>) -SearchTermNot:(<hashtable>) -SearchTermOr:(<hashtable>) -Timezone:(<string>)
```

```output
{{ Add output here (remove the output block if the example doesn't have an output) }}
```

This function will Get an EventInterval by IntervalUnit Service StartTime. IntervalUnit, Service, and StartTime are required parameters.

### Example 2: Get an EventInterval by Body
```powershell
Get-JcSdkEventInterval -Body:(<JumpCloud.SDK.DirectoryInsights.Models.EventIntervalQuery>)
```

```output
{{ Add output here (remove the output block if the example doesn't have an output) }}
```

This function will Get an EventInterval by Body. Body is a required parameter.

