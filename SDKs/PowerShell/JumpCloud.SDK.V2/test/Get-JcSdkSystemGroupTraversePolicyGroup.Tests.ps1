$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
<<<<<<< HEAD:SDKs/PowerShell/JumpCloud.SDK.V2/test/New-JcSdkActiveDirectory.Tests.ps1
$TestRecordingFile = Join-Path $PSScriptRoot 'New-JcSdkActiveDirectory.Recording.json'
=======
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkSystemGroupTraversePolicyGroup.Recording.json'
>>>>>>> master:SDKs/PowerShell/JumpCloud.SDK.V2/test/Get-JcSdkSystemGroupTraversePolicyGroup.Tests.ps1
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

<<<<<<< HEAD:SDKs/PowerShell/JumpCloud.SDK.V2/test/New-JcSdkActiveDirectory.Tests.ps1
Describe 'New-JcSdkActiveDirectory' {
    It 'NewExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'New' -skip {
=======
Describe 'Get-JcSdkSystemGroupTraversePolicyGroup' {
    It 'Get' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'GetViaIdentity' -skip {
>>>>>>> master:SDKs/PowerShell/JumpCloud.SDK.V2/test/Get-JcSdkSystemGroupTraversePolicyGroup.Tests.ps1
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
