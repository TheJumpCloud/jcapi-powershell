$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'New-JcSdkPolicyGroup.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'New-JcSdkPolicyGroup' {
    It 'NewExpanded' -skip {
        { New-JcSdkPolicyGroup -Name:($global:PesterTestPolicyGroup.Name) } | Should -Not -Throw
    }

    It 'New' -skip {
        { New-JcSdkPolicyGroup -Body:($global:PesterTestPolicyGroup) } | Should -Not -Throw
    }
}
