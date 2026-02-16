### Example 1: Set an AccessRequest by Id
```powershell
PS C:\> Set-JcSdkAccessRequest -Id:(<string>) -Admin:(<string>) -ApprovedDuration:(<string>) -InternalNote:(<string>) -OrganizationObjectIdInputFile:(<string>) -Remarks:(<string>) -Status:(<string>)
```

```output
JumpCloud.SDK.V2.Models.JumpcloudIngressoUpdateWorkflowAccessRequestResponse
```

This function will Set an AccessRequest by Id. Id is a required parameter.

### Example 2: Set an AccessRequest by Id, and Body
```powershell
PS C:\> Set-JcSdkAccessRequest -Id:(<string>) -Body:(<JumpCloud.SDK.V2.Models.Paths17F25RsApprovalflowrequestIdPutRequestbodyContentApplicationJsonSchema>)
```

```output
JumpCloud.SDK.V2.Models.JumpcloudIngressoUpdateWorkflowAccessRequestResponse
```

This function will Set an AccessRequest by Id Body. Id, and Body are required parameters.

