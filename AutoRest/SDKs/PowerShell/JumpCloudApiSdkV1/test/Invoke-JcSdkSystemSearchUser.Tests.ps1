$TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-JcSdkSystemSearchUser.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Invoke-JcSdkSystemSearchUser' {
    It 'SystemExpanded' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'System' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
