$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkEventDistinct.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-JcSdkEventDistinct' {
    It 'GetExpanded' -skip {
        { Get-JcSdkEventDistinct -Service:('all') -StartTime:((Get-Date).AddHours(-24).ToUniversalTime()) } | Should -Not -Throw
    }

    It 'Get' -skip {
        { Get-JcSdkEventDistinct -Body:(@{Service = 'all'; StartTime = (Get-Date).AddHours(-24).ToUniversalTime();}) } | Should -Not -Throw
    }
}
