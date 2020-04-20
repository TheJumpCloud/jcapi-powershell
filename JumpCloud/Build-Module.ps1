# $UserAgent = Get-JCUserAgent
# [Net.ServicePointManager]::SecurityProtocol = [Net.SecurityProtocolType]::Tls12
$OutputPath = $PSScriptRoot + '/JumpCloudV2/'
$IndentChar = '    '
$FunctionTemplate = "#Requires -modules {0}`nFunction {1}`n{{`n$($IndentChar){2}`n$($IndentChar)Param(`n{3}`n$($IndentChar))`n$($IndentChar)Begin`n$($IndentChar){{`n{4}`n$($IndentChar)}}`n$($IndentChar)Process`n$($IndentChar){{`n{5}`n$($IndentChar)}}`n$($IndentChar)End`n$($IndentChar){{`n{6}`n$($IndentChar)}}`n}}"
If (Test-Path -Path:($OutputPath))
{
    Remove-Item -Path:($OutputPath) -Recurse -Force
}
If (Get-Module -Name($ModuleNames))
{
    $Commands = Get-Command -Module:($ModuleNames)
    ForEach ($Command In $Commands)
    {
        # Create new function name
        $ModuleName = $Command.Module.Name
        $CommandName = $Command.Name
        $NewFunctionName = $CommandName.Replace($ModulePrefix, 'JC')
        # Build new function parameters
        $CommandParameterSets = $Command.ParameterSets
        $CommandParameters = $Command.Parameters
        $DefaultParameterSet = $CommandParameterSets | Where-Object { $_.IsDefault }
        # Get the default parameter set
        $DefaultParameterSetName = If ($DefaultParameterSet) { "[CmdletBinding(DefaultParameterSetName = '$($DefaultParameterSet.Name)')]" } Else { '' } # SupportsShouldProcess = `$true,
        # Build parameters by copying them from the SDK function parameters
        $NewParameters = ForEach ($CommandParameter In $CommandParameters.GetEnumerator())
        {
            # $ParameterName = $CommandParameter.Key
            # $ParameterValue.IsDynamic
            # $ParameterValue.SwitchParameter
            # $ParameterValue.Attributes.GetEnumerator() | ForEach-Object { $_ | Get-Member }
            $ParametersToExclude = @(('Break', 'HttpPipelineAppend', 'HttpPipelinePrepend', 'PassThru', 'Proxy', 'ProxyCredential', 'ProxyUseDefaultCredentials') + [System.Management.Automation.PSCmdlet]::CommonParameters) # + [System.Management.Automation.PSCmdlet]::OptionalCommonParameters)
            $ParameterValue = $CommandParameter.Value
            $ParameterName = $ParameterValue.Name
            $ParameterType = $ParameterValue.ParameterType
            $ParameterTypeFullName = $ParameterType.FullName
            $ParameterAliases = $ParameterValue.Aliases
            If ($ParameterName -notin $ParametersToExclude)
            {
                # Build aliases
                $Aliases = If (-not [System.string]::IsNullOrEmpty($ParameterAliases))
                {
                    '[Alias(' + $ParameterAliases + ')]'
                }
                # Build parameter sets
                $NewParameterSets = $ParameterValue.ParameterSets.GetEnumerator() | ForEach-Object {
                    $ParameterSetName = $_.Key
                    $ParameterSetAttributes = $_.Value
                    $ParameterSetAttributeProperties = $ParameterSetAttributes.PSObject.Properties
                    $NewParameterSetAttributes = ForEach ($ParameterSetAttributeProperty In $ParameterSetAttributeProperties)
                    {
                        $ParameterSetAttributePropertyName = $ParameterSetAttributeProperty.Name
                        If (-not [System.String]::IsNullOrEmpty($ParameterSetAttributes.$ParameterSetAttributePropertyName))
                        {
                            # Format the attribute value
                            $AttributeValue = Switch ($ParameterSetAttributeProperty.TypeNameOfValue)
                            {
                                'System.Boolean'
                                {
                                    [System.String]('$' + $ParameterSetAttributes.$ParameterSetAttributePropertyName).ToLower()
                                }
                                'System.String'
                                {
                                    "'" + $ParameterSetAttributes.$ParameterSetAttributePropertyName + "'"
                                }
                                'System.Int32'
                                {
                                    $ParameterSetAttributes.$ParameterSetAttributePropertyName
                                }
                                Default { Write-Error ('Unknown data type: ' + $ParameterSetAttributePropertyName + ' ' + $ParameterSetAttributeProperty.TypeNameOfValue) }
                            }
                            # Format the attribute name
                            If ($ParameterSetAttributePropertyName -eq 'IsMandatory')
                            {
                                $ParameterSetAttributePropertyName = 'Mandatory'
                            }
                            # Return key value pair
                            If ($AttributeValue -notin ('$false', '-2147483648'))
                            {
                                "`n$($IndentChar)$($IndentChar)$($IndentChar)" + $ParameterSetAttributePropertyName + " = " + $AttributeValue
                            }
                        }
                    }

                    $ParameterSets = If ($ParameterSetName -eq '__AllParameterSets')
                    {
                        $CommandParameterSets.Name
                    }
                    Else
                    {
                        $ParameterSetName
                    }
                    $FullParameterString = @()
                    $ParameterSets | ForEach-Object {
                        $ParameterString = $null
                        If (-not [System.String]::IsNullOrEmpty($_))
                        {
                            $ParameterString = "`n$($IndentChar)$($IndentChar)$($IndentChar)ParameterSetName = '" + $_ + "'"
                        }
                        If (-not [System.String]::IsNullOrEmpty($NewParameterSetAttributes))
                        {
                            $ParameterString = $ParameterString + "," + ($NewParameterSetAttributes -join ',') + "`n$($IndentChar)$($IndentChar)"
                        }
                        Else
                        {
                            $ParameterString = $ParameterString.Trim()
                        }
                        If (-not [System.String]::IsNullOrEmpty($ParameterString))
                        {
                            $ParameterString = "$($IndentChar)$($IndentChar)[Parameter(" + $ParameterString + ")]"
                            $FullParameterString += $ParameterString
                        }
                    }
                    ( $FullParameterString -join "`n")
                }
                # Return full parameter set
                If (-not [System.String]::IsNullOrEmpty($NewParameterSets))
                {
                    [System.String](($NewParameterSets -join "`n") + "`n$($IndentChar)$($IndentChar)" + $Aliases + "[" + $ParameterTypeFullName + "]`$" + $ParameterName)
                }
                Else
                {
                    [System.String]($Aliases + "[" + $ParameterTypeFullName + "]`$" + $ParameterName)
                }
            }
        }
        $NewParameters = ($NewParameters -join ",`n") + ",`n$($IndentChar)$($IndentChar)" + '[System.Boolean]$Paginate = $true'
        # $ParamBlock = $DefaultParameterSetName + ("$($IndentChar)" + 'Param(' + "`n$($IndentChar)$($IndentChar)" + ($NewParameters -join ",`n$($IndentChar)$($IndentChar)") + ",`n$($IndentChar)$($IndentChar)" + '[System.Boolean]$Paginate = $true' + "`n$($IndentChar)" + ')')
        # Build $BeginContent, $ProcessContent, and $EndContent
        If ($Command.Verb -in ('Get', 'Search'))
        {
            # Build script body
            If ($ModuleName -eq 'JumpCloud.SDK.DirectoryInsights')
            {
                # Build "Begin" block
                $BeginContent = "$($IndentChar)$($IndentChar)`$Results = @()
$($IndentChar)$($IndentChar)`$PSBoundParameters.Add('HttpPipelineAppend', {
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)param(`$req, `$callback, `$next )
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)# call the next step in the Pipeline
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)`$ResponseTask = `$next.SendAsync(`$req, `$callback)
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)`$global:JCHttpRequest = `$req
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)`$global:JCHttpResponse = `$ResponseTask.Result
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)Return `$ResponseTask
$($IndentChar)$($IndentChar)$($IndentChar)}
$($IndentChar)$($IndentChar))"
                # Build "Process" block
                $ProcessContent = "$($IndentChar)$($IndentChar)Do
$($IndentChar)$($IndentChar){
$($IndentChar)$($IndentChar)$($IndentChar)Write-Debug (""ResultCount: `$(`$XResultCount); Limit: `$(`$XLimit); XResultSearchAfter: `$(`$XResultSearchAfter); "");
$($IndentChar)$($IndentChar)$($IndentChar)`$Result = $($CommandName) @PSBoundParameters
$($IndentChar)$($IndentChar)$($IndentChar)If (-not [System.String]::IsNullOrEmpty(`$Result))
$($IndentChar)$($IndentChar)$($IndentChar){
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)`$XResultSearchAfter = (`$JCHttpResponse.Headers.GetValues('X-Search_after') | ConvertFrom-Json);
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)If ([System.String]::IsNullOrEmpty(`$PSBoundParameters.SearchAfter))
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar){
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)`$PSBoundParameters.Add('SearchAfter', `$XResultSearchAfter)
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)}
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)Else
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar){
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)`$PSBoundParameters.SearchAfter = `$XResultSearchAfter
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)}
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)`$XResultCount = `$JCHttpResponse.Headers.GetValues('X-Result-Count')
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)`$XLimit = `$JCHttpResponse.Headers.GetValues('X-Limit')
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)`$Results += (`$Result).ToJsonString() | ConvertFrom-Json;
$($IndentChar)$($IndentChar)$($IndentChar)}
$($IndentChar)$($IndentChar)$($IndentChar)Else
$($IndentChar)$($IndentChar)$($IndentChar){
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)Write-Warning ('No Results Found')
$($IndentChar)$($IndentChar)$($IndentChar)}
$($IndentChar)$($IndentChar)}
$($IndentChar)$($IndentChar)While (`$XResultCount -eq `$XLimit)"
                # Build "End" block
                $EndContent = "$($IndentChar)$($IndentChar)# Clean up global variables
$($IndentChar)$($IndentChar)If ((Get-Variable -Scope:('Global')).Where( { `$_.Name -eq 'JCHttpRequest' })) { Remove-Variable -Name:('JCHttpRequest') -Scope:('Global') }
$($IndentChar)$($IndentChar)If ((Get-Variable -Scope:('Global')).Where( { `$_.Name -eq 'JCHttpResponse' })) { Remove-Variable -Name:('JCHttpResponse') -Scope:('Global') }
$($IndentChar)$($IndentChar)Return `$Results"
            }
            ElseIf ($ModuleName -In ('JumpCloud.SDK.V1', 'JumpCloud.SDK.V2'))
            {
                # Create results logic
                $ResultsLogic = Switch ($ModuleName)
                {
                    'JumpCloud.SDK.V1'
                    {
                        @('$ResultCount = ($Result.results | Measure-Object).Count;', '$Results += $Result.results;')
                    }
                    'JumpCloud.SDK.V2'
                    {
                        @('$ResultCount = ($Result | Measure-Object).Count;', '$Results += $Result;')
                    }
                    Default
                    {
                        Write-Error ("Unknown module $($ModuleName)")
                    }
                }
                # Build "Begin" block
                $BeginContent = "$($IndentChar)$($IndentChar)`$Results = @()
$($IndentChar)$($IndentChar)If ([System.String]::IsNullOrEmpty(`$PSBoundParameters.Skip))
$($IndentChar)$($IndentChar){
$($IndentChar)$($IndentChar)$($IndentChar)`$PSBoundParameters.Add('Skip', 0)
$($IndentChar)$($IndentChar)}
$($IndentChar)$($IndentChar)If ([System.String]::IsNullOrEmpty(`$PSBoundParameters.Limit))
$($IndentChar)$($IndentChar){
$($IndentChar)$($IndentChar)$($IndentChar)`$PSBoundParameters.Add('Limit', 100)
$($IndentChar)$($IndentChar)}"
                # Build "Process" block
                $ProcessContent = "$($IndentChar)$($IndentChar)If (`$PSBoundParameters.Paginate)
$($IndentChar)$($IndentChar){
$($IndentChar)$($IndentChar)$($IndentChar)`$PSBoundParameters.Remove('Paginate') | Out-Null
$($IndentChar)$($IndentChar)$($IndentChar)Do
$($IndentChar)$($IndentChar)$($IndentChar){
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)Write-Debug (`"Skip: `$(`$PSBoundParameters.Skip); Limit: `$(`$PSBoundParameters.Limit);`");
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)`$Result = $CommandName @PSBoundParameters
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)If (-not [System.String]::IsNullOrEmpty(`$Result))
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar){
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)$($ResultsLogic -join "`n$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)")
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)`$PSBoundParameters.Skip += `$ResultCount
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)}
$($IndentChar)$($IndentChar)$($IndentChar)}
$($IndentChar)$($IndentChar)$($IndentChar)While (`$ResultCount -eq `$PSBoundParameters.Limit)
$($IndentChar)$($IndentChar)}
$($IndentChar)$($IndentChar)Else
$($IndentChar)$($IndentChar){
$($IndentChar)$($IndentChar)$($IndentChar)`$PSBoundParameters.Remove('Paginate') | Out-Null
$($IndentChar)$($IndentChar)$($IndentChar)`$Result = $CommandName @PSBoundParameters
$($IndentChar)$($IndentChar)$($IndentChar)If (-not [System.String]::IsNullOrEmpty(`$Result))
$($IndentChar)$($IndentChar)$($IndentChar){
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)$($ResultsLogic -join "`n$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)")
$($IndentChar)$($IndentChar)$($IndentChar)$($IndentChar)`$PSBoundParameters.Skip += `$ResultCount
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
            $BeginContent = "`$Results = @()"
            # Build "Process" block
            $ProcessContent = "`$Results = $CommandName @PSBoundParameters"
            # Build "End" block
            $EndContent = "Return `$Results"
        }
        Else
        {
            Write-Warning ('Unmapped command: ' + $CommandName)
            $null
        }
        If (-not [System.String]::IsNullOrEmpty($BeginContent) -and -not [System.String]::IsNullOrEmpty($ProcessContent) -and -not [System.String]::IsNullOrEmpty($EndContent))
        {
            # Build "Function"
            $NewScript = $FunctionTemplate -f $ModuleName, $NewFunctionName, $DefaultParameterSetName, $NewParameters, $BeginContent, $ProcessContent, $EndContent
            # Export the function
            $OutputFullPath = $OutputPath + $Command.Verb
            Write-Host ("$OutputFullPath - $CommandName")
            If (!(Test-Path -Path:($OutputFullPath)))
            {
                New-Item -Path:($OutputFullPath) -ItemType:('Directory') | Out-Null
            }
            $NewScript | Out-File -FilePath:($OutputFullPath + '/' + $NewFunctionName + '.ps1') -Force
        }
    }
}
Else
{
    Write-Error ('No modules found.')
}