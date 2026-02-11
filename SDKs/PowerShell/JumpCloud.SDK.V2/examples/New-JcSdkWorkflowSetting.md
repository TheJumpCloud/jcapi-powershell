### Example 1: Create a WorkflowSetting
```powershell
New-JcSdkWorkflowSetting -Body:(<JumpCloud.SDK.V2.Models.JumpcloudIngressoCreateAccessWorkflowSettingsRequest>)
```
```output
{{ Add output here (remove the output block if the example doesn't have an output) }}
```

This function will Create a WorkflowSetting by Body. Body is a required parameter.

### Example 2: Create a WorkflowSetting by
```powershell
New-JcSdkWorkflowSetting -AdminApprovalEmail:(<switch>) -ChannelEvents:(<JumpCloud.SDK.V2.Models.JumpcloudIngressoChannelEvent[]>) -ExposeApprovalProgress:(<switch>) -OrganizationObjectIdInputFile:(<string>) -ResourceRequest:(<switch>) -UserApprovalEmail:(<switch>) -UserRequestEmail:(<switch>)
```

```output
{{ Add output here (remove the output block if the example doesn't have an output) }}
```

This function will Create a WorkflowSetting by .

