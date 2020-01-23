$TestRecordingFile = Join-Path $PSScriptRoot 'Import-JcSdkWorkdayResult.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Import-JcSdkWorkdayResult' {
    It 'Import' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'ImportViaIdentity' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
