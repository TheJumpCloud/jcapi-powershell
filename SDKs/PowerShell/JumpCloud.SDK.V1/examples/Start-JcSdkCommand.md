### Example 1: Start a Command by Body
```powershell
PS C:\> Start-JcSdkCommand -Body:(<JumpCloud.SDK.V1.Models.PathsPnxbyeRuncommandPostRequestbodyContentApplicationJsonSchema>)



----               ----------
QueueIds           String
WorkflowInstanceId String


```

This function will Start a Command by Body. Body is a required parameter.

### Example 2: Start a Command by
```powershell
PS C:\> Start-JcSdkCommand -Id:(<string>) -SystemIds:(<string[]>)



----               ----------
QueueIds           String
WorkflowInstanceId String


```

This function will Start a Command by .

