$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-JcSdkSystemPostSystem.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Invoke-JcSdkSystemPostSystem' {
    It 'Systems' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Systems1' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Systems2' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Systems3' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'SystemsViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'SystemsViaIdentity1' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'SystemsViaIdentity2' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'SystemsViaIdentity3' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
