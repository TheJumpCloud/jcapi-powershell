### Example 1: Create a BulkUserState by StartDate, State, and UserIds
```powershell
PS C:\> New-JcSdkBulkUserState -StartDate:(<datetime>) -State:(<string>) -UserIds:(<string[]>) -ActivationEmailOverride:(<string>) -SendActivationEmails:(<switch>)



----           ----------
ScheduledDate  String
ScheduledJobId String
State          String
SystemUserId   String


```

This function will Create a BulkUserState by StartDate State UserIds. StartDate, State, and UserIds are required parameters.

### Example 2: Create a BulkUserState by Body
```powershell
PS C:\> New-JcSdkBulkUserState -Body:(<JumpCloud.SDK.V2.Models.BulkScheduledStatechangeCreate>)



----           ----------
ScheduledDate  String
ScheduledJobId String
State          String
SystemUserId   String


```

This function will Create a BulkUserState by Body. Body is a required parameter.

