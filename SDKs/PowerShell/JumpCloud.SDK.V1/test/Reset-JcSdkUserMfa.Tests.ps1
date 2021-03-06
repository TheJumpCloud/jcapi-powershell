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
    It 'ResetExpanded' -skip {
        { Reset-JcSdkUserMfa -Id:($global:PesterTestUser.Id) [-Exclusion] [-ExclusionUntil '<DateTime>'] } | Should -Not -Throw
    }

    It 'Reset' -skip {
        { Reset-JcSdkUserMfa -Body:($global:PesterTestUser) -Id:($global:PesterTestUser.Id) } | Should -Not -Throw
    }

    It 'ResetViaIdentity' -skip {
        { Reset-JcSdkUserMfa -Body:($global:PesterTestUser) -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'ResetViaIdentityExpanded' -skip {
        { Reset-JcSdkUserMfa -InputObject '<IJumpCloudApIsIdentity>' [-Exclusion] [-ExclusionUntil '<DateTime>'] } | Should -Not -Throw
    }
}
