$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkPolicyAssociation.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-JcSdkPolicyAssociation' {
    BeforeAll {
        Set-JcSdkPolicyAssociation -PolicyId $($global:PesterTestWindowsPolicy.Id) -Id $($global:PesterTestSystem.id) -op add -type system
        Set-JcSdkPolicyAssociation -PolicyId $($global:PesterTestLinuxPolicy.Id) -Id $($global:PesterTestSystem.id) -op add -type system
        Set-JcSdkPolicyAssociation -PolicyId $($global:PesterTestDarwinPolicy.Id) -Id $($global:PesterTestSystem.id) -op add -type system
    }
    AfterAll {
        Set-JcSdkPolicyAssociation -PolicyId $($global:PesterTestWindowsPolicy.Id) -Id $($global:PesterTestSystem.id) -op remove -type system
        Set-JcSdkPolicyAssociation -PolicyId $($global:PesterTestLinuxPolicy.Id) -Id $($global:PesterTestSystem.id) -op remove -type system
        Set-JcSdkPolicyAssociation -PolicyId $($global:PesterTestDarwinPolicy.Id) -Id $($global:PesterTestSystem.id) -op remove -type system
    }
    It 'List' {
        Get-JcSdkPolicyAssociation -PolicyId $($global:PesterTestWindowsPolicy.Id) -targets system | Should -Not -BeNullOrEmpty
        Get-JcSdkPolicyAssociation -PolicyId $($global:PesterTestLinuxPolicy.Id) -targets system | Should -Not -BeNullOrEmpty
        Get-JcSdkPolicyAssociation -PolicyId $($global:PesterTestDarwinPolicy.Id) -targets system | Should -Not -BeNullOrEmpty
    }
}
