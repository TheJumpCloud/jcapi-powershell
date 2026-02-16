### Example 1: Set an AccessRequestApproval by
```powershell
PS C:\> Set-JcSdkAccessRequestApproval -ApprovedDuration:(<string>) -Id:(<string>) -OrganizationObjectIdInputFile:(<string>) -Remarks:(<string>) -Status:(<string>)
```

```output
JumpCloud.SDK.V2.Models.JumpcloudIngressoUserApprovalRequestResponse
```

This function will Set an AccessRequestApproval by .

### Example 2: Set an AccessRequestApproval by Body
```powershell
PS C:\> Set-JcSdkAccessRequestApproval -Body:(<JumpCloud.SDK.V2.Models.JumpcloudIngressoUserApprovalRequest>)
```

```output
JumpCloud.SDK.V2.Models.JumpcloudIngressoUserApprovalRequestResponse
```

This function will Set an AccessRequestApproval by Body. Body is a required parameter.

