# $UserAgent = Get-JCUserAgent
# [Net.ServicePointManager]::SecurityProtocol = [Net.SecurityProtocolType]::Tls12
$OutputPath = $PSScriptRoot + '/JumpCloudV2/'
If (Test-Path -Path:($OutputPath))
{
    Remove-Item -Path:($OutputPath) -Recurse -Force
}
If (Get-Module -Name($ModuleNames))
{
    $Commands = Get-Command -Module:($ModuleNames) #| Where-Object { $_.Name -in ('Set-JcSdkSystemUser', 'Get-JcSdkSystemUser', 'New-JcSdkSystemUser') }
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
        $DefaultParameterSetName = If ($DefaultParameterSet) { "[CmdletBinding(DefaultParameterSetName = '$($DefaultParameterSet.Name)')]`n" } # SupportsShouldProcess = `$true,
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
                                "`n`t`t`t" + $ParameterSetAttributePropertyName + " = " + $AttributeValue
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
                            $ParameterString = "`n`t`t`tParameterSetName = '" + $_ + "'"
                        }
                        If (-not [System.String]::IsNullOrEmpty($NewParameterSetAttributes))
                        {
                            $ParameterString = $ParameterString + "," + ($NewParameterSetAttributes -join ',') + "`n`t`t"
                        }
                        Else
                        {
                            $ParameterString = $ParameterString.Trim()
                        }
                        If (-not [System.String]::IsNullOrEmpty($ParameterString))
                        {
                            $ParameterString = "[Parameter(" + $ParameterString + ")]"
                            $FullParameterString += $ParameterString
                        }
                    }
                    ( $FullParameterString -join "`n`t`t")
                }
                # Return full parameter set
                If (-not [System.String]::IsNullOrEmpty($NewParameterSets))
                {
                    [System.String](($NewParameterSets -join "`n`t`t") + "`n`t`t" + $Aliases + "[" + $ParameterTypeFullName + "]`$" + $ParameterName)
                }
                Else
                {
                    [System.String]($Aliases + "[" + $ParameterTypeFullName + "]`$" + $ParameterName)
                }
            }
        }
        $ParamBlock = $DefaultParameterSetName + ("`t" + 'Param(' + "`n`t`t" + ($NewParameters -join ",`n`t`t") + ",`n`t`t" + '[System.Boolean]$Paginate = $true' + "`n`t" + ')')
        # Build function
        $Script = If ($Command.Verb -in ('Get', 'Search'))
        {
            # Create results logic
            $ResultsLogic = Switch ($ModuleName)
            {
                'JumpCloud.SDK.V1'
                {
                    ('$ResultCount = ($Result.results | Measure-Object).Count;' + "`n                " + '$Results += $Result.results;')
                }
                'JumpCloud.SDK.V2'
                {
                    ('$ResultCount = ($Result | Measure-Object).Count;' + "`n                " + '$Results += $Result;')

                }
                Default
                {
                    Write-Error ('Unknown module $($ModuleName)')
                }
            }
            # Script template
            "#Requires -modules $($ModuleName)
Function $NewFunctionName
{
    $ParamBlock
    Begin
    {
        `$Results = @()
        If ([System.String]::IsNullOrEmpty(`$PSBoundParameters.Skip))
        {
            `$PSBoundParameters.Add('Skip', 0)
        }
        If ([System.String]::IsNullOrEmpty(`$PSBoundParameters.Limit))
        {
            `$PSBoundParameters.Add('Limit', 100)
        }
    }
    Process
    {
        If (`$PSBoundParameters.Paginate)
        {
            `$PSBoundParameters.Remove('Paginate') | Out-Null
            Do
            {
                # Write-Host (`"Skip: `$(`$PSBoundParameters.Skip); Limit: `$(`$PSBoundParameters.Limit); `");
                `$Result = $CommandName @PSBoundParameters
                If (-not [System.String]::IsNullOrEmpty(`$Result))
                {
                    $ResultsLogic
                    `$PSBoundParameters.Skip += `$ResultCount
                }
            }
            While (`$ResultCount -eq `$PSBoundParameters.Limit)
        }
        Else
        {
            `$PSBoundParameters.Remove('Paginate') | Out-Null
            `$Result = $CommandName @PSBoundParameters
            If (-not [System.String]::IsNullOrEmpty(`$Result))
            {
                $ResultsLogic
                `$PSBoundParameters.Skip += `$ResultCount
            }
        }
    }
    End
    {
        Return `$Results
    }
}"
        }
        ElseIf ($Command.Verb -in ('New', 'Set', 'Remove', 'Start', 'Unlock', 'Update', 'Reset', 'Grant', 'Import'))
        {
            # Script template
            "#Requires -modules $($ModuleName)
Function $NewFunctionName
{
    $ParamBlock
    Begin
    {
        `$Results = @()
    }
    Process
    {
        `$Results = $CommandName @PSBoundParameters
    }
    End
    {
        Return `$Results
    }
}"
        }
        Else
        {
            Write-Warning ('Unmapped command: ' + $CommandName)
            $null
        }
        If (-not [System.String]::IsNullOrEmpty($Script))
        {
            # Export the function
            $OutputFullPath = $OutputPath + $Command.Verb
            Write-Host ("$OutputFullPath - $CommandName")
            If (!(Test-Path -Path:($OutputFullPath)))
            {
                New-Item -Path:($OutputFullPath) -ItemType:('Directory') | Out-Null
            }
            $Script | Out-File -FilePath:($OutputFullPath + '/' + $NewFunctionName + '.ps1') -Force
        }
    }
}
Else
{
    Write-Error ('No modules found.')
}