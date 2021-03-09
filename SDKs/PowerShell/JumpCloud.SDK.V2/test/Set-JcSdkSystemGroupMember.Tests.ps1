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
        { Set-JcSdkSystemGroupMember -GroupId '<String>' -Id '<String>' -Op '<String>' [-Attributes '<Hashtable>'] [-Authorization '<String>'] [-Date '<String>'] } | Should -Not -Throw
    }

    It 'Set' -skip {
        { Set-JcSdkSystemGroupMember -Body '<IGraphOperationSystemGroupMember>' -GroupId '<String>' [-Authorization '<String>'] [-Date '<String>'] } | Should -Not -Throw
    }

    It 'SetViaIdentity' -skip {
        { Set-JcSdkSystemGroupMember -Body '<IGraphOperationSystemGroupMember>' -InputObject '<IJumpCloudApIsIdentity>' [-Authorization '<String>'] [-Date '<String>'] } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { Set-JcSdkSystemGroupMember -Id '<String>' -InputObject '<IJumpCloudApIsIdentity>' -Op '<String>' [-Attributes '<Hashtable>'] [-Authorization '<String>'] [-Date '<String>'] } | Should -Not -Throw
    }
}
