$ModuleFolder = Join-Path "$PSScriptRoot\.." "\SDKs\PowerShell\" -Resolve
$SDKs = Get-ChildItem -Path $ModuleFolder
    $ModuleName = $_.BaseName
    $PesterTestVariableList = @()
    $PesterTestDefVariableList = @()
    $Prefix = 'JcSdk'
    $Module = $_.BaseName
    $TestFolderPath = "$ModuleFolder\$Module\test\"
    Import-Module "$ModuleFolder\$Module\$Module.psd1"
    $Commands = Get-Command -Module $Module #-Verb Remove # For testing specific commands
    $Commands | ForEach-Object {
        $CommandName = $_.Name
        Write-Host ("Starting: $CommandName")
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
                Write-Host ("Starting: $CommandName $ParameterSetName")
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
                # Associations
                If ($CommandName -like '*GroupMember*' -or $CommandName -like '*Association*' -or $CommandName -like '*GroupTraverse*')
                {
                    If ($CommandName -like '*SystemGroupMember*')
                    {
                        $RequiredParameters = $RequiredParameters.Replace("-GroupId '<String>'", "-GroupId:(`$global:PesterTestSystemGroup.Id)")
                        $RequiredParameters = $RequiredParameters -Replace ("-Id '<String>'(.*?)-Op '<String>'", "-Id:(`$global:PesterTestSystem.Id)`${1}-Op:('add')")
                        $RequiredParameters = $RequiredParameters -Replace ("-Body '<.*?>'", "-Body:(@{Id = `$global:PesterTestSystem.Id; Op = 'add';})")

                    }
                    ElseIf ($CommandName -like '*SystemGroupAssociation*')
                    {
                        $RequiredParameters = $RequiredParameters.Replace("-GroupId '<String>'", "-GroupId:(`$global:PesterTestSystemGroup.Id)")
                        $RequiredParameters = $RequiredParameters -Replace ("-Id '<String>'(.*?)-Op '<String>' -Type '<String>'", "-Id:(`$global:PesterTestUserGroup.Id)`${1}-Op:('add') -Type:('user_group')")
                        $RequiredParameters = $RequiredParameters -Replace ("-Body '<.*?>'", "-Body:(@{Id = `$global:PesterTestUserGroup.Id; Op = 'add'; Type = 'user_group';})")
                        $RequiredParameters = $RequiredParameters.Replace("-Targets '<String>'", "-Targets:('user_group')")
                    }
                    ElseIf ($CommandName -like '*SystemGroupTraverse*')
                    {
                        $RequiredParameters = $RequiredParameters.Replace("-GroupId '<String>'", "-GroupId:(`$global:PesterTestSystemGroup.Id)")
                    }
                    ElseIf ($CommandName -like '*UserGroupMember*')
                    {
                        $RequiredParameters = $RequiredParameters.Replace("-GroupId '<String>'", "-GroupId:(`$global:PesterTestUserGroup.Id)")
                        $RequiredParameters = $RequiredParameters -Replace ("-Id '<String>'(.*?)-Op '<String>'", "-Id:(`$global:PesterTestUser.Id)`${1}-Op:('add')")
                        $RequiredParameters = $RequiredParameters -Replace ("-Body '<.*?>'", "-Body:(@{Id = `$global:PesterTestUser.Id; Op = 'add';})")

                    }
                    ElseIf ($CommandName -like '*UserGroupTraverse*')
                    {
                        $RequiredParameters = $RequiredParameters.Replace("-GroupId '<String>'", "-GroupId:(`$global:PesterTestUserGroup.Id)")
                    }
                    ElseIf ($CommandName -like '*UserGroupAssociation*')
                    {
                        $RequiredParameters = $RequiredParameters.Replace("-GroupId '<String>'", "-GroupId:(`$global:PesterTestUserGroup.Id)")
                        $RequiredParameters = $RequiredParameters -Replace ("-Id '<String>'(.*?)-Op '<String>' -Type '<String>'", "-Id:(`$global:PesterTestSystemGroup.Id)`${1}-Op:('add') -Type:('system_group')")
                        $RequiredParameters = $RequiredParameters -Replace ("-Body '<.*?>'", "-Body:(@{Id = `$global:PesterTestSystemGroup.Id; Op = 'add'; Type = 'system_group';})")
                        $RequiredParameters = $RequiredParameters.Replace("-Targets '<String>'", "-Targets:('system_group')")
                    }
                    ElseIf ($CommandName -like '*JcSdkCommandAssociation' -or $CommandName -like '*JcSdkSoftwareAppAssociation' -or $CommandName -like '*JcSdkPolicyAssociation' -or $CommandName -like '*JcSdkUserAssociation' )
                    {
                        $RequiredParameters = $RequiredParameters -Replace ("-Id '<String>'(.*?)-Op '<String>'(.*?)-Type '<String>'", "-Id:(`$global:PesterTestSystem.Id)`${1}-Op:('add')`${2}-Type:('system')")
                        $RequiredParameters = $RequiredParameters -Replace ("-Body '<.*?>'", "-Body:(@{Id = `$global:PesterTestSystem.Id; Op = 'add'; Type = 'system';})")
                        $RequiredParameters = $RequiredParameters.Replace("-Targets '<String>'", "-Targets:('system')")
                    }
                    Else
                    {
                        $RequiredParameters = $RequiredParameters -Replace ("-Id '<String>'(.*?)-Op '<String>'(.*?)-Type '<String>'", "-Id:(`$global:PesterTestUser.Id)`${1}-Op:('add')`${2}-Type:('user')")
                        $RequiredParameters = $RequiredParameters -Replace ("-Body '<.*?>'", "-Body:(@{Id = `$global:PesterTestUser.Id; Op = 'add'; Type = 'user';})")
                        $RequiredParameters = $RequiredParameters.Replace("-Targets '<String>'", "-Targets:('user')")
                    }
                }
                ElseIf ($ModuleName -eq 'JumpCloud.SDK.DirectoryInsights' -and $CommandName -like '*Event*')
                {
                    $RequiredParameters = $RequiredParameters.Replace("-Service '<String[]>' -StartTime '<DateTime>'", "-Service:('all') -StartTime:((Get-Date).AddHours(-24).ToUniversalTime())")
                    $RequiredParameters = $RequiredParameters -Replace ("-Body '<.*?>'", "-Body:(@{Service = 'all'; StartTime = (Get-Date).AddHours(-24).ToUniversalTime();})")
                }
                # Misc.
                $RequiredParameters = $RequiredParameters.Replace("-Subject '<String>' -Type '<String>'", "-Subject:(`$global:PesterTestCustomEmailConfiguration.Subject) -Type:(`$global:PesterTestCustomEmailConfiguration.Type)")
                $RequiredParameters = $RequiredParameters.Replace("-Name '<String>'", "-Name:($($PesterTestVariable).Name)")
                $RequiredParameters = $RequiredParameters.Replace("-CustomEmail '<ICustomEmail>'", "-CustomEmail:(`$global:PesterTestCustomEmailConfiguration)")
                $RequiredParameters = $RequiredParameters.Replace("-CustomEmailType '<String>'", "-CustomEmailType:(`$global:PesterTestCustomEmailConfiguration.Type)")
                $RequiredParameters = $RequiredParameters.Replace("-Triggername '<String>'", "-Triggername:(`$global:PesterTestCommand.trigger)")
                $RequiredParameters = $RequiredParameters -Replace ("(-Body '<)(.*?)(>')", "-Body:($($PesterTestVariable))")
                # Id replaces
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
                # Things that should just be user
                If ($CommandName -ne 'Remove-JcSdkUserSshKey')
                {
                    $RequiredParameters = $RequiredParameters.Replace('ExpireUserPassword', 'User')
                    $RequiredParameters = $RequiredParameters.Replace('UserSshKey', 'User')
                    $RequiredParameters = $RequiredParameters.Replace('UserMfa', 'User')
                }
                # Build function with parameters
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
                    SetAddRemoveShouldNotThrow      = "{ $($RequiredFunction.Replace("add","remove")) } | Should -Not -Throw`n        { $($RequiredFunction) } | Should -Not -Throw"
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
                        GetExpanded    = $PesterTestTypes.ShouldNotThrow
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
                        Set                    = If ($CommandName -in ('Set-JcSdkUserAssociation', 'Set-JcSdkUserGroupAssociation')) { $PesterTestTypes.SetAddRemoveShouldNotThrow }Else { $PesterTestTypes.ShouldNotThrow }
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
                    Write-Error ("Unmapped ParameterSetName in PesterTestFormatTable: $($CommandVerb).$($ParameterSetName)")
                }
                $Find = $Content | Select-String -Pattern:([regex]"(?smi)(It '$($ParameterSetName)' .*?{\s+)(.*?)(\n\s+})")
                $CurrentTest = $Find.Matches.Groups[2].Value
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
                    Else
                    {
                        If ($Find.Matches.Groups[1].Value -notlike '*-skip*')
                        {
                            $NewIt = $NewIt.Replace($Find.Matches.Groups[1].Value, $Find.Matches.Groups[1].Value.Replace("'$($ParameterSetName)'", "'$($ParameterSetName)' -skip"))
                        }
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