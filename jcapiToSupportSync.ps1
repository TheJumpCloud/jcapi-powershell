#Requires -PSEdition Core
$GitHubRoot = '' #ex: C:/Users/epanipinto/Documents/GitHub
$env:moduleRootFolder = "$GitHubRoot/support/PowerShell"
$env:deployFolder = "$env:moduleRootFolder/Deploy"
$env:MODULENAME = 'JumpCloud'
$env:MODULEFOLDERNAME = 'JumpCloud Module'
$env:RELEASETYPE = 'Minor'
$env:XAPIKEY_PESTER = 'ff6006d0cd75d4c52eacf9da2aa7205595ef97bf'
$env:XAPIKEY_MTP = '70a96c7196db6d4dac8a375b32686d07a641d671'
####################################################################################
####################################################################################
$AutoRest_Example = "$GitHubRoot/jcapi-powershell/AutoRest/SDKs/PowerShell/JumpCloud.SDK.DirectoryInsights/examples/Get-JcSdkEvent.md"
$AutoRest_Function = "$GitHubRoot/jcapi-powershell/AutoRest/SDKs/PowerShell/JumpCloud.SDK.DirectoryInsights/exports/Get-JcSdkEvent.ps1"
$AutoRest_HelpFile = "$GitHubRoot/jcapi-powershell/AutoRest/SDKs/PowerShell/JumpCloud.SDK.DirectoryInsights/docs/exports/Get-JcSdkEvent.md"
$AutoRest_Tests = "$GitHubRoot/jcapi-powershell/AutoRest/SDKs/PowerShell/JumpCloud.SDK.DirectoryInsights/test/Get-JcSdkEvent.Tests.ps1"
$Transformed_Function = "$GitHubRoot/jcapi-powershell/JumpCloud/JumpCloudV2/Get/Get-JCEvent.ps1"
$JCModule_Function = "$GitHubRoot/support/PowerShell/JumpCloud Module/Public/DirectoryInsights/Get-JCEvent.ps1"
$JCModule_HelpFile = "$GitHubRoot/support/PowerShell/JumpCloud Module/Docs/Get-JCEvent.md"
$JCModule_Tests = "$GitHubRoot/support/PowerShell/JumpCloud Module/Tests/Public/DirectoryInsights/Get-JCEvent.Tests.ps1"
# Invoke-Item -Path:($JCModule_Function)
####################################################################################
####################################################################################
.("$GitHubRoot/jcapi-powershell/AutoRest/SetupDependencies.ps1")
.("$GitHubRoot/jcapi-powershell/AutoRest/BuildAutoRest.ps1")
# Restart your PowerShell session
####################################################################################
####################################################################################
.("$GitHubRoot/jcapi-powershell/JumpCloud/Install-Module.ps1")
.("$GitHubRoot/jcapi-powershell/JumpCloud/Build-Module.ps1")
Copy-Item -Path:($Transformed_Function) -Destination:($JCModule_Function) -Force
Copy-Item -Path:($AutoRest_Tests) -Destination:($JCModule_Tests) -Force
(Get-Content -Path:($JCModule_Tests) -Raw).Replace('JcSdk', 'JC').Replace('.ToJsonString() | ConvertFrom-Json', '').Replace("Describe 'Get-JCEvent'", "Describe 'Get-JCEvent' -Tag:('JCEvent')").Replace('$loadEnvPath = Join-Path $PSScriptRoot ''loadEnv.ps1''
if (-Not (Test-Path -Path $loadEnvPath))
{
    $loadEnvPath = Join-Path $PSScriptRoot ''..\loadEnv.ps1''
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot ''Get-JCEvent.Recording.json''
$currentPath = $PSScriptRoot
while (-not $mockingPath)
{
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include ''HttpPipelineMocking.ps1'' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

', '') | Set-Content -Path:($JCModule_Tests)
Remove-Item -Path:($JCModule_HelpFile)
# Pipeline Steps
.("$env:deployFolder/Build-Module.ps1")
.("$env:deployFolder/Build-HelpFiles.ps1")
.("$env:deployFolder/Build-PesterTestFiles.ps1")
.("$env:moduleRootFolder/JumpCloud Module/Tests/InvokePester.ps1") -TestOrgAPIKey:($env:XAPIKEY_PESTER) -MultiTenantAPIKey:($env:XAPIKEY_MTP) -IncludeTagList:('ModuleValidation')
.("$env:moduleRootFolder/JumpCloud Module/Tests/InvokePester.ps1") -TestOrgAPIKey:($env:XAPIKEY_PESTER) -MultiTenantAPIKey:($env:XAPIKEY_MTP) -ExcludeTagList:('ModuleValidation', 'JCAssociation', 'JCUsersFromCSV') # -IncludeTagList:('')
####################################################################################
####################################################################################
