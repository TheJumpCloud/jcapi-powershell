### Example 1: Set a PolicyAssociation by PolicyId, and Body
```powershell
PS C:\> Set-JcSdkPolicyAssociation -PolicyId:(<string>) -Body:(<JumpCloud.SDK.V2.Models.GraphOperationPolicy>)


```

This function will Set a PolicyAssociation by PolicyId Body. PolicyId, and Body are required parameters.

### Example 2: Set a PolicyAssociation by PolicyId, Id, Op, and Type
```powershell
PS C:\> Set-JcSdkPolicyAssociation -PolicyId:(<string>) -Id:(<string>) -Op:(<string>) -Type:(<JumpCloud.SDK.V2.Support.GraphOperationPolicy1>) -Attributes:(<hashtable>)


```

This function will Set a PolicyAssociation by PolicyId Id Op Type. PolicyId, Id, Op, and Type are required parameters.

