### Example 1: Set an Organization by Id, and Body
```powershell
PS C:\> Set-JcSdkOrganization -Id:(<string>) -Body:(<JumpCloud.SDK.V1.Models.Paths1Vyp8HsOrganizationsIdPutRequestbodyContentApplicationJsonSchema>)



----                             ----------
AccessRestriction                String
AccountsReceivable               String
Created                          String
DisplayName                      String
EntitlementBillingModel          String
EntitlementIsManuallyBilled      Boolean
EntitlementPricePerUserSum       Int
EntitlementProducts              JumpCloud.SDK.V1.Models.OrganizationentitlementEntitlementProductsItem[]
HasCreditCard                    Boolean
HasStripeCustomerId              Boolean
Id                               String
LastEstimateCalculationTimeStamp String
LastSfdcSyncStatus               JumpCloud.SDK.V1.Models.OrganizationLastSfdcSyncStatus
LogoUrl                          String
Provider                         String
Settings                         JumpCloud.SDK.V1.Models.Organizationsettings
TotalBillingEstimate             Int


```

This function will Set an Organization by Id Body. Id, and Body are required parameters.

### Example 2: Set an Organization by Id
```powershell
PS C:\> Set-JcSdkOrganization -Id:(<string>) -Settings:(<JumpCloud.SDK.V1.Models.Organizationsettingsput>)



----                             ----------
AccessRestriction                String
AccountsReceivable               String
Created                          String
DisplayName                      String
EntitlementBillingModel          String
EntitlementIsManuallyBilled      Boolean
EntitlementPricePerUserSum       Int
EntitlementProducts              JumpCloud.SDK.V1.Models.OrganizationentitlementEntitlementProductsItem[]
HasCreditCard                    Boolean
HasStripeCustomerId              Boolean
Id                               String
LastEstimateCalculationTimeStamp String
LastSfdcSyncStatus               JumpCloud.SDK.V1.Models.OrganizationLastSfdcSyncStatus
LogoUrl                          String
Provider                         String
Settings                         JumpCloud.SDK.V1.Models.Organizationsettings
TotalBillingEstimate             Int


```

This function will Set an Organization by Id. Id is a required parameter.

