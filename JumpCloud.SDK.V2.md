## JumpCloud.SDK.V2-0.0.49
Release Date: March 05, 2025
#### RELEASE NOTES
```
Updated existing functions based on updated swagger specs
```

#### IMPROVEMENTS:
Updated existing functions based on updated swagger specs
#### Generated Changes:

<details>
<summary>Functions Added</summary>

No changes
</details>

<details>
<summary>Functions Modified</summary>

No changes
</details>

<details>
<summary>Functions Removed</summary>

No changes
</details>

## JumpCloud.SDK.V2-0.0.48
Release Date: June 17, 2024
#### RELEASE NOTES
```
This release includes an update to functions that return formatted json data.
```

#### BUG FIXES:
Functions that return formatted json data will now validate that the response is non-null before attempting to convert the response from Json. This resulted in an error for null responses in previous versions of the module.
#### Generated Changes:

<details>
<summary>Functions Added</summary>

No changes
</details>

<details>
<summary>Functions Modified</summary>

No changes
</details>

<details>
<summary>Functions Removed</summary>

No changes
</details>

## JumpCloud.SDK.V2-0.0.47
Release Date: June 06, 2024
#### RELEASE NOTES
```
This is a rollup release of the DirectoryInsights Module, no functional changes have been made
```
#### FEATURES:
NA
#### IMPROVEMENTS:
NA
#### BUG FIXES:
NA
#### Generated Changes:

<details>
<summary>Functions Added</summary>

No changes
</details>

<details>
<summary>Functions Modified</summary>

No changes
</details>

<details>
<summary>Functions Removed</summary>

No changes
</details>

## JumpCloud.SDK.V2-0.0.46
Release Date: May 15, 2024
#### RELEASE NOTES
```
This release fixes the input models for the Update-JcSdkBulkUser and New-JcSdkBulkUser functions
```
#### FEATURES:
NA
#### IMPROVEMENTS:
NA
#### BUG FIXES:
Fixes the issue of not being able to set all SystemUser attributes via the Update-JcSdkBulkUser and New-JcSdkBulkUser functions
#### Generated Changes:

<details>
<summary>Functions Added</summary>

No changes
</details>

<details>
<summary>Functions Modified</summary>

No changes
</details>

<details>
<summary>Functions Removed</summary>

No changes
</details>

## JumpCloud.SDK.V2-0.0.45
Release Date: April 15, 2024
#### RELEASE NOTES
```
This is a rollup release for the V2 module, no functional changes were made.
```
#### FEATURES:
NA
#### IMPROVEMENTS:
NA
#### BUG FIXES:
NA
#### Generated Changes:

<details>
<summary>Functions Added</summary>

No changes
</details>

<details>
<summary>Functions Modified</summary>

No changes
</details>

<details>
<summary>Functions Removed</summary>

No changes
</details>

## JumpCloud.SDK.V2-0.0.44
Release Date: March 27, 2024
#### RELEASE NOTES
```
This is a rollup release for the V2 module, no functional changes were made
```
#### FEATURES:
NA
#### IMPROVEMENTS:
NA
#### BUG FIXES:
NA
#### Generated Changes:

<details>
<summary>Functions Added</summary>

No changes
</details>

<details>
<summary>Functions Modified</summary>

No changes
</details>

<details>
<summary>Functions Removed</summary>

No changes
</details>

## JumpCloud.SDK.V2-0.0.43
Release Date: February 27, 2024
#### RELEASE NOTES
```
Added retry functionality for functions if a 503 error is experienced
```
#### FEATURES:
NA
#### IMPROVEMENTS:
Added retry functionality for functions if a 503 error is experienced
#### BUG FIXES:
NA
#### Generated Changes:

<details>
<summary>Functions Added</summary>

No changes
</details>

<details>
<summary>Functions Modified</summary>

* Clear-JcSdkAppleMdmDevice.ps1
* Clear-JcSdkAppleMdmDeviceActivationLock.ps1
* Get-JcSdkActiveDirectory.ps1
* Get-JcSdkActiveDirectoryAgent.ps1
* Get-JcSdkActiveDirectoryAssociation.ps1
* Get-JcSdkActiveDirectoryTraverseUser.ps1
* Get-JcSdkActiveDirectoryTraverseUserGroup.ps1
* Get-JcSdkAdministratorOrganization.ps1
* Get-JcSdkAdministratorOrganizationLink.ps1
* Get-JcSdkAppleMdm.ps1
* Get-JcSdkAppleMdmDevice.ps1
* Get-JcSdkAppleMdmEnrollmentProfile.ps1
* Get-JcSdkApplicationAssociation.ps1
* Get-JcSdkApplicationTraverseUser.ps1
* Get-JcSdkApplicationTraverseUserGroup.ps1
* Get-JcSdkAuthenticationPolicy.ps1
* Get-JcSdkBulkUserState.ps1
* Get-JcSdkBulkUsersResult.ps1
* Get-JcSdkCommandAssociation.ps1
* Get-JcSdkCommandTraverseSystem.ps1
* Get-JcSdkCommandTraverseSystemGroup.ps1
* Get-JcSdkCustomEmailConfiguration.ps1
* Get-JcSdkCustomEmailTemplate.ps1
* Get-JcSdkDirectory.ps1
* Get-JcSdkDuoAccount.ps1
* Get-JcSdkDuoApplication.ps1
* Get-JcSdkGSuite.ps1
* Get-JcSdkGSuiteAssociation.ps1
* Get-JcSdkGSuiteTranslationRule.ps1
* Get-JcSdkGSuiteTraverseUser.ps1
* Get-JcSdkGSuiteTraverseUserGroup.ps1
* Get-JcSdkGSuiteUsersToImport.ps1
* Get-JcSdkGroup.ps1
* Get-JcSdkGsuiteUsersToImportFormatted.ps1
* Get-JcSdkIPList.ps1
* Get-JcSdkLdapServer.ps1
* Get-JcSdkLdapServerAssociation.ps1
* Get-JcSdkLdapServerSambaDomain.ps1
* Get-JcSdkLdapServerTraverseUser.ps1
* Get-JcSdkLdapServerTraverseUserGroup.ps1
* Get-JcSdkNextScheduledBulkUserState.ps1
* Get-JcSdkOffice365.ps1
* Get-JcSdkOffice365Association.ps1
* Get-JcSdkOffice365TranslationRule.ps1
* Get-JcSdkOffice365TraverseUser.ps1
* Get-JcSdkOffice365TraverseUserGroup.ps1
* Get-JcSdkOffice365UsersToImport.ps1
* Get-JcSdkOrganizationPolicyResult.ps1
* Get-JcSdkPolicy.ps1
* Get-JcSdkPolicyAssociation.ps1
* Get-JcSdkPolicyGroup.ps1
* Get-JcSdkPolicyGroupAssociation.ps1
* Get-JcSdkPolicyGroupMember.ps1
* Get-JcSdkPolicyGroupMembership.ps1
* Get-JcSdkPolicyGroupTraverseSystem.ps1
* Get-JcSdkPolicyGroupTraverseSystemGroup.ps1
* Get-JcSdkPolicyResult.ps1
* Get-JcSdkPolicyStatus.ps1
* Get-JcSdkPolicyTemplate.ps1
* Get-JcSdkPolicyTraverseSystem.ps1
* Get-JcSdkPolicyTraverseSystemGroup.ps1
* Get-JcSdkProviderAdministrator.ps1
* Get-JcSdkProviderOrganization.ps1
* Get-JcSdkProvidersInvoice.ps1
* Get-JcSdkRadiusServerAssociation.ps1
* Get-JcSdkRadiusServerTraverseUser.ps1
* Get-JcSdkRadiusServerTraverseUserGroup.ps1
* Get-JcSdkSoftwareApp.ps1
* Get-JcSdkSoftwareAppAssociation.ps1
* Get-JcSdkSoftwareAppStatus.ps1
* Get-JcSdkSoftwareAppTraverseSystem.ps1
* Get-JcSdkSoftwareAppTraverseSystemGroup.ps1
* Get-JcSdkSubscription.ps1
* Get-JcSdkSystemAssociation.ps1
* Get-JcSdkSystemFdeKey.ps1
* Get-JcSdkSystemGroup.ps1
* Get-JcSdkSystemGroupAssociation.ps1
* Get-JcSdkSystemGroupMember.ps1
* Get-JcSdkSystemGroupMembership.ps1
* Get-JcSdkSystemGroupTraverseCommand.ps1
* Get-JcSdkSystemGroupTraversePolicy.ps1
* Get-JcSdkSystemGroupTraversePolicyGroup.ps1
* Get-JcSdkSystemGroupTraverseUser.ps1
* Get-JcSdkSystemGroupTraverseUserGroup.ps1
* Get-JcSdkSystemInsightAlf.ps1
* Get-JcSdkSystemInsightAlfException.ps1
* Get-JcSdkSystemInsightAlfExplicitAuth.ps1
* Get-JcSdkSystemInsightApp.ps1
* Get-JcSdkSystemInsightAppCompatShim.ps1
* Get-JcSdkSystemInsightAuthorizedKey.ps1
* Get-JcSdkSystemInsightAzureInstanceMetadata.ps1
* Get-JcSdkSystemInsightAzureInstanceTag.ps1
* Get-JcSdkSystemInsightBattery.ps1
* Get-JcSdkSystemInsightBitlockerInfo.ps1
* Get-JcSdkSystemInsightBrowserPlugin.ps1
* Get-JcSdkSystemInsightCertificate.ps1
* Get-JcSdkSystemInsightChassisInfo.ps1
* Get-JcSdkSystemInsightChromeExtension.ps1
* Get-JcSdkSystemInsightConnectivity.ps1
* Get-JcSdkSystemInsightCrash.ps1
* Get-JcSdkSystemInsightCupDestination.ps1
* Get-JcSdkSystemInsightDiskEncryption.ps1
* Get-JcSdkSystemInsightDiskInfo.ps1
* Get-JcSdkSystemInsightDnsResolver.ps1
* Get-JcSdkSystemInsightEtcHost.ps1
* Get-JcSdkSystemInsightFirefoxAddon.ps1
* Get-JcSdkSystemInsightGroup.ps1
* Get-JcSdkSystemInsightIeExtension.ps1
* Get-JcSdkSystemInsightInterfaceAddress.ps1
* Get-JcSdkSystemInsightInterfaceDetail.ps1
* Get-JcSdkSystemInsightKernelInfo.ps1
* Get-JcSdkSystemInsightLaunchd.ps1
* Get-JcSdkSystemInsightLinuxPackage.ps1
* Get-JcSdkSystemInsightLoggedinUser.ps1
* Get-JcSdkSystemInsightLogicalDrive.ps1
* Get-JcSdkSystemInsightManagedPolicy.ps1
* Get-JcSdkSystemInsightMount.ps1
* Get-JcSdkSystemInsightOSVersion.ps1
* Get-JcSdkSystemInsightPatch.ps1
* Get-JcSdkSystemInsightProgram.ps1
* Get-JcSdkSystemInsightPythonPackage.ps1
* Get-JcSdkSystemInsightSafariExtension.ps1
* Get-JcSdkSystemInsightScheduledTask.ps1
* Get-JcSdkSystemInsightSecureboot.ps1
* Get-JcSdkSystemInsightService.ps1
* Get-JcSdkSystemInsightShadow.ps1
* Get-JcSdkSystemInsightSharedFolder.ps1
* Get-JcSdkSystemInsightSharedResource.ps1
* Get-JcSdkSystemInsightSharingPreference.ps1
* Get-JcSdkSystemInsightSipConfig.ps1
* Get-JcSdkSystemInsightStartupItem.ps1
* Get-JcSdkSystemInsightSystemControl.ps1
* Get-JcSdkSystemInsightSystemInfo.ps1
* Get-JcSdkSystemInsightTpmInfo.ps1
* Get-JcSdkSystemInsightUptime.ps1
* Get-JcSdkSystemInsightUsbDevice.ps1
* Get-JcSdkSystemInsightUser.ps1
* Get-JcSdkSystemInsightUserAssist.ps1
* Get-JcSdkSystemInsightUserGroup.ps1
* Get-JcSdkSystemInsightUserSshKey.ps1
* Get-JcSdkSystemInsightWifiNetwork.ps1
* Get-JcSdkSystemInsightWifiStatus.ps1
* Get-JcSdkSystemInsightWindowsSecurityCenter.ps1
* Get-JcSdkSystemInsightWindowsSecurityProduct.ps1
* Get-JcSdkSystemMember.ps1
* Get-JcSdkSystemPolicyStatus.ps1
* Get-JcSdkSystemTraverseCommand.ps1
* Get-JcSdkSystemTraversePolicy.ps1
* Get-JcSdkSystemTraversePolicyGroup.ps1
* Get-JcSdkSystemTraverseUser.ps1
* Get-JcSdkSystemTraverseUserGroup.ps1
* Get-JcSdkUserAssociation.ps1
* Get-JcSdkUserGroup.ps1
* Get-JcSdkUserGroupAssociation.ps1
* Get-JcSdkUserGroupMember.ps1
* Get-JcSdkUserGroupMembership.ps1
* Get-JcSdkUserGroupTraverseActiveDirectory.ps1
* Get-JcSdkUserGroupTraverseApplication.ps1
* Get-JcSdkUserGroupTraverseDirectory.ps1
* Get-JcSdkUserGroupTraverseGSuite.ps1
* Get-JcSdkUserGroupTraverseLdapServer.ps1
* Get-JcSdkUserGroupTraverseOffice365.ps1
* Get-JcSdkUserGroupTraverseRadiusServer.ps1
* Get-JcSdkUserGroupTraverseSystem.ps1
* Get-JcSdkUserGroupTraverseSystemGroup.ps1
* Get-JcSdkUserMember.ps1
* Get-JcSdkUserPushEndpoint.ps1
* Get-JcSdkUserTraverseActiveDirectory.ps1
* Get-JcSdkUserTraverseApplication.ps1
* Get-JcSdkUserTraverseDirectory.ps1
* Get-JcSdkUserTraverseGSuite.ps1
* Get-JcSdkUserTraverseLdapServer.ps1
* Get-JcSdkUserTraverseOffice365.ps1
* Get-JcSdkUserTraverseRadiusServer.ps1
* Get-JcSdkUserTraverseSystem.ps1
* Get-JcSdkUserTraverseSystemGroup.ps1
* Get-JcSdkWorkday.ps1
* Get-JcSdkWorkdayWorker.ps1
* Grant-JcSdkWorkday.ps1
* Import-JcSdkScim.ps1
* Import-JcSdkWorkday.ps1
* Import-JcSdkWorkdayResult.ps1
* Invoke-JcSdkReclaimSoftwareAppLicense.ps1
* Lock-JcSdkAppleMdmDevice.ps1
* New-JcSdkActiveDirectory.ps1
* New-JcSdkActiveDirectoryAgent.ps1
* New-JcSdkAdministratorOrganization.ps1
* New-JcSdkAuthenticationPolicy.ps1
* New-JcSdkBulkUser.ps1
* New-JcSdkBulkUserState.ps1
* New-JcSdkCustomEmailConfiguration.ps1
* New-JcSdkDuoAccount.ps1
* New-JcSdkDuoApplication.ps1
* New-JcSdkGSuiteTranslationRule.ps1
* New-JcSdkIPList.ps1
* New-JcSdkLdapServerSambaDomain.ps1
* New-JcSdkOffice365TranslationRule.ps1
* New-JcSdkPolicy.ps1
* New-JcSdkPolicyGroup.ps1
* New-JcSdkProviderAdministrator.ps1
* New-JcSdkSoftwareApp.ps1
* New-JcSdkSystemGroup.ps1
* New-JcSdkUserGroup.ps1
* New-JcSdkWorkday.ps1
* Remove-JcSdkActiveDirectory.ps1
* Remove-JcSdkActiveDirectoryAgent.ps1
* Remove-JcSdkAdministratorOrganization.ps1
* Remove-JcSdkAppleMdm.ps1
* Remove-JcSdkAppleMdmDevice.ps1
* Remove-JcSdkApplicationLogo.ps1
* Remove-JcSdkAuthenticationPolicy.ps1
* Remove-JcSdkBulkUserState.ps1
* Remove-JcSdkCustomEmailConfiguration.ps1
* Remove-JcSdkDuoAccount.ps1
* Remove-JcSdkDuoApplication.ps1
* Remove-JcSdkGSuiteTranslationRule.ps1
* Remove-JcSdkIPList.ps1
* Remove-JcSdkLdapServerSambaDomain.ps1
* Remove-JcSdkOffice365TranslationRule.ps1
* Remove-JcSdkPolicy.ps1
* Remove-JcSdkPolicyGroup.ps1
* Remove-JcSdkProviderAdministrator.ps1
* Remove-JcSdkSoftwareApp.ps1
* Remove-JcSdkSystemGroup.ps1
* Remove-JcSdkUserGroup.ps1
* Remove-JcSdkUserPushEndpoint.ps1
* Remove-JcSdkWorkdayAuthorization.ps1
* Restart-JcSdkAppleMdmDevice.ps1
* Set-JcSdkActiveDirectoryAssociation.ps1
* Set-JcSdkAppleMdm.ps1
* Set-JcSdkApplicationAssociation.ps1
* Set-JcSdkCommandAssociation.ps1
* Set-JcSdkCustomEmailConfiguration.ps1
* Set-JcSdkDuoApplication.ps1
* Set-JcSdkGSuiteAssociation.ps1
* Set-JcSdkIPList.ps1
* Set-JcSdkLdapServerAssociation.ps1
* Set-JcSdkLdapServerSambaDomain.ps1
* Set-JcSdkOffice365Association.ps1
* Set-JcSdkPolicy.ps1
* Set-JcSdkPolicyAssociation.ps1
* Set-JcSdkPolicyGroup.ps1
* Set-JcSdkPolicyGroupAssociation.ps1
* Set-JcSdkPolicyGroupMember.ps1
* Set-JcSdkRadiusServerAssociation.ps1
* Set-JcSdkSoftwareApp.ps1
* Set-JcSdkSoftwareAppAssociation.ps1
* Set-JcSdkSystemAssociation.ps1
* Set-JcSdkSystemGroup.ps1
* Set-JcSdkSystemGroupAssociation.ps1
* Set-JcSdkSystemGroupMember.ps1
* Set-JcSdkUserAssociation.ps1
* Set-JcSdkUserGroup.ps1
* Set-JcSdkUserGroupAssociation.ps1
* Set-JcSdkUserGroupMember.ps1
* Set-JcSdkWorkday.ps1
* Stop-JcSdkAppleMdmDevice.ps1
* Sync-JcSdkAppleMdmDevice.ps1
* Update-JcSdkAppleMdmDeviceLockInformation.ps1
* Update-JcSdkAuthenticationPolicy.ps1
* Update-JcSdkBulkUser.ps1
* Update-JcSdkGSuite.ps1
* Update-JcSdkIPList.ps1
* Update-JcSdkLdapServer.ps1
* Update-JcSdkOffice365.ps1
* Update-JcSdkUserPushEndpoint.ps1

</details>

<details>
<summary>Functions Removed</summary>

No changes
</details>

## JumpCloud.SDK.V2-0.0.42
Release Date: February 07, 2024
#### RELEASE NOTES
```
This is a rollup release for the V2 module, no functional changes were made. Usage examples were added to the Set-JcSdkSystemAssociation and Set-JcSdkUserAssociation functions.
```
#### FEATURES:
NA
#### IMPROVEMENTS:
NA
#### BUG FIXES:
NA
#### Generated Changes:

<details>
<summary>Functions Added</summary>

No changes
</details>

<details>
<summary>Functions Modified</summary>

* New-JcSdkActiveDirectoryAgent.ps1
* New-JcSdkPolicy.ps1
* New-JcSdkSoftwareApp.ps1
* Set-JcSdkPolicy.ps1
* Set-JcSdkSoftwareApp.ps1
* Set-JcSdkSystemAssociation.ps1
* Set-JcSdkUserAssociation.ps1

</details>

<details>
<summary>Functions Removed</summary>

No changes
</details>

## JumpCloud.SDK.V2-0.0.41
Release Date: November 29, 2023
#### RELEASE NOTES
```
Unset a property of the office_365 functions which now allows admins to set the `UserLockoutAction` and `User PasswordExpirationAction` values
```
#### FEATURES:
NA
#### IMPROVEMENTS:
NA
#### BUG FIXES:
Addressed an issue in `Update-JcSdkOffice365` where the `UserLockoutAction` and `User PasswordExpirationAction` values could not be set
#### Generated Changes:

<details>
<summary>Functions Added</summary>

No changes
</details>

<details>
<summary>Functions Modified</summary>

No changes
</details>

<details>
<summary>Functions Removed</summary>

No changes
</details>

## JumpCloud.SDK.V2-0.0.40
Release Date: November 14, 2023
#### RELEASE NOTES
```
This is a rollup release for the DI module, no functional changes were made
```
#### FEATURES:
NA
#### IMPROVEMENTS:
NA
#### BUG FIXES:
NA
#### Generated Changes:

<details>
<summary>Functions Added</summary>

No changes
</details>

<details>
<summary>Functions Modified</summary>

* Get-JcSdkAppleMdm.ps1
* Get-JcSdkProvidersInvoice.ps1
* New-JcSdkProviderAdministrator.ps1
* New-JcSdkSoftwareApp.ps1
* New-JcSdkSystemGroup.ps1
* New-JcSdkUserGroup.ps1
* Set-JcSdkSoftwareApp.ps1
* Set-JcSdkSystemGroup.ps1
* Set-JcSdkUserGroup.ps1
* Update-JcSdkGSuite.ps1

</details>

<details>
<summary>Functions Removed</summary>

* Get-JcSdkGsuiteUsersToImportFormated.ps1

</details>

## JumpCloud.SDK.V2-0.0.39
Release Date: June 07, 2023
#### RELEASE NOTES
```
This is a rollup release for the V2 module, no functional changes were made
```
#### Generated Changes:

<details>
<summary>Functions Added</summary>

No changes
</details>

<details>
<summary>Functions Modified</summary>

* Get-JcSdkSystemGroupTraverseCommand.ps1
* Get-JcSdkSystemTraverseCommand.ps1
* New-JcSdkSystemGroup.ps1
* New-JcSdkUserGroup.ps1
* Set-JcSdkSystemGroup.ps1
* Set-JcSdkUserGroup.ps1
* Update-JcSdkBulkUser.ps1
* Update-JcSdkOffice365.ps1

</details>

<details>
<summary>Functions Removed</summary>

No changes
</details>

## JumpCloud.SDK.V2-0.0.38
Release Date: May 04, 2023
#### RELEASE NOTES
```
This release addresses a bugfix for both the `Get-JCSdkGSuiteUsersToImport` & `Get-JCSdkOffice365UsersToImport` functions. In addition several models have been updated with new functionatily from the public facing API.
```
#### BUG FIXES:
`Get-JCSdkGSuiteUsersToImport` & `Get-JCSdkOffice365UsersToImport` now support automatic pagination
#### Generated Changes:

<details>
<summary>Functions Added</summary>

No changes
</details>

<details>
<summary>Functions Modified</summary>

* Get-JcSdkGSuiteUsersToImport.ps1
* Get-JcSdkOffice365UsersToImport.ps1
* New-JcSdkPolicy.ps1
* New-JcSdkSystemGroup.ps1
* New-JcSdkUserGroup.ps1
* Set-JcSdkAppleMdm.ps1
* Set-JcSdkPolicy.ps1
* Set-JcSdkSystemGroup.ps1
* Set-JcSdkUserGroup.ps1

</details>

<details>
<summary>Functions Removed</summary>

No changes
</details>

## JumpCloud.SDK.V2-0.0.37
Release Date: March 13, 2023
#### RELEASE NOTES
```
This is a rollup release for the V2 module, no functional changes were made other than new parameters on several functions.
```
#### Generated Changes:

<details>
<summary>Functions Added</summary>

No changes
</details>

<details>
<summary>Functions Modified</summary>

* New-JcSdkCustomEmailConfiguration.ps1
* New-JcSdkSoftwareApp.ps1
* Set-JcSdkCustomEmailConfiguration.ps1
* Set-JcSdkSoftwareApp.ps1

</details>

<details>
<summary>Functions Removed</summary>

No changes
</details>

## JumpCloud.SDK.V2-0.0.36
Release Date: January 27, 2023
#### RELEASE NOTES
```
This release address an incompatability with the `-Filter` parameter on V2 endpoitns
```
#### BUG FIXES:
Multiple filter can now be passed into V2 endpoint functions. To use multiple filters on the V2 module, please refer to the individual function documentation. In general filter parameters will consist of an array of strings where filter strings are composed of the field, operator and value you wish to search for. Ex. `Get-JcSdkSystemInsightApp -Filter @("system_id:eq:61a90ffe7ef39016dc09ec5c", "bundle_name:eq:googleChrome")

#### Generated Changes:

<details>
<summary>Functions Added</summary>

No changes
</details>

<details>
<summary>Functions Modified</summary>

No changes
</details>

<details>
<summary>Functions Removed</summary>

No changes
</details>

## JumpCloud.SDK.V2-0.0.35
Release Date: December 28, 2022
#### RELEASE NOTES
```
This release is a rollup of SDK changes and adds several new system insights tables to the SDK module. See Functions Added for a full list of system insight functions added.
```
#### FEATURES:
Get-JcSdkAppleMdm — `ProxyUseDefaultCredentials` parameter added
Get-JcSdkBulkUserState — `Filter` parameter added
Get-JcSdkProviderAdministrator — `SortIgnoreCase` parameter added
Get-JcSdkProviderOrganization — `SortIgnoreCase` parameter added
New-JcSdkAuthenticationPolicy — `UserVerificationRequirement` parameter added
New-JcSdkBulkUserState — `ActivationEmailOverride` `SendActivationEmails` parameters added
New-JcSdkBulkUserState — `ActivationEmailOverride` `SendActivationEmails` parameters added
New-JcSdkUserGroup — `MemberQueryExemptions` `MembershipAutomated` parameters added
Restart-JcSdkAppleMdmDevice — `Body` `KextPaths` parameters added
Set-JcSdkAppleMdm — `AppleCertCreatorAppleId` parameter added
Set-JcSdkUserGroup — `MemberQueryExemptions` `MembershipAutomated` parameters added
Update-JcSdkAuthenticationPolicy — `UserVerificationRequirement` parameter added

#### BUG FIXES:
Fix for Set-JcSdkUserAssociation where removing a user/ system association would timeout

#### Generated Changes:

<details>
<summary>Functions Added</summary>

* Get-JcSdkSystemInsightAzureInstanceMetadata.ps1
* Get-JcSdkSystemInsightAzureInstanceTag.ps1
* Get-JcSdkSystemInsightChassisInfo.ps1
* Get-JcSdkSystemInsightLinuxPackage.ps1
* Get-JcSdkSystemInsightSecureboot.ps1
* Get-JcSdkSystemInsightTpmInfo.ps1
* Get-JcSdkSystemInsightUserAssist.ps1
* Get-JcSdkSystemInsightWindowsSecurityCenter.ps1

</details>

<details>
<summary>Functions Modified</summary>

* Clear-JcSdkAppleMdmDevice.ps1
* Clear-JcSdkAppleMdmDeviceActivationLock.ps1
* Get-JcSdkActiveDirectory.ps1
* Get-JcSdkActiveDirectoryAgent.ps1
* Get-JcSdkActiveDirectoryAssociation.ps1
* Get-JcSdkActiveDirectoryTraverseUser.ps1
* Get-JcSdkActiveDirectoryTraverseUserGroup.ps1
* Get-JcSdkAdministratorOrganization.ps1
* Get-JcSdkAdministratorOrganizationLink.ps1
* Get-JcSdkAppleMdm.ps1
* Get-JcSdkAppleMdmDevice.ps1
* Get-JcSdkAppleMdmEnrollmentProfile.ps1
* Get-JcSdkApplicationAssociation.ps1
* Get-JcSdkApplicationTraverseUser.ps1
* Get-JcSdkApplicationTraverseUserGroup.ps1
* Get-JcSdkAuthenticationPolicy.ps1
* Get-JcSdkBulkUserState.ps1
* Get-JcSdkBulkUsersResult.ps1
* Get-JcSdkCommandAssociation.ps1
* Get-JcSdkCommandTraverseSystem.ps1
* Get-JcSdkCommandTraverseSystemGroup.ps1
* Get-JcSdkCustomEmailConfiguration.ps1
* Get-JcSdkCustomEmailTemplate.ps1
* Get-JcSdkDirectory.ps1
* Get-JcSdkDuoAccount.ps1
* Get-JcSdkDuoApplication.ps1
* Get-JcSdkGSuite.ps1
* Get-JcSdkGSuiteAssociation.ps1
* Get-JcSdkGSuiteTranslationRule.ps1
* Get-JcSdkGSuiteTraverseUser.ps1
* Get-JcSdkGSuiteTraverseUserGroup.ps1
* Get-JcSdkGSuiteUsersToImport.ps1
* Get-JcSdkGroup.ps1
* Get-JcSdkGroupSuggestion.ps1
* Get-JcSdkGsuiteUsersToImportFormated.ps1
* Get-JcSdkIPList.ps1
* Get-JcSdkLdapServer.ps1
* Get-JcSdkLdapServerAssociation.ps1
* Get-JcSdkLdapServerSambaDomain.ps1
* Get-JcSdkLdapServerTraverseUser.ps1
* Get-JcSdkLdapServerTraverseUserGroup.ps1
* Get-JcSdkNextScheduledBulkUserState.ps1
* Get-JcSdkOffice365.ps1
* Get-JcSdkOffice365Association.ps1
* Get-JcSdkOffice365TranslationRule.ps1
* Get-JcSdkOffice365TraverseUser.ps1
* Get-JcSdkOffice365TraverseUserGroup.ps1
* Get-JcSdkOffice365UsersToImport.ps1
* Get-JcSdkOrganizationPolicyResult.ps1
* Get-JcSdkPolicy.ps1
* Get-JcSdkPolicyAssociation.ps1
* Get-JcSdkPolicyGroup.ps1
* Get-JcSdkPolicyGroupAssociation.ps1
* Get-JcSdkPolicyGroupMember.ps1
* Get-JcSdkPolicyGroupMembership.ps1
* Get-JcSdkPolicyGroupTraverseSystem.ps1
* Get-JcSdkPolicyGroupTraverseSystemGroup.ps1
* Get-JcSdkPolicyResult.ps1
* Get-JcSdkPolicyStatus.ps1
* Get-JcSdkPolicyTemplate.ps1
* Get-JcSdkPolicyTraverseSystem.ps1
* Get-JcSdkPolicyTraverseSystemGroup.ps1
* Get-JcSdkProviderAdministrator.ps1
* Get-JcSdkProviderOrganization.ps1
* Get-JcSdkProvidersInvoice.ps1
* Get-JcSdkRadiusServerAssociation.ps1
* Get-JcSdkRadiusServerTraverseUser.ps1
* Get-JcSdkRadiusServerTraverseUserGroup.ps1
* Get-JcSdkSoftwareApp.ps1
* Get-JcSdkSoftwareAppAssociation.ps1
* Get-JcSdkSoftwareAppStatus.ps1
* Get-JcSdkSoftwareAppTraverseSystem.ps1
* Get-JcSdkSoftwareAppTraverseSystemGroup.ps1
* Get-JcSdkSubscription.ps1
* Get-JcSdkSystemAssociation.ps1
* Get-JcSdkSystemFdeKey.ps1
* Get-JcSdkSystemGroup.ps1
* Get-JcSdkSystemGroupAssociation.ps1
* Get-JcSdkSystemGroupMember.ps1
* Get-JcSdkSystemGroupMembership.ps1
* Get-JcSdkSystemGroupTraverseCommand.ps1
* Get-JcSdkSystemGroupTraversePolicy.ps1
* Get-JcSdkSystemGroupTraversePolicyGroup.ps1
* Get-JcSdkSystemGroupTraverseUser.ps1
* Get-JcSdkSystemGroupTraverseUserGroup.ps1
* Get-JcSdkSystemInsightAlf.ps1
* Get-JcSdkSystemInsightAlfException.ps1
* Get-JcSdkSystemInsightAlfExplicitAuth.ps1
* Get-JcSdkSystemInsightApp.ps1
* Get-JcSdkSystemInsightAppCompatShim.ps1
* Get-JcSdkSystemInsightAuthorizedKey.ps1
* Get-JcSdkSystemInsightBattery.ps1
* Get-JcSdkSystemInsightBitlockerInfo.ps1
* Get-JcSdkSystemInsightBrowserPlugin.ps1
* Get-JcSdkSystemInsightCertificate.ps1
* Get-JcSdkSystemInsightChromeExtension.ps1
* Get-JcSdkSystemInsightConnectivity.ps1
* Get-JcSdkSystemInsightCrash.ps1
* Get-JcSdkSystemInsightCupDestination.ps1
* Get-JcSdkSystemInsightDiskEncryption.ps1
* Get-JcSdkSystemInsightDiskInfo.ps1
* Get-JcSdkSystemInsightDnsResolver.ps1
* Get-JcSdkSystemInsightEtcHost.ps1
* Get-JcSdkSystemInsightFirefoxAddon.ps1
* Get-JcSdkSystemInsightGroup.ps1
* Get-JcSdkSystemInsightIeExtension.ps1
* Get-JcSdkSystemInsightInterfaceAddress.ps1
* Get-JcSdkSystemInsightInterfaceDetail.ps1
* Get-JcSdkSystemInsightKernelInfo.ps1
* Get-JcSdkSystemInsightLaunchd.ps1
* Get-JcSdkSystemInsightLoggedinUser.ps1
* Get-JcSdkSystemInsightLogicalDrive.ps1
* Get-JcSdkSystemInsightManagedPolicy.ps1
* Get-JcSdkSystemInsightMount.ps1
* Get-JcSdkSystemInsightOSVersion.ps1
* Get-JcSdkSystemInsightPatch.ps1
* Get-JcSdkSystemInsightProgram.ps1
* Get-JcSdkSystemInsightPythonPackage.ps1
* Get-JcSdkSystemInsightSafariExtension.ps1
* Get-JcSdkSystemInsightScheduledTask.ps1
* Get-JcSdkSystemInsightService.ps1
* Get-JcSdkSystemInsightShadow.ps1
* Get-JcSdkSystemInsightSharedFolder.ps1
* Get-JcSdkSystemInsightSharedResource.ps1
* Get-JcSdkSystemInsightSharingPreference.ps1
* Get-JcSdkSystemInsightSipConfig.ps1
* Get-JcSdkSystemInsightStartupItem.ps1
* Get-JcSdkSystemInsightSystemControl.ps1
* Get-JcSdkSystemInsightSystemInfo.ps1
* Get-JcSdkSystemInsightUptime.ps1
* Get-JcSdkSystemInsightUsbDevice.ps1
* Get-JcSdkSystemInsightUser.ps1
* Get-JcSdkSystemInsightUserGroup.ps1
* Get-JcSdkSystemInsightUserSshKey.ps1
* Get-JcSdkSystemInsightWifiNetwork.ps1
* Get-JcSdkSystemInsightWifiStatus.ps1
* Get-JcSdkSystemMember.ps1
* Get-JcSdkSystemPolicyStatus.ps1
* Get-JcSdkSystemTraverseCommand.ps1
* Get-JcSdkSystemTraversePolicy.ps1
* Get-JcSdkSystemTraversePolicyGroup.ps1
* Get-JcSdkSystemTraverseUser.ps1
* Get-JcSdkSystemTraverseUserGroup.ps1
* Get-JcSdkUserAssociation.ps1
* Get-JcSdkUserGroup.ps1
* Get-JcSdkUserGroupAssociation.ps1
* Get-JcSdkUserGroupMember.ps1
* Get-JcSdkUserGroupMembership.ps1
* Get-JcSdkUserGroupTraverseActiveDirectory.ps1
* Get-JcSdkUserGroupTraverseApplication.ps1
* Get-JcSdkUserGroupTraverseDirectory.ps1
* Get-JcSdkUserGroupTraverseGSuite.ps1
* Get-JcSdkUserGroupTraverseLdapServer.ps1
* Get-JcSdkUserGroupTraverseOffice365.ps1
* Get-JcSdkUserGroupTraverseRadiusServer.ps1
* Get-JcSdkUserGroupTraverseSystem.ps1
* Get-JcSdkUserGroupTraverseSystemGroup.ps1
* Get-JcSdkUserMember.ps1
* Get-JcSdkUserPushEndpoint.ps1
* Get-JcSdkUserTraverseActiveDirectory.ps1
* Get-JcSdkUserTraverseApplication.ps1
* Get-JcSdkUserTraverseDirectory.ps1
* Get-JcSdkUserTraverseGSuite.ps1
* Get-JcSdkUserTraverseLdapServer.ps1
* Get-JcSdkUserTraverseOffice365.ps1
* Get-JcSdkUserTraverseRadiusServer.ps1
* Get-JcSdkUserTraverseSystem.ps1
* Get-JcSdkUserTraverseSystemGroup.ps1
* Get-JcSdkWorkday.ps1
* Get-JcSdkWorkdayWorker.ps1
* Grant-JcSdkWorkday.ps1
* Import-JcSdkScim.ps1
* Import-JcSdkWorkday.ps1
* Import-JcSdkWorkdayResult.ps1
* Invoke-JcSdkReclaimSoftwareAppLicense.ps1
* Lock-JcSdkAppleMdmDevice.ps1
* New-JcSdkActiveDirectory.ps1
* New-JcSdkActiveDirectoryAgent.ps1
* New-JcSdkAdministratorOrganization.ps1
* New-JcSdkAuthenticationPolicy.ps1
* New-JcSdkBulkUser.ps1
* New-JcSdkBulkUserState.ps1
* New-JcSdkCustomEmailConfiguration.ps1
* New-JcSdkDuoAccount.ps1
* New-JcSdkDuoApplication.ps1
* New-JcSdkGSuiteTranslationRule.ps1
* New-JcSdkIPList.ps1
* New-JcSdkLdapServerSambaDomain.ps1
* New-JcSdkOffice365TranslationRule.ps1
* New-JcSdkPolicy.ps1
* New-JcSdkPolicyGroup.ps1
* New-JcSdkProviderAdministrator.ps1
* New-JcSdkSoftwareApp.ps1
* New-JcSdkSystemGroup.ps1
* New-JcSdkUserGroup.ps1
* New-JcSdkWorkday.ps1
* Remove-JcSdkActiveDirectory.ps1
* Remove-JcSdkActiveDirectoryAgent.ps1
* Remove-JcSdkAdministratorOrganization.ps1
* Remove-JcSdkAppleMdm.ps1
* Remove-JcSdkAppleMdmDevice.ps1
* Remove-JcSdkApplicationLogo.ps1
* Remove-JcSdkAuthenticationPolicy.ps1
* Remove-JcSdkBulkUserState.ps1
* Remove-JcSdkCustomEmailConfiguration.ps1
* Remove-JcSdkDuoAccount.ps1
* Remove-JcSdkDuoApplication.ps1
* Remove-JcSdkGSuiteTranslationRule.ps1
* Remove-JcSdkIPList.ps1
* Remove-JcSdkLdapServerSambaDomain.ps1
* Remove-JcSdkOffice365TranslationRule.ps1
* Remove-JcSdkPolicy.ps1
* Remove-JcSdkPolicyGroup.ps1
* Remove-JcSdkProviderAdministrator.ps1
* Remove-JcSdkSoftwareApp.ps1
* Remove-JcSdkSystemGroup.ps1
* Remove-JcSdkUserGroup.ps1
* Remove-JcSdkUserPushEndpoint.ps1
* Remove-JcSdkWorkdayAuthorization.ps1
* Restart-JcSdkAppleMdmDevice.ps1
* Set-JcSdkActiveDirectoryAssociation.ps1
* Set-JcSdkAppleMdm.ps1
* Set-JcSdkApplicationAssociation.ps1
* Set-JcSdkCommandAssociation.ps1
* Set-JcSdkCustomEmailConfiguration.ps1
* Set-JcSdkDuoApplication.ps1
* Set-JcSdkGSuiteAssociation.ps1
* Set-JcSdkIPList.ps1
* Set-JcSdkLdapServerAssociation.ps1
* Set-JcSdkLdapServerSambaDomain.ps1
* Set-JcSdkOffice365Association.ps1
* Set-JcSdkPolicy.ps1
* Set-JcSdkPolicyAssociation.ps1
* Set-JcSdkPolicyGroup.ps1
* Set-JcSdkPolicyGroupAssociation.ps1
* Set-JcSdkPolicyGroupMember.ps1
* Set-JcSdkRadiusServerAssociation.ps1
* Set-JcSdkSoftwareApp.ps1
* Set-JcSdkSoftwareAppAssociation.ps1
* Set-JcSdkSystemAssociation.ps1
* Set-JcSdkSystemGroup.ps1
* Set-JcSdkSystemGroupAssociation.ps1
* Set-JcSdkSystemGroupMember.ps1
* Set-JcSdkUserAssociation.ps1
* Set-JcSdkUserGroup.ps1
* Set-JcSdkUserGroupAssociation.ps1
* Set-JcSdkUserGroupMember.ps1
* Set-JcSdkWorkday.ps1
* Stop-JcSdkAppleMdmDevice.ps1
* Sync-JcSdkAppleMdmDevice.ps1
* Update-JcSdkAppleMdmDeviceLockInformation.ps1
* Update-JcSdkAuthenticationPolicy.ps1
* Update-JcSdkBulkUser.ps1
* Update-JcSdkGSuite.ps1
* Update-JcSdkIPList.ps1
* Update-JcSdkLdapServer.ps1
* Update-JcSdkOffice365.ps1
* Update-JcSdkUserPushEndpoint.ps1

</details>

<details>
<summary>Functions Removed</summary>

No changes
</details>

## JumpCloud.SDK.V2-0.0.34
Release Date: June 21, 2022
#### RELEASE NOTES
```
This release removes the V2 function Get-JCSdkApplication, a duplicate version of this function exists already in the V1 Module.
```
#### Generated Changes:

<details>
<summary>Functions Added</summary>

No changes
</details>

<details>
<summary>Functions Modified</summary>

* New-JcSdkUserGroup.ps1
* Remove-JcSdkActiveDirectory.ps1
* Set-JcSdkPolicy.ps1
* Set-JcSdkPolicyGroup.ps1
* Set-JcSdkUserGroup.ps1

</details>

<details>
<summary>Functions Removed</summary>

* Get-JcSdkApplication.ps1

</details>

## JumpCloud.SDK.V2-0.0.33
Release Date: May 31, 2022
#### RELEASE NOTES
```
This release includes several new functions for the V2 SDK, see "Generated Changes" for a complete list of functions added/modified.
```
#### BUG FIXES:

In previous versions of the SDK, the `Get-JcSdkGsuiteUsersToImport` function would not return the `nextPageToken` which was required to paginate to the next page of Google Workspace users, this release addressed the issue and the function should now return the page token.
#### Generated Changes:

<details>
<summary>Functions Added</summary>

* Get-JcSdkApplication.ps1
* Get-JcSdkGsuiteUsersToImportFormated.ps1
* Import-JcSdkScim.ps1

</details>

<details>
<summary>Functions Modified</summary>

* Get-JcSdkGSuiteUsersToImport.ps1
* Get-JcSdkSoftwareApp.ps1
* New-JcSdkBulkUser.ps1
* New-JcSdkBulkUserState.ps1
* New-JcSdkOffice365TranslationRule.ps1
* New-JcSdkSoftwareApp.ps1
* Set-JcSdkSoftwareApp.ps1

</details>

<details>
<summary>Functions Removed</summary>

No changes
</details>

## JumpCloud.SDK.V2-0.0.32
Release Date: May 02, 2022
#### RELEASE NOTES
```
This release includes several new functions to interact with MTP functions. Documentation and parameter updates.
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

* Clear-JcSdkAppleMdmDevice.ps1
* Clear-JcSdkAppleMdmDeviceActivationLock.ps1
* Get-JcSdkActiveDirectory.ps1
* Get-JcSdkActiveDirectoryAgent.ps1
* Get-JcSdkActiveDirectoryAssociation.ps1
* Get-JcSdkActiveDirectoryTraverseUser.ps1
* Get-JcSdkActiveDirectoryTraverseUserGroup.ps1
* Get-JcSdkAppleMdmDevice.ps1
* Get-JcSdkApplicationAssociation.ps1
* Get-JcSdkApplicationTraverseUser.ps1
* Get-JcSdkApplicationTraverseUserGroup.ps1
* Get-JcSdkAuthenticationPolicy.ps1
* Get-JcSdkBulkUserState.ps1
* Get-JcSdkBulkUsersResult.ps1
* Get-JcSdkCommandAssociation.ps1
* Get-JcSdkCommandTraverseSystem.ps1
* Get-JcSdkCommandTraverseSystemGroup.ps1
* Get-JcSdkCustomEmailConfiguration.ps1
* Get-JcSdkDuoAccount.ps1
* Get-JcSdkDuoApplication.ps1
* Get-JcSdkGSuite.ps1
* Get-JcSdkGSuiteAssociation.ps1
* Get-JcSdkGSuiteTranslationRule.ps1
* Get-JcSdkGSuiteTraverseUser.ps1
* Get-JcSdkGSuiteTraverseUserGroup.ps1
* Get-JcSdkGroupSuggestion.ps1
* Get-JcSdkIPList.ps1
* Get-JcSdkLdapServer.ps1
* Get-JcSdkLdapServerAssociation.ps1
* Get-JcSdkLdapServerSambaDomain.ps1
* Get-JcSdkLdapServerTraverseUser.ps1
* Get-JcSdkLdapServerTraverseUserGroup.ps1
* Get-JcSdkOffice365.ps1
* Get-JcSdkOffice365Association.ps1
* Get-JcSdkOffice365TranslationRule.ps1
* Get-JcSdkOffice365TraverseUser.ps1
* Get-JcSdkOffice365TraverseUserGroup.ps1
* Get-JcSdkPolicy.ps1
* Get-JcSdkPolicyAssociation.ps1
* Get-JcSdkPolicyGroup.ps1
* Get-JcSdkPolicyGroupMember.ps1
* Get-JcSdkPolicyGroupMembership.ps1
* Get-JcSdkPolicyGroupTraverseSystem.ps1
* Get-JcSdkPolicyGroupTraverseSystemGroup.ps1
* Get-JcSdkPolicyResult.ps1
* Get-JcSdkPolicyTemplate.ps1
* Get-JcSdkPolicyTraverseSystem.ps1
* Get-JcSdkPolicyTraverseSystemGroup.ps1
* Get-JcSdkRadiusServerAssociation.ps1
* Get-JcSdkRadiusServerTraverseUser.ps1
* Get-JcSdkRadiusServerTraverseUserGroup.ps1
* Get-JcSdkSoftwareApp.ps1
* Get-JcSdkSoftwareAppAssociation.ps1
* Get-JcSdkSoftwareAppStatus.ps1
* Get-JcSdkSoftwareAppTraverseSystem.ps1
* Get-JcSdkSoftwareAppTraverseSystemGroup.ps1
* Get-JcSdkSystemAssociation.ps1
* Get-JcSdkSystemFdeKey.ps1
* Get-JcSdkSystemGroup.ps1
* Get-JcSdkSystemGroupAssociation.ps1
* Get-JcSdkSystemGroupMember.ps1
* Get-JcSdkSystemGroupMembership.ps1
* Get-JcSdkSystemGroupTraverseCommand.ps1
* Get-JcSdkSystemGroupTraversePolicy.ps1
* Get-JcSdkSystemGroupTraversePolicyGroup.ps1
* Get-JcSdkSystemGroupTraverseUser.ps1
* Get-JcSdkSystemGroupTraverseUserGroup.ps1
* Get-JcSdkSystemInsightApp.ps1
* Get-JcSdkSystemInsightProgram.ps1
* Get-JcSdkSystemMember.ps1
* Get-JcSdkSystemTraverseCommand.ps1
* Get-JcSdkSystemTraversePolicy.ps1
* Get-JcSdkSystemTraversePolicyGroup.ps1
* Get-JcSdkSystemTraverseUser.ps1
* Get-JcSdkSystemTraverseUserGroup.ps1
* Get-JcSdkUserAssociation.ps1
* Get-JcSdkUserGroup.ps1
* Get-JcSdkUserGroupAssociation.ps1
* Get-JcSdkUserGroupMember.ps1
* Get-JcSdkUserGroupMembership.ps1
* Get-JcSdkUserGroupTraverseActiveDirectory.ps1
* Get-JcSdkUserGroupTraverseApplication.ps1
* Get-JcSdkUserGroupTraverseDirectory.ps1
* Get-JcSdkUserGroupTraverseGSuite.ps1
* Get-JcSdkUserGroupTraverseLdapServer.ps1
* Get-JcSdkUserGroupTraverseOffice365.ps1
* Get-JcSdkUserGroupTraverseRadiusServer.ps1
* Get-JcSdkUserGroupTraverseSystem.ps1
* Get-JcSdkUserGroupTraverseSystemGroup.ps1
* Get-JcSdkUserMember.ps1
* Get-JcSdkUserPushEndpoint.ps1
* Get-JcSdkUserTraverseActiveDirectory.ps1
* Get-JcSdkUserTraverseApplication.ps1
* Get-JcSdkUserTraverseDirectory.ps1
* Get-JcSdkUserTraverseGSuite.ps1
* Get-JcSdkUserTraverseLdapServer.ps1
* Get-JcSdkUserTraverseOffice365.ps1
* Get-JcSdkUserTraverseRadiusServer.ps1
* Get-JcSdkUserTraverseSystem.ps1
* Get-JcSdkUserTraverseSystemGroup.ps1
* Get-JcSdkWorkday.ps1
* Get-JcSdkWorkdayWorker.ps1
* Grant-JcSdkWorkday.ps1
* Import-JcSdkWorkday.ps1
* Import-JcSdkWorkdayResult.ps1
* Invoke-JcSdkReclaimSoftwareAppLicense.ps1
* Lock-JcSdkAppleMdmDevice.ps1
* New-JcSdkActiveDirectoryAgent.ps1
* New-JcSdkBulkUser.ps1
* New-JcSdkDuoApplication.ps1
* New-JcSdkGSuiteTranslationRule.ps1
* New-JcSdkLdapServerSambaDomain.ps1
* New-JcSdkOffice365TranslationRule.ps1
* New-JcSdkSoftwareApp.ps1
* Remove-JcSdkActiveDirectory.ps1
* Remove-JcSdkActiveDirectoryAgent.ps1
* Remove-JcSdkAppleMdm.ps1
* Remove-JcSdkAppleMdmDevice.ps1
* Remove-JcSdkApplicationLogo.ps1
* Remove-JcSdkAuthenticationPolicy.ps1
* Remove-JcSdkBulkUserState.ps1
* Remove-JcSdkCustomEmailConfiguration.ps1
* Remove-JcSdkDuoAccount.ps1
* Remove-JcSdkDuoApplication.ps1
* Remove-JcSdkGSuiteTranslationRule.ps1
* Remove-JcSdkIPList.ps1
* Remove-JcSdkLdapServerSambaDomain.ps1
* Remove-JcSdkOffice365TranslationRule.ps1
* Remove-JcSdkPolicy.ps1
* Remove-JcSdkPolicyGroup.ps1
* Remove-JcSdkSoftwareApp.ps1
* Remove-JcSdkSystemGroup.ps1
* Remove-JcSdkUserGroup.ps1
* Remove-JcSdkUserPushEndpoint.ps1
* Remove-JcSdkWorkdayAuthorization.ps1
* Restart-JcSdkAppleMdmDevice.ps1
* Set-JcSdkActiveDirectoryAssociation.ps1
* Set-JcSdkAppleMdm.ps1
* Set-JcSdkApplicationAssociation.ps1
* Set-JcSdkCommandAssociation.ps1
* Set-JcSdkCustomEmailConfiguration.ps1
* Set-JcSdkDuoApplication.ps1
* Set-JcSdkGSuiteAssociation.ps1
* Set-JcSdkIPList.ps1
* Set-JcSdkLdapServerAssociation.ps1
* Set-JcSdkLdapServerSambaDomain.ps1
* Set-JcSdkOffice365Association.ps1
* Set-JcSdkPolicy.ps1
* Set-JcSdkPolicyAssociation.ps1
* Set-JcSdkPolicyGroup.ps1
* Set-JcSdkPolicyGroupAssociation.ps1
* Set-JcSdkPolicyGroupMember.ps1
* Set-JcSdkRadiusServerAssociation.ps1
* Set-JcSdkSoftwareApp.ps1
* Set-JcSdkSoftwareAppAssociation.ps1
* Set-JcSdkSystemAssociation.ps1
* Set-JcSdkSystemGroup.ps1
* Set-JcSdkSystemGroupAssociation.ps1
* Set-JcSdkSystemGroupMember.ps1
* Set-JcSdkUserAssociation.ps1
* Set-JcSdkUserGroup.ps1
* Set-JcSdkUserGroupAssociation.ps1
* Set-JcSdkUserGroupMember.ps1
* Set-JcSdkWorkday.ps1
* Stop-JcSdkAppleMdmDevice.ps1
* Sync-JcSdkAppleMdmDevice.ps1
* Update-JcSdkAppleMdmDeviceLockInformation.ps1
* Update-JcSdkAuthenticationPolicy.ps1
* Update-JcSdkBulkUser.ps1
* Update-JcSdkGSuite.ps1
* Update-JcSdkIPList.ps1
* Update-JcSdkLdapServer.ps1
* Update-JcSdkOffice365.ps1
* Update-JcSdkUserPushEndpoint.ps1

</details>

<details>
<summary>Functions Removed</summary>

No changes
</details>

## JumpCloud.SDK.V2-0.0.31
Release Date: Feb 16, 2022
#### RELEASE NOTES
```
Rollup of missing SDK functions
```
#### Generated Changes:

<details>
<summary>Functions Added</summary>

* Clear-JcSdkAppleMdmDeviceActivationLock.ps1
* Get-JcSdkActiveDirectoryAgent.ps1
* Get-JcSdkActiveDirectoryTraverseUser.ps1
* Get-JcSdkBulkUserState.ps1
* Get-JcSdkGroupSuggestion.ps1
* Get-JcSdkNextScheduledBulkUserState.ps1
* Get-JcSdkPolicyGroup.ps1
* Get-JcSdkPolicyGroupAssociation.ps1
* Get-JcSdkPolicyGroupMember.ps1
* Get-JcSdkPolicyGroupMembership.ps1
* Get-JcSdkPolicyGroupTraverseSystem.ps1
* Get-JcSdkPolicyGroupTraverseSystemGroup.ps1
* Get-JcSdkSystemGroupTraversePolicyGroup.ps1
* Get-JcSdkSystemTraversePolicyGroup.ps1
* Get-JcSdkUserGroupTraverseActiveDirectory.ps1
* Get-JcSdkUserTraverseActiveDirectory.ps1
* Invoke-JcSdkReclaimSoftwareAppLicense.ps1
* New-JcSdkActiveDirectory.ps1
* New-JcSdkBulkUserState.ps1
* New-JcSdkPolicyGroup.ps1
* Remove-JcSdkActiveDirectory.ps1
* Remove-JcSdkAppleMdmDevice.ps1
* Remove-JcSdkApplicationLogo.ps1
* Remove-JcSdkBulkUserState.ps1
* Remove-JcSdkPolicyGroup.ps1
* Remove-JcSdkUserPushEndpoint.ps1
* Set-JcSdkPolicyGroup.ps1
* Set-JcSdkPolicyGroupAssociation.ps1
* Set-JcSdkPolicyGroupMember.ps1
* Update-JcSdkAppleMdmDeviceLockInformation.ps1
* Update-JcSdkUserPushEndpoint.ps1

</details>

<details>
<summary>Functions Modified</summary>

* Clear-JcSdkAppleMdmDevice.ps1
* Get-JcSdkActiveDirectory.ps1
* Get-JcSdkActiveDirectoryAssociation.ps1
* Get-JcSdkActiveDirectoryTraverseUserGroup.ps1
* Get-JcSdkAppleMdmDevice.ps1
* Get-JcSdkAppleMdmEnrollmentProfile.ps1
* Get-JcSdkApplicationAssociation.ps1
* Get-JcSdkApplicationTraverseUser.ps1
* Get-JcSdkApplicationTraverseUserGroup.ps1
* Get-JcSdkAuthenticationPolicy.ps1
* Get-JcSdkCommandAssociation.ps1
* Get-JcSdkCommandTraverseSystem.ps1
* Get-JcSdkCommandTraverseSystemGroup.ps1
* Get-JcSdkCustomEmailConfiguration.ps1
* Get-JcSdkDirectory.ps1
* Get-JcSdkDuoAccount.ps1
* Get-JcSdkDuoApplication.ps1
* Get-JcSdkGSuite.ps1
* Get-JcSdkGSuiteAssociation.ps1
* Get-JcSdkGSuiteTranslationRule.ps1
* Get-JcSdkGSuiteTraverseUser.ps1
* Get-JcSdkGSuiteTraverseUserGroup.ps1
* Get-JcSdkGroup.ps1
* Get-JcSdkIPList.ps1
* Get-JcSdkLdapServer.ps1
* Get-JcSdkLdapServerAssociation.ps1
* Get-JcSdkLdapServerSambaDomain.ps1
* Get-JcSdkLdapServerTraverseUser.ps1
* Get-JcSdkLdapServerTraverseUserGroup.ps1
* Get-JcSdkOffice365.ps1
* Get-JcSdkOffice365Association.ps1
* Get-JcSdkOffice365TranslationRule.ps1
* Get-JcSdkOffice365TraverseUser.ps1
* Get-JcSdkOffice365TraverseUserGroup.ps1
* Get-JcSdkPolicy.ps1
* Get-JcSdkPolicyAssociation.ps1
* Get-JcSdkPolicyResult.ps1
* Get-JcSdkPolicyStatus.ps1
* Get-JcSdkPolicyTemplate.ps1
* Get-JcSdkPolicyTraverseSystem.ps1
* Get-JcSdkPolicyTraverseSystemGroup.ps1
* Get-JcSdkRadiusServerAssociation.ps1
* Get-JcSdkRadiusServerTraverseUser.ps1
* Get-JcSdkRadiusServerTraverseUserGroup.ps1
* Get-JcSdkSoftwareApp.ps1
* Get-JcSdkSoftwareAppAssociation.ps1
* Get-JcSdkSoftwareAppStatus.ps1
* Get-JcSdkSoftwareAppTraverseSystem.ps1
* Get-JcSdkSoftwareAppTraverseSystemGroup.ps1
* Get-JcSdkSystemAssociation.ps1
* Get-JcSdkSystemFdeKey.ps1
* Get-JcSdkSystemGroup.ps1
* Get-JcSdkSystemGroupAssociation.ps1
* Get-JcSdkSystemGroupMember.ps1
* Get-JcSdkSystemGroupMembership.ps1
* Get-JcSdkSystemGroupTraverseCommand.ps1
* Get-JcSdkSystemGroupTraversePolicy.ps1
* Get-JcSdkSystemGroupTraverseUser.ps1
* Get-JcSdkSystemGroupTraverseUserGroup.ps1
* Get-JcSdkSystemInsightAlf.ps1
* Get-JcSdkSystemInsightAlfException.ps1
* Get-JcSdkSystemInsightAlfExplicitAuth.ps1
* Get-JcSdkSystemInsightApp.ps1
* Get-JcSdkSystemInsightAppCompatShim.ps1
* Get-JcSdkSystemInsightAuthorizedKey.ps1
* Get-JcSdkSystemInsightBattery.ps1
* Get-JcSdkSystemInsightBitlockerInfo.ps1
* Get-JcSdkSystemInsightBrowserPlugin.ps1
* Get-JcSdkSystemInsightCertificate.ps1
* Get-JcSdkSystemInsightChromeExtension.ps1
* Get-JcSdkSystemInsightConnectivity.ps1
* Get-JcSdkSystemInsightCrash.ps1
* Get-JcSdkSystemInsightCupDestination.ps1
* Get-JcSdkSystemInsightDiskEncryption.ps1
* Get-JcSdkSystemInsightDiskInfo.ps1
* Get-JcSdkSystemInsightDnsResolver.ps1
* Get-JcSdkSystemInsightEtcHost.ps1
* Get-JcSdkSystemInsightFirefoxAddon.ps1
* Get-JcSdkSystemInsightGroup.ps1
* Get-JcSdkSystemInsightIeExtension.ps1
* Get-JcSdkSystemInsightInterfaceAddress.ps1
* Get-JcSdkSystemInsightInterfaceDetail.ps1
* Get-JcSdkSystemInsightKernelInfo.ps1
* Get-JcSdkSystemInsightLaunchd.ps1
* Get-JcSdkSystemInsightLoggedinUser.ps1
* Get-JcSdkSystemInsightLogicalDrive.ps1
* Get-JcSdkSystemInsightManagedPolicy.ps1
* Get-JcSdkSystemInsightMount.ps1
* Get-JcSdkSystemInsightOSVersion.ps1
* Get-JcSdkSystemInsightPatch.ps1
* Get-JcSdkSystemInsightProgram.ps1
* Get-JcSdkSystemInsightPythonPackage.ps1
* Get-JcSdkSystemInsightSafariExtension.ps1
* Get-JcSdkSystemInsightScheduledTask.ps1
* Get-JcSdkSystemInsightService.ps1
* Get-JcSdkSystemInsightShadow.ps1
* Get-JcSdkSystemInsightSharedFolder.ps1
* Get-JcSdkSystemInsightSharedResource.ps1
* Get-JcSdkSystemInsightSharingPreference.ps1
* Get-JcSdkSystemInsightSipConfig.ps1
* Get-JcSdkSystemInsightStartupItem.ps1
* Get-JcSdkSystemInsightSystemControl.ps1
* Get-JcSdkSystemInsightSystemInfo.ps1
* Get-JcSdkSystemInsightUptime.ps1
* Get-JcSdkSystemInsightUsbDevice.ps1
* Get-JcSdkSystemInsightUser.ps1
* Get-JcSdkSystemInsightUserGroup.ps1
* Get-JcSdkSystemInsightUserSshKey.ps1
* Get-JcSdkSystemInsightWifiNetwork.ps1
* Get-JcSdkSystemInsightWifiStatus.ps1
* Get-JcSdkSystemInsightWindowSecurityProduct.ps1
* Get-JcSdkSystemMember.ps1
* Get-JcSdkSystemPolicyStatus.ps1
* Get-JcSdkSystemTraverseCommand.ps1
* Get-JcSdkSystemTraversePolicy.ps1
* Get-JcSdkSystemTraverseUser.ps1
* Get-JcSdkSystemTraverseUserGroup.ps1
* Get-JcSdkUserAssociation.ps1
* Get-JcSdkUserGroup.ps1
* Get-JcSdkUserGroupAssociation.ps1
* Get-JcSdkUserGroupMember.ps1
* Get-JcSdkUserGroupMembership.ps1
* Get-JcSdkUserGroupTraverseApplication.ps1
* Get-JcSdkUserGroupTraverseDirectory.ps1
* Get-JcSdkUserGroupTraverseGSuite.ps1
* Get-JcSdkUserGroupTraverseLdapServer.ps1
* Get-JcSdkUserGroupTraverseOffice365.ps1
* Get-JcSdkUserGroupTraverseRadiusServer.ps1
* Get-JcSdkUserGroupTraverseSystem.ps1
* Get-JcSdkUserGroupTraverseSystemGroup.ps1
* Get-JcSdkUserMember.ps1
* Get-JcSdkUserTraverseApplication.ps1
* Get-JcSdkUserTraverseDirectory.ps1
* Get-JcSdkUserTraverseGSuite.ps1
* Get-JcSdkUserTraverseLdapServer.ps1
* Get-JcSdkUserTraverseOffice365.ps1
* Get-JcSdkUserTraverseRadiusServer.ps1
* Get-JcSdkUserTraverseSystem.ps1
* Get-JcSdkUserTraverseSystemGroup.ps1
* Get-JcSdkWorkday.ps1
* Get-JcSdkWorkdayWorker.ps1
* Grant-JcSdkWorkday.ps1
* Import-JcSdkWorkday.ps1
* Import-JcSdkWorkdayResult.ps1
* Lock-JcSdkAppleMdmDevice.ps1
* New-JcSdkAuthenticationPolicy.ps1
* New-JcSdkBulkUser.ps1
* New-JcSdkCustomEmailConfiguration.ps1
* New-JcSdkDuoApplication.ps1
* New-JcSdkGSuiteTranslationRule.ps1
* New-JcSdkIPList.ps1
* New-JcSdkLdapServerSambaDomain.ps1
* New-JcSdkOffice365TranslationRule.ps1
* New-JcSdkPolicy.ps1
* New-JcSdkSoftwareApp.ps1
* New-JcSdkUserGroup.ps1
* Remove-JcSdkAppleMdm.ps1
* Remove-JcSdkAuthenticationPolicy.ps1
* Remove-JcSdkCustomEmailConfiguration.ps1
* Remove-JcSdkDuoAccount.ps1
* Remove-JcSdkDuoApplication.ps1
* Remove-JcSdkGSuiteTranslationRule.ps1
* Remove-JcSdkIPList.ps1
* Remove-JcSdkLdapServerSambaDomain.ps1
* Remove-JcSdkOffice365TranslationRule.ps1
* Remove-JcSdkPolicy.ps1
* Remove-JcSdkSoftwareApp.ps1
* Remove-JcSdkSystemGroup.ps1
* Remove-JcSdkUserGroup.ps1
* Remove-JcSdkWorkdayAuthorization.ps1
* Restart-JcSdkAppleMdmDevice.ps1
* Set-JcSdkActiveDirectoryAssociation.ps1
* Set-JcSdkAppleMdm.ps1
* Set-JcSdkApplicationAssociation.ps1
* Set-JcSdkCommandAssociation.ps1
* Set-JcSdkCustomEmailConfiguration.ps1
* Set-JcSdkDuoApplication.ps1
* Set-JcSdkGSuiteAssociation.ps1
* Set-JcSdkIPList.ps1
* Set-JcSdkLdapServerAssociation.ps1
* Set-JcSdkLdapServerSambaDomain.ps1
* Set-JcSdkOffice365Association.ps1
* Set-JcSdkPolicy.ps1
* Set-JcSdkPolicyAssociation.ps1
* Set-JcSdkRadiusServerAssociation.ps1
* Set-JcSdkSoftwareApp.ps1
* Set-JcSdkSoftwareAppAssociation.ps1
* Set-JcSdkSystemAssociation.ps1
* Set-JcSdkSystemGroup.ps1
* Set-JcSdkSystemGroupAssociation.ps1
* Set-JcSdkSystemGroupMember.ps1
* Set-JcSdkUserAssociation.ps1
* Set-JcSdkUserGroup.ps1
* Set-JcSdkUserGroupAssociation.ps1
* Set-JcSdkUserGroupMember.ps1
* Set-JcSdkWorkday.ps1
* Stop-JcSdkAppleMdmDevice.ps1
* Sync-JcSdkAppleMdmDevice.ps1
* Update-JcSdkAuthenticationPolicy.ps1
* Update-JcSdkBulkUser.ps1
* Update-JcSdkGSuite.ps1
* Update-JcSdkIPList.ps1
* Update-JcSdkLdapServer.ps1
* Update-JcSdkOffice365.ps1

</details>

<details>
<summary>Functions Removed</summary>

No changes
</details>
