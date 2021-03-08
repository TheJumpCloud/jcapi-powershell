$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkPolicyTraverseSystemGroup.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-JcSdkPolicyTraverseSystemGroup' {
    BeforeAll {
        Set-JcSdkPolicyAssociation -PolicyId $($global:PesterTestWindowsPolicy.Id) -Id $($global:PesterTestSystemGroup.id) -op add -type system_group
        Set-JcSdkPolicyAssociation -PolicyId $($global:PesterTestLinuxPolicy.Id) -Id $($global:PesterTestSystemGroup.id) -op add -type system_group
        Set-JcSdkPolicyAssociation -PolicyId $($global:PesterTestDarwinPolicy.Id) -Id $($global:PesterTestSystemGroup.id) -op add -type system_group
    }
    AfterAll {
        Set-JcSdkPolicyAssociation -PolicyId $($global:PesterTestWindowsPolicy.Id) -Id $($global:PesterTestSystemGroup.id) -op remove -type system_group
        Set-JcSdkPolicyAssociation -PolicyId $($global:PesterTestLinuxPolicy.Id) -Id $($global:PesterTestSystemGroup.id) -op remove -type system_group
        Set-JcSdkPolicyAssociation -PolicyId $($global:PesterTestDarwinPolicy.Id) -Id $($global:PesterTestSystemGroup.id) -op remove -type system_group
    }
    It 'List' {
        Get-JcSdkPolicyTraverseSystemGroup -PolicyId $($global:PesterTestWindowsPolicy.Id) | Should -Not -BeNullOrEmpty
        Get-JcSdkPolicyTraverseSystemGroup -PolicyId $($global:PesterTestLinuxPolicy.Id) | Should -Not -BeNullOrEmpty
        Get-JcSdkPolicyTraverseSystemGroup -PolicyId $($global:PesterTestDarwinPolicy.Id) | Should -Not -BeNullOrEmpty
    }
}
