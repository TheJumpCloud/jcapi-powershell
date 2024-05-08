### Example 1: Grant a Workday by WorkdayId
```powershell
PS C:\> Grant-JcSdkWorkday -WorkdayId:(<string>) -BasicPassword:(<string>) -BasicUsername:(<string>) -OauthCode:(<string>)


```

This function will Grant a Workday by WorkdayId. WorkdayId is a required parameter.

### Example 2: Grant a Workday by WorkdayId, and Body
```powershell
PS C:\> Grant-JcSdkWorkday -WorkdayId:(<string>) -Body:(<JumpCloud.SDK.V2.Models.AuthInputObject>)


```

This function will Grant a Workday by WorkdayId Body. WorkdayId, and Body are required parameters.

