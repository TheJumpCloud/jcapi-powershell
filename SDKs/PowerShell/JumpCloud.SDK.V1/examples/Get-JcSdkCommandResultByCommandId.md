### Example 1: return command results by commandID
```powershell
get-JcSdkCommandResultByCommandId -Id 6406532738e1a32cafa24260
```

```output
Command            : echo "testname"
DataExitCode       : 0
DataOutput         : testname

Files              : {}
Id                 : 640659f4b7ac4d5f061f8ac9
Name               : RadiusCert-Install Farmer_142 Windows
Organization       : 5d643a77600577710a5e6112
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

Returns command results by commandID (workflowID) for naming simplicity the command references commandID but command results store this data in the `workflowId` field.