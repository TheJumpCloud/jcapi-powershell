### Example 1: Set an UserGroup by Id, and Body
```powershell
PS C:\> Set-JcSdkUserGroup -Id:(<string>) -Body:(<JumpCloud.SDK.V2.Models.UserGroupPut>)



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

This function will Set an UserGroup by Id Body. Id, and Body are required parameters.

### Example 2: Set an UserGroup by Id, and Name
```powershell
PS C:\> Set-JcSdkUserGroup -Id:(<string>) -Name:(<string>) -Attributes:(<hashtable>) -Description:(<string>) -Email:(<string>) -MemberQueryExemptions:(<JumpCloud.SDK.V2.Models.GraphObject[]>) -MemberQueryFilters:(<JumpCloud.SDK.V2.Models.Any[]>) -MemberQueryType:(<string>) -MemberSuggestionsNotify:(<switch>) -MembershipMethod:(<string>)



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

This function will Set an UserGroup by Id Name. Id, and Name are required parameters.

