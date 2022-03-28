BeforeAll {
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


}
Describe 'Set-JcSdkSystemGroupMember' -Tag:("")){
    It 'SetExpanded' {
        { Set-JcSdkSystemGroupMember -GroupId:($global:PesterTestSystemGroup.Id) -Id:($global:PesterTestSystem.Id) -Op:('add') } | Should -Not -Throw
    }

    It 'Set' -skip {
        { Set-JcSdkSystemGroupMember -Body:(@{Id = $global:PesterTestSystem.Id; Op = 'add';}) -GroupId:($global:PesterTestSystemGroup.Id) } | Should -Not -Throw
    }

    It 'SetViaIdentity' -skip {
        { Set-JcSdkSystemGroupMember -Body:(@{Id = $global:PesterTestSystem.Id; Op = 'add';}) -InputObject '<IJumpCloudApIsIdentity>' [-Authorization '<String>'] [-Date '<String>'] } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { Set-JcSdkSystemGroupMember -Id:($global:PesterTestSystem.Id) -InputObject '<IJumpCloudApIsIdentity>' -Op:('add') [-Attributes '<Hashtable>'] [-Authorization '<String>'] [-Date '<String>'] } | Should -Not -Throw
    }
}

