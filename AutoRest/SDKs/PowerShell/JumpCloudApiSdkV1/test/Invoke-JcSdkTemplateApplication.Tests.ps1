$TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-JcSdkTemplateApplication.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Invoke-JcSdkTemplateApplication' {
    It 'Templates' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Templates1' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'TemplatesViaIdentity' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
