$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'New-JcSdkApplication.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'New-JcSdkApplication' {
    It 'CreateExpanded' -skip {
        $global:PesterTestApplication = New-JcSdkApplication @global:PesterDefApplication
        $global:PesterTestApplication | Should -Not -BeNullOrEmpty
    }

    It 'Create' -skip {
        { New-JcSdkApplication -Body:($global:PesterTestApplication) } | Should -Not -Throw
    }
}
