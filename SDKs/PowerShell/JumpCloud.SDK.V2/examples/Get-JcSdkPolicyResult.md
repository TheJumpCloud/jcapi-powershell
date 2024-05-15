### Example 1: Get a PolicyResult by Id
```powershell
PS C:\> Get-JcSdkPolicyResult -Id:(<string>)



----       ----------
Detail     String
EndedAt    Datetime
ExitStatus System.Nullable[long] ExitStatus {get;set;}
Id         String
PolicyId   String
StartedAt  Datetime
State      String
StdErr     String
StdOut     String
Success    Boolean
SystemId   String


```

This function will Get a PolicyResult by Id. Id is a required parameter.

### Example 2: List PolicyResults
```powershell
PS C:\> Get-JcSdkPolicyResult -PolicyId:(<string>) -Fields:(<string[]>) -Filter:(<string[]>) -Sort:(<string[]>)



----       ----------
Detail     String
EndedAt    Datetime
ExitStatus System.Nullable[long] ExitStatus {get;set;}
Id         String
PolicyId   String
StartedAt  Datetime
State      String
StdErr     String
StdOut     String
Success    Boolean
SystemId   String


```

This function will return a list of all PolicyResults. Fields, Filter, and Sort are optional parameters.

