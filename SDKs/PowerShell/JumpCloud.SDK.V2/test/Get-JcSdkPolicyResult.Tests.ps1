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
    It 'List1' -skip {
        Get-JcSdkPolicyResult  | Should -Not -BeNullOrEmpty
    }

    It 'Get' {
        Get-JcSdkPolicyResult -Id:($global:PesterTestPolicyResult.Id) | Should -Not -BeNullOrEmpty
    }

    It 'GetViaIdentity' -skip {
        Get-JcSdkPolicyResult -InputObject '<IJumpCloudApIsIdentity>' | Should -Not -BeNullOrEmpty
    }

    It 'List' {
        Get-JcSdkPolicyResult | Should -Not -BeNullOrEmpty
    }
}
