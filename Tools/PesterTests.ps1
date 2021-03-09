<#
TODO:
    Clear-JcSdkSystem.Tests.ps1: Setup Orgs with a device that can be cleared each time
    Get-JcSdkCommandFile.Tests.ps1: Configure New-JcSdkCommand test to upload a simple text file
    Invoke-JcSdkCommandTrigger.Tests.ps1: Configure a command with a 'trigger' launchType
    Lock-JcSdkSystem.Tests.ps1: Setup Orgs with a device that can be locked each time
    New-JcApplication.Tests.ps1: Figure out how to configure an Application from the SDK
    New-JcSdkCommand.Tests.ps1: Configure a simple text file to upload with this command.
    Restart-JcSdkSystem.Tests.ps1: Setup Orgs with a device that can be restarted each time
    Remove-JcSdkSystem.Tests.ps1: Disabled untill we can create systems as well
#>
#################################################################
# If V2 is being run then run the V1 tests also because of dependencies
If ($moduleName -eq 'JumpCloud.SDK.V2')
{
    $testFolder = @($testFolder.Replace('V2', 'V1'), $testFolder)
}
$Filter = "*"
$PesterTestFiles = @()
# Populate with test file basenames that need to be run in a specific order
$OrderedTestsSetup = @()
$OrderedTestsMain = @()
$OrderedTestsTakeDown = @('Remove-JcSdkUserSshKey.Tests', 'Remove-JcSdkUser.Tests')
$TestFiles = Get-ChildItem -Path:($testFolder) | Where-Object { $_.BaseName -like "*-JcSdk$($Filter).Tests*" }
# Add "new" tests (Setup Org)
$OrderedTestsSetup | ForEach-Object { $FileBaseName = $_; $PesterTestFiles += $TestFiles | Where-Object { $_.BaseName -eq $FileBaseName }; }
$PesterTestFiles += $TestFiles | Where-Object { $_.BaseName -like "New-*" -and $_.BaseName -notin $OrderedTestsSetup }
# Add all tests that are not "new" and not "remove"
$OrderedTestsMain | ForEach-Object { $FileBaseName = $_; $PesterTestFiles += $TestFiles | Where-Object { $_.BaseName -eq $FileBaseName }; }
$PesterTestFiles += $TestFiles | Where-Object { $_.BaseName -notlike "New-*" -and $_.BaseName -notlike "Remove-*" -and $_.BaseName -notin $OrderedTestsMain }
# Add "remove" tests (Cleanup Org)
$OrderedTestsTakeDown | ForEach-Object { $FileBaseName = $_; $PesterTestFiles += $TestFiles | Where-Object { $_.BaseName -eq $FileBaseName }; }
$PesterTestFiles += $TestFiles | Where-Object { $_.BaseName -like "Remove-*" -and $_.BaseName -notin $OrderedTestsTakeDown }
# Run tests
Invoke-Pester -Script $PesterTestFiles.FullName -EnableExit -OutputFile (Join-Path $testFolder "$moduleName-TestResults.xml")
#################################################################
