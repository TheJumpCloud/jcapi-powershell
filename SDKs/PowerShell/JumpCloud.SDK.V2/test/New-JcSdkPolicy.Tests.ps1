BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'New-JcSdkPolicy.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'New-JcSdkPolicy' -Tag:(""){
    It 'CreateExpanded' {
        $global:PesterTestPolicy = New-JcSdkPolicy @global:PesterDefPolicy
        $global:PesterTestPolicy | Should -Not -BeNullOrEmpty
    }

    It 'Create' -skip {
        { New-JcSdkPolicy -Body:($global:PesterTestPolicy) } | Should -Not -Throw
    }
}

