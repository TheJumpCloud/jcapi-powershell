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
        { Set-JcSdkUserGroupMember -GroupId:($global:PesterTestUserGroup.Id) -Id:($global:PesterTestUser.Id) -Op:('add') } | Should -Not -Throw
    }

    It 'Set' -skip {
        { Set-JcSdkUserGroupMember -Body:(@{Id = $global:PesterTestUser.Id; Op = 'add';}) -GroupId:($global:PesterTestUserGroup.Id) } | Should -Not -Throw
    }

    It 'SetViaIdentity' -skip {
        { Set-JcSdkUserGroupMember -Body:(@{Id = $global:PesterTestUser.Id; Op = 'add';}) -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { Set-JcSdkUserGroupMember -Id:($global:PesterTestUser.Id) -InputObject '<IJumpCloudApIsIdentity>' -Op:('add') [-Attributes '<Hashtable>'] } | Should -Not -Throw
    }
}
