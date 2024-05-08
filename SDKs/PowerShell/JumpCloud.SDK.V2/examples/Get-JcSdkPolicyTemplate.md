### Example 1: List PolicyTemplates
```powershell
PS C:\> Get-JcSdkPolicyTemplate -Fields:(<string[]>) -Filter:(<string[]>) -Sort:(<string[]>)



----           ----------
Activation     String
Alert          String
Behavior       String
DeliveryTypes  String
Description    String
DisplayName    String
Id             String
Name           String
OSMetaFamily   String
OSRestrictions JumpCloud.SDK.V2.Models.OSRestriction[]
Reference      String
State          String


```

This function will return a list of all PolicyTemplates. Fields, Filter, and Sort are optional parameters.

### Example 2: Get a PolicyTemplate by Id
```powershell
PS C:\> Get-JcSdkPolicyTemplate -Id:(<string>)



----           ----------
Activation     String
Alert          String
Behavior       String
DeliveryTypes  String
Description    String
DisplayName    String
Id             String
Name           String
OSMetaFamily   String
OSRestrictions JumpCloud.SDK.V2.Models.OSRestriction[]
Reference      String
State          String


```

This function will Get a PolicyTemplate by Id. Id is a required parameter.

