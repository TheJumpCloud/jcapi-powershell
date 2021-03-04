Param(
    [Parameter(Mandatory = $true, ValueFromPipelineByPropertyName = $true, Position = 0)][ValidateNotNullOrEmpty()][System.String]$JumpCloudApiKey
    , [Parameter(Mandatory = $true, ValueFromPipelineByPropertyName = $true, Position = 1)][ValidateNotNullOrEmpty()][System.String]$JumpCloudApiKeyMsp
)
# Define variable names
$PesterParamsHash_VariableName = @{
    VariableNamePrefix     = 'PesterParams_';
    VariableNamePrefixHash = 'PesterParamsHash_';
}
# Determine OS type
$OS = If ($env:AGENT_OS)
{
    $env:AGENT_OS
}
Else
{
    If ($PSVersionTable.PSEdition -eq 'Core')
    {
        If ($IsWindows) { 'Windows_NT' }
        ElseIf ($IsMacOS) { 'Darwin' }
        ElseIf ($IsLinux) { 'Linux' }
        Else { Write-Error ('Unknown Operation System') }
    }
    Else
    {
        'Windows_NT'
    }
}
# Parameters that are not Org specific
$PesterParamsHash_Common = @{
    ModuleName                  = 'JumpCloud'
    ModuleManifestName          = 'JumpCloud.psd1'
    ModuleManifestPath          = "$PSScriptRoot/../"
    ApiKey                      = $JumpCloudApiKey
    ApiKeyMsp                   = $JumpCloudApiKeyMsp
    PesterResultsFileXml        = "$($PSScriptRoot)/JumpCloud-$($OS)-TestResults.xml"
    # CSV Files
    Import_JCUsersFromCSV_Tests = "$PSScriptRoot/Csv_Files/import/ImportExample_Pester_Tests.1.0.csv" # This CSV file is specific to pester environment (SystemID's and Group Names)
    JCDeployment_2_CSV          = "$PSScriptRoot/Csv_Files/commandDeployment/JCDeployment_2.csv"
    JCDeployment0_CSV           = "$PSScriptRoot/Csv_Files/commandDeployment/JCDeployment0.csv"
    ImportPath                  = "$PSScriptRoot/Csv_Files/import"
    UpdatePath                  = "$PSScriptRoot/Csv_Files/update"
    # Policy Info
    MultiplePolicyList          = @('1 Linux', 'Disable USB Storage - Linux')
    SinglePolicyList            = @('Disable USB Storage - Linux')
    SystemNameLinux             = 'PesterTest-Linux'
    SystemNameMac               = 'PesterTest-Mac'
    SystemNameWindows           = 'PesterTest-Windows'
}
# Define items
$RandomString = ( -join (( 0x41..0x5A) + ( 0x61..0x7A) | Get-Random -Count 8 | ForEach-Object { [char]$_ }))
$PesterParamsHash_Definitions = @{
    NewSystemUser      = @{
        username                 = "pester.tester_$($RandomString)"
        email                    = "$($RandomString)1@DeleteMe.com"
        employeeIdentifier       = "employeeIdentifier_$($RandomString)"
        allow_public_key         = $false
        password_never_expires   = $true
        NumberOfCustomAttributes = 1
        Attribute1_name          = 'One'
        Attribute1_value         = 'Attr'
        company                  = 'company'
        costCenter               = 'costCenter'
        department               = 'department'
        description              = 'description'
        displayName              = 'displayName'
        employeeType             = 'employeeType'
        firstname                = 'Pester'
        home_city                = 'home_city'
        home_country             = 'home_country'
        home_number              = 'home_number'
        home_poBox               = 'home_poBox'
        home_postalCode          = 'home_postalCode'
        home_state               = 'home_state'
        home_streetAddress       = 'home_streetAddress'
        jobTitle                 = 'jobTitle'
        lastname                 = 'Tester'
        location                 = 'location'
        MiddleName               = 'middlename'
        mobile_number            = 'mobile_number'
        work_city                = 'work_city'
        work_country             = 'work_country'
        work_fax_number          = 'work_fax_number'
        work_mobile_number       = 'work_mobile_number'
        work_number              = 'work_number'
        work_poBox               = 'work_poBox'
        work_postalCode          = 'work_postalCode'
        work_state               = 'work_state'
        work_streetAddress       = 'work_streetAddress'
    };
    NewSystemGroup     = @{
        GroupName = 'PesterTest_SystemGroup'
    };
    NewSystemUserGroup = @{
        GroupName = 'PesterTest_UserGroup'
    };
    NewRadiusServer    = @{
        name                  = 'PesterTest_RadiusServer'
        sharedSecret          = 'f3TkHSK2GT4JR!W9tugRPp2zQnAVObv'
        networkSourceIp       = If ($env:USERNAME -ne 'VssAdministrator') { [IPAddress]::Parse([String](Get-Random)).IPAddressToString }
        ElseIf ($OS -eq 'Windows_NT') { '250.250.250.250' }
        ElseIf ($OS -eq 'Darwin') { '250.251.250.251' }
        ElseIf ($OS -eq 'Linux') { '250.252.250.252' }
        Else { Write-Error ("Unknown OS: $($OS)") }
        networkSourceIpUpdate = If ($env:USERNAME -ne 'VssAdministrator') { [IPAddress]::Parse([String](Get-Random)).IPAddressToString }
        ElseIf ($OS -eq 'Windows_NT') { '250.250.250.251' }
        ElseIf ($OS -eq 'Darwin') { '250.251.250.252' }
        ElseIf ($OS -eq 'Linux') { '250.252.250.253' }
        Else { Write-Error ("Unknown OS: $($OS)") }
    };
    NewCommand         = @{
        name        = 'GetJCAgentLog'
        trigger     = 'GetJCAgentLog'
        commandType = 'linux'
        command     = 'cat /opt/jc/*.log'
        launchType  = 'trigger'
        timeout     = 120
    };
    NewPolicy          = @{
        Name       = 'PesterTest_Policy'
        TemplateId = ((Get-JcSdkPolicyTemplate)[0].Id)
    }
};
# Combine all hash tables into one list and foreach of their values create a new global parameter
(Get-Variable -Scope:('Script') -Name:("$($PesterParamsHash_VariableName.VariableNamePrefixHash)*")).Value | ForEach-Object {
    $_.GetEnumerator() | ForEach-Object {
        Set-Variable -Name:("$($PesterParamsHash_VariableName.VariableNamePrefix)$($_.Name)") -Value:($_.Value) -Scope:('Global')
    }
}

Get-Command -Module JumpCloud.SDK.V1 | Select-Object verb, Noun -Unique
Get    JcSdkApplication
Get    JcSdkApplicationTemplate
Get    JcSdkCommand
Get    JcSdkCommandFile
Get    JcSdkCommandResult
Get    JcSdkOrganization
Get    JcSdkRadiusServer
Get    JcSdkSystem
Get    JcSdkSystemUser
Get    JcSdkSystemUserSshKey
Invoke JcSdkCommandTrigger
Invoke JcSdkExpireSystemUserPassword
New    JcSdkApplication
New    JcSdkCommand
New    JcSdkRadiusServer
New    JcSdkSystemUser
New    JcSdkSystemUserSshKey
Remove JcSdkApplication
Remove JcSdkCommand
Remove JcSdkCommandResult
Remove JcSdkRadiusServer
Remove JcSdkSystem
Remove JcSdkSystemUser
Remove JcSdkSystemUserSshKey
Reset  JcSdkSystemUserMfa
Search JcSdkOrganization
Search JcSdkSystem
Search JcSdkSystemUser
Set-Variable    JcSdkApplication
Set-Variable    JcSdkCommand
Set-Variable    JcSdkOrganization
Set-Variable    JcSdkRadiusServer
Set-Variable    JcSdkSystem
Set-Variable    JcSdkSystemUser
Unlock JcSdkSystemUser