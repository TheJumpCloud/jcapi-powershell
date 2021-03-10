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
        { Set-JcSdkActiveDirectoryAssociation -ActivedirectoryId:($global:PesterTestActiveDirectory.Id) -Id:($global:PesterTestActiveDirectoryAssociation.Id) -Op '<String>' -Type '<String>' } | Should -Not -Throw
    }

    It 'Set' -skip {
        { Set-JcSdkActiveDirectoryAssociation -ActivedirectoryId:($global:PesterTestActiveDirectory.Id) -Body '<IGraphOperationActiveDirectory>' } | Should -Not -Throw
    }

    It 'SetViaIdentity' -skip {
        { Set-JcSdkActiveDirectoryAssociation -Body '<IGraphOperationActiveDirectory>' -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { Set-JcSdkActiveDirectoryAssociation -Id:($global:PesterTestActiveDirectoryAssociation.Id) -InputObject '<IJumpCloudApIsIdentity>' -Op '<String>' -Type '<String>' } | Should -Not -Throw
    }
}
