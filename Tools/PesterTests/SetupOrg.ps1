Param(
    [Parameter(Mandatory = $true, ValueFromPipelineByPropertyName = $true, Position = 0)][ValidateNotNullOrEmpty()][System.String]$JumpCloudApiKey
    , [Parameter(Mandatory = $true, ValueFromPipelineByPropertyName = $true, Position = 1)][ValidateNotNullOrEmpty()][System.String]$JumpCloudApiKeyMsp
)
Try
{
    # Define variable names
    $PesterParamsHash_VariableName = @{
        VariableNamePrefix     = 'PesterParams_';
        VariableNamePrefixHash = 'PesterParamsHash_';
    }
    # Tear down org
    Function Remove-Org
    {
        Param(
            [switch]$Users
            , [switch]$Systems
            # , [switch]$Policies
            , [switch]$Groups
            # , [switch]$Applications
            # , [switch]$Directories
            , [switch]$Commands
            , [switch]$RadiusServers
        )
        # Remove all users from an org
        If ($Users)
        {
            $NonExternallyManagedUsersToRemove = Get-JcSdkSystemUser | Where-Object { ($_.Email -like '*delete*' -or $_.Email -like '*pester*') -and -not $_.externally_managed }
            $RemoveNonExternallyManagedUsers = $NonExternallyManagedUsersToRemove | Remove-JcSdkSystemUser
            $ExternallyManagedUsersToRemove = Get-JcSdkSystemUser | Where-Object { ($_.Email -like '*delete*' -or $_.Email -like '*pester*') -and $_.externally_managed }
            $UpdateExternallyManagedUsersToRemove = $ExternallyManagedUsersToRemove | Set-JcSdkSystemUser -externally_managed $false
            $RemoveExternallyManagedUsers = $ExternallyManagedUsersToRemove | Remove-JcSdkSystemUser
        }
        # Remove all systems from an org
        If ($Systems)
        {
            $null = Get-JcSdkSystem | Remove-JcSdkSystem
        }
        # Remove all groups from an org
        If ($Groups)
        {
            $null = Get-JcSdkGroup | ForEach-Object { If ($_.Type -eq 'system_group') { Remove-JcSdkSystemGroup -GroupName:($_.Name) }ElseIf ($_.Type -eq 'user_group') { Remove-JcSdkUserGroup -GroupName:($_.Name) }Else { Write-Error('Unknown') } }
        }
        # Remove all Commands from an org
        If ($Commands)
        {
            $null = Get-JcSdkCommand | Remove-JcSdkCommand
        }
        # Remove all RadiusServers from an org
        If ($RadiusServers)
        {
            $null = Get-JcSdkRadiusServer | Remove-JcSdkRadiusServer
        }
    }
    Remove-Org -Users -Groups -Commands -RadiusServers

    # Setup org
    $PesterParamsHash_BuildOrg = @{
        # Newly created objects
        User1          = New-JcSdkSystemUser @PesterParams_NewUser
        UserGroup      = New-JcSdkUserGroup @PesterParams_NewUserGroup
        SystemGroup    = New-JcSdkSystemGroup @PesterParams_NewSystemGroup
        RadiusServer   = New-JcSdkRadiusServer @PesterParams_NewRadiusServer
        Command        = New-JcSdkCommand @PesterParams_NewCommand
        # Get info for things that have already been setup within the org. TODO dynamically create these
        # Add systems: Windows, Mac, and Linux
        # Create 2 new policies and assign policy to system
        Org            = Get-JcSdkOrganization
        Policy         = Get-JcSdkPolicy -Name:($PesterParams_SinglePolicyList)
        SystemLinux    = Get-JcSdkSystem -displayName:($PesterParams_SystemNameLinux)
        SystemMac      = Get-JcSdkSystem -displayName:($PesterParams_SystemNameMac)
        SystemWindows  = Get-JcSdkSystem -displayName:($PesterParams_SystemNameWindows)
        CommandResults = Get-JcSdkCommandResult
    }
    $PesterParamsHash_Associations = @{
        PolicySystemGroupMembership   = $PesterParamsHash_BuildOrg.MultiplePolicy | ForEach-Object {
            If (-not (Get-JcSdkAssociation -Type:('policy') -Id:($_.id) -TargetType:('system_group') | Where-Object { $_.targetId -eq $PesterParamsHash_BuildOrg.SystemGroup.id })) { New-JcSdkAssociation -Type:('policy') -Id:($_.id) -TargetType:('system_group') -TargetId:($PesterParamsHash_BuildOrg.SystemGroup.id); };
        };
        UserGroupMembership           = If (-not (Get-JcSdkAssociation -Type:('user_group') -Id:($PesterParamsHash_BuildOrg.UserGroup.id) -TargetType:('user') | Where-Object { $_.targetId -eq $PesterParamsHash_BuildOrg.User1.id })) { New-JcSdkAssociation -Type:('user_group') -Id:($PesterParamsHash_BuildOrg.UserGroup.id) -TargetType:('user') -TargetId:($PesterParamsHash_BuildOrg.User1.id); };
        SystemUserMembership          = If (-not (Get-JcSdkAssociation -Type:('system') -Id:($PesterParamsHash_BuildOrg.SystemLinux._id) -TargetType:('user') | Where-Object { $_.targetId -eq $PesterParamsHash_BuildOrg.User1.id })) { New-JcSdkAssociation -Type:('system') -Id:($PesterParamsHash_BuildOrg.SystemLinux._id) -TargetType:('user') -TargetId:($PesterParamsHash_BuildOrg.User1.id); };
        SystemPolicyMembership        = If (-not (Get-JcSdkAssociation -Type:('system') -Id:($PesterParamsHash_BuildOrg.SystemLinux._id) -TargetType:('policy') | Where-Object { $_.targetId -eq $PesterParamsHash_BuildOrg.SinglePolicy.id })) { New-JcSdkAssociation -Type:('system') -Id:($PesterParamsHash_BuildOrg.SystemLinux._id) -TargetType:('policy') -TargetId:($PesterParamsHash_BuildOrg.SinglePolicy.id); };
        Command1SystemGroupMembership = If (-not (Get-JcSdkAssociation -Type:('command') -Id:($PesterParamsHash_BuildOrg.Command1._id) -TargetType:('system_group') | Where-Object { $_.targetId -eq $PesterParamsHash_BuildOrg.SystemGroup.id })) { New-JcSdkAssociation -Type:('command') -Id:($PesterParamsHash_BuildOrg.Command1._id) -TargetType:('system_group') -TargetId:($PesterParamsHash_BuildOrg.SystemGroup.id); };
        Command2SystemGroupMembership = If (-not (Get-JcSdkAssociation -Type:('command') -Id:($PesterParamsHash_BuildOrg.Command2._id) -TargetType:('system_group') | Where-Object { $_.targetId -eq $PesterParamsHash_BuildOrg.SystemGroup.id })) { New-JcSdkAssociation -Type:('command') -Id:($PesterParamsHash_BuildOrg.Command2._id) -TargetType:('system_group') -TargetId:($PesterParamsHash_BuildOrg.SystemGroup.id); };
        Command3SystemGroupMembership = If (-not (Get-JcSdkAssociation -Type:('command') -Id:($PesterParamsHash_BuildOrg.Command3._id) -TargetType:('system_group') | Where-Object { $_.targetId -eq $PesterParamsHash_BuildOrg.SystemGroup.id })) { New-JcSdkAssociation -Type:('command') -Id:($PesterParamsHash_BuildOrg.Command3._id) -TargetType:('system_group') -TargetId:($PesterParamsHash_BuildOrg.SystemGroup.id); };
    }
    # Generate command results of they dont exist
    If ([System.String]::IsNullOrEmpty($PesterParamsHash_BuildOrg.CommandResults) -or $PesterParamsHash_BuildOrg.CommandResults.Count -lt $PesterParams_CommandResultCount)
    {
        If (-not (Get-JcSdkAssociation -Type:('command') -Id:($PesterParamsHash_BuildOrg.Command1._id) -TargetType:('system') | Where-Object { $_.targetId -eq $PesterParamsHash_BuildOrg.SystemLinux._id }))
        {
            New-JcSdkAssociation -Type:('command') -Id:($PesterParamsHash_BuildOrg.Command1._id) -TargetType:('system') -TargetId:($PesterParamsHash_BuildOrg.SystemLinux._id)
        };
        For ($i = 1; $i -le $PesterParams_CommandResultCount; $i++)
        {
            Invoke-JcSdkCommand -trigger:($PesterParamsHash_BuildOrg.Command1.trigger)
        }
        While ((Get-JcSdkCommandResult | Where-Object { $_.Name -eq $PesterParamsHash_BuildOrg.Command1.name }).Count -ge $PesterParams_CommandResultCount)
        {
            Start-Sleep -Seconds:(1)
        }
        If ((Get-JcSdkAssociation -Type:('command') -Id:($PesterParamsHash_BuildOrg.Command1._id) -TargetType:('system') | Where-Object { $_.targetId -eq $PesterParamsHash_BuildOrg.SystemLinux._id }))
        {
            Remove-JcSdkAssociation -Type:('command') -Id:($PesterParamsHash_BuildOrg.Command1._id) -TargetType:('system') -TargetId:($PesterParamsHash_BuildOrg.SystemLinux._id)
        };
    }
    # Combine all hash tables into one list and foreach of their values create a new global parameter
    (Get-Variable -Scope:('Script') -Name:("$($PesterParamsHash_VariableName.VariableNamePrefixHash)*")).Value | ForEach-Object {
        $_.GetEnumerator() | ForEach-Object {
            Set-Variable -Name:("$($PesterParamsHash_VariableName.VariableNamePrefix)$($_.Name)") -Value:($_.Value) -Scope:('Global')
        }
    }
}
Catch
{
    Write-Error ($_)
}
