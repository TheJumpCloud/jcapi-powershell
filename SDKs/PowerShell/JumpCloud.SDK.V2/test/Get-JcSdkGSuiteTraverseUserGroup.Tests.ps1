$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkGSuiteTraverseUserGroup.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-JcSdkGSuiteTraverseUserGroup' {
    BeforeAll {
        Set-JcSdkGSuiteAssociation -GsuiteId $($global:PesterTestGSuite.Id) -Id $($global:PesterTestUserGroup.Id) -Op 'add' -Type 'user_group'
    }
    AfterAll {
        Set-JcSdkGSuiteAssociation -GsuiteId $($global:PesterTestGSuite.Id) -Id $($global:PesterTestUserGroup.Id) -Op 'remove' -Type 'user_group'
    }
    It 'List' {
        Get-JcSdkGSuiteTraverseUserGroup -GsuiteId $($global:PesterTestGSuite.Id) | Should -Not -BeNullOrEmpty
    }
}
