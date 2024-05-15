### Example 1: Create a ProviderAdministrator by ProviderId, and Email
```powershell
PS C:\> New-JcSdkProviderAdministrator -ProviderId:(<string>) -Email:(<string>) -ApiKeyAllowed:(<switch>) -BindNoOrgs:(<switch>) -EnableMultiFactor:(<switch>) -Firstname:(<string>) -Lastname:(<string>) -Role:(<string>) -RoleName:(<string>)



----                    ----------
ApiKeyAllowed           Boolean
ApiKeySet               Boolean
Email                   String
EnableMultiFactor       Boolean
Firstname               String
Id                      String
Lastname                String
OrganizationAccessTotal System.Nullable[float] OrganizationAccessTotal {get;set;}
Registered              Boolean
Role                    String
RoleName                String
Suspended               Boolean


```

This function will Create a ProviderAdministrator by ProviderId Email. ProviderId, and Email are required parameters.

### Example 2: Create a ProviderAdministrator by ProviderId, and Body
```powershell
PS C:\> New-JcSdkProviderAdministrator -ProviderId:(<string>) -Body:(<JumpCloud.SDK.V2.Models.ProviderAdminReq>)



----                    ----------
ApiKeyAllowed           Boolean
ApiKeySet               Boolean
Email                   String
EnableMultiFactor       Boolean
Firstname               String
Id                      String
Lastname                String
OrganizationAccessTotal System.Nullable[float] OrganizationAccessTotal {get;set;}
Registered              Boolean
Role                    String
RoleName                String
Suspended               Boolean


```

This function will Create a ProviderAdministrator by ProviderId Body. ProviderId, and Body are required parameters.

