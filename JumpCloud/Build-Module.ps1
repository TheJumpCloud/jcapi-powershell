# $UserAgent = Get-JCUserAgent
# [Net.ServicePointManager]::SecurityProtocol = [Net.SecurityProtocolType]::Tls12
If (Get-Module -Name($ModuleNames))
{
    $Commands = Get-Command -Module:($ModuleNames) #| Where-Object { $_.Name -eq 'New-JcSdkSystemUser' }
    ForEach ($Command In $Commands)
    {
        # Create new function name
        $ModuleName = $Command.Module.Name
        $CommandName = $Command.Name
        $NewFunctionName = $CommandName.Replace($ModulePrefix, 'JC')
        # Build new function parameters
        $NewFunctionParameters = @()
        $CommandParameterSets = $Command.ParameterSets | Select-Object -Property:(@{Name = 'ParameterSetName'; Expression = { $_.Name } }, @{Name = 'IsDefault'; Expression = { $_.IsDefault } }) -ExpandProperty:('Parameters') | Sort-Object Name
        ForEach ($CommandParameterSet In $CommandParameterSets)
        {
            $NewFunctionParameter = [Ordered]@{ }
            $DefaultParameterSet = If ($CommandParameterSet.IsDefault) { "[CmdletBinding(DefaultParameterSetName = '$($CommandParameterSet.Name)')]`n" }
            $NewFunctionParameter.Add('ParameterSetName', "'" + $CommandParameterSet.ParameterSetName + "'")
            $PropertyNames = $CommandParameterSet | Get-Member | Where-Object { $_.MemberType -eq 'Property' -and $_.Name -notin ('Attributes', 'IsDynamic') }
            ForEach ($PropertyName In $PropertyNames.Name)
            {
                If (-not [System.String]::IsNullOrEmpty($CommandParameterSet.$PropertyName))
                {
                    $AttributeValue = Switch ($CommandParameterSet.$PropertyName.GetType().Name)
                    {
                        'Boolean'
                        {
                            '$' + $CommandParameterSet.$PropertyName
                        }
                        'string'
                        {
                            If ($PropertyName -eq 'Name')
                            {
                                '$' + $CommandParameterSet.$PropertyName
                            }
                            Else
                            {
                                "'" + $CommandParameterSet.$PropertyName + "'"
                            }
                        }
                        'Int32'
                        {
                            $CommandParameterSet.$PropertyName
                        }
                        'ReadOnlyCollection`1'
                        {
                            "'" + $CommandParameterSet.$PropertyName + "'"
                        }
                        'RuntimeType'
                        {
                            '[' + $CommandParameterSet.$PropertyName + ']'
                        }
                        Default { Write-Error ('Unknown data type: ' + $PropertyName + ' ' + $CommandParameterSet.$PropertyName.GetType().Name) }
                    }
                    If ($PropertyName -eq 'IsMandatory') { $PropertyName = 'Mandatory' }
                    $NewFunctionParameter.Add($PropertyName, $AttributeValue)
                }
            }
            $ParameterName = $NewFunctionParameter.Name
            $ParameterType = $NewFunctionParameter.ParameterType
            # If ($ParameterType -like ('*' + $ModuleName + '*Item*'))
            # {
            #     Write-Host ("Build-JCObjectTemplate -ModelName:('$ParameterType')") -BackgroundColor Cyan
            #     # Build-JCObjectTemplate -ModelName:($ParameterType)
            # }
            $ParameterSetName = $NewFunctionParameter.ParameterSetName
            $Aliases = $NewFunctionParameter.Aliases
            $NewFunctionParameter.Remove('Aliases')
            $NewFunctionParameter.Remove('Name')
            $NewFunctionParameter.Remove('ParameterType')
            $NewFunctionParameters += [pscustomobject]@{
                ParameterSetName     = $ParameterSetName
                ParameterName        = $ParameterName
                ParameterType        = $ParameterType
                NewFunctionParameter = $NewFunctionParameter
                Aliases              = $Aliases
            }
        }
        $NewFunctionParametersOut = @()
        $NewFunctionParameters | Group-Object ParameterName | ForEach-Object {
            $GroupName = $_.Name
            $Group = $_.Group | Sort-Object ParameterSetName
            If ($GroupName.Replace('$', '') -notin ('Verbose', 'Debug', 'ErrorAction', 'WarningAction', 'InformationAction', 'ErrorVariable', 'WarningVariable', 'InformationVariable', 'OutVariable', 'OutBuffer', 'PipelineVariable') `
                    -and $GroupName.Replace('$', '') -notin ('Break', 'HttpPipelineAppend', 'HttpPipelinePrepend', 'PassThru', 'Proxy', 'ProxyCredential', 'ProxyUseDefaultCredentials'))
            {
                $NewFunctionParameterString = @()
                ForEach ($GroupItem In $Group)
                {
                    $NewFunctionParameterString += '[Parameter(' + (($GroupItem.NewFunctionParameter.GetEnumerator() | ForEach-Object {
                                $_.Key + ' = ' + $_.Value
                            }) -join ', ') + ')]'
                }
                $Aliases = If (-not [System.string]::IsNullOrEmpty($GroupItem.Aliases))
                {
                    '[Alias(' + $GroupItem.Aliases + ')]'
                }
                $NewFunctionParameterString = ($NewFunctionParameterString -join "`n        ") + "`n        " + $Aliases + $GroupItem.ParameterType + $GroupItem.ParameterName
                $NewFunctionParametersOut += $NewFunctionParameterString
            }
        }
        $NewFunctionParametersOut = $NewFunctionParametersOut -join ",`n        "
        # Build function
        $Script = If ($Command.Verb -in ('Get', 'Search'))
        {
            # Create results logic
            $ResultsLogic = Switch ($ModuleName)
            {
                'JumpCloudApiSdkV1'
                {
                    ('$ResultCount = ($Result.results | Measure-Object).Count;' + "`n                " + '$Results += $Result.results;')
                }
                'JumpCloudApiSdkV2'
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
    $($DefaultParameterSet)Param(
        $NewFunctionParametersOut
    )
    Begin {
        `$Results = @()
        If([System.String]::IsNullOrEmpty(`$PSBoundParameters.Skip))
        {
            `$PSBoundParameters.Add('Skip',0)
        }
        If([System.String]::IsNullOrEmpty(`$PSBoundParameters.Limit))
        {
            `$PSBoundParameters.Add('Limit',100)
        }
    }
    Process {
        Do
        {
            # Write-Host (`"Skip: `$(`$PSBoundParameters.Skip); Limit: `$(`$PSBoundParameters.Limit); `");
            `$Result = $CommandName @PSBoundParameters
            If(-not [System.String]::IsNullOrEmpty(`$Result))
            {
                $ResultsLogic
                `$PSBoundParameters.Skip += `$ResultCount
            }
        }
        While (`$ResultCount -eq `$PSBoundParameters.Limit)
    }
    End {
        Return `$Results
    }
}
        "
        }
        ElseIf ($Command.Verb -in ('New', 'Set', 'Remove', 'Start', 'Unlock', 'Update', 'Reset', 'Grant', 'Import'))
        {
            # Script template
            "#Requires -modules $($ModuleName)
Function $NewFunctionName
{
    $($DefaultParameterSet)Param(
        $NewFunctionParametersOut
    )
    Begin {
        `$Results = @()
    }
    Process {
        `$Results = $CommandName @PSBoundParameters
    }
    End {
        Return `$Results
    }
}
        "
        }
        Else
        {
            Write-Warning ('Unmapped command: ' + $CommandName)
            $null
        }
        If (-not [System.String]::IsNullOrEmpty($Script))
        {
            # Export the function
            $OutputPath = $PSScriptRoot + '/JumpCloudV2/' + $Command.Verb
            Write-Host ("$OutputPath - $CommandName")
            If (!(Test-Path -Path:($OutputPath)))
            {
                New-Item -Path:($OutputPath) -ItemType:('Directory') | Out-Null
            }
            $Script | Out-File -FilePath:($OutputPath + '/' + $NewFunctionName + '.ps1') -Force
        }
    }
}