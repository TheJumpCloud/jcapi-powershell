### Example 1: Get an ApprovalFlow by ApprovalFlowId
```powershell
Get-JcSdkApprovalFlow -ApprovalFlowId:(<string>)
```

```output
ApprovalType        : automated
ApproverRequirement :
ApproverResources   : {}
Category            : Application
CreatedBy           : 5d643a77600577710a5e6113
Description         : Approval Flow testing
FixedDuration       :
IconColor           : #006CAC
IconUrl             :
Id                  : 67c5f44e2d72ba0001b6890b
MultiSelectDuration : {}
Name                : Test Workflow
NonAdminApproval    : False
OrganizationId      : {93, 100, 58, 119…}
Resources           : {Radius2}
SlackConfig         : {}
SlackEnabled        : False
Status              : active
TimeBasedAccess     : False
TtlConfig           : TTL_CONFIG_UNSPECIFIED
UpdatedBy           : 5d643a77600577710a5e6113
VisibleTo           : {Default Admin, Radius}
```

This function will Get an ApprovalFlow by ApprovalFlowId. ApprovalFlowId is a required parameter.

### Example 2: List ApprovalFlow
```powershell
Get-JcSdkApprovalFlow -Fields:(<System.Collections.Generic.List[string]>) -Filter:(<System.Collections.Generic.List[string]>) -Sort:(<string>)
```

```output
ApprovalType        : automated
ApproverRequirement :
ApproverResources   : {}
Category            : Application
CreatedBy           : 5d643a77600577710a5e6113
Description         : Approval Flow testing
FixedDuration       :
IconColor           : #006CAC
IconUrl             :
Id                  : 67c5f44e2d72ba0001b6890b
MultiSelectDuration : {}
Name                : Test Approval Flow
NonAdminApproval    : False
OrganizationId      : {93, 100, 58, 119…}
Resources           : {Radius2}
SlackConfig         : {}
SlackEnabled        : False
Status              : active
TimeBasedAccess     : False
TtlConfig           : TTL_CONFIG_UNSPECIFIED
UpdatedBy           : 5d643a77600577710a5e6113
VisibleTo           : {Default Admin, Radius}
```

This function will return a list of all ApprovalFlows. Fields, Filter, and Sort are optional parameters.

