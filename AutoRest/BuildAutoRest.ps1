#Requires -Modules powershell-yaml, BuildHelpers
Param(
    [Parameter(Mandatory = $true, ValueFromPipelineByPropertyName = $true, HelpMessage = 'Name of the API to build an SDK for.')][ValidateSet('V1', 'V2', 'DirectoryInsights')][ValidateNotNullOrEmpty()][System.String[]]$APIName
    , [Parameter(Mandatory = $false, ValueFromPipelineByPropertyName = $true, HelpMessage = 'API key used for pester tests.')][ValidateNotNullOrEmpty()][System.String[]]$JCApiKey
    , [Parameter(Mandatory = $false, ValueFromPipelineByPropertyName = $true, HelpMessage = 'OrgId used for pester tests.')][ValidateNotNullOrEmpty()][System.String[]]$JCOrgId
    , [Parameter(Mandatory = $false, ValueFromPipelineByPropertyName = $true, HelpMessage = 'GitHub Personal Access Token.')][ValidateNotNullOrEmpty()][System.String[]]$GitHubAccessToken
)
Try
{
    # Create environmental variable so that they can be used by the pester tests later.
    $env:JCApiKey = $JCApiKey
    $env:JCOrgId = $JCOrgId
    # https://github.com/Azure/autorest/blob/master/docs/powershell/options.md
    $PSRepoName = 'PSGallery'
    # $PSRepoPath = $Home + '/Documents/PowerShell/LocalRepository/'
    $ModuleVersionIncrementType = 'Build' # Major, Minor, Build
    $PrereleaseName = '' # Populate to make release a beta
    $FolderExcludeList = @('examples', 'test') # Excluded folder in root from being removed
    $InstallPreReq = $true
    $GenerateModule = $true
    $IncrementModuleVersion = $true
    $CopyModuleFile = $true
    $BuildModule = $true
    $UpdateModuleManifest = $true
    $TestModule = $true
    $PackModule = $true
    $CommitModule = $true
    $PublishModule = $false
    ForEach ($API In $APIName)
    {
        $ConfigFilePath = '{0}/Configs/{1}.yaml' -f $PSScriptRoot, $API
        If (Test-Path -Path:($ConfigFilePath))
        {
            # Run API Transform step
            $UpdatedSpec = .($PSScriptRoot + '/ApiTransform.ps1') -APIName:($APIName) -GitHubAccessToken:($GitHubAccessToken) #| Out-Null
            # If ($UpdatedSpec -or $env:USERNAME -eq 'VssAdministrator')
            # {
            # Start SDK generation
            $ConfigFile = Get-Item -Path:($ConfigFilePath)
            ###########################################################################
            $ConfigFileFullName = $ConfigFile.FullName
            $BaseFolder = $PSScriptRoot
            Set-Location $BaseFolder
            # Get config values
            $Config = Get-Content -Path:($ConfigFileFullName) | ConvertFrom-Yaml
            # $InputFile = $BaseFolder + $Config.'input-file'
            $OutputFullPath = '{0}/{1}' -f $BaseFolder, $Config.'output-folder'
            $ModuleName = $Config.'module-name'
            $Namespace = $Config.'namespace'
            $LogFilePath = '{0}/{1}.log' -f $OutputFullPath, $ModuleName
            $ModuleVersion = $Config.'module-version'
            $nupkgName = '{0}*.nupkg' -f $ModuleName
            $binFolder = '{0}/bin/' -f $OutputFullPath
            $extractedModulePath = '{0}{1}' -f $binFolder, $ModuleName
            $CustomFolderSourcePath = '{0}/Custom/*' -f $PSScriptRoot
            $CustomFolderPath = '{0}/custom' -f $OutputFullPath
            $TestFolderPath = '{0}/test' -f $OutputFullPath
            $PesterTestResultPath = Join-Path $TestFolderPath "$ModuleName-TestResults.xml"
            $buildModulePath = '{0}/build-module.ps1 -Docs -Release' -f $OutputFullPath # -Pack
            $packModulePath = '{0}/pack-module.ps1' -f $OutputFullPath
            $testModulePath = '{0}/test-module.ps1' -f $OutputFullPath
            $moduleManifestPath = '{0}/{1}.psd1' -f $OutputFullPath, $ModuleName
            ###########################################################################
            If ($InstallPreReq)
            {
                # Write-Host ('[RUN COMMAND] npm install -g dotnet-sdk-2.1') -BackgroundColor:('Black') -ForegroundColor:('Magenta')
                # npm install -g dotnet-sdk-2.1
                Write-Host ('[RUN COMMAND] npm install -g @autorest/autorest') -BackgroundColor:('Black') -ForegroundColor:('Magenta')
                npm install -g @autorest/autorest
                Write-Host ('[RUN COMMAND] autorest-beta --reset') -BackgroundColor:('Black') -ForegroundColor:('Magenta')
                autorest-beta --reset
                # autorest-beta --help
            }
            ###########################################################################
            If ($GenerateModule)
            {
                If (Test-Path -Path:($OutputFullPath)) { Get-ChildItem -Path:($OutputFullPath) | Where-Object { $_.Name -notin $FolderExcludeList } | Remove-Item -Force -Recurse }
                If (!(Test-Path -Path:($OutputFullPath))) { New-Item -Path:($OutputFullPath) -ItemType:('Directory') }
                Write-Host ('[RUN COMMAND] autorest-beta ' + $ConfigFileFullName + ' --force --verbose --debug') -BackgroundColor:('Black') -ForegroundColor:('Magenta')
                autorest-beta $ConfigFileFullName --force --verbose --debug | Tee-Object -FilePath:($LogFilePath) -Append
            }
            ###########################################################################
            If ($IncrementModuleVersion)
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
                    }
                }
            }
            ###########################################################################
            If ($CopyModuleFile)
            {
                Write-Host ('[COPYING] custom files.') -BackgroundColor:('Black') -ForegroundColor:('Magenta')
                Copy-Item -Path:($CustomFolderSourcePath) -Destination:($CustomFolderPath) -Force
                $ModuleVersion = If ([System.String]::IsNullOrEmpty($NextVersion))
                {
                    $ModuleVersion
                }
                Else
                {
                    $NextVersion
                }
                (Get-Content -Path:($CustomFolderPath + '/Module.cs') -Raw).Replace('namespace ModuleNameSpace', "namespace $Namespace").Replace('ModuleNameSpace/ModuleVersion', $Namespace.Replace('SDK', 'PowerShell.SDK') + '/' + $ModuleVersion) | Set-Content -Path:($CustomFolderPath + '/Module.cs')
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
                # Increment module version number
                If (-not [System.String]::IsNullOrEmpty($NextVersion))
                {
                    Write-Host ('[RUN COMMAND] Increment module version number to: ' + $NextVersion) -BackgroundColor:('Black') -ForegroundColor:('Magenta')
                    Update-ModuleManifest -Path:($moduleManifestPath) -ModuleVersion:($NextVersion)
                }
                # # Get existing GUID
                # $LatestModule | Install-Module -Force -Scope:('CurrentUser')
                # Import-Module -Name:($LatestModule.Name) -Force
                # $ExistingModule = Get-Module -Name:($LatestModule.Name)
                # $ExistingModule | Remove-Module -Force
                # Update-ModuleManifest -Path:($moduleManifestPath) -Guid:($ExistingModule.Guid)
                # Update FunctionsToExport with the same as CmdletsToExport
                Write-Host ('[RUN COMMAND] Updating module manifest: FunctionsToExport') -BackgroundColor:('Black') -ForegroundColor:('Magenta')
                $CurrentCmdletsToExport = Get-Metadata -Path:($moduleManifestPath) -PropertyName:('CmdletsToExport')
                Update-ModuleManifest -Path:($moduleManifestPath) -FunctionsToExport:($CurrentCmdletsToExport)
                # Add prerelease tag
                If (-not [System.String]::IsNullOrEmpty($PrereleaseName))
                {
                    $CurrentMetaData = Get-Metadata -Path:($moduleManifestPath) -PropertyName:('PSData')
                    If ([System.String]::IsNullOrEmpty($CurrentMetaData.Prerelease))
                    {
                        Write-Host ('[RUN COMMAND] Updating module manifest: Prerelease') -BackgroundColor:('Black') -ForegroundColor:('Magenta')
                        $CurrentMetaData.Add('Prerelease', $PrereleaseName)
                        Update-ModuleManifest -Path:($moduleManifestPath) -PrivateData:($CurrentMetaData)
                    }
                }
            }
            ###########################################################################
            If ($TestModule)
            {
                If (-not [System.String]::IsNullOrEmpty($env:JCApiKey) -and -not [System.String]::IsNullOrEmpty($env:JCOrgId))
                {
                    Write-Host ('[VALIDATION] JCApiKey AND JCOrgId have been populated.') -BackgroundColor:('Black') -ForegroundColor:('Magenta')
                    # Test module
                    Install-Module Pester -Force
                    Import-Module Pester -Force
                    # ./test-module.ps1 -Isolated # Not sure when to use this yet
                    # ./test-module.ps1 -Record # Run to create playback files
                    # ./test-module.ps1 -Playback # Run once playback files have been created
                    # ./test-module.ps1 -Live # Run to query against real API
                    $TestModuleCommand = $testModulePath + ' -Live'  # Run to query against real API
                    Invoke-Expression -Command:($TestModuleCommand)
                    Write-Host ('[RUN COMMAND] ' + $TestModuleCommand) -BackgroundColor:('Black') -ForegroundColor:('Magenta')
                    Invoke-Expression -Command:($TestModuleCommand)
                    [xml]$PesterResults = Get-Content -Path:($PesterTestResultPath)
                    $FailedTests = $PesterResults.'test-results'.'test-suite'.'results'.'test-suite' | Where-Object { $_.success -eq 'False' }
                    If ($FailedTests)
                    {
                        Write-Host ('')
                        Write-Host ('##############################################################################################################')
                        Write-Host ('##############################Error Description###############################################################')
                        Write-Host ('##############################################################################################################')
                        Write-Host ('')
                        $FailedTests | ForEach-Object { $_.InnerText + ';' }
                        Write-Host("##vso[task.logissue type=error;]" + 'Tests Failed: ' + [string]($FailedTests | Measure-Object).Count)
                        Write-Error -Message:('Tests Failed: ' + [string]($FailedTests | Measure-Object).Count)
                    }
                }
                Else
                {
                    Write-Host("##vso[task.logissue type=error;]" + 'JCApiKey and JCOrgId have not been set.')
                    Write-Error ('JCApiKey and JCOrgId have not been set.')
                }
            }
            Else
            {
                Write-Warning ('Skipping TestModule.')
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
                    Write-Host("##vso[task.logissue type=error;]" + "Path does not exist: $packModulePath")
                    Write-Error ("Path does not exist: $packModulePath")
                }
                $nupkg = Get-ChildItem -Path:($binFolder + $nupkgName)
                Expand-Archive -Path:($nupkg.FullName) -DestinationPath:($extractedModulePath)
                Remove-Item -Path:($extractedModulePath + '/_rels') -Recurse -Force
                Remove-Item -Path:($extractedModulePath + '/*Content*Types*.xml') -Force
                Remove-Item -Path:($extractedModulePath + '/package') -Force -Recurse
                Remove-Item -Path:($extractedModulePath + '/' + $ModuleName + '.nuspec') -Force
            }
            ##########################################################################
            If ($CommitModule)
            {
                If ($env:USERNAME -eq 'VssAdministrator')
                {
                    Write-Host ('[COMMITTING MODULE] changes back into "' + $env:BUILD_SOURCEBRANCHNAME + '"' ) -BackgroundColor:('Black') -ForegroundColor:('Magenta')
                    Try
                    {
                        $UserEmail = If ($env:BUILD_REQUESTEDFOREMAIL) { $env:BUILD_REQUESTEDFOREMAIL } Else { ($env:USERNAME).Replace(' ', '') + '@FakeEmail.com' }
                        $UserName = If ($env:BUILD_REQUESTEDFOR) { $env:BUILD_REQUESTEDFOR } Else { $env:USERNAME }
                        Set-Location -Path:($BaseFolder)
                        ./Invoke-Git.ps1 -Arguments:('config user.email "' + $UserEmail + '";')
                        ./Invoke-Git.ps1 -Arguments:('config user.name "' + $UserName + '";')
                        ./Invoke-Git.ps1 -Arguments:('add -A')
                        ./Invoke-Git.ps1 -Arguments:('status')
                        ./Invoke-Git.ps1 -Arguments:('commit -m ' + '"Updating module: ' + $ModuleName + ';[skip ci]";')
                        ./Invoke-Git.ps1 -Arguments:('push origin HEAD:refs/heads/' + $env:BUILD_SOURCEBRANCHNAME + ';')
                    }
                    Catch
                    {
                        Write-Host("##vso[task.logissue type=error;]" + $_)
                        Write-Error $_
                    }
                }
            }
            ###########################################################################
            If ($PublishModule)
            {
                Write-Host ('[PUBLISHING MODULE] from "' + $extractedModulePath + '" to "' + $PSRepoName + '"' ) -BackgroundColor:('Black') -ForegroundColor:('Magenta')
                If ($PSRepoName -eq 'PSGallery')
                {
                    Publish-Module -Repository:($PSRepoName) -Path:($extractedModulePath) -SkipAutomaticTags -NuGetApiKey:('oy2cwzfmucmj6ibyoveaiur3l5ixk23ejhupemqk5nep2u') -Force -Verbose
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
            Write-Host ("##vso[task.setvariable variable=ModuleFolder]$extractedModulePath") -BackgroundColor:('Black') -ForegroundColor:('Magenta')
            # }
            # Else
            # {
            #     Write-Warning ($API + ' spec is up to date.')
            # }
        }
        Else
        {
            Write-Host("##vso[task.logissue type=error;]" + 'Unable to find file: ' + $ConfigFilePath)
            Write-Error ('Unable to find file: ' + $ConfigFilePath)
        }
    }
}
Catch
{
    Write-Host("##vso[task.logissue type=error;]" + $_)
    Write-Error $_
}