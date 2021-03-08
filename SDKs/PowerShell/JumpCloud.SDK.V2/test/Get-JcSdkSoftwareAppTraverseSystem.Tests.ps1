$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkSoftwareAppTraverseSystem.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-JcSdkSoftwareAppTraverseSystem' {
    BeforeAll {
        Set-JcSdkSoftwareAppAssociation -SoftwareAppId $($global:PesterTestSoftwareApp.Id) -Id $($global:PesterTestSystem.Id) -Op 'add' -Type 'system'
    }
    AfterAll {
        Set-JcSdkSoftwareAppAssociation -SoftwareAppId $($global:PesterTestSoftwareApp.Id) -Id $($global:PesterTestSystem.Id) -Op 'remove' -Type 'system'
    }
    It 'Get' {
        Get-JcSdkSoftwareAppTraverseSystem -SoftwareAppId $($global:PesterTestSoftwareApp.Id) | Should -Not -BeNullOrEmpty
    }
    It 'GetViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
