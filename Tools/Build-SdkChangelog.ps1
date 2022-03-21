[CmdletBinding()]
param (
    [Parameter()]
    [String]
    $sdkName
)
$sdkChangelogLocation = "./$sdkName.md"
Import-Module ($PSScriptRoot + '/New-SdkChangelog.ps1')
$release = Invoke-WebRequest -Uri 'https://api.github.com/repos/TheJumpCloud/jcapi-powershell/releases'  -Method 'GET'
$releaseVersions = $release | ConvertFrom-Json -Depth 4

$sdkCommitId = $releaseVersions.target_commitish[0] #Latest release commit, getting the first value since it is the most recent
$latestRelaseVersion = $releaseVersions.tag_name -match $sdkName
Write-Host "Latest Release Commit: $sdkCommitId"

$moduleVersion = Select-String -Path "./SDKs/PowerShell/$sdkName/$sdkName.psd1" -Pattern '\d\.\d.\d\d' -AllMatches | ForEach-Object { $_.Matches } | % { $_.Value }
$diffAdded = git diff $sdkCommitId HEAD --compact-summary --diff-filter=A ./SDKs/PowerShell/$sdkName/custom/generated/ | Out-String
$diffModified = git diff $sdkCommitId HEAD --compact-summary --diff-filter=M ./SDKs/PowerShell/$sdkName/custom/generated/ | Out-String
$diffDeleted = git diff $sdkCommitId HEAD --compact-summary --diff-filter=D ./SDKs/PowerShell/$sdkName/custom/generated/ | Out-String
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
# Get Latest Version from Changelog
$SdkChangelog = Get-Content -Path $sdkChangelogLocation -Raw
$ChangelogVersionRegex = [regex]"##\ ($sdkName-\d+\.\d+\.\d+)"
$ChangelogVersions = Select-String -InputObject $SdkChangelog -Pattern $ChangelogVersionRegex
$LatestVersionInChangelog = $ChangelogVersions.Matches.Groups[1].value
Write-Host "Last Version in changelog: $LatestVersionInChangelog"

# Get lastest development version from PSD1 file:
$sdkPsd1FilePath = "./SDKs/PowerShell/$sdkName/$sdkName.psd1"
$SdkPsd1 = Get-Content -Path $sdkPsd1FilePath -Raw
$sdkPsd1Regex = [regex]"ModuleVersion\ =\ '(\d+\.\d+\.\d+)'"
$SdkDevVersion = Select-String -InputObject $SdkPsd1 -Pattern $sdkPsd1Regex
$LatestPsd1Version = "$sdkName-" +$SdkDevVersion.Matches.Groups[1].value
Write-Host "Last Version in psd1: $LatestPsd1Version"

# Populate changelog data
$NewSdkChangelogRecord = New-SdkChangelog -LatestVersion:($sdkName+'-'+$moduleVersion) -ReleaseNotes:('{{Fill in the Release Notes}}') -Features:('{{Fill in the Features}}') -Improvements:('{{Fill in the Improvements}}') -BugFixes('{{Fill in the Bug Fixes}}') -DiffAdded $diffAdded -DiffModified $diffModified -diffDeleted $diffDeleted

# If check sdkName then populate .md files
if ($SdkChangelog -notmatch "$LatestPsd1Version") {
    Write-Host "Latest Release Version: $latestRelaseVersion differs from changlog version $LatestVersionInChangelog"
    # ($SdkChangelog | Select-Object -First 1)
    Write-Host "Creating new changelog verion header"
    ($NewSdkChangelogRecord + ($SdkChangelog | Out-String)).Trim() | Set-Content -Path $sdkChangelogLocation -Force
}
elseif ($SdkChangelog -match "$LatestPsd1Version") {
    Write-Host "Updating Diffs"
    $LastChangeRegex = [regex]"## $LatestPsd1Version[\s\S]*?(?=## $sdkname-)"
    $LastChangeDiffRegex = Select-String -InputObject $SdkChangelog -Pattern $LastChangeRegex
    $ToEdit = $LastChangeDiffRegex.Matches.Value
    $difftext = "#### DIFF ADDED:
$diffAdded
#### DIFF MODIFIED:
$diffModified
#### DIFF Deleted:
$diffDeleted"
    # $difftext = New-SdkChangelog -DiffAdded $diffAdded -DiffModified $diffModified -diffDeleted $diffDeleted
    $toReplace = $ToEdit -replace ("#### DIFF ADDED:[\s\S]*", $difftext)
    $SdkChangelog -replace ($LastChangeRegex, $toReplace) | Set-Content -Path $sdkChangelogLocation -NoNewline -Force
}
