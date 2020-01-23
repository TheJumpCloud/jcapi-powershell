$TestRecordingFile = Join-Path $PSScriptRoot 'Set-JcSdkSystemGroupAssociation.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Set-JcSdkSystemGroupAssociation' {
    It 'SetExpanded' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Set' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'SetViaIdentity' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
