$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Set-JcSdkSystemGroupMember.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Set-JcSdkSystemGroupMember' {
    It 'SetExpanded' -skip {
        { Set-JcSdkSystemGroupMember -GroupId:($global:PesterTestSystemGroup.Id) -Id:($global:PesterTestSystem.Id) -Op '<String>' } | Should -Not -Throw
    }

    It 'Set' -skip {
        { Set-JcSdkSystemGroupMember -Body '<IGraphOperationSystemGroupMember>' -GroupId:($global:PesterTestSystemGroup.Id) } | Should -Not -Throw
    }

    It 'SetViaIdentity' -skip {
        { Set-JcSdkSystemGroupMember -Body '<IGraphOperationSystemGroupMember>' -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { Set-JcSdkSystemGroupMember -Id:($global:PesterTestSystem.Id) -InputObject '<IJumpCloudApIsIdentity>' -Op '<String>' } | Should -Not -Throw
    }
}
