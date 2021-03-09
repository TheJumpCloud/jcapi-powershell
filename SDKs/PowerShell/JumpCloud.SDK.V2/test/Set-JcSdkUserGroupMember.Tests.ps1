$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Set-JcSdkUserGroupMember.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Set-JcSdkUserGroupMember' {
    It 'SetExpanded' -skip {
        { Set-JcSdkUserGroupMember -GroupId '<String>' -Id '<String>' -Op '<String>' [-Attributes '<Hashtable>'] } | Should -Not -Throw
    }

    It 'Set' -skip {
        { Set-JcSdkUserGroupMember -Body '<IGraphOperationUserGroupMember>' -GroupId '<String>' } | Should -Not -Throw
    }

    It 'SetViaIdentity' -skip {
        { Set-JcSdkUserGroupMember -Body '<IGraphOperationUserGroupMember>' -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { Set-JcSdkUserGroupMember -Id '<String>' -InputObject '<IJumpCloudApIsIdentity>' -Op '<String>' [-Attributes '<Hashtable>'] } | Should -Not -Throw
    }
}
