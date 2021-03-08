$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Set-JcSdkSystemGroupMember.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Set-JcSdkSystemGroupMember' {
    It 'SetExpanded' {
        { Set-JcSdkSystemGroupMember -GroupId $($global:PesterTestSystemGroup.id) -Id $($global:pesterTestSystem.id) -Op 'add' } | Should -Not -Throw
        # check that the user group member is in the group
        Get-JcSdkSystemGroupMember -GroupId $($global:PesterTestSystemGroup.Id) | Should -Not -BeNullOrEmpty
        { Set-JcSdkSystemGroupMember -GroupId $($global:PesterTestSystemGroup.id) -Id $($global:pesterTestSystem.id) -Op 'remove' } | Should -Not -Throw
        # check that the user was removed from the group
        $toId = Get-JcSdkSystemGroupMember -GroupId $($global:PesterTestSystemGroup.Id)
        $toId.ToId | Should -Not -Contain $($global:pesterTestSystem.Id)
    }

    It 'Set' {
        $body = @{
            Id         = $global:pesterTestSystem.Id;
            Op         = 'add';
            Type       = 'system';
            Attributes = @{};
        }
        { Set-JcSdkSystemGroupMember -GroupId $($global:PesterTestSystemGroup.id) -Body $body } | Should -Not -Throw
        # check that the user group member is in the group
        Get-JcSdkSystemGroupMember -GroupId $($global:PesterTestSystemGroup.Id) | Should -Not -BeNullOrEmpty
        $body.Op = 'remove'
        { Set-JcSdkSystemGroupMember -GroupId $($global:PesterTestSystemGroup.id) -Body $body } | Should -Not -Throw
        # check that the user was removed from the group
        $toId = Get-JcSdkSystemGroupMember -GroupId $($global:PesterTestSystemGroup.Id)
        $toId.ToId | Should -Not -Contain $($global:pesterTestSystem.Id)
    }

    It 'SetViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
