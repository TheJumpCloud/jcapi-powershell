$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Set-JcSdkCommandAssociation.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Set-JcSdkCommandAssociation' {
    It 'SetExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Set' {
        { Set-JcSdkCommandAssociation -CommandId $($global:PesterTestCommand.Id) -Id $($global:PesterTestSystem.Id) -Op 'add' -Type 'system' } | Should -Not -Throw
        { Set-JcSdkCommandAssociation -CommandId $($global:PesterTestCommand.Id) -Id $($global:PesterTestSystemGroup.Id) -Op 'add' -Type 'system_group' } | Should -Not -Throw
        { Set-JcSdkCommandAssociation -CommandId $($global:PesterTestCommand.Id) -Id $($global:PesterTestSystem.Id) -Op 'remove' -Type 'system' } | Should -Not -Throw
        { Set-JcSdkCommandAssociation -CommandId $($global:PesterTestCommand.Id) -Id $($global:PesterTestSystemGroup.Id) -Op 'remove' -Type 'system_group' } | Should -Not -Throw
    }

    It 'SetViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
