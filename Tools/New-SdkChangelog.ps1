Function Global:New-SdkChangelog
{
    Param(
        [Parameter(Mandatory = $true, ValueFromPipelineByPropertyName = $true, Position = 0)][ValidateNotNullOrEmpty()][System.String]$LatestVersion
        , [Parameter(Mandatory = $true, ValueFromPipelineByPropertyName = $true, Position = 1)][ValidateNotNullOrEmpty()][System.String]$ReleaseNotes
        , [Parameter(Mandatory = $true, ValueFromPipelineByPropertyName = $true, Position = 2)][ValidateNotNullOrEmpty()][System.String]$Features
        , [Parameter(Mandatory = $true, ValueFromPipelineByPropertyName = $true, Position = 3)][ValidateNotNullOrEmpty()][System.String]$Improvements
        , [Parameter(Mandatory = $true, ValueFromPipelineByPropertyName = $true, Position = 4)][ValidateNotNullOrEmpty()][System.String]$BugFixes
        , [Parameter(Mandatory = $true, ValueFromPipelineByPropertyName = $true, Position = 5)][ValidateNotNullOrEmpty()][System.String]$DiffAdded
        , [Parameter(Mandatory = $true, ValueFromPipelineByPropertyName = $true, Position = 6)][ValidateNotNullOrEmpty()][System.String]$DiffModified
        , [Parameter(Mandatory = $true, ValueFromPipelineByPropertyName = $true, Position = 7)][ValidateNotNullOrEmpty()][System.String]$DiffDeleted
    )
    $Content = "## {0}
Release Date: $(Get-Date -UFormat:('%B %d, %Y'))
#### RELEASE NOTES
```````
{1}
```````
#### FEATURES:
{2}
#### IMPROVEMENTS:
{3}
#### BUG FIXES:
{4}
#### Generated Changes:

<details>
<summary>Functions Added</summary>

{5}
</details>

<details>
<summary>Functions Modified</summary>

{6}
</details>

<details>
<summary>Functions Removed</summary>

{7}
</details>

"
    Return ($Content -f $LatestVersion, $ReleaseNotes, $Features, $Improvements, $BugFixes, $DiffAdded, $DiffModified, $DiffDeleted)
}