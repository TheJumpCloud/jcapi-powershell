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
    It 'SetExpanded' {
        Set-JcSdkCommandAssociation -CommandId $($global:PesterTestCommand.id) -Id:($global:PesterTestSystem.Id) -Op:('add') -Type:('system')
        Get-JcSdkCommandAssociation -CommandId $($global:PesterTestCommand.id) -targets:('system') | Should -Not -BeNullOrEmpty

        Set-JcSdkCommandAssociation -CommandId $($global:PesterTestCommand.id) -Id:($global:PesterTestSystem.Id) -Op:('remove') -Type:('system')
        Get-JcSdkCommandAssociation -CommandId $($global:PesterTestCommand.id) -targets:('system') | Should -BeNullOrEmpty
    }

    It 'Set' {
        $PesterDefAssociation = @{
            Id   = $global:PesterTestSystem.Id;
            Op   = 'add';
            Type = 'system';
            Attributes = @{};
        }
        Set-JcSdkCommandAssociation -CommandId $($global:PesterTestCommand.id) -Body $PesterDefAssociation
        Get-JcSdkCommandAssociation -CommandId $($global:PesterTestCommand.id) -targets:('system') | Should -Not -BeNullOrEmpty

        $PesterDefAssociation.Op = 'remove'
        Set-JcSdkCommandAssociation -CommandId $($global:PesterTestCommand.id) -Body $PesterDefAssociation
        Get-JcSdkCommandAssociation -CommandId $($global:PesterTestCommand.id) -targets:('system') | Should -BeNullOrEmpty
    }

    It 'SetViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
