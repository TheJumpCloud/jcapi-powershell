$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkOffice365TraverseUser.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-JcSdkOffice365TraverseUser' {
    BeforeAll {
        Set-JcSdkOffice365Association -Office365Id $($global:PesterTestOffice365.Id) -Id $($global:PesterTestUser.Id) -Op 'add' -Type 'user'
    }
    AfterAll {
        Set-JcSdkOffice365Association -Office365Id $($global:PesterTestOffice365.Id) -Id $($global:PesterTestUser.Id) -Op 'remove' -Type 'user'
    }
    It 'List' {
        Get-JcSdkOffice365TraverseUser -Office365Id $($global:PesterTestOffice365.Id) | Should -Not -BeNullOrEmpty
    }
}
