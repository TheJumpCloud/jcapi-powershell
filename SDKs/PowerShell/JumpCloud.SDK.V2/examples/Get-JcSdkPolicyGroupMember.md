### Example 1: Get a PolicyGroupMember by PolicyId
```powershell
PS C:\> Get-JcSdkPolicyGroupMember -PolicyId:(<string>) -Filter:(<string[]>) -Sort:(<string[]>) -Authorization:(<string>) -Date:(<string>)



----           ----------
Attributes     JumpCloud.SDK.V2.Models.GraphAttributes
FromAttributes JumpCloud.SDK.V2.Models.GraphAttributes
FromId         String
FromType       String
ToAttributes   JumpCloud.SDK.V2.Models.GraphAttributes
ToId           String
ToType         String


```

This function will Get a PolicyGroupMember by PolicyId. PolicyId is a required parameter.

### Example 2: List PolicyGroupMembers
```powershell
PS C:\> Get-JcSdkPolicyGroupMember -GroupId:(<string>)



----           ----------
Attributes     JumpCloud.SDK.V2.Models.GraphAttributes
FromAttributes JumpCloud.SDK.V2.Models.GraphAttributes
FromId         String
FromType       String
ToAttributes   JumpCloud.SDK.V2.Models.GraphAttributes
ToId           String
ToType         String


```

This function will return a list of all PolicyGroupMembers.

