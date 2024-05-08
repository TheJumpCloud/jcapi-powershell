### Example 1: Set a Command by Id, and Body
```powershell
PS C:\> Set-JcSdkCommand -Id:(<string>) -Body:(<JumpCloud.SDK.V1.Models.Command>)



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

This function will Set a Command by Id Body. Id, and Body are required parameters.

### Example 2: Set a Command by Id, Command, CommandType, and Name
```powershell
PS C:\> Set-JcSdkCommand -Id:(<string>) -Command:(<string>) -CommandType:(<string>) -Name:(<string>) -CommandRunners:(<string[]>) -Files:(<string[]>) -LaunchType:(<string>) -ListensTo:(<string>) -Organization:(<string>) -Schedule:(<string>) -ScheduleRepeatType:(<string>) -ScheduleYear:(<int>) -Shell:(<string>) -Sudo:(<switch>) -Template:(<string>) -TimeToLiveSeconds:(<int>) -Timeout:(<string>) -Trigger:(<string>) -User:(<string>)



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

This function will Set a Command by Id Command CommandType Name. Id, Command, CommandType, and Name are required parameters.

