$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkGSuiteAssociation.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-JcSdkGSuiteAssociation' {
    BeforeAll{
        Set-JcSdkGSuiteAssociation -GsuiteId $($global:PesterTestGSuite.Id) -Id $($global:PesterTestUser.id) -op add -type user
    }
    AfterAll{
        Set-JcSdkGSuiteAssociation -GsuiteId $($global:PesterTestGSuite.Id) -Id $($global:PesterTestUser.id) -op remove -type user
    }
    It 'List' {
        Get-JcSdkGSuiteAssociation -GsuiteId $($global:PesterTestGSuite.Id) -Targets user
    }
}
