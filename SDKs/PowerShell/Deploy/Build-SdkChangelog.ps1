[CmdletBinding()]
param (
    [Parameter()]
    [String]
    $SdkName
)
#curl -H "Accept: application/vnd.github.v3+json" https://api.github.com/repos/TheJumpCloud/jcapi-powershell/releases | jq '.[] | {tag_name,target_commitish,published_at}'

$release = Invoke-WebRequest -Uri 'https://api.github.com/repos/TheJumpCloud/jcapi-powershell/releases'  -Method 'GET'
$releaseVersions =$release | ConvertFrom-Json -Depth 4

$v1LatestVersion = $releaseVersions.tag_name -match "JumpCloud.SDK.v1"
$v2LatestVersion = $releaseVersions.tag_name -match "JumpCloud.SDK.V2"
$DiLatestVersion = $releaseVersions.tag_name -match "JumpCloud.SDK.DirectoryInsights"

#Write-Host $DiLatestVersion | Out-String
# $test | Select tag_name

#Write-Host $test | ConvertFrom-Json -Depth 100
#TODO: Populate SdkChangelog.md
#TODO: Call New-SdkChangelog to populate data
$CurrentBranch = git branch --show-current

$Diffs = git diff master...$CurrentBranch
$SdkChangelog = Get-Content -Path:("SDKs/PowerShell/JumpCloud.SDK.DirectoryInsights/DiChangelog.md")
$NewSdkChangelogRecord = New-SdkChangelog -LatestVersion:($DiLatestVersion | Out-String) -ReleaseNotes:('{{Fill in the Release Notes}}') -Features:('{{Fill in the Features}}') -Improvements:('{{Fill in the Improvements}}') -BugFixes('{{Fill in the Bug Fixes}}') -Diff($Diffs | Out-String)

If ((($SdkChangelog | Select-Object -First 1) -match $DiLatestVersion)){
    ($NewSdkChangelogRecord + ($SdkChangelog | Out-String)).Trim() | Set-Content -Path:("SDKs/PowerShell/JumpCloud.SDK.DirectoryInsights/DiChangelog.md") -Force
}


