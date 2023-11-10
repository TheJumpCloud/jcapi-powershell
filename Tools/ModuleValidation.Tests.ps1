
Describe -Tag:('ModuleValidation') 'Module Manifest Tests' {
    It ('Validates Module Versions'){
        [version]$v1GalleryVersion = Find-Module -name JumpCloud.SDK.V1 | Select-Object -Property Version | ForEach-Object { $_.Version }
        # Compare the versions to SDKs/PowerShell/JumpCloud.SDK.V1/JumpCloud.SDK.V1.psd1
        [version]$V1LocalVersion = Get-Content -Path "./SDKs/PowerShell/JumpCloud.SDK.V1/JumpCloud.SDK.V1.psd1" | Select-String -Pattern "ModuleVersion = '(.*)'" | ForEach-Object { $_.Matches.Groups[1].Value }

        # Compare the versions to SDKs/PowerShell/JumpCloud.SDK.V2/JumpCloud.SDK.V2.psd1
        [version]$v2GalleryVersion = Find-Module -name JumpCloud.SDK.V2 | Select-Object -Property Version | ForEach-Object { $_.Version }
        [version]$V2LocalVersion = Get-Content -Path "./SDKs/PowerShell/JumpCloud.SDK.V2/JumpCloud.SDK.V2.psd1" | Select-String -Pattern "ModuleVersion = '(.*)'" | ForEach-Object { $_.Matches.Groups[1].Value }

        # Compare the versions to SDKs/PowerShell/JumpCloud.SDK.DirectoryInsights/JumpCloud.SDK.DirectoryInsights.psd1
        [version]$DiGalleryVersion = Find-Module -name JumpCloud.SDK.DirectoryInsights | Select-Object -Property Version | ForEach-Object { $_.Version }
        [version]$DiLocalVersion = Get-Content -Path "./SDKs/PowerShell/JumpCloud.SDK.DirectoryInsights/JumpCloud.SDK.DirectoryInsights.psd1" | Select-String -Pattern "ModuleVersion = '(.*)'" | ForEach-Object { $_.Matches.Groups[1].Value }


        switch ($env:RELEASE_TYPE) {
            'major' {
                $V1LocalVersion.Major | Should -Be ($v1GalleryVersion.Major + 1)
                $V2LocalVersion.Major | Should -Be ($v2GalleryVersion.Major + 1)
                $DiLocalVersion.Major | Should -Be ($DiGalleryVersion.Major + 1)

                $V1LocalVersion | Should -BeGreaterThan $v1GalleryVersion
                $V2LocalVersion | Should -BeGreaterThan $v2GalleryVersion
                $DiGalleryVersion | Should -BeGreaterThan $DiGalleryVersion
            }
            'minor' {
                $V1LocalVersion.Minor | Should -Be ($v1GalleryVersion.Minor + 1)
                $V2LocalVersion.Minor | Should -Be ($v2GalleryVersion.Minor + 1)
                $DiLocalVersion.Minor | Should -Be ($DiGalleryVersion.Minor + 1)

                $V1LocalVersion | Should -BeGreaterThan $v1GalleryVersion
                $V2LocalVersion | Should -BeGreaterThan $v2GalleryVersion
                $DiGalleryVersion | Should -BeGreaterThan $DiGalleryVersion
            }
            'patch' {
                #Test
                $V1LocalVersion.Build | Should -Be ($v1GalleryVersion.Build + 1)
                $V2LocalVersion.Build | Should -Be ($v2GalleryVersion.Build + 1)
                $DiLocalVersion.Build | Should -Be ($DiGalleryVersion.Build + 1)

                $V1LocalVersion | Should -BeGreaterThan $v1GalleryVersion
                $V2LocalVersion | Should -BeGreaterThan $v2GalleryVersion
                $DiLocalVersion | Should -BeGreaterThan $DiGalleryVersion


            }
        }
    }
    It 'The data on the current version of the Module Changelog should be todays date' {
        if ($env:RELEASE_TYPE) {
            @('JumpCloud.SDK.DirectoryInsights', 'JumpCloud.SDK.V1', 'JumpCloud.SDK.V2')| ForEach-Object {
                $latestModule = Find-Module -Name $_
                $rootPath = "$PSScriptRoot/../"
                $moduleChangelogPath = "$rootPath/$_.md"
                $moduleChangelogContent = Get-Content ("$moduleChangelogPath") -TotalCount 3
                # latest from changelog
                $stringMatch = Select-String -InputObject $moduleChangelogContent -Pattern "## $_-([0-9]+.[0-9]+.[0-9]+)"
                $latestChangelogVersion = $stringMatch.matches.groups[1].value
                $stringMatch = Select-String -InputObject $moduleChangelogContent -Pattern "Release Date: (.*) ####"
                $latestReleaseDate = $stringMatch.matches.groups[1].value
                switch ($env:RELEASE_TYPE) {
                    'major' {
                        $versionString = "$($(([version]$latestModule.Version).Major) + 1).0.0"
                        Write-Host "[Module Validation Tests] Development Version Major Changelog Version: $($latestChangelogVersion) Should be $versionString"
                        ([Version]$latestChangelogVersion).Major | Should -Be (([version]$latestModule.Version).Major + 1)
                        ([Version]$latestChangelogVersion) | Should -BeGreaterThan (([version]$latestModule.Version))
                    }
                    'minor' {
                        $versionString = "$($(([version]$latestModule.Version).Major)).$(([version]$latestModule.Version).minor + 1).0"
                        Write-Host "[Module Validation Tests] Development Version Minor Changelog Version: $($latestChangelogVersion) Should be $versionString"
                        ([Version]$latestChangelogVersion).Minor | Should -Be (([version]$latestModule.Version).Minor + 1)
                        ([Version]$latestChangelogVersion) | Should -BeGreaterThan (([version]$latestModule.Version))
                    }
                    'patch' {
                        $versionString = "$($(([version]$latestModule.Version).Major)).$(([version]$latestModule.Version).minor).$(([version]$latestModule.Version).Build + 1)"
                        Write-Host "[Module Validation Tests] Development Version Build Changelog Version: $($latestChangelogVersion) Should be $versionString"
                        ([Version]$latestChangelogVersion).Build | Should -Be (([version]$latestModule.Version).Build + 1)
                        ([Version]$latestChangelogVersion) | Should -BeGreaterThan (([version]$latestModule.Version))
                    }
                    'manual' {
                        Write-Host "[Module Validation Tests] Development Version Changelog Version: $($latestChangelogVersion) is going to be manually released to PowerShell Gallery"
                        ([Version]$latestChangelogVersion) | Should -BeGreaterThan (([version]$latestModule.Version))
                    }
                }
                $todayDate = Get-Date -UFormat "%B %d, %Y"
                # if ($todayDate | Select-String -Pattern "0\d,") {
                #     $todayDate = "$(Get-Date -UFormat %B) $($(Get-Date -Uformat %d) -replace '0', ''), $(Get-Date -UFormat %Y)"
                # }
                $latestReleaseDate | Should -Be $todayDate
            }

        }
    }
    It 'The ModuleChangeLog Congent should not contain placeholder content'{
        $rootPath = "$PSScriptRoot/../"
        @('JumpCloud.SDK.DirectoryInsights', 'JumpCloud.SDK.V1', 'JumpCloud.SDK.V2') | ForEach-Object {
            $moduleChangelogPath = "$rootPath/$_.md"
            $moduleChangelogContent = Get-Content ("$moduleChangelogPath")
            $moduleChangelogContent | Should -Not -Match "{{Fill in the"
        }
    }
    It 'Runs API Transform and validates no changes in SwaggerSpec exist (branch is up to date with public docs)'{
        $rootPath = "$PSScriptRoot/../"
        @('JumpCloud.SDK.DirectoryInsights', 'JumpCloud.SDK.V1', 'JumpCloud.SDK.V2') | ForEach-Object {
            . "$rootpath/ApiTransform.ps1" -SDKName $_ 3>$null
            $sdkSwaggerFile = "$rootpath/SwaggerSpecs/$_.json"
            $currentBranch = git rev-parse --abbrev-ref HEAD
            $changes = git diff $currentBranch -- $sdkSwaggerFile
            if ($changes){
                Write-Warning "Git Diff changes found in /SwaggerSpecs/$_.json have you run build.ps1 today?"
            }
            $changes | should -BeNullOrEmpty
        }
    }
}