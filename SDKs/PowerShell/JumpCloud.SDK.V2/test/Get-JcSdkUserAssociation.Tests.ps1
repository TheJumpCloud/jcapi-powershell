$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkUserAssociation.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-JcSdkUserAssociation' {
    It 'Get' {
        Get-JcSdkUserAssociation -Targets '<String>' -UserId '<String>' | Should -Not -BeNullOrEmpty
    }

    It 'GetViaIdentity' -skip {
        Get-JcSdkUserAssociation -InputObject '<IJumpCloudApIsIdentity>' -Targets '<String>' | Should -Not -BeNullOrEmpty
    }
}
