#Requires -PSEdition Core
#Requires -Modules powershell-yaml, BuildHelpers
Param(
    [Parameter(Mandatory = $true, ValueFromPipelineByPropertyName = $true, HelpMessage = 'Name of the SDK to build.')][ValidateSet('JumpCloud.SDK.V1', 'JumpCloud.SDK.V2', 'JumpCloud.SDK.DirectoryInsights')][ValidateNotNullOrEmpty()][System.String[]]$SDKName
    , [Parameter(Mandatory = $false, ValueFromPipelineByPropertyName = $true, HelpMessage = 'API key used for pester tests.')][ValidateNotNullOrEmpty()][System.String]$JCApiKey
    , [Parameter(Mandatory = $false, ValueFromPipelineByPropertyName = $true, HelpMessage = 'OrgId used for pester tests.')][ValidateNotNullOrEmpty()][System.String]$JCOrgId
    , [Parameter(Mandatory = $false, ValueFromPipelineByPropertyName = $true, HelpMessage = 'GitHub Personal Access Token.')][ValidateNotNullOrEmpty()][System.String]$GitHubAccessToken
    , [Parameter(Mandatory = $false, ValueFromPipelineByPropertyName = $true, HelpMessage = 'Set to true to bypass swagger spec version check.')][ValidateNotNullOrEmpty()][System.String]$BuildModuleOverride = $false
    , [Parameter(Mandatory = $false, ValueFromPipelineByPropertyName = $true, HelpMessage = 'Specify module version number to set manually.')][System.String]$ManualModuleVersion
    , [Parameter(Mandatory = $false, ValueFromPipelineByPropertyName = $true, HelpMessage = 'Populate to make module version a prerelease.')][ValidateSet('', 'beta')][System.String]$PrereleaseName = ''
    , [Parameter(Mandatory = $false, ValueFromPipelineByPropertyName = $true, HelpMessage = 'Excluded folder in root from being removed')][ValidateNotNullOrEmpty()][System.String[]]$FolderExcludeList = @('examples', 'test')
    , [Parameter(Mandatory = $false, ValueFromPipelineByPropertyName = $true, HelpMessage = 'Set the module version increment type.')][ValidateSet('Major', 'Minor', 'Build')][ValidateNotNullOrEmpty()][System.String]$ModuleVersionIncrementType = 'Build'
    , [Parameter(Mandatory = $false, ValueFromPipelineByPropertyName = $true, HelpMessage = '$true to run the ApiTransform.ps1 file.')][ValidateNotNullOrEmpty()][System.Boolean]$RunApiTransform = $true
    , [Parameter(Mandatory = $false, ValueFromPipelineByPropertyName = $true, HelpMessage = '$true to increment the module version.')][ValidateNotNullOrEmpty()][System.Boolean]$IncrementModuleVersion = $true
    , [Parameter(Mandatory = $false, ValueFromPipelineByPropertyName = $true, HelpMessage = '$true to install prereqs.')][ValidateNotNullOrEmpty()][System.Boolean]$InstallPreReq = $true
    , [Parameter(Mandatory = $false, ValueFromPipelineByPropertyName = $true, HelpMessage = '$true to run AutoRest to generate the module.')][ValidateNotNullOrEmpty()][System.Boolean]$GenerateModule = $true
    , [Parameter(Mandatory = $false, ValueFromPipelineByPropertyName = $true, HelpMessage = '$true to copy files from the custom directory to the SDK.')][ValidateNotNullOrEmpty()][System.Boolean]$CopyCustomFiles = $true
    , [Parameter(Mandatory = $false, ValueFromPipelineByPropertyName = $true, HelpMessage = '$true to run build-module.ps1 ')][ValidateNotNullOrEmpty()][System.Boolean]$BuildModule = $true
    , [Parameter(Mandatory = $false, ValueFromPipelineByPropertyName = $true, HelpMessage = '$true to run BuildCustomFunctions.ps1')][ValidateNotNullOrEmpty()][System.Boolean]$BuildCustomFunctions = $true
    , [Parameter(Mandatory = $false, ValueFromPipelineByPropertyName = $true, HelpMessage = '$true to update the module guid.')][ValidateNotNullOrEmpty()][System.Boolean]$UpdateModuleGuid = $true
    , [Parameter(Mandatory = $false, ValueFromPipelineByPropertyName = $true, HelpMessage = '$true to run pester tests.')][ValidateNotNullOrEmpty()][System.Boolean]$TestModule = $true
    , [Parameter(Mandatory = $false, ValueFromPipelineByPropertyName = $true, HelpMessage = '$true to modify the AutoRest .gitignore file')][ValidateNotNullOrEmpty()][System.Boolean]$ModifyGitIgnore = $true
    , [Parameter(Mandatory = $false, ValueFromPipelineByPropertyName = $true, HelpMessage = '$true to remove AutoRest generated Az module')][ValidateNotNullOrEmpty()][System.Boolean]$RemoveAzAccounts = $true
    , [Parameter(Mandatory = $false, ValueFromPipelineByPropertyName = $true, HelpMessage = '$true to add GitHub Packages required attributes')][ValidateNotNullOrEmpty()][System.Boolean]$ModifyNuspec = $true
    , [Parameter(Mandatory = $false, ValueFromPipelineByPropertyName = $true, ParameterSetName = 'Publish', HelpMessage = 'Set to $true to publish the module to a repository.')][ValidateNotNullOrEmpty()][System.Boolean]$PublishModule = $false
    , [Parameter(Mandatory = $false, ValueFromPipelineByPropertyName = $true, ParameterSetName = 'Publish', HelpMessage = 'Specify the PowerShell repository to deploy to.')][ValidateNotNullOrEmpty()][System.String]$PSRepoName = 'PSGallery'
    , [Parameter(Mandatory = $false, ValueFromPipelineByPropertyName = $true, ParameterSetName = 'Publish', HelpMessage = 'NuGetApiKey for your repository.')][ValidateNotNullOrEmpty()][System.String]$NuGetApiKey = ''
)
Try
{
    # https://github.com/Azure/autorest/blob/master/docs/powershell/options.md
    # Create environmental variable so that they can be used by the pester tests later.
    If ([System.String]::IsNullOrEmpty($env:JCApiKey)) { $env:JCApiKey = $JCApiKey }
    If ([System.String]::IsNullOrEmpty($env:JCOrgId)) { $env:JCOrgId = $JCOrgId }
    $RunLocal = If ($env:USERNAME -eq 'VssAdministrator') { $false } Else { $true }
    ForEach ($SDK In $SDKName)
    {
        $ConfigFilePath = '{0}/Configs/{1}.yaml' -f $PSScriptRoot, $SDK
        $ApiTransformPath = '{0}/ApiTransform.ps1' -f $PSScriptRoot
        If (Test-Path -Path:($ConfigFilePath))
        {
            # Run API Transform step
            If ($RunApiTransform)
            {
                $UpdatedSpec = If ([System.String]::IsNullOrEmpty($PSBoundParameters.GitHubAccessToken))
                {
                    .($ApiTransformPath) -SDKName:($SDKName) # -NoUpdate # | Out-Null
                }
                Else
                {
                    .($ApiTransformPath) -SDKName:($SDKName) -GitHubAccessToken:($GitHubAccessToken) # -NoUpdate # | Out-Null
                }
                If ($PSBoundParameters.BuildModuleOverride)
                {
                    $UpdatedSpec = $PSBoundParameters.BuildModuleOverride
                }
            }
            If (($UpdatedSpec -and $env:USERNAME -eq 'VssAdministrator') -or $RunLocal)
            {
                # Start SDK generation
                $ConfigFile = Get-Item -Path:($ConfigFilePath)
                $ConfigFileFullName = $ConfigFile.FullName
                $ConfigContent = Get-Content -Path:($ConfigFileFullName) -Raw
                $BaseFolder = $PSScriptRoot
                Set-Location $BaseFolder
                ###########################################################################
                # Get config values
                $Config = $ConfigContent | ConvertFrom-Yaml
                # $InputFile = $BaseFolder + $Config.'input-file'
                $OutputFullPath = '{0}/{1}' -f $BaseFolder, $Config.'output-folder'
                $ToolsFolderPath = '{0}/Tools' -f $BaseFolder
                $RunPesterTestsFilePath = '{0}/RunPesterTests.ps1' -f $ToolsFolderPath
                $ModuleName = $Config.'module-name'
                $Namespace = $Config.'namespace'
                $ConfigPrefix = $Config.prefix | Select-Object -First 1
                $ConfigCustomFunctionPrefix = $Config.customFunctionPrefix
                # $ConfigProjectUri = $Config.metadata.projectUri
                # $ConfigHelpLinkPrefix = $Config.'help-link-prefix'
                $ConfigInputFile = '{0}/{1}' -f $BaseFolder, $Config.'input-file'
                $LogFilePath = '{0}/{1}.log' -f $OutputFullPath, $ModuleName
                $ModuleVersion = $Config.'module-version'
                # $nupkgName = '{0}*.nupkg' -f $ModuleName
                $binFolder = '{0}/bin/' -f $OutputFullPath
                $extractedModulePath = '{0}{1}' -f $binFolder, $ModuleName
                $CustomFolderSourcePath = '{0}/Custom' -f $PSScriptRoot
                $CustomFolderPath = '{0}/custom' -f $OutputFullPath
                $GeneratedFolderPath = '{0}/generated' -f $CustomFolderPath
                $exportsFolderPath = '{0}/exports' -f $OutputFullPath
                $TestFolderPath = '{0}/test' -f $OutputFullPath
                $ExamplesFolderPath = '{0}/examples' -f $OutputFullPath
                $DocsFolderPath = '{0}/docs/exports' -f $OutputFullPath
                $PesterTestResultPath = Join-Path $TestFolderPath "$ModuleName-TestResults.xml"
                $buildModulePath = '{0}/build-module.ps1' -f $OutputFullPath # -Pack
                $testModulePath = '{0}/test-module.ps1' -f $OutputFullPath
                $checkDependenciesModulePath = '{0}/check-dependencies.ps1' -f $OutputFullPath
                $psd1Path = '{0}/{1}.psd1' -f $OutputFullPath, $ModuleName
                $nuspecPath = '{0}/{1}.nuspec' -f $OutputFullPath, $ModuleName
                $internalFolderPath = '{0}/internal' -f $OutputFullPath, $ModuleName
                $internalPsm1 = '{0}/{1}.internal.psm1' -f $internalFolderPath, $ModuleName
                $moduleMdPath = '{0}/{1}.md' -f $DocsFolderPath, $ModuleName
                $AzAccountsPath = '{0}/{1}' -f $OutputFullPath, '\generated\modules\Az.Accounts'
                $CustomHelpProxyType = '{0}/generated/runtime/BuildTime/Models/PsProxyTypes.cs' -f $OutputFullPath
                $BuildCustomFunctionsPath = '{0}/BuildCustomFunctions.ps1 -ConfigPath:("{1}") -psd1Path:("{2}") -CustomFolderPath:("{3}") -ExamplesFolderPath:("{4}") -TestFolderPath:("{5}")' -f [System.String]$BaseFolder, [System.String]$ConfigFileFullName, [System.String]$internalPsm1, [System.String]$GeneratedFolderPath, [System.String]$ExamplesFolderPath, [System.String]$TestFolderPath
                ###########################################################################
                # Check to see if module exists on PowerShellGallery already
                $PublishedModule = If ([System.String]::IsNullOrEmpty($PrereleaseName))
                {
                    Find-Module -Name:($ModuleName) -Repository:($PSRepoName) -ErrorAction:('SilentlyContinue')
                }
                Else
                {
                    Find-Module -Name:($ModuleName) -Repository:($PSRepoName) -ErrorAction:('SilentlyContinue') -AllowPrerelease
                }
                ###########################################################################
                If (-not [System.String]::IsNullOrEmpty($PublishedModule))
                {
                    # Increment module version number
                    If ($IncrementModuleVersion)
                    {
                        If (-not [System.String]::IsNullOrEmpty($ModuleVersionIncrementType))
                        {
                            $ModuleVersion = If (-not [System.String]::IsNullOrEmpty($ManualModuleVersion))
                            {
                                [System.Version]$ManualModuleVersion
                            }
                            Else
                            {
                                Step-Version -Version:(($PublishedModule.Version -split '-')[0]) -By:($ModuleVersionIncrementType)
                            }
                            Write-Host ('[RUN COMMAND] Increment module version number to: ' + $ModuleVersion) -BackgroundColor:('Black') -ForegroundColor:('Magenta')
                            $ConfigContent = $ConfigContent -Replace ("(module-version: )([0-9]\d*)\.([0-9]\d*)\.([0-9]\d*)", "module-version: $($ModuleVersion)")
                            $ConfigContent.Trim() | Out-File -FilePath:($ConfigFilePath) -Force
                        }
                    }
                }
                $env:CIRCLE_BUILD_NUM = If ([System.String]::IsNullOrEmpty($env:CIRCLE_BUILD_NUM))
                {
                    '0000'
                }
                Else
                {
                    $env:CIRCLE_BUILD_NUM
                }
                $BuildVersion = "$($ModuleVersion)-$($env:CIRCLE_BUILD_NUM)"
                ###########################################################################
                If ($InstallPreReq)
                {
                    Write-Host ('[RUN COMMAND] npm install -g dotnet-sdk-3.1') -BackgroundColor:('Black') -ForegroundColor:('Magenta')
                    If ($IsWindows) { npm install -g dotnet-sdk-3.1-win-x64 }
                    ElseIf ($IsMacOS) { npm install -g dotnet-sdk-3.1-osx-x64 }
                    ElseIf ($IsLinux) { npm install -g dotnet-sdk-3.1-linux-x64 }
                    Else { Write-Error ('Unknown Operation System') }
                }
                ###########################################################################
                If ($GenerateModule)
                {
                    If (Test-Path -Path:($OutputFullPath)) { Get-ChildItem -Path:($OutputFullPath) | Where-Object { $_.Name -notin $FolderExcludeList } | Remove-Item -Force -Recurse }
                    If (!(Test-Path -Path:($OutputFullPath))) { New-Item -Path:($OutputFullPath) -ItemType:('Directory') }
                    Write-Host ('[RUN COMMAND] autorest ' + $ConfigFileFullName + ' --force --verbose --debug') -BackgroundColor:('Black') -ForegroundColor:('Magenta')
                    autorest $ConfigFileFullName --force --verbose --debug | Tee-Object -FilePath:($LogFilePath) -Append
                }
                ###########################################################################
                If ($CopyCustomFiles)
                {
                    # Create folder if it does not exist
                    If (!(Test-Path -Path:($CustomFolderPath))) { New-Item -Path:($CustomFolderPath) -ItemType:('Directory') | Out-Null }
                    Write-Host ('[COPYING] custom files.') -BackgroundColor:('Black') -ForegroundColor:('Magenta')
                    Copy-Item -Path:("$($CustomFolderSourcePath)/*") -Destination:([System.String]$CustomFolderPath) -Force
                    (Get-Content -Path:($CustomFolderPath + '/Module.cs') -Raw).Replace('namespace ModuleNameSpace', "namespace $Namespace").Replace('ModuleNameSpace/ModuleVersion', $Namespace.Replace('SDK', 'PowerShell.SDK') + '/' + $ModuleVersion) | Set-Content -Path:($CustomFolderPath + '/Module.cs')
                    # Copy swagger spec to SDK directory
                    Copy-Item -Path:("$ConfigInputFile") -Destination:([System.String]$CustomFolderPath) -Force
                }
                ###########################################################################
                If ($BuildModule)
                {
                    $BuildModuleContent = Get-Content -Path:($buildModulePath) -Raw
                    $BuildModuleContent.Replace('Export-ExampleStub -ExportsFolder', '#Export-ExampleStub -ExportsFolder') | Set-Content -Path:($buildModulePath)

                    $BuildModuleCommand = "$buildModulePath -Release"
                    Write-Host ('[RUN COMMAND] ' + $BuildModuleCommand) -BackgroundColor:('Black') -ForegroundColor:('Magenta') | Tee-Object -FilePath:($LogFilePath) -Append
                    # fix docs help link
                    $PsProxyTypes = (Get-Content $CustomHelpProxyType -Raw)
                    $OnlineVersionPsProxyTypes = [Regex]::Replace($PsProxyTypes, ('\$\@\"{HelpLinkPrefix}.*'), '$@"{HelpLinkPrefix}{variantGroup.ModuleName}/docs/exports/{variantGroup.CmdletName}.md";', [System.Text.RegularExpressions.RegexOptions]::IgnoreCase);
                    Set-Content -Path:($CustomHelpProxyType) -Value:($OnlineVersionPsProxyTypes)
                    # build the module
                    $BuildModuleCommandJob = Start-Job -ScriptBlock:( {
                            param ($BuildModuleCommand);
                            Invoke-Expression -Command:($BuildModuleCommand)
                        }) -ArgumentList:($BuildModuleCommand)
                    $BuildModuleCommandJobStatus = Wait-Job -Id:($BuildModuleCommandJob.Id)
                    $BuildModuleCommandJobStatus | Receive-Job | Tee-Object -FilePath:($LogFilePath) -Append
                }
                ###########################################################################
                If ($BuildCustomFunctions)
                {
                    Write-Host ('[RUN COMMAND] ' + $BuildCustomFunctionsPath) -BackgroundColor:('Black') -ForegroundColor:('Magenta') | Tee-Object -FilePath:($LogFilePath) -Append
                    # Run build custom functions script as a job in a new session to avoid "did you forget to close your session?" error
                    $BuildCustomFunctionsJob = Start-Job -ScriptBlock:( {
                            param ($BuildCustomFunctionsPath);
                            Invoke-Expression -Command:($BuildCustomFunctionsPath)
                        }) -ArgumentList:($BuildCustomFunctionsPath)
                    $BuildCustomFunctionsJobStatus = Wait-Job -Id:($BuildCustomFunctionsJob.Id)
                    $BuildCustomFunctionsJobStatus | Receive-Job | Tee-Object -FilePath:($LogFilePath) -Append
                    If ($BuildCustomFunctionsJobStatus.State -ne 'Completed')
                    {
                        Write-Error ('Build custom functions job did not return a "Completed" status.')
                    }
                    Else
                    {
                        # Rebuild the module with the new custom functions
                        If ($BuildModule)
                        {
                            # Comment out section of build-module script so it does not erase the contents of the export folder
                            $BuildModuleContent = Get-Content -Path:($buildModulePath) -Raw
                            $BuildModuleContent.Replace('#Export-ExampleStub -ExportsFolder', 'Export-ExampleStub -ExportsFolder') | Set-Content -Path:($buildModulePath)
                            # Build-module
                            $BuildModuleCommand = "$buildModulePath -Docs -Release"
                            Write-Host ('[RUN COMMAND] ' + $BuildModuleCommand) -BackgroundColor:('Black') -ForegroundColor:('Magenta') | Tee-Object -FilePath:($LogFilePath) -Append
                            Invoke-Expression -Command:($BuildModuleCommand) | Tee-Object -FilePath:($LogFilePath) -Append
                            # Build PSScriptInfo - Theres gotta be a better way to do this
                            Function Convert-GeneratedToCustom ([System.String]$InputString, [System.String]$ConfigPrefix, [System.String]$ConfigCustomFunctionPrefix)
                            {
                                # Swap out SDK prefix for customFunction prefix
                                $InputString = $InputString.Replace($ConfigPrefix, $ConfigCustomFunctionPrefix)
                                # Remove weird output conversion for the customFunctions
                                $OutputMatches = $InputString | Select-String -Pattern:('(?<=\()(.*?)(?=\)\.ToJsonString\(\) \| ConvertFrom-Json)') -AllMatches
                                $OutputMatches.Matches | ForEach-Object {
                                    $OutputMatchesFind = '({0}).ToJsonString() | ConvertFrom-Json' -f ($_.Value)
                                    $InputString = $InputString.Replace($OutputMatchesFind, $_.Value)
                                }
                                $InputString = $InputString -replace (" `r", "`r") -replace (" `n", "`n")
                                Return $InputString
                            }
                            $CustomFiles = Get-ChildItem -Path:($GeneratedFolderPath) -File | Where-Object { $_.Extension -eq '.ps1' }
                            ForEach ($CustomFile In $CustomFiles)
                            {
                                $CustomFileFullName = $CustomFile.FullName
                                $CustomFileContent = Get-Content -Path:($CustomFileFullName) -Raw
                                $ExportFullName = "$exportsFolderPath/$($CustomFile.Name)"
                                $ExportContent = Get-Content -Path:($ExportFullName) -Raw
                                $PSScriptInfo = ($ExportContent | Select-String -Pattern:('(?s)(<#)(.*?)(#>)')).Matches.Value
                                # Convert generated function syntax to custom function syntax
                                $PSScriptInfo = Convert-GeneratedToCustom -InputString:($PSScriptInfo) -ConfigPrefix:($ConfigPrefix) -ConfigCustomFunctionPrefix:($ConfigCustomFunctionPrefix)
                                $InternalFullName = "$internalFolderPath/$($CustomFile.Name.Replace($ConfigCustomFunctionPrefix,$ConfigPrefix))"
                                $InternalContent = Get-Content -Path:($InternalFullName) -Raw
                                $InternalDescription = ($InternalContent | Select-String -Pattern:('(?s)(\.Synopsis)(.*?)(?=\.Example)')).Matches.Value
                                $PSScriptInfoDescription = ($PSScriptInfo | Select-String -Pattern:('(?s)(\.Synopsis)(.*?)(?=\.Example)')).Matches.Value
                                If (-not [System.String]::IsNullOrEmpty($InternalDescription) -and -not [System.String]::IsNullOrEmpty($PSScriptInfoDescription))
                                {
                                    $PSScriptInfo = [Regex]::Replace($PSScriptInfo, [regex]::Escape($PSScriptInfoDescription), $InternalDescription, [System.Text.RegularExpressions.RegexOptions]::IgnoreCase);
                                    $PSScriptInfo = $PSScriptInfo.Replace($PSScriptInfoDescription, $InternalDescription)
                                    "$PSScriptInfo`n $CustomFileContent" | Set-Content -Path:($CustomFileFullName)
                                }
                                # Format help files
                                (Get-Content -Path:($CustomFile.FullName) -Raw).Replace('\n', "`n") | Set-Content -Path:($CustomFile.FullName)
                            }
                            # Clean tests folder
                            $UnusedTestFiles = Get-ChildItem -Path:($TestFolderPath) -Recurse -File | Where-Object { `
                                    $_.Name -notin ('loadEnv.ps1', 'localEnv.json', 'readme.md', 'utils.ps1') <# AutoRest generated #> `
                                    -and $_.Name -notin ('HelpFiles.Tests.ps1') <# Common tests #> `
                                    -and $_.Name -notin ($CustomFiles.Name).Replace('.ps1', '.Tests.ps1') <# Remove tests that correlate to functions which don't exist #> `
                            }
                            If (-not [System.String]::IsNullOrEmpty($UnusedTestFiles)) { $UnusedTestFiles | Remove-Item -Force -Recurse }
                            # Rebuild to distribute the update PSScriptInfo to other locations
                            $BuildModuleCommand = "$buildModulePath -Docs -Release"
                            Write-Host ('[RUN COMMAND] ' + $BuildModuleCommand) -BackgroundColor:('Black') -ForegroundColor:('Magenta') | Tee-Object -FilePath:($LogFilePath) -Append
                            Invoke-Expression -Command:($BuildModuleCommand) | Tee-Object -FilePath:($LogFilePath) -Append
                        }
                    }
                }
                ###########################################################################
                # Add prerelease tag
                If (-not [System.String]::IsNullOrEmpty($PrereleaseName))
                {
                    $CurrentMetaData = Get-Metadata -Path:($psd1Path) -PropertyName:('PSData')
                    If ([System.String]::IsNullOrEmpty($CurrentMetaData.Prerelease))
                    {
                        Write-Host ('[RUN COMMAND] Updating module manifest: Prerelease') -BackgroundColor:('Black') -ForegroundColor:('Magenta')
                        $CurrentMetaData.Add('Prerelease', $PrereleaseName)
                        Update-ModuleManifest -Path:($psd1Path) -PrivateData:($CurrentMetaData)
                    }
                }
                ###########################################################################
                If ($TestModule)
                {
                    If (-not [System.String]::IsNullOrEmpty($env:JCApiKey) -and -not [System.String]::IsNullOrEmpty($env:JCOrgId))
                    {
                        Write-Host ('[VALIDATION] JCApiKey AND JCOrgId have been populated.') -BackgroundColor:('Black') -ForegroundColor:('Magenta')
                        # Tmp workaround
                        $checkDependenciesModuleContent = Get-Content -Path:($checkDependenciesModulePath) -Raw
                        $checkDependenciesModuleContent.Replace('autorest-beta', 'autorest') | Set-Content -Path:($checkDependenciesModulePath)
                        # Temp workaround untill autorest updates to use Pester V5 syntax
                        $testModuleContent = Get-Content -Path:($testModulePath) -Raw
                        $PesterTestsContent = Get-Content -Path:($RunPesterTestsFilePath) -Raw
                        # $testModuleContent.Replace('Invoke-Pester -Script @{ Path = $testFolder } -EnableExit -OutputFile (Join-Path $testFolder "$moduleName-TestResults.xml")', 'Invoke-Pester -Path "' + $TestFolderPath + '" -PassThru | Export-NUnitReport -Path "' + $PesterTestResultPath + '"') | Set-Content -Path:($testModulePath)
                        $testModuleContent.Replace('Invoke-Pester -Script @{ Path = $testFolder } -EnableExit -OutputFile (Join-Path $testFolder "$moduleName-TestResults.xml")', $PesterTestsContent) | Set-Content -Path:($testModulePath)
                        $testModuleContent.Replace('Import-Module -Name Az.Accounts', '# Import-Module -Name Az.Accounts') | Set-Content -Path:($testModulePath)
                        # Test module
                        Install-Module -Name Pester -RequiredVersion '4.10.1' -Force
                        # ./test-module.ps1 -Isolated # Not sure when to use this yet
                        # ./test-module.ps1 -Record # Run to create playback files
                        # ./test-module.ps1 -Playback # Run once playback files have been created
                        # ./test-module.ps1 -Live # Run to query against real API
                        $TestModuleCommand = $testModulePath + ' -Live'  # Run to query against real API
                        Write-Host ('[RUN COMMAND] ' + $TestModuleCommand) -BackgroundColor:('Black') -ForegroundColor:('Magenta') | Tee-Object -FilePath:($LogFilePath) -Append
                        # Run test-module script as a job in a new session to avoid "did you forget to close your session?" error
                        $TestModuleJob = Start-Job -ScriptBlock:( {
                                param ($TestModuleCommand);
                                Invoke-Expression -Command:($TestModuleCommand)
                            }) -ArgumentList:($TestModuleCommand)
                        $TestModuleJobStatus = Wait-Job -Id:($TestModuleJob.Id)
                        $TestModuleJobStatus | Receive-Job | Tee-Object -FilePath:($LogFilePath) -Append
                        If (Test-Path -Path:($PesterTestResultPath))
                        {
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
                                Write-Error ("Tests Failed: $([string]($FailedTests | Measure-Object).Count)")
                            }
                        }
                    }
                    Else
                    {
                        Write-Error ("JCApiKey and JCOrgId have not been set.")
                    }
                }
                Else
                {
                    Write-Warning ('Skipping TestModule.')
                }
                ###########################################################################
                # Remove auto generated .gitignore files
                If ($ModifyGitIgnore)
                {
                    $GitIgnoreFiles = Get-ChildItem -Path:($OutputFullPath) -Recurse -File | Where-Object { $_.Extension -eq '.gitignore' }
                    $GitIgnoreFiles | ForEach-Object {
                        $GitIgnoreContent = Get-Content -Path:($_.FullName) -Raw
                        $GitIgnoreContent = $GitIgnoreContent.Replace('exports', "exports`n!docs/exports")
                        $GitIgnoreContent = $GitIgnoreContent.Replace('generated', "generated`n!custom/generated")
                        $GitIgnoreContent | Set-Content -Path:($_.FullName)
                    }
                }
                ###########################################################################
                # Remove auto generated Az module
                If ($RemoveAzAccounts)
                {
                    If (Test-Path -Path:($AzAccountsPath))
                    {
                        Remove-Item -Path:($AzAccountsPath) -Force -Recurse
                    }
                }
                ###########################################################################
                # Add GitHub Packages required attributes
                If ($ModifyNuspec)
                {
                    $nuspecContent = [System.Xml.XmlDocument](Get-Content -Path:($nuspecPath) )
                    $repository = $nuspecContent.package.metadata.AppendChild($nuspecContent.CreateElement('repository', $nuspecContent.DocumentElement.NamespaceURI))
                    $repository.SetAttribute('type', 'git')
                    $repository.SetAttribute('url', $env:CIRCLE_REPOSITORY_URL)
                    $nuspecContent.Save($nuspecPath)
                }
                ###########################################################################
                # One last built to generate nupkg
                $BuildModuleCommand = "$buildModulePath -Docs -Release -Pack"
                Write-Host ('[RUN COMMAND] ' + $BuildModuleCommand) -BackgroundColor:('Black') -ForegroundColor:('Magenta') | Tee-Object -FilePath:($LogFilePath) -Append
                Invoke-Expression -Command:($BuildModuleCommand) | Tee-Object -FilePath:($LogFilePath) -Append
                ##########################################################################
                # Update module GUID
                If ($UpdateModuleGuid -and -not [System.String]::IsNullOrEmpty($PublishedModule))
                {
                    Write-Host ('[RUN COMMAND] Updating module GUID to existing value: ' + $PublishedModule.AdditionalMetadata.GUID) -BackgroundColor:('Black') -ForegroundColor:('Magenta')
                    Update-ModuleManifest -Path:($psd1Path) -Guid:($PublishedModule.AdditionalMetadata.GUID)
                    $moduleMdContent = Get-Content -Path:($moduleMdPath) -Raw
                    $GuidMatch = $moduleMdContent | Select-String -Pattern:([regex]'(Module Guid:)(.*?)(\n)')
                    $moduleMdContent.Replace($GuidMatch.Matches.Value, "Module Guid: $($PublishedModule.AdditionalMetadata.GUID)`n") | Set-Content -Path:($moduleMdPath)
                }
                ##########################################################################
                If ($env:CIRCLECI -eq $true)
                {
                    Write-Host ('[COMMITTING MODULE] changes back into "' + $env:CIRCLE_BRANCH + '"' ) -BackgroundColor:('Black') -ForegroundColor:('Magenta')
                    Try
                    {
                        $UserEmail = If ($env:CIRCLE_PROJECT_USERNAME) { $env:CIRCLE_PROJECT_USERNAME } Else { ($env:USERNAME).Replace(' ', '') + '@FakeEmail.com' }
                        $UserName = If ($env:CIRCLE_PROJECT_USERNAME) { $env:CIRCLE_PROJECT_USERNAME } Else { $env:USERNAME }
                        Set-Location -Path:($BaseFolder)
                        ./Invoke-Git.ps1 -Arguments:('config user.email "' + $UserEmail + '";')
                        ./Invoke-Git.ps1 -Arguments:('config user.name "' + $UserName + '";')
                        ./Invoke-Git.ps1 -Arguments:('add -A')
                        ./Invoke-Git.ps1 -Arguments:('status')
                        ./Invoke-Git.ps1 -Arguments:('commit -m ' + '"Updating module: ' + $ModuleName + ';[skip ci]";')
                        ./Invoke-Git.ps1 -Arguments:('push origin HEAD:refs/heads/' + $env:CIRCLE_BRANCH + ';')
                    }
                    Catch
                    {
                        Write-Error $_
                    }
                }
                ###########################################################################
                If ($PublishModule)
                {
                    Write-Host ('[PUBLISHING MODULE] from "' + $extractedModulePath + '" to "' + $PSRepoName + '"' ) -BackgroundColor:('Black') -ForegroundColor:('Magenta')
                    If ($PSRepoName -eq 'PSGallery')
                    {
                        Publish-Module -Repository:($PSRepoName) -Path:($extractedModulePath) -SkipAutomaticTags -NuGetApiKey:($NuGetApiKey) -Force -Verbose
                    }
                    Else
                    {
                        # Create the local PSRepository if it does not exist
                        If (!(Get-PSRepository -Name:($PSRepoName) -ErrorAction:('Ignore')))
                        {
                            # Create the local PSRepository path if it does not exist
                            If (!(Test-Path -Path:($PSRepoPath))) { New-Item -Path:($PSRepoPath) -ItemType:('Directory') | Out-Null }
                            Write-Host ('Creating new PSRepository: ' + $PSRepoName) -BackgroundColor:('Black') -ForegroundColor:('Green')
                            Register-PSRepository -Name:($PSRepoName) -SourceLocation:($PSRepoPath) -ScriptSourceLocation:($PSRepoPath) -InstallationPolicy:('Trusted')
                            # Unregister-PSRepository -Name:($PSRepoName)
                        }
                        Publish-Module -Repository:($PSRepoName) -Path:($extractedModulePath) -SkipAutomaticTags
                    }
                }
                ###########################################################################
                Set-Location -Path:($OutputFullPath)
                # Invoke-Expression -Command:("$BaseFolder/nuget.exe pack $OutputFullPath\$ModuleName.csproj -NonInteractive -OutputDirectory $BaseFolder -Symbols -version $BuildVersion -Verbosity Detailed") | Tee-Object -FilePath:($LogFilePath) -Append
                Write-Host ("$OutputFullPath - $BuildVersion") -BackgroundColor:('Black') -ForegroundColor:('Magenta')
            }
            Else
            {
                Write-Warning ($APIName + ' spec is up to date.')
            }
        }
        Else
        {
            Write-Error ("Unable to find file: $ConfigFilePath")
        }
        # Mark Updated Spec in Pipeline
        Return $UpdatedSpec
    }
}
Catch
{
    Write-Error $_
}
