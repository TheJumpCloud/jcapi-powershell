[CmdletBinding()]
param (
    [Parameter(Mandatory = $true, ValueFromPipelineByPropertyName = $true, HelpMessage = 'Name of the API to build an SDK for.')][ValidateSet('JumpCloud.SDK.DirectoryInsights', 'JumpCloud.SDK.V1', 'JumpCloud.SDK.V2')][ValidateNotNullOrEmpty()][System.String[]]$SDKName
)
$rootPath = "$PSScriptRoot/../"
$SdkChangelogFilePath = "$rootPath/$SDKName.md"
Import-Module ($PSScriptRoot + '/New-SdkChangelog.ps1')
# For authorized requests add header & OAuth Token:
# $headers = @{
#     "Authorization" = ""
# }
$release = Invoke-WebRequest -Uri 'https://api.github.com/repos/TheJumpCloud/jcapi-powershell/releases'  -Method 'GET'#  -Headers $Headers
# Get latest release by sorting last published
$releaseVersions = ($release | ConvertFrom-Json -Depth 99) | Where-Object { $_.name -match $SDKName } | Select-Object name, target_commitish, published_at, tag_name | Sort-Object -Property published_at -Descending
# Latest release commit, getting the first value since it is the most recent
$LatestCommit = $releaseVersions[0].target_commitish
$LatestVersion = $releaseVersions[0].name
Write-Host "Last Release Commit: $LatestCommit"
Write-Host "Last Release Name: $LatestVersion"

# For each diff type, replace string with '* ' to turn it into a markdown list; we only care about reporting functions in the /custom/generated directory
$diffAdded = (git diff $LatestCommit HEAD --diff-filter=A --name-only ./SDKs/PowerShell/$SDKName/custom/generated/ | Out-String).replace("SDKs/PowerShell/$SDKName/custom/generated/", '* ')
$diffModified = (git diff $LatestCommit HEAD --diff-filter=M --name-only ./SDKs/PowerShell/$SDKName/custom/generated/ | Out-String).replace("SDKs/PowerShell/$SDKName/custom/generated/", '* ')
$diffDeleted = (git diff $LatestCommit HEAD --diff-filter=D --name-only ./SDKs/PowerShell/$SDKName/custom/generated/ | Out-String).replace("SDKs/PowerShell/$SDKName/custom/generated/", '* ')
# If nothing is returned, return no changes
if (!$diffAdded) {
    Write-Host "No new functions were generated"
    $diffAdded = 'No changes'
}
if (!$diffModified) {
    Write-Host "No functions were modified"
    $diffModified = 'No changes'
}
if (!$diffDeleted) {
    Write-Host "No existing functions were deleted"
    $diffDeleted = 'No changes'
}
# Get Latest Version from Changelog
$SdkChangelog = Get-Content -Path $SdkChangelogFilePath -Raw
$ChangelogVersionRegex = [regex]"##\ ($SDKName-\d+\.\d+\.\d+)"
$ChangelogVersions = Select-String -InputObject $SdkChangelog -Pattern $ChangelogVersionRegex
if ($ChangelogVersions){
    $LatestVersionInChangelog = $ChangelogVersions.Matches.Groups[1].value
}
Write-Host "Last Version in Changelog: $LatestVersionInChangelog"

# Get lastest development version from PSD1 file:
$sdkPsd1FilePath = "$rootPath/SDKs/PowerShell/$SDKName/$SDKName.psd1"
$SdkPsd1 = Get-Content -Path $sdkPsd1FilePath -Raw
$sdkPsd1Regex = [regex]"ModuleVersion\ =\ '(\d+\.\d+\.\d+)'"
$SdkDevVersion = Select-String -InputObject $SdkPsd1 -Pattern $sdkPsd1Regex
$LatestPsd1Version = "$SDKName-" +$SdkDevVersion.Matches.Groups[1].value
Write-Host "Last Version in Psd1: $LatestPsd1Version"

# Populate changelog data
$NewSdkChangelogRecord = New-SdkChangelog -LatestVersion:($LatestPsd1Version) -ReleaseNotes:('{{Fill in the Release Notes}}') -Features:('{{Fill in the Features}}') -Improvements:('{{Fill in the Improvements}}') -BugFixes('{{Fill in the Bug Fixes}}') -DiffAdded $diffAdded -DiffModified $diffModified -diffDeleted $diffDeleted

# Check if we need to post a new changelog block or update the diffs
if ($SdkChangelog -notmatch "$LatestPsd1Version") {
    Write-Host "Latest Release Version: $LatestPsd1Version differs from changelog version $LatestVersionInChangelog"
    # Write-Host "Creating new changelog verion header"
    ($NewSdkChangelogRecord + ($SdkChangelog | Out-String)).Trim() | Set-Content -Path $SdkChangelogFilePath -Force
}
elseif ($SdkChangelog -match "$LatestPsd1Version") {
    Write-Host "Updating Diffs"
    # Update the changelog Release Date
    $SdkChangelog = Get-Content -Path $SdkChangelogFilePath -Raw
    $todaysDate = Get-Date -UFormat "%B %d, %Y"
    $SdkChangelog = $SdkChangelog -replace ("Release Date:.*"), "Release Date: $todaysDate"
    # Update the changelog with the new diffs
    $SdkChangelog | Set-Content -Path $SdkChangelogFilePath -Force

    # Get the current version content up to the last version content
    $LastChangeRegex = [regex]"## $LatestPsd1Version[\s\S]*?(?=## $sdkname-)"
    $ChangeLogContent = Select-String -InputObject $SdkChangelog -Pattern $LastChangeRegex
    # Get Content to edit
    $ContentToEdit = $ChangeLogContent.Matches.Value
    $UpdatedDiffText = "#### Generated Changes:

<details>
<summary>Functions Added</summary>

$diffAdded
</details>

<details>
<summary>Functions Modified</summary>

$diffModified
</details>

<details>
<summary>Functions Removed</summary>

$diffDeleted
</details>

"
    # Update the Generated Changes Block:
    $ReplacedContent = $ContentToEdit -replace ("#### Generated Changes:[\s\S]*", $UpdatedDiffText)
    $SdkChangelog -replace ($LastChangeRegex, $ReplacedContent) | Set-Content -Path $SdkChangelogFilePath -NoNewline -Force
    # Finally reaplce the "Release Date" date if there is a change required:
    $SdkChangelog = Get-Content -Path $SdkChangelogFilePath -Raw
    $LastChangeRegex = [regex]"## $LatestPsd1Version[\s\S]*?(?=## $sdkname-)"
    $ChangeLogContent = Select-String -InputObject $SdkChangelog -Pattern $LastChangeRegex
    $ContentToEdit = $ChangeLogContent.Matches.Value
    $ReplacedContent = $ContentToEdit -replace ("Release Date:.*", "Release Date: $(Get-Date -UFormat:('%B %d, %Y'))")
    # Update the Release Date
    $SdkChangelog -replace ($LastChangeRegex, $ReplacedContent) | Set-Content -Path $SdkChangelogFilePath -NoNewline -Force
}