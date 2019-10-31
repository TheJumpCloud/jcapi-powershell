$TestRecordingFile = Join-Path $PSScriptRoot 'Update-JcSdkBulkJobRequestBulkUser.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Update-JcSdkBulkJobRequestBulkUser' {
    It 'Update' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
