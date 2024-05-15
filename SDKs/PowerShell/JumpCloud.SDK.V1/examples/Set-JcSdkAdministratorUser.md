### Example 1: Set an AdministratorUser by Id, and Body
```powershell
PS C:\> Set-JcSdkAdministratorUser -Id:(<string>) -Body:(<JumpCloud.SDK.V1.Models.Userput>)



----                       ----------
ApiKeyAllowed              Boolean
ApiKeySet                  Boolean
ApiKeyUpdatedAt            Datetime
Created                    Datetime
DisableIntroduction        Boolean
Email                      String
EnableMultiFactor          Boolean
Firstname                  String
GrowthDataExperimentStates JumpCloud.SDK.V1.Models.UserreturnGrowthDataExperimentStates
GrowthDataOnboardingState  JumpCloud.SDK.V1.Models.UserreturnGrowthDataOnboardingState
Id                         String
Lastname                   String
LastWhatsNewChecked        Datetime
Organization               String
PasswordUpdatedAt          Datetime
Provider                   String
Role                       String
RoleName                   String
SessionCount               Int
Suspended                  Boolean
TotpEnrolled               Boolean
TotpUpdatedAt              Datetime
UsersTimeZone              String


```

This function will Set an AdministratorUser by Id Body. Id, and Body are required parameters.

### Example 2: Set an AdministratorUser by Id
```powershell
PS C:\> Set-JcSdkAdministratorUser -Id:(<string>) -ApiKeyAllowed:(<switch>) -Email:(<string>) -EnableMultiFactor:(<switch>) -Firstname:(<string>) -GrowthData:(<hashtable>) -LastWhatsNewChecked:(<datetime>) -Lastname:(<string>) -RoleName:(<string>)



----                       ----------
ApiKeyAllowed              Boolean
ApiKeySet                  Boolean
ApiKeyUpdatedAt            Datetime
Created                    Datetime
DisableIntroduction        Boolean
Email                      String
EnableMultiFactor          Boolean
Firstname                  String
GrowthDataExperimentStates JumpCloud.SDK.V1.Models.UserreturnGrowthDataExperimentStates
GrowthDataOnboardingState  JumpCloud.SDK.V1.Models.UserreturnGrowthDataOnboardingState
Id                         String
Lastname                   String
LastWhatsNewChecked        Datetime
Organization               String
PasswordUpdatedAt          Datetime
Provider                   String
Role                       String
RoleName                   String
SessionCount               Int
Suspended                  Boolean
TotpEnrolled               Boolean
TotpUpdatedAt              Datetime
UsersTimeZone              String


```

This function will Set an AdministratorUser by Id. Id is a required parameter.

