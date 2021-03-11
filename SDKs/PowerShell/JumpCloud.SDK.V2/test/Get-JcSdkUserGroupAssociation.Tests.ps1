$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkUserGroupAssociation.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-JcSdkUserGroupAssociation' {
    It 'Get' {
        { Get-JcSdkUserGroupAssociation -GroupId:($global:PesterTestUserGroup.Id) -Targets:('system') } | Should -Not -Throw
    }

    It 'GetViaIdentity' -skip {
        Get-JcSdkUserGroupAssociation -InputObject '<IJumpCloudApIsIdentity>' -Targets:('system') | Should -Not -BeNullOrEmpty
    }
}
