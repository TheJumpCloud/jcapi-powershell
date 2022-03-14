[CmdletBinding()]
param (
    [Parameter()]
    [String]
    $sdkName,
    [Parameter()]
    [String]
    $sdkChangelogLocation
)
$sdkName = 'JumpCloud.SDK.V2'
$sdkChangelogLocation = 'SDKs/PowerShell/JumpCloud.SDK.V2/sdkV2Changelog.md'
$release = Invoke-WebRequest -Uri 'https://api.github.com/repos/TheJumpCloud/jcapi-powershell/releases'  -Method 'GET'
$releaseVersions = $release | ConvertFrom-Json -Depth 4

$sdkCommitId = $releaseVersions.target_commitish[0] #Latest release commit, getting the first value since it is the most recent
$sdkVersion = $releaseVersions.tag_name -match $sdkName | Out-String
Write-Host $sdkCommitId

Write-Host $sdkVersion
$diffAdded = git diff HEAD^ $sdkCommitId --compact-summary --diff-filter=A | Grep "generated" | Out-String
$diffModified = git diff HEAD^ $sdkCommitId --compact-summary --diff-filter=M | Grep "generated" | Out-String
$diffDeleted = git diff HEAD^ $sdkCommitId --compact-summary --diff-filter=D | Grep "generated" | Out-String
#Write-Host $diffModified
if (!$diffAdded) {
    $diffAdded = 'No changes'
}
if (!$diffModified) {
    $diffModified = 'No changes'
}
if (!$diffDeleted) {
    $diffDeleted = 'No changes'
}

$SdkChangelog = Get-Content -Path $sdkChangelogLocation | Out-String
#Write-Host $sdkChangelogLocation | Select-Object -First 1
# Populate changelog data
$NewSdkChangelogRecord = New-SdkChangelog -LatestVersion:($sdkVersion) -ReleaseNotes:('{{Fill in the Release Notes}}') -Features:('{{Fill in the Features}}') -Improvements:('{{Fill in the Improvements}}') -BugFixes('{{Fill in the Bug Fixes}}') -DiffAdded $diffAdded -DiffModified $diffModified -diffDeleted $diffDeleted
#Write-Host (($SdkChangelog | Out-String | Select-Object -First 1) -match $sdkVersion)

# If check sdkName then populate .md files
If (($SdkName -eq 'JumpCloud.SDK.DirectoryInsights') -and (($SdkChangelog | Select-Object -First 1) -match $sdkVersion)){
    ($NewSdkChangelogRecord + ($SdkChangelog | Out-String)).Trim() | Set-Content -Path $sdkChangelogLocation -Force
}
If (($SdkName -eq 'JumpCloud.SDK.V1') -and (($SdkChangelog | Select-Object -First 1) -match $sdkVersion)){
    ($NewSdkChangelogRecord + ($SdkChangelog | Out-String)).Trim() | Set-Content -Path $sdkChangelogLocation -Force
} 
If (($SdkName -eq 'JumpCloud.SDK.V2') -and (($SdkChangelog | Select-Object -First 1) -match $sdkVersion)){
    ($NewSdkChangelogRecord + ($SdkChangelog | Out-String)).Trim() | Set-Content -Path $sdkChangelogLocation -Force
}


