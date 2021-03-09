$ModuleFolder = Join-Path "$PSScriptRoot\.." "\SDKs\PowerShell\" -Resolve
$SDKs = Get-ChildItem -Path $ModuleFolder
$SDKs | ForEach-Object {
    $PesterTestVariableList = @()
    $PesterTestDefVariableList = @()
    $Prefix = 'JcSdk'
    $Module = $_.BaseName
    $TestFolderPath = "$ModuleFolder\$Module\test\"
    Import-Module "$ModuleFolder\$Module\$Module.psd1"
    $Commands = Get-Command -Module $Module
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
                $Find = "    It '$($ParameterSetName)' -skip {`n        { throw [System.NotImplementedException] } | Should -Not -Throw`n    }"
                $Replace = If ($CommandVerb -eq 'Get')
                {
                    If ($ParameterSetName -eq 'List') { "    It '$ParameterSetName' {`n        $($CommandName) | Should -Not -BeNullOrEmpty`n    }" }
                    ElseIf ($ParameterSetName -eq 'Get') { "    It '$ParameterSetName' {`n        $($CommandName) -Id:($PesterTestVariable.Id) | Should -Not -BeNullOrEmpty`n    }" }
                    Else
                    {
                        Write-Warning ("Unmapped ParameterSetName: $ParameterSetName ($($CommandVerb))"); ;
                        "    It '$ParameterSetName' -Skip {`n        $($CommandName) $($Parameters) | Should -Not -BeNullOrEmpty`n    }"
                    }
                }
                ElseIf ($CommandVerb -eq 'New')
                {
                    If ($ParameterSetName -eq 'CreateExpanded') { "    It '$ParameterSetName' {`n        $PesterTestVariable = $($CommandName) $PesterTestDefVariable`n        $PesterTestVariable | Should -Not -BeNullOrEmpty`n    }" }
                    Else
                    {
                        Write-Warning ("Unmapped ParameterSetName: $ParameterSetName ($($CommandVerb))");
                        "    It '$ParameterSetName' -Skip {`n        $($CommandName) $($Parameters) | Should -Not -BeNullOrEmpty`n    }"
                    }
                }
                ElseIf ($CommandVerb -eq 'Remove')
                {
                    If ($ParameterSetName -eq 'Delete') { "    It '$ParameterSetName' {`n        { $($CommandName) -Id:($PesterTestVariable.Id) } | Should -Not -Throw`n    }" }
                    Else
                    {
                        Write-Warning ("Unmapped ParameterSetName: $ParameterSetName ($($CommandVerb))");
                        "    It '$ParameterSetName' -Skip {`n        { $($CommandName) $($Parameters) } | Should -Not -Throw`n    }"
                    }
                }
                ElseIf ($CommandVerb -in ('Clear', 'Invoke', 'Lock', 'Reset', 'Restart', 'Search', 'Set', 'Stop', 'Unlock'))
                {
                    Write-Warning ("Unmapped ParameterSetName: $ParameterSetName ($($CommandVerb))");
                    "    It '$ParameterSetName' -Skip {`n        { $($CommandName) $($Parameters) } | Should -Not -Throw`n    }"
                }
                Else
                {
                    Write-Warning ("Unmapped Verb: $CommandVerb")
                }
                If (-not [System.String]::IsNullOrEmpty($Replace))
                {
                    $Content = $Content.Replace("`r", "").Replace($Find, $Replace)
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