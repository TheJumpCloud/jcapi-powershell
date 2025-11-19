BeforeAll {
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


}
Describe 'Set-JcSdkUserGroupAssociation' -Tag:(""){
    It 'SetExpanded' {
        # get a user group
        $group = Get-JcSdkUserGroup | Select-Object -First 1
        {Set-JcSdkUserGroupAssociation -GroupId $group.Id -Op 'add' -Type 'ldap_server' -id $global:PesterTestLdapServer.Id} | Should -Not -Throw
        {Set-JcSdkUserGroupAssociation -GroupId $group.Id -Op 'remove' -Type 'ldap_server' -id $global:PesterTestLdapServer.Id} | Should -Not -Throw
    }

    It 'SetViaIdentity' -skip {
        { Set-JcSdkUserGroupAssociation -Body:(@{Id = $global:PesterTestSystemGroup.Id; Op = 'add'; Type = 'system_group';}) -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { Set-JcSdkUserGroupAssociation -Id:($global:PesterTestSystemGroup.Id) -InputObject '<IJumpCloudApIsIdentity>' -Op:('add') -Type:('system_group') [-Attributes '<Hashtable>'] } | Should -Not -Throw
    }
}

