### Example 1: Create an AdministratorOrganization by Id
```powershell
PS C:\> New-JcSdkAdministratorOrganization -Id:(<string>) -Organization:(<string>)



----          ----------
Administrator String
Organization  String


```

This function will Create an AdministratorOrganization by Id. Id is a required parameter.

### Example 2: Create an AdministratorOrganization by Id, and Body
```powershell
PS C:\> New-JcSdkAdministratorOrganization -Id:(<string>) -Body:(<JumpCloud.SDK.V2.Models.AdministratorOrganizationLinkReq>)



----          ----------
Administrator String
Organization  String


```

This function will Create an AdministratorOrganization by Id Body. Id, and Body are required parameters.

