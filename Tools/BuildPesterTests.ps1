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
            $ParameterSets = $_.ParameterSets
            $ParameterSets | ForEach-Object {
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
                $Find = $Content | Select-String -Pattern:([regex]"(?smi)(It '$($ParameterSetName)' .*?{\s+)(.*?)(\n\s+})")
                $CurrentTest = $Find.Matches.Groups[2].Value
                If ($CommandName -like '*SystemGroupMember*' -or $CommandName -like '*SystemGroupAssociation*' -or $CommandName -like '*SystemGroupTraverse*')
                {
                    $RequiredParameters = $RequiredParameters.Replace("-GroupId '<String>'", "-GroupId:(`$global:PesterTestSystemGroup.Id)")
                    $RequiredParameters = $RequiredParameters.Replace("-Id '<String>'", "-Id:(`$global:PesterTestSystem.Id)")
                }
                ElseIf ($CommandName -like '*UserGroupMember*' -or $CommandName -like '*UserGroupAssociation*' -or $CommandName -like '*UserGroupTraverse*')
                {
                    $RequiredParameters = $RequiredParameters.Replace("-GroupId '<String>'", "-GroupId:(`$global:PesterTestUserGroup.Id)")
                    $RequiredParameters = $RequiredParameters.Replace("-Id '<String>'", "-Id:(`$global:PesterTestUser.Id)")
                }
                $RequiredParameters = $RequiredParameters.Replace("-Id '<String>'", "-Id:($($PesterTestVariable).Id)")
                $RequiredParameters = $RequiredParameters.Replace("-ActivedirectoryId '<String>'", "-ActivedirectoryId:(`$global:PesterTestActiveDirectory.Id)")
                $RequiredParameters = $RequiredParameters.Replace("-AppleMdmId '<String>'", "-AppleMdmId:(`$global:PesterTestAppleMdm.Id)")
                $RequiredParameters = $RequiredParameters.Replace("-ApplicationId '<String>'", "-ApplicationId:(`$global:PesterTestApplication.Id)")
                $RequiredParameters = $RequiredParameters.Replace("-CommandId '<String>'", "-CommandId:(`$global:PesterTestCommand.Id)")
                $RequiredParameters = $RequiredParameters.Replace("-GsuiteId '<String>'", "-GsuiteId:(`$global:PesterTestGsuite.Id)")
                $RequiredParameters = $RequiredParameters.Replace("-LdapserverId '<String>'", "-LdapserverId:(`$global:PesterTestLdapserver.Id)")
                $RequiredParameters = $RequiredParameters.Replace("-Office365Id '<String>'", "-Office365Id:(`$global:PesterTestOffice365.Id)")
                $RequiredParameters = $RequiredParameters.Replace("-PolicyId '<String>'", "-PolicyId:(`$global:PesterTestPolicy.Id)")
                $RequiredParameters = $RequiredParameters.Replace("-RadiusserverId '<String>'", "-RadiusserverId:(`$global:PesterTestRadiusserver.Id)")
                $RequiredParameters = $RequiredParameters.Replace("-SoftwareAppId '<String>'", "-SoftwareAppId:(`$global:PesterTestSoftwareApp.Id)")
                $RequiredParameters = $RequiredParameters.Replace("-SystemId '<String>'", "-SystemId:(`$global:PesterTestSystem.Id)")
                $RequiredParameters = $RequiredParameters.Replace("-SystemuserId '<String>'", "-SystemuserId:(`$global:PesterTestUser.Id)")
                $RequiredParameters = $RequiredParameters.Replace("-UserId '<String>'", "-UserId:(`$global:PesterTestUser.Id)")
                $RequiredParameters = $RequiredParameters.Replace("-CustomEmailType '<String>'", "-CustomEmailType:(`$global:PesterDefCustomEmailConfiguration.Type)")
                $RequiredParameters = $RequiredParameters.Replace("-Triggername '<String>'", "-Triggername:(`$global:PesterTestCommand.trigger)")
                $RequiredParameters = $RequiredParameters.Replace("-Targets '<String>'", "-Targets:('user')")
                $RequiredParameters = $RequiredParameters -Replace ("(-Body '<)(.*?)(>')", "-Body:($($PesterTestVariable))")
                If ($CommandName -ne 'Remove-JcSdkUserSshKey')
                {
                    $RequiredParameters = $RequiredParameters.Replace('ExpireUserPassword', 'User')
                    $RequiredParameters = $RequiredParameters.Replace('UserSshKey', 'User')
                    $RequiredParameters = $RequiredParameters.Replace('UserMfa', 'User')
                }
                # -Op '<String>' -Type '<String>'
                # $RequiredParameters = $RequiredParameters.Replace("-$($Type)Id '<String>'", "-$($Type)Id:(`$global:PesterTest$($Type).Id)")
                $RequiredFunction = If ($RequiredParameters)
                {
                    "$($CommandName) $($RequiredParameters)"
                }
                Else
                {
                    $CommandName
                }
                $OptionalFunction = If ($OptionalParameters)
                {
                    "$($RequiredFunction) $($OptionalParameters)"
                }
                Else
                {
                    $RequiredFunction
                }
                $PesterTestTypes = [Ordered]@{
                    ShouldNotThrow                  = "{ $($RequiredFunction) } | Should -Not -Throw"
                    NewObjectShouldNotBeNullOrEmpty = "$PesterTestVariable = $($CommandName) $PesterTestDefVariable`n        $PesterTestVariable | Should -Not -BeNullOrEmpty"
                    ShouldNotBeNullOrEmpty          = "$($RequiredFunction) | Should -Not -BeNullOrEmpty"
                }
                $PesterTestFormatTable = [Ordered]@{
                    Clear   = [Ordered]@{
                        Clear                    = $null
                        ClearExpanded            = $null
                        ClearViaIdentity         = $null
                        ClearViaIdentityExpanded = $null
                    }
                    Get     = [Ordered]@{
                        Get            = $PesterTestTypes.ShouldNotThrow
                        GetViaIdentity = $null
                        List           = $PesterTestTypes.ShouldNotThrow
                    }
                    Grant   = [Ordered]@{
                        Authorize                    = $null
                        AuthorizeExpanded            = $null
                        AuthorizeViaIdentity         = $null
                        AuthorizeViaIdentityExpanded = $null
                    }
                    Import  = [Ordered]@{
                        Import            = $null
                        ImportViaIdentity = $null
                    }
                    Invoke  = [Ordered]@{
                        Post            = $PesterTestTypes.ShouldNotThrow
                        PostViaIdentity = $null
                    }
                    Lock    = [Ordered]@{
                        Lock                    = $PesterTestTypes.ShouldNotThrow
                        LockExpanded            = $null
                        LockViaIdentity         = $null
                        LockViaIdentityExpanded = $null
                    }
                    New     = [Ordered]@{
                        Create                    = $null
                        CreateExpanded            = $PesterTestTypes.NewObjectShouldNotBeNullOrEmpty
                        CreateViaIdentity         = $null
                        CreateViaIdentityExpanded = $null
                    }
                    Remove  = [Ordered]@{
                        Delete            = $PesterTestTypes.ShouldNotThrow
                        DeleteViaIdentity = $null
                    }
                    Reset   = [Ordered]@{
                        Reset                    = $PesterTestTypes.ShouldNotThrow
                        ResetExpanded            = $null
                        ResetViaIdentity         = $null
                        ResetViaIdentityExpanded = $null
                    }
                    Restart = [Ordered]@{
                        Restart            = $null
                        RestartViaIdentity = $null
                    }
                    Search  = [Ordered]@{
                        Search         = $null
                        SearchExpanded = $null
                    }
                    Set     = [Ordered]@{
                        Set                    = $PesterTestTypes.ShouldNotThrow
                        SetExpanded            = $null
                        SetViaIdentity         = $null
                        SetViaIdentityExpanded = $null
                    }
                    Stop    = [Ordered]@{
                        Stop            = $null
                        StopViaIdentity = $null
                    }
                    Sync    = [Ordered]@{
                        Sync            = $null
                        SyncViaIdentity = $null
                    }
                    Unlock  = [Ordered]@{
                        Unlock            = $PesterTestTypes.ShouldNotThrow
                        UnlockViaIdentity = $null
                    }
                    Update  = [Ordered]@{
                        Update                    = $null
                        UpdateExpanded            = $null
                        UpdateViaIdentity         = $null
                        UpdateViaIdentityExpanded = $null
                    }
                }
                If (-not $PesterTestFormatTable.Contains($CommandVerb))
                {
                    Write-Error ("Unmapped Verb in PesterTestFormatTable: $CommandVerb")
                }
                If (-not $PesterTestFormatTable.$CommandVerb.Contains($ParameterSetName))
                {
                    Write-Error ("Unmapped ParameterSetName in PesterTestFormatTable: $ParameterSetName")
                }
                $NewTest = $PesterTestFormatTable.$CommandVerb.$ParameterSetName
                If ([System.String]::IsNullOrEmpty($NewTest))
                {
                    $Skip = $true
                    # Write-Warning ("Unmapped Test Format for Verb: $CommandVerb; ParameterSetName: $ParameterSetName;")
                    $NewTest = "{ $($OptionalFunction) } | Should -Not -Throw"
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
                # Write-Host ("$($ParameterSetName): $($ParameterName)$($RequiredFunction)")
            }
        }
        $Content.Trim() | Set-Content -Path $TestFilePath
    }
    Write-Warning ("Make sure these are defined in the RunPesterTests.ps1 script! $($PesterTestVariableList -join ', ')")
    Write-Warning ("Make sure these are defined in the RunPesterTests.ps1 script! $($PesterTestDefVariableList -join ', ')")
    Invoke-ScriptAnalyzer -Path:("$TestFolderPath/*.Tests.ps1") -Recurse -ExcludeRule PSShouldProcess, PSAvoidTrailingWhitespace, PSAvoidUsingWMICmdlet, PSAvoidUsingPlainTextForPassword, PSAvoidUsingUsernameAndPasswordParams, PSAvoidUsingInvokeExpression, PSUseDeclaredVarsMoreThanAssignments, PSUseSingularNouns, PSAvoidGlobalVars, PSUseShouldProcessForStateChangingFunctions, PSAvoidUsingWriteHost, PSAvoidUsingPositionalParameters
}