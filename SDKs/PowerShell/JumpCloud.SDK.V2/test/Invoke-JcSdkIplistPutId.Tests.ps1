$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-JcSdkIplistPutId.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Invoke-JcSdkIplistPutId' {
    It 'IplistsExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Iplists' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'IplistsViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'IplistsViaIdentityExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}