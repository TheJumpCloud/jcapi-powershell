$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkPolicyResult.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-JcSdkPolicyResult' {
    # BeforeAll {
    #     Set-JcSdkPolicyAssociation -PolicyId $($global:PesterTestWindowsPolicy.Id) -Id $($global:PesterTestSystem.id) -op add -type system
    #     Set-JcSdkPolicyAssociation -PolicyId $($global:PesterTestLinuxPolicy.Id) -Id $($global:PesterTestSystem.id) -op add -type system
    #     Set-JcSdkPolicyAssociation -PolicyId $($global:PesterTestDarwinPolicy.Id) -Id $($global:PesterTestSystem.id) -op add -type system
    # }
    # AfterAll {
    #     Set-JcSdkPolicyAssociation -PolicyId $($global:PesterTestWindowsPolicy.Id) -Id $($global:PesterTestSystem.id) -op remove -type system
    #     Set-JcSdkPolicyAssociation -PolicyId $($global:PesterTestLinuxPolicy.Id) -Id $($global:PesterTestSystem.id) -op remove -type system
    #     Set-JcSdkPolicyAssociation -PolicyId $($global:PesterTestDarwinPolicy.Id) -Id $($global:PesterTestSystem.id) -op remove -type system
    # }
    It 'List1' -skip {
        # This endpoint returns all policies results for an organization.
        # TODO: Value was either too large or too small for an Int32.
        Get-JcSdkPolicyResult | Should -Not -BeNullOrEmpty
    }

    It 'Get' -skip {
        # TODO: depending on the pester system apply a policy, wait for policy to be applied, then test
        $policyResultWindow = Get-JcSdkPolicyResult -policyId $($global:PesterTestWindowsPolicy.Id) | Select-Object -First 1
        Get-JcSdkPolicyResult -id $policyResultWindow.id | Should -Not -BeNullOrEmpty
        $policyResultLinux = Get-JcSdkPolicyResult -policyId $($global:PesterTestLinuxPolicy.Id) | Select-Object -First 1
        Get-JcSdkPolicyResult -id $policyResultLinux.id | Should -Not -BeNullOrEmpty
        $policyResultMac = Get-JcSdkPolicyResult -policyId $($global:PesterTestDarwinPolicy.Id) | Select-Object -First 1
        Get-JcSdkPolicyResult -id $policyResultMac.id | Should -Not -BeNullOrEmpty
    }

    It 'GetViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'List' -skip {
        # TODO: depending on the pester system apply a policy, wait for policy to be applied, then test
        Get-JcSdkPolicyResult -policyId $($global:PesterTestWindowsPolicy.Id) | Should -Not -BeNullOrEmpty
        Get-JcSdkPolicyResult -policyId $($global:PesterTestLinuxPolicy.Id) | Should -Not -BeNullOrEmpty
        Get-JcSdkPolicyResult -policyId $($global:PesterTestDarwinPolicy.Id) | Should -Not -BeNullOrEmpty
    }
}
