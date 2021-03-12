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
    It 'SetExpanded' -skip {
        { Set-JcSdkSystemGroupAssociation -GroupId:($global:PesterTestSystemGroup.Id) -Id:($global:PesterTestUserGroup.Id) -Op:('add') -Type:('user_group') [-Attributes '<Hashtable>'] } | Should -Not -Throw
    }

    It 'Set' {
        { Set-JcSdkSystemGroupAssociation -Body:(@{Id = $global:PesterTestUserGroup.Id; Op = 'add'; Type = 'user_group';}) -GroupId:($global:PesterTestSystemGroup.Id) } | Should -Not -Throw
    }

    It 'SetViaIdentity' -skip {
        { Set-JcSdkSystemGroupAssociation -Body:(@{Id = $global:PesterTestUserGroup.Id; Op = 'add'; Type = 'user_group';}) -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { Set-JcSdkSystemGroupAssociation -Id:($global:PesterTestUserGroup.Id) -InputObject '<IJumpCloudApIsIdentity>' -Op:('add') -Type:('user_group') [-Attributes '<Hashtable>'] } | Should -Not -Throw
    }
}
