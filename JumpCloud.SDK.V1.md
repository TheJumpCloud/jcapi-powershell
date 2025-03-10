## JumpCloud.SDK.V1-0.0.45
Release Date: March 06, 2025
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

* Get-JcSdkApplication.ps1
* Get-JcSdkApplicationTemplate.ps1
* Get-JcSdkCommand.ps1
* Get-JcSdkCommandResult.ps1
* Get-JcSdkOrganization.ps1
* Get-JcSdkRadiusServer.ps1
* Get-JcSdkSystem.ps1
* Get-JcSdkUser.ps1
* New-JcSdkRadiusServer.ps1
* Set-JcSdkOrganization.ps1
* Set-JcSdkRadiusServer.ps1

</details>

<details>
<summary>Functions Removed</summary>

No changes
</details>

## JumpCloud.SDK.V1-0.0.44
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

## JumpCloud.SDK.V1-0.0.43
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

## JumpCloud.SDK.V1-0.0.42
Release Date: May 15, 2024
#### RELEASE NOTES
```
This is a rollup release of the V1 Module, no functional changes have been made
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

## JumpCloud.SDK.V1-0.0.41
Release Date: April 15, 2024
#### RELEASE NOTES
```
This is a rollup release for the V1 module, a few changes were made to the systemUser model to return additional parameters.
```
#### FEATURES:
Restricted Fields can be set with Set/New-JcSdkUser
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

## JumpCloud.SDK.V1-0.0.40
Release Date: March 27, 2024
#### RELEASE NOTES
```
This is a rollup release for the V1 module, a few changes were made to the Application model to return additional parameters.
```
#### FEATURES:
Additional parameters were added to the Application model
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

## JumpCloud.SDK.V1-0.0.39
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

* Clear-JcSdkSystem.ps1
* Get-JcSdkApplication.ps1
* Get-JcSdkApplicationTemplate.ps1
* Get-JcSdkCommand.ps1
* Get-JcSdkCommandFile.ps1
* Get-JcSdkCommandResult.ps1
* Get-JcSdkCommandResultByCommandId.ps1
* Get-JcSdkOrganization.ps1
* Get-JcSdkRadiusServer.ps1
* Get-JcSdkSystem.ps1
* Get-JcSdkUser.ps1
* Get-JcSdkUserSshKey.ps1
* Initialize-JcSdkUserState.ps1
* Invoke-JcSdkCommandTrigger.ps1
* Invoke-JcSdkExpireUserPassword.ps1
* Lock-JcSdkSystem.ps1
* New-JcSdkApplication.ps1
* New-JcSdkCommand.ps1
* New-JcSdkRadiusServer.ps1
* New-JcSdkUser.ps1
* New-JcSdkUserSshKey.ps1
* Remove-JcSdkApplication.ps1
* Remove-JcSdkCommand.ps1
* Remove-JcSdkCommandResult.ps1
* Remove-JcSdkRadiusServer.ps1
* Remove-JcSdkSystem.ps1
* Remove-JcSdkUser.ps1
* Remove-JcSdkUserSshKey.ps1
* Reset-JcSdkAdministratorUserActivation.ps1
* Reset-JcSdkAdministratorUserTotp.ps1
* Reset-JcSdkUserMfa.ps1
* Restart-JcSdkSystem.ps1
* Search-JcSdkCommand.ps1
* Search-JcSdkCommandResult.ps1
* Search-JcSdkOrganization.ps1
* Search-JcSdkSystem.ps1
* Search-JcSdkUser.ps1
* Set-JcSdkAdministratorUser.ps1
* Set-JcSdkApplication.ps1
* Set-JcSdkCommand.ps1
* Set-JcSdkOrganization.ps1
* Set-JcSdkRadiusServer.ps1
* Set-JcSdkSystem.ps1
* Set-JcSdkUser.ps1
* Start-JcSdkCommand.ps1
* Stop-JcSdkSystem.ps1
* Sync-JcSdkUserMfa.ps1
* Unlock-JcSdkUser.ps1

</details>

<details>
<summary>Functions Removed</summary>

No changes
</details>

## JumpCloud.SDK.V1-0.0.38
Release Date: February 07, 2024
#### RELEASE NOTES
```
This is a rollup release for the V1 module, no functional changes were made
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

* Get-JcSdkCommandResult.ps1
* New-JcSdkUser.ps1
* Set-JcSdkUser.ps1

</details>

<details>
<summary>Functions Removed</summary>

No changes
</details>

## JumpCloud.SDK.V1-0.0.37
Release Date: November 29, 2023
#### RELEASE NOTES
```
This is a rollup release for the V1 module, no functional changes were made
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

## JumpCloud.SDK.V1-0.0.36
Release Date: November 14, 2023
#### RELEASE NOTES
```
This release includes a new funcion `Start-JCSdkCommand` which can be used to ad-hoc invoke commands on a list of systems
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

* Start-JcSdkCommand.ps1

</details>

<details>
<summary>Functions Modified</summary>

* New-JcSdkApplication.ps1
* Set-JcSdkAdministratorUser.ps1
* Set-JcSdkApplication.ps1

</details>

<details>
<summary>Functions Removed</summary>

No changes
</details>

## JumpCloud.SDK.V1-0.0.35
Release Date: June 07, 2023
#### RELEASE NOTES
```
This release makes changes to available parameters in the Search functions
```
#### IMPROVEMENTS:
`filter1` and `fields1` parameters have been removed for the following functions:
* `Search-JcSdkCommand`
* `Search-JcSdkOrganization`
* `Search-JcSdkSystem`
* `Search-JcSdkUser`
#### Generated Changes:

<details>
<summary>Functions Added</summary>

No changes
</details>

<details>
<summary>Functions Modified</summary>

* Search-JcSdkCommand.ps1
* Search-JcSdkOrganization.ps1
* Search-JcSdkSystem.ps1
* Search-JcSdkUser.ps1
* Set-JcSdkOrganization.ps1

</details>

<details>
<summary>Functions Removed</summary>

No changes
</details>

## JumpCloud.SDK.V1-0.0.34
Release Date: May 04, 2023
#### RELEASE NOTES
```
This is a rollup release for the V1 module, no functional changes were made
```
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

## JumpCloud.SDK.V1-0.0.33
Release Date: March 13, 2023
#### RELEASE NOTES
```
This release adderesses several changes to the command result functions.
```
#### FEATURES:
`Get-JCSdkCommandResultByCommandID`, `Search-JCSdkCommandResult` functions added
#### BUG FIXES:
Fixed a bug in `Get-JcSdkCommandResult` where the ID parameter could not be used
#### Generated Changes:

<details>
<summary>Functions Added</summary>

* Get-JcSdkCommandResultByCommandId.ps1
* Search-JcSdkCommandResult.ps1

</details>

<details>
<summary>Functions Modified</summary>

* Get-JcSdkCommandResult.ps1
* Set-JcSdkOrganization.ps1

</details>

<details>
<summary>Functions Removed</summary>

No changes
</details>

## JumpCloud.SDK.V1-0.0.32
Release Date: January 27, 2023
#### RELEASE NOTES
```
This release address an incompatability with the `-Filter` parameter on V1 endpoitns
```
#### BUG FIXES:
Multiple filter can now be passed into V1 endpoint functions. To use multiple filters on the V1 module, please refer to the individual function documentation. In general filter parameters will consist of an array of strings where filter strings are composed of the field, operator and value you wish to search for. Ex. `Get-jcsdkuser -filter @("firstname:``$eq:foo", "company:``$eq:fakeCompany")`
#### Generated Changes:

<details>
<summary>Functions Added</summary>

No changes
</details>

<details>
<summary>Functions Modified</summary>

* Get-JcSdkApplication.ps1
* Get-JcSdkApplicationTemplate.ps1
* Get-JcSdkCommand.ps1
* Get-JcSdkCommandResult.ps1
* Get-JcSdkOrganization.ps1
* Get-JcSdkRadiusServer.ps1
* Get-JcSdkSystem.ps1
* Get-JcSdkUser.ps1
* Search-JcSdkCommand.ps1
* Search-JcSdkOrganization.ps1
* Search-JcSdkSystem.ps1
* Search-JcSdkUser.ps1

</details>

<details>
<summary>Functions Removed</summary>

No changes
</details>

## JumpCloud.SDK.V1-0.0.31
Release Date: December 28, 2022
#### RELEASE NOTES
```
This release is a rollup of SDK changes, several parameters have been added to V1 functions
```
#### FEATURES:
Get-JcSdkOrganization — `SortIgnoreCase` parameter added
New-JcSdkApplication — `SsoHidden` parameter added
New-JcSdkCommand — `ScheduleYear` parameter added
New-JcSdkRadiusServer — `CaCert` `DeviceCertEnabled` `UserCertEnabled` `UserPasswordEnabled` parameters added
New-JcSdkUser — `FullValidationDetails` parameter added
Set-JcSdkApplication — `SsoHidden` parameter addedSet-JcSdkCommand — `ScheduleYear` parameter added
Set-JcSdkRadiusServer — `CaCert` `DeviceCertEnabled` `UserCertEnabled` `UserPasswordEnabled` parameters added
Set-JcSdkUser — `FullValidationDetails` parameter added

#### Generated Changes:

<details>
<summary>Functions Added</summary>

No changes
</details>

<details>
<summary>Functions Modified</summary>

* Clear-JcSdkSystem.ps1
* Get-JcSdkApplication.ps1
* Get-JcSdkApplicationTemplate.ps1
* Get-JcSdkCommand.ps1
* Get-JcSdkCommandFile.ps1
* Get-JcSdkCommandResult.ps1
* Get-JcSdkOrganization.ps1
* Get-JcSdkRadiusServer.ps1
* Get-JcSdkSystem.ps1
* Get-JcSdkUser.ps1
* Get-JcSdkUserSshKey.ps1
* Initialize-JcSdkUserState.ps1
* Invoke-JcSdkCommandTrigger.ps1
* Invoke-JcSdkExpireUserPassword.ps1
* Lock-JcSdkSystem.ps1
* New-JcSdkApplication.ps1
* New-JcSdkCommand.ps1
* New-JcSdkRadiusServer.ps1
* New-JcSdkUser.ps1
* New-JcSdkUserSshKey.ps1
* Remove-JcSdkApplication.ps1
* Remove-JcSdkCommand.ps1
* Remove-JcSdkCommandResult.ps1
* Remove-JcSdkRadiusServer.ps1
* Remove-JcSdkSystem.ps1
* Remove-JcSdkUser.ps1
* Remove-JcSdkUserSshKey.ps1
* Reset-JcSdkAdministratorUserActivation.ps1
* Reset-JcSdkAdministratorUserTotp.ps1
* Reset-JcSdkUserMfa.ps1
* Restart-JcSdkSystem.ps1
* Search-JcSdkCommand.ps1
* Search-JcSdkOrganization.ps1
* Search-JcSdkSystem.ps1
* Search-JcSdkUser.ps1
* Set-JcSdkAdministratorUser.ps1
* Set-JcSdkApplication.ps1
* Set-JcSdkCommand.ps1
* Set-JcSdkOrganization.ps1
* Set-JcSdkRadiusServer.ps1
* Set-JcSdkSystem.ps1
* Set-JcSdkUser.ps1
* Stop-JcSdkSystem.ps1
* Sync-JcSdkUserMfa.ps1
* Unlock-JcSdkUser.ps1

</details>

<details>
<summary>Functions Removed</summary>

No changes
</details>

## JumpCloud.SDK.V1-0.0.30
Release Date: June 21, 2022
#### RELEASE NOTES
```
No changes, version increment
```
#### Generated Changes:

<details>
<summary>Functions Added</summary>

No changes
</details>

<details>
<summary>Functions Modified</summary>

* New-JcSdkRadiusServer.ps1

</details>

<details>
<summary>Functions Removed</summary>

No changes
</details>

## JumpCloud.SDK.V1-0.0.29
Release Date: May 31, 2022
#### RELEASE NOTES
```
This release includes several new functions for the V1 SDK, see "Generated Changes" for a complete list of functions added/modified.
```
#### Generated Changes:

<details>
<summary>Functions Added</summary>

* Initialize-JcSdkUserState.ps1
* Reset-JcSdkAdministratorUserActivation.ps1
* Reset-JcSdkAdministratorUserTotp.ps1
* Search-JcSdkCommand.ps1
* Set-JcSdkAdministratorUser.ps1
* Sync-JcSdkUserMfa.ps1

</details>

<details>
<summary>Functions Modified</summary>

* New-JcSdkCommand.ps1
* Set-JcSdkCommand.ps1

</details>

<details>
<summary>Functions Removed</summary>

No changes
</details>

## JumpCloud.SDK.V1-0.0.28
Release Date: May 02, 2022
#### RELEASE NOTES
```
Documentation and parameter updates
```
#### BUG FIXES:
Search-JcSdkOrganization should not longer error & remove orgID header before running
#### Generated Changes:

<details>
<summary>Functions Added</summary>

No changes
</details>

<details>
<summary>Functions Modified</summary>

* Get-JcSdkApplication.ps1
* Get-JcSdkApplicationTemplate.ps1
* Get-JcSdkUser.ps1
* New-JcSdkApplication.ps1
* New-JcSdkUser.ps1
* Reset-JcSdkUserMfa.ps1
* Set-JcSdkApplication.ps1
* Set-JcSdkOrganization.ps1
* Set-JcSdkUser.ps1

</details>

<details>
<summary>Functions Removed</summary>

No changes
</details>

## JumpCloud.SDK.V1-0.0.27
Release Date: Feb 16, 2022
#### RELEASE NOTES
```
Rollup of missing SDK functions
```
#### Generated Changes:

<details>
<summary>Functions Added</summary>

No changes
</details>

<details>
<summary>Functions Modified</summary>

* Clear-JcSdkSystem.ps1
* Get-JcSdkApplication.ps1
* Get-JcSdkApplicationTemplate.ps1
* Get-JcSdkCommand.ps1
* Get-JcSdkCommandFile.ps1
* Get-JcSdkCommandResult.ps1
* Get-JcSdkOrganization.ps1
* Get-JcSdkRadiusServer.ps1
* Get-JcSdkSystem.ps1
* Get-JcSdkUser.ps1
* Get-JcSdkUserSshKey.ps1
* Invoke-JcSdkCommandTrigger.ps1
* Invoke-JcSdkExpireUserPassword.ps1
* Lock-JcSdkSystem.ps1
* New-JcSdkApplication.ps1
* New-JcSdkCommand.ps1
* New-JcSdkUser.ps1
* New-JcSdkUserSshKey.ps1
* Remove-JcSdkApplication.ps1
* Remove-JcSdkCommand.ps1
* Remove-JcSdkCommandResult.ps1
* Remove-JcSdkRadiusServer.ps1
* Remove-JcSdkSystem.ps1
* Remove-JcSdkUser.ps1
* Remove-JcSdkUserSshKey.ps1
* Reset-JcSdkUserMfa.ps1
* Restart-JcSdkSystem.ps1
* Search-JcSdkOrganization.ps1
* Search-JcSdkSystem.ps1
* Search-JcSdkUser.ps1
* Set-JcSdkApplication.ps1
* Set-JcSdkCommand.ps1
* Set-JcSdkOrganization.ps1
* Set-JcSdkRadiusServer.ps1
* Set-JcSdkSystem.ps1
* Set-JcSdkUser.ps1
* Stop-JcSdkSystem.ps1
* Unlock-JcSdkUser.ps1
</details>

<details>
<summary>Functions Removed</summary>

No changes
</details>
