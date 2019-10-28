$TestRecordingFile = Join-Path $PSScriptRoot 'New-JcSdkAppleMdm.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'New-JcSdkAppleMdm' {
    It 'NewExpanded' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'New' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
