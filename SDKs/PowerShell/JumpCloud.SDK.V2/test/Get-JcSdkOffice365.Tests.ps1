$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath))
{
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkOffice365.Recording.json'
$currentPath = $PSScriptRoot
while (-not $mockingPath)
{
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-JcSdkOffice365' {
    It 'Get' {
        Get-JcSdkOffice365 -Office365Id $($global:PesterTestOffice365.id) | Should -Not -BeNullOrEmpty
    }

    It 'GetViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
