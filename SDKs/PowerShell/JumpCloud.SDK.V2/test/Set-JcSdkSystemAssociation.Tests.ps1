$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Set-JcSdkSystemAssociation.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Set-JcSdkSystemAssociation' {
    It 'SetExpanded' {
        { Set-JcSdkSystemAssociation -Id:($global:PesterTestUser.Id) -Op:('add') -SystemId:($global:PesterTestSystem.Id) -Type:('user') } | Should -Not -Throw
    }

    It 'Set' -skip {
        { Set-JcSdkSystemAssociation -Body:($global:PesterTestSystemAssociation) -SystemId:($global:PesterTestSystem.Id) [-Authorization '<String>'] [-Date '<String>'] } | Should -Not -Throw
    }

    It 'SetViaIdentity' -skip {
        { Set-JcSdkSystemAssociation -Body:($global:PesterTestSystemAssociation) -InputObject '<IJumpCloudApIsIdentity>' [-Authorization '<String>'] [-Date '<String>'] } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { Set-JcSdkSystemAssociation -Id:($global:PesterTestUser.Id) -InputObject '<IJumpCloudApIsIdentity>' -Op:('add') -Type:('user') [-AttributeSudoEnabled] [-AttributeSudoWithoutPassword] [-Authorization '<String>'] [-Date '<String>'] } | Should -Not -Throw
    }
}
