    Describe -Tag:('ModuleValidation') 'Module Validation'  {
        BeforeAll {
            if ($env:v1 -eq 'true') {
                $moduleName = 'JumpCloud.SDK.V1'
            } elseif ($env:v2 -eq 'true') {
                $moduleName = 'JumpCloud.SDK.V2'
            } elseif ($env:directoryinsights -eq 'true') {
                $moduleName = 'JumpCloud.SDK.DirectoryInsights'
            } else {
                Write-Error "No valid module label found in the environment variables. Exiting."
                Exit 1
            }
        }
        It "validates the module version against the gallery based on the release type" {
            # Find the currently published version on the PowerShell Gallery.
            # Use -ErrorAction SilentlyContinue for cases where the module isn't published yet (e.g., first release).
            $galleryModule = Find-Module -Name $moduleName -ErrorAction SilentlyContinue
            $galleryVersion = if ($null -ne $galleryModule) { [version]$galleryModule.Version } else { [version]'0.0.0' }

            # Get the local version from the module manifest (.psd1 file).
            $psd1Path = Join-Path $PSScriptRoot '..' 'SDKs' 'PowerShell' $moduleName "$moduleName.psd1"
            $localVersionString = (Get-Content -Path $psd1Path | Select-String -Pattern "ModuleVersion\s*=\s*'(.*)'").Matches.Groups[1].Value
            [version]$localVersion = $localVersionString

            # Assertion: The local version must always be greater than the published version.
            $localVersion | Should -BeGreaterThan $galleryVersion

            # If a release type is specified, validate the version increment is correct according to SemVer.
            if ($env:RELEASE_TYPE) {
                switch ($env:RELEASE_TYPE.ToLower()) {
                    'major' {
                        $localVersion.Major | Should -Be ($galleryVersion.Major + 1) "for a 'major' release"
                        $localVersion.Minor | Should -Be 0 "for a 'major' release"
                        $localVersion.Build | Should -Be 0 "for a 'major' release"
                    }
                    'minor' {
                        $localVersion.Major | Should -Be $galleryVersion.Major "for a 'minor' release"
                        $localVersion.Minor | Should -Be ($galleryVersion.Minor + 1) "for a 'minor' release"
                        $localVersion.Build | Should -Be 0 "for a 'minor' release"
                    }
                    'patch' {
                        # In SemVer, 'patch' is the third component. In the .NET [version] class, this corresponds to 'Build'.
                        $localVersion.Major | Should -Be $galleryVersion.Major "for a 'patch' release"
                        $localVersion.Minor | Should -Be $galleryVersion.Minor "for a 'patch' release"
                        $localVersion.Build | Should -Be ($galleryVersion.Build + 1) "for a 'patch' release"
                    }
                }
            }
        }

        It "validates the changelog has the correct new version and today's date" {
            # This test only runs if a release type that requires a changelog entry is specified.
            if (-not ($env:RELEASE_TYPE -in @('major', 'minor', 'patch'))) {
                Skip "Skipping changelog validation because release type is not 'major', 'minor', or 'patch'."
            }

            $galleryModule = Find-Module -Name $moduleName -ErrorAction SilentlyContinue
            $galleryVersion = if ($null -ne $galleryModule) { [version]$galleryModule.Version } else { [version]'0.0.0' }

            $changelogPath = Join-Path $PSScriptRoot '..' "$moduleName.md"
            $changelogContent = Get-Content -Path $changelogPath -TotalCount 5 # Read a few lines from the top

            # Validate the version in the changelog header.
            $changelogLine = $changelogContent | Select-String -Pattern "## $moduleName-([0-9]+\.[0-9]+\.[0-9]+)"
            $changelogLine | Should -Not -BeNullOrEmpty "because the changelog should contain a version header like '## $moduleName-x.y.z'"
            [version]$latestChangelogVersion = $changelogLine.Matches.Groups[1].Value
            $latestChangelogVersion | Should -BeGreaterThan $galleryVersion

            # Validate the release date is today.
            $latestReleaseDate = (Select-String -InputObject $changelogContent -Pattern "Release Date: (.*) ####").Matches.Groups[1].Value
            $todayDate = Get-Date -UFormat "%B %d, %Y"
            $latestReleaseDate | Should -Be $todayDate
        }

        It "ensures the changelog does not contain placeholder content" {
            $changelogPath = Join-Path $PSScriptRoot '..' "$moduleName.md"
            Get-Content -Path $changelogPath | Should -Not -Match '\{\{Fill in the'
        }

        It "ensures the Swagger spec is up to date with no pending changes" {
            # Note: Assumes dependent scripts are in the parent directory of this test script.
            . (Join-Path $PSScriptRoot '..' 'ApiTransform.ps1') -SDKName $moduleName 3>$null
            $sdkSwaggerFile = Join-Path $PSScriptRoot '..' 'SwaggerSpecs' "$moduleName.json"

            $currentBranch = git rev-parse --abbrev-ref HEAD

            # Compare the generated spec file with the version committed to the current branch.
            # Ignore keys that have dynamic values like timestamps.
            $gitDiffOutput = git diff --ignore-matching-lines='collection_time' --ignore-matching-lines='dueDate' $currentBranch -- $sdkSwaggerFile

            if ($gitDiffOutput) {
                Write-Warning "Git Diff found changes in /SwaggerSpecs/$moduleName.json. Please run the build script to ensure it is up to date."
            }

            $gitDiffOutput | Should -BeNullOrEmpty "because the Swagger spec file should have no pending changes after a build."
        }
    }