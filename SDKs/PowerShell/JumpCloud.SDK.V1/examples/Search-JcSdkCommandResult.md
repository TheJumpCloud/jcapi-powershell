### Example 1: Search using the filter and field parameters

```powershell
search-JcSdkCommandResult -filter @{'and' = @("name:`$regex:RadiusCert*", "workflowId:`$eq:6406532738e1a32cafa24260")} -fields "response.data.exitCode name system workflowId"
```

```output
Command            :
DataExitCode       : 0
DataOutput         :
Files              :
Id                 : 64065378c2165ca5044e2902
Name               : testname
RequestTime        :
ResponseError      :
ResponseId         :
ResponseTime       :
Sudo               :
SystemId           : 636d2a89e05773965cdb4092
User               :
WorkflowId         : 6406532738e1a32cafa24260
WorkflowInstanceId :
```

Search for commands where `name` matches a regex pattern, `workflowId` matches an exact value and return only `exitCode`, `name`, `systemId` and `workflowId`. Note, fields `ExitCode`, `Output` are nested, when specifying these values using the fields/ filter parameters, reference them with `response.data.exitCode` & `response.data.output` respectively. The `systemID` field is referenced by `system` if using the fields/ filter parameters.

### Example 2: Search using the body parameter set
```powershell
$body = @{
    'filter' = @{
        'and' = @("workflowId:`$eq:6406532738e1a32cafa24260")
    }
}
Search-JcSdkCommandResult -Body $body
```

```output
Command            : echo "testname"
DataExitCode       : 0
DataOutput         : testname

Files              : {}
Id                 : 640659f4b7ac4d5f061f8ac9
Name               : RadiusCert-Install Farmer_142 Windows
RequestTime        : 3/6/2023 9:24:04 PM
ResponseError      :
ResponseId         : 640659f4b7ac4d5f061f8ac9
ResponseTime       : 3/6/2023 9:24:04 PM
Sudo               : False
SystemId           : 636d2a89e05773965cdb4092
User               : root
WorkflowId         : 6406532738e1a32cafa24260
WorkflowInstanceId : 6406595bdefe7fd96e664f8b
```

Search for commands using the `body` parameter. In this search only command results who's `workflowId` (CommandID) are returned

