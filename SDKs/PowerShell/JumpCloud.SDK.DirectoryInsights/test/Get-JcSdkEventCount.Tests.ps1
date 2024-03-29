BeforeAll{
    $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
    if (-Not (Test-Path -Path $loadEnvPath)) {
        $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
    }
    . ($loadEnvPath)
    $TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkEventCount.Recording.json'
    $currentPath = $PSScriptRoot
    while(-not $mockingPath) {
        $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
        $currentPath = Split-Path -Path $currentPath -Parent
    }
    . ($mockingPath | Select-Object -First 1).FullName
}
Describe 'Get-JcSdkEventCount' -Tag:(""){
    It 'GetExpanded' {
        { Get-JcSdkEventCount -Service:('all') -StartTime:((Get-Date).AddHours(-24).ToUniversalTime()) } | Should -Not -Throw
    }

    It 'Get' {
        { Get-JcSdkEventCount -Body:(@{Service = 'all'; StartTime = (Get-Date).AddHours(-24).ToUniversalTime();}) } | Should -Not -Throw
    }
}
