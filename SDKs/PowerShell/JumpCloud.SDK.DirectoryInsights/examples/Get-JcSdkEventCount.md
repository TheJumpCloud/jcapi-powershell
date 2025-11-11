### Example 1: Get an EventCount by Service, and StartTime
```powershell
Get-JcSdkEventCount -Service:(<string[]>) -StartTime:(<datetime>) -EndTime:(<datetime>) -ExactMatch:(<string>) -Fields:(<string[]>) -Q:(<string>) -SearchAfter:(<string[]>) -SearchTermAnd:(<hashtable>) -SearchTermNot:(<hashtable>) -SearchTermOr:(<hashtable>) -Sort:(<string>)
```

```output
{{ Add output here (remove the output block if the example doesn't have an output) }}
```

This function will Get an EventCount by Service StartTime. Service, and StartTime are required parameters.

### Example 2: Get an EventCount by Body
```powershell
Get-JcSdkEventCount -Body:(<JumpCloud.SDK.DirectoryInsights.Models.EventQuery>)
```

```output
{{ Add output here (remove the output block if the example doesn't have an output) }}
```

This function will Get an EventCount by Body. Body is a required parameter.

