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
    It 'SetExpanded' {
        { Set-JcSdkActiveDirectoryAssociation -ActivedirectoryId:($global:PesterTestActiveDirectory.Id) -Id:($global:PesterTestUser.Id) -Op:('add') -Type:('user') } | Should -Not -Throw
    }

    It 'Set' -skip {
        { Set-JcSdkActiveDirectoryAssociation -ActivedirectoryId:($global:PesterTestActiveDirectory.Id) -Body:($global:PesterTestActiveDirectoryAssociation) } | Should -Not -Throw
    }

    It 'SetViaIdentity' -skip {
        { Set-JcSdkActiveDirectoryAssociation -Body:($global:PesterTestActiveDirectoryAssociation) -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { Set-JcSdkActiveDirectoryAssociation -Id:($global:PesterTestUser.Id) -InputObject '<IJumpCloudApIsIdentity>' -Op:('add') -Type:('user') [-Attributes '<Hashtable>'] } | Should -Not -Throw
    }
}
