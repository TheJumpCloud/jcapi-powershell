# PowerShell Dependencies
#TODO: get latest of these other modules
$PSDependencies = @{
    'AWS.Tools.CodeArtifact' = @{Repository = 'PSGallery'; RequiredVersion = '4.1.14.0' }
    'AWS.Tools.Common'       = @{Repository = 'PSGallery'; RequiredVersion = '4.1.14.0' }
    'BuildHelpers'           = @{Repository = 'PSGallery'; RequiredVersion = '2.0.15'}
    'Pester'                 = @{Repository = 'PSGallery'; RequiredVersion = '4.10.1'}
    'powershell-yaml'        = @{Repository = 'PSGallery'; RequiredVersion = '0.4.2'}
    'PowerShellGet'          = @{Repository = 'PSGallery'; RequiredVersion = '3.0.12-beta'}
    'PSScriptAnalyzer'       = @{Repository = 'PSGallery'; RequiredVersion = '1.19.1'}
}
foreach ($RequiredModule in $PSDependencies.Keys) {
    Write-Host("[status]Installing module: '$RequiredModule'; version: $($PSDependencies[$RequiredModule].RequiredVersion) from $($PSDependencies[$RequiredModule].Repository)")
    Install-Module -Name $RequiredModule -Repository:($($PSDependencies[$RequiredModule].Repository)) -RequiredVersion:($($PSDependencies[$RequiredModule].RequiredVersion)) -AllowPrerelease -Force
}
# NPM Dependencies
If ($env:CI -eq $false)
{
    Write-Host ('[RUN COMMAND] npm install -g dotnet-sdk-3.1') -BackgroundColor:('Black') -ForegroundColor:('Magenta')
    If ($IsWindows) { npm install -g dotnet-sdk-3.1-win-x64 }
    ElseIf ($IsMacOS) { npm install -g dotnet-sdk-3.1-osx-x64 }
    ElseIf ($IsLinux) { npm install -g dotnet-sdk-3.1-linux-x64 }
    Else { Write-Error ('Unknown Operation System') }
}
# Install NPM Dependencies from packages.json
npm install

Import-Module 'Tools/New-SdkChangelog.ps1' -Force