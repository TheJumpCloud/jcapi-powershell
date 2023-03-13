### Example 1: List all command results

```powershell
Get-JcSdkCommandResult
```

```output
...
Command      : echo "testname"
ExitCode     : 0
Id           : 64065378c2165ca5044e2902
Name         : testname
RequestTime  : 3/6/2023 8:56:24 PM
ResponseTime : 3/6/2023 8:56:24 PM
Sudo         : False
System       : SE0PU00ABEXY-darwin
SystemId     : 636d2a89e05773965cdb4092
User         : root
WorkflowId   : 6406532738e1a32cafa24260

Command      : echo "testname"
ExitCode     : 0
Id           : 640659f4b7ac4d5f061f8ac9
Name         : RadiusCert-Install Farmer_142 Windows
RequestTime  : 3/6/2023 9:24:04 PM
ResponseTime : 3/6/2023 9:24:04 PM
Sudo         : False
System       : SE0PU00ABEXY-darwin
SystemId     : 636d2a89e05773965cdb4092
User         : root
WorkflowId   : 6406532738e1a32cafa24260
...
```

Returns all command results

### Example 2: Get Command Results by individual ID

```powershell
Get-JcSdkCommandResult -Id 640659f4b7ac4d5f061f8ac9
```

```output

Command      : echo "testname"
ExitCode     : 0
Id           : 640659f4b7ac4d5f061f8ac9
Name         : RadiusCert-Install Farmer_142 Windows
RequestTime  : 3/6/2023 9:24:04 PM
ResponseTime : 3/6/2023 9:24:04 PM
Sudo         : False
System       : SE0PU00ABEXY-darwin
SystemId     : 636d2a89e05773965cdb4092
User         : root
WorkflowId   : 6406532738e1a32cafa24260
```

Returns a specific command result by it's individual Id (i.e. the ID of the commandResult, not command)