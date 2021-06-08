################################################################################
# Rules Skipped:
# 'PSAvoidUsingWriteHost',
# 'PSUseDeclaredVarsMoreThanAssignments',
# 'PSReviewUnusedParameter',
# 'PSAvoidUsingInvokeExpression'
################################################################################

Describe 'PSScriptAnalyzer Test Suite' {
    Context 'PSScriptAnalyzer Tests'{
        BeforeAll{
            ### SET UP ###
            $FolderPath_Module = (Get-Item -Path("$PSScriptRoot/../")).FullName
            $SettingsFile = "$PSScriptRoot/PSScriptAnalyzerSettings.psd1"
            # Import Settings:
            $SettingsFromFile = Import-PowerShellDataFile $SettingsFile
            $settingsObject = @{
                Severity     = $SettingsFromFile.Severity
                ExcludeRules = $SettingsFromFile.ExcludeRules
            }
            ##############
            Write-Host ('[status]Running PSScriptAnalyzer on: ' + $FolderPath_Module)
            Write-Host ('[status]PSScriptAnalyzer Settings File: ' + $SettingsFile)
            $ScriptAnalyzerResults = Invoke-ScriptAnalyzer -Path:("$FolderPath_Module") -recurse -Settings $settingsObject -reportSummary -Verbose
            If (-not [System.String]::IsNullOrEmpty($ScriptAnalyzerResults))
            {
                $ScriptAnalyzerResults | ForEach-Object {
                    Write-Error ('[PSScriptAnalyzer][' + $_.Severity + '][' + $_.RuleName + '] ' + $_.Message + ' found in "' + $_.ScriptPath + '" at line ' + $_.Line + ':' + $_.Column)
                }
            }
            Else
            {
                Write-Host ('[success]ScriptAnalyzer returned no results')
            }
        }
        It 'PSScriptAnalyzer Results should be null'{
            $ScriptAnalyzerResults | Should -BeNullOrEmpty
        }
        It 'PSScriptAnalyzer SettingsFile should exist' {
            test-path $SettingsFile | Should -Be $true
        }
        It 'PSScriptAnalyzer SettingsObject Should Not Be Null or Empty'{
            $SettingsFromFile | Should -Not -BeNullOrEmpty
            $settingsObject | Should -Not -BeNullOrEmpty
        }

    }
}