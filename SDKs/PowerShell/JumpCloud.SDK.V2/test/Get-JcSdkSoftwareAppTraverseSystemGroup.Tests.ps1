$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkSoftwareAppTraverseSystemGroup.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-JcSdkSoftwareAppTraverseSystemGroup' {
    BeforeAll {
        Set-JcSdkSoftwareAppAssociation -SoftwareAppId $($global:PesterTestSoftwareApp.Id) -Id $($global:PesterTestSystemGroup.Id) -Op 'add' -Type 'system_group'
    }
    AfterAll {
        Set-JcSdkSoftwareAppAssociation -SoftwareAppId $($global:PesterTestSoftwareApp.Id) -Id $($global:PesterTestSystemGroup.Id) -Op 'remove' -Type 'system_group'
    }
    It 'Get' {
        Get-JcSdkSoftwareAppTraverseSystemGroup -SoftwareAppId $($global:PesterTestSoftwareApp.Id) | Should -Not -BeNullOrEmpty
    }

    It 'GetViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
