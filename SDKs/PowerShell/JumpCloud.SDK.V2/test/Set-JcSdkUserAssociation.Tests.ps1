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
    It 'SetExpanded' {
        { Set-JcSdkUserAssociation -Id:($global:PesterTestSystem.Id) -Op:('add') -Type:('system') -UserId:($global:PesterTestUser.Id) } | Should -Not -Throw
    }

    It 'Set' -skip {
        { Set-JcSdkUserAssociation -Body:($global:PesterTestUserAssociation) -UserId:($global:PesterTestUser.Id) } | Should -Not -Throw
    }

    It 'SetViaIdentity' -skip {
        { Set-JcSdkUserAssociation -Body:($global:PesterTestUserAssociation) -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { Set-JcSdkUserAssociation -Id:($global:PesterTestSystem.Id) -InputObject '<IJumpCloudApIsIdentity>' -Op:('add') -Type:('system') [-AttributeSudoEnabled] [-AttributeSudoWithoutPassword] } | Should -Not -Throw
    }
}
