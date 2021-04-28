# PowerShell Dependencies
$RequiredModules = ('PSScriptAnalyzer', 'powershell-yaml', 'BuildHelpers')
ForEach ($RequiredModule In $RequiredModules)
{
    # Check to see if the module is installed
    If (Get-InstalledModule -Name:($RequiredModule) -ErrorAction:('SilentlyContinue'))
    {
        Update-Module -Name:($RequiredModule) -Force
    }
    # Check to see if the module exists on the PSGallery
    ElseIf (Find-Module -Name:($RequiredModule))
    {
        Install-Module -Name:($RequiredModule) -Force
    }
    Import-Module -Name:($RequiredModule) -Force
}
Install-Module -Name Pester -RequiredVersion '4.10.1' -Force
# NPM Dependencies
If ($env:CI -eq $false)
{
    Write-Host ('[RUN COMMAND] npm install -g dotnet-sdk-3.1') -BackgroundColor:('Black') -ForegroundColor:('Magenta')
    If ($IsWindows) { npm install -g dotnet-sdk-3.1-win-x64 }
    ElseIf ($IsMacOS) { npm install -g dotnet-sdk-3.1-osx-x64 }
    ElseIf ($IsLinux) { npm install -g dotnet-sdk-3.1-linux-x64 }
    Else { Write-Error ('Unknown Operation System') }
}
npm install -g autorest@latest
autorest --reset
# autorest --help
