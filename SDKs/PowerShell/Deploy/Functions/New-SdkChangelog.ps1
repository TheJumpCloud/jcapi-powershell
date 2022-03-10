Function Global:New-SdkChangelog
{
    Param(
        [Parameter(Mandatory = $true, ValueFromPipelineByPropertyName = $true, Position = 0)][ValidateNotNullOrEmpty()][System.String]$LatestVersion
        , [Parameter(Mandatory = $true, ValueFromPipelineByPropertyName = $true, Position = 1)][ValidateNotNullOrEmpty()][System.String]$ReleaseNotes
        , [Parameter(Mandatory = $true, ValueFromPipelineByPropertyName = $true, Position = 2)][ValidateNotNullOrEmpty()][System.String]$Features
        , [Parameter(Mandatory = $true, ValueFromPipelineByPropertyName = $true, Position = 3)][ValidateNotNullOrEmpty()][System.String]$Improvements
        , [Parameter(Mandatory = $true, ValueFromPipelineByPropertyName = $true, Position = 4)][ValidateNotNullOrEmpty()][System.String]$BugFixes
        , [Parameter(Mandatory = $true, ValueFromPipelineByPropertyName = $true, Position = 5)][ValidateNotNullOrEmpty()][System.String]$Diff
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
#### DIFF:
{5}
"
    Return ($Content -f $LatestVersion, $ReleaseNotes, $Features, $Improvements, $BugFixes, $Diff)
}