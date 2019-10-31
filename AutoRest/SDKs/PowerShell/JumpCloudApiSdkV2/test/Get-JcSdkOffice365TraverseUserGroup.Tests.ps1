$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkOffice365TraverseUserGroup.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-JcSdkOffice365TraverseUserGroup' {
    It 'List' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
