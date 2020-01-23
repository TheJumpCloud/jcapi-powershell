$TestRecordingFile = Join-Path $PSScriptRoot 'Unlock-JcSdkSystemUser.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Unlock-JcSdkSystemUser' {
    It 'Unlock' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UnlockViaIdentity' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
