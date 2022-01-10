# PowerShell Dependencies
$PSDependencies = @{
    'AWS.Tools.CodeArtifact' = @{Repository = 'PSGallery'; RequiredVersion = ''}
    'AWS.Tools.Common'       = @{Repository = 'PSGallery'; RequiredVersion = '' }
    'BuildHelpers'           = @{Repository = 'PSGallery'; RequiredVersion = ''}
    'Pester'                 = @{Repository = 'PSGallery'; RequiredVersion = '4.10.1'}
    'powershell-yaml'        = @{Repository = 'PSGallery'; RequiredVersion = ''}
    'PowerShellGet'          = @{Repository = 'PSGallery'; RequiredVersion = '3.0.0-beta10'}
    'PSScriptAnalyzer'       = @{Repository = 'PSGallery'; RequiredVersion = '1.19.1'}
}
foreach ($RequiredModule in $PSDependencies.Keys) {
    If (Get-InstalledModule -Name:($RequiredModule) -ErrorAction:('SilentlyContinue'))
    {
        Write-Host("[status]Updating module: '$RequiredModule' from $($PSDependencies[$RequiredModule].Repository)")
        # Update-Module -Name:($RequiredModule) -Force
    }
    # If module version is specified:
    If ($($PSDependencies[$RequiredModule].RequiredVersion)) {
        Write-Host("[status]Installing module: '$RequiredModule'; version: $($PSDependencies[$RequiredModule].RequiredVersion) from $($PSDependencies[$RequiredModule].Repository)")
        # Install-Module -Name $RequiredModule -Repository:($($PSDependencies[$RequiredModule].Repository)) -RequiredVersion:($($PSDependencies[$RequiredModule].RequiredVersion)) -AllowPrerelease -Force
    }
    else{
        Write-Host("[status]Installing module: '$RequiredModule' from $($PSDependencies[$RequiredModule].Repository)")
        # Install-Module -Name:($RequiredModule) -Repository:($($PSDependencies[$RequiredModule].Repository)) -Force
    }
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
npm install -g autorest@3.4.2
autorest --reset
# autorest --help