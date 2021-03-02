$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkGSuiteTraverseUser.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-JcSdkGSuiteTraverseUser' {
    BeforeAll {
        Set-JcSdkGSuiteAssociation -GsuiteId $($global:PesterTestGsuite.Id) -Id $($global:PesterTestUser.Id) -Op 'add' -Type 'user'
    }
    AfterAll {
        Set-JcSdkGSuiteAssociation -GsuiteId $($global:PesterTestGsuite.Id) -Id $($global:PesterTestUser.Id) -Op 'remove' -Type 'user'
    }
    It 'List' {
        Get-JcSdkGSuiteTraverseUser -GsuiteId $($global:PesterTestGsuite.Id) | Should -Not -BeNullOrEmpty
    }
}
