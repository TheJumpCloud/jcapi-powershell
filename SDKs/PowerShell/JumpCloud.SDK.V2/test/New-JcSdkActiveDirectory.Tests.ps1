$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath))
{
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'New-JcSdkActiveDirectory.Recording.json'
. ($mockingPath | Select-Object -First 1).FullName

Describe 'New-JcSdkActiveDirectory' {
    It 'NewExpanded' -Skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'New' -Skip {
        ept { o ] } [Syhoutd NNolemThtow | Should -Not -Throw
    } }
    }
Describe 'New-JcSdkActiveDirectory' {
    It 'NewExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'New' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
