### Example 1: Set an ApprovalFlow by ApprovalFlowId
```powershell
PS C:\> Set-JcSdkApprovalFlow -ApprovalFlowId:(<string>) -ApprovalType:(<string>) -ApproverRequirement:(<string>) -ApproverResources:(<JumpCloud.SDK.V2.Models.JumpcloudIngressoApproverResource[]>) -Description:(<string>) -FixedDuration:(<string>) -IconColor:(<string>) -IconUrl:(<string>) -MultiSelectDuration:(<string[]>) -Name:(<string>) -NonAdminApproval:(<switch>) -OrganizationObjectIdInputFile:(<string>) -ResourceId:(<string>) -SlackConfig:(<JumpCloud.SDK.V2.Models.JumpcloudIngressoSlackConfig[]>) -SlackEnabled:(<switch>) -Status:(<string>) -TimeBasedAccess:(<switch>) -TtlConfig:(<string>) -VisibleTo:(<string[]>)
```

```output
{{ Add output here (remove the output block if the example doesnt have an output) }}
```

This function will Set an ApprovalFlow by ApprovalFlowId. ApprovalFlowId is a required parameter.

### Example 2: Set an ApprovalFlow by ApprovalFlowId, and Body
```powershell
PS C:\> Set-JcSdkApprovalFlow -ApprovalFlowId:(<string>) -Body:(<JumpCloud.SDK.V2.Models.Paths14Hfh8UApprovalflowsApprovalflowidPutRequestbodyContentApplicationJsonSchema>)
```

```output
{{ Add output here (remove the output block if the example doesnt have an output) }}
```

This function will Set an ApprovalFlow by ApprovalFlowId Body. ApprovalFlowId, and Body are required parameters.

