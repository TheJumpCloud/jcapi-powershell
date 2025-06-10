# This script reads environment variables to determine which modules to test.
# It expects the following variables to be set by the CI pipeline:
#   - $env:V1
#   - $env:V2
#   - $env:DIRECTORYINSIGHTS
#   - $env:RELEASE_TYPE

# Build a list of modules to test based on the environment variables.
$modulesToTest = [System.Collections.Generic.List[string]]::new()
if ($env:V1 -eq 'true') { $modulesToTest.Add('JumpCloud.SDK.V1') }
if ($env:V2 -eq 'true') { $modulesToTest.Add('JumpCloud.SDK.V2') }
if ($env:DIRECTORYINSIGHTS -eq 'true') { $modulesToTest.Add('JumpCloud.SDK.DirectoryInsights') }

# This Pester block will skip all subsequent tests if no module labels were found.
BeforeAll {
    if ($modulesToTest.Count -eq 0) {
        # Using Skip-All is the idiomatic Pester way to gracefully exit tests.
        Skip-All "No module labels (v1, v2, DirectoryInsights) found on PR. Skipping validation tests."
    }
    Write-Host "Running validation for the following modules: $($modulesToTest -join ', ')"
}

# Loop through each module identified for testing and run a dedicated suite of tests.
foreach ($moduleName in $modulesToTest) {

    Describe -Tag 'ModuleValidation', $moduleName "Module Manifest Tests for $moduleName" {
        $currentModuleName = $moduleName
        Write-Host "Running module validation tests for: $currentModuleName"

        It "validates the module version against the gallery based on the release type" {
            [version]$galleryVersion = Find-Module -Name $currentModuleName | Select-Object -ExpandProperty Version
            $psd1Path = "./SDKs/PowerShell/$currentModuleName/$currentModuleName.psd1"
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
            if (-not ($env:RELEASE_TYPE -in @('major', 'minor', 'patch'))) {
                Skip "Skipping changelog validation because release type is not 'major', 'minor', or 'patch'."
            }

            $latestModule = Find-Module -Name $currentModuleName
            $changelogPath = "$PSScriptRoot/../$currentModuleName.md"
            $changelogContent = Get-Content -Path $changelogPath -TotalCount 3

            # Validate the version in the changelog.
            $latestChangelogVersionString = (Select-String -InputObject $changelogContent -Pattern "## $currentModuleName-([0-9]+\.[0-9]+\.[0-9]+)").Matches.Groups[1].Value
            [version]$latestChangelogVersion = $latestChangelogVersionString
            $latestChangelogVersion | Should -BeGreaterThan ([version]$latestModule.Version)

            # Validate the release date is today.
            $latestReleaseDate = (Select-String -InputObject $changelogContent -Pattern "Release Date: (.*) ####").Matches.Groups[1].Value
            $todayDate = Get-Date -UFormat "%B %d, %Y"
            $latestReleaseDate | Should -Be $todayDate
        }

        It "ensures the changelog does not contain placeholder content" {
            $changelogPath = "$PSScriptRoot/../$currentModuleName.md"
            $changelogContent = Get-Content -Path $changelogPath
            $changelogContent | Should -Not -Match '\{\{Fill in the'
        }

        It "ensures the Swagger spec is up to date with no pending changes" {
            . "$PSScriptRoot/../ApiTransform.ps1" -SDKName $currentModuleName 3>$null
            $sdkSwaggerFile = "$PSScriptRoot/../SwaggerSpecs/$currentModuleName.json"
            $currentBranch = git rev-parse --abbrev-ref HEAD

            # Compare the generated spec file with the one in the current branch.
            $changes = git diff -I "collection_time" -I "dueDate" $currentBranch -- $sdkSwaggerFile

            if ($changes) {
                Write-Warning "Git Diff found changes in /SwaggerSpecs/$currentModuleName.json. Please run build.ps1 to ensure it is up to date."
            }
            $changes | Should -BeNullOrEmpty
        }
    }
}
