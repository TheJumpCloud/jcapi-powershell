### Example 1: List ActiveDirectoryAgents
```powershell
PS C:\> Get-JcSdkActiveDirectoryAgent -ActivedirectoryId:(<string>) -Sort:(<string[]>)



----      ----------
ContactAt String
Hostname  String
Id        String
SourceIP  String
State     String
Version   String


```

This function will return a list of all ActiveDirectoryAgents. Sort is an optional parameter.

### Example 2: Get an ActiveDirectoryAgent by ActivedirectoryId, and AgentId
```powershell
PS C:\> Get-JcSdkActiveDirectoryAgent -ActivedirectoryId:(<string>) -AgentId:(<string>)



----      ----------
ContactAt String
Hostname  String
Id        String
SourceIP  String
State     String
Version   String


```

This function will Get an ActiveDirectoryAgent by ActivedirectoryId AgentId. ActivedirectoryId, and AgentId are required parameters.

