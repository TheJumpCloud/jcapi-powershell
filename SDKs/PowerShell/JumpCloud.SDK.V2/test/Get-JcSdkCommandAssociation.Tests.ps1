$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkCommandAssociation.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-JcSdkCommandAssociation' {
    BeforeAll {
        Set-JcSdkCommandAssociation -CommandId $($global:PesterTestCommand.id) -Id $($global:PesterTestSystem.Id) -Op 'add' -Type 'system'
    }
    AfterAll {
        Set-JcSdkCommandAssociation -CommandId $($global:PesterTestCommand.id) -Id $($global:PesterTestSystem.Id) -Op 'remove' -Type 'system'
    }
    It 'List' {
        Get-JcSdkCommandAssociation -CommandId $($global:PesterTestCommand.id) -targets "system" | Should -Not -BeNullOrEmpty
    }
}
