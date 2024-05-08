### Example 1: List Commands
```powershell
PS C:\> Get-JcSdkCommand -Filter:(<string[]>) -Sort:(<string>)



----               ----------
Command1           String
CommandRunners     String
CommandType        String
Files              String
LaunchType         String
ListensTo          String
Name               String
Organization       String
Schedule           String
ScheduleRepeatType String
ScheduleYear       Int
Shell              String
Sudo               Boolean
Template           String
Timeout            String
TimeToLiveSeconds  Int
Trigger            String
User               String


```

This function will return a list of all Commands. Filter, and Sort are optional parameters.

### Example 2: Get a Command by Id
```powershell
PS C:\> Get-JcSdkCommand -Id:(<string>)



----               ----------
Command1           String
CommandRunners     String
CommandType        String
Files              String
LaunchType         String
ListensTo          String
Name               String
Organization       String
Schedule           String
ScheduleRepeatType String
ScheduleYear       Int
Shell              String
Sudo               Boolean
Template           String
Timeout            String
TimeToLiveSeconds  Int
Trigger            String
User               String


```

This function will Get a Command by Id. Id is a required parameter.

