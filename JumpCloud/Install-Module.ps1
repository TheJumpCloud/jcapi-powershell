$env:JCApiKey = ''
$env:JCOrgId = ''
$global:ModuleNames = @('JumpCloud.SDK.V1', 'JumpCloud.SDK.V2', 'JumpCloud.SDK.DirectoryInsights')
$global:ModulePrefix = 'JcSdk'
If (Get-Module -Name $ModuleNames) { Get-Module -Name $ModuleNames | Remove-Module -Force }
If (Get-InstalledModule -Name $ModuleNames -ErrorAction SilentlyContinue) { Get-InstalledModule -Name $ModuleNames -ErrorAction SilentlyContinue | Uninstall-Module -AllVersions -Force }
ForEach ($ModuleName In $ModuleNames)
{
    Install-Module -Name $ModuleName -Force -Scope:('CurrentUser')
    Import-Module -Name $ModuleName -Force
    # Get-Module -Name $ModuleName
}
$Error.Clear()