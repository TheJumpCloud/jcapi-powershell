$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkOffice365TraverseUserGroup.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-JcSdkOffice365TraverseUserGroup' {
    BeforeAll {
        Set-JcSdkOffice365Association -Office365Id $($global:PesterTestOffice365.Id) -Id $($global:PesterTestUserGroup.Id) -Op 'add' -Type 'user_group'
    }
    AfterAll {
        Set-JcSdkOffice365Association -Office365Id $($global:PesterTestOffice365.Id) -Id $($global:PesterTestUserGroup.Id) -Op 'remove' -Type 'user_group'
    }
    It 'List' {
        Get-JcSdkOffice365TraverseUserGroup -Office365Id $($global:PesterTestOffice365.Id) | Should -Not -BeNullOrEmpty
    }
}
