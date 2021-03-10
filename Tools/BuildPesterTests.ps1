$ModuleFolder = Join-Path "$PSScriptRoot\.." "\SDKs\PowerShell\" -Resolve
$SDKs = Get-ChildItem -Path $ModuleFolder
$SDKs | ForEach-Object {
    $PesterTestVariableList = @()
    $PesterTestDefVariableList = @()
    $Prefix = 'JcSdk'
    $Module = $_.BaseName
    $TestFolderPath = "$ModuleFolder\$Module\test\"
    Import-Module "$ModuleFolder\$Module\$Module.psd1"
    $Commands = Get-Command -Module $Module #-Verb Remove # For testing specific commands
    $Commands | ForEach-Object {
        $CommandName = $_.Name
        $Type = $_.Noun.Replace($Prefix, '')
        $PesterTestVariable = "`$global:PesterTest$($Type)"
        $PesterTestDefVariable = "@global:PesterDef$($Type)"
        $PesterTestVariableList += $PesterTestVariable
        $PesterTestDefVariableList += $PesterTestDefVariable
        $CommandVerb = $_.Verb
        $TestFilePath = Join-Path $TestFolderPath "$($_.Name).Tests.ps1"
        $Content = Get-Content -Path $TestFilePath -Raw
        (Get-Command -Name $CommandName) | ForEach-Object {
            $ParameterName = $_.Name
            $_.ParameterSets | ForEach-Object {
                $ParameterSetName = $_.Name
                $RequiredParameters = @()
                $OptionalParameters = @()
                ($_.Parameters | Sort-Object @{e = 'IsMandatory'; desc = $true }, @{e = 'Name'; desc = $false } | ForEach-Object {
                        $ParameterName = $_.Name
                        if ($ParameterName -notin ('Fields', 'Filter', 'Sort', 'Search', 'Paginate', 'Break', 'HttpPipelineAppend', 'HttpPipelinePrepend', 'PassThru', 'Proxy', 'ProxyCredential', 'ProxyUseDefaultCredentials', 'CommonParameters', 'WhatIf', 'Confirm', 'Verbose', 'Debug', 'ErrorAction', 'WarningAction', 'InformationAction', 'ErrorVariable', 'WarningVariable', 'InformationVariable', 'OutVariable', 'OutBuffer', 'PipelineVariable'))
                        {
                            $ParameterType = If ($_.ParameterType.Name -eq 'switchparameter') { '' }Else { " '<$($_.ParameterType.Name)>'" }
                            If ($_.IsMandatory)
                            {
                                $RequiredParameters += "-$($ParameterName)$($ParameterType)".Trim()
                            }
                            else
                            {
                                $OptionalParameters += "[-$($ParameterName)$($ParameterType)]".Trim()
                            }
                        }
                    }
                )
                $RequiredParameters = $RequiredParameters -join ' '
                $OptionalParameters = $OptionalParameters -join ' '
                $Skip = $false
                $Find = $Content | Select-String -Pattern:([regex]"(?smi)(It '$($ParameterSetName)' .*?{\s+)(.*?)(\s+}\s+$)")
                $CurrentTest = $Find.Matches.Groups[2].Value
                If ($CommandName -like '*SystemGroupMember*' -or $CommandName -like '*SystemGroupAssociation*')
                {
                    $RequiredParameters = $RequiredParameters.Replace("-GroupId '<String>'", "-GroupId:(`$global:PesterTestSystemGroup.Id)")
                    $RequiredParameters = $RequiredParameters.Replace("-Id '<String>'", "-Id:(`$global:PesterTestSystem.Id)")
                }
                ElseIf ($CommandName -like '*UserGroupMember*' -or $CommandName -like '*UserGroupAssociation*')
                {
                    $RequiredParameters = $RequiredParameters.Replace("-GroupId '<String>'", "-GroupId:(`$global:PesterTestUserGroup.Id)")
                    $RequiredParameters = $RequiredParameters.Replace("-Id '<String>'", "-Id:(`$global:PesterTestUser.Id)")
                }
                $RequiredParameters = $RequiredParameters.Replace("-Id '<String>'", "-Id:($($PesterTestVariable).Id)")
                $RequiredParameters = $RequiredParameters.Replace("-SystemuserId '<String>'", "-SystemuserId:(`$global:PesterTestUser.Id)")
                $RequiredParameters = $RequiredParameters.Replace("-CustomEmailType '<String>'", "-CustomEmailType:(`$global:PesterDefCustomEmailConfiguration.Type)")
                $RequiredParameters = $RequiredParameters.Replace("-GsuiteId '<String>'", "-GsuiteId:(`$global:PesterTestGsuite.Id)")
                $RequiredParameters = $RequiredParameters.Replace("-Office365Id '<String>'", "-Office365Id:(`$global:PesterTestOffice365.Id)")
                $RequiredParameters = $RequiredParameters.Replace("-ActivedirectoryId '<String>'", "-ActivedirectoryId:(`$global:PesterTestActiveDirectory.Id)")
                $RequiredParameters = $RequiredParameters.Replace("-ApplicationId '<String>'", "-ApplicationId:(`$global:PesterTestApplication.Id)")
                $RequiredParameters = $RequiredParameters.Replace("-CommandId '<String>'", "-CommandId:(`$global:PesterTestCommand.Id)")
                $RequiredParameters = $RequiredParameters.Replace("-SystemId '<String>'", "-SystemId:(`$global:PesterTestSystem.Id)")
                # -Op '<String>' -Type '<String>'
                # $RequiredParameters = $RequiredParameters.Replace("-$($Type)Id '<String>'", "-$($Type)Id:(`$global:PesterTest$($Type).Id)")
                $NewTest = If ($CommandVerb -eq 'Get')
                {
                    If ($ParameterSetName -eq 'List')
                    {
                        "$($CommandName) | Should -Not -BeNullOrEmpty"
                    }
                    ElseIf ($ParameterSetName -eq 'Get')
                    {
                        "$($CommandName) $($RequiredParameters) | Should -Not -BeNullOrEmpty"
                    }
                    Else
                    {
                        $Skip = $true
                        Write-Warning ("Unmapped ParameterSetName: $ParameterSetName ($($CommandVerb))")
                        "$($CommandName) $($RequiredParameters) | Should -Not -BeNullOrEmpty"
                    }
                }
                ElseIf ($CommandVerb -in ('New', 'Invoke'))
                {
                    If (($CommandVerb -eq 'New' -and $ParameterSetName -eq 'CreateExpanded') -or ($CommandVerb -eq 'Invoke' -and $ParameterSetName -eq 'Post'))
                    {
                        "$PesterTestVariable = $($CommandName) $PesterTestDefVariable`n        $PesterTestVariable | Should -Not -BeNullOrEmpty"
                    }
                    Else
                    {
                        $Skip = $true
                        Write-Warning ("Unmapped ParameterSetName: $ParameterSetName ($($CommandVerb))")
                        "$($CommandName) $($RequiredParameters) | Should -Not -BeNullOrEmpty"
                    }
                }
                ElseIf ($CommandVerb -eq 'Remove')
                {
                    If ($ParameterSetName -eq 'Delete')
                    {
                        "{ $($CommandName) $($RequiredParameters) } | Should -Not -Throw"
                    }
                    Else
                    {
                        $Skip = $true
                        Write-Warning ("Unmapped ParameterSetName: $ParameterSetName ($($CommandVerb))")
                        "{ $($CommandName) $($RequiredParameters) } | Should -Not -Throw"
                    }
                }
                ElseIf ($CommandVerb -in ('Search', 'Set'))
                {
                    $Skip = $true
                    Write-Warning ("Unmapped ParameterSetName: $ParameterSetName ($($CommandVerb))")
                    "{ $($CommandName) $($RequiredParameters) $($OptionalParameters) } | Should -Not -Throw"
                }
                ElseIf ($CommandVerb -in ('Clear', 'Lock', 'Reset', 'Restart', 'Stop', 'Unlock'))
                {
                    $Skip = $true
                    Write-Warning ("Unmapped ParameterSetName: $ParameterSetName ($($CommandVerb))")
                    "{ $($CommandName) $($RequiredParameters) } | Should -Not -Throw"
                }
                Else
                {
                    $Skip = $true
                    Write-Warning ("Unmapped Verb: $CommandVerb")
                }
                If (-not [System.String]::IsNullOrEmpty($CurrentTest) -and -not [System.String]::IsNullOrEmpty($NewTest))
                {
                    $NewIt = $Find.Matches.Value.Replace($CurrentTest, $NewTest)
                    If (-not $Skip)
                    {
                        $NewIt = $NewIt.Replace('-skip ', '')
                    }
                    $Content = $Content.Replace($Find.Matches.Value, $NewIt)
                }
                # Write-Host ("$($ParameterSetName): $($ParameterName) $($RequiredParameters)")
            }
        }
        $Content.Trim() | Set-Content -Path $TestFilePath
    }
    Write-Warning ("Make sure these are defined in the RunPesterTests.ps1 script! $($PesterTestVariableList -join ', ')")
    Write-Warning ("Make sure these are defined in the RunPesterTests.ps1 script! $($PesterTestDefVariableList -join ', ')")
    Invoke-ScriptAnalyzer -Path:("$TestFolderPath/*.Tests.ps1") -Recurse -ExcludeRule PSShouldProcess, PSAvoidTrailingWhitespace, PSAvoidUsingWMICmdlet, PSAvoidUsingPlainTextForPassword, PSAvoidUsingUsernameAndPasswordParams, PSAvoidUsingInvokeExpression, PSUseDeclaredVarsMoreThanAssignments, PSUseSingularNouns, PSAvoidGlobalVars, PSUseShouldProcessForStateChangingFunctions, PSAvoidUsingWriteHost, PSAvoidUsingPositionalParameters
}