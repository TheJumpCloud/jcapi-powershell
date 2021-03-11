$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath))
{
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkAppleMdmCsr.Recording.json'
$currentPath = $PSScriptRoot
while (-not $mockingPath)
{
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-JcSdkAppleMdmCsr' {
    It 'Get'  -skip {
        # TODO: Test Fails
        Get-JcSdkAppleMdmCsr -AppleMdmId $($global:PesterAppleMDM.id) | Should -Not -BeNullOrEmpty
    }

    It 'GetViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
