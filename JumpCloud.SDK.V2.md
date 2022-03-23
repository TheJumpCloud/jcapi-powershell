## JumpCloud.SDK.V2-0.0.32
Release Date: March 22, 2022
#### RELEASE NOTES
```
This release includes several new functions to interact with MTP functions
```
#### BUG FIXES:
SDK generated functions that can not accept the x-org-id header strip that header before calling that endpoint. Previously an error was thrown on each of these functions.
#### Generated Changes:

<details>
<summary>Functions Added</summary>

* Get-JcSdkAdministratorOrganization.ps1
* Get-JcSdkAdministratorOrganizationLink.ps1
* Get-JcSdkProviderAdministrator.ps1
* Get-JcSdkProviderOrganization.ps1
* Get-JcSdkProvidersInvoice.ps1
* New-JcSdkAdministratorOrganization.ps1
* New-JcSdkProviderAdministrator.ps1
* Remove-JcSdkAdministratorOrganization.ps1
* Remove-JcSdkProviderAdministrator.ps1

</details>

<details>
<summary>Functions Modified</summary>

* Get-JcSdkBulkUserState.ps1
* Get-JcSdkSystemInsightApp.ps1
* Get-JcSdkSystemInsightProgram.ps1
* New-JcSdkBulkUser.ps1
* Set-JcSdkAppleMdm.ps1
* Update-JcSdkBulkUser.ps1

</details>

<details>
<summary>Functions Removed</summary>

No changes
</details>

## JumpCloud.SDK.V2-0.0.31
