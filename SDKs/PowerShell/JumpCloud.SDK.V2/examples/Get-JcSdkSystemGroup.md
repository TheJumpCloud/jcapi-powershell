### Example 1: List SystemGroups
```powershell
PS C:\> Get-JcSdkSystemGroup -Fields:(<string[]>) -Filter:(<string[]>) -Sort:(<string[]>)



----                    ----------
Attributes              JumpCloud.SDK.V2.Models.GraphAttributes
Description             String
Email                   String
Id                      String
MemberQueryExemptions   JumpCloud.SDK.V2.Models.GraphObject[]
MemberQueryFilters      JumpCloud.SDK.V2.Models.Any[]
MemberQueryType         String
MembershipMethod        String
MemberSuggestionsNotify Boolean
Name                    String
Type                    String


```

This function will return a list of all SystemGroups. Fields, Filter, and Sort are optional parameters.

### Example 2: Get a SystemGroup by Id
```powershell
PS C:\> Get-JcSdkSystemGroup -Id:(<string>)



----                    ----------
Attributes              JumpCloud.SDK.V2.Models.GraphAttributes
Description             String
Email                   String
Id                      String
MemberQueryExemptions   JumpCloud.SDK.V2.Models.GraphObject[]
MemberQueryFilters      JumpCloud.SDK.V2.Models.Any[]
MemberQueryType         String
MembershipMethod        String
MemberSuggestionsNotify Boolean
Name                    String
Type                    String


```

This function will Get a SystemGroup by Id. Id is a required parameter.

