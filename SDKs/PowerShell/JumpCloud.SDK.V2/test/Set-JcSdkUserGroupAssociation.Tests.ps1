$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Set-JcSdkUserGroupAssociation.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Set-JcSdkUserGroupAssociation' {
    It 'SetExpanded' -skip {
        { Set-JcSdkUserGroupAssociation -GroupId:($global:PesterTestUserGroup.Id) -Id:($global:PesterTestSystemGroup.Id) -Op:('add') -Type:('system_group') [-Attributes '<Hashtable>'] } | Should -Not -Throw
    }

    It 'Set' {
        { Set-JcSdkUserGroupAssociation -Body:(@{Id = $global:PesterTestSystemGroup.Id; Op = 'remove'; Type = 'system_group';}) -GroupId:($global:PesterTestUserGroup.Id) } | Should -Not -Throw
        { Set-JcSdkUserGroupAssociation -Body:(@{Id = $global:PesterTestSystemGroup.Id; Op = 'add'; Type = 'system_group';}) -GroupId:($global:PesterTestUserGroup.Id) } | Should -Not -Throw
    }

    It 'SetViaIdentity' -skip {
        { Set-JcSdkUserGroupAssociation -Body:(@{Id = $global:PesterTestSystemGroup.Id; Op = 'add'; Type = 'system_group';}) -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { Set-JcSdkUserGroupAssociation -Id:($global:PesterTestSystemGroup.Id) -InputObject '<IJumpCloudApIsIdentity>' -Op:('add') -Type:('system_group') [-Attributes '<Hashtable>'] } | Should -Not -Throw
    }
}
