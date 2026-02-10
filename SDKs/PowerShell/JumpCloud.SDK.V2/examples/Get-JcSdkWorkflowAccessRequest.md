### Example 1: Get a WorkflowAccessRequest by Id
```powershell
Get-JcSdkWorkflowAccessRequest -Id:(<string>)
```

```output
ApprovalFlowDescription : Workflow Description
ApprovalFlowId          : 698b4c92097b6a000175dda8
ApprovalFlowName        : Workflow Name
ApprovalType            : manual
ApprovedDuration        :
CreatedAt               : 2026-02-10T21:22:30.465574Z
Department              : Sales
Group                   : 00-Farmer-Type-Dairy
IconColor               : #006CAC
IconUrl                 :
Id                      : 698ba196ff5a9e00016c58d4
Manager                 :
NonAdminApproval        : False
Remarks                 : User Requested Message
RequestedDuration       :
Requestor               : 5d67fd481da3c52aa1faa883
RunId                   :
Status                  : granted
UpdatedAt               : 2026-02-10T21:25:09.352713Z
UpdatedBy               : 5d643a77600577710a5e6113
UserName                : Default Admin
WfMetadata              : {123, 125}
```

This function will Get a WorkflowAccessRequest by Id. Id is a required parameter.

### Example 2: List WorkflowAccessRequests
```powershell
Get-JcSdkWorkflowAccessRequest -Fields:(<System.Collections.Generic.List[string]>) -Filter:(<System.Collections.Generic.List[string]>) -Sort:(<string>)
```

```output
ApprovalFlowDescription : Workflow Description
ApprovalFlowId          : 698b4c92097b6a000175dda8
ApprovalFlowName        : Workflow Name
ApprovalType            : manual
ApprovedDuration        :
CreatedAt               : 2026-02-10T21:22:30.465574Z
Department              : Sales
Group                   : 00-Farmer-Type-Dairy
IconColor               : #006CAC
IconUrl                 :
Id                      : 698ba196ff5a9e00016c58d4
Manager                 :
NonAdminApproval        : False
Remarks                 : User Requested Message
RequestedDuration       :
Requestor               : 5d67fd481da3c52aa1faa883
RunId                   :
Status                  : granted
UpdatedAt               : 2026-02-10T21:25:09.352713Z
UpdatedBy               : 5d643a77600577710a5e6113
UserName                : Default Admin
WfMetadata              : {123, 125}
```

This function will return a list of all WorkflowAccessRequests. Fields, Filter, and Sort are optional parameters.

