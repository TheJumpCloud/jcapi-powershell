### Example 1: List UserGroups
```powershell
PS C:\> Get-JcSdkUserGroup -Fields:(<string[]>) -Filter:(<string[]>) -Sort:(<string[]>)



----                    ----------
Attributes              JumpCloud.SDK.V2.Models.GroupAttributesUserGroup
Description             String
Email                   String
Id                      String
MemberQueryExemptions   JumpCloud.SDK.V2.Models.GraphObject[]
MemberQueryFilters      JumpCloud.SDK.V2.Models.Any[]
MemberQueryType         String
MembershipMethod        String
MemberSuggestionsNotify Boolean
Name                    String
SuggestionCountAdd      Int
SuggestionCountRemove   Int
SuggestionCountTotal    Int
Type                    String


```

This function will return a list of all UserGroups. Fields, Filter, and Sort are optional parameters.

### Example 2: Get an UserGroup by Id
```powershell
PS C:\> Get-JcSdkUserGroup -Id:(<string>)



----                    ----------
Attributes              JumpCloud.SDK.V2.Models.GroupAttributesUserGroup
Description             String
Email                   String
Id                      String
MemberQueryExemptions   JumpCloud.SDK.V2.Models.GraphObject[]
MemberQueryFilters      JumpCloud.SDK.V2.Models.Any[]
MemberQueryType         String
MembershipMethod        String
MemberSuggestionsNotify Boolean
Name                    String
SuggestionCountAdd      Int
SuggestionCountRemove   Int
SuggestionCountTotal    Int
Type                    String


```

This function will Get an UserGroup by Id. Id is a required parameter.

