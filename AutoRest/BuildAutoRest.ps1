# Requires -Modules 'powershell-yaml'
# https://github.com/Azure/autorest/blob/master/docs/powershell/options.md
$InstallPreReq = $true
$GenerateModule = $true
$CopyModuleFile = $true
$BuildModule = $true
$PackModule = $true
$PublishModule = $true
$InstallModule = $false
$ImportModule = $false
$ConfigFolderPath = '{0}/Configs' -f $PSScriptRoot
# Run API Transform step
.($PSScriptRoot + '/ApiTransform.ps1')
# Start SDK generation
Get-ChildItem -Path:('{0}/V*.yaml' -f $ConfigFolderPath) -Directory:($false) | ForEach-Object {
    # Get-ChildItem -Path:('{0}/V1.yaml' -f $ConfigFolderPath) -Directory:($false) | ForEach-Object {
    # Get-ChildItem -Path:('{0}/V2.yaml' -f $ConfigFolderPath) -Directory:($false) | ForEach-Object {
    # Get-ChildItem -Path:('{0}/TestApi.yaml' -f $ConfigFolderPath) -Directory:($false) | ForEach-Object {
    ###########################################################################
    $LocalPSRepoName = 'LocalRepository'
    $LocalPSRepoPath = $Home + '/Documents/PowerShell/LocalRepository/'
    $ConfigFileFullName = $_.FullName
    $BaseFolder = $PSScriptRoot
    Set-Location $BaseFolder
    # Get config values
    $Config = Get-Content -Path:($ConfigFileFullName) | ConvertFrom-Yaml
    # $InputFile = $BaseFolder + $Config.'input-file'
    $OutputFullPath = '{0}/{1}' -f $BaseFolder, $Config.'output-folder'
    $ModuleName = $Config.'module-name'
    $Namespace = $Config.'namespace'
    $ModuleVersion = $Config.'module-version'
    $LogFilePath = '{0}/{1}.log' -f $OutputFullPath, $ModuleName
    $nupkgName = '{0}.{1}.nupkg' -f $ModuleName, $ModuleVersion
    $nupkgPath = '{0}/bin/{1}' -f $OutputFullPath, $nupkgName
    $extractedModulePath = '{0}/bin/{1}' -f $OutputFullPath, $ModuleName
    $CustomFolderSourcePath = '{0}/Custom/*' -f $PSScriptRoot
    $CustomFolderPath = '{0}/custom' -f $OutputFullPath
    $buildModulePath = '{0}/build-module.ps1' -f $OutputFullPath
    $packModulePath = '{0}/pack-module.ps1' -f $OutputFullPath
    Set-Location $BaseFolder
    # Log Parsing Regex
    # "(DEBUG)(.*?)(: )", ""
    # "( \/\/  )", "`t"
    # "( => )", "`t"
    # " taking ", "`t taking: "
    # "create-commands - START"
    # "create-commands - END"
    ###########################################################################
    # Remove module from session if it has been imported
    $Module = Get-Module -ListAvailable | Where-Object { $_.Name -match $ModuleName }
    If ($Module)
    {
        $Module | Remove-Module -Force
    }
    # Uninstall module
    $InstalledModule = Get-InstalledModule | Where-Object { $_.Name -like $ModuleName }
    If ($InstalledModule)
    {
        $InstalledModule | Uninstall-Module -Force
    }
    ###########################################################################
    If ($InstallPreReq)
    {
        # Convert JSON to module
        Write-Host ('[RUN COMMAND] npm.cmd install -g pwsh') -BackgroundColor:('Black') -ForegroundColor:('Magenta')
        npm.cmd install -g pwsh # | Out-Null
        Write-Host ('[RUN COMMAND] npm.cmd install -g dotnet-sdk-2.1') -BackgroundColor:('Black') -ForegroundColor:('Magenta')
        npm.cmd install -g dotnet-sdk-2.1 # | Out-Null
        # autorest --help
        Write-Host ('[RUN COMMAND] npm.cmd install -g autorest@beta') -BackgroundColor:('Black') -ForegroundColor:('Magenta')
        npm.cmd install -g autorest@beta # | Out-Null
        # npm install -g autorest@latest
        # npm install -g autorest@preview
        # npm install -g autorest
    }
    ###########################################################################
    If ($GenerateModule)
    {
        If (Test-Path -Path:($OutputFullPath)) { Remove-Item -Path:($OutputFullPath) -Recurse -Force }
        If (!(Test-Path -Path:($OutputFullPath))) { New-Item -Path:($OutputFullPath) -ItemType:('Directory') }
        Write-Host ('[RUN COMMAND] autorest.cmd --reset') -BackgroundColor:('Black') -ForegroundColor:('Magenta')
        autorest.cmd --reset # | Out-Null
        Write-Host ('[RUN COMMAND] autorest.cmd ' + $ConfigFileFullName + ' --verbose --debug --force') -BackgroundColor:('Black') -ForegroundColor:('Magenta')
        autorest.cmd $ConfigFileFullName --force --verbose --debug | Tee-Object -FilePath:($LogFilePath) -Append
    }
    ###########################################################################
    If ($CopyModuleFile)
    {
        Write-Host ('[COPYING] custom files.') -BackgroundColor:('Black') -ForegroundColor:('Magenta')
        Copy-Item -Path:($CustomFolderSourcePath) -Destination:($CustomFolderPath) -Force
        (Get-Content -Path:($CustomFolderPath + '/Module.cs') -Raw).Replace('namespace ModuleNameSpace', "namespace $Namespace") | Set-Content -Path:($CustomFolderPath + '/Module.cs')
    }
    ##########################################################################
    If ($BuildModule)
    {
        # Build module
        If (Test-Path -Path:($buildModulePath))
        {
            Write-Host ('[RUN COMMAND] ' + $buildModulePath) -BackgroundColor:('Black') -ForegroundColor:('Magenta')
            Invoke-Expression -Command:($buildModulePath + ' -Docs -Release') # -Pack
        }
        Else
        {
            Write-Error ("Path does not exist: $buildModulePath")
        }
    }
    ###########################################################################
    If ($PackModule)
    {
        # Pack module
        If (Test-Path -Path:($packModulePath))
        {
            Write-Host ('[RUN COMMAND] ' + $packModulePath ) -BackgroundColor:('Black') -ForegroundColor:('Magenta')
            Invoke-Expression -Command:($packModulePath)
        }
        Else
        {
            Write-Error ("Path does not exist: $packModulePath")
        }
        Expand-Archive -Path:($nupkgPath) -DestinationPath:($extractedModulePath)
        Remove-Item -Path:($extractedModulePath + '/_rels') -Recurse -Force
        Remove-Item -Path:($extractedModulePath + '/*Content*Types*.xml') -Force
    }
    ##########################################################################
    If ($PublishModule)
    {
        # Create the local PSRepository path if it does not exist
        If (!(Test-Path -Path:($LocalPSRepoPath))) { New-Item -Path:($LocalPSRepoPath) -ItemType:('Directory') | Out-Null }
        # Create the local PSRepository if it does not exist
        If (!(Get-PSRepository -Name:($LocalPSRepoName) -ErrorAction:('Ignore')))
        {
            Write-Host ('Creating new PSRepository: ' + $LocalPSRepoName) -BackGroundColor:('Black') -ForegroundColor:('Green')
            Register-PSRepository -Name:($LocalPSRepoName) -SourceLocation:($LocalPSRepoPath) -ScriptSourceLocation:($LocalPSRepoPath) -InstallationPolicy:('Trusted')
            # Unregister-PSRepository -Name:($LocalPSRepoName)
        }
        If (Test-Path -Path:($LocalPSRepoPath + '/' + $nupkgName)) { Remove-Item -Path:($LocalPSRepoPath + '/' + $nupkgName) -Force }
        Publish-Module -Repository:($LocalPSRepoName) -Path:($extractedModulePath)
    }
    ##########################################################################
    If ($InstallModule)
    {
        Install-Module -Repository:($LocalPSRepoName) -Name:($ModuleName) -Scope:('CurrentUser') -Force
        If ($ImportModule)
        {
            Import-Module -Name:($ModuleName)
            # Get-Command | Where-Object { $_.Module -like ('*' + $ModuleName + '*') -and $_.Source -notlike '*private*' } | Select-Object Source, Name | Sort-Object Source, Name | Where-Object { $_.Name -like '*invoke*' }
            # Get-Command | Where-Object { $_.Module -like ('*' + $ModuleName + '*') } | Select-Object Source, Name | Sort-Object Source, Name
        }
    }
    ##########################################################################
    Set-Location -Path:($OutputFullPath)
}
