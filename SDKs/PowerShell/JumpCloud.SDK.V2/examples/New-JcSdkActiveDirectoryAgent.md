### Example 1: Create an ActiveDirectoryAgent by ActivedirectoryId
```powershell
PS C:\> New-JcSdkActiveDirectoryAgent -ActivedirectoryId:(<string>) -AgentType:(<string>)



----       ----------
ConnectKey String
ContactAt  String
Hostname   String
Id         String
SourceIP   String
State      String
Version    String


```

This function will Create an ActiveDirectoryAgent by ActivedirectoryId. ActivedirectoryId is a required parameter.

### Example 2: Create an ActiveDirectoryAgent by ActivedirectoryId, and Body
```powershell
PS C:\> New-JcSdkActiveDirectoryAgent -ActivedirectoryId:(<string>) -Body:(<JumpCloud.SDK.V2.Models.ActiveDirectoryAgent>)



----       ----------
ConnectKey String
ContactAt  String
Hostname   String
Id         String
SourceIP   String
State      String
Version    String


```

This function will Create an ActiveDirectoryAgent by ActivedirectoryId Body. ActivedirectoryId, and Body are required parameters.

