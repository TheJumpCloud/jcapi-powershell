$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkCommandTraverseSystemGroup.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-JcSdkCommandTraverseSystemGroup' {
    BeforeAll {
        Set-JcSdkCommandAssociation -CommandId $($global:PesterTestCommand.id) -Id $($global:PesterTestSystemGroup.Id) -Op 'add' -Type 'system_group'
    }
    AfterAll {
        Set-JcSdkCommandAssociation -CommandId $($global:PesterTestCommand.id) -Id $($global:PesterTestSystemGroup.Id) -Op 'remove' -Type 'system_group'
    }
    It 'List' {
        Get-JcSdkCommandTraverseSystemGroup -CommandId $($global:PesterTestCommand.id) | Should -Not -BeNullOrEmpty
    }
}
