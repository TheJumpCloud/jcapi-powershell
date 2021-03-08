$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath))
{
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkEventDistinct.Recording.json'
$currentPath = $PSScriptRoot
while (-not $mockingPath)
{
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-JcSdkEventDistinct' {
    It 'GetExpanded' -Skip {
        # TODO: documentation needs updating
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get' -Skip {
        # TODO: documentation needs updating
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
