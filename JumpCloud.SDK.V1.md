## JumpCloud.SDK.V1-0.0.32
Release Date: January 27, 2023
#### RELEASE NOTES
```
{{Fill in the Release Notes}}
```
#### FEATURES:
{{Fill in the Features}}
#### IMPROVEMENTS:
{{Fill in the Improvements}}
#### BUG FIXES:
{{Fill in the Bug Fixes}}
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
