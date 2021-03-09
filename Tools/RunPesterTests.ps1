<#
(Get-Command -Name Remove-JcSdkApplication) | ForEach-Object {
    $ParameterName = $_.Name
    $_.ParameterSets | ForEach-Object {
        $Parameters = ($_.Parameters | Sort-Object @{e = 'IsMandatory'; desc = $true }, @{e = 'Name'; desc = $false } | ForEach-Object {
                if ($_.Name -notin ('Fields', 'Filter', 'Sort', 'Search', 'Paginate', 'Break', 'HttpPipelineAppend', 'HttpPipelinePrepend', 'PassThru', 'Proxy', 'ProxyCredential', 'ProxyUseDefaultCredentials', 'CommonParameters', 'WhatIf', 'Confirm', 'Verbose', 'Debug', 'ErrorAction', 'WarningAction', 'InformationAction', 'ErrorVariable', 'WarningVariable', 'InformationVariable', 'OutVariable', 'OutBuffer', 'PipelineVariable'))
                {
                    $ParameterType = If ($_.ParameterType.Name -eq 'switchparameter') { '' }Else { " <$($_.ParameterType.Name.ToLower())>" }
                    If ($_.IsMandatory)
                    {
                        "-$($_.Name)$($ParameterType)"
                    }
                    else
                    {
                        "[-$($_.Name)$($ParameterType)]"
                    }
                }
            }
        ) -join ' '
        Write-Host ("`n$($_.Name): $($ParameterName) $($Parameters)")
    }
}
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
        Username  = "pester.test.$(-join ((65..90) + (97..122) | Get-Random -Count 5 | ForEach-Object { [char]$_ }))"
        FirstName = "Pester"
        LastName  = "Test"
        Password  = "Testing123!"
        Email     = "pester.test@example$(-join ((65..90) + (97..122) | Get-Random -Count 5 | ForEach-Object { [char]$_ })).com"
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

    # Create Application
    # TODO: Switch from get to new
    $global:PesterTestApplication = Get-JcSdkApplication | Select-Object -First 1
    # Get organization
    $global:PesterTestOrganization = Get-JcSdkOrganization
    # Get a System
    $global:PesterTestSystem = Get-JcSdkSystem | Select-Object -First 1
}
If ($moduleName -eq 'JumpCloud.SDK.V2')
{
    # Create a User Group
    $global:PesterDefUserGroup = @{
        Name = 'PesterTestUserGroup'
    }
    # Create a System Group
    $global:PesterDefSystemGroup = @{
        Name = 'PesterTestSystemGroup'
    }
    # Create an Active Directory Object
    # TODO: Make this endpoint public
    $Headers = @{
        'Accept'    = 'application/json';
        'x-api-key' = $env:JCApiKey;
    }
    $Form = @{
        'domain' = "DC=ADTEST{0};DC=ORG" -f [string]( -join ((65..90) + (97..122) | Get-Random -Count 6 | ForEach-Object { [char]$_ }));
    } | ConvertTo-Json
    $global:PesterTestActiveDirectory = Invoke-RestMethod -Method 'Post' -Uri "https://console.jumpcloud.com/api/v2/activedirectories" -Headers $Headers -Body $Form -ContentType 'application/json' -UseBasicParsing

    # Get the Apple MDM
    $global:PesterAppleMDM = Get-JcSdkAppleMdm
    # Get LDAP Server
    $global:PesterLdapServer = Get-JcSdkLdapServer
    # Get all Directories
    $global:PesterTestDirectories = Get-JcSdkDirectory
    $global:PesterTestGSuite = $global:PesterTestDirectories | Where-Object { $_.type -eq "g_suite" } | Select-Object -First 1
    $global:PesterTestOffice365 = $global:PesterTestDirectories | Where-Object { $_.type -eq "office_365" } | Select-Object -First 1
    $global:PesterTestLdap = $global:PesterTestDirectories | Where-Object { $_.type -eq "ldap_server" } | Select-Object -First 1
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

#region Clean Up (This section should ideally be taken care of by the "Remove-" tests)
If ($moduleName -eq 'JumpCloud.SDK.V1')
{
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
}
If ($moduleName -eq 'JumpCloud.SDK.V2')
{
    # Delete an Active Directory Object
    $Headers = @{
        'Accept'    = 'application/json';
        'x-api-key' = $env:JCApiKey
    }
    Invoke-WebRequest -Method 'DELETE' -Uri "https://console.jumpcloud.com/api/v2/activedirectories/$($global:PesterTestActiveDirectory.Id)" -Headers $Headers -ContentType 'application/json' -UseBasicParsing
}
#endregion Clean Up
