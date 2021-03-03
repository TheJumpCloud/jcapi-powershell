$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Set-JcSdkUserGroupMember.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Set-JcSdkUserGroupMember' {
    It 'SetExpanded' {
        Set-JcSdkUserGroupMember -GroupId $($global:PesterTestUserGroup.id) -Id $($global:PesterTestUser.id) -Op 'add'
        Set-JcSdkUserGroupMember -GroupId $($global:PesterTestUserGroup.id) -Id $($global:PesterTestUser.id) -Op 'remove'
    }

    It 'Set' {
        $body = @{
            Id         = $global:PesterTestUser.Id;
            Op         = 'add';
            Type       = 'user';
            Attributes = @{};
        }
        {Set-JcSdkUserGroupMember -GroupId $($global:PesterTestUserGroup.id) -Body $body} | Should -Not -Throw
        Get-JcSdkUserGroupMember -GroupId $($global:PesterTestUserGroup.Id) | Should -Not -BeNullOrEmpty
        $body.Op = 'remove'
        {Set-JcSdkUserGroupMember -GroupId $($global:PesterTestUserGroup.id) -Body $body} | Should -Not -Throw
        # check that the user was removed from the group
        $toId = Get-JcSdkUserGroupMember -GroupId $($global:PesterTestUserGroup.Id)
        $toId.ToId | Should -Not -Contain $($global:PesterTestUser.Id)
    }

    It 'SetViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
