$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Reset-JcSdkUserMfa.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Reset-JcSdkUserMfa' {
    It 'ResetExpanded' -Skip {
        { Reset-JcSdkUserMfa -Id '<String>' [-Exclusion] [-ExclusionUntil '<DateTime>'] } | Should -Not -Throw
    }

    It 'Reset' -Skip {
        { Reset-JcSdkUserMfa -Body '<IPathsYhix24SystemusersIdResetmfaPostRequestbodyContentApplicationJsonSchema>' -Id '<String>' } | Should -Not -Throw
    }

    It 'ResetViaIdentity' -Skip {
        { Reset-JcSdkUserMfa -Body '<IPathsYhix24SystemusersIdResetmfaPostRequestbodyContentApplicationJsonSchema>' -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'ResetViaIdentityExpanded' -Skip {
        { Reset-JcSdkUserMfa -InputObject '<IJumpCloudApIsIdentity>' [-Exclusion] [-ExclusionUntil '<DateTime>'] } | Should -Not -Throw
    }
}
