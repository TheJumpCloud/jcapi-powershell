$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'New-JcSdkSystemGroup.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'New-JcSdkSystemGroup' {
    It 'CreateExpanded' {
        $global:PesterTestSystemGroup = New-JcSdkSystemGroup @global:PesterDefSystemGroup
        $global:PesterTestSystemGroup | Should -Not -BeNullOrEmpty
    }

    It 'Create' -skip {
        { New-JcSdkSystemGroup -Body:($global:PesterTestSystemGroup) } | Should -Not -Throw
    }
}
