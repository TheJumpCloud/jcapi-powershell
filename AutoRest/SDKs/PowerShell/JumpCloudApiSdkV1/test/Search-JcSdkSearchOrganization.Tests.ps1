$TestRecordingFile = Join-Path $PSScriptRoot 'Search-JcSdkSearchOrganization.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Search-JcSdkSearchOrganization' {
    It 'SearchExpanded' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Search' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
