#################################################################
$Filter = "*"
$PesterTestFiles = @()
# Populate with test file basenames that need to be run in a specific order
$OrderedTests = @()
$TestFiles = Get-ChildItem -Path:($testFolder) | Where-Object { $_.BaseName -like "*-JcSdk$($Filter).Tests*" }
# Add "new" tests (Setup Org)
$PesterTestFiles += $TestFiles | Where-Object { $_.BaseName -like "New-*" }
# Add all tests that are in the $OrderedTests list
$PesterTestFiles += $TestFiles | Where-Object { $_.BaseName -in $OrderedTests }
# Add all tests that are not "new" and not "remove" and not in the $OrderedTests list
$PesterTestFiles += $TestFiles | Where-Object { $_.BaseName -notlike "New-*" -and $_.BaseName -notlike "Remove-*" -and $_.BaseName -notin $OrderedTests }
# Add "remove" tests (Cleanup Org)
$PesterTestFiles += $TestFiles | Where-Object { $_.BaseName -like "Remove-*" }
# Run tests
Invoke-Pester -Script $PesterTestFiles.FullName -EnableExit -OutputFile (Join-Path $testFolder "$moduleName-TestResults.xml")
#################################################################