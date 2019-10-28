$TestRecordingFile = Join-Path $PSScriptRoot 'Send-JcSdkUserEmail.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Send-JcSdkUserEmail' {
    It 'SendExpanded' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Send' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'SendViaIdentityExpanded' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'SendViaIdentity' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
