$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkUserTraverseApplication.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-JcSdkUserTraverseApplication' {
    It 'Get' {
        { Get-JcSdkUserTraverseApplication -UserId:($global:PesterTestUser.Id) } | Should -Not -Throw
    }

    It 'GetViaIdentity' -skip {
        Get-JcSdkUserTraverseApplication -InputObject '<IJumpCloudApIsIdentity>' | Should -Not -BeNullOrEmpty
    }
}
