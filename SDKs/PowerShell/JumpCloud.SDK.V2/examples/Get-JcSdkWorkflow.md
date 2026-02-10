### Example 1: Get a Workflow by ApprovalFlowId
```powershell
Get-JcSdkWorkflow -ApprovalFlowId:(<string>)
```

```output
ApprovalType        : automated
ApproverRequirement :
ApproverResources   : {}
Category            : Application
CreatedBy           : 5d643a77600577710a5e6113
Description         : Workflow testing
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

This function will Get a Workflow by ApprovalFlowId. ApprovalFlowId is a required parameter.

### Example 2: List Workflows
```powershell
Get-JcSdkWorkflow -Fields:(<System.Collections.Generic.List[string]>) -Filter:(<System.Collections.Generic.List[string]>) -Sort:(<string>)
```

```output
ApprovalType        : automated
ApproverRequirement :
ApproverResources   : {}
Category            : Application
CreatedBy           : 5d643a77600577710a5e6113
Description         : Workflow testing
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

This function will return a list of all Workflows. Fields, Filter, and Sort are optional parameters.

