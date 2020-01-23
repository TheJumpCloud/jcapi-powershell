$TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-JcSdkOffice365GetSOffice365.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Invoke-JcSdkOffice365GetSOffice365' {
    It 'Office365' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Office365ViaIdentity' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
