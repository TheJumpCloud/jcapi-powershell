$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath))
{
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Clear-JcSdkSystem.Recording.json'
$currentPath = $PSScriptRoot
while (-not $mockingPath)
{
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Clear-JcSdkSystem' {
    It 'Clear' -Skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'ClearViaIdentity' -Skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
