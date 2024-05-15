### Example 1: Create a SystemGroup by Name
```powershell
PS C:\> New-JcSdkSystemGroup -Name:(<string>) -Attributes:(<hashtable>) -Description:(<string>) -Email:(<string>) -MemberQueryExemptions:(<JumpCloud.SDK.V2.Models.GraphObject[]>) -MemberQueryFilters:(<JumpCloud.SDK.V2.Models.Any[]>) -MemberQueryType:(<string>) -MemberSuggestionsNotify:(<switch>) -MembershipMethod:(<string>)



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

This function will Create a SystemGroup by Name. Name is a required parameter.

### Example 2: Create a SystemGroup by Body
```powershell
PS C:\> New-JcSdkSystemGroup -Body:(<JumpCloud.SDK.V2.Models.SystemGroupPost>)



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

This function will Create a SystemGroup by Body. Body is a required parameter.

