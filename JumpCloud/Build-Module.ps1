$OutputPath = $PSScriptRoot + '/JumpCloudV2/'
$IndentChar = '    '
$MSCopyrightHeader = "`n# ----------------------------------------------------------------------------------`n#`n# Copyright Microsoft Corporation`n# Licensed under the Apache License, Version 2.0 (the ""License"");`n# you may not use this file except in compliance with the License.`n# You may obtain a copy of the License at`n# http://www.apache.org/licenses/LICENSE-2.0`n# Unless required by applicable law or agreed to in writing, software`n# distributed under the License is distributed on an ""AS IS"" BASIS,`n# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.`n# See the License for the specific language governing permissions and`n# limitations under the License.`n# ----------------------------------------------------------------------------------`n"
$Divider = '|#|#|#|#|#|#|#|#|#|#|#|#|#|#|#|'
$FunctionTemplate = "{0}`nFunction {1}`n{{`n$($IndentChar)#Requires {2}`n$($IndentChar){3}`n$($IndentChar)Param(`n{4}`n$($IndentChar))`n$($IndentChar)Begin`n$($IndentChar){{`n{5}`n$($IndentChar)}}`n$($IndentChar)Process`n$($IndentChar){{`n{6}`n$($IndentChar)}}`n$($IndentChar)End`n$($IndentChar){{`n{7}`n$($IndentChar)}}`n}}"
$ScriptAnalyzerResults = @()
If (Test-Path -Path:($OutputPath))
{
    Remove-Item -Path:($OutputPath) -Recurse -Force
}
If (Get-Module -Name($ModuleNames))
{
    $Commands = Get-Command -Module:($ModuleNames) # -Verb:('Get') -Noun:('JcSdkApplication') # Use to troubleshoot single command
    ForEach ($Command In $Commands)
    {
        # Create new function name
        $ModuleName = $Command.Module.Name
        $CommandName = $Command.Name
        $NewFunctionName = $CommandName.Replace($ModulePrefix, 'JC')
        # Get content from sdk function
        $CommandFilePath = $Command.ScriptBlock.File
        $CommandFilePathContent = Get-Content -Path:($CommandFilePath) -Raw
        $FunctionContent = If ($CommandFilePath -like '*ProxyCmdletDefinitions.ps1')
        {
            <# When the autorest generated module has been installed and imported from the PSGallery all the
            cmdlets will exist in a single ProxyCmdletDefinitions.ps1 file. We need to parse
            out the specific function in order to gather the parts we need to copy over. #>
            $CommandFilePathContent.Replace($MSCopyrightHeader, $Divider).Split($Divider).Where( { $_ -like ('*' + "function $CommandName {" + '*') })
        }
        Else
        {
            <# When the autorest generated module has been imported from a local psd1 module the function will
            remain in their individual files. #>
            $CommandFilePathContent
        }
        # Extract the sections we want to copy over to our new function.
        $Params = $FunctionContent | Select-String -Pattern:('(?s)(    \[Parameter)(.*?)(\})') -AllMatches
        $PSScriptInfo = ($FunctionContent | Select-String -Pattern:('(?s)(<#)(.*?)(#>)')).Matches.Value
        $OutputType = ($FunctionContent | Select-String -Pattern:('(\[OutputType)(.*?)(\]\r)')).Matches.Value
        $CmdletBinding = ($FunctionContent | Select-String -Pattern:('(\[CmdletBinding)(.*?)(\]\r)')).Matches.Value
        # Filter/Manipulate extracted content
        $ParameterContent = ($Params.Matches.Value | Where-Object { $_ -notlike '*DontShow*' }) -join ",`n`n"
        $PSScriptInfo = $PSScriptInfo.Replace(($PSScriptInfo | Select-String -Pattern:('(?s)(\.Link)(.*?)(docs.microsoft.com)(.*?)(\n)')).Matches.Value, '')
        $PSScriptInfo = $PSScriptInfo.Replace($ModulePrefix, 'JC').Replace('.ToJsonString() | ConvertFrom-Json', '')
        If (-not [System.String]::IsNullOrEmpty($OutputType)) { $CmdletBinding = "$($OutputType)`n$($IndentChar)$($CmdletBinding)" }
        # Build requires statment
        $Requires = "-Modules $ModuleName"
        # # Build new function parameters
        # $CommandParameterSets = $Command.ParameterSets
        # $CommandParameters = $Command.Parameters
        # $CommandDefinition = $Command.Definition
        # # Build parameters by copying them from the SDK function parameters
        # $ParameterContent = ForEach ($CommandParameter In $CommandParameters.GetEnumerator())
        # {
        #     # $ParameterName = $CommandParameter.Key
        #     # $ParameterValue.IsDynamic
        #     # $ParameterValue.SwitchParameter
        #     # $ParameterValue.Attributes.GetEnumerator() | ForEach-Object { $_ | Get-Member }
        #     $ParametersToExclude = @(('Break', 'HttpPipelineAppend', 'HttpPipelinePrepend', 'PassThru', 'Proxy', 'ProxyCredential', 'ProxyUseDefaultCredentials') + [System.Management.Automation.PSCmdlet]::CommonParameters + [System.Management.Automation.PSCmdlet]::OptionalCommonParameters)
        #     $ParameterValue = $CommandParameter.Value
        #     $ParameterName = $ParameterValue.Name
        #     $ParameterType = $ParameterValue.ParameterType
        #     $ParameterTypeFullName = $ParameterType.FullName
        #     $ParameterAliases = $ParameterValue.Aliases
        #     If ($ParameterName -notin $ParametersToExclude)
        #     {
        #         # Build aliases
        #         $Aliases = If (-not [System.string]::IsNullOrEmpty($ParameterAliases))
        #         {
        #             '[Alias(' + $ParameterAliases + ')]'
        #         }
        #         # Build parameter sets
        #         $NewParameterSets = $ParameterValue.ParameterSets.GetEnumerator() | ForEach-Object {
        #             $ParameterSetName = $_.Key
        #             $ParameterSetAttributes = $_.Value
        #             $ParameterSetAttributeProperties = $ParameterSetAttributes.PSObject.Properties
        #             $NewParameterSetAttributes = ForEach ($ParameterSetAttributeProperty In $ParameterSetAttributeProperties)
        #             {
        #                 $ParameterSetAttributePropertyName = $ParameterSetAttributeProperty.Name
        #                 If (-not [System.String]::IsNullOrEmpty($ParameterSetAttributes.$ParameterSetAttributePropertyName))
        #                 {
        #                     # Format the attribute value
        #                     $AttributeValue = Switch ($ParameterSetAttributeProperty.TypeNameOfValue)
        #                     {
        #                         'System.Boolean'
        #                         {
        #                             [System.String]('$' + $ParameterSetAttributes.$ParameterSetAttributePropertyName).ToLower()
        #                         }
        #                         'System.String'
        #                         {
        #                             "'" + $ParameterSetAttributes.$ParameterSetAttributePropertyName + "'"
        #                         }
        #                         'System.Int32'
        #                         {
        #                             $ParameterSetAttributes.$ParameterSetAttributePropertyName
        #                         }
        #                         Default { Write-Error ('Unknown data type: ' + $ParameterSetAttributePropertyName + ' ' + $ParameterSetAttributeProperty.TypeNameOfValue) }
        #                     }
        #                     # Format the attribute name
        #                     If ($ParameterSetAttributePropertyName -eq 'IsMandatory')
        #                     {
        #                         $ParameterSetAttributePropertyName = 'Mandatory'
        #                     }
        #                     # Return key value pair
        #                     If ($AttributeValue -notin ('$false', '-2147483648'))
        #                     {
        #                         "`n$($IndentChar)$($IndentChar)$($IndentChar)" + $ParameterSetAttributePropertyName + " = " + $AttributeValue
        #                     }
        #                 }
        #             }

        #             $ParameterSets = If ($ParameterSetName -eq '__AllParameterSets')
        #             {
        #                 $CommandParameterSets.Name
        #             }
        #             Else
        #             {
        #                 $ParameterSetName
        #             }
        #             $FullParameterString = @()
        #             $ParameterSets | ForEach-Object {
        #                 $ParameterString = $null
        #                 If (-not [System.String]::IsNullOrEmpty($_))
        #                 {
        #                     $ParameterString = "`n$($IndentChar)$($IndentChar)$($IndentChar)ParameterSetName = '" + $_ + "'"
        #                 }
        #                 If (-not [System.String]::IsNullOrEmpty($NewParameterSetAttributes))
        #                 {
        #                     $ParameterString = $ParameterString + "," + ($NewParameterSetAttributes -join ',') + "`n$($IndentChar)$($IndentChar)"
        #                 }
        #                 Else
        #                 {
        #                     $ParameterString = $ParameterString.Trim()
        #                 }
        #                 If (-not [System.String]::IsNullOrEmpty($ParameterString))
        #                 {
        #                     $ParameterString = "$($IndentChar)$($IndentChar)[Parameter(" + $ParameterString + ")]"
        #                     $FullParameterString += $ParameterString
        #                 }
        #             }
        #             ( $FullParameterString -join "`n")
        #         }
        #         # Return full parameter set
        #         If (-not [System.String]::IsNullOrEmpty($NewParameterSets))
        #         {
        #             [System.String](($NewParameterSets -join "`n") + "`n$($IndentChar)$($IndentChar)" + $Aliases + "[" + $ParameterTypeFullName + "]`$" + $ParameterName)
        #         }
        #         Else
        #         {
        #             [System.String]($Aliases + "[" + $ParameterTypeFullName + "]`$" + $ParameterName)
        #         }
        #     }
        # }
        # $ParameterContent = ($ParameterContent -join ",`n")
        # Build $BeginContent, $ProcessContent, and $EndContent
        If ($Command.Verb -in ('Get', 'Search'))
        {
            If (-not [System.String]::IsNullOrEmpty($ParameterContent)) { $ParameterContent = $ParameterContent + ",`n`n$($IndentChar)[System.Boolean]`n$($IndentChar)# Set to `$true to return all results.`n$($IndentChar)`$Paginate = `$true" }
            # Build script content
            If ($ModuleName -eq 'JumpCloud.SDK.DirectoryInsights')
            {
                # Build "Begin" block
                $BeginContent = "$($IndentChar)$($IndentChar)Connect-JCOnline -force | Out-Null
$($IndentChar)$($IndentChar)`$Results = @()
$($IndentChar)$($IndentChar)`$PSBoundParameters.Add('HttpPipelineAppend', {
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)param(`$req, `$callback, `$next)
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)# call the next step in the Pipeline
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)`$ResponseTask = `$next.SendAsync(`$req, `$callback)
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)`$global:JCHttpRequest = `$req
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)`$global:JCHttpRequestContent = `$req.Content.ReadAsStringAsync()
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)`$global:JCHttpResponse = `$ResponseTask
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)Return `$ResponseTask
$($IndentChar)$($IndentChar)$($IndentChar)}
$($IndentChar)$($IndentChar))"
                # Build "Process" block
                $ProcessContent = "$($IndentChar)$($IndentChar)If (`$Paginate)
$($IndentChar)$($IndentChar){
$($IndentChar)$($IndentChar)$($IndentChar)`$PSBoundParameters.Remove('Paginate') | Out-Null
$($IndentChar)$($IndentChar)$($IndentChar)Do
$($IndentChar)$($IndentChar)$($IndentChar){
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)`$Result = $($CommandName) @PSBoundParameters
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)If (-not [System.String]::IsNullOrEmpty(`$Result))
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar){
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)`$XResultSearchAfter = (`$JCHttpResponse.Result.Headers.GetValues('X-Search_after') | ConvertFrom-Json);
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)If ([System.String]::IsNullOrEmpty(`$PSBoundParameters.SearchAfter))
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar){
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)If ([System.String]::IsNullOrEmpty(`$PSBoundParameters.EventQueryBody))
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar){
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)`$PSBoundParameters.Add('SearchAfter', `$XResultSearchAfter)
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)}
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)Else
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar){
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)`$PSBoundParameters.EventQueryBody.SearchAfter = `$XResultSearchAfter
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)}
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)}
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)Else
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar){
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)`$PSBoundParameters.SearchAfter = `$XResultSearchAfter
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)}
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)`$XResultCount = `$JCHttpResponse.Result.Headers.GetValues('X-Result-Count')
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)`$XLimit = `$JCHttpResponse.Result.Headers.GetValues('X-Limit')
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)`$Results += (`$Result).ToJsonString() | ConvertFrom-Json;
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)}
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)Write-Debug (""ResultCount: `$(`$XResultCount); Limit: `$(`$XLimit); XResultSearchAfter: `$(`$XResultSearchAfter); "");
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)Write-Debug ('HttpRequest: ' + `$JCHttpRequest);
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)Write-Debug ('HttpRequestContent: ' + `$JCHttpRequestContent.Result);
$($IndentChar)$($IndentChar)$($IndentChar)}
$($IndentChar)$($IndentChar)$($IndentChar)While (`$XResultCount -eq `$XLimit -and `$Result)
$($IndentChar)$($IndentChar)}
$($IndentChar)$($IndentChar)Else
$($IndentChar)$($IndentChar){
$($IndentChar)$($IndentChar)$($IndentChar)`$PSBoundParameters.Remove('Paginate') | Out-Null
$($IndentChar)$($IndentChar)$($IndentChar)`$Result = $($CommandName) @PSBoundParameters
$($IndentChar)$($IndentChar)$($IndentChar)Write-Debug ('HttpRequest: ' + `$JCHttpRequest);
$($IndentChar)$($IndentChar)$($IndentChar)Write-Debug ('HttpRequestContent: ' + `$JCHttpRequestContent.Result);
$($IndentChar)$($IndentChar)$($IndentChar)If (-not [System.String]::IsNullOrEmpty(`$Result))
$($IndentChar)$($IndentChar)$($IndentChar){
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)`$Results += (`$Result).ToJsonString() | ConvertFrom-Json;
$($IndentChar)$($IndentChar)$($IndentChar)}
$($IndentChar)$($IndentChar)}"
                # Build "End" block
                $EndContent = "$($IndentChar)$($IndentChar)# Clean up global variables
$($IndentChar)$($IndentChar)`$GlobalVars = @('JCHttpRequest', 'JCHttpRequestContent', 'JCHttpResponse')
$($IndentChar)$($IndentChar)`$GlobalVars | ForEach-Object {
$($IndentChar)$($IndentChar)$($IndentChar)If ((Get-Variable -Scope:('Global')).Where( { `$_.Name -eq `$_ })) { Remove-Variable -Name:(`$_) -Scope:('Global') }
$($IndentChar)$($IndentChar)}
$($IndentChar)$($IndentChar)Return `$Results"
            }
            ElseIf ($ModuleName -In ('JumpCloud.SDK.V1', 'JumpCloud.SDK.V2'))
            {
                # Create results logic
                $ResultsLogic = Switch ($ModuleName)
                {
                    'JumpCloud.SDK.V1'
                    {
                        '$Result.results'
                    }
                    'JumpCloud.SDK.V2'
                    {
                        '$Result'
                    }
                    Default
                    {
                        Write-Error ("Unknown module $($ModuleName)")
                    }
                }
                # Build "Begin" block
                $BeginContent = "$($IndentChar)$($IndentChar)Connect-JCOnline -force | Out-Null
$($IndentChar)$($IndentChar)`$Results = @()
$($IndentChar)$($IndentChar)If ([System.String]::IsNullOrEmpty(`$PSBoundParameters.Skip))
$($IndentChar)$($IndentChar){
$($IndentChar)$($IndentChar)$($IndentChar)`$PSBoundParameters.Add('Skip', 0)
$($IndentChar)$($IndentChar)}
$($IndentChar)$($IndentChar)If ([System.String]::IsNullOrEmpty(`$PSBoundParameters.Limit))
$($IndentChar)$($IndentChar){
$($IndentChar)$($IndentChar)$($IndentChar)`$PSBoundParameters.Add('Limit', 100)
$($IndentChar)$($IndentChar)}"
                # Build "Process" block
                $ProcessContent = "$($IndentChar)$($IndentChar)If (`$Paginate)
$($IndentChar)$($IndentChar){
$($IndentChar)$($IndentChar)$($IndentChar)`$PSBoundParameters.Remove('Paginate') | Out-Null
$($IndentChar)$($IndentChar)$($IndentChar)Do
$($IndentChar)$($IndentChar)$($IndentChar){
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)Write-Debug (`"Skip: `$(`$PSBoundParameters.Skip); Limit: `$(`$PSBoundParameters.Limit);`");
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)`$Result = $CommandName @PSBoundParameters
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)If (-not [System.String]::IsNullOrEmpty(`$Result))
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar){
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)`$ResultCount = ($ResultsLogic | Measure-Object).Count;
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)`$Results += $ResultsLogic;
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)`$PSBoundParameters.Skip += `$ResultCount
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)}
$($IndentChar)$($IndentChar)$($IndentChar)}
$($IndentChar)$($IndentChar)$($IndentChar)While (`$ResultCount -eq `$PSBoundParameters.Limit -and `$Result)
$($IndentChar)$($IndentChar)}
$($IndentChar)$($IndentChar)Else
$($IndentChar)$($IndentChar){
$($IndentChar)$($IndentChar)$($IndentChar)`$PSBoundParameters.Remove('Paginate') | Out-Null
$($IndentChar)$($IndentChar)$($IndentChar)`$Result = $CommandName @PSBoundParameters
$($IndentChar)$($IndentChar)$($IndentChar)If (-not [System.String]::IsNullOrEmpty(`$Result))
$($IndentChar)$($IndentChar)$($IndentChar){
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)`$Results += $ResultsLogic;
$($IndentChar)$($IndentChar)$($IndentChar)}
$($IndentChar)$($IndentChar)}"
                # Build "End" block
                $EndContent = "$($IndentChar)$($IndentChar)Return `$Results"
            }
            Else
            {
                Write-Error ('Unknown module $($ModuleName)')
            }
        }
        ElseIf ($Command.Verb -in ('New', 'Set', 'Remove', 'Start', 'Unlock', 'Update', 'Reset', 'Grant', 'Import'))
        {
            # Build "Begin" block
            $BeginContent = "$($IndentChar)$($IndentChar)`$Results = @()"
            # Build "Process" block
            $ProcessContent = "$($IndentChar)$($IndentChar)`$Results = $CommandName @PSBoundParameters"
            # Build "End" block
            $EndContent = "$($IndentChar)$($IndentChar)Return `$Results"
        }
        Else
        {
            Write-Warning ('Unmapped command: ' + $CommandName)
            $null
        }
        If (-not [System.String]::IsNullOrEmpty($BeginContent) -and -not [System.String]::IsNullOrEmpty($ProcessContent) -and -not [System.String]::IsNullOrEmpty($EndContent))
        {
            # Build "Function"
            $NewScript = $FunctionTemplate -f $PSScriptInfo, $NewFunctionName, $Requires, $CmdletBinding, $ParameterContent, $BeginContent, $ProcessContent, $EndContent
            # Fix line endings
            $NewScript = $NewScript.Replace("`r`n", "`n").Trim()
            # Export the function
            $OutputFullPath = $OutputPath + $Command.Verb
            Write-Host ("$OutputFullPath - $CommandName")
            If (!(Test-Path -Path:($OutputFullPath)))
            {
                New-Item -Path:($OutputFullPath) -ItemType:('Directory') | Out-Null
            }
            $OutputFilePath = $OutputFullPath + '/' + $NewFunctionName + '.ps1'
            $NewScript | Out-File -FilePath:($OutputFilePath) -Force
            # Validate script syntax
            $ScriptAnalyzerResult = Invoke-ScriptAnalyzer -Path:($OutputFilePath) -Recurse -ExcludeRule PSAvoidTrailingWhitespace, PSAvoidUsingWMICmdlet, PSAvoidUsingPlainTextForPassword, PSAvoidUsingUsernameAndPasswordParams, PSAvoidUsingInvokeExpression, PSUseDeclaredVarsMoreThanAssignments, PSUseSingularNouns, PSAvoidGlobalVars, PSUseShouldProcessForStateChangingFunctions, PSAvoidUsingWriteHost, PSAvoidUsingPositionalParameters
            If ($ScriptAnalyzerResult)
            {
                $ScriptAnalyzerResults += $ScriptAnalyzerResult
            }
        }
    }
}
Else
{
    Write-Error ('No modules found.')
}
If ($ScriptAnalyzerResults)
{
    $ScriptAnalyzerResults
}