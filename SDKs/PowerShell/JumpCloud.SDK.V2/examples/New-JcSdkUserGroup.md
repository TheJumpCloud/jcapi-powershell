### Example 1: Create an UserGroup by Name
```powershell
PS C:\> New-JcSdkUserGroup -Name:(<string>) -Attributes:(<hashtable>) -Description:(<string>) -Email:(<string>) -MemberQueryExemptions:(<JumpCloud.SDK.V2.Models.GraphObject[]>) -MemberQueryFilters:(<JumpCloud.SDK.V2.Models.Any[]>) -MemberQueryType:(<string>) -MemberSuggestionsNotify:(<switch>) -MembershipMethod:(<string>)



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

This function will Create an UserGroup by Name. Name is a required parameter.

### Example 2: Create an UserGroup by Body
```powershell
PS C:\> New-JcSdkUserGroup -Body:(<JumpCloud.SDK.V2.Models.UserGroupPost>)



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

This function will Create an UserGroup by Body. Body is a required parameter.

