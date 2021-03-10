$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkUserTraverseSystem.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-JcSdkUserTraverseSystem' {
    It 'Get' {
        Get-JcSdkUserTraverseSystem -UserId '<String>' | Should -Not -BeNullOrEmpty
    }

    It 'GetViaIdentity' -skip {
        Get-JcSdkUserTraverseSystem -InputObject '<IJumpCloudApIsIdentity>' | Should -Not -BeNullOrEmpty
    }
}
