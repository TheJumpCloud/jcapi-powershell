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
                $Parameters = ($_.Parameters | Sort-Object @{e = 'IsMandatory'; desc = $true }, @{e = 'Name'; desc = $false } | ForEach-Object {
                        $ParameterName = $_.Name
                        if ($ParameterName -notin ('Fields', 'Filter', 'Sort', 'Search', 'Paginate', 'Break', 'HttpPipelineAppend', 'HttpPipelinePrepend', 'PassThru', 'Proxy', 'ProxyCredential', 'ProxyUseDefaultCredentials', 'CommonParameters', 'WhatIf', 'Confirm', 'Verbose', 'Debug', 'ErrorAction', 'WarningAction', 'InformationAction', 'ErrorVariable', 'WarningVariable', 'InformationVariable', 'OutVariable', 'OutBuffer', 'PipelineVariable'))
                        {
                            $ParameterType = If ($_.ParameterType.Name -eq 'switchparameter') { '' }Else { " '<$($_.ParameterType.Name)>'" }
                            If ($_.IsMandatory)
                            {
                                "-$($ParameterName)$($ParameterType)".Trim()
                            }
                            else
                            {
                                "[-$($ParameterName)$($ParameterType)]".Trim()
                            }
                        }
                    }
                ) -join ' '
                $Skip = $false
                $Find = $Content | Select-String -Pattern:([regex]"(?smi)(It '$($ParameterSetName)' .*?{\s+)(.*?)(\s+}\s+$)")
                $CurrentTest = $Find.Matches.Groups[2].Value
                $NewTest = If ($CommandVerb -eq 'Get')
                {
                    If ($ParameterSetName -eq 'List') { "$($CommandName) | Should -Not -BeNullOrEmpty" }
                    ElseIf ($ParameterSetName -eq 'Get') { "$($CommandName) -Id:($PesterTestVariable.Id) | Should -Not -BeNullOrEmpty" }
                    Else
                    {
                        $Skip = $true
                        Write-Warning ("Unmapped ParameterSetName: $ParameterSetName ($($CommandVerb))")
                        "$($CommandName) $($Parameters) | Should -Not -BeNullOrEmpty"
                    }
                }
                ElseIf ($CommandVerb -eq 'New')
                {
                    If ($ParameterSetName -eq 'CreateExpanded') { "$PesterTestVariable = $($CommandName) $PesterTestDefVariable`n        $PesterTestVariable | Should -Not -BeNullOrEmpty" }
                    Else
                    {
                        $Skip = $true
                        Write-Warning ("Unmapped ParameterSetName: $ParameterSetName ($($CommandVerb))")
                        "$($CommandName) $($Parameters) | Should -Not -BeNullOrEmpty"
                    }
                }
                ElseIf ($CommandVerb -eq 'Remove')
                {
                    $Parameters = $Parameters.Replace("-Id '<String>'", "-Id:($($PesterTestVariable).Id)")
                    $Parameters = $Parameters.Replace("-SystemuserId '<String>'", "-SystemuserId:(`$global:PesterTestUser.Id)")
                    $Parameters = $Parameters.Replace("-GsuiteId '<String>", "-GsuiteId:(`$global:PesterTestGsuite.Id)")
                    $Parameters = $Parameters.Replace("-Office365Id '<String>", "-Office365Id:(`$global:PesterTestOffice365.Id)")
                    If ($ParameterSetName -eq 'Delete') { "{ $($CommandName) $($Parameters) } | Should -Not -Throw" }
                    Else
                    {
                        $Skip = $true
                        Write-Warning ("Unmapped ParameterSetName: $ParameterSetName ($($CommandVerb))")
                        "{ $($CommandName) $($Parameters) } | Should -Not -Throw"
                    }
                }
                ElseIf ($CommandVerb -in ('Clear', 'Invoke', 'Lock', 'Reset', 'Restart', 'Search', 'Set', 'Stop', 'Unlock'))
                {
                    $Skip = $true
                    Write-Warning ("Unmapped ParameterSetName: $ParameterSetName ($($CommandVerb))")
                    "{ $($CommandName) $($Parameters) } | Should -Not -Throw"
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
                # Write-Host ("$($ParameterSetName): $($ParameterName) $($Parameters)")
            }
        }
        $Content.Trim() | Set-Content -Path $TestFilePath
    }
    Invoke-ScriptAnalyzer -Path:("$TestFolderPath/*.Tests.ps1") -Recurse -ExcludeRule PSShouldProcess, PSAvoidTrailingWhitespace, PSAvoidUsingWMICmdlet, PSAvoidUsingPlainTextForPassword, PSAvoidUsingUsernameAndPasswordParams, PSAvoidUsingInvokeExpression, PSUseDeclaredVarsMoreThanAssignments, PSUseSingularNouns, PSAvoidGlobalVars, PSUseShouldProcessForStateChangingFunctions, PSAvoidUsingWriteHost, PSAvoidUsingPositionalParameters
    Write-Warning ("Make sure these are defined in the RunPesterTests.ps1 script! $($PesterTestVariableList -join ', ')")
    Write-Warning ("Make sure these are defined in the RunPesterTests.ps1 script! $($PesterTestDefVariableList -join ', ')")
}