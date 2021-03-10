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
    It 'Post' {
        $global:PesterTestExpireUserPassword = Invoke-JcSdkExpireUserPassword @global:PesterDefExpireUserPassword
        $global:PesterTestExpireUserPassword | Should -Not -BeNullOrEmpty
    }

    It 'PostViaIdentity' -skip {
        Invoke-JcSdkExpireUserPassword -InputObject '<IJumpCloudApIsIdentity>' | Should -Not -BeNullOrEmpty
    }
}
