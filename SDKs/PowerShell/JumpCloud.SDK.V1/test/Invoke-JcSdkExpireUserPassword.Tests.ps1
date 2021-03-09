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
    It 'Post' -Skip {
        { Invoke-JcSdkExpireUserPassword -Id '<String>' } | Should -Not -Throw
    }

    It 'PostViaIdentity' -Skip {
        { Invoke-JcSdkExpireUserPassword -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }
}
