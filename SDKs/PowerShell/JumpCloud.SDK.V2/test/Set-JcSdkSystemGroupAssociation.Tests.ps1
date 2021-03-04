$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Set-JcSdkSystemGroupAssociation.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Set-JcSdkSystemGroupAssociation' {
    BeforeAll {
        $types = @{
            'command'       = $($global:PesterTestCommand.id);
            'policy'      = $($global:PesterTestWindowsPolicy.id);
            'user'          = $($global:PesterTestUser.id);
            'user_group'      = $($global:PesterTestUserGroup.id);
        }
    }
    It 'SetExpanded' {
        # Adds
        foreach ($type in $types.keys)
        {
            { Set-JcSdkSystemGroupAssociation -GroupId:$($global:PesterTestSystemGroup.id) -Id:$($types[$type]) -Op:('add') -Type:($type) } | Should -Not -Throw
            # check that the association was added to the group
            Get-JcSdkSystemGroupAssociation -GroupId:$($global:PesterTestSystemGroup.id) -Targets:($type) | Should -Not -BeNullOrEmpty
        }
        # Removes
        foreach ($type in $types.keys)
        {
            { Set-JcSdkSystemGroupAssociation -GroupId:$($global:PesterTestSystemGroup.id) -Id:$($types[$type]) -Op:('remove') -Type:($type) } | Should -Not -Throw
            # check that the association was removed from the group
            $toId = Get-JcSdkSystemGroupAssociation -GroupId $($global:PesterTestSystemGroup.Id) -Targets:($type)
            $toId.ToId | Should -Not -Contain $($types[$type])
        }
    }

    It 'Set' {
        foreach ($type in $types.keys)
        {
            $body = @{
                Id   = $($types[$type])
                Op   = 'add'
                Type = $type
            }
            { Set-JcSdkSystemGroupAssociation -GroupId:$($global:PesterTestSystemGroup.id) -Body $body } | Should -Not -Throw
            # check that the association was added to the group
            Get-JcSdkSystemGroupAssociation -GroupId:$($global:PesterTestSystemGroup.id) -Targets:($type) | Should -Not -BeNullOrEmpty
        }
        foreach ($type in $types.keys)
        {
            $body = @{
                Id   = $($types[$type])
                Op   = 'remove'
                Type = $type
            }
            { Set-JcSdkSystemGroupAssociation -GroupId:$($global:PesterTestSystemGroup.id) -Body $body } | Should -Not -Throw
            # check that the association was removed from the group
            $toId = Get-JcSdkSystemGroupAssociation -GroupId $($global:PesterTestSystemGroup.Id) -Targets:($type)
            $toId.ToId | Should -Not -Contain $($types[$type])
        }
    }

    It 'SetViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
