$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath))
{
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkApplicationTemplate.Recording.json'
$currentPath = $PSScriptRoot
while (-not $mockingPath)
{
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-JcSdkApplicationTemplate' {
    It 'List' {
        Get-JcSdkApplicationTemplate | Should -Not -BeNullOrEmpty
    }

    It 'Get' -Skip {
        $ListResults = Get-JcSdkApplicationTemplate # Need to pull from global

        Get-JcSdkApplicationTemplate -Id:($ListResults[0].Id) | Should -Not -BeNullOrEmpty
    }

    It 'GetViaIdentity' -Skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
