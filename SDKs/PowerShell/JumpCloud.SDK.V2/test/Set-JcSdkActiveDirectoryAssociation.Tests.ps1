$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Set-JcSdkActiveDirectoryAssociation.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Set-JcSdkActiveDirectoryAssociation' {
    It 'SetExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Set' {
        {Set-JcSdkActiveDirectoryAssociation -ActivedirectoryId $($global:PesterTestActiveDirectory.Id) -Id $($global:PesterTestUser.Id) -Op 'add' -Type 'user' } | Should -Not -Throw
        {Set-JcSdkActiveDirectoryAssociation -ActivedirectoryId $($global:PesterTestActiveDirectory.Id) -Id $($global:PesterTestUserGroup.Id) -Op 'add' -Type 'user_group' } | Should -Not -Throw
        {Set-JcSdkActiveDirectoryAssociation -ActivedirectoryId $($global:PesterTestActiveDirectory.Id) -Id $($global:PesterTestUser.Id) -Op 'remove' -Type 'user' } | Should -Not -Throw
        {Set-JcSdkActiveDirectoryAssociation -ActivedirectoryId $($global:PesterTestActiveDirectory.Id) -Id $($global:PesterTestUserGroup.Id) -Op 'remove' -Type 'user_group' } | Should -Not -Throw
    }

    It 'SetViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}