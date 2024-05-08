### Example 1: Update an AuthenticationPolicy by Id, and Body
```powershell
PS C:\> Update-JcSdkAuthenticationPolicy -Id:(<string>) -Body:(<JumpCloud.SDK.V2.Models.AuthnPolicy>)



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

This function will Update an AuthenticationPolicy by Id Body. Id, and Body are required parameters.

### Example 2: Update an AuthenticationPolicy by Id
```powershell
PS C:\> Update-JcSdkAuthenticationPolicy -Id:(<string>) -Conditions:(<hashtable>) -Description:(<string>) -Disabled:(<switch>) -EffectAction:(<string>) -MfaRequired:(<switch>) -Name:(<string>) -TargetResources:(<JumpCloud.SDK.V2.Models.AuthnPolicyResourceTarget[]>) -Type:(<string>) -UserAttributeExclusions:(<JumpCloud.SDK.V2.Models.AuthnPolicyUserAttributeFilter[]>) -UserAttributeInclusions:(<JumpCloud.SDK.V2.Models.AuthnPolicyUserAttributeFilter[]>) -UserGroupExclusions:(<string[]>) -UserGroupInclusions:(<string[]>) -UserInclusions:(<string[]>) -UserVerificationRequirement:(<string>)



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

This function will Update an AuthenticationPolicy by Id. Id is a required parameter.

