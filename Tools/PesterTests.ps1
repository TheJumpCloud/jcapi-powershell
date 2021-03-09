<#
(Get-Command -Syntax -Name Invoke-JcSdkCommandTrigger) | ForEach-Object { $_.Replace('[-Fields <string>]', '').Replace('[-Filter <string>]', '').Replace('[-Sort <string>]', '').Replace('[-Search <string>]', '').Replace('[-Paginate <bool>]', '').Replace('[-Break]', '').Replace('[-HttpPipelineAppend <SendAsyncStep[]>]', '').Replace('[-HttpPipelinePrepend <SendAsyncStep[]>]', '').Replace('[-PassThru]', '').Replace('[-Proxy <uri>]', '').Replace('[-ProxyCredential <pscredential>]', '').Replace('[-ProxyUseDefaultCredentials]', '').Replace('[<CommonParameters>]', '').Replace('[-WhatIf]', '').Replace('[-Confirm]', '') }
TODO:
    Clear-JcSdkSystem.Tests.ps1: Setup Orgs with a device that can be cleared each time
    Get-JcSdkCommandFile.Tests.ps1: Configure New-JcSdkCommand test to upload a simple text file
    Invoke-JcSdkCommandTrigger.Tests.ps1: Configure a command with a 'trigger' launchType
    Lock-JcSdkSystem.Tests.ps1: Setup Orgs with a device that can be locked each time
    New-JcApplication.Tests.ps1: Figure out how to configure an Application from the SDK
    New-JcSdkCommand.Tests.ps1: Configure a simple text file to upload with this command.
    Restart-JcSdkSystem.Tests.ps1: Setup Orgs with a device that can be restarted each time
    Remove-JcSdkSystem.Tests.ps1: Disabled untill we can also create systems
#>
$testFolder = $testFolder # .\jcapi-powershell\SDKs\PowerShell\JumpCloud.SDK.V1\test
$moduleName = $moduleName # JumpCloud.SDK.V1
#region Define Objects
If ($moduleName -eq 'JumpCloud.SDK.V1' -or $moduleName -eq 'JumpCloud.SDK.V2')
{
    # Create a command
    $global:PesterDefCommand = @{
        Name    = 'PesterTestCommand'
        Command = 'echo "Hello World"'
        User    = '000000000000000000000000'
    }
    # Create a user
    $global:PesterDefUser = @{
        Username  = "pester.test.$(-join ((33..126) | Get-Random -Count 5 | ForEach-Object { [char]$_ }))"
        FirstName = "Pester"
        LastName  = "Test"
        Password  = "Testing123!"
        Email     = "pester.test@example$(-join ((33..126) | Get-Random -Count 5 | ForEach-Object { [char]$_ })).com"
    }
    # Create a user ssh key
    $global:PesterDefUserSshKey = @{
        Id        = $null # Defined later in New-JcSdkUserSshKey.Tests.ps1
        Name      = 'PesterTestUserSshKeyName'
        PublicKey = 'PesterTestUserSshKeyPublicKey'
    }
    # Create a RADIUS Server
    $global:PesterDefRadiusServer = @{
        Name            = "PesterTestRadiusServer"
        SharedSecret    = "Testing123!"
        NetworkSourceIP = [IPAddress]::Parse([String](Get-Random)).IPAddressToString
    }
    # Get organization
    $global:PesterTestOrganization = Get-JcSdkOrganization
    # Get a System
    $global:PesterTestSystem = Get-JcSdkSystem | Select-Object -First 1
}
ElseIf ($moduleName -eq 'JumpCloud.SDK.V2')
{

}
#endregion Define Objects

#region Run Pester Tests
# If V2 is being run then run the V1 tests also because of dependencies
$moduleTestFolder = If ($moduleName -eq 'JumpCloud.SDK.V2')
{
    @($testFolder.Replace('V2', 'V1'), $testFolder)
}
else
{
    $testFolder
}
$Filter = "*"
$PesterTestFiles = @()
# Populate with test file basenames that need to be run in a specific order
$OrderedTestsSetup = @()
$OrderedTestsMain = @()
$OrderedTestsTakeDown = @('Remove-JcSdkUserSshKey.Tests', 'Remove-JcSdkUser.Tests')
$TestFiles = Get-ChildItem -Path:($moduleTestFolder) | Where-Object { $_.BaseName -like "*-JcSdk$($Filter).Tests*" }
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
#endregion Run Pester Tests

# #region Clean Up
# If ($moduleName -eq 'JumpCloud.SDK.V1')
# {
#     # Remove Commands
#     $null = Get-JcSdkCommand | ForEach-Object { Remove-JcSdkCommand -Id:($_.Id) }
#     # Remove Users and SSH Keys
#     $null = Get-JcSdkUser | ForEach-Object {
#         $UserId = $_.Id
#         If ( $_.ExternallyManaged )
#         {
#             Set-JcSdkUser -Id:($UserId) -ExternallyManaged:($false)
#         }
#         If ($_.SshKeys)
#         {
#             $_.SshKeys | ForEach-Object {
#                 Remove-JcSdkUserSshKey -Id:($_.Id) -SystemuserId:($UserId)
#             }
#         }
#         Remove-JcSdkUser -Id:($UserId)
#     }
#     # Remove RADIUS Servers
#     $null = Get-JcSdkRadiusServer | ForEach-Object { Remove-JcSdkRadiusServer -Id:($_.Id) }
# }
# #endregion Clean Up
