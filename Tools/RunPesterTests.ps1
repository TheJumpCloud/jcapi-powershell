<#
(Get-Command -Name New-JcSdkPolicy) | ForEach-Object {
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
    Reset-JcSdkUserMfa.Tests.ps1: Configure MFA for $global:PesterTestUser
    New-JcSdkDuoApplication.Tests.ps1: Set up DUO in Pester Orgs
#>
$testFolder = $testFolder # .\jcapi-powershell\SDKs\PowerShell\JumpCloud.SDK.V1\test
$moduleName = $moduleName # JumpCloud.SDK.V1
#region Import Modules
If ($moduleName -eq 'JumpCloud.SDK.V2')
{
    Import-Module -Name $modulePath.Replace('JumpCloud.SDK.V2', 'JumpCloud.SDK.V1') -Force
}
#endregion Import Modules
#region Define Objects
If ($moduleName -eq 'JumpCloud.SDK.V1' -or $moduleName -eq 'JumpCloud.SDK.V2')
{
    # Get a ApplicationTemplate
    $global:PesterTestApplicationTemplate = Get-JcSdkApplicationTemplate | Select-Object -First 1
    # Get a CommandResult
    $global:PesterTestCommandResult = Get-JcSdkCommandResult | Select-Object -First 1
    # Get Organization
    $global:PesterTestOrganization = Get-JcSdkOrganization
    # Get a System
    $global:PesterTestSystem = Get-JcSdkSystem | Select-Object -First 1

    # # Create a Application
    # $global:PesterDefApplication = @{
    #     Name   = 'dropbox'
    #     ssoUrl = 'https://sso.jumpcloud.com/saml2/dropbox'
    #     config = @{}
    # }
    # TODO: Switch from get to new
    $global:PesterTestApplication = Get-JcSdkApplication | Select-Object -First 1
    # Create a Command
    $global:PesterDefCommand = @{
        Name        = "PesterTestCommand-$(-join ((65..90) + (97..122) | Get-Random -Count 5 | ForEach-Object { [char]$_ }))"
        Command     = 'echo "Hello World"'
        User        = "000000000000000000000000"
        launchType  = "trigger"
        trigger     = "PesterTestTrigger"
        commandType = "windows"
    }
    # Trying to create a command, assign it to systems, and run it
    # $NewCommand = New-JcSdkCommand @global:PesterDefCommand
    # $global:PesterTestCommand = Get-JcSdkCommand | Where-Object { $_.Name -eq $NewCommand.Name } | Select-Object -First 1
    # $global:PesterDefCommand.Id = $global:PesterTestCommand.Id
    # $global:PesterDefCommand.Systems = Get-JcSdkSystem | Where-Object { $_.os -eq $global:PesterDefCommand.commandType } | Select-Object -ExpandProperty Id
    # Set-JcSdkCommand @global:PesterDefCommand
    # Invoke-JcSdkCommandTrigger @global:PesterDefCommand.trigger
    # Create a User
    $global:PesterDefUser = @{
        Username  = "pester.test.$(-join ((65..90) + (97..122) | Get-Random -Count 5 | ForEach-Object { [char]$_ }))"
        FirstName = "Pester"
        LastName  = "Test"
        Password  = "Testing123!"
        Email     = "pester.test@example$(-join ((65..90) + (97..122) | Get-Random -Count 5 | ForEach-Object { [char]$_ })).com"
    }
    # Create a User SSH Key
    $global:PesterDefUserSshKey = @{
        Id        = $null # Defined later in New-JcSdkUserSshKey.Tests.ps1
        Name      = "PesterTestUserSshKeyName"
        PublicKey = "PesterTestUserSshKeyPublicKey"
    }
    # Create a RADIUS Server
    $global:PesterDefRadiusServer = @{
        Name            = "PesterTestRadiusServer-$(-join ((65..90) + (97..122) | Get-Random -Count 5 | ForEach-Object { [char]$_ }))"
        SharedSecret    = "Testing123!"
        NetworkSourceIP = [IPAddress]::Parse([String](Get-Random)).IPAddressToString
    }
}
If ($moduleName -eq 'JumpCloud.SDK.V2')
{
    # Get the Apple MDM
    $global:PesterTestAppleMDM = Get-JcSdkAppleMdm | Select-Object -First 1
    # Get LDAP Server
    $global:PesterTestLdapServer = Get-JcSdkLdapServer | Select-Object -First 1
    # Get all Directories
    $global:PesterTestDirectories = Get-JcSdkDirectory
    $global:PesterTestGSuite = $global:PesterTestDirectories | Where-Object { $_.type -eq "g_suite" } | Select-Object -First 1
    $global:PesterTestOffice365 = $global:PesterTestDirectories | Where-Object { $_.type -eq "office_365" } | Select-Object -First 1
    $global:PesterTestLdap = $global:PesterTestDirectories | Where-Object { $_.type -eq "ldap_server" } | Select-Object -First 1
    # Get a Policy Template
    $global:PesterTestPolicyTemplate = Get-JcSdkPolicyTemplate | Select-Object -First 1
    # Create an ActiveDirectory
    $global:PesterDefActiveDirectory = @{
        'domain' = "DC=ADTEST{0};DC=ORG" -f [string]( -join ((65..90) + (97..122) | Get-Random -Count 6 | ForEach-Object { [char]$_ }));
    }
    # TODO: Make this endpoint public
    $global:PesterTestActiveDirectory = Invoke-RestMethod -Method 'Post' -Uri "https://console.jumpcloud.com/api/v2/activedirectories" -Headers:(@{'Accept' = 'application/json'; 'x-api-key' = $env:JCApiKey; }) -Body:($global:PesterDefActiveDirectory | ConvertTo-Json) -ContentType:('application/json') -UseBasicParsing
    # Create a Authentication Policy
    $global:PesterDefAuthenticationPolicy = @{
        Name                = "AuthenticationPolicy-$(-join ((65..90) + (97..122) | Get-Random -Count 5 | ForEach-Object { [char]$_ }))"
        EffectAction        = 'allow'
        TargetResources     = @{"type" = "user_portal" }
        UserGroupInclusions = $null # Defined later in New-JcSdkAuthenticationPolicy.Tests.ps1
    }
    # Create a Custom Email Configuration
    $global:PesterDefCustomEmailConfiguration = @{
        Type    = 'password_reset_confirmation'
        # Having multiple breaks remove tests
        # Type    = Get-Random @('password_reset_confirmation', 'password_expiration_warning', 'lockout_notice_user', 'password_expiration', 'user_change_password')
        Subject = "CUSTOM"
    }
    # Create a GSuite Translation Rule
    $global:PesterDefGSuiteTranslationRule = @{
        GsuiteId = $global:PesterTestGSuite.Id
        BuiltIn  = 'user_work_addresses'
    }
    # Create a IP List
    $global:PesterDefIPList = @{
        Description = 'PesterIpList'
        Ips         = [IPAddress]::Parse([String](Get-Random)).IPAddressToString
        Name        = "Pester IP Test List $(-join ((65..90) + (97..122) | Get-Random -Count 5 | ForEach-Object { [char]$_ }))"
    }
    # Create a LdapServer
    $global:PesterDefLdapServer = @{
        Id                           = $PesterTestLdapServer.Id
        Name                         = "jumpcloud"
        UserLockoutAction            = "remove"
        UserPasswordExpirationAction = "remove"
    }
    # Create a Office365 Translation Rule
    $global:PesterDefOffice365TranslationRule = @{
        Office365Id = $global:PesterTestOffice365.Id
        BuiltIn     = 'user_street_address'
    }
    # Create a Policy
    $global:PesterDefPolicy = Get-Random @(
        @{
            Name       = "Pester_Windows - $(-join ((65..90) + (97..122) | Get-Random -Count 5 | ForEach-Object { [char]$_ }))"
            TemplateId = (Get-JcSdkPolicyTemplate | Where-Object { $_.OSMetaFamily -eq 'windows' } | Select-Object -First 1).Id
        },
        @{
            Name       = "Pester_Linux - $(-join ((65..90) + (97..122) | Get-Random -Count 5 | ForEach-Object { [char]$_ }))"
            TemplateId = (Get-JcSdkPolicyTemplate | Where-Object { $_.OSMetaFamily -eq 'linux' } | Select-Object -First 1).Id
        },
        @{
            Name       = "Pester_Darwin - $(-join ((65..90) + (97..122) | Get-Random -Count 5 | ForEach-Object { [char]$_ }))"
            TemplateId = (Get-JcSdkPolicyTemplate | Where-Object { $_.OSMetaFamily -eq 'darwin' } | Select-Object -First 1).Id
        }
    )
    # Create a Software App
    $global:PesterDefSoftwareApp = @{
        DisplayName = "Adobe Reader"
        Settings    = @{PackageId = 'adobereader' }
    }
    # Create a User Group
    $global:PesterDefUserGroup = @{
        Name = "PesterTestUserGroup-$(-join ((65..90) + (97..122) | Get-Random -Count 5 | ForEach-Object { [char]$_ }))"
    }
    # Create a System Group
    $global:PesterDefSystemGroup = @{
        Name = "PesterTestSystemGroup-$(-join ((65..90) + (97..122) | Get-Random -Count 5 | ForEach-Object { [char]$_ }))"
    }
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
$OrderedTestsSetup = @('New-JcSdkUserGroup.Tests', 'New-JcSdkAuthenticationPolicy.Tests', 'New-JcSdkCommand.Tests', 'Invoke-JcSdkCommandTrigger.Tests')
$OrderedTestsUpdate = @()
$OrderedTestsMain = @('Lock-JcSdkUser.Tests', 'Unlock-JcSdkUser.Tests')
$OrderedTestsTakeDown = @('Remove-JcSdkUserSshKey.Tests', 'Remove-JcSdkUser.Tests')
$TestFiles = Get-ChildItem -Path:($moduleTestFolder) -Recurse | Where-Object { $_.BaseName -like "*$($Filter).Tests*" }
# Add "New" tests (Setup Org)
$OrderedTestsSetup | ForEach-Object { $FileBaseName = $_; $PesterTestFiles += $TestFiles | Where-Object { $_.BaseName -eq $FileBaseName }; }
$PesterTestFiles += $TestFiles | Where-Object { $_.BaseName -like "New-*" -and $_.BaseName -notin $PesterTestFiles.BaseName }
# Add "Set" tests (Setup Org)
$OrderedTestsUpdate | ForEach-Object { $FileBaseName = $_; $PesterTestFiles += $TestFiles | Where-Object { $_.BaseName -eq $FileBaseName }; }
$PesterTestFiles += $TestFiles | Where-Object { $_.BaseName -like "Set-*" -and $_.BaseName -notin $PesterTestFiles.BaseName }
# Add tests that are not "Get" or "Remove" (Setup Org)
$OrderedTestsUpdate | ForEach-Object { $FileBaseName = $_; $PesterTestFiles += $TestFiles | Where-Object { $_.BaseName -eq $FileBaseName }; }
$PesterTestFiles += $TestFiles | Where-Object { $_.BaseName -notlike "Get-*" -and $_.BaseName -notlike "Remove-*" -and $_.BaseName -notin $PesterTestFiles.BaseName }
# # Add "Get" tests (Setup Org)
$OrderedTestsMain | ForEach-Object { $FileBaseName = $_; $PesterTestFiles += $TestFiles | Where-Object { $_.BaseName -eq $FileBaseName }; }
$PesterTestFiles += $TestFiles | Where-Object { $_.BaseName -like "Get-*" -and $_.BaseName -notin $PesterTestFiles.BaseName }
# Add "Remove" tests (Cleanup Org)
$OrderedTestsTakeDown | ForEach-Object { $FileBaseName = $_; $PesterTestFiles += $TestFiles | Where-Object { $_.BaseName -eq $FileBaseName }; }
$PesterTestFiles += $TestFiles | Where-Object { $_.BaseName -like "Remove-*" -and $_.BaseName -notin $PesterTestFiles.BaseName }
# Run tests
Invoke-Pester -Script $PesterTestFiles.FullName -EnableExit -OutputFile (Join-Path $testFolder "$moduleName-TestResults.xml") -OutputFormat:('JUnitXml')
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
    # Delete a ActiveDirectory
    Invoke-WebRequest -Method 'DELETE' -Uri "https://console.jumpcloud.com/api/v2/activedirectories/$($global:PesterTestActiveDirectory.Id)" -Headers:(@{'Accept' = 'application/json'; 'x-api-key' = $env:JCApiKey }) -ContentType 'application/json' -UseBasicParsing
    # Remove-JcSdkCustomEmailConfiguration -CustomEmailType:('password_reset_confirmation')
    # Remove-JcSdkGSuiteTranslationRule -GsuiteId:((Get-JcSdkDirectory | Where-Object { $_.type -eq "g_suite" } | Select-Object -First 1).id) -Id:((Get-JcSdkGSuiteTranslationRule -GsuiteId:((Get-JcSdkDirectory | Where-Object { $_.type -eq "g_suite" } | Select-Object -First 1).id)).id)
    # Remove-JcSdkOffice365TranslationRule -Office365Id:((Get-JcSdkDirectory | Where-Object { $_.type -eq "office_365" } | Select-Object -First 1).id) -Id:((Get-JcSdkOffice365TranslationRule -Office365Id:((Get-JcSdkDirectory | Where-Object { $_.type -eq "office_365" } | Select-Object -First 1).id)).id)
}
#endregion Clean Up
