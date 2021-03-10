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
        { Set-JcSdkUserGroupAssociation -GroupId:($global:PesterTestUserGroup.Id) -Id:($global:PesterTestUser.Id) -Op '<String>' -Type '<String>' } | Should -Not -Throw
    }

    It 'Set' -skip {
        { Set-JcSdkUserGroupAssociation -Body '<IGraphOperationUserGroup>' -GroupId:($global:PesterTestUserGroup.Id) } | Should -Not -Throw
    }

    It 'SetViaIdentity' -skip {
        { Set-JcSdkUserGroupAssociation -Body '<IGraphOperationUserGroup>' -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { Set-JcSdkUserGroupAssociation -Id:($global:PesterTestUser.Id) -InputObject '<IJumpCloudApIsIdentity>' -Op '<String>' -Type '<String>' } | Should -Not -Throw
    }
}
