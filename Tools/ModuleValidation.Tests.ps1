Describe -Tag:('ModuleValidation') 'Module Manifest Tests' {
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
        @('JumpCloud.SDK.DirectoryInsights', 'JumpCloud.SDK.V1', 'JumpCloud.SDK.V2') | ForEach-Object {
            $rootPath = "$PSScriptRoot/../"
            $moduleChangelogPath = "$rootPath/$_.md"
            $moduleChangelogContent = Get-Content ("$moduleChangelogPath")
            $moduleChangelogContent | Should -Not -Match "{{Fill in the"

        }
    }
}