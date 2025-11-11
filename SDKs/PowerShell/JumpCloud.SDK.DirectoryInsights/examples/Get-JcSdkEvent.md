### Example 1: Get an Event by Service, and StartTime
```powershell
Get-JcSdkEvent -Service:(<string[]>) -StartTime:(<datetime>) -EndTime:(<datetime>) -ExactMatch:(<string>) -Fields:(<string[]>) -Limit:(<long>) -Q:(<string>) -SearchAfter:(<string[]>) -SearchTermAnd:(<hashtable>) -SearchTermNot:(<hashtable>) -SearchTermOr:(<hashtable>) -Skip:(<long>) -Sort:(<string>)
```

```output
{{ Add output here (remove the output block if the example doesn't have an output) }}
```

This function will Get an Event by Service StartTime. Service, and StartTime are required parameters.

### Example 2: Get an Event by Body
```powershell
Get-JcSdkEvent -Body:(<JumpCloud.SDK.DirectoryInsights.Models.EventQuery>)
```

```output
{{ Add output here (remove the output block if the example doesn't have an output) }}
```

This function will Get an Event by Body. Body is a required parameter.

