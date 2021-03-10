$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Set-JcSdkUserGroup.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Set-JcSdkUserGroup' {
    It 'SetExpanded' -skip {
        { Set-JcSdkUserGroup -Id:($global:PesterTestUserGroup.Id) -Name '<String>' } | Should -Not -Throw
    }

    It 'Set' -skip {
        { Set-JcSdkUserGroup -Body '<IUserGroupPut>' -Id:($global:PesterTestUserGroup.Id) } | Should -Not -Throw
    }

    It 'SetViaIdentity' -skip {
        { Set-JcSdkUserGroup -Body '<IUserGroupPut>' -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { Set-JcSdkUserGroup -InputObject '<IJumpCloudApIsIdentity>' -Name '<String>' } | Should -Not -Throw
    }
}
