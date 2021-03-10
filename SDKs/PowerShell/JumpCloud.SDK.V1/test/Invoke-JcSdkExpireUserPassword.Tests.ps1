$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-JcSdkExpireUserPassword.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Invoke-JcSdkExpireUserPassword' {
    It 'Post' -skip {
        { Invoke-JcSdkExpireUserPassword -Id:($global:PesterTestExpireUserPassword.Id) } | Should -Not -Throw
    }

    It 'PostViaIdentity' -skip {
        { Invoke-JcSdkExpireUserPassword -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }
}
