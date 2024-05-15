### Example 1: List AuthenticationPolicys
```powershell
PS C:\> Get-JcSdkAuthenticationPolicy -Filter:(<string[]>) -Sort:(<string[]>) -XTotalCount:(<int>)



----                        ----------
Conditions                  JumpCloud.SDK.V2.Models.AuthnPolicyConditions
Description                 String
Disabled                    Boolean
EffectAction                String
Id                          String
MfaRequired                 Boolean
Name                        String
TargetResources             JumpCloud.SDK.V2.Models.AuthnPolicyResourceTarget[]
Type                        String
UserAttributeExclusions     JumpCloud.SDK.V2.Models.AuthnPolicyUserAttributeFilter[]
UserAttributeInclusions     JumpCloud.SDK.V2.Models.AuthnPolicyUserAttributeFilter[]
UserGroupExclusions         String
UserGroupInclusions         String
UserInclusions              String
UserVerificationRequirement String


```

This function will return a list of all AuthenticationPolicys. Filter, Sort, and XTotalCount are optional parameters.

### Example 2: Get an AuthenticationPolicy by Id
```powershell
PS C:\> Get-JcSdkAuthenticationPolicy -Id:(<string>)



----                        ----------
Conditions                  JumpCloud.SDK.V2.Models.AuthnPolicyConditions
Description                 String
Disabled                    Boolean
EffectAction                String
Id                          String
MfaRequired                 Boolean
Name                        String
TargetResources             JumpCloud.SDK.V2.Models.AuthnPolicyResourceTarget[]
Type                        String
UserAttributeExclusions     JumpCloud.SDK.V2.Models.AuthnPolicyUserAttributeFilter[]
UserAttributeInclusions     JumpCloud.SDK.V2.Models.AuthnPolicyUserAttributeFilter[]
UserGroupExclusions         String
UserGroupInclusions         String
UserInclusions              String
UserVerificationRequirement String


```

This function will Get an AuthenticationPolicy by Id. Id is a required parameter.

