$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'New-JcSdkSoftwareApp.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'New-JcSdkSoftwareApp' {
    It 'CreateExpanded' {
        $global:PesterTestSoftwareApp = New-JcSdkSoftwareApp @global:PesterDefSoftwareApp
        $global:PesterTestSoftwareApp | Should -Not -BeNullOrEmpty
    }

    It 'Create' -skip {
        New-JcSdkSoftwareApp -Body '<ISoftwareApp>' | Should -Not -BeNullOrEmpty
    }
}
