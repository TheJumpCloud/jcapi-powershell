$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkActiveDirectoryAssociation.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-JcSdkActiveDirectoryAssociation' {
    BeforeAll{
        Set-JcSdkActiveDirectoryAssociation -ActivedirectoryId $($global:PesterTestActiveDirectory.Id) -Id $($global:PesterTestUser.Id) -Op 'add' -Type 'user'
    }
    AfterAll{
        Set-JcSdkActiveDirectoryAssociation -ActivedirectoryId $($global:PesterTestActiveDirectory.Id) -Id $($global:PesterTestUser.Id) -Op 'remove' -Type 'user'
    }
    It 'List' -skip {
        #TODO: Test fails
        Get-JcSdkActiveDirectoryAssociation -ActivedirectoryId $($global:PesterTestActiveDirectory.Id) -Targets 'User' | Should -not -BeNullOrEmpty
    }
}
