#Requires -PSEdition Core
#Requires -Modules powershell-yaml, BuildHelpers
Param(
    [Parameter(Mandatory = $true, ValueFromPipelineByPropertyName = $true, HelpMessage = 'Name of the SDK to build.')][ValidateSet('JumpCloud.SDK.DirectoryInsights', 'JumpCloud.SDK.V1', 'JumpCloud.SDK.V2')][ValidateNotNullOrEmpty()][System.String[]]$SDKName
    , [Parameter(Mandatory = $false, ValueFromPipelineByPropertyName = $true, HelpMessage = 'Specify module version number to set manually.')][System.String]$ManualModuleVersion
    , [Parameter(Mandatory = $false, ValueFromPipelineByPropertyName = $true, HelpMessage = 'Populate to make module version a prerelease.')][System.String]$PrereleaseName = ''
    , [Parameter(Mandatory = $false, ValueFromPipelineByPropertyName = $true, HelpMessage = 'Excluded folder in root from being removed')][ValidateNotNullOrEmpty()][System.String[]]$FolderExcludeList = @('examples', 'test')
    , [Parameter(Mandatory = $false, ValueFromPipelineByPropertyName = $true, HelpMessage = 'Set the module version increment type.')][ValidateSet('Major', 'Minor', 'Patch', 'Manual')][ValidateNotNullOrEmpty()][System.String]$ModuleVersionIncrementType
    , [Parameter(Mandatory = $false, ValueFromPipelineByPropertyName = $true, HelpMessage = '$true to run the ApiTransform.ps1 file.')][ValidateNotNullOrEmpty()][System.Boolean]$RunApiTransform = $true
    , [Parameter(Mandatory = $false, ValueFromPipelineByPropertyName = $true, HelpMessage = '$true to increment the module version.')][ValidateNotNullOrEmpty()][System.Boolean]$IncrementModuleVersion = $true
    , [Parameter(Mandatory = $false, ValueFromPipelineByPropertyName = $true, HelpMessage = '$true to run AutoRest to generate the module.')][ValidateNotNullOrEmpty()][System.Boolean]$GenerateModule = $true
    , [Parameter(Mandatory = $false, ValueFromPipelineByPropertyName = $true, HelpMessage = '$true to copy files from the custom directory to the SDK.')][ValidateNotNullOrEmpty()][System.Boolean]$CopyCustomFiles = $true
    , [Parameter(Mandatory = $false, ValueFromPipelineByPropertyName = $true, HelpMessage = '$true to run build-module.ps1 ')][ValidateNotNullOrEmpty()][System.Boolean]$BuildModule = $true
    , [Parameter(Mandatory = $false, ValueFromPipelineByPropertyName = $true, HelpMessage = '$true to run BuildCustomFunctions.ps1')][ValidateNotNullOrEmpty()][System.Boolean]$BuildCustomFunctions = $true
    , [Parameter(Mandatory = $false, ValueFromPipelineByPropertyName = $true, HelpMessage = '$true to update the module guid.')][ValidateNotNullOrEmpty()][System.Boolean]$UpdateModuleGuid = $true
    , [Parameter(Mandatory = $false, ValueFromPipelineByPropertyName = $true, HelpMessage = '$true to perform customizations to test-module.ps1 file.')][ValidateNotNullOrEmpty()][System.Boolean]$TestModulePrep = $true
    , [Parameter(Mandatory = $false, ValueFromPipelineByPropertyName = $true, HelpMessage = '$true to modify the AutoRest .gitignore file')][ValidateNotNullOrEmpty()][System.Boolean]$ModifyGitIgnore = $true
    , [Parameter(Mandatory = $false, ValueFromPipelineByPropertyName = $true, HelpMessage = '$true to add GitHub Packages required attributes')][ValidateNotNullOrEmpty()][System.Boolean]$ModifyNuspec = $true
    , [Parameter(Mandatory = $false, ValueFromPipelineByPropertyName = $true, ParameterSetName = 'Publish', HelpMessage = 'Set to $true to publish the module to a repository.')][ValidateNotNullOrEmpty()][System.Boolean]$PublishModule = $false
    , [Parameter(Mandatory = $false, ValueFromPipelineByPropertyName = $true, ParameterSetName = 'Publish', HelpMessage = 'Specify the PowerShell repository to deploy to.')][ValidateNotNullOrEmpty()][System.String]$PSRepoName = 'PSGallery'
    , [Parameter(Mandatory = $false, ValueFromPipelineByPropertyName = $true, ParameterSetName = 'Publish', HelpMessage = 'NuGetApiKey for your repository.')][ValidateNotNullOrEmpty()][System.String]$NuGetApiKey = ''
)
# https://github.com/Azure/autorest/blob/master/docs/powershell/options.md
# CI Variables
$CurrentBranch = If ([System.String]::IsNullOrEmpty($env:CIRCLE_BRANCH)) { git branch --show-current } Else { $env:CIRCLE_BRANCH }
$BuildNumber = If ([System.String]::IsNullOrEmpty($env:CIRCLE_BUILD_NUM)) { '0000' } Else { $env:CIRCLE_BUILD_NUM }
$RepoUrl = If ([System.String]::IsNullOrEmpty($env:CIRCLE_REPOSITORY_URL)) { 'https://github.com/TheJumpCloud/jcapi-powershell' } Else { $env:CIRCLE_REPOSITORY_URL }
# Start script
ForEach ($SDK In $SDKName)
{
    $ConfigFilePath = '{0}/Configs/{1}.yaml' -f $PSScriptRoot, $SDK
    $ApiTransformPath = '{0}/ApiTransform.ps1' -f $PSScriptRoot
    If (Test-Path -Path:($ConfigFilePath))
    {
        # Run API Transform step
        If ($RunApiTransform)
        {
            .($ApiTransformPath) -SDKName:($SDK) # -NoUpdate # | Out-Null
        }
        # Start SDK generation
        $ConfigFile = Get-Item -Path:($ConfigFilePath)
        $ConfigFileFullName = $ConfigFile.FullName
        $ConfigContent = Get-Content -Path:($ConfigFileFullName) -Raw
        $BaseFolder = $PSScriptRoot
        Set-Location $BaseFolder
        ###########################################################################
        # Get config values
        $Config = $ConfigContent | ConvertFrom-Yaml
        # Write current branch back to config file
        $Config.branch = $CurrentBranch
        $Config | ConvertTo-Yaml -OutFile:($ConfigFileFullName) -force
        $OutputFullPath = '{0}/{1}' -f $BaseFolder, [System.String]$Config.'output-folder'
        $ToolsFolderPath = '{0}/Tools' -f $BaseFolder
        $RunPesterTestsFilePath = '{0}/RunPesterTests.ps1' -f $ToolsFolderPath
        $CleanScript = '{0}/clean.sh' -f $ToolsFolderPath
        $ModuleName = [System.String]$Config.'module-name'
        $Namespace = [System.String]$Config.'namespace'
        $ConfigPrefix = $Config.prefix | Select-Object -First 1
        $ConfigCustomFunctionPrefix = $Config.customFunctionPrefix
        $SwaggerSpecFilePath = '{0}/SwaggerSpecs/{1}.json' -f $BaseFolder, $ModuleName
        $LogFilePath = '{0}/{1}.log' -f $OutputFullPath, $ModuleName
        $ModuleVersion = [System.String]$Config.'module-version'
        $binFolder = '{0}/bin' -f $OutputFullPath
        $extractedModulePath = '{0}/{1}' -f $binFolder, $ModuleName
        $CustomFolderSourcePath = '{0}/Custom' -f $PSScriptRoot
        $CustomFolderPath = '{0}/custom' -f $OutputFullPath
        $GeneratedFolderPath = '{0}/generated' -f $CustomFolderPath
        $exportsFolderPath = '{0}/exports' -f $OutputFullPath
        $TestFolderPath = '{0}/test' -f $OutputFullPath
        $ExamplesFolderPath = '{0}/examples' -f $OutputFullPath
        $DocsFolderPath = '{0}/docs/exports' -f $OutputFullPath
        $buildModulePath = '{0}/build-module.ps1' -f $OutputFullPath
        $testModulePath = '{0}/test-module.ps1' -f $OutputFullPath
        $checkDependenciesModulePath = '{0}/check-dependencies.ps1' -f $OutputFullPath
        $psd1Path = '{0}/{1}.psd1' -f $OutputFullPath, $ModuleName
        $nuspecPath = '{0}/{1}.nuspec' -f $OutputFullPath, $ModuleName
        $internalFolderPath = '{0}/internal' -f $OutputFullPath, $ModuleName
        $internalPsm1 = '{0}/{1}.internal.psm1' -f $internalFolderPath, $ModuleName
        $moduleMdPath = '{0}/{1}.md' -f $DocsFolderPath, $ModuleName
        $CustomHelpProxyType = '{0}/generated/runtime/BuildTime/Models/PsProxyTypes.cs' -f $OutputFullPath
        $BuildCustomFunctionsPath = '{0}/BuildCustomFunctions.ps1 -ConfigPath:("{1}") -psd1Path:("{2}") -CustomFolderPath:("{3}") -ExamplesFolderPath:("{4}") -TestFolderPath:("{5}")' -f [System.String]$BaseFolder, [System.String]$ConfigFileFullName, [System.String]$internalPsm1, [System.String]$GeneratedFolderPath, [System.String]$ExamplesFolderPath, [System.String]$TestFolderPath
        $npmDependencies = Get-Content "$BaseFolder/package.json" | ConvertFrom-Json
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
                    ElseIf ($ModuleVersionIncrementType -eq 'Manual')
                    {
                        # For Manual type, use the version specified in the config file
                        [System.Version]$Config.'module-version'
                    }
                    Else
                    {
                        # for step-version if the $moduleVersionIncrementType is Patch change it to be Build
                        If ($ModuleVersionIncrementType -eq 'Patch')
                        {
                            $stepVersionType = 'Build'
                        }
                        else {
                            $stepVersionType = $ModuleVersionIncrementType
                        }
                        Step-Version -Version:(($PublishedModule.Version -split '-')[0]) -By:($stepVersionType)
                    }
                    Write-Host ('[RUN COMMAND] Increment module version number to: ' + $ModuleVersion) -BackgroundColor:('Black') -ForegroundColor:('Magenta')
                    $ConfigContent = $ConfigContent -Replace ("(module-version: )([0-9]\d*)\.([0-9]\d*)\.([0-9]\d*)", "module-version: $($ModuleVersion)")
                    $ConfigContent.Trim() | Out-File -FilePath:($ConfigFilePath) -Force
                }
            }
        }
        $BuildVersion = "$($ModuleVersion)-$($BuildNumber)"
        ###########################################################################
        If ($GenerateModule)
        {
            If (Test-Path -Path:($OutputFullPath)) { Get-ChildItem -Path:($OutputFullPath) | Where-Object { $_.Name -notin $FolderExcludeList } | Remove-Item -Force -Recurse }
            If (!(Test-Path -Path:($OutputFullPath))) { New-Item -Path:($OutputFullPath) -ItemType:('Directory') }
            if ($IsMacOS -or $IsLinux)
            {
                Write-Host ('[RUN COMMAND] Clean Script') -BackgroundColor:('Black') -ForegroundColor:('Magenta')
                # check if the /bin /obj directories need to permissions reset and deleted before continuing.
                bash $CleanScript $PSScriptRoot $OutputFullPath
            }
            Write-Host ('[RUN COMMAND] autorest ' + $ConfigFileFullName + ' --force --verbose --debug') -BackgroundColor:('Black') -ForegroundColor:('Magenta')
            npx autorest $ConfigFileFullName --force --version:$($npmDependencies.dependencies.'@autorest/core') --use:@autorest/powershell@$($npmDependencies.dependencies.'@autorest/powershell') | Out-Null
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
            Copy-Item -Path:("$SwaggerSpecFilePath") -Destination:([System.String]$CustomFolderPath) -Force
        }
        ###########################################################################
        If ($BuildModule)
        {
            # For V1, V2 builds, apply this change to the generated c# code to filter correctly
            if (($SDKName -eq "JumpCloud.SDK.V1") -or ($SDKName -eq "JumpCloud.SDK.V2")) {
                # Modify .cs file "https://github.com/Azure/autorest/issues/3604" #autorest does not support even the "collectionFormat": "multi" in my testing
                $inputFile = Get-Content -Path "$OutputFullPath/generated/api/JumpCloudApi.cs" -Raw
                # Replace the filter logic to use indexed array parameters: filter[0]=..., filter[1]=..., etc.
                # Pattern matches both filter.Length and filter.Count variations, with flexible whitespace
                # Also handles both patterns: with and without EscapeDataString wrapper

                # Pattern 1: Without EscapeDataString (V1 SDK)
                $newFile = $inputFile -replace '\(null != filter\s+&&\s+filter\.(Length|Count)\s+>\s+0\s+\?\s+"filter="\s+\+\s+\(global::System\.Linq\.Enumerable\.Aggregate\(filter,\s+\(current,\s+each\)\s+=>\s+current\s+\+\s+","\s+\+\s+\(\s+null\s+==\s+each\s+\?\s+global::System\.String\.Empty\s+:\s+each\.ToString\(\)\s*\)\s*\)\s*\)\s+:\s+global::System\.String\.Empty\)', '(null != filter  && filter.Count > 0 ? global::System.Linq.Enumerable.Aggregate(global::System.Linq.Enumerable.Select(filter, (value, index) => new { value, index }), "", (current, item) => current + (item.index > 0 ? "&" : "") + "filter[" + item.index + "]=" + (item.value?.ToString() ?? global::System.String.Empty)) : global::System.String.Empty)'

                # Pattern 2: With EscapeDataString (V2 SDK)
                $newFile = $newFile -replace '\(null != filter\s+&&\s+filter\.(Length|Count)\s+>\s+0\s+\?\s+"filter="\s+\+\s+global::System\.Uri\.EscapeDataString\(global::System\.Linq\.Enumerable\.Aggregate\(filter,\s+\(current,\s+each\)\s+=>\s+current\s+\+\s+","\s+\+\s+\(\s+null\s+==\s+each\s+\?\s+global::System\.String\.Empty\s+:\s+each\.ToString\(\)\s*\)\s*\)\s*\)\s+:\s+global::System\.String\.Empty\)', '(null != filter  && filter.Count > 0 ? global::System.Linq.Enumerable.Aggregate(global::System.Linq.Enumerable.Select(filter, (value, index) => new { value, index }), "", (current, item) => current + (item.index > 0 ? "&" : "") + "filter[" + item.index + "]=" + global::System.Uri.EscapeDataString(item.value?.ToString() ?? global::System.String.Empty)) : global::System.String.Empty)'

                Set-Content -Path "$OutputFullPath/generated/api/JumpCloudApi.cs" -Value $newFile
            }
            $BuildModuleContent = Get-Content -Path:($buildModulePath) -Raw
            $BuildModuleContent.Replace('Export-ExampleStub -ExportsFolder', '#Export-ExampleStub -ExportsFolder') | Set-Content -Path:($buildModulePath)
            $BuildModuleCommand = "$buildModulePath -Release"
            if ($IsMacOS -or $IsLinux)
            {
                Write-Host ('[RUN COMMAND] Clean Script') -BackgroundColor:('Black') -ForegroundColor:('Magenta')
                bash $CleanScript $PSScriptRoot $OutputFullPath
            }
            Write-Host ('[RUN COMMAND] ' + $BuildModuleCommand) -BackgroundColor:('Black') -ForegroundColor:('Magenta') | Tee-Object -FilePath:($LogFilePath) -Append
            # fix docs help link
            $PsProxyTypes = (Get-Content $CustomHelpProxyType -Raw)
            $OnlineVersionPsProxyTypes = [Regex]::Replace($PsProxyTypes, ('\$\@\"{HelpLinkPrefix}.*'), '$@"{HelpLinkPrefix}{variantGroup.ModuleName}/docs/exports/{variantGroup.CmdletName}.md";', [System.Text.RegularExpressions.RegexOptions]::IgnoreCase);
            Set-Content -Path:($CustomHelpProxyType) -Value:($OnlineVersionPsProxyTypes)
            # before building the module, remove the generate-portal-ux.ps1 from the module directory, we don't need it and will not be building for Azure Portal UX at this time.
            If (Test-Path $OutputFullPath/generate-portal-ux.ps1) {
                write-Host ('[REMOVING] generate-portal-ux.ps1 from module directory.') -BackgroundColor:('Black') -ForegroundColor:('Magenta')
                Remove-Item -Path $OutputFullPath/generate-portal-ux.ps1 -Force
            }
            # After AutoRest generation, create a ModuleIdentifier.cs file for each SDK
            $moduleIdentifierPath = "$OutputFullPath/custom/ModuleIdentifier.cs"
            $sdkIdentifier = switch ($SDKNameItem) {
                'JumpCloud.SDK.DirectoryInsights' { 'DirectoryInsights' }
                'JumpCloud.SDK.V1' { 'V1' }
                'JumpCloud.SDK.V2' { 'V2' }
            }

            $moduleIdentifierContent = @"
namespace ModuleNameSpace
{
    public static class ModuleIdentifier
    {
        public const string SDKName = "$sdkIdentifier";
    }
}
"@
            Set-Content -Path $moduleIdentifierPath -Value $moduleIdentifierContent -Force
            # build the module
            $BuildModuleCommandJob = Start-Job -ArgumentList:($BuildModuleCommand) -ScriptBlock:( { param ($BuildModuleCommand);
                    Invoke-Expression -Command:($BuildModuleCommand)
                })
            $BuildModuleCommandJobStatus = Wait-Job -Id:($BuildModuleCommandJob.Id)
            $BuildModuleCommandJobStatus | Receive-Job | Tee-Object -FilePath:($LogFilePath) -Append

            # Add environment-based parameter defaults to the main .psm1 file
            $mainPsm1Path = "$OutputFullPath/$ModuleName.psm1"
            if (Test-Path $mainPsm1Path) {
                $psm1Content = Get-Content -Path $mainPsm1Path -Raw
                $environmentSwitchBlock = @"
switch (`$env:JCEnvironment) {
  'STANDARD' {
      `$Global:PSDefaultParameterValues['*-JcSdk*:ApiHost'] = 'api'
      `$Global:PSDefaultParameterValues['*-JcSdk*:ConsoleHost'] = 'console'
   }
  'EU' {
      `$Global:PSDefaultParameterValues['*-JcSdk*:ApiHost'] = 'api.eu'
      `$Global:PSDefaultParameterValues['*-JcSdk*:ConsoleHost'] = 'console.eu'
   }
  Default {}
}
"@
                # Append the switch block at the end of the file
                $psm1Content += "`n$environmentSwitchBlock"
                Set-Content -Path $mainPsm1Path -Value $psm1Content
                Write-Host ('[ADDED] Environment-based parameter defaults to module .psm1 file.') -BackgroundColor:('Black') -ForegroundColor:('Magenta')
            }

        }
        ###########################################################################
        If ($BuildCustomFunctions)
        {
            Write-Host ('[RUN COMMAND] ' + $BuildCustomFunctionsPath) -BackgroundColor:('Black') -ForegroundColor:('Magenta') | Tee-Object -FilePath:($LogFilePath) -Append
            # Run build custom functions script as a job in a new session to avoid "did you forget to close your session?" error
            $BuildCustomFunctionsJob = Start-Job -ArgumentList:($BuildCustomFunctionsPath) -ScriptBlock:( { param ($BuildCustomFunctionsPath);
                    Invoke-Expression -Command:($BuildCustomFunctionsPath)
                })
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
                    if ($IsMacOS -or $IsLinux)
                    {
                        Write-Host ('[RUN COMMAND] Clean Script') -BackgroundColor:('Black') -ForegroundColor:('Magenta')
                        bash $CleanScript $PSScriptRoot $OutputFullPath
                    }
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
                    if ($IsMacOS -or $IsLinux)
                    {
                        Write-Host ('[RUN COMMAND] Clean Script') -BackgroundColor:('Black') -ForegroundColor:('Magenta')
                        bash $CleanScript $PSScriptRoot $OutputFullPath
                    }
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
        If ($TestModulePrep)
        {
            # Tmp workaround
            $checkDependenciesModuleContent = Get-Content -Path:($checkDependenciesModulePath) -Raw
            $checkDependenciesModuleContent.Replace("autorest .\README.md", "npx autorest .\README.md --version:$($npmDependencies.dependencies.'@autorest/core')") | Set-Content -Path:($checkDependenciesModulePath)
            # Temp workaround until autorest updates to use Pester V5 syntax
            $testModuleContent = Get-Content -Path:($testModulePath) -Raw
            $PesterTestsContent = Get-Content -Path:($RunPesterTestsFilePath) -Raw
            # Replace if else Invoke-Pester block with contents from runpestertests file.
            $InvokePesterLine = $testModuleContent | Select-String -Pattern '(.*?if)(.*?\(\$null -ne \$TestName\))([\s\S]*?)(Invoke-Pester.*?.xml"\))([\s\S]*?)(Invoke-Pester.*?.xml"\))([\s\S]*?)(\})'
            If ([System.String]::IsNullOrEmpty($InvokePesterLine.Matches.Value))
            {
                Write-Error ("Unable to find Invoke-Pester line in $testModulePath")
            }
            $testModuleContent = $testModuleContent.Replace($InvokePesterLine.Matches.Value, $PesterTestsContent)
            $testModuleContent = $testModuleContent.Replace('Import-Module -Name Az.Accounts', '# Import-Module -Name Az.Accounts')
            $testModuleContent | Set-Content -Path:($testModulePath)
            # update the loadEnv.ps1 file for each SDK to set the default hostEnv while testing:
            $loadEnvContent = Get-Content -Path:("$TestFolderPath/loadEnv.ps1") -Raw
            $loadContentToAdd = @"

# Determine default host values based on environment
`$apiHost = 'api'
`$consoleHost = 'console'

if (`$env:JCEnvironment -eq 'EU') {
    `$apiHost = 'api.eu'
    `$consoleHost = 'console.eu'
}

# Set both parameter defaults so all SDKs work correctly
`$PSDefaultParameterValues['*-JcSdk*:ApiHost'] = `$apiHost
`$PSDefaultParameterValues['*-JcSdk*:ConsoleHost'] = `$consoleHost
# Write-Host "Test environment loaded. ApiHost set to: `$apiHost, ConsoleHost set to: `$consoleHost"
"@
            # append to the end of the loadEnv.ps1 file
            $loadEnvContent += $loadContentToAdd
            $loadEnvContent | Set-Content -Path:("$TestFolderPath/loadEnv.ps1")
        }
        ###########################################################################
        # Remove auto generated .gitignore files
        If ($ModifyGitIgnore)
        {
            $GitIgnoreFiles = Get-ChildItem -Path:($OutputFullPath) -Recurse -File -Hidden | Where-Object { $_.Extension -eq '.gitignore' }
            $GitIgnoreFiles | ForEach-Object {
                $GitIgnoreContent = Get-Content -Path:($_.FullName) -Raw
                $GitIgnoreContent = $GitIgnoreContent.Replace('exports', "exports`n!docs/exports")
                $GitIgnoreContent = $GitIgnoreContent.Replace('generated', "generated`n!custom/generated")
                $GitIgnoreContent | Set-Content -Path:($_.FullName)
            }
        }
        ###########################################################################
        # Add GitHub Packages required attributes
        If ($ModifyNuspec)
        {
            $nuspecContent = [System.Xml.XmlDocument](Get-Content -Path:($nuspecPath) )
            $repository = $nuspecContent.package.metadata.AppendChild($nuspecContent.CreateElement('repository', $nuspecContent.DocumentElement.NamespaceURI))
            $repository.SetAttribute('type', 'git')
            $repository.SetAttribute('url', $RepoUrl)
            $nuspecContent.Save($nuspecPath)
        }
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
        Write-Host ("$OutputFullPath - $BuildVersion") -BackgroundColor:('Black') -ForegroundColor:('Magenta')
    }
    Else
    {
        Write-Error ("Unable to find file: $ConfigFilePath")
    }
}
