BeforeAll {
    $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
    if (-Not (Test-Path -Path $loadEnvPath)) {
        $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
    }
    . ($loadEnvPath)
    $TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkEventInterval.Recording.json'
    $currentPath = $PSScriptRoot
    while(-not $mockingPath) {
        $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
        $currentPath = Split-Path -Path $currentPath -Parent
    }
    . ($mockingPath | Select-Object -First 1).FullName
}
Describe 'Get-JcSdkEventInterval' {
    # TODO: endpoint never returns data
    It 'GetExpanded' -skip {
        { Get-JcSdkEventInterval -IntervalUnit '<String>' -Service:('all') -StartTime:((Get-Date).AddHours(-24).ToUniversalTime()) } | Should -Not -Throw
    }

    It 'Get' -skip {
        { Get-JcSdkEventInterval -Body:(@{Service = 'all'; StartTime = (Get-Date).AddHours(-24).ToUniversalTime();}) } | Should -Not -Throw
    }
}
