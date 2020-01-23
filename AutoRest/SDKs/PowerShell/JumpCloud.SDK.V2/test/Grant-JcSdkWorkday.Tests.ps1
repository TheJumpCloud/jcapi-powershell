$TestRecordingFile = Join-Path $PSScriptRoot 'Grant-JcSdkWorkday.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Grant-JcSdkWorkday' {
    It 'AuthorizeExpanded' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Authorize' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'AuthorizeViaIdentityExpanded' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'AuthorizeViaIdentity' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
