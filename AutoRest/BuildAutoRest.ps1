#Requires -Modules powershell-yaml, BuildHelpers
# https://github.com/Azure/autorest/blob/master/docs/powershell/options.md
$PSRepoName = 'PSGallery'
# $PSRepoPath = $Home + '/Documents/PowerShell/LocalRepository/'
$ModuleVersionIncrementType = 'Build' # Major, Minor, Build
$PrereleaseName = 'beta'
$InstallPreReq = $true
$GenerateModule = $true
$CopyModuleFile = $true
$BuildModule = $true
$UpdateModuleManifest = $true
$PackModule = $true
$CommitModule = $true
$PublishModule = $true
$ConfigFolderPath = '{0}/Configs' -f $PSScriptRoot
# Run API Transform step
.($PSScriptRoot + '/ApiTransform.ps1') | Out-Null
# Start SDK generation
Get-ChildItem -Path:('{0}/V*.yaml' -f $ConfigFolderPath) -Directory:($false) | ForEach-Object {
    ###########################################################################
    $ConfigFileFullName = $_.FullName
    $BaseFolder = $PSScriptRoot
    Set-Location $BaseFolder
    # Get config values
    $Config = Get-Content -Path:($ConfigFileFullName) | ConvertFrom-Yaml
    # $InputFile = $BaseFolder + $Config.'input-file'
    $OutputFullPath = '{0}/{1}' -f $BaseFolder, $Config.'output-folder'
    $ModuleName = $Config.'module-name'
    $Namespace = $Config.'namespace'
    $LogFilePath = '{0}/{1}.log' -f $OutputFullPath, $ModuleName
    # $ModuleVersion = $Config.'module-version'
    $nupkgName = '{0}*.nupkg' -f $ModuleName
    $binFolder = '{0}/bin/' -f $OutputFullPath
    $extractedModulePath = '{0}/{1}' -f $binFolder, $ModuleName
    $CustomFolderSourcePath = '{0}/Custom/*' -f $PSScriptRoot
    $CustomFolderPath = '{0}/custom' -f $OutputFullPath
    $buildModulePath = '{0}/build-module.ps1 -Docs -Release' -f $OutputFullPath # -Pack
    $packModulePath = '{0}/pack-module.ps1' -f $OutputFullPath
    $moduleManifestPath = '{0}/{1}.psd1' -f $OutputFullPath, $ModuleName
    Set-Location $BaseFolder
    ###########################################################################
    If ($InstallPreReq)
    {
        Write-Host ('[RUN COMMAND] npm.cmd install -g dotnet-sdk-2.1') -BackgroundColor:('Black') -ForegroundColor:('Magenta')
        npm.cmd install -g dotnet-sdk-2.1 # | Out-Null
        # autorest --help
        Write-Host ('[RUN COMMAND] npm.cmd install -g autorest@beta') -BackgroundColor:('Black') -ForegroundColor:('Magenta')
        npm.cmd install -g autorest@beta # | Out-Null
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
    ###########################################################################
    If ($BuildModule)
    {
        Write-Host ('[RUN COMMAND] ' + $buildModulePath) -BackgroundColor:('Black') -ForegroundColor:('Magenta')
        Invoke-Expression -Command:($buildModulePath)
    }
    ###########################################################################
    If ($UpdateModuleManifest)
    {
        $LatestModule = Find-Module -Name:($ModuleName) -Repository:($PSRepoName) -ErrorAction:('SilentlyContinue')
        If ([System.String]::IsNullOrEmpty($LatestModule))
        {
            $LatestModule = Find-Module -Name:($ModuleName) -Repository:($PSRepoName) -ErrorAction:('SilentlyContinue') -AllowPrerelease
        }
        If (-not [System.String]::IsNullOrEmpty($LatestModule))
        {
            # Increment module version number
            If (-not [System.String]::IsNullOrEmpty($ModuleVersionIncrementType))
            {
                $NextVersion = Step-Version -Version:(($LatestModule.Version -split '-')[0]) -By:($ModuleVersionIncrementType)
                Update-ModuleManifest -Path:($moduleManifestPath) -ModuleVersion:($NextVersion)
            }
            # # Get existing GUID
            # $LatestModule | Install-Module -Force -Scope:('CurrentUser')
            # Import-Module -Name:($LatestModule.Name) -Force
            # $ExistingModule = Get-Module -Name:($LatestModule.Name)
            # $ExistingModule | Remove-Module -Force
            # Update-ModuleManifest -Path:($moduleManifestPath) -Guid:($ExistingModule.Guid)
        }
        # Update FunctionsToExport with the same as CmdletsToExport
        $CurrentCmdletsToExport = Get-Metadata -Path:($moduleManifestPath) -PropertyName:('CmdletsToExport')
        Update-ModuleManifest -Path:($moduleManifestPath) -FunctionsToExport:($CurrentCmdletsToExport)
        # Add prerelease tag
        If (-not [System.String]::IsNullOrEmpty($PrereleaseName))
        {
            $CurrentMetaData = Get-Metadata -Path:($moduleManifestPath) -PropertyName:('PSData')
            If ([System.String]::IsNullOrEmpty($CurrentMetaData.Prerelease))
            {
                $CurrentMetaData.Add('Prerelease', $PrereleaseName)
                Update-ModuleManifest -Path:($moduleManifestPath) -PrivateData:($CurrentMetaData)
            }
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
        $nupkg = Get-ChildItem -Path:($binFolder + $nupkgName)
        Expand-Archive -Path:($nupkg.FullName) -DestinationPath:($extractedModulePath)
        Remove-Item -Path:($extractedModulePath + '/_rels') -Recurse -Force
        Remove-Item -Path:($extractedModulePath + '/*Content*Types*.xml') -Force
        Remove-Item -Path:($extractedModulePath + '/package') -Force -Recurse
        Remove-Item -Path:($extractedModulePath + '/' + $ModuleName + '.nuspec') -Force
    }
    ###########################################################################
    If ($CommitModule)
    {

        If ($env:USERNAME -eq 'VssAdministrator')
        {
            Try
            {
                Invoke-Git -Arguments:('config user.email "' + $env:BUILD_REQUESTEDFOREMAIL + '";')
                Invoke-Git -Arguments:('config user.name "' + $env:BUILD_REQUESTEDFOR + '-AzPipelines";')
                Invoke-Git -Arguments:('add -A')
                Invoke-Git -Arguments:('status')
                Invoke-Git -Arguments:('commit -m ' + '"Updating module: ' + $ModuleName + ';[skip ci]";')
                Invoke-Git -Arguments:('push origin HEAD:refs/heads/' + $env:BUILD_SOURCEBRANCHNAME + ';')
            }
            Catch
            {
                Write-Error $_
            }
        }
    }
    ###########################################################################
    If ($PublishModule)
    {
        If ($PSRepoName -eq 'PSGallery')
        {
            Publish-Module -Repository:($PSRepoName) -Path:($extractedModulePath) -SkipAutomaticTags -NuGetApiKey:($env:NuGetApiKey)
        }
        Else
        {
            # Create the local PSRepository if it does not exist
            If (!(Get-PSRepository -Name:($PSRepoName) -ErrorAction:('Ignore')))
            {
                # Create the local PSRepository path if it does not exist
                If (!(Test-Path -Path:($PSRepoPath))) { New-Item -Path:($PSRepoPath) -ItemType:('Directory') | Out-Null }
                Write-Host ('Creating new PSRepository: ' + $PSRepoName) -BackGroundColor:('Black') -ForegroundColor:('Green')
                Register-PSRepository -Name:($PSRepoName) -SourceLocation:($PSRepoPath) -ScriptSourceLocation:($PSRepoPath) -InstallationPolicy:('Trusted')
                # Unregister-PSRepository -Name:($PSRepoName)
            }
            Publish-Module -Repository:($PSRepoName) -Path:($extractedModulePath) -SkipAutomaticTags
        }
    }
    ###########################################################################
    Set-Location -Path:($OutputFullPath)
}
