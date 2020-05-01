# $env:JCApiKey = ''
# $env:JCOrgId = ''
$OtherModuleNames = @('JumpCloud')
$global:ModuleNames = @('JumpCloud.SDK.V1', 'JumpCloud.SDK.V2', 'JumpCloud.SDK.DirectoryInsights')
$global:ModulePrefix = 'JcSdk'
# Remove module from session
If (Get-Module -Name $ModuleNames) { Get-Module -Name $ModuleNames | Remove-Module -Force }
# Uninstall module from system
If (Get-InstalledModule -Name $ModuleNames -ErrorAction SilentlyContinue) { Get-InstalledModule -Name $ModuleNames -ErrorAction SilentlyContinue | Uninstall-Module -AllVersions -Force }
$Error.Clear()
ForEach ($ModuleName In $ModuleNames + $OtherModuleNames)
{
    If ((Find-Module -Name:($ModuleName)) -and $env:USERNAME -eq 'VssAdministrator')
    {
        # Install module from PowerShell Gallery
        Write-Host ("[Status]Installing/Importing module: $ModuleName") -BackgroundColor:('Black') -ForegroundColor:('Gray')
        Install-Module -Name $ModuleName -Force
        Import-Module -Name $ModuleName -Force -Scope:('Global')
    }
    Else
    {
        # Import module from local file system
        $ScriptRoot = Get-Item -Path:($PSScriptRoot)
        $GitHubRoot = $ScriptRoot.Parent.Parent.FullName
        $RepoName = If ($ModuleName -in ('JumpCloud.SDK.V1', 'JumpCloud.SDK.V2', 'JumpCloud.SDK.DirectoryInsights'))
        {
            'jcapi-powershell'
        }
        ElseIf ($ModuleName -in ('JumpCloud'))
        {
            'support'
        }
        Else
        {
            Write-Error ('Unknown module name: ' + $ModuleName)
        }
        $ModulePsd1 = (Get-ChildItem -Path:("$GitHubRoot\$RepoName") -Recurse | Where-Object { $_.Name -eq "$ModuleName.psd1" -and $_.FullName -notlike '*bin*' }).FullName | Select-Object -Unique
        If (Test-Path -Path:($ModulePsd1))
        {
            Write-Host ("[Status]Importing module: $ModulePsd1") -BackgroundColor:('Black') -ForegroundColor:('Gray')
            Import-Module $ModulePsd1 -Force -Scope:('Global')
        }
        Else
        {
            Write-Error ('Path does not exist:' + $ModulePsd1)
        }
    }
}
