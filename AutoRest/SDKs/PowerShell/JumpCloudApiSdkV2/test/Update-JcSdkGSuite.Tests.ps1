$TestRecordingFile = Join-Path $PSScriptRoot 'Update-JcSdkGSuite.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Update-JcSdkGSuite' {
    It 'PatchExpanded' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Patch' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'PatchViaIdentityExpanded' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'PatchViaIdentity' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
