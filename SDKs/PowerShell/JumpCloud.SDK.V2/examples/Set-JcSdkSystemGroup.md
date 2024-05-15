### Example 1: Set a SystemGroup by Id, and Body
```powershell
PS C:\> Set-JcSdkSystemGroup -Id:(<string>) -Body:(<JumpCloud.SDK.V2.Models.SystemGroupPut>)



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

This function will Set a SystemGroup by Id Body. Id, and Body are required parameters.

### Example 2: Set a SystemGroup by Id, and Name
```powershell
PS C:\> Set-JcSdkSystemGroup -Id:(<string>) -Name:(<string>) -Attributes:(<hashtable>) -Description:(<string>) -Email:(<string>) -MemberQueryExemptions:(<JumpCloud.SDK.V2.Models.GraphObject[]>) -MemberQueryFilters:(<JumpCloud.SDK.V2.Models.Any[]>) -MemberQueryType:(<string>) -MemberSuggestionsNotify:(<switch>) -MembershipMethod:(<string>)



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

This function will Set a SystemGroup by Id Name. Id, and Name are required parameters.

