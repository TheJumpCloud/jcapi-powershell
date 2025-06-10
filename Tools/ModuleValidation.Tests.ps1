# Reads environment variables from CI to determine which modules to test.
#   - $env:V1
#   - $env:V2
#   - $env:DIRECTORYINSIGHTS
# It also uses $env:RELEASE_TYPE ('major', 'minor', 'patch').

# Build a list of modules to test based on the environment variables.
$modulesToTest = [System.Collections.Generic.List[string]]::new()
if ($env:v1 -eq 'true') { $modulesToTest.Add('JumpCloud.SDK.V1') }
if ($env:v2 -eq 'true') { $modulesToTest.Add('JumpCloud.SDK.V2') }
if ($env:directoryinsights -eq 'true') { $modulesToTest.Add('JumpCloud.SDK.DirectoryInsights') }

Write-Host "Modules to test: $($modulesToTest -join ', ')"
Write-Host "Release Type: $env:RELEASE_TYPE"
# If no module labels are found, skip all tests.
BeforeAll {
    if ($modulesToTest.Count -eq 0) {
        Write-Warning "No module labels (v1, v2, directoryinsights) found on PR. Skipping validation tests."
        exit 0
    }
}

# Loop through each module identified for testing and run a dedicated suite of tests.
foreach ($moduleName in $modulesToTest) {

    Describe -Tag 'ModuleValidation', $moduleName "Module Manifest Tests for $moduleName" {

        It "validates the module version against the gallery based on the release type" {
            [version]$galleryVersion = Find-Module -Name $moduleName | Select-Object -ExpandProperty Version
            $psd1Path = "./SDKs/PowerShell/$moduleName/$moduleName.psd1"
            [version]$localVersion = (Get-Content -Path $psd1Path | Select-String -Pattern "ModuleVersion = '(.*)'").Matches.Groups[1].Value

            # The local version must always be greater than the published gallery version.
            $localVersion | Should -BeGreaterThan $galleryVersion

            # Check for the correct version number increment based on the release type.
            switch ($env:RELEASE_TYPE) {
                'major' { $localVersion.Major | Should -Be ($galleryVersion.Major + 1) }
                'minor' { $localVersion.Minor | Should -Be ($galleryVersion.Minor + 1) }
                'patch' { $localVersion.Build | Should -Be ($galleryVersion.Build + 1) }
            }
        }

        It "validates the changelog has the correct new version and today's date" {
            # This test only runs if a release type is specified.
            if (-not $env:RELEASE_TYPE) {
                Skip "Skipping changelog validation because no release type was specified."
            }

            $latestModule = Find-Module -Name $moduleName
            $changelogPath = "$PSScriptRoot/../$moduleName.md"
            $changelogContent = Get-Content -Path $changelogPath -TotalCount 3

            # Validate the version in the changelog.
            $latestChangelogVersionString = (Select-String -InputObject $changelogContent -Pattern "## $moduleName-([0-9]+.[0-9]+.[0-9]+)").Matches.Groups[1].Value
            [version]$latestChangelogVersion = $latestChangelogVersionString
            $latestChangelogVersion | Should -BeGreaterThan ([version]$latestModule.Version)

            # Validate the release date is today.
            $latestReleaseDate = (Select-String -InputObject $changelogContent -Pattern "Release Date: (.*) ####").Matches.Groups[1].Value
            $todayDate = Get-Date -UFormat "%B %d, %Y"
            $latestReleaseDate | Should -Be $todayDate
        }

        It "ensures the changelog does not contain placeholder content" {
            $changelogPath = "$PSScriptRoot/../$moduleName.md"
            $changelogContent = Get-Content -Path $changelogPath
            $changelogContent | Should -Not -Match "{{Fill in the"
        }

        It "ensures the Swagger spec is up to date with no pending changes" {
            . "$PSScriptRoot/../ApiTransform.ps1" -SDKName $moduleName 3>$null
            $sdkSwaggerFile = "$PSScriptRoot/../SwaggerSpecs/$moduleName.json"
            $currentBranch = git rev-parse --abbrev-ref HEAD

            # Compare the generated spec file with the one in the current branch.
            $changes = git diff -I "collection_time" -I "dueDate" $currentBranch -- $sdkSwaggerFile

            if ($changes) {
                Write-Warning "Git Diff found changes in /SwaggerSpecs/$moduleName.json. Please run build.ps1 to ensure it is up to date."
            }
            $changes | Should -BeNullOrEmpty
        }
    }
}