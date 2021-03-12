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
        { Set-JcSdkCommandAssociation -CommandId:($global:PesterTestCommand.Id) -Id:($global:PesterTestSystem.Id) -Op:('add') -Type:('system') [-Attributes '<Hashtable>'] } | Should -Not -Throw
    }

    It 'Set' {
        { Set-JcSdkCommandAssociation -Body:(@{Id = $global:PesterTestSystem.Id; Op = 'add'; Type = 'system';}) -CommandId:($global:PesterTestCommand.Id) } | Should -Not -Throw
    }

    It 'SetViaIdentity' -skip {
        { Set-JcSdkCommandAssociation -Body:(@{Id = $global:PesterTestSystem.Id; Op = 'add'; Type = 'system';}) -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { Set-JcSdkCommandAssociation -Id:($global:PesterTestSystem.Id) -InputObject '<IJumpCloudApIsIdentity>' -Op:('add') -Type:('system') [-Attributes '<Hashtable>'] } | Should -Not -Throw
    }
}
