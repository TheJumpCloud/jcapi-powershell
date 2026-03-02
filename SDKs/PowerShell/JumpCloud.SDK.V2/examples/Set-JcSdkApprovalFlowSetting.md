### Example 1: Set an ApprovalFlowSetting by
```powershell
PS C:\> Set-JcSdkApprovalFlowSetting -AdminApprovalEmail:(<switch>) -ChannelEvents:(<JumpCloud.SDK.V2.Models.JumpcloudIngressoChannelEvent[]>) -ExposeApprovalProgress:(<switch>) -OrganizationObjectIdInputFile:(<string>) -ResourceRequest:(<switch>) -UserApprovalEmail:(<switch>) -UserRequestEmail:(<switch>)
```

```output
{{ Add output here (remove the output block if the example doesnt have an output) }}
```

This function will Set an ApprovalFlowSetting by .

### Example 2: Set an ApprovalFlowSetting by Body
```powershell
PS C:\> Set-JcSdkApprovalFlowSetting -Body:(<JumpCloud.SDK.V2.Models.JumpcloudIngressoUpdateAccessWorkflowSettingsRequest>)
```

```output
{{ Add output here (remove the output block if the example doesnt have an output) }}
```

This function will Set an ApprovalFlowSetting by Body. Body is a required parameter.

