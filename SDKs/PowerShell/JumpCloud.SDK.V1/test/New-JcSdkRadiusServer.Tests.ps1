$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'New-JcSdkRadiusServer.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'New-JcSdkRadiusServer' {
    It 'CreateExpanded' {
        Do { $global:PesterTestRadiusServer = New-JcSdkRadiusServer @global:PesterDefRadiusServer } While ([System.String]::IsNullOrEmpty($global:PesterTestRadiusServer))
        $global:PesterTestRadiusServer | Should -Not -BeNullOrEmpty
    }

    It 'Create' -Skip {
        New-JcSdkRadiusServer -Body '<IRadiusserverpost>' | Should -Not -BeNullOrEmpty
    }
}
