$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Set-JcSdkUserAssociation.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Set-JcSdkUserAssociation' {
    BeforeAll{
        $types = @{
            'active_directory' = $($global:PesterTestActiveDirectory.id);
            'application'      = $($global:PesterTestApplication.id);
            'g_suite'          = $($global:PesterTestGSuite.id);
            'ldap_server'      = $($global:PesterTestLdap.id);
            'office_365'       = $($global:PesterTestOffice365.id);
            'radius_server'    = $($global:PesterTestRadiusServer.id);
            'system'           = $($global:PesterTestSystem.id);
            'system_group'     = $($global:PesterTestSystemGroup.id);
        }
    }
    It 'SetExpanded' {
        # Adds
        foreach ($type in $types.keys)
        {
            { Set-JcSdkUserAssociation -UserId:$($global:PesterTestUser.id) -Id:$($types[$type]) -Op:('add') -Type:($type) } | Should -Not -Throw
            # check that the association was added to the group
            Get-JcSdkUserAssociation -UserId:$($global:PesterTestUser.id) -Targets:($type) | Should -Not -BeNullOrEmpty
        }
        # Removes
        foreach ($type in $types.keys)
        {
            { Set-JcSdkUserAssociation -UserId:$($global:PesterTestUser.id) -Id:$($types[$type]) -Op:('remove') -Type:($type) } | Should -Not -Throw
            # check that the association was removed from the group
            $toId = Get-JcSdkUserAssociation -UserId $($global:PesterTestUser.Id) -Targets:($type)
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
            { Set-JcSdkUserAssociation -UserId:$($global:PesterTestUser.id) -Body $body } | Should -Not -Throw
            # check that the association was added to the group
            Get-JcSdkUserAssociation -UserId:$($global:PesterTestUser.id) -Targets:($type) | Should -Not -BeNullOrEmpty
        }
        foreach ($type in $types.keys)
        {
            $body = @{
                Id   = $($types[$type])
                Op   = 'remove'
                Type = $type
            }
            { Set-JcSdkUserAssociation -UserId:$($global:PesterTestUser.id) -Body $body } | Should -Not -Throw
            # check that the association was removed from the group
            $toId = Get-JcSdkUserAssociation -UserId $($global:PesterTestUser.Id) -Targets:($type)
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
